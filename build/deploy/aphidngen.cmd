@echo off
cls 
set src=%~dp0..\..
set dst=c:\tools\aphid
set done=%dst%\aphidNgenDone.txt
set working=%cd%
goto TEST

:TEST

if "%1" neq "" (
    goto NGEN
) else (
    echo Checking for admin privileges
    %dst%\aphid64.exe %dst%\tools\IsAdmin.alx || goto NGEN
    echo Requesting admin privileges
    goto RUN_CHILD
)

::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:: Run Child Begin
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:RUN_CHILD
echo Starting child
del %done%
run.exe -admin cmd /c call %~f0 child & pause
echo Waiting
:WAIT
aphid64 * Thread.Sleep(10)

if exist %done% (
    echo Done waiting
    del %done%
    goto EXIT
) else (    
    goto WAIT
)
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:: Run Child End
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:: Run NGEN Begin
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:NGEN

echo Starting Ngen
pushd .
cd /d %dst%
for /f %%f in ('dir aphid*.exe /b') do %dst%\ngen.exe %cd%\%%f
::for /f %%i in ('dir /s %src%\Components.Aphid.*Test*.dll /b') do %dst%\Ngen.exe %%i
for /f %%i in ('dir /s %src%\*bin /b') do for /f %%a in ('dir %%i\*.dll /s /b') do ngen %%a
pushd .
for /f %%i in ('dir /s %src%\*bin /b') do for /f %%a in ('dir %i\*.dll /s /b') do cd /d %%~dpa & ngen %a
echo Done > %done%
popd
::pause

::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:: Run NGEN End
::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

:EXIT

@echo on