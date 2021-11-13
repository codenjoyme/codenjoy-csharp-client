call 0-settings.bat

echo off
call lib :color Starting dotnet tests...
echo on

call %DOT_NET% test

call lib :ask