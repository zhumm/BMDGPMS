if exists (select * from sysobjects where id = OBJECT_ID('[Menu]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [Menu]

CREATE TABLE [Menu] (
[ID] [uniqueidentifier]  NOT NULL,
[MenuOrder] [int]  NULL,
[ChineseName] [nvarchar]  (50) NULL,
[EnglishName] [varchar]  (50) NULL,
[ResURL] [varchar]  (10) NULL,
[Type] [int]  NULL,
[Enable] [bit]  NULL,
[Creater] [varchar]  (50) NULL,
[CreateTime] [datetime]  NULL DEFAULT (getdate()),
[Modifier] [nvarchar]  (50) NULL,
[ModifyTime] [datetime]  NULL DEFAULT (getdate()),
[Remark] [nvarchar]  (50) NULL,
[ParentId] [uniqueidentifier]  NULL,
[ICON] [varchar]  (50) NULL)

ALTER TABLE [Menu] WITH NOCHECK ADD  CONSTRAINT [PK_Menu] PRIMARY KEY  NONCLUSTERED ( [ID] )
if exists (select * from sysobjects where id = OBJECT_ID('[Role]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [Role]

CREATE TABLE [Role] (
[ID] [uniqueidentifier]  NOT NULL,
[ChineseName] [nvarchar]  (50) NULL,
[EnglishName] [varchar]  (50) NULL,
[Type] [int]  NULL,
[Enable] [bit]  NULL,
[Creater] [varchar]  (50) NULL,
[CreateTime] [datetime]  NULL DEFAULT (getdate()),
[Modifier] [nvarchar]  (50) NULL,
[ModifyTime] [datetime]  NULL DEFAULT (getdate()),
[Remark] [nvarchar]  (50) NULL)

ALTER TABLE [Role] WITH NOCHECK ADD  CONSTRAINT [PK_Role] PRIMARY KEY  NONCLUSTERED ( [ID] )
if exists (select * from sysobjects where id = OBJECT_ID('[RoleMenu]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [RoleMenu]

CREATE TABLE [RoleMenu] (
[ID] [uniqueidentifier]  NOT NULL,
[RoleId] [uniqueidentifier]  NULL,
[MenuId] [uniqueidentifier]  NULL,
[Enable] [bit]  NULL,
[Creater] [varchar]  (50) NULL,
[CreateTime] [datetime]  NULL DEFAULT (getdate()),
[Modifier] [nvarchar]  (50) NULL,
[ModifyTime] [datetime]  NULL DEFAULT (getdate()))

ALTER TABLE [RoleMenu] WITH NOCHECK ADD  CONSTRAINT [PK_RoleMenu] PRIMARY KEY  NONCLUSTERED ( [ID] )
if exists (select * from sysobjects where id = OBJECT_ID('[sysdiagrams]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [sysdiagrams]

CREATE TABLE [sysdiagrams] (
[name] [nvarchar]  (128) NOT NULL,
[principal_id] [int]  NOT NULL,
[diagram_id] [int]  IDENTITY (1, 1)  NOT NULL,
[version] [int]  NULL,
[definition] [varbinary]  (MAX) NULL)

ALTER TABLE [sysdiagrams] WITH NOCHECK ADD  CONSTRAINT [PK_sysdiagrams] PRIMARY KEY  NONCLUSTERED ( [name],[principal_id],[diagram_id] )
SET IDENTITY_INSERT [sysdiagrams] ON


SET IDENTITY_INSERT [sysdiagrams] OFF
if exists (select * from sysobjects where id = OBJECT_ID('[SysUser]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [SysUser]

CREATE TABLE [SysUser] (
[ID] [uniqueidentifier]  NOT NULL,
[UserName] [varchar]  (50) NULL,
[TrueName] [nvarchar]  (50) NULL,
[UserType] [int]  NULL,
[Sex] [int]  NULL,
[BirthDay] [datetime]  NULL,
[Password] [varchar]  (50) NULL,
[LoginIP] [varchar]  (50) NULL,
[LoginTime] [datetime]  NULL,
[LastLoginIP] [varchar]  (50) NULL,
[LastLoginTime] [datetime]  NULL,
[Enable] [bit]  NULL,
[Remark] [nvarchar]  (50) NULL,
[Creater] [varchar]  (50) NULL,
[CreateTime] [datetime]  NULL DEFAULT (getdate()),
[Modifier] [nvarchar]  (50) NULL,
[ModifyTime] [datetime]  NULL DEFAULT (getdate()))

ALTER TABLE [SysUser] WITH NOCHECK ADD  CONSTRAINT [PK_SysUser] PRIMARY KEY  NONCLUSTERED ( [ID] )
INSERT [SysUser] ([ID],[UserName],[TrueName],[BirthDay],[Password],[Enable],[Remark]) VALUES ( N'f92a95e1-b32b-4f07-b5e8-a61900fd47ae',N'1',N'2',N'2016/6/2 0:00:00',N'4',0,N'6')
INSERT [SysUser] ([ID],[UserName],[TrueName],[BirthDay],[Password],[Enable],[Remark],[Creater],[CreateTime]) VALUES ( N'0b86dea1-9400-4cb4-943b-a61900fdf057',N'1',N'2',N'2016/6/2 0:00:00',N'3',0,N'4',N'admin',N'2016/6/2 15:24:27')
INSERT [SysUser] ([ID],[UserName],[TrueName],[Sex],[BirthDay],[Password],[Enable],[Remark],[Creater],[CreateTime]) VALUES ( N'8c12dcc1-46e4-48eb-ae03-a6190101c8e0',N'test',N'测试用户',1,N'2016/6/1 0:00:00',N'1',0,N'是是是',N'admin',N'2016/6/2 15:38:33')
INSERT [SysUser] ([ID],[UserName],[TrueName],[UserType],[Sex],[Password],[Enable],[Remark],[Creater],[CreateTime]) VALUES ( N'f79d0096-ee26-4811-aa38-a6190104d21c',N'test1',N'特色团1',2,0,N'1',1,N'特色团',N'admin',N'2016/6/2 15:49:37')
if exists (select * from sysobjects where id = OBJECT_ID('[UserMenu]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [UserMenu]

CREATE TABLE [UserMenu] (
[ID] [uniqueidentifier]  NOT NULL,
[UserId] [uniqueidentifier]  NULL,
[MenuId] [uniqueidentifier]  NULL,
[Enable] [bit]  NULL,
[Creater] [varchar]  (50) NULL,
[CreateTime] [datetime]  NULL DEFAULT (getdate()),
[Modifier] [nvarchar]  (50) NULL,
[ModifyTime] [datetime]  NULL DEFAULT (getdate()))

ALTER TABLE [UserMenu] WITH NOCHECK ADD  CONSTRAINT [PK_UserMenu] PRIMARY KEY  NONCLUSTERED ( [ID] )
if exists (select * from sysobjects where id = OBJECT_ID('[UserRole]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [UserRole]

CREATE TABLE [UserRole] (
[ID] [uniqueidentifier]  NOT NULL,
[UserId] [uniqueidentifier]  NULL,
[RoleId] [uniqueidentifier]  NULL,
[Enable] [bit]  NULL,
[Creater] [varchar]  (50) NULL,
[CreateTime] [datetime]  NULL DEFAULT (getdate()),
[Modifier] [nvarchar]  (50) NULL,
[ModifyTime] [datetime]  NULL DEFAULT (getdate()))

ALTER TABLE [UserRole] WITH NOCHECK ADD  CONSTRAINT [PK_UserRole] PRIMARY KEY  NONCLUSTERED ( [ID] )
