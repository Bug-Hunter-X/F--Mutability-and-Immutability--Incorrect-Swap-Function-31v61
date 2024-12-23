let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printfn "%d %d" x y //This will print 20 10

//However, if you try to swap values of immutable variables, it won't work.
let x1 = 10
let y1 = 20

let swapImmutable x y = 
    let temp = x
    x <- y //This will produce an error because you cannot assign a value to an immutable variable
    y <- temp

swapImmutable x1 y1 //This will cause error