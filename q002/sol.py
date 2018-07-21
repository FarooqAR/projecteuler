#!/bin/python3

import sys

def fibonacci_even(n):
    a = 2
    b = 3
    sum = 2
    while True:
        add  = (a+b)
        temp = add +b
        if temp > n:
            break
        sum += temp
        a = temp
        b = temp+add
    return sum

t = int(input().strip())
for a0 in range(t):
    n = int(input().strip())
    print(fibonacci_even(n))
    