call 0-settings.bat

echo off
call lib :color Starting dotnet client...
echo on

call %DOT_NET% Dojo\bin\Debug\net6.0\Dojo.dll %GAME_TO_RUN% %BOARD_URL%

call lib :ask