pushd .
cd /d c:\source\Aphid\build
ResetEnvironment.alx
call clean
call buildAphidAlone.cmd
call core\init.cmd
%B% /p:Configuration=Debug /p:Platform="Any CPU" ..\AphidVSExtension.sln
ResetEnvironment.alx
UpdateVSPackage.alx -a
popd