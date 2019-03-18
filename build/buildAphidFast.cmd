::@echo off
call core\init.cmd

for %%c in (Debug BinaryTrace Release) do (
    for %%b in ("" "32" "64") do (
        msbuild /p:Configuration=%%c%%~b /p:Platform="Default" /m /r /maxcpucount ..\Aphid\Aphid.csproj || goto ERROR
    )
)

msbuild /p:Configuration=Release /p:Platform="x64" /m /r /maxcpucount ..\AphidUI\AphidUI.csproj || goto ERROR

call mergeAphid

echo ================================================================
echo Finished building Aphid
echo ================================================================

goto EXIT
:ERROR
echo.
echo ================================================================
echo Error building Aphid!
echo ================================================================
:EXIT
::@echo on