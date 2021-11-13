echo off
call lib :color Setup variables...
echo on

if "%GAME_TO_RUN%"=="" ( set GAME_TO_RUN=)
if "%BOARD_URL%"==""   ( set BOARD_URL=)

set ROOT=%CD%

if "%SKIP_TESTS%"=="" ( set SKIP_TESTS=true)

set CODE_PAGE=65001
chcp %CODE_PAGE%

set TOOLS=%ROOT%\.tools
set ARCH=%TOOLS%\7z\7za.exe

rem Set to true if you want to ignore node installation on the system
if "%INSTALL_LOCALLY%"=="" ( set INSTALL_LOCALLY=true)

if "%INSTALL_LOCALLY%"=="true" ( set NODE_HOME=)
if "%DOT_NET_HOME%"=="" ( set DOT_NET_HOME=%ROOT%\.dotnet)
set DOT_NET=%DOT_NET_HOME%\dotnet.exe

echo off
call lib :color DOT_NET_HOME=%DOT_NET_HOME%
echo on

set ARCH_URL=https://download.visualstudio.microsoft.com/download/pr/6b96c97d-9b8c-4141-a32a-5848d3369dbf/9972321cb7af5938fecdee2d8ebd72bb/dotnet-runtime-6.0.0-win-x64.zip
set ARCH_FOLDER=

set SCHARP_CLIENT_HOME=%ROOT%