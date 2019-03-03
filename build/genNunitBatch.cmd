..\aphid\bin\Release64\Aphid64.exe * #'std'; #'io'; ret '.\\' :* '*nunit*-console.exe' ^^! @format('{1} {0}', 1..9-^>@format('%%{0}') @join(' ')) @File.WriteAllText('nu.cmd')

nu.cmd ^
    ..\Components.Aphid.IntelliTests\bin\x64\Release\Components.Aphid.IntelliTests.dll ^
    ..\Components.Aphid.ScriptedUnitTests\bin\x64\Release\Components.Aphid.ScriptedUnitTests.dll ^
    ..\Components.Aphid.UnitTests\bin\x64\Release\Components.Aphid.UnitTests.dll ^