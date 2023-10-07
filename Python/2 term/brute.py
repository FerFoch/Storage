import random
alpha_up = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
alpha_low = "zyxwvutsrqponmlkjihgfedcba"
spec = "`~!@#$%^&*_+"
pas_str = "1234567890"
pas, numb_of_sy, spec_sy, alpha, alpha_low_sy, alpha_up_sy, correctPassword = "", "", "", "", "", "", "",
while numb_of_sy.isdigit() == False:
    numb_of_sy = input("Введите количество символов в пароле\n")
    if numb_of_sy.isdigit() == True:
        numb_of_sy = int(numb_of_sy)
        break

while spec_sy != "y" and spec_sy != "n":
    spec_sy = input("Нужны ли спец символы?\n")
    if spec_sy == "y":
        pas_str += spec
        break
    if spec_sy == "n":
        break

while alpha != "y" and alpha != "n":
        alpha = input("Нужны ли сторочны и заглавные буквы?\n")
        if alpha == "y":
            pas_str += alpha_low + alpha_up
            break
        if alpha == "n":
            while alpha_low_sy != "y" and alpha_low_sy != "n":
                alpha_low_sy = input("Нужны ли строчные буквы?\n")
                if alpha_low_sy == "y":
                    pas_str += alpha_low
                    break
                if alpha_low_sy == "n":
                    break
            while alpha_up_sy != "y" and alpha_up_sy != "n":
                alpha_up_sy = input("Нужны ли заглавные буквы?\n")
                if alpha_up_sy == "y":
                    pas_str += alpha_up
                    break
                if alpha_up_sy == "n":
                    break
            break

while len(correctPassword) != numb_of_sy:
    correctPassword = input("Введите пароль для взлома\n")

while True:
    if pas != correctPassword:
        pas = ""
        for i in range(numb_of_sy):
            pas += pas_str[random.randint(0, len(pas_str) - 1)]
        print("\n", pas)
    else:
        break
print(pas + " is correct")