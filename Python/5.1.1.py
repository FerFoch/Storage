import math
n = " "
while True:
        while n.isdigit() == False:
            n = input("a = ")
        else:
            n = int(n)
            break
b = n
c = None
l = None
while b>0:
    c = b%10
    b = b//10
print("Сумма = ",c + n%10)