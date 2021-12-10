# YAPP (Yet Another Procrastination Project)

A to be named programming language I started creating instead of studying for my exams

## How to run

The current compiler is using C#. I use Rider but I suppose any IDE with C# support should work.

So far, it's able to parse arithmetic operations, namely addition, subtraction, multiplication and division. However, it's just parsing, _i.e._ not actually traversing the syntax tree and computing anything. No paranthesis support yet. Operators and operands must be separated by a single space character.

Example of legal operations and their outputs:

```
2 + 3

└──PLUS +
    ├──NUMBER 2
    └──NUMBER 3
```

```
3 * 4 + 5

└──PLUS +
    ├──MULTIPLY *
    │   ├──NUMBER 3
    │   └──NUMBER 4
    └──NUMBER 5
```
