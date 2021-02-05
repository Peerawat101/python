print('ป้อนชื่ออาหารสุดโปรดของคุณ หรือ exit เพื่อออกจากโปรแกรม')
Food_list = []
m = 0
while (True):
    m=m+1
    print('อาหารโปรดอันดับที่ ',m,end=' ')
    food = input("คือ ")
    Food_list.append(food)
    if food == 'exit':
        break
print('อาหารโปรดของคุณมีดังนี้')
for o in range(1,m):
    print(o,'.',Food_list[o-1],end='   ')