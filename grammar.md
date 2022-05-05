# Grammar Definition

## Introduction
I haven't really made up my mind yet what this language is going to be, so this document is more brainstorming than a formal grammar definition. I'm fond of functional and declarative programming, and I want create something inspired by Haskell, but with more modern syntax. I've also been following another functional language called Roc, which is still in development. It's made by Richard Feldman, who is a really smart dude, so taking some inspiration from this language could be helpful. 

In addition to the benefits a functional language provides for developers, I imagine it's also easier to create the language. My knowledge and experience when it comes to building languages is close to zero, but a pure functional language should be a lot easier because, well, it's pretty much just functions and immutable data. When all data is immutable, we shouldn't need to worry about nasty stuff like race conditions. Right...?

## Data & Functions
One thing I appreciate with functional programming it how it simplifies everything. It feels like modern languages try to do a million things in a million different ways. In functional languages, we remove all of the redundant features such as classes, inheritance and abstractions, and break programming down to its core: data and functions. We use data to store values in memory, and we use functions to perform actions with that data. That's all a programming language really needs, so that's what we'll start with for Yapp.

Since data is immutable, they shouldn't really be called variables. I think `value` works fine. And `function` is fine already. 

After a lot of consideration, I think a  `value` declaration should look like this:

```python
x: int = 42
```

and a `function` declaration like this:

```python
add: (int, int -> int) = a, b -> a + b
```

A function can use multiple lines. The following functions are all valid:

```python
add: (int, int -> int) = a, b ->
  a + b

add: (int, int -> int) =
  a, b -> a + b

add: (int, int -> int) =
  a, b ->
    a + b
```

I don't think this will be a major issue for the parser. When we see a newline character we just try to find the next character, regardless of indentation. There may be some issues for large functions with several if-blocks, but let's worry about that later. You shouldn't really have such large functions anyway!

## Types
I consider strongly typed languages superior to dynamically typed languages, pretty much always. Sure, for a beginner you could argue that it's easier to not have to worry about types, but this language is made for myself, and I want static types. However, I've been working in Kotlin a lot recently, and I really appreciate how they use static types "under the hood", but use type inference so you don't have to specify types when the type is obvious. As a start, though, I think going fully static typing is the easiest way to go, and perhaps we can add some sort of type inference later. 


## Lazy Evaluation
In a lazily evaluated functional language, there isn't really much difference between a data value and a function. It's possible to consider a data value as a function which takes no arguments and returns a value. Let's consider the following code

```python
x: int = 5
y: int = 3
add: (int, int -> int) = a, b -> a + b

add(x, y)
# prints 8
```

The variables _x_ and _y_ have the type `int`, and the function _add_ has the type `(int, int -> int)`. You could consider _x_ and _y_'s type to be `(_ -> int)`, and have their implicit declarations be `x: _ -> int = _ -> 5` and `y: _ int = _ -> 3`. They could then be treated as functions by the compiler, and only be evaluated when they're needed. 