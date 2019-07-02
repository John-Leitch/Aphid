@echo off
set dst=c:\tools\aphid
set a=/E /Y /D /F /H
set id=%random%%random%%random%%random%

set hr=call aphid64 *#'std';subhead('%%msg%%');
set msg=Cleaning Aphid
%hr%

pushd .

cd /d %dst%

for %%i in (exe dll pdb config bak) do (
    echo Renaming c:\tools\aphid\*.%%i to *.%id%.%%i
    ren c:\tools\aphid\*.%%i *.%id%.%%i
    del c:\tools\Aphid\*.%%i
)
for %%i in (Benchmarks Library Samples Tools ViewModels) do rd /s /q c:\tools\Aphid\%%i

popd
@echo on