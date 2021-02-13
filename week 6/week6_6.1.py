import sqlite3
conn = sqlite3.connect (r'D:\Peerawat_Python\week 6\example2.db')
c = conn.cursor()
c.execute('''INSERT INTO users (id,fname,lname,email)VALUES(NULL,'A','A','A')''')
c.execute('''INSERT INTO users VALUES (NULL,'B','B','B')''')
conn.commit()
conn.close()