use master
go

if not exists (select *
               from sys.databases
               where name = 'Schedule')
    begin
        create database Schedule
    end
go

use Schedule
go

begin
    -- Bảng giáo viên
    create table Teachers
    (
        TeacherID   varchar(8)    not null,
        TeacherName nvarchar(200) not null,
        constraint PK_Teacher primary key (TeacherID asc)
    )

    -- Bảng môn học
    create table Subjects
    (
        SubjectID   varchar(6)  not null,
        SubjectName nvarchar(6) not null,
        constraint PK_Subject primary key (SubjectID asc)
    )

    -- Bảng ngày trong tuần
    create table DaysOfWeek
    (
        DayID   int          not null, -- 1, 2, 3...
        DayName nvarchar(20) not null, -- Thứ 2, thứ 3...
        constraint PK_Day primary key (DayID asc)
    )

    -- Bảng khung giờ dạy
    create table TimeSlots
    (
        TimeSlotID   int          not null,
        TimeSlotName nvarchar(20) not null, -- Sáng, trưa, chiều
        constraint PK_TimeSlot primary key (TimeSlotID asc)
    )

    -- Bản lịch dạy
    create table TeachingAvailability
    (
        AvailabilityID       int        not null,
        TeacherID            varchar(8) not null,
        SubjectID            varchar(6) not null,
        DayID                int        not null,
        TimeSlotID           int        not null,
        IsMorningAvailable   bit        not null, -- (0 hoặc 1) Cho biết giảng viên có thể dạy vào buổi sáng hay không
        IsAfternoonAvailable bit        not null, -- (0 hoặc 1) Cho biết giảng viên có thể dạy vào buổi chiều hay không
        IsEveningAvailable   bit        not null, -- (0 hoặc 1) Cho biết giảng viên có thể dạy vào buổi tối hay không,
        constraint PK_Availability primary key (AvailabilityID asc)
    )


    alter table TeachingAvailability
        with check
            add
            constraint FK_Teacher foreign key (TeacherID) references Teachers (TeacherID),
            constraint FK_Subject foreign key (SubjectID) references Subjects (SubjectID),
            constraint FK_DaysOfWeek foreign key (DayID) references DaysOfWeek (DayID),
            constraint FK_TimeSlot foreign key (TimeSlotID) references TimeSlots (TimeSlotID)
end
