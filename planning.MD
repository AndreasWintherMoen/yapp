# Motivation

After watching Tsoding's Porth series on YouTube where he makes his own stack-based language from scratch, I've been interested in making a language myself. If anything, just to familiarize myself with compilers and assembly, as well as for bragging rights. The purpose of this project is to delve into the deep depths of low-level programming and, arguably most importantly, to do something fun. The language is not meant to be a general purpose language, but it would be cool to be able to solve simple coding problems such as advent of code.

I'm also a big advocate functional programming, and would like to use this as an opportunity to improve my functional programming skills and perhaps show others the power of deterministic code. However, I think there are lots of issues to solve before I get to that point. It will probably take a long time just to get something that is Turing complete, but a pure functional language inspired by languages like Haskell and Clojure would be really, really cool.

# Compiler Language

As mentioned, the primary goal of this project is to do something fun and to learn something. Before I get to the point where I can use Yapp to compile Yapp code, we're gonna need another language to compile the code. Tsoding used Python, but the lack of raw pointers seemed to limit him a bit for tokenization. I also don't want to straight up copy his work either, so I wanna try something else.

## C++

Efficient, but tedious to write. Manual garbage collection sucks. Don't really need the efficiency. If a goal is to re-write the compiler in Yapp, then efficiency is irrelevant for the first language. Would be fun and useful to freshen up my C++ skills though.

## C#

Have a lot of experience with C# through Unity, but it could be helpful to use it in a more traditional manner, as Unity has a lot of own libraries for things. Doesn't C# and .NET development on macs kinda suck though? Although Microsoft has improved, I suspect it's still not optimal. It would also be a lot quicker if we could use an interpreted language...

## Go

I recently watched a YouTube video on Go. You know, one of those 6 hours long tutorials that are just a whole Udemy course mashed into one video. It seems pretty cool I guess. Has an increasing adoption rate. But I kinda feel that the strengths of Go are mostly related to concurrency because of Goroutines, i.e. green threads, which isn't really a necessity for this project.

## Rust

Rust is a language I've wanted to try out but never had the time for. I'm not very familiar with its strengths and weaknesses, but I guess it's like a modernized C++ with some garbage collection. So, quite low level but easier than C and C++. It's still probably quite a lot of work to learn, though. Its popularity is rising, but I'm not really feeling it that much. Doubt I'll end up using Rust once I start working. Also, when you search for Rust on YouTube you just get gameplay videos. Rust seems cool but I don't think this is the project for it.

## Dart

This is another one of those langauges trying to make everything look simple, kinda like a new Python. Doesn't really do much you can't do in Python, except use camel case. Its popularity is growing, probably mostly because of Flutter, but I don't really think it's going to be that common in the future. The type system seems nice. Pointer arithmetic seems to be non-existent. Not really feeling this one either.

-----

## Conclusion

Ok, so I don't really want something too low level, because efficiency is irrelevant and eventually I want to use my own language to compile. The two most important things are #1 development time and #2 learning outcome and usefulness. For #1 I guess C# would be preferred because I already have experience with it and it's very well documented. Once I grasp the basics I guess both Go and Dart would be pretty quick as well. For #2 I'm thinking Go is preferred, followed by C# and maybe Dart.

Let's exclude C++ and Rust because too low level and unnecessarily tedious and complex. That leaves C#, Go and Dart. The least commonly used is Dart, and I feel like this is probably the least likely to be useful for me in the future. And it seems a bit too high level for this project. I guess we're down to Go vs C#. It's quite late so I'll ponder about this until tomorrow, but I think I'll go with C# assuming that there's no issues doing it on a Mac. Yeah, I think so. The only major strength of Go is goroutines which I won't be using at all for this project. As of day 1, C# is the primary contender.
