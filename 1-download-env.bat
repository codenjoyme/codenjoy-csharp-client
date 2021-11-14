call 0-settings.bat

echo off
call lib :color Installing dotnet...
echo on

if "%SKIP_NODE_INSTALL%"=="true" ( goto :skip )
if "%INSTALL_LOCALLY%"=="false" ( goto :skip )
if "%INSTALL_LOCALLY%"=="" ( goto :skip )

rem IF EXIST %TOOLS%\..\node_modules (
rem    rd /S /Q %TOOLS%\..\node_modules
rem )
call lib :install dotnet %ARCH_URL% %ARCH_FOLDER%
call lib :print_color %DOT_NET% -v

call lib :ask

goto :eof

:skip
	echo off
	call lib :color Installation skipped
	call lib :color INSTALL_LOCALLY=%INSTALL_LOCALLY%
	call lib :color SKIP_NODE_INSTALL=%SKIP_NODE_INSTALL%
	echo on
	call lib :ask
    goto :eof