import math
n = " "
i = 0
S = 0
while True:
        while n.isdigit() == False:
            n = input("n = ")
        else:
            n = int(n)
            break
for i in range (1, n+1):
    S += 1/((2*i+1)*(2*i+1))
    print(i)
    print(S)