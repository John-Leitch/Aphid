@re -p %* ^
    "\xff\xd8\xff[\xe0-\xef].{0,32}?[jJ][fF][a-zA-Z]{2}.*?(\n|.)*?\xff\xd9" ^
    -asm -b -s -e ^
    var e = file ^| io.ext @()$_.ToLower(); ^
    if (m.Index == 0 ^&^& (e == '.jpg' ^|^| e == '.jpeg')) ret null; ^
    console.success('Found JPG in {0} at offset 0x{1:x8}', file, m.Index); ^
    reader.BaseStream.Position = m.Index.long(); ^
    reader.ReadBytes(m.Length) @io.bytes('{0}_Carved_{1}.jpg' ::[file, m.Index]);
