# F# Mutability and Immutability Bug

This repository demonstrates a common error in F# related to the misuse of mutable and immutable variables.  The `bug.fs` file shows an attempt to swap the values of immutable variables, which results in a compiler error. The `bugSolution.fs` file shows how to correctly handle variable swapping using mutable variables.

## Setup

No special setup is required.  You'll need an F# compiler (like the one included with .NET SDK) to compile and run the code.

## Running the code

1. Open a terminal or command prompt.
2. Navigate to the directory containing `bug.fs` and `bugSolution.fs`.
3. Compile and run each file using the F# compiler (fsc.exe): 
   ```bash
fsc.exe bug.fs && ./bug.exe
fsc.exe bugSolution.fs && ./bugSolution.exe
```

## Key Learning Points

* Understanding the distinction between mutable and immutable variables in F# is crucial to avoid runtime errors.
* Immutability is a core tenet of functional programming and can lead to more robust and predictable code.
* When swapping values, you must use mutable variables or employ techniques involving tuples or other data structures that allow for value replacement without directly modifying variables.