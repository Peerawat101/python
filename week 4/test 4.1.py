import os
print('โปรแกรมร้านค้าออนไลน์')
print('-'*40)
x = 0
choose_list= ['1.ยาดม','2.น้ำเปล่า','3.มาม่า','4.สบู่','5.แปรงฟัน','6.ออกจากฟังก์']
price_list= ['ราคา 15 บาท',' ราคา 10 บาท',' ราคา 20 บาท','ราคา 30 บาท','ราคา 25 บาท']
pig_list = [0,0,0,0,0,0]
def menu():
    global choice
    print('1.แสดงรายการสินค้า\n 2. หยิบสินค้าเข้าตะกร้า\n 3. แสดงรายจำนวนและราคาของสินค้าที่หยิบ\n 4.หยิบสินค้าออกจากตะกร้า\n 5. ปิดโปรแกรม')
    choice = int(input('กรุณาเลือกทำรายการ'))
def choose_def():
    for x in range(0,6):
        print(choose_list[x],' ',price_list[x])
def choose_def():
    for x in range(0,6):
        print(choose_list[x])
    pig = int(input('เลือกหยิบสินค้า'))
    if pig == 1:
        pig_list [0] +=1
    elif pig == 2:
        pig_list [1] +=1
    elif pig == 3:
        pig_list [2] +=1
    elif pig == 4:
        pig_list [3] +=1
    elif pig == 5:
        pig_list [4] +=1
    elif pig == 6:
        pig_list [5] +=1
    elif pig ==7:
        menu()
    os.system('cls')
def showlist_def():
    print('-'*20,'สินค้าที่คุณได้หยิบไป','-'*20)
    print('-'*5,'สินค้า','-'*5,'จำนวน','-'*5,'ราคา')
    for x in range(0,6):
        print('-'*5,choose_list[x],'-'*10,pig_list[x],'-'*10,pig_list[x]*price_list[x])

def choose_def():
    for x in range(0,6):
        print(choose_list[x])
    pig = int(input('เลือกหยิบสินค้า'))
    if pig == 1:
        pig_list [0] -=1
    elif pig == 2:
        pig_list [1] -=1
    elif pig == 3:
        pig_list [2] -=1
    elif pig == 4:
        pig_list [3] -=1
    elif pig == 5:
        pig_list [4] -=1
    elif pig == 6:
        pig_list [5] -=1
    elif pig ==7:
        menu()
    os.system('cls')


while(True):
    menu()
    if choice == 1 :
        os.system('cls')
        choose_def()
    elif choice == 2:
        os.system('cls')
        choose_def()
    elif choice == 3:
        os.system('cls')
        showlist_def()
    elif choice == 4:
        os.system('cls')
        showlist_def()
    elif choice == 5:
        c = input('หากต้องการปิดโปรแกรม y/n')
        if c =='y':
            print('จบการทำงาน')
        break
    else :
        continue