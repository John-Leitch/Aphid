@echo off
set src=%~dp0..\..
set dst=c:\tools\aphid
REM set a=/E /Y /D /F /H
set a=/Y /D /F /H
pushd .

set hr=call %src%\Aphid\bin\Release64\aphid64.exe *#'std';subhead('%%msg%%');
set msg=Updating Aphid Binaries
%hr%

pushd .
cd /d %dst%
aphid64 * Console.WriteLine(Guid.NewGuid().ToString().Replace('-', '')) > rnd.txt
set /p rnd=<rnd.txt
del rnd.txt
ren %dst%\Aphid64.exe Aphid64.exe.%rnd%.bak
ren %dst%\Components.Aphid64.dll Components.Aphid64.dll.%rnd%.bak

for %%d in (AphidUI\bin\x64\Release Aphid\bin\Debug Aphid\bin\Release Aphid\bin\Release32 Aphid\bin\Release64) do (
    for %%i in (exe dll pdb config) do (
        xcopy %src%\%%d\*.%%i %dst% %a%
    )
)

popd
cd %src%\build\deploy
call %cd%\aphidupdatescripts.cmd
::call aphidngen
popd.
@echo on