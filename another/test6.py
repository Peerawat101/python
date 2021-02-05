print('ป้อนชื่ออาหารสุดโปรดของคุณ หรือ exit เพื่อออกจากโปรแกรม')
Food_list = []
n = 1
m = 0
while n > 0:
    m=m+1
    print('อาหารโปรดอันดับที่ ',m,end=' ')
    food = input("คือ ")
    Food_list.append(food)
    if food == 'exit':
        continue
for o in range(1,m):
    print(o,'.',Food_list[o-1],end='   ')