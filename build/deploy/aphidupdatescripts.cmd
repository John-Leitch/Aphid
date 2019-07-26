REM @echo off

REM REM set a=/E /Y /D /F /H /L
REM set a=/E /Y /D /F /H

REM set hr=call aphid64 *#'std';subhead('%%msg%%');
REM set hr=
REM set msg=Updating Application Scripts
REM %hr%

REM for %%i in (Samples Benchmarks) do (
REM     xcopy c:\source\aphid\Aphid\%%i\*.alx c:\tools\aphid\%%i\ %a%
REM )

REM set msg=Updating Library Scripts
REM %hr%


REM for %%d in (c:\tools\aphid) do (
REM     echo Cleaning %%d cache
REM     del /s /ah %%d\*.cache*
REM     for %%i in (Library Tools) do (
REM         echo Updating %%d\%%i
REM         xcopy c:\source\aphid\Components.Aphid\%%i\*.alx %%d\%%i\ %a%
REM     )
REM )

REM @echo on