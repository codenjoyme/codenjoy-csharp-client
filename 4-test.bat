call 0-settings.bat

echo off
call lib :color Starting dotnet tests...
echo on


if "%GAME_TO_RUN%"=="" (call %DOT_NET% test) ELSE (call %DOT_NET% test --filter "TestCategory=%GAME_TO_RUN%")


call lib :ask