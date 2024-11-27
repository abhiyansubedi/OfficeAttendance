-- Script Date: 10/23/2024 10:50 AM  - ErikEJ.SqlCeScripting version 3.5.2.95
CREATE TABLE [Users] (
  [Id] INTEGER NOT NULL
, [Username ] TEXT NOT NULL
, [Password] TEXT NOT NULL
, CONSTRAINT [PK_Users] PRIMARY KEY ([Id])
);
