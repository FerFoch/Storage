import math
digit = '0123456789'
dot = '.'
plus = '+'
minus = '-'
check = False
while True:
    x = input("x = ")
    if x:
        if ((x[0] in plus) or (x[0] in minus) or (x[0] in dot)):
            for symbol in x[1:len(x)]:
                if (symbol in digit) or (symbol in dot):
                    check = True
                else:
                    check = False
                    break
        elif (x[0] in digit):
            if (len(x) == 1 and x in digit):
                check = True
            else:
                for symbol in data[1:len(x)]:
                    if (symbol in digit) or (symbol in dot):
                        check = True
                    else:
                        check = False
                        break
        if (x.count(dot) > 1):
            check = False
    if check: break

while True:
    y = input("y = ")
    if y:
        if ((y[0] in plus) or (y[0] in minus) or (y[0] in dot)):
            for symbol in y[1:len(y)]:
                if (symbol in digit) or (symbol in dot):
                    check = True
                else:
                    check = False
                    break
        elif (y[0] in digit):
            if (len(y) == 1 and y in digit):
                check = True
            else:
                for symbol in data[1:len(y)]:
                    if (symbol in digit) or (symbol in dot):
                        check = True
                    else:
                        check = False
                        break
        if (y.count(dot) > 1):
            check = False
    if check:
        break
x = float(x)
y = float(y)
if (-6 <= x <= -3) and  (-3 <= y <= 2) or (-6 <= x <= -1) and (2 <= y <= 7):
    print("True")
else:
    print("False")
