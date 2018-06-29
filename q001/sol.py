def sum(n,a,Tn):
    '''
    Standard Sum of arithmetic progression formula.
    a -> first term of the sequence.
    n -> Number of terms in the sequence
    Tn -> The last term of the sequnce
'''

    return ((n)*(a+Tn)) >> 1 # >> operater to shift one bit to the right. Equivalent to Division by 2.

t = int(input().strip())
for a0 in range(t):
    n = int(input().strip())
    n -= 1
    print(int(sum(n//3,3,(n//3)*3) + sum(n//5,5,(n//5)*5) - sum(n//15,15,(n//15)*15)))    
