@re ^
    "\x1f\x8b" ^
    -p %* ^
    -b ^
    -e ^
        if (!(gzip defined)) { ^
            #'io/compression'; ^
            this.Parent.gzip = gzip; ^
        } ^
        try { ^
            var name = '{0}_carved_{1:x8}.ungz' :: [file, m.Index]; ^
            reader.BaseStream.Position = m.Index.long(); ^
            if ((var l = (reader.BaseStream.Length - reader.BaseStream.Position).int()) ^> 8) { ^
                var b = reader.ReadBytes(l); ^
                var c = b to gzip.decompress; ^
                c @io.bytes(name); ^
                console.success('Wrote ~Cyan~{0}~R~', name.Replace('~', '~~')); ^
            } ^
        } catch (e) { ^
            if (verbosity ^>= 3) { ^
                console.error(e.message); ^
            } ^
        }