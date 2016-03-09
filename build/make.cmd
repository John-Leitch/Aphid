set mode=debug
set outPath=..\%mode%
set nunit="c:\Program Files (x86)\NUnit.org\nunit-console\nunit3-console.exe"

mkdir ..\Arch

del ..\Aphid\bin\%mode%\* /s /q
del ..\Coywolf\bin\%mode%\* /s /q
del ..\Boxelder\bin\%mode%\* /s /q
del ..\Mantispid\bin\%mode%\* /s /q
del %outPath%\* /s /q

call xbuild ..\Aphid\Aphid.csproj
mkdir %outPath%\Aphid
mkdir %outPath%\Aphid\Library
copy ..\Aphid\bin\%mode%\Aphid.exe %outPath%\Aphid
copy ..\Aphid\bin\%mode%\Components.Aphid.dll %outPath%\Aphid
copy ..\Aphid\bin\%mode%\*.alx %outPath%\Aphid
copy ..\Aphid\bin\%mode%\Library\*.alx %outPath%\Aphid\Library

call xbuild ..\Coywolf\Coywolf.csproj
mkdir %outPath%\Coywolf
mkdir %outPath%\Coywolf\Library
copy ..\Coywolf\bin\%mode%\cw.exe %outPath%\Coywolf
copy ..\Coywolf\bin\%mode%\phpFunctions.txt %outPath%\Coywolf
copy ..\Coywolf\bin\%mode%\Components.Aphid.dll %outPath%\Coywolf
::copy ..\Coywolf\bin\%mode%\*.alx %outPath%\Coywolf
copy ..\Coywolf\bin\%mode%\Library\Query.alx %outPath%\Coywolf\Library

call xbuild ..\Boxelder\Boxelder.csproj
mkdir %outPath%\Boxelder
mkdir %outPath%\Boxelder\Library
copy ..\Boxelder\bin\%mode%\be.exe %outPath%\Boxelder
copy ..\Boxelder\bin\%mode%\Components.Aphid.dll %outPath%\Boxelder
copy ..\Boxelder\bin\%mode%\*.alx %outPath%\Boxelder
copy ..\Boxelder\bin\%mode%\Library\Query.alx %outPath%\Boxelder\Library

call xbuild ..\Mantispid\Mantispid.csproj
mkdir %outPath%\Mantispid
mkdir %outPath%\Mantispid\Library
copy ..\Mantispid\bin\%mode%\Mantispid.exe %outPath%\Mantispid
copy ..\Mantispid\bin\%mode%\AphidCodeGenerator.exe %outPath%\Mantispid
copy ..\Mantispid\bin\%mode%\llex.exe %outPath%\Mantispid
copy ..\Mantispid\bin\%mode%\Components.Aphid.dll %outPath%\Mantispid
copy ..\Mantispid\bin\%mode%\Library\*.alx %outPath%\Mantispid\Library
copy ..\Components.Aphid\Aphid.alx %outPath%\Mantispid
copy ..\Components.Aphid\Aphid.Lexer.alx %outPath%\Mantispid
copy ..\Components.Aphid\Aphid.Lexer.Code.alx %outPath%\Mantispid
copy ..\Components.Aphid\Aphid.Lexer.Tmpl.alx %outPath%\Mantispid

call xbuild ..\Components.Aphid.Tests.Integration\Components.Aphid.Tests.Integration.csproj
set testAsm=..\Components.Aphid.Tests.Integration\bin\%mode%\Components.Aphid.Tests.Integration.dll
%nunit% %testAsm% --full --work=%outPath% --out=%outPath%\TestResults.txt --err=%outPath%\TestErrors.txt

powershell .\package.ps1