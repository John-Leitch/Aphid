call core\init.cmd
nuget restore ..\Aphid.Test.sln
%B% /p:Configuration=Release64 /t:Rebuild /p:Platform="Any CPU" ..\Aphid.Test.sln
