 IF NOT EXISTS(SELECT * FROM sys.schemas WHERE [name] = N'FirstRow')      
     EXEC (N'CREATE SCHEMA FirstRow')                                   
 GO                                                               
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Blog_Comentarios'  AND sc.name = N'FirstRow'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'Blog_Comentarios'  AND sc.name = N'FirstRow'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [FirstRow].[Blog_Comentarios]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[FirstRow].[Blog_Comentarios]
(
   [id_Blog] int  NOT NULL,
   [id_Comentario] int  NOT NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'FirstRow.Blog_Comentarios',
        N'SCHEMA', N'FirstRow',
        N'TABLE', N'Blog_Comentarios'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Blog_Imagenes'  AND sc.name = N'FirstRow'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'Blog_Imagenes'  AND sc.name = N'FirstRow'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [FirstRow].[Blog_Imagenes]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[FirstRow].[Blog_Imagenes]
(
   [id_Blog] int  NOT NULL,
   [id_Imagen] int  NOT NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'FirstRow.Blog_Imagenes',
        N'SCHEMA', N'FirstRow',
        N'TABLE', N'Blog_Imagenes'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Blog_Stories'  AND sc.name = N'FirstRow'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'Blog_Stories'  AND sc.name = N'FirstRow'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [FirstRow].[Blog_Stories]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[FirstRow].[Blog_Stories]
(
   [id_Blog] int  NOT NULL,
   [id_Storie] int  NOT NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'FirstRow.Blog_Stories',
        N'SCHEMA', N'FirstRow',
        N'TABLE', N'Blog_Stories'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Blogs'  AND sc.name = N'FirstRow'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'Blogs'  AND sc.name = N'FirstRow'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [FirstRow].[Blogs]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[FirstRow].[Blogs]
(
   [id] int  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [imagen_principal] varchar(100)  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [titulo] varchar(50)  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [descripcion] varchar(100)  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR(MAX) according to character set mapping for latin1 character set
   */

   [text_1] varchar(max)  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR(MAX) according to character set mapping for latin1 character set
   */

   [text_2] varchar(max)  NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR(MAX) according to character set mapping for latin1 character set
   */

   [text_3] varchar(max)  NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [citacion] varchar(100)  NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [slug] varchar(100)  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [usuario] varchar(20)  NOT NULL,
   [categoria] int  NOT NULL,
   [pais] int  NOT NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'FirstRow.Blogs',
        N'SCHEMA', N'FirstRow',
        N'TABLE', N'Blogs'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Categorias'  AND sc.name = N'FirstRow'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'Categorias'  AND sc.name = N'FirstRow'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [FirstRow].[Categorias]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[FirstRow].[Categorias]
(
   [id] int IDENTITY(1, 1)  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [nombre] varchar(45)  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR(MAX) according to character set mapping for latin1 character set
   */

   [descripcion] varchar(max)  NOT NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'FirstRow.Categorias',
        N'SCHEMA', N'FirstRow',
        N'TABLE', N'Categorias'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Ciudades'  AND sc.name = N'FirstRow'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'Ciudades'  AND sc.name = N'FirstRow'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [FirstRow].[Ciudades]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[FirstRow].[Ciudades]
(
   [id] int  NOT NULL,
   [id_pais] int  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [nombre] varchar(45)  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [descripcion] varchar(100)  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [image] varchar(100)  NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'FirstRow.Ciudades',
        N'SCHEMA', N'FirstRow',
        N'TABLE', N'Ciudades'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Comentarios'  AND sc.name = N'FirstRow'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'Comentarios'  AND sc.name = N'FirstRow'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [FirstRow].[Comentarios]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[FirstRow].[Comentarios]
(
   [id] int IDENTITY(1, 1)  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [texto] varchar(45)  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [estrellas] varchar(45)  NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [nickname] varchar(20)  NOT NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'FirstRow.Comentarios',
        N'SCHEMA', N'FirstRow',
        N'TABLE', N'Comentarios'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Dias'  AND sc.name = N'FirstRow'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'Dias'  AND sc.name = N'FirstRow'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [FirstRow].[Dias]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[FirstRow].[Dias]
(
   [id] int  NOT NULL,
   [id_experiencia] int  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [nombre_dia] varchar(45)  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [titulo] varchar(45)  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR(MAX) according to character set mapping for latin1 character set
   */

   [descipcion] varchar(max)  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [imagen] varchar(50)  NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'FirstRow.Dias',
        N'SCHEMA', N'FirstRow',
        N'TABLE', N'Dias'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Empresas'  AND sc.name = N'FirstRow'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'Empresas'  AND sc.name = N'FirstRow'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [FirstRow].[Empresas]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[FirstRow].[Empresas]
(

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [nickname] varchar(20)  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [email] varchar(50)  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [password] varchar(100)  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [image] varchar(100)  NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [background_image] varchar(100)  NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [name] varchar(100)  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [firstname] varchar(100)  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [secondname] varchar(100)  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [facebook] varchar(100)  NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [twitter] varchar(100)  NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [cif] varchar(20)  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [direccion] varchar(45)  NOT NULL,
   [fechaCreacion] datetime2(0)  NOT NULL,
   [pais] int IDENTITY(1, 1)  NOT NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'FirstRow.Empresas',
        N'SCHEMA', N'FirstRow',
        N'TABLE', N'Empresas'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Experiencia_Comentarios'  AND sc.name = N'FirstRow'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'Experiencia_Comentarios'  AND sc.name = N'FirstRow'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [FirstRow].[Experiencia_Comentarios]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[FirstRow].[Experiencia_Comentarios]
(
   [id_Experiencia] int  NOT NULL,
   [id_Comentario] int  NOT NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'FirstRow.Experiencia_Comentarios',
        N'SCHEMA', N'FirstRow',
        N'TABLE', N'Experiencia_Comentarios'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Experiencia_Imagenes'  AND sc.name = N'FirstRow'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'Experiencia_Imagenes'  AND sc.name = N'FirstRow'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [FirstRow].[Experiencia_Imagenes]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[FirstRow].[Experiencia_Imagenes]
(
   [id_Experiencia] int  NOT NULL,
   [id_Imagen] int  NOT NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'FirstRow.Experiencia_Imagenes',
        N'SCHEMA', N'FirstRow',
        N'TABLE', N'Experiencia_Imagenes'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Experiencia_Incluido'  AND sc.name = N'FirstRow'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'Experiencia_Incluido'  AND sc.name = N'FirstRow'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [FirstRow].[Experiencia_Incluido]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[FirstRow].[Experiencia_Incluido]
(
   [id_experiencia] int  NOT NULL,
   [id_incluido] int  NOT NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'FirstRow.Experiencia_Incluido',
        N'SCHEMA', N'FirstRow',
        N'TABLE', N'Experiencia_Incluido'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Experiencia_Stories'  AND sc.name = N'FirstRow'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'Experiencia_Stories'  AND sc.name = N'FirstRow'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [FirstRow].[Experiencia_Stories]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[FirstRow].[Experiencia_Stories]
(
   [id_experiencia] int  NOT NULL,
   [id_storie] int  NOT NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'FirstRow.Experiencia_Stories',
        N'SCHEMA', N'FirstRow',
        N'TABLE', N'Experiencia_Stories'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Experiencias'  AND sc.name = N'FirstRow'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'Experiencias'  AND sc.name = N'FirstRow'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [FirstRow].[Experiencias]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[FirstRow].[Experiencias]
(
   [id] int IDENTITY(1, 1)  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [nombre] varchar(45)  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [titulo] varchar(45)  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [descripcion] varchar(45)  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [slug] varchar(100)  NOT NULL,
   [pais] int  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [empresa] varchar(20)  NOT NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'FirstRow.Experiencias',
        N'SCHEMA', N'FirstRow',
        N'TABLE', N'Experiencias'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Imagenes'  AND sc.name = N'FirstRow'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'Imagenes'  AND sc.name = N'FirstRow'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [FirstRow].[Imagenes]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[FirstRow].[Imagenes]
(
   [id] int IDENTITY(1, 1)  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [name] varchar(100)  NOT NULL,
   [mode] int  NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'FirstRow.Imagenes',
        N'SCHEMA', N'FirstRow',
        N'TABLE', N'Imagenes'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Incluidos'  AND sc.name = N'FirstRow'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'Incluidos'  AND sc.name = N'FirstRow'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [FirstRow].[Incluidos]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[FirstRow].[Incluidos]
(
   [id] int  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [titulo] varchar(50)  NOT NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'FirstRow.Incluidos',
        N'SCHEMA', N'FirstRow',
        N'TABLE', N'Incluidos'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Paises'  AND sc.name = N'FirstRow'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'Paises'  AND sc.name = N'FirstRow'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [FirstRow].[Paises]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[FirstRow].[Paises]
(
   [id] int IDENTITY(1, 1)  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [name] varchar(100)  NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'FirstRow.Paises',
        N'SCHEMA', N'FirstRow',
        N'TABLE', N'Paises'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Propuestas'  AND sc.name = N'FirstRow'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'Propuestas'  AND sc.name = N'FirstRow'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [FirstRow].[Propuestas]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[FirstRow].[Propuestas]
(
   [id] int IDENTITY(1, 1)  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [titulo] varchar(100)  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [texto] varchar(45)  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [imagen] varchar(100)  NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [usuario] varchar(20)  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [empresa] varchar(20)  NOT NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'FirstRow.Propuestas',
        N'SCHEMA', N'FirstRow',
        N'TABLE', N'Propuestas'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Reservas'  AND sc.name = N'FirstRow'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'Reservas'  AND sc.name = N'FirstRow'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [FirstRow].[Reservas]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[FirstRow].[Reservas]
(
   [id] int  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [nombre] varchar(45)  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [descripcion] varchar(100)  NULL,
   [experiencia] int  NOT NULL,
   [fechaEntrada] datetime2(0)  NOT NULL,
   [fechaSalida] datetime2(0)  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [usuario] varchar(20)  NOT NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'FirstRow.Reservas',
        N'SCHEMA', N'FirstRow',
        N'TABLE', N'Reservas'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Sorteo_Usuarios'  AND sc.name = N'FirstRow'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'Sorteo_Usuarios'  AND sc.name = N'FirstRow'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [FirstRow].[Sorteo_Usuarios]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[FirstRow].[Sorteo_Usuarios]
(
   [id_Sorteo] int  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [id_Usuario] varchar(20)  NOT NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'FirstRow.Sorteo_Usuarios',
        N'SCHEMA', N'FirstRow',
        N'TABLE', N'Sorteo_Usuarios'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Sorteos'  AND sc.name = N'FirstRow'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'Sorteos'  AND sc.name = N'FirstRow'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [FirstRow].[Sorteos]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[FirstRow].[Sorteos]
(
   [id] int  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [titulo] varchar(45)  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [descripcion] varchar(100)  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [slug] varchar(100)  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [imagen] varchar(100)  NOT NULL,
   [experiencia] int  NOT NULL,
   [fechaInicio] datetime2(0)  NOT NULL,
   [fechafINAL] datetime2(0)  NOT NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'FirstRow.Sorteos',
        N'SCHEMA', N'FirstRow',
        N'TABLE', N'Sorteos'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Stories'  AND sc.name = N'FirstRow'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'Stories'  AND sc.name = N'FirstRow'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [FirstRow].[Stories]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[FirstRow].[Stories]
(
   [id] int  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [titulo] varchar(50)  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [descripcion] varchar(100)  NOT NULL,
   [fecha] datetime2(0)  NOT NULL,
   [pais] int  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [usuario] varchar(20)  NOT NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'FirstRow.Stories',
        N'SCHEMA', N'FirstRow',
        N'TABLE', N'Stories'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Usuarios'  AND sc.name = N'FirstRow'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'Usuarios'  AND sc.name = N'FirstRow'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [FirstRow].[Usuarios]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[FirstRow].[Usuarios]
(

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [nickname] varchar(20)  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [email] varchar(50)  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [password] varchar(100)  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [image] varchar(100)  NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [background_image] varchar(100)  NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [name] varchar(100)  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [firstname] varchar(100)  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [secondname] varchar(100)  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [facebook] varchar(100)  NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [twitter] varchar(100)  NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'FirstRow.Usuarios',
        N'SCHEMA', N'FirstRow',
        N'TABLE', N'Usuarios'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Wearing'  AND sc.name = N'FirstRow'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'Wearing'  AND sc.name = N'FirstRow'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [FirstRow].[Wearing]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[FirstRow].[Wearing]
(
   [id] int  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [titulo] varchar(50)  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [descripcion] varchar(100)  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [texto] varchar(255)  NOT NULL,
   [experiencia] int  NOT NULL,

   /*
   *   SSMA informational messages:
   *   M2SS0055: Data type was converted to VARCHAR according to character set mapping for latin1 character set
   */

   [slug] varchar(100)  NOT NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'FirstRow.Wearing',
        N'SCHEMA', N'FirstRow',
        N'TABLE', N'Wearing'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Wearing_Imagenes'  AND sc.name = N'FirstRow'  AND type in (N'U'))
BEGIN

  DECLARE @drop_statement nvarchar(500)

  DECLARE drop_cursor CURSOR FOR
      SELECT 'alter table '+quotename(schema_name(ob.schema_id))+
      '.'+quotename(object_name(ob.object_id))+ ' drop constraint ' + quotename(fk.name) 
      FROM sys.objects ob INNER JOIN sys.foreign_keys fk ON fk.parent_object_id = ob.object_id
      WHERE fk.referenced_object_id = 
          (
             SELECT so.object_id 
             FROM sys.objects so JOIN sys.schemas sc
             ON so.schema_id = sc.schema_id
             WHERE so.name = N'Wearing_Imagenes'  AND sc.name = N'FirstRow'  AND type in (N'U')
           )

  OPEN drop_cursor

  FETCH NEXT FROM drop_cursor
  INTO @drop_statement

  WHILE @@FETCH_STATUS = 0
  BEGIN
     EXEC (@drop_statement)

     FETCH NEXT FROM drop_cursor
     INTO @drop_statement
  END

  CLOSE drop_cursor
  DEALLOCATE drop_cursor

  DROP TABLE [FirstRow].[Wearing_Imagenes]
END 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE 
[FirstRow].[Wearing_Imagenes]
(
   [id_Wearing] int  NOT NULL,
   [id_Imagen] int  NOT NULL
)
WITH (DATA_COMPRESSION = NONE)
GO
BEGIN TRY
    EXEC sp_addextendedproperty
        N'MS_SSMA_SOURCE', N'FirstRow.Wearing_Imagenes',
        N'SCHEMA', N'FirstRow',
        N'TABLE', N'Wearing_Imagenes'
END TRY
BEGIN CATCH
    IF (@@TRANCOUNT > 0) ROLLBACK
    PRINT ERROR_MESSAGE()
END CATCH
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'PK_Blog_Comentarios_id_Blog'  AND sc.name = N'FirstRow'  AND type in (N'PK'))
ALTER TABLE [FirstRow].[Blog_Comentarios] DROP CONSTRAINT [PK_Blog_Comentarios_id_Blog]
 GO



ALTER TABLE [FirstRow].[Blog_Comentarios]
 ADD CONSTRAINT [PK_Blog_Comentarios_id_Blog]
   PRIMARY KEY
   CLUSTERED ([id_Blog] ASC, [id_Comentario] ASC)

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'PK_Blog_Imagenes_id_Blog'  AND sc.name = N'FirstRow'  AND type in (N'PK'))
ALTER TABLE [FirstRow].[Blog_Imagenes] DROP CONSTRAINT [PK_Blog_Imagenes_id_Blog]
 GO



ALTER TABLE [FirstRow].[Blog_Imagenes]
 ADD CONSTRAINT [PK_Blog_Imagenes_id_Blog]
   PRIMARY KEY
   CLUSTERED ([id_Blog] ASC, [id_Imagen] ASC)

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'PK_Blog_Stories_id_Blog'  AND sc.name = N'FirstRow'  AND type in (N'PK'))
ALTER TABLE [FirstRow].[Blog_Stories] DROP CONSTRAINT [PK_Blog_Stories_id_Blog]
 GO



ALTER TABLE [FirstRow].[Blog_Stories]
 ADD CONSTRAINT [PK_Blog_Stories_id_Blog]
   PRIMARY KEY
   CLUSTERED ([id_Blog] ASC, [id_Storie] ASC)

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'PK_Blogs_id'  AND sc.name = N'FirstRow'  AND type in (N'PK'))
ALTER TABLE [FirstRow].[Blogs] DROP CONSTRAINT [PK_Blogs_id]
 GO



ALTER TABLE [FirstRow].[Blogs]
 ADD CONSTRAINT [PK_Blogs_id]
   PRIMARY KEY
   CLUSTERED ([id] ASC)

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'PK_Categorias_id'  AND sc.name = N'FirstRow'  AND type in (N'PK'))
ALTER TABLE [FirstRow].[Categorias] DROP CONSTRAINT [PK_Categorias_id]
 GO



ALTER TABLE [FirstRow].[Categorias]
 ADD CONSTRAINT [PK_Categorias_id]
   PRIMARY KEY
   CLUSTERED ([id] ASC)

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'PK_Ciudades_id'  AND sc.name = N'FirstRow'  AND type in (N'PK'))
ALTER TABLE [FirstRow].[Ciudades] DROP CONSTRAINT [PK_Ciudades_id]
 GO



ALTER TABLE [FirstRow].[Ciudades]
 ADD CONSTRAINT [PK_Ciudades_id]
   PRIMARY KEY
   CLUSTERED ([id] ASC, [id_pais] ASC)

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'PK_Comentarios_id'  AND sc.name = N'FirstRow'  AND type in (N'PK'))
ALTER TABLE [FirstRow].[Comentarios] DROP CONSTRAINT [PK_Comentarios_id]
 GO



ALTER TABLE [FirstRow].[Comentarios]
 ADD CONSTRAINT [PK_Comentarios_id]
   PRIMARY KEY
   CLUSTERED ([id] ASC)

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'PK_Dias_id'  AND sc.name = N'FirstRow'  AND type in (N'PK'))
ALTER TABLE [FirstRow].[Dias] DROP CONSTRAINT [PK_Dias_id]
 GO



ALTER TABLE [FirstRow].[Dias]
 ADD CONSTRAINT [PK_Dias_id]
   PRIMARY KEY
   CLUSTERED ([id] ASC, [id_experiencia] ASC)

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'PK_Empresas_nickname'  AND sc.name = N'FirstRow'  AND type in (N'PK'))
ALTER TABLE [FirstRow].[Empresas] DROP CONSTRAINT [PK_Empresas_nickname]
 GO



ALTER TABLE [FirstRow].[Empresas]
 ADD CONSTRAINT [PK_Empresas_nickname]
   PRIMARY KEY
   CLUSTERED ([nickname] ASC)

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'PK_Experiencia_Comentarios_id_Experiencia'  AND sc.name = N'FirstRow'  AND type in (N'PK'))
ALTER TABLE [FirstRow].[Experiencia_Comentarios] DROP CONSTRAINT [PK_Experiencia_Comentarios_id_Experiencia]
 GO



ALTER TABLE [FirstRow].[Experiencia_Comentarios]
 ADD CONSTRAINT [PK_Experiencia_Comentarios_id_Experiencia]
   PRIMARY KEY
   CLUSTERED ([id_Experiencia] ASC, [id_Comentario] ASC)

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'PK_Experiencia_Imagenes_id_Experiencia'  AND sc.name = N'FirstRow'  AND type in (N'PK'))
ALTER TABLE [FirstRow].[Experiencia_Imagenes] DROP CONSTRAINT [PK_Experiencia_Imagenes_id_Experiencia]
 GO



ALTER TABLE [FirstRow].[Experiencia_Imagenes]
 ADD CONSTRAINT [PK_Experiencia_Imagenes_id_Experiencia]
   PRIMARY KEY
   CLUSTERED ([id_Experiencia] ASC, [id_Imagen] ASC)

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'PK_Experiencia_Incluido_id_experiencia'  AND sc.name = N'FirstRow'  AND type in (N'PK'))
ALTER TABLE [FirstRow].[Experiencia_Incluido] DROP CONSTRAINT [PK_Experiencia_Incluido_id_experiencia]
 GO



ALTER TABLE [FirstRow].[Experiencia_Incluido]
 ADD CONSTRAINT [PK_Experiencia_Incluido_id_experiencia]
   PRIMARY KEY
   CLUSTERED ([id_experiencia] ASC, [id_incluido] ASC)

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'PK_Experiencia_Stories_id_experiencia'  AND sc.name = N'FirstRow'  AND type in (N'PK'))
ALTER TABLE [FirstRow].[Experiencia_Stories] DROP CONSTRAINT [PK_Experiencia_Stories_id_experiencia]
 GO



ALTER TABLE [FirstRow].[Experiencia_Stories]
 ADD CONSTRAINT [PK_Experiencia_Stories_id_experiencia]
   PRIMARY KEY
   CLUSTERED ([id_experiencia] ASC, [id_storie] ASC)

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'PK_Experiencias_id'  AND sc.name = N'FirstRow'  AND type in (N'PK'))
ALTER TABLE [FirstRow].[Experiencias] DROP CONSTRAINT [PK_Experiencias_id]
 GO



ALTER TABLE [FirstRow].[Experiencias]
 ADD CONSTRAINT [PK_Experiencias_id]
   PRIMARY KEY
   CLUSTERED ([id] ASC)

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'PK_Imagenes_id'  AND sc.name = N'FirstRow'  AND type in (N'PK'))
ALTER TABLE [FirstRow].[Imagenes] DROP CONSTRAINT [PK_Imagenes_id]
 GO



ALTER TABLE [FirstRow].[Imagenes]
 ADD CONSTRAINT [PK_Imagenes_id]
   PRIMARY KEY
   CLUSTERED ([id] ASC)

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'PK_Incluidos_id'  AND sc.name = N'FirstRow'  AND type in (N'PK'))
ALTER TABLE [FirstRow].[Incluidos] DROP CONSTRAINT [PK_Incluidos_id]
 GO



ALTER TABLE [FirstRow].[Incluidos]
 ADD CONSTRAINT [PK_Incluidos_id]
   PRIMARY KEY
   CLUSTERED ([id] ASC)

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'PK_Paises_id'  AND sc.name = N'FirstRow'  AND type in (N'PK'))
ALTER TABLE [FirstRow].[Paises] DROP CONSTRAINT [PK_Paises_id]
 GO



ALTER TABLE [FirstRow].[Paises]
 ADD CONSTRAINT [PK_Paises_id]
   PRIMARY KEY
   CLUSTERED ([id] ASC)

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'PK_Propuestas_id'  AND sc.name = N'FirstRow'  AND type in (N'PK'))
ALTER TABLE [FirstRow].[Propuestas] DROP CONSTRAINT [PK_Propuestas_id]
 GO



ALTER TABLE [FirstRow].[Propuestas]
 ADD CONSTRAINT [PK_Propuestas_id]
   PRIMARY KEY
   CLUSTERED ([id] ASC)

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'PK_Reservas_id'  AND sc.name = N'FirstRow'  AND type in (N'PK'))
ALTER TABLE [FirstRow].[Reservas] DROP CONSTRAINT [PK_Reservas_id]
 GO



ALTER TABLE [FirstRow].[Reservas]
 ADD CONSTRAINT [PK_Reservas_id]
   PRIMARY KEY
   CLUSTERED ([id] ASC)

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'PK_Sorteo_Usuarios_id_Sorteo'  AND sc.name = N'FirstRow'  AND type in (N'PK'))
ALTER TABLE [FirstRow].[Sorteo_Usuarios] DROP CONSTRAINT [PK_Sorteo_Usuarios_id_Sorteo]
 GO



ALTER TABLE [FirstRow].[Sorteo_Usuarios]
 ADD CONSTRAINT [PK_Sorteo_Usuarios_id_Sorteo]
   PRIMARY KEY
   CLUSTERED ([id_Sorteo] ASC, [id_Usuario] ASC)

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'PK_Sorteos_id'  AND sc.name = N'FirstRow'  AND type in (N'PK'))
ALTER TABLE [FirstRow].[Sorteos] DROP CONSTRAINT [PK_Sorteos_id]
 GO



ALTER TABLE [FirstRow].[Sorteos]
 ADD CONSTRAINT [PK_Sorteos_id]
   PRIMARY KEY
   CLUSTERED ([id] ASC)

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'PK_Stories_id'  AND sc.name = N'FirstRow'  AND type in (N'PK'))
ALTER TABLE [FirstRow].[Stories] DROP CONSTRAINT [PK_Stories_id]
 GO



ALTER TABLE [FirstRow].[Stories]
 ADD CONSTRAINT [PK_Stories_id]
   PRIMARY KEY
   CLUSTERED ([id] ASC)

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'PK_Usuarios_nickname'  AND sc.name = N'FirstRow'  AND type in (N'PK'))
ALTER TABLE [FirstRow].[Usuarios] DROP CONSTRAINT [PK_Usuarios_nickname]
 GO



ALTER TABLE [FirstRow].[Usuarios]
 ADD CONSTRAINT [PK_Usuarios_nickname]
   PRIMARY KEY
   CLUSTERED ([nickname] ASC)

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'PK_Wearing_id'  AND sc.name = N'FirstRow'  AND type in (N'PK'))
ALTER TABLE [FirstRow].[Wearing] DROP CONSTRAINT [PK_Wearing_id]
 GO



ALTER TABLE [FirstRow].[Wearing]
 ADD CONSTRAINT [PK_Wearing_id]
   PRIMARY KEY
   CLUSTERED ([id] ASC)

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'PK_Wearing_Imagenes_id_Wearing'  AND sc.name = N'FirstRow'  AND type in (N'PK'))
ALTER TABLE [FirstRow].[Wearing_Imagenes] DROP CONSTRAINT [PK_Wearing_Imagenes_id_Wearing]
 GO



ALTER TABLE [FirstRow].[Wearing_Imagenes]
 ADD CONSTRAINT [PK_Wearing_Imagenes_id_Wearing]
   PRIMARY KEY
   CLUSTERED ([id_Wearing] ASC, [id_Imagen] ASC)

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Usuarios$email_UNIQUE'  AND sc.name = N'FirstRow'  AND type in (N'UQ'))
ALTER TABLE [FirstRow].[Usuarios] DROP CONSTRAINT [Usuarios$email_UNIQUE]
 GO



ALTER TABLE [FirstRow].[Usuarios]
 ADD CONSTRAINT [Usuarios$email_UNIQUE]
 UNIQUE 
   NONCLUSTERED ([email] ASC)

GO

IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'Blog_Imagenes'  AND sc.name = N'FirstRow'  AND si.name = N'blog-imagen_idx' AND so.type in (N'U'))
   DROP INDEX [blog-imagen_idx] ON [FirstRow].[Blog_Imagenes] 
GO
CREATE NONCLUSTERED INDEX [blog-imagen_idx] ON [FirstRow].[Blog_Imagenes]
(
   [id_Imagen] ASC
)
WITH (DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF)
GO
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'Blogs'  AND sc.name = N'FirstRow'  AND si.name = N'categoria-blog_idx' AND so.type in (N'U'))
   DROP INDEX [categoria-blog_idx] ON [FirstRow].[Blogs] 
GO
CREATE NONCLUSTERED INDEX [categoria-blog_idx] ON [FirstRow].[Blogs]
(
   [categoria] ASC
)
WITH (DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF)
GO
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'Ciudades'  AND sc.name = N'FirstRow'  AND si.name = N'ciudad-pais_idx' AND so.type in (N'U'))
   DROP INDEX [ciudad-pais_idx] ON [FirstRow].[Ciudades] 
GO
CREATE NONCLUSTERED INDEX [ciudad-pais_idx] ON [FirstRow].[Ciudades]
(
   [id_pais] ASC
)
WITH (DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF)
GO
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'Blog_Comentarios'  AND sc.name = N'FirstRow'  AND si.name = N'comentario-blog_idx' AND so.type in (N'U'))
   DROP INDEX [comentario-blog_idx] ON [FirstRow].[Blog_Comentarios] 
GO
CREATE NONCLUSTERED INDEX [comentario-blog_idx] ON [FirstRow].[Blog_Comentarios]
(
   [id_Comentario] ASC
)
WITH (DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF)
GO
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'Experiencia_Comentarios'  AND sc.name = N'FirstRow'  AND si.name = N'comentario-experiencia_idx' AND so.type in (N'U'))
   DROP INDEX [comentario-experiencia_idx] ON [FirstRow].[Experiencia_Comentarios] 
GO
CREATE NONCLUSTERED INDEX [comentario-experiencia_idx] ON [FirstRow].[Experiencia_Comentarios]
(
   [id_Comentario] ASC
)
WITH (DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF)
GO
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'Dias'  AND sc.name = N'FirstRow'  AND si.name = N'dia-experiencia_idx' AND so.type in (N'U'))
   DROP INDEX [dia-experiencia_idx] ON [FirstRow].[Dias] 
GO
CREATE NONCLUSTERED INDEX [dia-experiencia_idx] ON [FirstRow].[Dias]
(
   [id_experiencia] ASC
)
WITH (DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF)
GO
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'Experiencias'  AND sc.name = N'FirstRow'  AND si.name = N'experiencia_empresa_idx' AND so.type in (N'U'))
   DROP INDEX [experiencia_empresa_idx] ON [FirstRow].[Experiencias] 
GO
CREATE NONCLUSTERED INDEX [experiencia_empresa_idx] ON [FirstRow].[Experiencias]
(
   [empresa] ASC
)
WITH (DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF)
GO
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'Experiencias'  AND sc.name = N'FirstRow'  AND si.name = N'experiencia_pais_idx' AND so.type in (N'U'))
   DROP INDEX [experiencia_pais_idx] ON [FirstRow].[Experiencias] 
GO
CREATE NONCLUSTERED INDEX [experiencia_pais_idx] ON [FirstRow].[Experiencias]
(
   [pais] ASC
)
WITH (DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF)
GO
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'Sorteos'  AND sc.name = N'FirstRow'  AND si.name = N'experiencia-sorteos_idx' AND so.type in (N'U'))
   DROP INDEX [experiencia-sorteos_idx] ON [FirstRow].[Sorteos] 
GO
CREATE NONCLUSTERED INDEX [experiencia-sorteos_idx] ON [FirstRow].[Sorteos]
(
   [experiencia] ASC
)
WITH (DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF)
GO
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'Experiencia_Imagenes'  AND sc.name = N'FirstRow'  AND si.name = N'id_imagen_idx' AND so.type in (N'U'))
   DROP INDEX [id_imagen_idx] ON [FirstRow].[Experiencia_Imagenes] 
GO
CREATE NONCLUSTERED INDEX [id_imagen_idx] ON [FirstRow].[Experiencia_Imagenes]
(
   [id_Imagen] ASC
)
WITH (DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF)
GO
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'Experiencia_Stories'  AND sc.name = N'FirstRow'  AND si.name = N'id_storie_experiencia_idx' AND so.type in (N'U'))
   DROP INDEX [id_storie_experiencia_idx] ON [FirstRow].[Experiencia_Stories] 
GO
CREATE NONCLUSTERED INDEX [id_storie_experiencia_idx] ON [FirstRow].[Experiencia_Stories]
(
   [id_storie] ASC
)
WITH (DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF)
GO
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'Experiencia_Incluido'  AND sc.name = N'FirstRow'  AND si.name = N'id-incluido_idx' AND so.type in (N'U'))
   DROP INDEX [id-incluido_idx] ON [FirstRow].[Experiencia_Incluido] 
GO
CREATE NONCLUSTERED INDEX [id-incluido_idx] ON [FirstRow].[Experiencia_Incluido]
(
   [id_incluido] ASC
)
WITH (DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF)
GO
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'Sorteo_Usuarios'  AND sc.name = N'FirstRow'  AND si.name = N'id-sorteo-usuario_idx' AND so.type in (N'U'))
   DROP INDEX [id-sorteo-usuario_idx] ON [FirstRow].[Sorteo_Usuarios] 
GO
CREATE NONCLUSTERED INDEX [id-sorteo-usuario_idx] ON [FirstRow].[Sorteo_Usuarios]
(
   [id_Usuario] ASC
)
WITH (DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF)
GO
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'Wearing_Imagenes'  AND sc.name = N'FirstRow'  AND si.name = N'imagen-wearing_idx' AND so.type in (N'U'))
   DROP INDEX [imagen-wearing_idx] ON [FirstRow].[Wearing_Imagenes] 
GO
CREATE NONCLUSTERED INDEX [imagen-wearing_idx] ON [FirstRow].[Wearing_Imagenes]
(
   [id_Imagen] ASC
)
WITH (DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF)
GO
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'Comentarios'  AND sc.name = N'FirstRow'  AND si.name = N'nickname_idx' AND so.type in (N'U'))
   DROP INDEX [nickname_idx] ON [FirstRow].[Comentarios] 
GO
CREATE NONCLUSTERED INDEX [nickname_idx] ON [FirstRow].[Comentarios]
(
   [nickname] ASC
)
WITH (DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF)
GO
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'Empresas'  AND sc.name = N'FirstRow'  AND si.name = N'pais_idx' AND so.type in (N'U'))
   DROP INDEX [pais_idx] ON [FirstRow].[Empresas] 
GO
CREATE NONCLUSTERED INDEX [pais_idx] ON [FirstRow].[Empresas]
(
   [pais] ASC
)
WITH (DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF)
GO
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'Blogs'  AND sc.name = N'FirstRow'  AND si.name = N'pais-blog_idx' AND so.type in (N'U'))
   DROP INDEX [pais-blog_idx] ON [FirstRow].[Blogs] 
GO
CREATE NONCLUSTERED INDEX [pais-blog_idx] ON [FirstRow].[Blogs]
(
   [pais] ASC
)
WITH (DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF)
GO
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'Propuestas'  AND sc.name = N'FirstRow'  AND si.name = N'propuesta_empresa_idx' AND so.type in (N'U'))
   DROP INDEX [propuesta_empresa_idx] ON [FirstRow].[Propuestas] 
GO
CREATE NONCLUSTERED INDEX [propuesta_empresa_idx] ON [FirstRow].[Propuestas]
(
   [empresa] ASC
)
WITH (DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF)
GO
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'Propuestas'  AND sc.name = N'FirstRow'  AND si.name = N'propuesta_usuario_idx' AND so.type in (N'U'))
   DROP INDEX [propuesta_usuario_idx] ON [FirstRow].[Propuestas] 
GO
CREATE NONCLUSTERED INDEX [propuesta_usuario_idx] ON [FirstRow].[Propuestas]
(
   [usuario] ASC
)
WITH (DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF)
GO
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'Reservas'  AND sc.name = N'FirstRow'  AND si.name = N'reserva-experiencia_idx' AND so.type in (N'U'))
   DROP INDEX [reserva-experiencia_idx] ON [FirstRow].[Reservas] 
GO
CREATE NONCLUSTERED INDEX [reserva-experiencia_idx] ON [FirstRow].[Reservas]
(
   [experiencia] ASC
)
WITH (DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF)
GO
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'Reservas'  AND sc.name = N'FirstRow'  AND si.name = N'reserva-usuario_idx' AND so.type in (N'U'))
   DROP INDEX [reserva-usuario_idx] ON [FirstRow].[Reservas] 
GO
CREATE NONCLUSTERED INDEX [reserva-usuario_idx] ON [FirstRow].[Reservas]
(
   [usuario] ASC
)
WITH (DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF)
GO
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'Stories'  AND sc.name = N'FirstRow'  AND si.name = N'storie_pais_idx' AND so.type in (N'U'))
   DROP INDEX [storie_pais_idx] ON [FirstRow].[Stories] 
GO
CREATE NONCLUSTERED INDEX [storie_pais_idx] ON [FirstRow].[Stories]
(
   [pais] ASC
)
WITH (DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF)
GO
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'Stories'  AND sc.name = N'FirstRow'  AND si.name = N'storie_usuario_idx' AND so.type in (N'U'))
   DROP INDEX [storie_usuario_idx] ON [FirstRow].[Stories] 
GO
CREATE NONCLUSTERED INDEX [storie_usuario_idx] ON [FirstRow].[Stories]
(
   [usuario] ASC
)
WITH (DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF)
GO
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'Blog_Stories'  AND sc.name = N'FirstRow'  AND si.name = N'storie-blog_idx' AND so.type in (N'U'))
   DROP INDEX [storie-blog_idx] ON [FirstRow].[Blog_Stories] 
GO
CREATE NONCLUSTERED INDEX [storie-blog_idx] ON [FirstRow].[Blog_Stories]
(
   [id_Storie] ASC
)
WITH (DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF)
GO
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'Blogs'  AND sc.name = N'FirstRow'  AND si.name = N'usuario-blog_idx' AND so.type in (N'U'))
   DROP INDEX [usuario-blog_idx] ON [FirstRow].[Blogs] 
GO
CREATE NONCLUSTERED INDEX [usuario-blog_idx] ON [FirstRow].[Blogs]
(
   [usuario] ASC
)
WITH (DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF)
GO
GO
IF EXISTS (
       SELECT * FROM sys.objects  so JOIN sys.indexes si
       ON so.object_id = si.object_id
       JOIN sys.schemas sc
       ON so.schema_id = sc.schema_id
       WHERE so.name = N'Wearing'  AND sc.name = N'FirstRow'  AND si.name = N'wearing-experiencia_idx' AND so.type in (N'U'))
   DROP INDEX [wearing-experiencia_idx] ON [FirstRow].[Wearing] 
GO
CREATE NONCLUSTERED INDEX [wearing-experiencia_idx] ON [FirstRow].[Wearing]
(
   [experiencia] ASC
)
WITH (DROP_EXISTING = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF)
GO
GO
IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Blog_Comentarios$blog-comentario'  AND sc.name = N'FirstRow'  AND type in (N'F'))
ALTER TABLE [FirstRow].[Blog_Comentarios] DROP CONSTRAINT [Blog_Comentarios$blog-comentario]
 GO



ALTER TABLE [FirstRow].[Blog_Comentarios]
 ADD CONSTRAINT [Blog_Comentarios$blog-comentario]
 FOREIGN KEY 
   ([id_Blog])
 REFERENCES 
   [FirstRow].[Blogs]     ([id])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Blog_Comentarios$comentario-blog'  AND sc.name = N'FirstRow'  AND type in (N'F'))
ALTER TABLE [FirstRow].[Blog_Comentarios] DROP CONSTRAINT [Blog_Comentarios$comentario-blog]
 GO



ALTER TABLE [FirstRow].[Blog_Comentarios]
 ADD CONSTRAINT [Blog_Comentarios$comentario-blog]
 FOREIGN KEY 
   ([id_Comentario])
 REFERENCES 
   [FirstRow].[Comentarios]     ([id])
    ON DELETE CASCADE
    ON UPDATE CASCADE

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Blog_Imagenes$blog-imagen'  AND sc.name = N'FirstRow'  AND type in (N'F'))
ALTER TABLE [FirstRow].[Blog_Imagenes] DROP CONSTRAINT [Blog_Imagenes$blog-imagen]
 GO



ALTER TABLE [FirstRow].[Blog_Imagenes]
 ADD CONSTRAINT [Blog_Imagenes$blog-imagen]
 FOREIGN KEY 
   ([id_Imagen])
 REFERENCES 
   [FirstRow].[Imagenes]     ([id])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Blog_Imagenes$imagen-blog'  AND sc.name = N'FirstRow'  AND type in (N'F'))
ALTER TABLE [FirstRow].[Blog_Imagenes] DROP CONSTRAINT [Blog_Imagenes$imagen-blog]
 GO



ALTER TABLE [FirstRow].[Blog_Imagenes]
 ADD CONSTRAINT [Blog_Imagenes$imagen-blog]
 FOREIGN KEY 
   ([id_Blog])
 REFERENCES 
   [FirstRow].[Blogs]     ([id])
    ON DELETE CASCADE
    ON UPDATE CASCADE

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Blog_Stories$blog-storie'  AND sc.name = N'FirstRow'  AND type in (N'F'))
ALTER TABLE [FirstRow].[Blog_Stories] DROP CONSTRAINT [Blog_Stories$blog-storie]
 GO



ALTER TABLE [FirstRow].[Blog_Stories]
 ADD CONSTRAINT [Blog_Stories$blog-storie]
 FOREIGN KEY 
   ([id_Blog])
 REFERENCES 
   [FirstRow].[Blogs]     ([id])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Blog_Stories$storie-blog'  AND sc.name = N'FirstRow'  AND type in (N'F'))
ALTER TABLE [FirstRow].[Blog_Stories] DROP CONSTRAINT [Blog_Stories$storie-blog]
 GO



ALTER TABLE [FirstRow].[Blog_Stories]
 ADD CONSTRAINT [Blog_Stories$storie-blog]
 FOREIGN KEY 
   ([id_Storie])
 REFERENCES 
   [FirstRow].[Stories]     ([id])
    ON DELETE CASCADE
    ON UPDATE CASCADE

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Blogs$categoria-blog'  AND sc.name = N'FirstRow'  AND type in (N'F'))
ALTER TABLE [FirstRow].[Blogs] DROP CONSTRAINT [Blogs$categoria-blog]
 GO



ALTER TABLE [FirstRow].[Blogs]
 ADD CONSTRAINT [Blogs$categoria-blog]
 FOREIGN KEY 
   ([categoria])
 REFERENCES 
   [FirstRow].[Categorias]     ([id])
    ON DELETE CASCADE
    ON UPDATE CASCADE

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Blogs$pais-blog'  AND sc.name = N'FirstRow'  AND type in (N'F'))
ALTER TABLE [FirstRow].[Blogs] DROP CONSTRAINT [Blogs$pais-blog]
 GO



ALTER TABLE [FirstRow].[Blogs]
 ADD CONSTRAINT [Blogs$pais-blog]
 FOREIGN KEY 
   ([pais])
 REFERENCES 
   [FirstRow].[Paises]     ([id])
    ON DELETE CASCADE
    ON UPDATE CASCADE

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Blogs$usuario-blog'  AND sc.name = N'FirstRow'  AND type in (N'F'))
ALTER TABLE [FirstRow].[Blogs] DROP CONSTRAINT [Blogs$usuario-blog]
 GO



ALTER TABLE [FirstRow].[Blogs]
 ADD CONSTRAINT [Blogs$usuario-blog]
 FOREIGN KEY 
   ([usuario])
 REFERENCES 
   [FirstRow].[Usuarios]     ([nickname])
    ON DELETE CASCADE
    ON UPDATE CASCADE

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Ciudades$ciudad-pais'  AND sc.name = N'FirstRow'  AND type in (N'F'))
ALTER TABLE [FirstRow].[Ciudades] DROP CONSTRAINT [Ciudades$ciudad-pais]
 GO



ALTER TABLE [FirstRow].[Ciudades]
 ADD CONSTRAINT [Ciudades$ciudad-pais]
 FOREIGN KEY 
   ([id_pais])
 REFERENCES 
   [FirstRow].[Paises]     ([id])
    ON DELETE CASCADE
    ON UPDATE CASCADE

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Comentarios$nickname_comentarios'  AND sc.name = N'FirstRow'  AND type in (N'F'))
ALTER TABLE [FirstRow].[Comentarios] DROP CONSTRAINT [Comentarios$nickname_comentarios]
 GO



ALTER TABLE [FirstRow].[Comentarios]
 ADD CONSTRAINT [Comentarios$nickname_comentarios]
 FOREIGN KEY 
   ([nickname])
 REFERENCES 
   [FirstRow].[Usuarios]     ([nickname])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Dias$dia-experiencia'  AND sc.name = N'FirstRow'  AND type in (N'F'))
ALTER TABLE [FirstRow].[Dias] DROP CONSTRAINT [Dias$dia-experiencia]
 GO



ALTER TABLE [FirstRow].[Dias]
 ADD CONSTRAINT [Dias$dia-experiencia]
 FOREIGN KEY 
   ([id_experiencia])
 REFERENCES 
   [FirstRow].[Experiencias]     ([id])
    ON DELETE CASCADE
    ON UPDATE CASCADE

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Empresas$nickname'  AND sc.name = N'FirstRow'  AND type in (N'F'))
ALTER TABLE [FirstRow].[Empresas] DROP CONSTRAINT [Empresas$nickname]
 GO



ALTER TABLE [FirstRow].[Empresas]
 ADD CONSTRAINT [Empresas$nickname]
 FOREIGN KEY 
   ([nickname])
 REFERENCES 
   [FirstRow].[Usuarios]     ([nickname])
    ON DELETE CASCADE
    ON UPDATE CASCADE

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Empresas$pais'  AND sc.name = N'FirstRow'  AND type in (N'F'))
ALTER TABLE [FirstRow].[Empresas] DROP CONSTRAINT [Empresas$pais]
 GO



ALTER TABLE [FirstRow].[Empresas]
 ADD CONSTRAINT [Empresas$pais]
 FOREIGN KEY 
   ([pais])
 REFERENCES 
   [FirstRow].[Paises]     ([id])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Experiencia_Comentarios$comentario-experiencia'  AND sc.name = N'FirstRow'  AND type in (N'F'))
ALTER TABLE [FirstRow].[Experiencia_Comentarios] DROP CONSTRAINT [Experiencia_Comentarios$comentario-experiencia]
 GO



ALTER TABLE [FirstRow].[Experiencia_Comentarios]
 ADD CONSTRAINT [Experiencia_Comentarios$comentario-experiencia]
 FOREIGN KEY 
   ([id_Comentario])
 REFERENCES 
   [FirstRow].[Comentarios]     ([id])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Experiencia_Comentarios$experiencia-comentario'  AND sc.name = N'FirstRow'  AND type in (N'F'))
ALTER TABLE [FirstRow].[Experiencia_Comentarios] DROP CONSTRAINT [Experiencia_Comentarios$experiencia-comentario]
 GO



ALTER TABLE [FirstRow].[Experiencia_Comentarios]
 ADD CONSTRAINT [Experiencia_Comentarios$experiencia-comentario]
 FOREIGN KEY 
   ([id_Experiencia])
 REFERENCES 
   [FirstRow].[Experiencias]     ([id])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Experiencia_Imagenes$id_experiencia'  AND sc.name = N'FirstRow'  AND type in (N'F'))
ALTER TABLE [FirstRow].[Experiencia_Imagenes] DROP CONSTRAINT [Experiencia_Imagenes$id_experiencia]
 GO



ALTER TABLE [FirstRow].[Experiencia_Imagenes]
 ADD CONSTRAINT [Experiencia_Imagenes$id_experiencia]
 FOREIGN KEY 
   ([id_Experiencia])
 REFERENCES 
   [FirstRow].[Experiencias]     ([id])
    ON DELETE CASCADE
    ON UPDATE CASCADE

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Experiencia_Imagenes$id_imagen'  AND sc.name = N'FirstRow'  AND type in (N'F'))
ALTER TABLE [FirstRow].[Experiencia_Imagenes] DROP CONSTRAINT [Experiencia_Imagenes$id_imagen]
 GO



ALTER TABLE [FirstRow].[Experiencia_Imagenes]
 ADD CONSTRAINT [Experiencia_Imagenes$id_imagen]
 FOREIGN KEY 
   ([id_Imagen])
 REFERENCES 
   [FirstRow].[Imagenes]     ([id])
    ON DELETE CASCADE
    ON UPDATE CASCADE

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Experiencia_Incluido$id-experiencia'  AND sc.name = N'FirstRow'  AND type in (N'F'))
ALTER TABLE [FirstRow].[Experiencia_Incluido] DROP CONSTRAINT [Experiencia_Incluido$id-experiencia]
 GO



ALTER TABLE [FirstRow].[Experiencia_Incluido]
 ADD CONSTRAINT [Experiencia_Incluido$id-experiencia]
 FOREIGN KEY 
   ([id_experiencia])
 REFERENCES 
   [FirstRow].[Experiencias]     ([id])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Experiencia_Incluido$id-incluido'  AND sc.name = N'FirstRow'  AND type in (N'F'))
ALTER TABLE [FirstRow].[Experiencia_Incluido] DROP CONSTRAINT [Experiencia_Incluido$id-incluido]
 GO



ALTER TABLE [FirstRow].[Experiencia_Incluido]
 ADD CONSTRAINT [Experiencia_Incluido$id-incluido]
 FOREIGN KEY 
   ([id_incluido])
 REFERENCES 
   [FirstRow].[Incluidos]     ([id])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Experiencia_Stories$id_experiencia_storie'  AND sc.name = N'FirstRow'  AND type in (N'F'))
ALTER TABLE [FirstRow].[Experiencia_Stories] DROP CONSTRAINT [Experiencia_Stories$id_experiencia_storie]
 GO



ALTER TABLE [FirstRow].[Experiencia_Stories]
 ADD CONSTRAINT [Experiencia_Stories$id_experiencia_storie]
 FOREIGN KEY 
   ([id_experiencia])
 REFERENCES 
   [FirstRow].[Experiencias]     ([id])
    ON DELETE CASCADE
    ON UPDATE CASCADE

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Experiencia_Stories$id_storie_experiencia'  AND sc.name = N'FirstRow'  AND type in (N'F'))
ALTER TABLE [FirstRow].[Experiencia_Stories] DROP CONSTRAINT [Experiencia_Stories$id_storie_experiencia]
 GO



ALTER TABLE [FirstRow].[Experiencia_Stories]
 ADD CONSTRAINT [Experiencia_Stories$id_storie_experiencia]
 FOREIGN KEY 
   ([id_storie])
 REFERENCES 
   [FirstRow].[Stories]     ([id])
    ON DELETE CASCADE
    ON UPDATE CASCADE

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Experiencias$experiencia_empresa'  AND sc.name = N'FirstRow'  AND type in (N'F'))
ALTER TABLE [FirstRow].[Experiencias] DROP CONSTRAINT [Experiencias$experiencia_empresa]
 GO



ALTER TABLE [FirstRow].[Experiencias]
 ADD CONSTRAINT [Experiencias$experiencia_empresa]
 FOREIGN KEY 
   ([empresa])
 REFERENCES 
   [FirstRow].[Empresas]     ([nickname])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Experiencias$experiencia_pais'  AND sc.name = N'FirstRow'  AND type in (N'F'))
ALTER TABLE [FirstRow].[Experiencias] DROP CONSTRAINT [Experiencias$experiencia_pais]
 GO



ALTER TABLE [FirstRow].[Experiencias]
 ADD CONSTRAINT [Experiencias$experiencia_pais]
 FOREIGN KEY 
   ([pais])
 REFERENCES 
   [FirstRow].[Paises]     ([id])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Propuestas$propuesta_empresa'  AND sc.name = N'FirstRow'  AND type in (N'F'))
ALTER TABLE [FirstRow].[Propuestas] DROP CONSTRAINT [Propuestas$propuesta_empresa]
 GO



ALTER TABLE [FirstRow].[Propuestas]
 ADD CONSTRAINT [Propuestas$propuesta_empresa]
 FOREIGN KEY 
   ([empresa])
 REFERENCES 
   [FirstRow].[Empresas]     ([nickname])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Propuestas$propuesta_usuario'  AND sc.name = N'FirstRow'  AND type in (N'F'))
ALTER TABLE [FirstRow].[Propuestas] DROP CONSTRAINT [Propuestas$propuesta_usuario]
 GO



ALTER TABLE [FirstRow].[Propuestas]
 ADD CONSTRAINT [Propuestas$propuesta_usuario]
 FOREIGN KEY 
   ([usuario])
 REFERENCES 
   [FirstRow].[Usuarios]     ([nickname])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Reservas$reserva-experiencia'  AND sc.name = N'FirstRow'  AND type in (N'F'))
ALTER TABLE [FirstRow].[Reservas] DROP CONSTRAINT [Reservas$reserva-experiencia]
 GO



ALTER TABLE [FirstRow].[Reservas]
 ADD CONSTRAINT [Reservas$reserva-experiencia]
 FOREIGN KEY 
   ([experiencia])
 REFERENCES 
   [FirstRow].[Experiencias]     ([id])
    ON DELETE CASCADE
    ON UPDATE CASCADE

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Reservas$reserva-usuario'  AND sc.name = N'FirstRow'  AND type in (N'F'))
ALTER TABLE [FirstRow].[Reservas] DROP CONSTRAINT [Reservas$reserva-usuario]
 GO



ALTER TABLE [FirstRow].[Reservas]
 ADD CONSTRAINT [Reservas$reserva-usuario]
 FOREIGN KEY 
   ([usuario])
 REFERENCES 
   [FirstRow].[Usuarios]     ([nickname])
    ON DELETE CASCADE
    ON UPDATE CASCADE

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Sorteo_Usuarios$id-sorteo'  AND sc.name = N'FirstRow'  AND type in (N'F'))
ALTER TABLE [FirstRow].[Sorteo_Usuarios] DROP CONSTRAINT [Sorteo_Usuarios$id-sorteo]
 GO



ALTER TABLE [FirstRow].[Sorteo_Usuarios]
 ADD CONSTRAINT [Sorteo_Usuarios$id-sorteo]
 FOREIGN KEY 
   ([id_Sorteo])
 REFERENCES 
   [FirstRow].[Sorteos]     ([id])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Sorteo_Usuarios$id-sorteo-usuario'  AND sc.name = N'FirstRow'  AND type in (N'F'))
ALTER TABLE [FirstRow].[Sorteo_Usuarios] DROP CONSTRAINT [Sorteo_Usuarios$id-sorteo-usuario]
 GO



ALTER TABLE [FirstRow].[Sorteo_Usuarios]
 ADD CONSTRAINT [Sorteo_Usuarios$id-sorteo-usuario]
 FOREIGN KEY 
   ([id_Usuario])
 REFERENCES 
   [FirstRow].[Usuarios]     ([nickname])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Sorteos$experiencia-sorteo'  AND sc.name = N'FirstRow'  AND type in (N'F'))
ALTER TABLE [FirstRow].[Sorteos] DROP CONSTRAINT [Sorteos$experiencia-sorteo]
 GO



ALTER TABLE [FirstRow].[Sorteos]
 ADD CONSTRAINT [Sorteos$experiencia-sorteo]
 FOREIGN KEY 
   ([experiencia])
 REFERENCES 
   [FirstRow].[Experiencias]     ([id])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Stories$storie_pais'  AND sc.name = N'FirstRow'  AND type in (N'F'))
ALTER TABLE [FirstRow].[Stories] DROP CONSTRAINT [Stories$storie_pais]
 GO



ALTER TABLE [FirstRow].[Stories]
 ADD CONSTRAINT [Stories$storie_pais]
 FOREIGN KEY 
   ([pais])
 REFERENCES 
   [FirstRow].[Paises]     ([id])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Stories$storie_usuario'  AND sc.name = N'FirstRow'  AND type in (N'F'))
ALTER TABLE [FirstRow].[Stories] DROP CONSTRAINT [Stories$storie_usuario]
 GO



ALTER TABLE [FirstRow].[Stories]
 ADD CONSTRAINT [Stories$storie_usuario]
 FOREIGN KEY 
   ([usuario])
 REFERENCES 
   [FirstRow].[Usuarios]     ([nickname])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Wearing$wearing-experiencia'  AND sc.name = N'FirstRow'  AND type in (N'F'))
ALTER TABLE [FirstRow].[Wearing] DROP CONSTRAINT [Wearing$wearing-experiencia]
 GO



ALTER TABLE [FirstRow].[Wearing]
 ADD CONSTRAINT [Wearing$wearing-experiencia]
 FOREIGN KEY 
   ([experiencia])
 REFERENCES 
   [FirstRow].[Experiencias]     ([id])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Wearing_Imagenes$imagen-wearing'  AND sc.name = N'FirstRow'  AND type in (N'F'))
ALTER TABLE [FirstRow].[Wearing_Imagenes] DROP CONSTRAINT [Wearing_Imagenes$imagen-wearing]
 GO



ALTER TABLE [FirstRow].[Wearing_Imagenes]
 ADD CONSTRAINT [Wearing_Imagenes$imagen-wearing]
 FOREIGN KEY 
   ([id_Imagen])
 REFERENCES 
   [FirstRow].[Imagenes]     ([id])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION

GO

IF EXISTS (SELECT * FROM sys.objects so JOIN sys.schemas sc ON so.schema_id = sc.schema_id WHERE so.name = N'Wearing_Imagenes$wearing-imagen'  AND sc.name = N'FirstRow'  AND type in (N'F'))
ALTER TABLE [FirstRow].[Wearing_Imagenes] DROP CONSTRAINT [Wearing_Imagenes$wearing-imagen]
 GO



ALTER TABLE [FirstRow].[Wearing_Imagenes]
 ADD CONSTRAINT [Wearing_Imagenes$wearing-imagen]
 FOREIGN KEY 
   ([id_Wearing])
 REFERENCES 
   [FirstRow].[Wearing]     ([id])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION

GO

ALTER TABLE  [FirstRow].[Blogs]
 ADD DEFAULT NULL FOR [citacion]
GO

ALTER TABLE  [FirstRow].[Ciudades]
 ADD DEFAULT NULL FOR [image]
GO

ALTER TABLE  [FirstRow].[Comentarios]
 ADD DEFAULT NULL FOR [estrellas]
GO

ALTER TABLE  [FirstRow].[Dias]
 ADD DEFAULT NULL FOR [imagen]
GO

ALTER TABLE  [FirstRow].[Empresas]
 ADD DEFAULT NULL FOR [image]
GO

ALTER TABLE  [FirstRow].[Empresas]
 ADD DEFAULT NULL FOR [background_image]
GO

ALTER TABLE  [FirstRow].[Empresas]
 ADD DEFAULT NULL FOR [facebook]
GO

ALTER TABLE  [FirstRow].[Empresas]
 ADD DEFAULT NULL FOR [twitter]
GO

ALTER TABLE  [FirstRow].[Imagenes]
 ADD DEFAULT NULL FOR [mode]
GO

ALTER TABLE  [FirstRow].[Paises]
 ADD DEFAULT NULL FOR [name]
GO

ALTER TABLE  [FirstRow].[Propuestas]
 ADD DEFAULT NULL FOR [imagen]
GO

ALTER TABLE  [FirstRow].[Reservas]
 ADD DEFAULT NULL FOR [descripcion]
GO

ALTER TABLE  [FirstRow].[Usuarios]
 ADD DEFAULT NULL FOR [image]
GO

ALTER TABLE  [FirstRow].[Usuarios]
 ADD DEFAULT NULL FOR [background_image]
GO

ALTER TABLE  [FirstRow].[Usuarios]
 ADD DEFAULT NULL FOR [facebook]
GO

ALTER TABLE  [FirstRow].[Usuarios]
 ADD DEFAULT NULL FOR [twitter]
GO

