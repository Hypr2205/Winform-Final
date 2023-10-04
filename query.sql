use master
go

if not exists (select *
               from sys.databases
               where name = 'TKB')
    begin
        create database TKB
    end
go

use TKB
go

begin
    create table Teachers
    (
        TeacherID   varchar(8)    not null,
        TeacherName nvarchar(200) not null,
        SubjectID   varchar(6)    not null,
        constraint PK_Teacher primary key (TeacherID asc)
    )

    create table Subjects
    (
        SubjectID   varchar(6)  not null,
        SubjectName nvarchar(6) not null,
        constraint PK_Subject primary key (SubjectID asc)
    )

    create table DaysOfWeek
    (
        DayID   int          not null,
        DayName nvarchar(20) not null,
        constraint PK_Day primary key (DayID asc)
    )

    create table TeachingSchedule
    (
        AvailabilityID       int        not null,
        TeacherID            varchar(8) not null,
        SubjectID            varchar(6) not null,
        DayID                int        not null,
        IsMorningAvailable   bit        not null, -- (0 hoặc 1) Cho biết giảng viên có thể dạy vào buổi sáng hay không
        IsAfternoonAvailable bit        not null, -- (0 hoặc 1) Cho biết giảng viên có thể dạy vào buổi chiều hay không
        IsEveningAvailable   bit        not null, -- (0 hoặc 1) Cho biết giảng viên có thể dạy vào buổi tối hay không,
        constraint PK_Availability primary key (AvailabilityID, TeacherID, SubjectID, DayID)
    )


    alter table TeachingSchedule
        with check
            add
            constraint FK_Teacher foreign key (TeacherID) references Teachers (TeacherID),
            constraint FK_Subject foreign key (SubjectID) references Subjects (SubjectID),
            constraint FK_DaysOfWeek foreign key (DayID) references DaysOfWeek (DayID)
end
