-- Script Date: 12/20/2024 12:44 PM  - ErikEJ.SqlCeScripting version 3.5.2.95
CREATE TABLE [Attendance] (
  [Id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
, [employee_id] bigint NOT NULL
, [checkin_time] text NOT NULL
, [checkout_time] text NOT NULL
, [verify_date] text NOT NULL
, [organization_id] bigint NOT NULL
, [Posted_Date_Time] text NULL
, [Local_Date_Time] text NOT NULL
);
