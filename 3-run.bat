call 0-settings.bat

echo off
call lib :color Starting dotnet client...
echo on

call %DOTNET% Dojo\bin\Debug\net6.0\Dojo.dll %GAME_TO_RUN% %SERVER_URL%

call lib :ask