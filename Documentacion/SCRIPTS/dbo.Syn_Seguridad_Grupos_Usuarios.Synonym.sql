USE [SINU]
GO
/****** Object:  Synonym [dbo].[Syn_Seguridad_Grupos_Usuarios]    Script Date: 01/06/2020 18:22:45 ******/
CREATE SYNONYM [dbo].[Syn_Seguridad_Grupos_Usuarios] FOR [Seguridad].[dbo].[Grupos_Usuarios]
GO
EXEC sys.sp_addextendedproperty @name=N'Descripcion', @value=N'Synonim que accede a la base Seguridad para ver Tabla Grupos_Usuarios' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'SYNONYM',@level1name=N'Syn_Seguridad_Grupos_Usuarios'
GO
