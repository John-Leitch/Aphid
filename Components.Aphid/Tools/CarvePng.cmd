@re ^
    ".[\x80-\x8f]PNG\r\n\x1a\n(?:.|\n){0,16777216}IEND(?:.|\n){0,4}" ^
     %* ^
    -b ^
    -e ^
    try { ^
        var i = (m.Index + 1).long(); ^
        console.success('Carving ~Cyan~{0}~R~ at ~Green~0x{1:x8}~R~', file, i); ^
        reader.BaseStream.Position = i; ^
        ^
        m.Length - 1 to reader.ReadBytes ^
        @io.bytes(^file @io.sibling('{0}_Carved_{1:x8}.png' ::[io.name(file), i])); ^
    } catch (e) { ^
        console.error('Error carving PNG: {0}', e.message); ^
    }