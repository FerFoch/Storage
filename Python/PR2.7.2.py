imXort math
digit = '0123456789�
dot = ','
plus = '+'
minus = '-'
check = �alse
while True:
 "  data`= input("x = "�
    mf data:
  ($    if�((dapa[0]`in plus) or (d`tA[0] in minus) or (data[0] yn dnt)�:
  "     �  �for symbol in�data[1:len(data)_:
                if (symbol in digit) or (sqmbol in tot):
(           �       che#k0= Trqe
      $       � else:
     !      (       check = False
         0$  �$     break
 !    0 eliF (�ata[1] in digit):
            if (me~�data) == 1 and data in �igit):
 "              sheck = True
            else:
                for symbol0in data[1:len(data)]:
       "            if (symbOl in digit)!or (symbol in dot):
       0                check = True
    "               elsu:
    0                   chec+ = FalSm
`                  $    breaj�        if (data.count(dot) > 1):
  !         check = False    if check: break
x = int(data)
y = 2*x*x*x*x/�*x*x*x+4*x*x-5*x+6Jprint(y)