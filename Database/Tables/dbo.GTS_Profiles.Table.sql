CREATE TABLE [dbo].[GTS_Profiles](
	[ProfileId] [bigint] IDENTITY(1,1) NOT NULL,
	[Id] [nvarchar](32) NOT NULL CONSTRAINT [DF_GTSPROFILES_ID]  DEFAULT (''),
	[ProfileNumber] [bigint] NOT NULL CONSTRAINT [DF_GTSPROFILES_PROFILENUMBER]  DEFAULT ((0)),
	[ProfileStatus] [bigint] NOT NULL CONSTRAINT [DF_GTSPROFILES_PROFILESTATUS]  DEFAULT ((0)),
	[CountryId] [bigint] NOT NULL CONSTRAINT [DF_GTSPROFILES_COUNTRYID]  DEFAULT ((0)),
	[CreateDate] [datetime] NOT NULL CONSTRAINT [DF_GTSPROFILES_CREATEDATE]  DEFAULT ('1753-01-01'),
 CONSTRAINT [PK_GTSPROFILES] PRIMARY KEY CLUSTERED 
(
	[ProfileId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
CREATE NONCLUSTERED INDEX [GTS_Profiles_CountryId_37343] ON [dbo].[GTS_Profiles]
(
	[CountryId] ASC
)
INCLUDE ( 	[ProfileId],
	[Id],
	[ProfileNumber],
	[ProfileStatus],
	[CreateDate]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [GTS_Profiles_Id_0D615] ON [dbo].[GTS_Profiles]
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [GTS_Profiles_Id_F3355] ON [dbo].[GTS_Profiles]
(
	[Id] ASC
)
INCLUDE ( 	[ProfileId],
	[ProfileNumber]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [GTS_Profiles_ProfileNumber_C395D] ON [dbo].[GTS_Profiles]
(
	[ProfileNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [GTS_Profiles_ProfileStatus_76AB8] ON [dbo].[GTS_Profiles]
(
	[ProfileStatus] ASC
)
INCLUDE ( 	[CountryId]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [GTS_Profiles_ProfileStatus_CountryId_4719C] ON [dbo].[GTS_Profiles]
(
	[ProfileStatus] ASC,
	[CountryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [GTS_Profiles_ProfileStatus_CountryId_E5D51] ON [dbo].[GTS_Profiles]
(
	[ProfileStatus] ASC,
	[CountryId] ASC
)
INCLUDE ( 	[ProfileId],
	[ProfileNumber]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
GO
ALTER TABLE [dbo].[GTS_Profiles] ADD  CONSTRAINT [FK_GTSPROFILES_COUNTRYID] FOREIGN KEY([CountryId])
REFERENCES [dbo].[GTS_Countries] ([CountryId])
GO
ALTER TABLE [dbo].[GTS_Profiles] CHECK CONSTRAINT [FK_GTSPROFILES_COUNTRYID]
GO
