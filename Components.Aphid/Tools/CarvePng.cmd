@re ^
    "[\x80-\x8f]PNG\r\n\x1a\n" ^
    -b ^
    -e ^
    if (m.Index == 0 and io.ext(file).ToLower() == '.png') ^
        ret null; ^
    ^
    console.success('Carving ~Cyan~{0}~R~ at ~Green~0x{1:x8}~R~', file, m.Index); ^
    reader.BaseStream.Position = m.Index.long(); ^
    ^
    reader.BaseStream.Length.int() ^
        @Math.Max(50000000) ^
        to reader.ReadBytes ^
        @io.bytes(^file @io.sibling('{0}_{1:x8}.png' ::[io.name(file), m.Index]));