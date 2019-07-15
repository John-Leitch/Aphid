echo ================================================================
echo Creating Merged Binaries
echo ================================================================

pushd .
cd %~dp0

for /r ..\aphid\bin %%i in (aphid*portable*.*) do del %%i

for /f %%i in ('dir ..\Aphid\bin\*aphid*.exe /s /b') do (
    pushd .
    cd /d %%~dpi
    %%i tools\ILMerge.alx -unattended || exit bad80
    popd
)

popd