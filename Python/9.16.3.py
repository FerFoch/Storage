from random import randint
a = []
N = " "
c = 0
while True:
        while N.isdigit() == False:
            N = input("N = ")
        else:
            N = int(N)
            break
for i in range(N):
    a.append(randint(1, 99))
print(a)

for i in range(N - 1):
    for j in range(N - i - 1):
        if a[j] > a[j + 1]:
            a[j], a[j + 1] = a[j + 1], a[j]
            c += 1
print("Количество перезаписей равно", c)
print(a)