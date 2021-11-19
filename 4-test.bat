call 0-settings.bat

echo off
call lib :color Starting dotnet tests...
echo on

call %DOTNET% test

rem to run tests for one game only
rem call %DOTNET% test --filter "TestCategory=%GAME_TO_RUN%"

call lib :ask