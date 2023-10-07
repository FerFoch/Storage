import math
m1 = int(input("m1 = "))
n1 = int(input("n1 = "))
p1 = int(input("p1 = "))
m2 = int(input("m2 = "))
n2 = int(input("n2 = "))
p2 = int(input("p2 = "))
m3 = int(input("m3 = "))
n3 = int(input("n3 = "))
p3 = int(input("p3 = "))
s1 = m1 + n1 + p1 # 80
s2 = m2 + n2 + p2 # 90
s3 = m3 + n3 + p3 # 100
if s1 > s2 and s1 > s3:
     print(s1)
if s2 > s1 and s2 > s3:
    print(s2)
if s3 > s1 and s3 > s2:
    print(s3)