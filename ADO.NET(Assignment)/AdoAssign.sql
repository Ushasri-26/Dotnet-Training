create table Students(
StudentId int identity(1,1) primary key,
FullName varchar(100) not null,
Email varchar(100) unique,
Department varchar(50) not null,
YearOfStudy int not null);
create table Courses(
CourseId int identity(1,1) primary key,
CourseName varchar(100) not null,
Credits int not null,
Semester varchar(20) not null);
create table Enrollments(
EnrollmentId int identity(1,1) primary key,
Student int not null foreign  key references Students(StudentId),
CourseId int not null foreign key references Courses(CourseId),
EnrollDate datetime not null,
Grade varchar(5) null);
insert into Students values
('Usha sri','usha@gmail.com','Electronics',4),
('Monika','monika@gmail.com','Computer Science',3),
('Anvith','anvithg@gmail.com','Artificial Intelligence',2),
('Uday Kiran','udaykiran@gmail.com','Civil',1),
('Sravani','sravanil@gmail.com','Mechanical',2);
insert into Courses values
('Data Structures',4,'4-1'),
('Database Systems',3,'3-1'),
('Digital Logic',3,'3-2'),
('Operating Systems',4,'2-1'),
('Networks',3,'1-2');
insert into Enrollments values 
(1,1,getdate(),'A'),
(2,1,'05-08-2024',null),
(1,2,'06-07-2025','B'),
(3,4,'12-12-2025',null),
(4,1,getdate(),'C');
select * from Students
select * from Courses
select * from Enrollments;
--Stored Procedure
--Call stored procedure:
--usp_GetCoursesBySemester @semester
create procedure usp_GetCoursesBySemester
(@semester varchar(30))
as
select CourseId,CourseName,Credits,Semester
from Courses
where Semester =@semester;
