let mutable x = 10
let mutable y = 20
let mutable z = x + y
printf "%d\n" z
x <- 30
z <- x + y //reassign z to update its value
printf "%d\n" z