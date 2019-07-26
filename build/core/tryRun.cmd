@echo off
Setlocal EnableDelayedExpansion
for %%m in ("" ".Debug" ".BinaryTrace" ".ScriptDebugger.TimeTravel") do ^
for %%b in ("" "32" "64") do ^
for %%s in ("" "Portable") do (
    set aphid=%cd%\Aphid%%~b%%~m%%~s.exe
    echo Checking for !aphid!
    IF EXIST "!aphid!" (
        goto :break
    )
)
echo Could not find Aphid executable
@echo on
exit /b 5230

:break
echo Using Aphid binary at !aphid!
set errorlevel=
!aphid! %*

@echo on
exit /b errorlevel