@re ^
    -decoders "utf-8, utf-16, utf-32" ^
    "\[[\r\n\s]*((0x[a-fA-F0-9]{1,2})|([\d]{1,2})|(1\d{2})|(2[0-4]\d)|(25[0-5]))[\r\n\s]*(,[\r\n\s]*((0x[a-fA-F0-9]{1,2})|([\d]{1,2})|(1\d{2})|(2[0-4]\d)|(25[0-5]))[\r\n\s]*){32,}[\r\n\s]*,?[\n\s]*\]" ^
    -b ^
    -e ^
    try { ^
        var name = '{0}_carved_{1:x8}.array' :: [file, m.Index]; ^
        m.Value to deserialize @seq.array(byte) @io.bytes(name); ^
        console.success('Wrote ~Cyan~{0}~R~', name); ^
    } catch (e) { ^
        console.error(e.message); ^
    }