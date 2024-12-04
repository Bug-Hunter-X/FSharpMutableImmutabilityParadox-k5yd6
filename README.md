# Unexpected Immutability with Mutable Variables in F#

This example demonstrates a common pitfall in F# when working with mutable variables. Even when using the `mutable` keyword, the expression is evaluated when the variable is first assigned and not updated when the mutable variable changes later. 

## The Bug

The code demonstrates that the value of `z` is not updated when the value of `x` is changed later, even though `x` is mutable.

## The Solution

The correct way to update `z` is to reassign `z` or use a function to recalculate the value. The solution shows how to directly reassign `z` after changing `x`. 