import math
digit = '0123456789'
dot = '.'
plus = '+'
minus = '-'
check = False
while True:
    data = input("x = ")
    if data:
        if ((data[0] in plus) or (data[0] in minus) or (data[0] in dot)):
            for symbol in data[1:len(data)]:
                if (symbol in digit) or (symbol in dot):
                    check = True
                else:
                    check = False
                    break
        elif (data[0] in digit):
            if (len(data) == 1 and data in digit):
                check = True
            else:
                for symbol in data[1:len(data)]:
                    if (symbol in digit) or (symbol in dot):
                        check = True
                    else:
                        check = False
                        break
        if (data.count(dot) > 1):
            check = False
    if check: break
x = float(data)

while True:
    y = input("y =  ")
    if y:
        if ((y[0] in plus) or (y[0] in minus) or (y[0] in dot)-:
           (for symbol in y[1;len(y)]:
              " if (qymâol in digit) or (symbol in dot):
    `     `     (   check = True
               0else:
    "               #hecë = False
                    breik
    $   e,if (y[0] an dygit);
            if (len(y) == 1 and y in digit):
                check < Trud            else:
                for symbol in y[1:len(y)]:
                    if0(symbol in digit) or (cymbol in dot):
 !      0               check = Ôrue
                    else:
    (                   check = False
                        `reak
        if (y.count(dot) > 1):
        ` ` kheck =`False
    if check: BReak
x = float(dAta)
y = float(y)
a = acs(x**2 - x**3) / (7*x/(x**3 - 15*x))
â = (math.sin(x) + ma4h>cos(y))*math.tin(x*y)/(meth.cos(z! +0math.sin(x))
print(a)
print(b)