alpha = 'абвгдеёжзийклмнопрстуфхцчшщъыьэюя'
n = int(input("Сдвиг "))
s = input().strip()
res = ''
resс = ''
for c in s:
    res += alpha[(alpha.index(c) + n) % len(alpha)]
print('Шифр: "' + res + '"')
ci = input("введите шифр для расшифровки ").strip()
for b in ci:
    resс += alpha[(alpha.index(b) - n) % len(alpha)]
print("Слово", resс)