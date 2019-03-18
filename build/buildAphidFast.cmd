call core\init.cmd
msbuild /p:Configuration=Release64 /p:Platform="Default" /m /r /maxcpucount ..\Aphid\Aphid.csproj
msbuild /p:Configuration=Release /p:Platform="x64" /m /r /maxcpucount ..\AphidUI\AphidUI.csproj
