CREATE TABLE [dbo].[GAMES] (
    [ID]           INT            NOT NULL,
    [Game_Name]    VARCHAR (255)  NULL,
    [Category]     INT            NULL,
    [Min_Players]  INT            NULL,
    [Max_Players]  INT            NULL,
    [Sug_Players]  INT            NULL,
    [Game_Desc]    VARCHAR (8000) NULL,
    [Playtime_Min] INT            NULL,
    [Playtime_Max] INT            NULL,
    [ReviewScore]  FLOAT (53)     NULL,
    [Num_Reviews]  INT            NULL,
    [Complexity]   FLOAT (53)     NULL,
    [Age_Min]      INT            NULL,
    [Age_Max]      INT            NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

