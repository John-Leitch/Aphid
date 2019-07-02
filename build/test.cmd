pushd .
call buildTest

if %errorlevel% neq 0 (
    echo Failed building tests
) else (
    cd /d c:\tools\nunit
    call testaphidfast
)

popd