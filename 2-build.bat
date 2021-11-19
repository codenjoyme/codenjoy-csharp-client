call 0-settings.bat

echo off
call lib :color Building dotnet client...
echo on

call lib :print_color %DOTNET% -v

call %DOTNET% build

call lib :ask