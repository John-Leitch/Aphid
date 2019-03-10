call core\init.cmd
set sln=..\Aphid.Test.sln
nuget restore %sln%
msbuild /p:Configuration=Release64 /p:Platform="Any CPU" /m /r /maxcpucount %sln%
