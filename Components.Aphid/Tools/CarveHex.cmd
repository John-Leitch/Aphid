@re ^
    -asm ^
    -s ^
    %* ^
    "(^^|[^^a-fA-F0-9])(((((?<b>[a-fA-F0-9]{2})([\r\n\s]*)){1,})([\r\n\s]*)(?<delim>[^^a-fA-F0-9])?)([\r\n\s]*)((?<b>[a-fA-F0-9]{2})([\r\n\s]*)\k<delim>?([\r\n\s]*))+)" ^
    -b ^
    -decoders "utf-8, utf-16, utf-32" ^
    -e ^
    var h = m.b().Captures-^>@.Value to concat; ^
    var len = h.Length / 2; ^
    if (len ^< 8 or !context.hashed.Add(h)) ret null; ^
    var name = '{0}_{1}_carved_{2:x8}.bin' :: [file, encoding.BodyName, m.Groups[2].Index]; ^
    console.success('Writing {0} bytes of hex encoded data to {1}', len, name); ^
    if (verbosity ^> 3) { ^
        m.Groups[2].Value @console.line('Raw: {0}'); ^
        h @console.line('Hex: {0}'); ^
        h to unhexStr @console.line('Str: {0}'); ^
        h to unhex to hex @console.line('Tnd: {0}') ^
    } ^
    if (!(context.parseHex defined)) { ^
        #'data/fasthex'; ^
        context.parseHex = fastHex.parse; ^
    } ^
    h to context.parseHex @io.bytes(name);^
