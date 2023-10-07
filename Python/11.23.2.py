text = input("Введите текст на русском языке: ").lower()
letters = [i for i in text if i.isalpha()]
letter_counts = {}
for letter in letters:
    if letter in letter_counts:
        letter_counts[letter] += 1
    else:
        letter_counts[letter] = 1

for letter, count in sorted(letter_counts.items()):
    if count > 5:
        print(f"{letter} - {count} раз")
    else:
        print(f"{letter} - {count} раза")