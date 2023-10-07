import math
e = " "
i = 0
a = 0.0
while True:
        while e.isdigit() == False:
            e = input("e = ")
        else:
            e = int(e)
            break
while abs(a*a-2) < e:
    if i == 1:
        print(' Division by 0 is unacceptable')
        i+=1
        continue
    else:
        a = 1/2*((i-1) + 2/(i-1))
        i+=1
print(a)



