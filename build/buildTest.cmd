call %~dp0core\prologue.cmd
set sln=..\Aphid.Test.sln
nuget restore %sln%
%B% /p:Configuration=Release64 /p:Platform="Any CPU" %sln%
call %~dp0core\epilogue.cmd