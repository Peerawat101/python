class nisit :
    def __init__(self,name,lastname,sex,year,department,province):
        self.name = name
        self.lastname = lastname
        self.sex = sex
        self.year = year
        self.department = department
        self.province = province
    def showNisit(self):
        print(self.name,self.lastname,self.sex,self.year,self.department,self.province)
def input_data():
    global name , lastname , sex , year , department , provice
    print('-------------------------introduce yourself---------------------------')
    data = input('name:lastname:sex:year:departm    ent:province  ')
    date = data.split(':')
    name = date[0]
    lastname = date[1]
    sex = date[2]
    year = date[3]
    department = date[4]
    provice = date[5]

input_data()
x = nisit(name,lastname,sex,year,department,provice)
x.showNisit()
