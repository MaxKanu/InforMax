USE [master]
GO
/****** Object:  Database [Informax]    Script Date: 02/02/2022 12:54:16 ******/
CREATE DATABASE [Informax]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Informax', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Informax.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Informax_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Informax_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Informax] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Informax].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Informax] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Informax] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Informax] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Informax] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Informax] SET ARITHABORT OFF 
GO
ALTER DATABASE [Informax] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Informax] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Informax] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Informax] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Informax] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Informax] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Informax] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Informax] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Informax] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Informax] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Informax] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Informax] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Informax] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Informax] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Informax] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Informax] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Informax] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Informax] SET RECOVERY FULL 
GO
ALTER DATABASE [Informax] SET  MULTI_USER 
GO
ALTER DATABASE [Informax] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Informax] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Informax] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Informax] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Informax] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Informax', N'ON'
GO
ALTER DATABASE [Informax] SET QUERY_STORE = OFF
GO
USE [Informax]
GO
/****** Object:  Table [dbo].[tblCliente]    Script Date: 02/02/2022 12:54:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCliente](
	[IdCliente] [int] NOT NULL,
	[DataNascimento] [date] NULL,
 CONSTRAINT [PK_tblCliente] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDocumentoJuridico]    Script Date: 02/02/2022 12:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDocumentoJuridico](
	[IdDocumentoJuridico] [int] NOT NULL,
	[IE] [varchar](20) NULL,
	[CNPJ] [varchar](14) NOT NULL,
 CONSTRAINT [PK_tblDocumentoJuridico] PRIMARY KEY CLUSTERED 
(
	[IdDocumentoJuridico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDocumentos]    Script Date: 02/02/2022 12:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDocumentos](
	[IdDocumentos] [int] NOT NULL,
	[RG] [varchar](13) NULL,
	[CPF] [varchar](12) NULL,
	[Matricula] [varchar](7) NULL,
 CONSTRAINT [PK_tblDocumentos] PRIMARY KEY CLUSTERED 
(
	[IdDocumentos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblEmail]    Script Date: 02/02/2022 12:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblEmail](
	[IdEmail] [int] NOT NULL,
	[Email1] [varchar](100) NOT NULL,
	[Email2] [varchar](100) NULL,
 CONSTRAINT [PK_tblEmail] PRIMARY KEY CLUSTERED 
(
	[IdEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblFuncionario]    Script Date: 02/02/2022 12:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblFuncionario](
	[IdFuncionario] [int] NOT NULL,
	[DataNascimento] [date] NOT NULL,
 CONSTRAINT [PK_tblFuncionario] PRIMARY KEY CLUSTERED 
(
	[IdFuncionario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPessoa]    Script Date: 02/02/2022 12:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPessoa](
	[IdPessoa] [int] IDENTITY(1,1) NOT NULL,
	[IdTipoPessoa] [int] NOT NULL,
	[IdSituacao] [int] NOT NULL,
	[Nome] [varchar](150) NOT NULL,
	[Cadastro] [date] NOT NULL,
	[Alteracao] [date] NULL,
 CONSTRAINT [PK_tblPessoa] PRIMARY KEY CLUSTERED 
(
	[IdPessoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPessoaSituacao]    Script Date: 02/02/2022 12:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPessoaSituacao](
	[IdSituacao] [int] NOT NULL,
	[Descricao] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblPessoaSituacao] PRIMARY KEY CLUSTERED 
(
	[IdSituacao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPessoaTipo]    Script Date: 02/02/2022 12:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPessoaTipo](
	[IdTipoPessoa] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](20) NOT NULL,
 CONSTRAINT [PK_tblPessoaTipo] PRIMARY KEY CLUSTERED 
(
	[IdTipoPessoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTelefone]    Script Date: 02/02/2022 12:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTelefone](
	[IdTelefone] [int] NOT NULL,
	[Fixo1] [varchar](10) NULL,
	[Fixo2] [varchar](10) NULL,
	[Celular1] [varchar](11) NOT NULL,
	[Celular2] [varchar](11) NULL,
 CONSTRAINT [PK_tblTelefone] PRIMARY KEY CLUSTERED 
(
	[IdTelefone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblEnderecos]    Script Date: 02/02/2022 12:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblEnderecos](
	[IdEndereco] [int] NOT NULL,
	[Rua] [varchar](150) NOT NULL,
	[Numero] [varchar](7) NOT NULL,
	[Complemento1] [varchar](10) NULL,
	[Complemento2] [varchar](10) NULL,
	[CEP] [varchar](9) NULL,
	[Bairro] [varchar](150) NOT NULL,
	[Cidade] [varchar](150) NOT NULL,
	[Estado] [char](2) NOT NULL,
 CONSTRAINT [PK_tblEnderecos] PRIMARY KEY CLUSTERED 
(
	[IdEndereco] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[uvwCliente_Funcionario]    Script Date: 02/02/2022 12:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






CREATE VIEW [dbo].[uvwCliente_Funcionario]
  AS
	SELECT 
		pes.IdPessoa, pes.Nome, pes.Alteracao, pes.Cadastro, pesT.IdTipoPessoa, pesT.Descricao AS Tipo_Pessoa, 
		sit.IdSituacao, sit.Descricao AS Situacao, ende.IdEndereco, ende.Rua, ende.Numero, ende.Complemento1, ende.Complemento2,
		ende.Bairro, ende.CEP, ende.Cidade, ende.Estado,tel.IdTelefone, tel.Fixo1, tel.Celular1, tel.Fixo2, tel.Celular2,
		doc.IdDocumentos, doc.Matricula, doc.RG, doc.CPF,docj.IdDocumentoJuridico, docj.CNPJ, docj.IE,ema.IdEmail, ema.Email1, ema.Email2
			
	FROM tblPessoa AS pes
			JOIN
			 tblPessoaTipo AS pesT ON pesT.IdTipoPessoa = pes.IdTipoPessoa
			JOIN
			 tblPessoaSituacao AS sit ON sit.IdSituacao = pes.IdSituacao
			 LEFT JOIN
			 tblEnderecos AS ende ON pes.IdPessoa = ende.IdEndereco
			 LEFT JOIN
			 tblTelefone AS tel ON pes.IdPessoa = tel.IdTelefone
			 LEFT JOIN
			 tblDocumentos AS doc ON pes.IdPessoa = doc.IdDocumentos
			 LEFT JOIN 
			 tblDocumentoJuridico AS docj ON pes.IdPessoa = docj.IdDocumentoJuridico
			 LEFT JOIN
			 tblEmail AS ema ON pes.IdPessoa = ema.IdEmail
			 LEFT JOIN
			   tblCliente AS cli ON pes.IdPessoa = cli.IdCliente
			  LEFT JOIN
			   tblFuncionario AS func ON pes.IdPessoa = func.IdFuncionario
			   
			   
GO
/****** Object:  Table [dbo].[tblTipo_Tarefa]    Script Date: 02/02/2022 12:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTipo_Tarefa](
	[IdTipo] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblTipo_Tarefa] PRIMARY KEY CLUSTERED 
(
	[IdTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTarefas]    Script Date: 02/02/2022 12:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTarefas](
	[IdTarefas] [int] IDENTITY(1,1) NOT NULL,
	[IdTipo_Tarefa] [int] NOT NULL,
 CONSTRAINT [PK_tblTarefas] PRIMARY KEY CLUSTERED 
(
	[IdTarefas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblProdutos]    Script Date: 02/02/2022 12:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblProdutos](
	[IdProdutos] [int] NOT NULL,
	[IdFabricante] [int] NOT NULL,
	[Descricao] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblProdutos] PRIMARY KEY CLUSTERED 
(
	[IdProdutos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblServicos]    Script Date: 02/02/2022 12:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblServicos](
	[IdServicos] [int] NOT NULL,
	[Descricao] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblServicos] PRIMARY KEY CLUSTERED 
(
	[IdServicos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[uvwProduto_Servico]    Script Date: 02/02/2022 12:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE VIEW [dbo].[uvwProduto_Servico]
  AS
	SELECT	
			CASE
			 WHEN tipoTar.IdTipo = 1 THEN pro.Descricao
			ELSE serv.Descricao END AS Descricao,
		tar.IdTarefas, pro.IdProdutos, serv.IdServicos
		--pro.Descricao AS Produtos, serv.IdServicos, serv.Descricao AS Servicos
	FROM 

	tblTarefas AS tar
	JOIN
		tblTipo_Tarefa AS tipoTar ON tipoTar.IdTipo = tar.IdTarefas
	LEFT JOIN
		tblProdutos AS pro ON pro.IdProdutos = tar.IdTarefas
	LEFT JOIN
		tblServicos AS serv ON serv.IdServicos = tar.IdTarefas
GO
/****** Object:  Table [dbo].[tblItensDePedidos]    Script Date: 02/02/2022 12:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblItensDePedidos](
	[IdPedido] [int] NOT NULL,
	[IdProdutos] [int] NOT NULL,
	[Quantidade] [int] NOT NULL,
	[ValorUnitario] [decimal](18, 2) NOT NULL,
	[PercentualDesconto] [decimal](5, 2) NOT NULL,
	[ValorDesconto] [decimal](18, 2) NULL,
	[ValorTotal] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_tblItensDePedidos] PRIMARY KEY CLUSTERED 
(
	[IdPedido] ASC,
	[IdProdutos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPedido]    Script Date: 02/02/2022 12:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPedido](
	[IdPedido] [int] IDENTITY(1,1) NOT NULL,
	[DatHora] [datetime] NOT NULL,
	[IdOperacao] [int] NOT NULL,
	[IdSituacao] [int] NOT NULL,
	[IdCliente] [int] NOT NULL,
	[Marcador] [varchar](150) NOT NULL,
 CONSTRAINT [PK_tblPedido] PRIMARY KEY CLUSTERED 
(
	[IdPedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[uvwItensDePedido]    Script Date: 02/02/2022 12:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






CREATE VIEW [dbo].[uvwItensDePedido]
  AS
	SELECT 
		pes.IdPessoa, pes.Nome ,ipe.IdPedido, ipe.IdProdutos,
		ipe.Quantidade, ipe.ValorUnitario, 
		ipe.PercentualDesconto, ipe.ValorDesconto, ipe.ValorTotal
		
	FROM 
		tblItensDePedidos AS ipe
	LEFT JOIN
		tblPedido AS ped ON ped.IdPedido = ipe.IdPedido
	LEFT JOIN
		tblPessoa AS pes ON pes.IdPessoa = ped.IdCliente
GO
/****** Object:  Table [dbo].[tblFabricante]    Script Date: 02/02/2022 12:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblFabricante](
	[IdFabricante] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](50) NULL,
 CONSTRAINT [PK_tblFabricante] PRIMARY KEY CLUSTERED 
(
	[IdFabricante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblJuridico]    Script Date: 02/02/2022 12:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblJuridico](
	[IdJuridico] [int] NOT NULL,
	[DataRegistro] [date] NOT NULL,
	[NomeFantasia] [varchar](35) NULL,
 CONSTRAINT [PK_tblJuridico] PRIMARY KEY CLUSTERED 
(
	[IdJuridico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblOperacao]    Script Date: 02/02/2022 12:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblOperacao](
	[IdOperacao] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblOperacao] PRIMARY KEY CLUSTERED 
(
	[IdOperacao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPedidoSituacao]    Script Date: 02/02/2022 12:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPedidoSituacao](
	[IdSituacao] [int] IDENTITY(1,1) NOT NULL,
	[Situacao] [varchar](40) NOT NULL,
 CONSTRAINT [PK_tblPedidoSituacao] PRIMARY KEY CLUSTERED 
(
	[IdSituacao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPedidoValorTotal]    Script Date: 02/02/2022 12:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPedidoValorTotal](
	[IdPedido] [int] NOT NULL,
	[ValorPedido] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_tblPedidoValorTotal] PRIMARY KEY CLUSTERED 
(
	[IdPedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPreco]    Script Date: 02/02/2022 12:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPreco](
	[IdPreco] [int] IDENTITY(1,1) NOT NULL,
	[IdTarefas] [int] NOT NULL,
	[Preco] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_tblPreco] PRIMARY KEY CLUSTERED 
(
	[IdPreco] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblCliente]  WITH CHECK ADD  CONSTRAINT [FK_tblCliente_tblPessoa] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[tblPessoa] ([IdPessoa])
GO
ALTER TABLE [dbo].[tblCliente] CHECK CONSTRAINT [FK_tblCliente_tblPessoa]
GO
ALTER TABLE [dbo].[tblDocumentoJuridico]  WITH CHECK ADD  CONSTRAINT [FK_tblDocumentoJuridico_tblPessoa] FOREIGN KEY([IdDocumentoJuridico])
REFERENCES [dbo].[tblPessoa] ([IdPessoa])
GO
ALTER TABLE [dbo].[tblDocumentoJuridico] CHECK CONSTRAINT [FK_tblDocumentoJuridico_tblPessoa]
GO
ALTER TABLE [dbo].[tblDocumentos]  WITH CHECK ADD  CONSTRAINT [FK_tblDocumentos_tblPessoa] FOREIGN KEY([IdDocumentos])
REFERENCES [dbo].[tblPessoa] ([IdPessoa])
GO
ALTER TABLE [dbo].[tblDocumentos] CHECK CONSTRAINT [FK_tblDocumentos_tblPessoa]
GO
ALTER TABLE [dbo].[tblEmail]  WITH CHECK ADD  CONSTRAINT [FK_tblEmail_tblPessoa] FOREIGN KEY([IdEmail])
REFERENCES [dbo].[tblPessoa] ([IdPessoa])
GO
ALTER TABLE [dbo].[tblEmail] CHECK CONSTRAINT [FK_tblEmail_tblPessoa]
GO
ALTER TABLE [dbo].[tblEnderecos]  WITH CHECK ADD  CONSTRAINT [FK_tblEnderecos_tblPessoa] FOREIGN KEY([IdEndereco])
REFERENCES [dbo].[tblPessoa] ([IdPessoa])
GO
ALTER TABLE [dbo].[tblEnderecos] CHECK CONSTRAINT [FK_tblEnderecos_tblPessoa]
GO
ALTER TABLE [dbo].[tblFuncionario]  WITH CHECK ADD  CONSTRAINT [FK_tblFuncionario_tblPessoa] FOREIGN KEY([IdFuncionario])
REFERENCES [dbo].[tblPessoa] ([IdPessoa])
GO
ALTER TABLE [dbo].[tblFuncionario] CHECK CONSTRAINT [FK_tblFuncionario_tblPessoa]
GO
ALTER TABLE [dbo].[tblItensDePedidos]  WITH CHECK ADD  CONSTRAINT [FK_tblItensDePedidos_tblPedido] FOREIGN KEY([IdPedido])
REFERENCES [dbo].[tblPedido] ([IdPedido])
GO
ALTER TABLE [dbo].[tblItensDePedidos] CHECK CONSTRAINT [FK_tblItensDePedidos_tblPedido]
GO
ALTER TABLE [dbo].[tblItensDePedidos]  WITH CHECK ADD  CONSTRAINT [FK_tblItensDePedidos_tblTarefas] FOREIGN KEY([IdProdutos])
REFERENCES [dbo].[tblTarefas] ([IdTarefas])
GO
ALTER TABLE [dbo].[tblItensDePedidos] CHECK CONSTRAINT [FK_tblItensDePedidos_tblTarefas]
GO
ALTER TABLE [dbo].[tblJuridico]  WITH CHECK ADD  CONSTRAINT [FK_tblJuridico_tblPessoa] FOREIGN KEY([IdJuridico])
REFERENCES [dbo].[tblPessoa] ([IdPessoa])
GO
ALTER TABLE [dbo].[tblJuridico] CHECK CONSTRAINT [FK_tblJuridico_tblPessoa]
GO
ALTER TABLE [dbo].[tblPedido]  WITH CHECK ADD  CONSTRAINT [FK_tblPedido_tblOperacao] FOREIGN KEY([IdOperacao])
REFERENCES [dbo].[tblOperacao] ([IdOperacao])
GO
ALTER TABLE [dbo].[tblPedido] CHECK CONSTRAINT [FK_tblPedido_tblOperacao]
GO
ALTER TABLE [dbo].[tblPedido]  WITH CHECK ADD  CONSTRAINT [FK_tblPedido_tblPedidoSituacao] FOREIGN KEY([IdSituacao])
REFERENCES [dbo].[tblPedidoSituacao] ([IdSituacao])
GO
ALTER TABLE [dbo].[tblPedido] CHECK CONSTRAINT [FK_tblPedido_tblPedidoSituacao]
GO
ALTER TABLE [dbo].[tblPedido]  WITH CHECK ADD  CONSTRAINT [FK_tblPedido_tblPessoa] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[tblPessoa] ([IdPessoa])
GO
ALTER TABLE [dbo].[tblPedido] CHECK CONSTRAINT [FK_tblPedido_tblPessoa]
GO
ALTER TABLE [dbo].[tblPessoa]  WITH CHECK ADD  CONSTRAINT [FK_tblPessoa_tblPessoaSituacao] FOREIGN KEY([IdSituacao])
REFERENCES [dbo].[tblPessoaSituacao] ([IdSituacao])
GO
ALTER TABLE [dbo].[tblPessoa] CHECK CONSTRAINT [FK_tblPessoa_tblPessoaSituacao]
GO
ALTER TABLE [dbo].[tblPessoa]  WITH CHECK ADD  CONSTRAINT [FK_tblPessoa_tblPessoaTipo] FOREIGN KEY([IdTipoPessoa])
REFERENCES [dbo].[tblPessoaTipo] ([IdTipoPessoa])
GO
ALTER TABLE [dbo].[tblPessoa] CHECK CONSTRAINT [FK_tblPessoa_tblPessoaTipo]
GO
ALTER TABLE [dbo].[tblPreco]  WITH CHECK ADD  CONSTRAINT [FK_tblPreco_tblTarefas] FOREIGN KEY([IdTarefas])
REFERENCES [dbo].[tblTarefas] ([IdTarefas])
GO
ALTER TABLE [dbo].[tblPreco] CHECK CONSTRAINT [FK_tblPreco_tblTarefas]
GO
ALTER TABLE [dbo].[tblProdutos]  WITH CHECK ADD  CONSTRAINT [FK_tblProdutos_tblFabricante] FOREIGN KEY([IdFabricante])
REFERENCES [dbo].[tblFabricante] ([IdFabricante])
GO
ALTER TABLE [dbo].[tblProdutos] CHECK CONSTRAINT [FK_tblProdutos_tblFabricante]
GO
ALTER TABLE [dbo].[tblProdutos]  WITH CHECK ADD  CONSTRAINT [FK_tblProdutos_tblTarefas] FOREIGN KEY([IdProdutos])
REFERENCES [dbo].[tblTarefas] ([IdTarefas])
GO
ALTER TABLE [dbo].[tblProdutos] CHECK CONSTRAINT [FK_tblProdutos_tblTarefas]
GO
ALTER TABLE [dbo].[tblServicos]  WITH CHECK ADD  CONSTRAINT [FK_tblServicos_tblTarefas] FOREIGN KEY([IdServicos])
REFERENCES [dbo].[tblTarefas] ([IdTarefas])
GO
ALTER TABLE [dbo].[tblServicos] CHECK CONSTRAINT [FK_tblServicos_tblTarefas]
GO
ALTER TABLE [dbo].[tblTarefas]  WITH CHECK ADD  CONSTRAINT [FK_tblTarefas_tblTipo_Tarefa] FOREIGN KEY([IdTipo_Tarefa])
REFERENCES [dbo].[tblTipo_Tarefa] ([IdTipo])
GO
ALTER TABLE [dbo].[tblTarefas] CHECK CONSTRAINT [FK_tblTarefas_tblTipo_Tarefa]
GO
ALTER TABLE [dbo].[tblTelefone]  WITH CHECK ADD  CONSTRAINT [FK_tblTelefone_tblPessoa] FOREIGN KEY([IdTelefone])
REFERENCES [dbo].[tblPessoa] ([IdPessoa])
GO
ALTER TABLE [dbo].[tblTelefone] CHECK CONSTRAINT [FK_tblTelefone_tblPessoa]
GO
/****** Object:  StoredProcedure [dbo].[uspAlterarPedido]    Script Date: 02/02/2022 12:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure [dbo].[uspAlterarPedido]

@IDPedido AS INT,
@DataHora AS DATE,
@Operacao AS INT,
@Situacao AS INT,
@Cliente AS INT,
@Marcador AS VARCHAR(150)


AS

Begin
--Exceção(TRY/CATCH)
--Transação
   BEGIN TRY
      BEGIN TRAN

		UPDATE 
				tblPedido
			SET
				DatHora = @DataHora, IdOperacao = @Operacao, IdSituacao = @Situacao, IdCliente = @Cliente, Marcador = @Marcador
			WHERE	
				IdPedido = @IDPedido


	  Select @IDPedido AS Retorno

	  COMMIT TRAN

   END TRY
   BEGIN CATCH
        ROLLBACK TRAN
		SELECT ERROR_MESSAGE() AS Retorno;

   END CATCH

END
GO
/****** Object:  StoredProcedure [dbo].[uspComboProduto]    Script Date: 02/02/2022 12:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspComboProduto]
@IdProdutos AS INT = NULL,
@Descricao AS VARCHAR(50) = NULL
AS
BEGIN
	SELECT
		IdProdutos, Descricao
	FROM
		tblProdutos
	WHERE
		(@IdProdutos IS NULL OR IdProdutos = @IdProdutos) AND
		(@Descricao IS NULL OR Descricao like '%' + @Descricao + '%')
END

GO
/****** Object:  StoredProcedure [dbo].[uspComboServico]    Script Date: 02/02/2022 12:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspComboServico]
@IdServicos AS INT = NULL,
@Descricao AS VARCHAR(50) = NULL
AS
BEGIN
	SELECT
		IdServicos, Descricao
	FROM
		tblServicos
	WHERE
		(@IdServicos IS NULL OR IdServicos = @IdServicos) AND
		(@Descricao IS NULL OR Descricao like '%' + @Descricao + '%')
END

GO
/****** Object:  StoredProcedure [dbo].[uspConsultarClientePorCodigoNome]    Script Date: 02/02/2022 12:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspConsultarClientePorCodigoNome]
	@IdCliente AS INT = NULL,
	@Nome AS VARCHAR(100) = NULL
AS
BEGIN
	
	SELECT 
		cli.IdCliente, pes.Nome, pes.Tipo_Pessoa, pes.Situacao, pes.Cadastro, cli.DataNascimento AS Data_Nascimento,
		pes.RG, pes.CPF, pes.Rua, pes.Numero, pes.Complemento1, pes.Complemento2, pes.CEP, pes.Bairro, 
		pes.Cidade, pes.Estado, pes.Fixo1, pes.Fixo2, pes.Celular1, pes.Celular2, pes.Email1, pes.Email2
	FROM 
	tblCliente AS cli
	JOIN
	uvwCliente_Funcionario AS pes ON pes.IdPessoa = cli.IdCliente

	WHERE
		(@IdCliente IS NULL OR cli.IdCliente = @IdCliente) AND
		(@Nome IS NULL OR pes.Nome like '%' + @Nome + '%')

END
GO
/****** Object:  StoredProcedure [dbo].[uspConsultarFabricante]    Script Date: 02/02/2022 12:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspConsultarFabricante]
@IdFabricante AS INT = NULL,
@Descricao AS VARCHAR(50) = NULL
AS
BEGIN
	SELECT
		IdFabricante, Descricao
	FROM
		tblFabricante
	WHERE
		(@IdFabricante IS NULL OR IdFabricante = @IdFabricante) AND
		(@Descricao IS NULL OR Descricao like '%' + @Descricao + '%')
END
GO
/****** Object:  StoredProcedure [dbo].[uspConsultarFuncionarioPorCodigoNome]    Script Date: 02/02/2022 12:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspConsultarFuncionarioPorCodigoNome]
	@IdFuncionario AS INT = NULL,
	@Nome AS VARCHAR(100) = NULL
AS
BEGIN
	
	SELECT 
		func.IdFuncionario, pes.Nome, pes.Tipo_Pessoa, pes.Situacao, pes.Cadastro, func.DataNascimento AS Data_Nascimento,
		pes.RG, pes.CPF, pes.Matricula, pes.Rua, pes.Numero, pes.Complemento1, pes.Complemento2, pes.CEP, pes.Bairro, 
		pes.Cidade, pes.Estado, pes.Fixo1, pes.Fixo2, pes.Celular1, pes.Celular2, pes.Email1, pes.Email2
	FROM 
	tblFuncionario AS func
	JOIN
	uvwCliente_Funcionario AS pes ON pes.IdPessoa = func.IdFuncionario

	WHERE
		(@IdFuncionario IS NULL OR func.IdFuncionario = @IdFuncionario) AND
		(@Nome IS NULL OR pes.Nome like '%' + @Nome + '%')

END
GO
/****** Object:  StoredProcedure [dbo].[uspConsultarItensPedidos]    Script Date: 02/02/2022 12:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspConsultarItensPedidos]

@IDPedido AS INT = NULL,
@IdCliente AS INT = NULL

AS

BEGIN 

	SELECT
		IdPedido, IdPessoa, Nome, Descricao, Quantidade, ValorUnitario, PercentualDesconto, ValorDesconto, ValorTotal
	FROM
		uvwItensDePedido AS uip
	JOIN
		uvwProduto_Servico AS ups ON ups.IdTarefas = uip.IdProdutos
		
	WHERE
		(@IDPedido IS NULL OR IdPedido = @IDPedido) AND
		(@IdCliente IS NULL OR IdPessoa = @IdCliente)
END
GO
/****** Object:  StoredProcedure [dbo].[uspConsultarJuridicoPorCodigoNome]    Script Date: 02/02/2022 12:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspConsultarJuridicoPorCodigoNome]
	@IdJuridico AS INT = NULL,
	@Nome AS VARCHAR(100) = NULL
AS
BEGIN
	
	SELECT 
		jud.IdJuridico, pes.Nome, pes.Tipo_Pessoa, pes.Situacao, pes.Cadastro, jud.DataRegistro AS Data_Registro, jud.NomeFantasia AS Nome_Fantasia,
		pes.IE,pes.CNPJ, pes.Rua, pes.Numero, pes.Complemento1, pes.Complemento2, pes.CEP, pes.Bairro, 
		pes.Cidade, pes.Estado, pes.Fixo1, pes.Fixo2, pes.Celular1, pes.Celular2, pes.Email1, pes.Email2
	FROM 
	tblJuridico AS jud
	JOIN
	uvwCliente_Funcionario AS pes ON pes.IdPessoa = jud.IdJuridico

	WHERE
		(@IdJuridico IS NULL OR jud.IdJuridico = @IdJuridico) AND
		(@Nome IS NULL OR pes.Nome like '%' + @Nome + '%')

END
GO
/****** Object:  StoredProcedure [dbo].[uspConsultarPedidos]    Script Date: 02/02/2022 12:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspConsultarPedidos]

@IDPedido AS INT = NULL,
@IdCliente AS INT = NULL

AS

BEGIN 
	SELECT
		ped.IdPedido, pes.Nome, op.Descricao, ps.Situacao, ped.DatHora as Cadastro, ped.Marcador
	FROM 
		tblPedido as ped
	JOIN
		tblPessoa as pes on pes.IdPessoa = ped.IdCliente
	JOIN
		tblOperacao as op on ped.IdOperacao = op.IdOperacao
	JOIN
		tblPedidoSituacao as ps on ps.IdSituacao = ped.IdSituacao
		
	WHERE
		(@IDPedido IS NULL OR IdPedido = @IDPedido) AND
		(@IdCliente IS NULL OR IdPessoa = @IdCliente)
END
GO
/****** Object:  StoredProcedure [dbo].[uspConsultarPrecosProdutos]    Script Date: 02/02/2022 12:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--SELECT * FROM tblPreco

CREATE PROCEDURE [dbo].[uspConsultarPrecosProdutos]
@IdTarefas AS INT = NULL,
@Descricao AS VARCHAR(50) = NULL

AS
BEGIN
	BEGIN TRY
		SELECT
			tar.IdProdutos, tar.Produtos, pre.Preco
		FROM
			tblPreco AS pre
		JOIN
			uvwProduto_Servico AS tar ON tar.IdProdutos = pre.IdTarefas
		WHERE
			(@IdTarefas IS NULL OR @IdTarefas  = tar.IdTarefas) AND
			(@Descricao IS NULL OR tar.Produtos LIKE '%'+@Descricao+'%')
	END TRY
	BEGIN CATCH
		SELECT ERROR_MESSAGE() AS Retorno
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspConsultarPrecosServicos]    Script Date: 02/02/2022 12:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--SELECT * FROM tblPreco

CREATE PROCEDURE [dbo].[uspConsultarPrecosServicos]
@IdTarefas AS INT = NULL,
@Descricao AS VARCHAR(50) = NULL

AS
BEGIN
	BEGIN TRY
		SELECT
			tar.IdServicos, tar.Servicos, pre.Preco
		FROM
			tblPreco AS pre
		JOIN
			uvwProduto_Servico AS tar ON tar.IdServicos = pre.IdTarefas
		WHERE
			(@IdTarefas IS NULL OR @IdTarefas  = tar.IdServicos) AND
			(@Descricao IS NULL OR tar.Servicos LIKE '%'+@Descricao+'%')
	END TRY
	BEGIN CATCH
		SELECT ERROR_MESSAGE() AS Retorno
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspConsultarProdutos]    Script Date: 02/02/2022 12:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspConsultarProdutos]
@IdProdutos AS INT = NULL,
@Descricao AS VARCHAR(50) = NULL
AS
BEGIN
	SELECT
		IdProdutos, prod.Descricao, fab.Descricao AS Fabricante
	FROM
		tblProdutos AS prod
	JOIN
		tblFabricante AS fab ON prod.Idfabricante = fab.IdFabricante
	WHERE
		(@IdProdutos IS NULL OR IdProdutos = @IdProdutos) AND
		(@Descricao IS NULL OR prod.Descricao like '%' + @Descricao + '%')
	END
GO
/****** Object:  StoredProcedure [dbo].[uspConsultarServico]    Script Date: 02/02/2022 12:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspConsultarServico]
@IdServicos AS INT = NULL,
@Descricao AS VARCHAR(50) = NULL
AS
BEGIN
	SELECT
		IdServicos, Descricao
	FROM
		tblServicos
	WHERE
		(@IdServicos IS NULL OR IdServicos = @IdServicos) AND
		(@Descricao IS NULL OR Descricao like '%' + @Descricao + '%')
END

GO
/****** Object:  StoredProcedure [dbo].[uspInserirCadastroFisico]    Script Date: 02/02/2022 12:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspInserirCadastroFisico]
@Nome AS VARCHAR(150),
@PessoaTipo AS INT,
@Situacao AS INT,
@Cadastro AS DATE,
@Data_Nascimento AS DATE,
@RG AS VARCHAR(13),
@CPF AS VARCHAR(12),
--@Matricula AS VARCHAR(7),
@Rua AS VARCHAR(150),
@Numero AS VARCHAR(7),
@Complemento1 AS VARCHAR(10),
@Complemento2 AS VARCHAR(10),
@CEP AS VARCHAR(9),
@Bairro AS VARCHAR(150),
@Cidade AS VARCHAR(150),
@Estado AS CHAR(2),
@Fixo1 AS VARCHAR(10),
@Fixo2 AS VARCHAR(10),
@Celular1 AS VARCHAR(11),
@Celular2 AS VARCHAR(11),
@Email1 AS VARCHAR(100),
@Email2 AS VARCHAR(100)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
		

	  DECLARE @IDPessoa as int
	  
		IF(EXISTS(SELECT IdPessoa from tblPessoa where IdPessoa = @IDPessoa))
		RAISERROR ('Usuario já cadastrado', 14,1);

		IF(EXISTS(SELECT Nome from tblPessoa where Nome = @Nome))
		RAISERROR ('Cliente já cadastrado', 14,1);
		
		IF(EXISTS(SELECT Email1 from tblEmail where Email1 = @Email1))
		RAISERROR ('Este Email não é permitido', 14,1);

		IF(EXISTS(SELECT Email1 from tblEmail where Email2 = @Email2))
		RAISERROR ('Este Email não é permitido', 14,1);

		IF(EXISTS(SELECT CPF from tblDocumentos where CPF = @CPF))
		RAISERROR ('Documento já cadastrado', 14,1);
		
		IF(EXISTS(SELECT RG from tblDocumentos where RG = @RG))
		RAISERROR ('Documento já cadastrado', 14,1);


	  --1º Inserir na Tabela tblPessoa
	  Insert into tblPessoa(IdTipoPessoa, IdSituacao, Nome, Cadastro) Values ( @PessoaTipo, @Situacao, @Nome,GETDATE());

	  set @IDPessoa = @@Identity;

	  --2º Inserir na Tabela tblCliente
	  Insert Into tblCliente( IdCliente, DataNascimento) Values (@IDPessoa, @Data_Nascimento);

	  --Insert Into tblFuncionario( IdFuncionario, DataNascimento) Values (@IDPessoa, @Data_Nascimento);

	  --Inserir na Tabela tblEmail
	  Insert Into tblEmail(IdEmail, Email1, Email2) Values (@IDPessoa, @Email1, @Email2);

	  --3º Inserir na Tabela tblEnderecos
	  Insert into tblEnderecos(IdEndereco, Rua, Numero, Complemento1, Complemento2, CEP, Bairro, Cidade, Estado) Values(@IDPessoa, @Rua, @Numero, @Complemento1, @Complemento2, @Cep, @Bairro, @Cidade, @Estado);

	  --4º Inserir na tblTelefone
	  Insert Into tblTelefone(IdTelefone, Fixo1, Fixo2, Celular1, Celular2) VALUES (@IDPessoa, @Fixo1, @Fixo2, @Celular1, @Celular2);

	  --5º Inserir na Tabela tblDocumentos
	  Insert Into tblDocumentos(IdDocumentos, CPF, RG) Values(@IDPessoa, @CPF, @RG);

	  Select @IDPessoa AS Retorno

		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		SELECT ERROR_MESSAGE() AS Retorno;
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspInserirCadastroFuncionario]    Script Date: 02/02/2022 12:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspInserirCadastroFuncionario]
@Nome AS VARCHAR(150),
@Cadastro AS DATE,
@Data_Nascimento AS DATE,
@PessoaTipo AS INT,
@Situacao AS INT,
@RG AS VARCHAR(13),
@CPF AS VARCHAR(12),
@Matricula AS VARCHAR(7),
@Rua AS VARCHAR(150),
@Numero AS VARCHAR(7),
@Complemento1 AS VARCHAR(10),
@Complemento2 AS VARCHAR(10),
@CEP AS VARCHAR(9),
@Bairro AS VARCHAR(150),
@Cidade AS VARCHAR(150),
@Estado AS CHAR(2),
@Fixo1 AS VARCHAR(10),
@Fixo2 AS VARCHAR(10),
@Celular1 AS VARCHAR(11),
@Celular2 AS VARCHAR(11),
@Email1 AS VARCHAR(100),
@Email2 AS VARCHAR(100)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
		

	  DECLARE @IDPessoa as int
	  
		IF(EXISTS(SELECT IdPessoa from tblPessoa where IdPessoa = @IDPessoa))
		RAISERROR ('Usuario já cadastrado', 14,1);

		IF(EXISTS(SELECT Nome from tblPessoa where Nome = @Nome))
		RAISERROR ('Funcionário já cadastrado', 14,1);
		
		IF(EXISTS(SELECT Email1 from tblEmail where Email1 = @Email1))
		RAISERROR ('Este Email não é permitido', 14,1);

		IF(EXISTS(SELECT Email1 from tblEmail where Email2 = @Email2))
		RAISERROR ('Este Email não é permitido', 14,1);

		IF(EXISTS(SELECT CPF from tblDocumentos where CPF = @CPF))
		RAISERROR ('Documento já cadastrado', 14,1);
		
		IF(EXISTS(SELECT RG from tblDocumentos where RG = @RG))
		RAISERROR ('Documento já cadastrado', 14,1);


	  --1º Inserir na Tabela tblPessoa
	  Insert into tblPessoa(IdTipoPessoa, IdSituacao,  Nome, Cadastro) Values ( @PessoaTipo, @Situacao, @Nome,GETDATE());

	  set @IDPessoa = @@Identity;

	  --2º Inserir na Tabela tblCliente Insert Into tblCliente( IdCliente, IdSexo, Nascimento_Fundacao, Observacoes) Values (@IDPessoa, @Sexo, @Data_Nascimento, @Observacoes);

	  Insert Into tblFuncionario( IdFuncionario, DataNascimento) Values (@IDPessoa, @Data_Nascimento);

	  --Inserir na Tabela tblEmail
	  Insert Into tblEmail(IdEmail, Email1, Email2) Values (@IDPessoa, @Email1, @Email2);

	  --3º Inserir na Tabela tblEnderecos
	  Insert into tblEnderecos(IdEndereco, Rua, Numero, Complemento1, Complemento2, CEP, Bairro, Cidade, Estado) Values(@IDPessoa, @Rua, @Numero, @Complemento1, @Complemento2, @Cep, @Bairro, @Cidade, @Estado);

	  --4º Inserir na tblTelefone
	  Insert Into tblTelefone(IdTelefone, Fixo1, Fixo2, Celular1, Celular2) VALUES (@IDPessoa, @Fixo1, @Fixo2, @Celular1, @Celular2);

	  --5º Inserir na Tabela tblDocumentos
	  Insert Into tblDocumentos(IdDocumentos, CPF, RG, Matricula) Values(@IDPessoa, @CPF, @RG, @Matricula);

	  Select @IDPessoa AS Retorno

		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		SELECT ERROR_MESSAGE() AS Retorno;
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspInserirCadastroJuridico]    Script Date: 02/02/2022 12:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspInserirCadastroJuridico]
@Nome AS VARCHAR(150),
@PessoaTipo AS INT,
@Situacao AS INT,
@Cadastro AS DATE,
@Data_Registro AS DATE,
@CNPJ AS VARCHAR(14),
@IE AS VARCHAR(12),
@Nome_Fantasia AS VARCHAR(35),
--@Matricula AS VARCHAR(7),
@Rua AS VARCHAR(150),
@Numero AS VARCHAR(7),
@Complemento1 AS VARCHAR(10),
@Complemento2 AS VARCHAR(10),
@CEP AS VARCHAR(9),
@Bairro AS VARCHAR(150),
@Cidade AS VARCHAR(150),
@Estado AS CHAR(2),
@Fixo1 AS VARCHAR(10),
@Fixo2 AS VARCHAR(10),
@Celular1 AS VARCHAR(11),
@Celular2 AS VARCHAR(11),
@Email1 AS VARCHAR(100),
@Email2 AS VARCHAR(100)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
		

	  DECLARE @IDPessoa as int
	  
		IF(EXISTS(SELECT IdPessoa from tblPessoa where IdPessoa = @IDPessoa))
		RAISERROR ('Usuario já cadastrado', 14,1);

		IF(EXISTS(SELECT Nome from tblPessoa where Nome = @Nome))
		RAISERROR ('Cliente já cadastrado', 14,1);
		
		IF(EXISTS(SELECT Email1 from tblEmail where Email1 = @Email1))
		RAISERROR ('Este Email não é permitido', 14,1);

		IF(EXISTS(SELECT Email1 from tblEmail where Email2 = @Email2))
		RAISERROR ('Este Email não é permitido', 14,1);

		IF(EXISTS(SELECT IE from tblDocumentoJuridico where IE = @IE))
		RAISERROR ('Documento já cadastrado', 14,1);
		
		IF(EXISTS(SELECT CNPJ from tblDocumentoJuridico where CNPJ = @CNPJ))
		RAISERROR ('Documento já cadastrado', 14,1);


	  --1º Inserir na Tabela tblPessoa
	  Insert into tblPessoa(IdTipoPessoa, IdSituacao,  Nome, Cadastro) Values ( @PessoaTipo, @Situacao, @Nome,GETDATE());

	  set @IDPessoa = @@Identity;

	  --2º Inserir na Tabela tblCliente
	  --Insert Into tblCliente( IdCliente, DataNascimento) Values (@IDPessoa, @Data_Nascimento);

	  --Insert Into tblFuncionario( IdFuncionario, DataNascimento) Values (@IDPessoa, @Data_Nascimento);

	  Insert INTO tblJuridico(IdJuridico, DataRegistro, NomeFantasia) VALUES(@IDPessoa, @Data_Registro, @Nome_Fantasia)

	  --Inserir na Tabela tblEmail
	  Insert Into tblEmail(IdEmail, Email1, Email2) Values (@IDPessoa, @Email1, @Email2);

	  --3º Inserir na Tabela tblEnderecos
	  Insert into tblEnderecos(IdEndereco, Rua, Numero, Complemento1, Complemento2, CEP, Bairro, Cidade, Estado) Values(@IDPessoa, @Rua, @Numero, @Complemento1, @Complemento2, @Cep, @Bairro, @Cidade, @Estado);

	  --4º Inserir na tblTelefone
	  Insert Into tblTelefone(IdTelefone, Fixo1, Fixo2, Celular1, Celular2) VALUES (@IDPessoa, @Fixo1, @Fixo2, @Celular1, @Celular2);

	  --5º Inserir na Tabela tblDocumentos
	  Insert Into tblDocumentoJuridico(IdDocumentoJuridico, IE, CNPJ) Values(@IDPessoa, @IE, @CNPJ);

	  Select @IDPessoa AS Retorno

		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		SELECT ERROR_MESSAGE() AS Retorno;
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspInserirFabricante]    Script Date: 02/02/2022 12:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspInserirFabricante]
@Descricao AS VARCHAR(50)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
		DECLARE @IdFabricante AS INT;

		INSERT INTO tblFabricante(Descricao) VALUES(@Descricao)
		
		SET @IdFabricante = @@IDENTITY;

		SELECT @IdFabricante AS retorno;
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		SELECT ERROR_MESSAGE() AS retorno;
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspInserirIPedidosValorTotal]    Script Date: 02/02/2022 12:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspInserirIPedidosValorTotal]

@IdPedido AS INT,
@ValorTotal AS DECIMAL(18,2)



AS

Begin

--Exceção(TRY/CATCH)
--Transação
   BEGIN TRY
      BEGIN TRAN

			IF(EXISTS(SELECT IdPedido FROM tblPedidoValorTotal WHERE IdPedido = @IdPedido))
			RAISERROR ('Nota já foi fechada', 14, 1);

	  
	  --1º Inserir na Tabela tblPessoa, @Exclusao, Exclusao

	  Insert into tblPedidoValorTotal( IdPedido, ValorPedido) 
	  Values (@IdPedido,  @ValorTotal);


	  Select @IdPedido AS Retorno

	  COMMIT TRAN

   END TRY
   BEGIN CATCH
        ROLLBACK TRAN
		SELECT ERROR_MESSAGE() AS Retorno;

   END CATCH

END
GO
/****** Object:  StoredProcedure [dbo].[uspInserirItensPedidos]    Script Date: 02/02/2022 12:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspInserirItensPedidos]

@IdPedido AS INT,
@IdProduto AS INT,
@Quantidade AS INT,
@ValorUnitario AS Decimal(18,2),
@Percentual AS DECIMAL(5,2),
@ValorDesconto AS DECIMAL(18,2),
@ValorTotal AS DECIMAL(18,2)



AS

Begin

--Exceção(TRY/CATCH)
--Transação
   BEGIN TRY
      BEGIN TRAN

			--IF(EXISTS(SELECT IdProdutos FROM tblItensDePedidos WHERE IdPedido = @IdPedido))
			--RAISERROR ('Pedido Existente', 14, 1);

	  
	  --1º Inserir na Tabela tblPessoa, @Exclusao, Exclusao

	  Insert into tblItensDePedidos( IdPedido, IdProdutos, Quantidade, ValorUnitario, PercentualDesconto, ValorDesconto, ValorTotal) 
	  Values (@IdPedido, @IdProduto, @Quantidade, @ValorUnitario, @Percentual, @ValorDesconto, @ValorTotal);


	  Select @IdPedido AS Retorno

	  COMMIT TRAN

   END TRY
   BEGIN CATCH
        ROLLBACK TRAN
		SELECT ERROR_MESSAGE() AS Retorno;

   END CATCH

END
GO
/****** Object:  StoredProcedure [dbo].[uspInserirPedido]    Script Date: 02/02/2022 12:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure [dbo].[uspInserirPedido]

@DataHora AS DATE,
@Operacao AS INT,
@Situacao AS INT,
@Cliente AS INT,
@Marcador AS VARCHAR(150)


AS

Begin

--Exceção(TRY/CATCH)
--Transação
   BEGIN TRY
      BEGIN TRAN

	  DECLARE @IDPedido as int
	  --1º Inserir na Tabela tblPessoa, @Exclusao, Exclusao

	  Insert into tblPedido(DatHora, IdOperacao, IdSituacao, IdCliente, Marcador) Values (GETDATE(), @Operacao, @Situacao, @Cliente, @Marcador);
	   
	  set @IDPedido = @@Identity;

	  Select @IDPedido AS Retorno

	  COMMIT TRAN

   END TRY
   BEGIN CATCH
        ROLLBACK TRAN
		SELECT ERROR_MESSAGE() AS Retorno;

   END CATCH

END
GO
/****** Object:  StoredProcedure [dbo].[uspInserirPrecos]    Script Date: 02/02/2022 12:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspInserirPrecos]
@IdTarefa AS INT,
@Preco AS DECIMAL(18,2)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN

			DECLARE @IdPreco AS INT;

			INSERT INTO tblPreco(IdTarefas, Preco) VALUES(@IdTarefa,@Preco);
		
			SET @IdPreco = @@IDENTITY;

			SELECT @IdPreco AS retorno;

		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		SELECT ERROR_MESSAGE() AS retorno;;
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspInserirProdutos]    Script Date: 02/02/2022 12:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspInserirProdutos]
@IdFabricante AS INT,
@Descricao AS VARCHAR(50)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN

		DECLARE @IdProduto AS INT;
		
			INSERT INTO tblTarefas(IdTipo_Tarefa) Values(1)

			SET @IdProduto = @@IDENTITY;

			INSERT INTO tblProdutos(IdProdutos, Idfabricante, Descricao) VALUES(@IdProduto,@IdFabricante, @Descricao);

			SELECT @IdProduto AS retorno;

		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		SELECT ERROR_MESSAGE() AS retorno;;
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspInserirServicos]    Script Date: 02/02/2022 12:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspInserirServicos]
@Descricao AS VARCHAR(50)
AS
BEGIN 
	BEGIN TRY
		BEGIN TRAN

			DECLARE @IdServico AS INT;

			INSERT INTO tblTarefas(IdTipo_Tarefa) Values(2)

			SET @IdServico = @@IDENTITY;

			INSERT INTO tblServicos(IdServicos,Descricao) VALUES(@IdServico, @Descricao);

			SELECT @IdServico AS Retorno;

			COMMIT TRAN

		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
			SELECT ERROR_MESSAGE() AS Retorno;
		END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspPesquisarPedidos]    Script Date: 02/02/2022 12:54:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspPesquisarPedidos]

@IDPedido AS INT = NULL,
@Cliente AS INT = NULL,
@Nome Varchar(100) = NULL

AS

BEGIN 

	SELECT
		
		ped.IdPedido, cli.IdPessoa, cli.Nome, op.Descricao AS Operacao, sit.Situacao, ped.DatHora, ped.Marcador
		
	FROM
		tblPedido AS ped
	JOIN
		tblOperacao AS op ON ped.IdOperacao = op.IdOperacao
	JOIN
		tblPedidoSituacao AS sit ON ped.IdSituacao = sit.IdSituacao
	JOIN
		uvwCliente_Funcionario AS cli ON ped.IdCliente = cli.IdPessoa

		
	WHERE
		(@IDPedido IS NULL OR IdPedido = @IDPedido) AND
		(@Cliente IS NULL OR @Cliente = @Cliente) AND
		(@Nome IS NULL OR Nome like '%' + @Nome + '%')
END

GO
USE [master]
GO
ALTER DATABASE [Informax] SET  READ_WRITE 
GO
