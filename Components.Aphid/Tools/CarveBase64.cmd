@re ^
    -decoders "utf-8, utf-16, utf-32" ^
    "([a-z0-9+/\s\r\n]{32,}=*)" ^
    -b ^
    -e ^
    try { ^
        var name = '{0}_{1}_carved_{2:x8}.base64' :: [file, encoding.BodyName, m.Index]; ^
        m.Groups[1].Value to Convert.FromBase64String @io.bytes(name); ^
        console.success('Wrote ~Cyan~{0}~R~', name); ^
    } catch (e) { ^
        console.error(e.message); ^
    }