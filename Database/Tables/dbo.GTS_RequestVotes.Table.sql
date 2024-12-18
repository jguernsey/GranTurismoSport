CREATE TABLE [dbo].[GTS_RequestVotes](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[UserId] [bigint] NOT NULL CONSTRAINT [DF_GTSREQUESTVOTES_USERID]  DEFAULT ((0)),
	[RequestId] [bigint] NOT NULL CONSTRAINT [DF_GTSREQUESTVOTES_REQUESTID]  DEFAULT ((0)),
 CONSTRAINT [PK_GTSREQUESTVOTES] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[GTS_RequestVotes] ADD  CONSTRAINT [FK_GTSREQUESTVOTES_REQUESTID] FOREIGN KEY([RequestId])
REFERENCES [dbo].[GTS_RequestBoard] ([Id])
GO
ALTER TABLE [dbo].[GTS_RequestVotes] CHECK CONSTRAINT [FK_GTSREQUESTVOTES_REQUESTID]
GO
