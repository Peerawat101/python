import os
say_dictionary = {}
def menu():
    global choice
    print('-'*35+'\nพจนานุกรม\n 1.เพิ่มคำศัพท์\n2.แสดงคำศัพท์ทั้งหมด\n3.ลบคำศัพท์\n4.ออกจากโปรแกรม\n'+'-'*35)
    choice = input('Lnput Choice : ')
def addict():
    word = input('เพิ่มคำศัพท์ :')
    typeword = input('ชนิดของคำ(n. , v. , adj. , adv.)')
    mean = input('ความหมายของคำ : ')
    say_dictionary[word] = typeword,mean
    print('เพิ่มคำศัพท์เรียบร้อยแล้ว')
def showdict():
    print('\n\tคำศัพท์ทั้งหมด\n{0: <11}{1: <8}{2}'.format('คำศัพท์' , 'ประเภท' , 'ความหมาย'))
    for key in say_dictionary:
        print('{}{:<3}{}'.format(key,'',say_dictionary[key]))
def deleteee():
    delete_word = input('\nพิมพ์คำศัพท์ที่ต้องการลบ : ')
    yes_no = input('ต้องการลบ {} ใช่หรือไม่ (y/n):'.format(delete_word))
    if yes_no == 'y':
        del say_dictionary[delete_word]
        print('ลบ'+delete_word+'เรียบร้อยแล้ว')
while True:
    menu()
    if choice == '1':
        addict()
    elif choice == '2':
        showdict()
    elif choice == '3':
        deleteee()
    elif choice == '4':
        c = input('Want Close Program y/n: ')
        if c =='y':
            print('Work finish')
        break


