USE [WiProApiDB]
GO

USE [WiProApiDB]
GO

/****** Object:  Table [dbo].[DePara]    Script Date: 28/12/2020 13:22:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DePara](
	[ID_MOEDA] [varchar](3) NOT NULL,
	[COD_COTACAO] [int] NOT NULL
) ON [PRIMARY]
GO

INSERT INTO DePara (ID_MOEDA, COD_COTACAO)
VALUES 
('AFN',	66),
('ALL',	49),
('ANG',	33),
('ARS',	3 ),
('AWG',	6 ),
('BOB',	56),
('BYN',	64),
('CAD',	25),
('CDF',	58),
('CLP',	16),
('COP', 37),
('CRC',	52),
('CUP',	8 ),
('CVE',	51),
('CZK', 29),
('DJF',	36),
('DZD',	54),
('EGP',	12),
('EUR', 20),
('FJD',	38),
('GBP', 22),
('GEL',	48),
('GIP', 18),
('HTG',	63),
('ILS', 40),
('IRR',	17),
('ISK', 11),
('JPY',	9 ),
('KES', 21),
('KMF',	19),
('LBP', 42),
('LSL',	4 ),
('MGA',	35),
('MGB',	26),
('MMK', 69),
('MRO',	53),
('MRU',	15),
('MUR',	7 ),
('MXN', 41),
('MZN',	43),
('NIO', 23),
('NOK',	62),
('OMR',	34),
('PEN',	45),
('PGK',	2 ),
('PHP',	24),
('RON', 5 ),
('SAR',	44),
('SBD',	32),
('SGD',	70),
('SLL', 10),
('SOS',	61),
('SSP',	47)
