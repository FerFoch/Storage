text = input("Введите текст\n")
vowels = ['a', 'e', 'i', 'o', 'u']
vowel_count = 0
consonant_count = 0
for char in text:
 if char.isalpha() and char != '.':
  if char.lower() in vowels:
   vowel_count += 1
else:
    consonant_count += 1

if vowel_count > consonant_count:
 print("В тексте больше гласных букв")
elif vowel_count < consonant_count:
 print("В тексте больше согласных букв")
else:
 print("В тексте равное количество гласных и согласных букв")