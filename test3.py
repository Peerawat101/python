print('เลือกเมนูเพื่อทำรายการ')
print('################')
print('กด 1 เลือกเหมาจ่าย')
print('กด 2 เลือกจ่ายเพิ่ม')
choose = int(input(''))
Km = int(input("กรุณาบอกระยะทาง"))
if choose == 1:
    if Km < 25 :
        print('ค่าใช้จ่าย 25 บาท')
    else :
        print('ค่าใช้จ่าย 55 บาท')
if choose == 2 :
    if Km < 25 :
        print('ค่าใช้จ่าย 25 บาท')
    else :
        print('ค่าใช้จ่าย 80 บาท')
          