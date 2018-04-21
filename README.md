# Aphid
Aphid is a unique multiparadigm language that can be interpreted or compiled. Although it began as an embedded scripting language for the .NET framework, over the years it grew into a standalone .NET language, as well as the ability to be compiled into other languages such as Python, PHP, and Verilog.

Despite its growth beyond what was originally envisioned, Aphid still retains many of the properties typically specific to such languages. Namely, Aphid's entire implementation is a white-box, with its internals represented as a clean and easy to work with object model. This means that not only can new compilers and interpreters be created with ease, but Aphid programs can actually alter the semantics of the language at runtime.

# Getting Started

The Aphid REPL can be run by launching the main executable without any arguments.

```
c:\Aphid>Aphid.exe
╔═══════════════════════════════════════════════════════════╗
║ Aphid Programming Language 0.6.6685.4918                  ║
╚═══════════════════════════════════════════════════════════╝
>>>using System
>>>Console.WriteLine('Hello world')
Hello world
>>>
```

Aphid scripts can be passed via command-line argument. Several samples are included in the \Samples folder.

```
c:\Aphid>Aphid.exe Samples\HelloWorld.alx
Hello, world
```