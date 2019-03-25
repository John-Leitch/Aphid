pushd .
call buildTest

if %errorlevel% neq 0 (
    echo Failed building tests
) else (
    cd c:\tools\nunit
    call testaphidfast
)

popd