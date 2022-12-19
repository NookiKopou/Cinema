CREATE TABLE [dbo].[CinemaCartItem] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [movieid]      INT            NULL,
    [price]        INT            NOT NULL,
    [CinemaCartId] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_CinemaCartItem] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_CinemaCartItem_Movie_movieid] FOREIGN KEY ([movieid]) REFERENCES [dbo].[Movie] ([id])
);


GO
CREATE NONCLUSTERED INDEX [IX_CinemaCartItem_movieid]
    ON [dbo].[CinemaCartItem]([movieid] ASC);

