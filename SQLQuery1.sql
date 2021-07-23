create table employee
(EmpId int identity(1,1) primary key,
EmpName varchar(20),
EmpSalary money,EmpDob date,
EmpAddress varchar(30),
EmpStatus varchar(8) check(EmpStatus in('active','inactive')));

insert into employee values ('Dhesh',75000,'1999-08-30','Saligramam,Chennai','active');
insert into employee values ('Hari',65000,'1999-12-24','Katpadi,Vellore','active');
insert into employee values ('Dhivakar',95000,'2000-04-30','Kattur,Trichy','active');
insert into employee values ('Fazil',70000,'2000-04-28','Senji,Villupuram','active');
insert into employee values ('Theo',75000,'1998-07-30','Melur,Madurai','active');
insert into employee values ('Prasanna',85000,'2000-10-27','Saligramam,Chennai','active');
insert into employee values ('Bharath',59000,'1999-08-31','Porur,Chennai','inactive');
insert into employee values ('Shiva',90000,'1997-05-30','Vadapalani,Chennai','active');
insert into employee values ('Muthukumaran',99000,'1997-05-30','Melur,Madurai','active');
insert into employee values ('Balaji',72000,'1999-04-30','Saligramam,Chennai','inactive');

insert into employee values ('Saikiran',70000,'1999-12-20','Nellore,Andhra','inactive');
insert into employee values ('Surya',95000,'2000-04-30','Kattur,Trichy','active');
insert into employee values ('Tripathi',70000,'2000-04-28','AAA,UP','inactive');
insert into employee values ('Srikanth',70000,'2000-05-30','PeriyarNagar,Chennai','active');
insert into employee values ('Manolin',80000,'2000-09-27','Redhills,Chennai','inactive');
insert into employee values ('Vinoba',89000,'2000-08-31','Porur,Chennai','active');
insert into employee values ('Hemalatha',90000,'2000-12-30','Vadapalani,Chennai','active');
insert into employee values ('ShakthiAbirami',65000,'1999-05-28','MMDA,Chennai','active');
insert into employee values('Dheeraj',80000,'2000-07-18','Anna nagar,Chennai','active');
insert into employee values ('LakshmiPriya',75000,'2000-07-13','Ennore,Chennai','active');

insert into employee values ('Aarthi',65000,'1999-09-20','MaduravoyalChennai','inactive');
insert into employee values ('Nandhini',95000,'2000-04-29','Poonamalle,Chennai','inactive');
insert into employee values ('Niranjani',75000,'1999-04-28','CMBD,Chennai','active');
insert into employee values ('Trishna',55000,'2000-09-15','Porur,Chennai','inactive');
insert into employee values ('Suganthi',85000,'2000-05-27','Redhills,Chennai','active');
insert into employee values ('ManjuPriya',65000,'1999-10-31','Vadapalani,Chennai','inactive');
insert into employee values ('Navreen',86000,'1999-12-30','Central,Chennai','inactive');
insert into employee values ('Bersey',70000,'2000-05-28','MMDA,Chennai','active');
insert into employee values('Sushmitha',85000,'1999-08-15','Ennore,Chennai','inactive');
insert into employee values('Shivani',65000,'2000-05-19','Kilpauk,Chennai','active');

insert into employee values('vignesh',75000,'1999-02-28','kodambakkam,chennai','inactive');
insert into employee values('Arun',65000,'1999-04-08','valasaravakkam,chennai','active');
insert into employee values('pradeep',75000,'1999-05-18','vadapalani,chennai','inactive');
insert into employee values('rahul',85000,'1999-07-03','porur,chennai','active');
insert into employee values('udhaya',65000,'1999-09-21','virugambakkam,chennai','inactive');
insert into employee values('Boobalan',76000,'1999-03-28','kodambakkam,chennai','active');
insert into employee values('Ajith',55000,'1999-02-28','Mylapore,chennai','inactive');
insert into employee values('kailash',75000,'1999-05-28','virugambakkam,chennai','active');
insert into employee values('lingesh',75000,'1999-06-28','Anna nagar,chennai','inactive');
insert into employee values('Ranjith',75000,'1999-07-28','Tnagar,chennai','active');

insert into employee values('Andrew',75000,'1999-01-28','kodambakkam,chennai','inactive');
insert into employee values('Kevin',65000,'1999-02-08','valasaravakkam,chennai','active');
insert into employee values('Tharun',75000,'1999-03-18','vadapalani,chennai','inactive');
insert into employee values('Umesh',85000,'1999-04-03','porur,chennai','active');
insert into employee values('Madhan',65000,'1999-05-21','virugambakkam,chennai','inactive');
insert into employee values('Aadhitya',76000,'1999-06-28','kodambakkam,chennai','active');
insert into employee values('Mukilan',55000,'1999-07-28','Mylapore,chennai','inactive');
insert into employee values('Raj',75000,'1999-08-28','virugambakkam,chennai','active');
insert into employee values('vijay',75000,'1999-10-28','Anna nagar,chennai','inactive');
insert into employee values('Ajay',75000,'1999-11-28','Tnagar,chennai','active');

insert into employee values ('Santhosh',77000,'1999-08-20','gandhipuram,kovai','active');
insert into employee values ('Gokul',68000,'1999-2-14','Katpadi,Vellore','active');
insert into employee values ('Bala',65000,'2000-02-23','Kattur,Trichy','active');
insert into employee values ('Charan',80000,'2000-03-18','Senji,Villupuram','active');
insert into employee values ('Visvesh',79000,'1994-07-20','Melur,Madurai','active');
insert into employee values ('Sharmila',83000,'2001-10-27','Saligramam,Chennai','active');
insert into employee values ('Viveka',50000,'1996-04-24','Porur,Chennai','inactive');
insert into employee values ('Reshma',70000,'1997-06-30','Vadapalani,Chennai','active');
insert into employee values ('Karthik',96000,'1999-05-23','Melur,Madurai','active');
insert into employee values ('Sameer',86000,'1999-04-23','Adyar,Chennai','active');

insert into employee values ('Guna',79000,'1999-03-30','avadi,Chennai','inactive');
insert into employee values ('Sanjey',80000,'1998-11-20','mnm,chennai','inactive');
insert into employee values ('Dinesh',89000,'2000-04-30','kattur,Trichy','active');
insert into employee values ('Deepika',78000,'2000-04-28','porur,chennai','inactive');
insert into employee values ('Guru',79000,'2000-02-26','PeriyarNagar,Chennai','active');
insert into employee values ('Varun',87000,'2000-09-27','Redhills,Chennai','inactive');
insert into employee values ('Saran',89000,'2002-04-28','Porur,Chennai','inactive');
insert into employee values ('Sriram',60000,'2000-11-30','Vadapalani,Chennai','active');
insert into employee values ('Arul',69000,'1998-04-28','saidapet,Chennai','active');
insert into employee values('Ajith',84000,'2001-06-18','Anna nagar,Chennai','active');

insert into employee values ('Hritish',65000,'2000-07-19','BesantNagar,Chennai','active');
insert into employee values ('Shravan',70000,'1999-12-20','Vijayawada,Andhra','inactive');
insert into employee values ('Alagupandi',95000,'2000-04-30','Bodi,Theni','active');
insert into employee values ('Ezhil',70000,'2000-08-29','Thiruvanmiyur,Chennai','inactive');
insert into employee values ('Joshua',85000,'1999-05-30','PeriyarNagar,Chennai','active');
insert into employee values ('Gokilnath',80000,'2000-09-27','Arumbakkam,Chennai','inactive');
insert into employee values ('Eashwar',75000,'1999-06-30','Porur,Chennai','active');
insert into employee values ('Kaarthik',85000,'2000-08-30','Mylapore,Chennai','inactive');
insert into employee values ('Jebinesh',65000,'2000-02-12','Palayankottai,Tirunelveli','active');
insert into employee values('Ajay Gopal',85000,'2000-08-18','Avadi,Chennai','inactive');

insert into employee values ('Padmanaban',85000,'2000-02-23','Porur,Chennai','inactive');
insert into employee values ('AAkash',65000,'1999-03-13','Maduravoyal,Chennai','inactive');
insert into employee values ('Balakumar',80000,'2000-06-19','Mellur,Madurai','active');
insert into employee values ('Harish',65000,'1999-07-18','Maduravoyal,Chennai','inactive');
insert into employee values ('Keerthi',85000,'2000-05-15','Porur,Chennai','active');
insert into employee values ('Kishore',85000,'2000-05-13','Chrompet,Chennai','active');
insert into employee values ('Jaggadesh',68000,'1999-10-31','Vadapalani,Chennai','active');
insert into employee values ('Kalai',88000,'1999-12-19','Tambaram,Chennai','inactive');
insert into employee values ('Dhinesh',80000,'2000-06-28','Anna Nagar,Chennai','inactive');
insert into employee values('Yogesh',95000,'1999-04-12','Guindy,Chennai','inactive');

insert into employee values ('Arvinth',95000,'2000-04-23','T.Nagar,Chennai','inactive');
insert into employee values ('Thivakar',55000,'1999-03-10','Maduravoyal,Chennai','inactive');
insert into employee values ('Sundar',90000,'2000-02-19','Mellur,Madurai','active');
insert into employee values ('Sanjay',65000,'1999-07-28','CMBD,Chennai','inactive');
insert into employee values ('Sudharson',75000,'2000-05-25','Porur,Chennai','active');
insert into employee values ('Jayasuriya',55000,'2000-05-23','Chrompet,Chennai','active');
insert into employee values ('Madesh',88000,'1999-11-21','Vadapalani,Chennai','active');
insert into employee values ('Chandru',86000,'1999-11-13','Central,Chennai','inactive');
insert into employee values ('Ezhil',70000,'2000-02-24','Porur,Chennai','inactive');
insert into employee values('Jerson',85000,'1999-02-12','Central,Chennai','inactive');

create proc proc_employee
as
select EmpId,EmpName,EmpSalary,EmpDob,EmpAddress,EmpStatus from employee

exec proc_employee

select * from employee
