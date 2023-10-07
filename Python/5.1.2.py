import math
n = " "
while True:
        while n.isdigit() == False:
            n = input("a = ")
        else:
            n = int(n)
            break
m = 0
km = 1
i = 1
cf = int()
while (n):
    cf = n % 10
    if (cf == m):
        km+=1
    elif (cf > m):
         m = cf
         km = 0
    n = (n - cf)/10
    print(n, ' ', cf)
print("Максимальная цифра", m ," повторяется", km ,"раз")
