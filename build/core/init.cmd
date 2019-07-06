::set MSBUILDDISABLENODEREUSE=1
::set MSBUILD_FIX=/nr:false /p:ContinueOnDisconnected=false 
::set B=msbuild.exe /r /m /p:BuildInParallel=true %MSBUILD_FIX%
set MSBUILD_FIX=/m
set B=msbuild.exe /r %MSBUILD_FIX%
IF NOT DEFINED VisualStudioVersion call "d:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\Common7\Tools\VsDevCmd.bat" 
