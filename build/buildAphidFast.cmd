@echo off
call core\init.cmd

for %%c in (Debug BinaryTrace Release) do (
    for %%b in ("" "32" "64") do (
        %B% /p:Configuration=%%c%%~b /p:Platform="Default" ..\Aphid\Aphid.csproj || goto ERROR
    )
)

%B% /p:Configuration=Release /p:Platform="x64" ..\AphidUI\AphidUI.csproj || goto ERROR

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