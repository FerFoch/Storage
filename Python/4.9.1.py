import math
x = " "
i = 0
while True:
        while x.isdigit() == False:
            x = input("a = ")
        else:
            x = int(x)
        if (0 <= x <= 40):
            break
        else:
            x = input("a = ")
for i in range(0,41):
    y = i*i+i+41
    print(y)