This project represents a basic .Net6 with using websocket client for the codenjoy platform.
It allows you to easily and quickly join the game, developing your unique algorithm, having a configured infrastructure.

# What do I get started?
To get started, you should define the desired game and enter a value in `_game` variable of `Runner.cs` file. \
The second important thing is the connection token to the server. After successful authorization on the site, you must copy the url
and enter a value in `_url` variable of `Runner.cs` file. \
This is enough to connect and participate in the competition.

# How do I run it?
The are two options. \
If you have .Net 6.0 and Visual Studio, you can open `Project.sln`, then build run. \
If you do not have .Net 6.0 and Visual Studio, you need do following:
- open cmd.exe in client folder.
- execute `0-settings.bat`. This is sets up some needed varibles.
- execute `1-download-env.bat`. This downloads .Net6.0 portable version and unpack its.
- execute `2-build.bat`. This builds the projects.
- execute `3-run.bat`. This runs the project. You should see board game in the console and some stats.
 That's it!

# Where do I write code for the game?
Open `games/<gamename>/Solver`. Write your code in `private string Get(...)` method.

# How does it work?
The elements on the map are defined in `games/<gamename>/Element`. They determine the meaning of a particular symbol.
The two important components of the game are the `games/<gamename>/Board` board and the `games/<gamename>/Solver` solver.

Every second the server sends a string representation of the current state of the board, which is parsed in an object of class `Board`.
Then the server expects a string representation of your bot's action that is computed by executing `solver.Get(board)`.

Using the set of available methods of the `Board` class, you improve the algorithm of the bot's behavior.
You should develop this class, extending it with new methods that will be your tool in the fight.
For example, a bot can get information about an element in a specific coordinate by calling `gameBoard.getAt(pt)`
or count the number of elements of a certain type near the coordinate by calling `gameBoard.countNear(pt, elements[])`, etc.

# Business logic testing
Writing tests will allow you to create conclusive evidence of the correctness of the existing code. This is your faithful friend, who is always ready to answer the question: "Is everything working as I expect? The new code did not break my existing logic?".
The `games/<gamename>/BoardTest` class contains a set of tests that check board tools. Implementation of new methods should be accompanied by writing new tests and checking the results of processing existing ones.
Use `games/<gamename>/SolverTest` to check the bot's behavior for a specific game scenario.