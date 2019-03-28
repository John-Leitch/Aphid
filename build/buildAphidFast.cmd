@echo off
call core\init.cmd
set a=/m /p:BuildInParallel=true /r

for %%c in (Debug BinaryTrace Release) do (
    for %%b in ("" "32" "64") do (
        msbuild /p:Configuration=%%c%%~b /p:Platform="Default" %a% ..\Aphid\Aphid.csproj || goto ERROR
    )
)

msbuild /p:Configuration=Release /p:Platform="x64" %a% ..\AphidUI\AphidUI.csproj || goto ERROR

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
@echo on