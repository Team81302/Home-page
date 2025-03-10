The database you must create 
----------------------------

CREATE DATABASE students;
USE students;
CREATE TABLE stud_new (
    id INT IDENTITY(1,1) PRIMARY KEY,
    user_name NVARCHAR(100),
    email NVARCHAR(255) UNIQUE,
    password NVARCHAR(255),
    mobile NVARCHAR(20)
);
--------------------------------

then take the Connection string 
Data Source= your SQL Server name ;Initial Catalog=students;Integrated Security=True;Encrypt=True;Trust Server Certificate=True

and then put it to the Connectionstring variable on the code.




good luck 

