import sqlite3
def insertTousers (fname,lname,email):
    try :
       conn = sqlite3.connect (r'D:\Peerawat_Python\week 6\example2.db')
       c = conn.cursor()
       sql = ''' INSERT INTO users (fname,lname,email)VALUES (?,?,?)'''
       data = (fname,lname,email)
       c.execute(sql,data)
       conn.commit()
       c.close()
    except sqlite3.Error as e:
        print('Failed to insert : ',e)
    finally :
        if conn :
            conn.close()
insertTousers('Peerawat','Wannaaudom','peerawat.wa@kkumail.com')
insertTousers('Jirawat','nongkong','jirawat@gmail.com')