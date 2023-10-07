f = 0
b = 0
n = input("Введите текст" '\n')
while True:
        while n.isdigit() != False:
            n = input("n = ")
        else:
            n = str(n)
            break
for i in n:
    f+=1
    if i == ';':
        b = len(n) - f
        f-=1
        break
print("Количество символов перед запятой равно ", f, "а после ; равно ", b)
