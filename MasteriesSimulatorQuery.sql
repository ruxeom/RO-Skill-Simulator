USE [MasteriesSimulator]
GO
/****** Object:  Table [dbo].[Mastery_to_Mastery]    Script Date: 05/30/2012 19:37:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mastery_to_Mastery](
	[id_mastery] [int] NOT NULL,
	[id_tree] [int] NULL,
	[id_depmastery] [int] NULL,
	[level_req] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_mastery] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Mastery_to_Mastery] ([id_mastery], [id_tree], [id_depmastery], [level_req]) VALUES (8, 1, 1, 4)
INSERT [dbo].[Mastery_to_Mastery] ([id_mastery], [id_tree], [id_depmastery], [level_req]) VALUES (9, 1, 1, 4)
INSERT [dbo].[Mastery_to_Mastery] ([id_mastery], [id_tree], [id_depmastery], [level_req]) VALUES (10, 1, 1, 4)
INSERT [dbo].[Mastery_to_Mastery] ([id_mastery], [id_tree], [id_depmastery], [level_req]) VALUES (11, 1, 1, 8)
INSERT [dbo].[Mastery_to_Mastery] ([id_mastery], [id_tree], [id_depmastery], [level_req]) VALUES (12, 1, 8, 8)
INSERT [dbo].[Mastery_to_Mastery] ([id_mastery], [id_tree], [id_depmastery], [level_req]) VALUES (13, 1, 9, 8)
INSERT [dbo].[Mastery_to_Mastery] ([id_mastery], [id_tree], [id_depmastery], [level_req]) VALUES (14, 1, 1, 8)
INSERT [dbo].[Mastery_to_Mastery] ([id_mastery], [id_tree], [id_depmastery], [level_req]) VALUES (15, 1, 11, 12)
INSERT [dbo].[Mastery_to_Mastery] ([id_mastery], [id_tree], [id_depmastery], [level_req]) VALUES (16, 1, 1, 12)
INSERT [dbo].[Mastery_to_Mastery] ([id_mastery], [id_tree], [id_depmastery], [level_req]) VALUES (17, 1, 1, 12)
INSERT [dbo].[Mastery_to_Mastery] ([id_mastery], [id_tree], [id_depmastery], [level_req]) VALUES (18, 1, 1, 16)
INSERT [dbo].[Mastery_to_Mastery] ([id_mastery], [id_tree], [id_depmastery], [level_req]) VALUES (19, 1, 1, 16)
INSERT [dbo].[Mastery_to_Mastery] ([id_mastery], [id_tree], [id_depmastery], [level_req]) VALUES (20, 1, 1, 20)
INSERT [dbo].[Mastery_to_Mastery] ([id_mastery], [id_tree], [id_depmastery], [level_req]) VALUES (25, 2, 2, 4)
INSERT [dbo].[Mastery_to_Mastery] ([id_mastery], [id_tree], [id_depmastery], [level_req]) VALUES (26, 2, 2, 4)
INSERT [dbo].[Mastery_to_Mastery] ([id_mastery], [id_tree], [id_depmastery], [level_req]) VALUES (27, 2, 2, 8)
INSERT [dbo].[Mastery_to_Mastery] ([id_mastery], [id_tree], [id_depmastery], [level_req]) VALUES (28, 2, 25, 8)
INSERT [dbo].[Mastery_to_Mastery] ([id_mastery], [id_tree], [id_depmastery], [level_req]) VALUES (29, 2, 2, 8)
INSERT [dbo].[Mastery_to_Mastery] ([id_mastery], [id_tree], [id_depmastery], [level_req]) VALUES (30, 2, 24, 8)
INSERT [dbo].[Mastery_to_Mastery] ([id_mastery], [id_tree], [id_depmastery], [level_req]) VALUES (31, 2, 2, 12)
INSERT [dbo].[Mastery_to_Mastery] ([id_mastery], [id_tree], [id_depmastery], [level_req]) VALUES (32, 2, 2, 12)
INSERT [dbo].[Mastery_to_Mastery] ([id_mastery], [id_tree], [id_depmastery], [level_req]) VALUES (33, 2, 2, 12)
INSERT [dbo].[Mastery_to_Mastery] ([id_mastery], [id_tree], [id_depmastery], [level_req]) VALUES (34, 2, 2, 16)
INSERT [dbo].[Mastery_to_Mastery] ([id_mastery], [id_tree], [id_depmastery], [level_req]) VALUES (35, 2, 2, 16)
INSERT [dbo].[Mastery_to_Mastery] ([id_mastery], [id_tree], [id_depmastery], [level_req]) VALUES (36, 2, 2, 20)
INSERT [dbo].[Mastery_to_Mastery] ([id_mastery], [id_tree], [id_depmastery], [level_req]) VALUES (41, 3, 3, 4)
INSERT [dbo].[Mastery_to_Mastery] ([id_mastery], [id_tree], [id_depmastery], [level_req]) VALUES (42, 3, 39, 4)
INSERT [dbo].[Mastery_to_Mastery] ([id_mastery], [id_tree], [id_depmastery], [level_req]) VALUES (43, 3, 3, 4)
INSERT [dbo].[Mastery_to_Mastery] ([id_mastery], [id_tree], [id_depmastery], [level_req]) VALUES (44, 3, 3, 8)
INSERT [dbo].[Mastery_to_Mastery] ([id_mastery], [id_tree], [id_depmastery], [level_req]) VALUES (45, 3, 3, 8)
INSERT [dbo].[Mastery_to_Mastery] ([id_mastery], [id_tree], [id_depmastery], [level_req]) VALUES (46, 3, 3, 8)
INSERT [dbo].[Mastery_to_Mastery] ([id_mastery], [id_tree], [id_depmastery], [level_req]) VALUES (47, 3, 44, 12)
INSERT [dbo].[Mastery_to_Mastery] ([id_mastery], [id_tree], [id_depmastery], [level_req]) VALUES (48, 3, 3, 12)
INSERT [dbo].[Mastery_to_Mastery] ([id_mastery], [id_tree], [id_depmastery], [level_req]) VALUES (49, 3, 3, 12)
INSERT [dbo].[Mastery_to_Mastery] ([id_mastery], [id_tree], [id_depmastery], [level_req]) VALUES (50, 3, 3, 16)
INSERT [dbo].[Mastery_to_Mastery] ([id_mastery], [id_tree], [id_depmastery], [level_req]) VALUES (51, 3, 3, 16)
INSERT [dbo].[Mastery_to_Mastery] ([id_mastery], [id_tree], [id_depmastery], [level_req]) VALUES (52, 3, 3, 20)
/****** Object:  Table [dbo].[Masteries]    Script Date: 05/30/2012 19:37:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Masteries](
	[mastery_id] [int] NOT NULL,
	[mastery_name] [varchar](30) NULL,
	[mastery_type] [int] NULL,
	[max_lvl] [int] NULL,
	[mastery_description] [varchar](80) NULL,
PRIMARY KEY CLUSTERED 
(
	[mastery_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Masteries] ([mastery_id], [mastery_name], [mastery_type], [max_lvl], [mastery_description]) VALUES (4, N'Summoners Wrath', 1, 1, N'Bonus damage with spells')
INSERT [dbo].[Masteries] ([mastery_id], [mastery_name], [mastery_type], [max_lvl], [mastery_description]) VALUES (5, N'Brute Force', 1, 3, N'1/2/3 Attack Damage')
INSERT [dbo].[Masteries] ([mastery_id], [mastery_name], [mastery_type], [max_lvl], [mastery_description]) VALUES (6, N'Mental Force', 1, 4, N'1/2/3/4 Ability Power')
INSERT [dbo].[Masteries] ([mastery_id], [mastery_name], [mastery_type], [max_lvl], [mastery_description]) VALUES (7, N'Butcher', 1, 2, N'2/4 Damage to minions')
INSERT [dbo].[Masteries] ([mastery_id], [mastery_name], [mastery_type], [max_lvl], [mastery_description]) VALUES (8, N'Alacrity', 1, 4, N'1.5/3/4.5/6% Attack Speed')
INSERT [dbo].[Masteries] ([mastery_id], [mastery_name], [mastery_type], [max_lvl], [mastery_description]) VALUES (9, N'Sorcery', 1, 4, N'1/2/3/4% Cooldown Reduction')
INSERT [dbo].[Masteries] ([mastery_id], [mastery_name], [mastery_type], [max_lvl], [mastery_description]) VALUES (10, N'Demolitionist', 1, 1, N'10 Bonus damage to turrets')
INSERT [dbo].[Masteries] ([mastery_id], [mastery_name], [mastery_type], [max_lvl], [mastery_description]) VALUES (11, N'Deadliness', 1, 4, N'0.125/0.25/0.375/0.5 Attack Damage per level')
INSERT [dbo].[Masteries] ([mastery_id], [mastery_name], [mastery_type], [max_lvl], [mastery_description]) VALUES (12, N'Weapon Expertise', 1, 1, N'10% Armor Penetration')
INSERT [dbo].[Masteries] ([mastery_id], [mastery_name], [mastery_type], [max_lvl], [mastery_description]) VALUES (13, N'Arcane Knowledge', 1, 1, N'10% Magic Penetration')
INSERT [dbo].[Masteries] ([mastery_id], [mastery_name], [mastery_type], [max_lvl], [mastery_description]) VALUES (14, N'Havoc', 1, 3, N'Increase Damage Dealt by 0.5/1/1.5%')
INSERT [dbo].[Masteries] ([mastery_id], [mastery_name], [mastery_type], [max_lvl], [mastery_description]) VALUES (15, N'Lethality', 1, 1, N'10% Critical Strike Damage')
INSERT [dbo].[Masteries] ([mastery_id], [mastery_name], [mastery_type], [max_lvl], [mastery_description]) VALUES (16, N'Vampirism', 1, 3, N'1/2/3% Life Steal')
INSERT [dbo].[Masteries] ([mastery_id], [mastery_name], [mastery_type], [max_lvl], [mastery_description]) VALUES (17, N'Blast', 1, 4, N'0.25/.5/.75/1 Ability Power per level')
INSERT [dbo].[Masteries] ([mastery_id], [mastery_name], [mastery_type], [max_lvl], [mastery_description]) VALUES (18, N'Sunder', 1, 3, N'2/4/6 Armor Penetration')
INSERT [dbo].[Masteries] ([mastery_id], [mastery_name], [mastery_type], [max_lvl], [mastery_description]) VALUES (19, N'Archmage', 1, 4, N'Increases your Ability Power 1.25/2.5/3.75/5%')
INSERT [dbo].[Masteries] ([mastery_id], [mastery_name], [mastery_type], [max_lvl], [mastery_description]) VALUES (20, N'Executioner', 1, 1, N'Increases Damage Dealt by 6% to targets below 40% health ')
INSERT [dbo].[Masteries] ([mastery_id], [mastery_name], [mastery_type], [max_lvl], [mastery_description]) VALUES (21, N'Summoners Resolve', 2, 1, N'Health restored with spells')
INSERT [dbo].[Masteries] ([mastery_id], [mastery_name], [mastery_type], [max_lvl], [mastery_description]) VALUES (22, N'Resistance', 2, 3, N'2/4/6 Magic Resist')
INSERT [dbo].[Masteries] ([mastery_id], [mastery_name], [mastery_type], [max_lvl], [mastery_description]) VALUES (23, N'Hardiness', 2, 3, N'2/4/6 Armor')
INSERT [dbo].[Masteries] ([mastery_id], [mastery_name], [mastery_type], [max_lvl], [mastery_description]) VALUES (24, N'Tough Skin', 2, 2, N'Reduces Damage Taken from minions by 1/2')
INSERT [dbo].[Masteries] ([mastery_id], [mastery_name], [mastery_type], [max_lvl], [mastery_description]) VALUES (25, N'Durability', 2, 4, N'1.5/3/4.5/6 Health per level')
INSERT [dbo].[Masteries] ([mastery_id], [mastery_name], [mastery_type], [max_lvl], [mastery_description]) VALUES (26, N'Vigor', 2, 3, N'1/2/3 Health Regen per 5 seconds')
INSERT [dbo].[Masteries] ([mastery_id], [mastery_name], [mastery_type], [max_lvl], [mastery_description]) VALUES (27, N'Indomitable', 2, 2, N'Reduces incoming damage by 1/2')
INSERT [dbo].[Masteries] ([mastery_id], [mastery_name], [mastery_type], [max_lvl], [mastery_description]) VALUES (28, N'Veteran Scars', 2, 1, N'30 Health')
INSERT [dbo].[Masteries] ([mastery_id], [mastery_name], [mastery_type], [max_lvl], [mastery_description]) VALUES (29, N'Evasion', 2, 3, N'Reduce the damage taken from area effect abilities by 1/2/3%')
INSERT [dbo].[Masteries] ([mastery_id], [mastery_name], [mastery_type], [max_lvl], [mastery_description]) VALUES (30, N'Bladed Armor', 2, 1, N'Returns 6 damage against monster and minion attacks')
INSERT [dbo].[Masteries] ([mastery_id], [mastery_name], [mastery_type], [max_lvl], [mastery_description]) VALUES (31, N'Siege Commander', 2, 1, N'Reduces the armor of towers by 10')
INSERT [dbo].[Masteries] ([mastery_id], [mastery_name], [mastery_type], [max_lvl], [mastery_description]) VALUES (32, N'Initiator', 2, 3, N'Increases Movement Speed by 1/2/3% when above 70%')
INSERT [dbo].[Masteries] ([mastery_id], [mastery_name], [mastery_type], [max_lvl], [mastery_description]) VALUES (33, N'Enlightenment', 2, 3, N'0.15/0.3/0.45% Cooldown Reduction per level')
INSERT [dbo].[Masteries] ([mastery_id], [mastery_name], [mastery_type], [max_lvl], [mastery_description]) VALUES (34, N'Honor Guard', 2, 3, N'Reduces damage taken by 0.5/1/1.5%')
INSERT [dbo].[Masteries] ([mastery_id], [mastery_name], [mastery_type], [max_lvl], [mastery_description]) VALUES (35, N'Mercenary', 2, 3, N'8/16/24 bonus gold on champion kills and assists')
INSERT [dbo].[Masteries] ([mastery_id], [mastery_name], [mastery_type], [max_lvl], [mastery_description]) VALUES (36, N'Juggernaut', 2, 1, N'Increases your maximum Health by 3%')
INSERT [dbo].[Masteries] ([mastery_id], [mastery_name], [mastery_type], [max_lvl], [mastery_description]) VALUES (37, N'Summoners Insight', 3, 1, N'Reduces cooldown reduction by 15 with Flash')
INSERT [dbo].[Masteries] ([mastery_id], [mastery_name], [mastery_type], [max_lvl], [mastery_description]) VALUES (38, N'Good Hands', 3, 3, N'Redcues time spent dead by 4/7/10%')
INSERT [dbo].[Masteries] ([mastery_id], [mastery_name], [mastery_type], [max_lvl], [mastery_description]) VALUES (39, N'Expanded Mind', 3, 3, N'4/8/12 Mana per level')
INSERT [dbo].[Masteries] ([mastery_id], [mastery_name], [mastery_type], [max_lvl], [mastery_description]) VALUES (40, N'Improved Recall', 3, 1, N'Reduces the cast time of Recall by 1 second')
INSERT [dbo].[Masteries] ([mastery_id], [mastery_name], [mastery_type], [max_lvl], [mastery_description]) VALUES (41, N'Swiftness', 3, 4, N'0.5/1/1.5/2% Movement Speed')
INSERT [dbo].[Masteries] ([mastery_id], [mastery_name], [mastery_type], [max_lvl], [mastery_description]) VALUES (42, N'Meditation', 3, 3, N'1/2/3 Mana Regen per 5 seconds')
INSERT [dbo].[Masteries] ([mastery_id], [mastery_name], [mastery_type], [max_lvl], [mastery_description]) VALUES (43, N'Scout', 3, 1, N'Increase vision range of wards by 5%')
INSERT [dbo].[Masteries] ([mastery_id], [mastery_name], [mastery_type], [max_lvl], [mastery_description]) VALUES (44, N'Greed', 3, 4, N'Gain an additional 0.5/1/1.5/2 gold every 10 seconds')
INSERT [dbo].[Masteries] ([mastery_id], [mastery_name], [mastery_type], [max_lvl], [mastery_description]) VALUES (45, N'Transmutation', 3, 3, N'1/2/3% Spell Vamp')
INSERT [dbo].[Masteries] ([mastery_id], [mastery_name], [mastery_type], [max_lvl], [mastery_description]) VALUES (46, N'Runic Affinity', 3, 1, N'Increases the buffs duration by 20%')
INSERT [dbo].[Masteries] ([mastery_id], [mastery_name], [mastery_type], [max_lvl], [mastery_description]) VALUES (47, N'Wealth', 3, 2, N'Increases starting gold by 20/40')
INSERT [dbo].[Masteries] ([mastery_id], [mastery_name], [mastery_type], [max_lvl], [mastery_description]) VALUES (48, N'Awareness', 3, 4, N'Increases experience gained by 1.25/2.5/3.75/5%')
INSERT [dbo].[Masteries] ([mastery_id], [mastery_name], [mastery_type], [max_lvl], [mastery_description]) VALUES (49, N'Sage', 3, 1, N'Gain 40 bonus experience points on kills and assists')
INSERT [dbo].[Masteries] ([mastery_id], [mastery_name], [mastery_type], [max_lvl], [mastery_description]) VALUES (50, N'Perseverance', 3, 3, N'Increases Health and Mana Regen by 3/6/9%')
INSERT [dbo].[Masteries] ([mastery_id], [mastery_name], [mastery_type], [max_lvl], [mastery_description]) VALUES (51, N'Intelligence', 3, 3, N'2/4/6% Cooldown Reduction')
INSERT [dbo].[Masteries] ([mastery_id], [mastery_name], [mastery_type], [max_lvl], [mastery_description]) VALUES (52, N'Mastermind', 3, 1, N'Reduces the cooldown of your Summoner Spells by 15%')
/****** Object:  StoredProcedure [dbo].[get_masteries_to_masteries]    Script Date: 05/30/2012 19:37:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[get_masteries_to_masteries]
AS
	Select * from Mastery_to_Mastery
GO
/****** Object:  StoredProcedure [dbo].[get_masteries]    Script Date: 05/30/2012 19:37:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[get_masteries]
AS
	Select * from Masteries
GO
