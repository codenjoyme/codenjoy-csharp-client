/*-
 * #%L
 * Codenjoy - it's a dojo-like platform from developers to developers.
 * %%
 * Copyright (C) 2020 Codenjoy
 * %%
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as
 * published by the Free Software Foundation, either version 3 of the
 * License, or (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public
 * License along with this program.  If not, see
 * <http://www.gnu.org/licenses/gpl-3.0.html>.
 * #L%
 */
using Dojo.Games.Mollymage;
using System.Security.Authentication;
using WebSocketSharp;

namespace Dojo
{
    public class Runner
    {
        private const string _responsePrefix = "board=";

        private const int _maxRetriesCount = 3;
        private const int _retriestTimeoutInMilliseconds = 10000;

        private string _webSocketUrl;

        private int _retriesCount;
        private bool _shouldExit;

        private WebSocket _gameServer;

        // Select your game
        private string _game = "mollymage";

        // Paste here board page url from browser after registration,
        // or put it as command line parameter.
        private string _url = "https://dojorena.io/codenjoy-contest/board/player/dojorena762?code=1660136636364593901";

        private static bool IsAllowedToReconnect(ushort code)
        {
            var reconnectList = new List<ushort>
            {
                1006, // The connection was closed abnormally, e.g., without sending or receiving a Close control frame.
                1011 // A server is terminating the connection because it encountered an unexpected condition that prevented it from fulfilling the request.
            };

            return reconnectList.Contains(code);
        }

        public void Run(string[] args)
        {
            Console.WriteLine("+-----------------+");
            Console.WriteLine("| Starting runner |");
            Console.WriteLine("+-----------------+");

            if (args != null && args.Length == 2)
            {
                _game = args[0];
                _url = args[1];
                Console.WriteLine("Environment");
            }
            else
            {
                Console.WriteLine("Runner");
            }

            Console.WriteLine($"GAME: {_game}");
            Console.WriteLine($"URL: {_url}");

            // Console.OutputEncoding = Encoding.UTF8;
            _webSocketUrl = GetWebSocketUrl(_url);

            Play();

            Console.ReadKey();
        }

        /// <summary>
        /// Starts the web socket connection ang recieving board;
        /// </summary>
        public void Play()
        {
            _gameServer = new WebSocket(_webSocketUrl);
            _gameServer.SslConfiguration.EnabledSslProtocols = SslProtocols.Tls12;

            _gameServer.OnMessage += Socket_OnMessage;
            _gameServer.OnClose += async (s, e) => await ReconnectAsync(e.WasClean, e.Code);

            _gameServer.Connect();
        }

        /// <summary>
        /// Starts client shutdown.
        /// </summary>
        public void InitiateExit()
        {
            Console.WriteLine("Exit initiated...");

            _shouldExit = true;

            if (_gameServer.ReadyState == WebSocketState.Open)
            {
                _gameServer.Close();
            }
        }

        /// <summary>
        /// Convers game server URL to web socket URL.
        /// </summary>
        /// <param name="serverUrl">The game server URL.</param>
        /// <returns>The web socket URL.</returns>
        public string GetWebSocketUrl(string serverUrl)
        {
            return serverUrl.Replace("http", "ws")
                            .Replace("board/player/", "ws?user=")
                            .Replace("?code=", "&code=");
        }

        private void Socket_OnMessage(object? sender, MessageEventArgs e)
        {
            if (_shouldExit || sender is null)
            {
                return;
            }

            var response = e.Data;
            _retriesCount = 0;

            if (!response.StartsWith(_responsePrefix))
            {
                Console.WriteLine("Something strange is happening on the server... Response:\n{0}", response);
                InitiateExit();
            }
            else
            {
                var boardString = response.Substring(_responsePrefix.Length);

                var board = GetCameBoard(boardString);
                //Just print current state (gameBoard) to console
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine(board.ToString());

                var solver = GetGameSolver();
                var action = solver.Get(board);

                Console.WriteLine("Answer: " + action);
                Console.SetCursorPosition(0, 0);

                ((WebSocket)sender).Send(action);
            }
        }

        private ISolver GetGameSolver()
        {
            switch (_game.ToLowerInvariant())
            {
                case "mollymage":
                    return new Solver();
                    break;
                default:
                    throw new ArgumentException("This game wasn't implemented");
            }
        }

        private IBoard GetCameBoard(string boardString)
        {
            switch (_game.ToLowerInvariant())
            {
                case "mollymage":
                    return new Board(boardString);
                    break;
                default:
                    throw new ArgumentException("This game wasn't implemented");
            }
        }

        private async Task ReconnectAsync(bool wasClean, ushort code)
        {
            if (!wasClean && !_gameServer.IsAlive && IsAllowedToReconnect(code))
            {
                if (_retriesCount < _maxRetriesCount)
                {
                    Console.WriteLine($"Trying to recconnect, attempt {_retriesCount + 1} of {_maxRetriesCount}...");
                    await Task.Delay(_retriestTimeoutInMilliseconds);

                    _retriesCount++;
                    _gameServer.Connect();
                }
                else
                {
                    Console.WriteLine("Could not reconnect to the server, please try again later. Press any key to exit...");
                }
            }
        }
    }
}