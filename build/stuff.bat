@echo off

if "%RUN%"=="" set RUN=%CD%\run
if "%STUFF%"=="" set STUFF=%CD%\stuff

call %RUN% :init_colors

:check_run_mode
    if "%*"=="" (       
        call :run_executable 
    ) else (
        call :run_library %*
    )
    goto :eof

:run_executable
    rem run stuff.bat as executable script
    call %RUN% :color ‘%CL_INFO%‘ ‘This is not executable script. Please use 'run.bat' only.‘
    call %RUN% :ask   
    goto :eof

:run_library
    rem run stuff.bat as library
    call %*     
    goto :eof          

:settings
    if "%INSTALL_LOCALLY%"=="true" ( set NODE_HOME=)

    if "%DOTNET_HOME%"==""    ( set NO_DOTNET=true)
    if "%NO_DOTNET%"=="true"  ( set DOTNET_HOME=%ROOT%\.dotnet)
    if "%NO_DOTNET%"=="true"  ( set PATH=%DOTNET_HOME%\;%PATH%)

    set DOTNET=%DOTNET_HOME%\dotnet.exe

    echo Language environment variables
    call %RUN% :color ‘%CL_INFO%‘ ‘PATH=%PATH%‘
    call %RUN% :color ‘%CL_INFO%‘ ‘DOTNET_HOME=%DOTNET_HOME%‘

    set ARCH_URL=https://download.visualstudio.microsoft.com/download/pr/ca65b248-9750-4c2d-89e6-ef27073d5e95/05c682ca5498bfabc95985a4c72ac635/dotnet-sdk-6.0.100-win-x64.zip
    set ARCH_FOLDER=
    goto :eof

:install
    call %RUN% :install dotnet %ARCH_URL% %ARCH_FOLDER%
    goto :eof

:version
    call %RUN% :eval_echo_color ‘%DOTNET% --version‘
    goto :eof

:build
    call %RUN% :eval_echo ‘%DOTNET% build .‘
    goto :eof

:test
    call %RUN% :eval_echo ‘%DOTNET% test --verbosity minimal --list-tests .‘
    call %RUN% :eval_echo ‘%DOTNET% test --no-build --verbosity normal .‘

    rem to run tests for one game only
    rem call %RUN% :eval_echo ‘%DOTNET% test --filter “TestCategory=%GAME_TO_RUN%“‘
    goto :eof

:run
    call %RUN% :eval_echo ‘%DOTNET% .\Dojo\bin\Debug\net6.0\Dojo.dll %GAME_TO_RUN% %SERVER_URL%‘
    goto :eof