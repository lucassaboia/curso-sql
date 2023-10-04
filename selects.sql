SELECT top 100 Curso.Nome as [Nome do Curso], Categoria.Nome as [Categoria], Categoria.Id as [ID]
    FROM[Curso] LEFT JOIN [Categoria] ON [Curso].[CategoriaId] = [Categoria].Id