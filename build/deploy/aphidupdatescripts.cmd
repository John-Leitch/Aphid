@echo off

REM set a=/E /Y /D /F /H /L
set a=/E /Y /D /F /H

set hr=call aphid64 *#'std';subhead('%%msg%%');
set hr=
set msg=Updating Application Scripts
%hr%

for %%i in (Samples Benchmarks) do (
    xcopy c:\source\aphid\Aphid\%%i\*.alx c:\tools\aphid\%%i\ %a%
)

set msg=Updating Library Scripts
%hr%


for %%d in (c:\tools\aphid c:\users\John\.vscode-insiders\extensions\ast.aphid-debug-0.0.1\bin\Debug) do (
    echo Cleaning %%d cache
    del /s /ah %%d\*.cache*
    for %%i in (Library Tools) do (
        echo Updating %%d\%%i
        xcopy c:\source\aphid\Components.Aphid\%%i\*.alx %%d\%%i\ %a%
    )
)

@echo on