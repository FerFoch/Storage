import math
m = int(input("m = "))
n = int(input("n = "))
a = int(input("a = "))
b = int(input("b = "))
c = int(input("c = "))
f = a*m*m + b*m + c - n
if f == 0:
  print("Проходит")
else:
  print ("Не проходит")