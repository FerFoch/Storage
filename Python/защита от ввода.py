import math
digit = '0123456789'
dot = '.'
plus = '+'
minus = '-'
check = False

while True:
    data = input("введите дробное число ")
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
data = float(data)
print ("все окей, вот ваше число ", data)
        
