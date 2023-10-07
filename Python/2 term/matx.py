import math
import random
i = 0
matx1 = [[random.randint(0,10) for i in range(6)] for i in range(6)]
matx2 = [[random.randint(0,10) for i in range(6)] for i in range(6)]
sum = [[(0) for i in range(6)] for i in range(6)]
sub = [[(0) for i in range(6)] for i in range(6)]
mult = [[(0) for i in range(6)] for i in range(6)]
for i in range(6):
    for j in range(6):
        sum[i][j] = matx1[i][j] + matx2[i][j]
        sub[i][j] = matx2[i][j] - matx1[i][j]
        mult[i][j] = matx2[i][j] * matx1[i][j]
print("matx1  ", matx1)
print("matx2  ", matx2)
print("sum  ",sum)
print("sub  ",sub)
print("mult  ", mult)