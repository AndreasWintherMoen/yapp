# YAPP (Yet Another Procrastination Project)

A to be named programming language I started creating instead of studying for my exams

## TODOs

- [x] Parse code into a syntax tree and evaluate tree.
- [ ] Achieve Turing completeness
  - [ ] Jump conditionally (if/else)
  - [ ] Access arbitrary memory addresses (read and store)
- [ ] Read code from a file
- [ ] Compile into assembly or LLVM

## How to run

The current compiler is using C#. I use Rider but I suppose any IDE with C# support should work.

So far, it's able to parse and calculate arithmetic operations, namely addition, subtraction, multiplication and division. No paranthesis support yet. Operators and operands must be separated by a single space character.

Example of legal operations and their outputs:

```
2 + 3

└──PLUS +
    ├──NUMBER 2
    └──NUMBER 3

5
```

```
3 * 4 + 5

└──PLUS +
    ├──MULTIPLY *
    │   ├──NUMBER 3
    │   └──NUMBER 4
    └──NUMBER 5

17
```
