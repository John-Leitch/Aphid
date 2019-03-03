call core\init.cmd
msbuild /p:Configuration=Release /p:Platform="Any CPU" /m /r /maxcpucount ..\AphidVSExtension.sln 
