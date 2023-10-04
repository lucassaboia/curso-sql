CREATE OR ALTER PROCEDURE [spListarCursos]
    @Category NVARCHAR(60)
    AS
    DECLARE @CategoryId INT
    SET @CategoryId = (SELECT TOP 1 [Id] FROM [Categoria] WHERE [Nome] = 'Backend')
    SELECT * FROM [Curso] WHERE [CategoriaId] = @CategoryId

    DROP PROCEDURE [spListarCursos]