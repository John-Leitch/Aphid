pushd .
cd /d c:\source\aphid\build
call c:\source\Aphid\build\core\init.cmd 
msbuild ..\Aphid\Aphid.csproj /p:Configuration=Release64 /p:Platform=Default %MSBUILD_FIX%
popd