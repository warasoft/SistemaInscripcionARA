USE [SINU]
GO
/****** Object:  Synonym [dbo].[Syn_Seguridad_Grupos]    Script Date: 01/06/2020 18:22:45 ******/
CREATE SYNONYM [dbo].[Syn_Seguridad_Grupos] FOR [Seguridad].[dbo].[Grupos]
GO
EXEC sys.sp_addextendedproperty @name=N'Descripcion', @value=N'Synonim que accede a la base Seguridad para ver Tabla Grupos' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'SYNONYM',@level1name=N'Syn_Seguridad_Grupos'
GO
