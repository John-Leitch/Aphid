
@echo off
echo ================================================================
echo Started building %BuildLoopTarget% %BuildLoopPlatform%
echo ================================================================

echo if not defined %%1 ( set %%1=%%2 ) > def.cmd


if not defined BuildLoopNames (
    SET BuildLoopNames=Debug BinaryTrace Release
)

SET BuildLoopSuffixes="" "32" "64"

call core\init.cmd

for %%c in (%BuildLoopNames%) do (
    for %%b in (%BuildLoopSuffixes%) do (
        %B% /p:Configuration=%%c%%~b /p:Platform="%BuildLoopPlatform%" %BuildLoopTarget% || goto ERROR
    )
)

echo ================================================================
echo Finished building %BuildLoopTarget% %BuildLoopPlatform%
echo ================================================================

goto EXIT
:ERROR
echo.
echo ================================================================
echo Error building %BuildLoopTarget% %BuildLoopPlatform%
echo ================================================================
:EXIT
@echo on