# Theory.md

These are some notes and observations I have made during the development. It may prove useful, particularly if anyone wants to contribute to the project.

## Lexemes and Tokens

A program can be seen metaphorically as a book. A statement, such as an assignment (**var x = 0**) or an if-block (**if condition do statement**), can be considered a sentence in this book. Note, by sentence I mean a logical line of code; a logical line of code may contain several lines in the code but still be part of the same statement. Furthermore, a statement is divided into tokens and lexemes, which can be seen as words that make up the sentence. A lexeme is the string representantion, and a token is a lexeme with meta data such as its type and its index in the statement (sentence). So, the statement **x = 1 + 2** can be interpreted as the lexemes "x", "=", "1", "+" and "2", and these lexemes can be parsed as the tokens **VARIABLE (0) x**, **EQUALS (1)**, **NUMBER (2) 1** and so on. I did some research on this, and I'm not sure if it's 100% academically correct, but it's how I I interpret it and I think it'll work. At least for now. Famous last words, right?

## Abstract Syntax Tree (AST)

Tsoding's language was Stack-based, _i.e._ a postfix or reverse polish notation language, which means a statement such as **1 + 2** must be written as **1 2 +**. The two numbers are first pushed onto the stack, and then they are added together. This is actually pretty cool and simplifies the compiler a lot, but since it's not very common in modern programming language I think I want to implement proper infix notation.

To make infix notation work, values must be cached and parsed into a syntax tree. Whenever a binary operation such as **+** is spotted, we move up the tree, and whenever a number is spotted we move down. The statement **1 + 2** gives the following tree:

```
  +
 / \
1   2
```

An advantage with the postfix notation is that we don't have to care about presedence and parantheses, but with infix notation we do. So, the statement **1 + 2 + 3** would give the following AST:

```
    +
   / \
  +   3
 / \
1   2
```

But the statement **1 + 2 \* 3** must give the following:

```
  +
 / \
1   *
   / \
  2   3
```

Basically, we have to build the tree based on the presedence of the operators. Then, we obviously use inorder traversal to translate the tree into a logical piece of code. I have to look into this more, but I think I've got the gist of it.

Here is a more complex example for the code

```python
while b != 0:
  if a > b:
    a = a - b
  else:
    b = b - a
return a
```

<img src="https://upload.wikimedia.org/wikipedia/commons/thumb/c/c7/Abstract_syntax_tree_for_Euclidean_algorithm.svg/1920px-Abstract_syntax_tree_for_Euclidean_algorithm.svg.png" height="400px"/>

## Expression Types

To build an AST, tokens must be separated into different expression types. Some tokens are primary expressions. These have only one value, such as **2** or **"Hello world"**. A paranthesized expression can also be considered a primary expression, as it can be considered a standalone expression seen from outside the parantheses, so **(2 + 3)** would be a primary expression.

Other expressions are binary. These have a left side and a right side. **+** and **/** are examples of binary expressions. Each side is another expression, but do not necessarily have to be primary expressions.

I don't think ASTs necessarily have to be binary trees, which means we can have n-ary expressions. Function parameters are something I think may lead to more than 2 child nodes. However, this will do for now.
