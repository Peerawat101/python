import sqlite3
conn = sqlite3.connect (r'D:\Peerawat_Python\week 6\example2.db')
c = conn.cursor()
c.execute ('''CREATE TABLE users(id integer PRIMARY KEY AUTOINCREMENT,
    fname varchar(30) NOT NULL,
    lname varchar(30) NOT NULL,
    email varchar(100) NOT NULL)''')
conn.commit()
conn.close()