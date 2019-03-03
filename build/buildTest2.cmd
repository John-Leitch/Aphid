call core\init.cmd
nuget restore ..\Aphid.Test.sln
msbuild /p:Configuration=Release64 /t:Rebuild /p:Platform="Any CPU" /m /r /maxcpucount ..\Aphid.Test.sln
