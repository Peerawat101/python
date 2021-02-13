import sqlite3
def insert_data(fname,lname,email) :
    try :
        conn = sqlite3.connect (r'D:\Peerawat_Python\week 6\example2.db')
        c = conn.cursor()
        sql = '''INSERT INTO users (fname,lname,email) VALUES (?,?,?)'''
        data = (fname,lname,email)
        c.execute(sql,data)
        conn.commit()
        conn.close()

    except sqlite3.Error as e :
        print('Failed to insert : ',e)
    finally :
        if conn :
            conn.close()

def input_data() :
    global data , a , b , c , text
    data = input()
    text = data.split(':')
    a = text[0]
    b = text[1]
    c = text[2]
input_data()
insert_data(a,b,c)
