echo ================================================================
echo Creating Merged Binaries
echo ================================================================

for /r ..\aphid\bin %%i in (aphid*portable*.*) do del %%i

for /f %%i in ('dir ..\Aphid\bin\*aphid*.exe /s /b') do (
    pushd .
    cd %%~dpi
    %%i tools\ILMerge.alx -unattended
    popd
)