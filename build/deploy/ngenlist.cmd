@echo off
SETLOCAL ENABLEEXTENSIONS
SETLOCAL ENABLEDELAYEDEXPANSION
set nug=

for %%b in ("" "64") do (
    set ng=c:\windows\Microsoft.NET\Framework%%~b\v4.0.30319\ngen.exe
    echo ================================================================================
    if %%b equ "" (echo Listing Assemblies) else (echo Listing 64-bit Assemblies)
    echo ================================================================================
    !ng! display * | findstr /i /c:"%*"
    echo.
)

@echo on