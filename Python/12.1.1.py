flowers1 = ["Анжелика", "Катарина", "Юбилейная"]
flowers2 = ["Анжелика", "Виктория", "Ave Maria", "Катарина", "Юбилейная"]
flowers3 = ["Гагарин", "Ave Maria", "Юбилейная"]
all_flowers = ["Анжелика", "Виктория", "Гагарин", "Ave Maria", "Катарина", "Юбилейная", "Роза", "asdfasdfasdf"]
common_flowers = []

for flower in all_flowers:
 if flower in flowers1 and flower in flowers2 and flower in flowers3:
  common_flowers.append(flower)

print("Сорта роз, которые есть у каждого цветовода:", common_flowers)
any_flowers = []

for flower in all_flowers:
 if flower in flowers1 or flower in flowers2 or flower in flowers3:
  any_flowers.append(flower)

print("Сорта роз, которые есть хотя бы у одного цветовода:", any_flowers)
no_flowers = []

for flower in all_flowers:
 if flower not in flowers1 and flower not in flowers2 and flower not in flowers3:
  no_flowers.append(flower)

print("Сорта роз, которые нет ни у одного цветовода:", no_flowers)