CREATE PROCEDURE [dbo].[GTS_RequestBoard_SelectAll]
AS
	SELECT		rb.[Id],
				COALESCE(COUNT([RequestId]),0)		AS		[Votes],
				[DateCreated]						AS		[Date],
				[Title],
				[Description],
				[RequestType],
				[RequestStatus]
	
	FROM		[dbo].[GTS_RequestBoard]			rb

	JOIN		[dbo].[GTS_RequestTypes]			rt
		ON		rb.[TypeId]					=		rt.[Id]

	JOIN		[dbo].[GTS_RequestStatus]			rs
		ON		rb.[StatusId]				=		rs.[Id]

	LEFT JOIN	[dbo].[GTS_RequestVotes]			rv
		ON		rb.[Id]						=		rv.[RequestId]

	GROUP BY	rb.[id], [DateCreated], [Title], [Description], [RequestType], [RequestStatus]
	ORDER BY	[Votes] DESC

GO
