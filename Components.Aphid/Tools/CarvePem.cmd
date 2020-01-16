re -asm -hs -s -p %1 ^
    "-----BEGIN (?<name>([a-zA-Z0-9 ]*?))-----[a-zA-Z0-9\+\s\r\n/\\=-]{8,1000000}?-----END \k<name>-----" ^
    -g 0 ^
    -e console.success('Found {0} PEM: {1}:{2}', m.name(), file, m.Index); ^
    value.Replace('\\n', '\n') @io.txt('c:/temp/{0}_{1}_{2}_{3}.pem' :: [$_.Groups[1].Value, io.base(file), $_.Index, Guid.NewGuid()])