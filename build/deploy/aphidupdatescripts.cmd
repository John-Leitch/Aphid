@echo off

REM set a=/E /Y /D /F /H /L
set a=/E /Y /D /F /H

set hr=call aphid64 *#'std';subhead('%%msg%%');

set msg=Updating Application Scripts
%hr%

for %%i in (Samples Benchmarks) do (
    xcopy c:\source\aphid\Aphid\%%i\*.alx c:\tools\aphid\%%i\ %a%
)

set msg=Updating Library Scripts
%hr%

for %%i in (Library Tools) do (
    xcopy c:\source\aphid\Components.Aphid\%%i\*.alx c:\tools\aphid\%%i\ %a%
)

@echo on