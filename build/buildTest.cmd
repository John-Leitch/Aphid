call core\init.cmd
set sln=..\Aphid.Test.sln
nuget restore %sln%
%B% /p:Configuration=Release64 /p:Platform="Any CPU" %sln%
