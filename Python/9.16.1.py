import math
from random import randint
N = " "
i = 0
c = 2
simple = True
summ = 0
while True:
        while N.isdigit() == False:
            N = input("N = ")
        else:
            N = int(N)
            break
a = [0]*N
for i in range(0,N):
    a[i] = randint(1,10)
    print(a[i])
    summ = a[1] + a[2] + a[3]
    while c <= math.sqrt(i):
        if i % c == 0:
            simple = False
            break
        c += 1
        if simple:
            summ += a[i]
            break
    c = 2
print("Сумма чисел = ", summ)