call core\init.cmd
msbuild /p:Configuration=Release64 /t:Rebuild /p:Platform="Any CPU" /m /r /maxcpucount ..\Aphid.Test.sln
