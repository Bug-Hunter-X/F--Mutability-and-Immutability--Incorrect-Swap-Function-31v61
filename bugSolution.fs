let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printfn "%d %d" x y //This will print 20 10

//Alternatively, using tuples for swapping without mutable variables:
let swapImmutable (x, y) = (y, x)
let x1 = 10
let y1 = 20
let (x2, y2) = swapImmutable (x1, y1)
printfn "%d %d" x2 y2