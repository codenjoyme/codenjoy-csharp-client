call 0-settings.bat

echo off
call lib :color Building dotnet client...
echo on

call lib :print_color %DOT_NET% -v
call %DOT_NET% build

call lib :ask