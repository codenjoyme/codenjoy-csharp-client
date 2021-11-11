using Dojo;

internal interface ISolver
{
    /// <summary>
    /// Should provide action for bot that will be sent back to game server, (quering each second).
    /// </summary>
    /// <param name="gameBoard">The Game board.</param>
    /// <returns>Action for the bot.</returns>
    public abstract string Get(IBoard gameBoard);
}