CREATE OR ALTER VIEW vwContagemCursosPorCategoria AS  

SELECT TOP 100 [Categoria].[Nome],([Curso].[CategoriaId]) as [Cursos]
 FROM       [Categoria] 
 INNER JOIN [Curso] 
 ON         Curso.CategoriaId = Categoria.Id
 GROUP BY   [Categoria].[Nome], [Curso].[CategoriaId]