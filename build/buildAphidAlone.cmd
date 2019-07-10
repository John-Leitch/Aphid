pushd .
cd /d %~dp0
call core\init.cmd 
msbuild ..\Aphid\Aphid.csproj /p:Configuration=Release64 /p:Platform=Default %MSBUILD_FIX%
..\aphid\bin\release64\aphid64.exe ..\aphid\bin\release64\tools\ilmerge.alx
popd