USE [SINU]
GO
/****** Object:  Synonym [dbo].[Syn_Param_Idiomas]    Script Date: 01/06/2020 18:22:45 ******/
CREATE SYNONYM [dbo].[Syn_Param_Idiomas] FOR [Parametricas].[dbo].[T008_IDIOMAS]
GO
EXEC sys.sp_addextendedproperty @name=N'Descripcion', @value=N'Synonim que accede a la base Parametricas para ver Tabla T008_IDIOMAS' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'SYNONYM',@level1name=N'Syn_Param_Idiomas'
GO
