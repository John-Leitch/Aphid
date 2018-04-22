# Aphid
Aphid is a unique multiparadigm language that can be interpreted or compiled. Although it began as an embedded scripting language for the .NET framework, over the years it grew into a standalone .NET language, as well as the ability to be compiled into other languages such as Python, PHP, and Verilog.

Despite its growth beyond what was originally envisioned, Aphid still retains many of the properties typically specific to such languages. Namely, Aphid's entire implementation is a white-box, with its internals represented as a clean and easy to work with object model. This means that not only can new compilers and interpreters be created with ease, but Aphid programs can actually alter the semantics of the language at runtime.

## Getting Started

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
c:\Aphid>type Samples\HelloWorld.alx
#'Std';

print('Hello, world');
c:\Aphid>Aphid.exe Samples\HelloWorld.alx
Hello, world

```
The samples range from the traditional hello world, as seen above, to more advanced language features. The custom operator example demonstrates how Medusa, Aphid's white-box capabilities, can be used to implement the safe navigation operator (?.) in one line.

```
c:\Aphid>type Samples\CustomOperatorExample.alx
#'Std';
#'Meta';

@?. (lhs, rhs) lhs != null ? lhs.{frame(1).exp().rhs().id()} : null;

var foo = {
    bar: {
        x: 10
    }
};

foo?.bar?.x |> print;

foo.bar = null;

foo?.bar?.x |> print;

foo = null;
foo?.bar?.x |> print;

c:\Aphid>aphid Samples\CustomOperatorExample.alx
10
null
null
```
## Aphid Dialects

Builds of multiple other Aphid dialects are included. They are as follows:

* Boxelder: Aphid to Python
* Coywolf: Aphid to PHP
* AphidHdl: Aphid to Verilog
* Mantispid: Lexer/Parser Generation

These frontends demonstrate how a few hundred lines of code can not only offer an alternatve syntax to the target language, but extend the semantics in significant ways as well, enabling features like partial functiona application.

Boxelder allows for writing concise C-style functional code that is executed by the Python interpreter.

```
c:\Aphid\Aphid2Python>type HelloWorld.alx
#'BoxelderQuery';

items =
    range(0, 100)
    @where(@(x) x < 10 || x > 50)
    @select(@(x) x * 2)
    @selectMany(@(x) [ x, x * x ]);

items |> print;

f = @(x) { items |> x |> print; };

items @first(@(x) x > 100) print;
items @all(@(x) x > -1) print;
items @all(@(x) x > 10) print;
items |> count |> print;
items @take(4) print;
items @skip(4) @take(4) print;
items @concat([ 111, 222]) print;

[ 'foo', 'ba', 'r' ] |> addAll |> print;
'0x%x' % (0x10 << 4) |> print;

c:\Aphid\Aphid2Python>be.exe HelloWorld.alx
╔═══════════════════════════════════════════════════════════════╗
║ Boxelder 0.5.6686.28404                                       ║
╚═══════════════════════════════════════════════════════════════╝

[i] Parsing 'HelloWorld.alx'
[+] File successfully parsed
[i] Compiling to Python
[+] Compilation successful, Python written to 'HelloWorld.py'

c:\Aphid\Aphid2Python>type HelloWorld.py
def var_func_00000008(x):
    return (x > 10)

def var_func_00000007(x):
    return (x > -1)

def var_func_00000006(x):
    return (x > 100)


[...]

items = (lambda var_00000000:selectMany(var_func_00000003, var_00000000))((lambda var_00000001:select(var_func_00000004, var_00000001))((lambda var_00000002:where(var_func_00000005, var_00000002))(range(0, 100))))
print(items)
def f(x):
    print(x(items))

print((lambda var_00000003:first(var_func_00000006, var_00000003))(items))
print((lambda var_00000004:all(var_func_00000007, var_00000004))(items))
print((lambda var_00000005:all(var_func_00000008, var_00000005))(items))
[...]
```

Coywolf offers several enhancements to PHP, such as a unified concat/addition operator (+), automatic closure capture, and automatic gator emit encoding.

```
c:\Aphid\Aphid2Php>type HelloWorld.alx
<%
    #'CoywolfQuery';
    square = @(x) x * x;
    [ 0, 1, 3, 4 ] @select(square) @concat(', ') |> echo;
%>

c:\Aphid\Aphid2Php>cw.exe HelloWorld.alx
╔═══════════════════════════════════════════════════════════════╗
║ Coywolf 0.5.6686.28404                                        ║
╚═══════════════════════════════════════════════════════════════╝

[i] Parsing 'HelloWorld.alx'
[+] File successfully parsed
[i] Compiling to PHP
[+] Compilation successful, PHP written to 'HelloWorld.php'

c:\Aphid\Aphid2Php>type HelloWorld.php
<?php
if (!function_exists('__add')) {
    function __add($lhs, $rhs) {
            return gettype($lhs) == 'string' || gettype($rhs) == 'string' ?
                    $lhs . $rhs :
                    $lhs + $rhs;
    }
}
?><?php
[...]
$concat = function ($separator, $source) use (&$aggr, &$x, &$y) {
    return call_user_func(
        (function($id_00000003) use (&$aggr, &$x, &$separator, &$y) { return $aggr(function ($x, $y) use (&$separator) {
            return __add(__add($x, $separator), $y);
        }, $id_00000003); }),
        $source);
};
$iter = function ($action, $source) {
    foreach ($source as $x){
        $action($x);
    }
};
$square = function ($x) {
    return ($x * $x);
};
echo call_user_func(
    (function($id_00000004) use (&$concat) { return $concat(", ", $id_00000004); }),
    call_user_func(
        (function($id_00000005) use (&$select, &$square) { return $select($square, $id_00000005); }),
        [0, 1, 3, 4]));
?>
```

The other dialects offer similar enhancements to their target languages.

## Visual Studio Extension

Beyond compiler frontends, an early version of a Visual Studio extension can be found at VisualStudioExtension\AphidPackage.vsix. This package should be compatible with the full range of Visual Studio editions from 2012 to 2017. Note that the plugin is considered an early Alpha, and currently only offers syntax highlighting, error checking, and limited intellisense.