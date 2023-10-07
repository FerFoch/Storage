import math
from random import randint
n = " "
while True:
        while n.isdigit() == False:
            n = input("n = ")
        else:
            n = int(n)
            break
m = " "
while True:
        while m.isdigit() == False:
            m = input("m = ")
        else:
            m = int(m)
            break

i = 0
a = [0]*(n+2)
for i in range(0,n+1):
    a[i] = randint(1,10)
    print(a[i])
    if a[i]+a[i+1] == m:
        print(a[i], a[i+1])