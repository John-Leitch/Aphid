:: "\xff\xd8\xff[\xe0-\xef].{0,32}?[jJ][fF][a-zA-Z]{2}.*?(?:\n|.)*?\xff\xd9"
:: "\xff\xd8\xff[\xe0-\xef].{0,10000000}?\xff\xd9"
@re -p %* ^
    "\xff.\xff...(([jJ][fF])|([eE][xX]))[iI][fF]((?!JFIF).){0,1000}?(\xff...(([jJ][fF])|([eE][xX]))((?!Exif|JFIF).)*?\xff\xd9)?((?!JFIF).){0,25000000}?\xff\xd9" ^
    -fl Singleline ^
    -max 1000000000 ^
    -asm -b -s -e ^
    try { ^
        var e = file ^| io.ext @()$_.ToLower(); ^
        if (m.Index == 0 ^&^& (e == '.jpg' ^|^| e == '.jpeg')) ret null; ^
        console.success('Found JPG in {0} at offset 0x{1:x8}', file, m.Index); ^
        reader.BaseStream.Position = m.Index.long(); ^
        reader.ReadBytes(m.Length) @io.bytes('{0}_Carved_{1:D8}.jpg' ::[file, m.Index]); ^
    } catch (e) { ^
        console.error('Error carving file {0}: {1}', file, e.message); ^
    } ^
