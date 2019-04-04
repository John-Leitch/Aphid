@echo off
SETLOCAL ENABLEEXTENSIONS
SETLOCAL ENABLEDELAYEDEXPANSION
set nug=

for %%b in ("" "64") do (
    set ng=c:\windows\Microsoft.NET\Framework%%~b\v4.0.30319\ngen.exe
    echo ================================================================================
    if %%b equ "" (echo Uninstalling Assemblies) else (echo Uninstalling 64-bit Assemblies)
    echo ================================================================================
    for /F "usebackq delims=" %%i in (`!ng! display * ^| findstr /i /c:"%*"`) do !ng! uninstall "%%i"
    echo.
)

@echo on