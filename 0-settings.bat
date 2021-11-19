echo off
call lib :color Setup variables...
echo on

if "%GAME_TO_RUN%"=="" ( set GAME_TO_RUN=mollymage)
if "%BOARD_URL%"==""   ( set BOARD_URL=http://127.0.0.1:8080/codenjoy-contest/board/player/0?code=000000000000)

set ROOT=%CD%

if "%SKIP_TESTS%"==""  ( set SKIP_TESTS=true)

set CODE_PAGE=65001
chcp %CODE_PAGE%

set TOOLS=%ROOT%\.tools
set ARCH=%TOOLS%\7z\7za.exe

rem Set to true if you want to ignore dotnet installation on the system
if "%INSTALL_LOCALLY%"==""     ( set INSTALL_LOCALLY=true)

if "%INSTALL_LOCALLY%"=="true" ( set NODE_HOME=)

if "%DOTNET_HOME%"==""    ( set NO_DOTNET=true)
if "%NO_DOTNET%"=="true"  ( set DOTNET_HOME=%ROOT%\.dotnet)
if "%NO_DOTNET%"=="true"  ( set PATH=%DOTNET_HOME%\;%PATH%)

set DOTNET=%DOTNET_HOME%\dotnet.exe

echo off
call lib :color PATH=%PATH%
call lib :color DOTNET_HOME=%DOTNET_HOME%
echo on

set ARCH_URL=https://download.visualstudio.microsoft.com/download/pr/ca65b248-9750-4c2d-89e6-ef27073d5e95/05c682ca5498bfabc95985a4c72ac635/dotnet-sdk-6.0.100-win-x64.zip
set ARCH_FOLDER=

set SCHARP_CLIENT_HOME=%ROOT%