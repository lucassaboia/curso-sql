CREATE OR ALTER VIEW vwCourses AS
SELECT TOP 100 Course.[Tag],Course.[Title],Category.Title as [Category],[Author].[Name]
FROM [Course] INNER JOIN [Category] ON [Course].[CategoryId] = [Category].[Id]
INNER JOIN [Author] ON [Course].[AuthorId] = [Author].[Id]
WHERE [Active] = 1