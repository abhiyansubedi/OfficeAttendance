-- Script Date: 11/19/2024 12:21 PM  - ErikEJ.SqlCeScripting version 3.5.2.95
CREATE TABLE [Organization] (
  [Id] bigint NOT NULL
, [Organization_ID] bigint NOT NULL
, [Username] text NOT NULL
, [Password] text NOT NULL
, [LicenseKey] text NOT NULL
, CONSTRAINT [sqlite_master_PK_Organization] PRIMARY KEY ([Id])
);
