USE [demo20]
GO
/****** Object:  Table [dbo].[Antecedentes]    Script Date: 22/04/2022 19:15:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Antecedentes](
	[cod_antecedentes] [int] IDENTITY(1,1) NOT NULL,
	[cod_persona] [int] NOT NULL,
	[diabetico] [varchar](50) NOT NULL,
	[hipertenso] [varchar](50) NOT NULL,
	[cardiacos] [varchar](50) NOT NULL,
	[lagrimeo] [varchar](50) NOT NULL,
	[otros] [varchar](50) NOT NULL,
	[alergico_a] [varchar](50) NOT NULL,
	[medicamentos] [varchar](50) NOT NULL,
	[anestesicos] [varchar](50) NOT NULL,
	[medicamentos_u] [varchar](max) NOT NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [pkactor] PRIMARY KEY CLUSTERED 
(
	[cod_antecedentes] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cita]    Script Date: 22/04/2022 19:15:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cita](
	[cod_cita] [int] NULL,
	[diagnostico] [varchar](100) NULL,
	[tratamiento] [varchar](100) NULL,
	[medico] [varchar](50) NULL,
	[fecha] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lamparah]    Script Date: 22/04/2022 19:15:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lamparah](
	[cod_lamparah] [int] NULL,
	[parpados_od] [varchar](20) NULL,
	[parpados_oi] [varchar](20) NULL,
	[lacriales_od] [varchar](20) NULL,
	[lacriales_oi] [varchar](20) NULL,
	[conjutiva_od] [varchar](20) NULL,
	[conjutiva_oi] [varchar](20) NULL,
	[cornea_od] [varchar](20) NULL,
	[cornea_oi] [varchar](20) NULL,
	[iris_od] [varchar](20) NULL,
	[iris_oi] [varchar](20) NULL,
	[cristalino_od] [varchar](20) NULL,
	[cristalino_oi] [varchar](20) NULL,
	[vitreo_od] [varchar](20) NULL,
	[vitreo_oi] [varchar](20) NULL,
	[retina_od] [varchar](20) NULL,
	[retina_oi] [varchar](20) NULL,
	[fondos_od] [varchar](max) NULL,
	[fondos_oi] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Motivo]    Script Date: 22/04/2022 19:15:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Motivo](
	[cod_motivo] [int] NULL,
	[dolor] [bit] NULL,
	[orojo] [bit] NULL,
	[dvisual] [bit] NULL,
	[vdoble] [bit] NULL,
	[otros] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oftalmologicos]    Script Date: 22/04/2022 19:15:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oftalmologicos](
	[cod_oftalm] [int] NULL,
	[sc_od] [varchar](10) NULL,
	[sc_oi] [varchar](10) NULL,
	[cc_od] [varchar](10) NULL,
	[cc_oi] [varchar](10) NULL,
	[ae_od] [varchar](10) NULL,
	[ae_oi] [varchar](10) NULL,
	[pio_od] [varchar](10) NULL,
	[pio_oi] [varchar](10) NULL,
	[re_od] [varchar](10) NULL,
	[re_oi] [varchar](10) NULL,
	[re_add] [varchar](10) NULL,
	[re_dio] [varchar](10) NULL,
	[ka_od] [varchar](10) NULL,
	[ka_oi] [varchar](10) NULL,
	[bi_od] [varchar](10) NULL,
	[bi_oi] [varchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Persona]    Script Date: 22/04/2022 19:15:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persona](
	[idPersonal] [int] IDENTITY(1,1) NOT NULL,
	[codPersona] [varchar](10) NULL,
	[dni] [varchar](10) NULL,
	[edad] [int] NULL,
	[telefono] [varchar](10) NULL,
	[apellido] [varchar](50) NULL,
	[nombre] [varchar](50) NULL,
	[direccion] [varchar](50) NULL,
	[lugarNacimiento] [varchar](50) NULL,
	[ocupacion] [varchar](50) NULL,
	[procedencia] [varchar](50) NULL,
	[referido] [varchar](50) NULL,
	[fechaNacimiento] [date] NULL,
 CONSTRAINT [PK_Persona] PRIMARY KEY CLUSTERED 
(
	[idPersonal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Antecedentes] ADD  DEFAULT ((1)) FOR [estado]
GO
/****** Object:  StoredProcedure [dbo].[sp_IngresarAntecedentes]    Script Date: 22/04/2022 19:15:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[sp_IngresarAntecedentes]
	@diabetico  varchar(50) ,
	@hipertenso  varchar(50),
	@cardiacos  varchar(50),
	@lagrimeo  varchar(50),
	@otros  varchar(50),
	@alergico_a  varchar(50),
	@medicamentos  varchar(50),
	@anestesicos  varchar(50),
	@medicamentos_u  varchar(max) 
As
Insert Into Antecedentes(diabetico,hipertenso,cardiacos,lagrimeo,otros,alergico_a,medicamentos,anestesicos,medicamentos_u)
values(@diabetico,@hipertenso,@cardiacos,@lagrimeo,@otros,@alergico_a,@medicamentos,@anestesicos,@medicamentos_u)
return @@identity	
GO
/****** Object:  StoredProcedure [dbo].[sp_IngresarCita]    Script Date: 22/04/2022 19:15:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_IngresarCita]
@diagnostico	varchar(100),
@tratamiento	varchar(100),
@medico			varchar(100),
@fecha			date
As
Insert Into Cita(diagnostico,tratamiento,medico,fecha)
values(@diagnostico,@tratamiento,@medico,@fecha)
return @@identity
GO
/****** Object:  StoredProcedure [dbo].[sp_IngresarLamparah]    Script Date: 22/04/2022 19:15:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_IngresarLamparah]

	@parpados_od varchar(20) ,
	@parpados_oi varchar(20) ,
	@lacriales_od varchar(20) ,
	@lacriales_oi varchar(20) ,
	@conjutiva_od varchar(20) ,
	@conjutiva_oi varchar(20) ,
	@cornea_od varchar(20) ,
	@cornea_oi varchar(20) ,
	@iris_od varchar(20) ,
	@iris_oi varchar(20) ,
	@cristalino_od varchar(20) ,
	@cristalino_oi varchar(20) ,
	@vitreo_od varchar(20) ,
	@vitreo_oi varchar(20) ,
	@retina_od varchar(20) ,
	@retina_oi varchar(20) ,
	@fondos_od varchar(max) ,
	@fondos_oi varchar(max) 

As
Insert Into Lamparah(parpados_od,parpados_oi,lacriales_od,lacriales_oi,conjutiva_od,conjutiva_oi,cornea_od,cornea_oi,iris_od,iris_oi,cristalino_od,cristalino_oi,vitreo_od,vitreo_oi,retina_od,retina_oi,fondos_od,fondos_oi)
values	(@parpados_od,@parpados_oi,@lacriales_od,@lacriales_oi,@conjutiva_od,@conjutiva_oi,@cornea_od,@cornea_oi,@iris_od,@iris_oi,@cristalino_od,@cristalino_oi,@vitreo_od,@vitreo_oi,@retina_od,@retina_oi,@fondos_od,@fondos_oi)
return @@identity
GO
/****** Object:  StoredProcedure [dbo].[sp_IngresarMotivo]    Script Date: 22/04/2022 19:15:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[sp_IngresarMotivo]
@dolor		bit,
@orojo		bit,
@dvisual	bit,
@vdoble		bit,
@otro		bit

As
Insert Into Motivo(dolor,orojo,dvisual,vdoble,otros)
values(@dolor,@orojo,@dvisual,@vdoble,@otro)
return @@identity
GO
/****** Object:  StoredProcedure [dbo].[sp_IngresarOftalmologicos]    Script Date: 22/04/2022 19:15:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_IngresarOftalmologicos]
	@sc_od	varchar(10),
	@sc_oi	 varchar(10),
	@cc_od	varchar(10),
	@cc_oi	 varchar(10),
	@ae_od	 varchar(10),
	@ae_oi	 varchar(10),
	@pio_od	 varchar(10),
	@pio_oi	varchar(10),
	@re_od	varchar(10),
	@re_oi	 varchar(10),
	@re_add	 varchar(10),
	@re_dio	 varchar(10),
	@ka_od	varchar(10),
	@ka_oi	varchar(10),
	@bi_od	varchar(10),
	@bi_oi	 varchar(10)

As
Insert Into Oftalmologicos(sc_od, sc_oi,cc_od,cc_oi,ae_od,ae_oi,pio_od,pio_oi,re_od,re_oi,re_add,re_dio,ka_od,ka_oi,bi_od,bi_oi)
values	(@sc_od, @sc_oi,@cc_od,@cc_oi,@ae_od,@ae_oi,@pio_od,@pio_oi,@re_od,@re_oi,@re_add,@re_dio,@ka_od,@ka_oi,@bi_od,@bi_oi)
return @@identity
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertarPersona]    Script Date: 22/04/2022 19:15:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_InsertarPersona]
@codPersona varchar(10),
@dni varchar(10),
@edad int,
@telefono varchar(10),
@apellido varchar(50),
@nombre varchar(50),
@direccion varchar(50),
@lNacimiento varchar(50),
@ocupacion varchar(50),
@procedencia varchar(50),
@referido varchar(50),
@fecha date

AS
INSERT INTO persona VALUES (@codPersona,@dni,@edad, @telefono ,@apellido ,@nombre ,@direccion ,@lNacimiento,@ocupacion ,@procedencia ,@referido,@fecha)
GO
