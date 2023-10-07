USE [CV]
GO
/****** Object:  Table [dbo].[Candidate]    Script Date: 10/5/2023 10:42:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Candidate](
	[CVNo] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](250) NOT NULL,
	[EmailAddress] [nvarchar](50) NOT NULL,
	[WorkExperienceYear] [int] NULL,
	[ExpectedSalary] [int] NULL,
 CONSTRAINT [PK_Candidate] PRIMARY KEY CLUSTERED 
(
	[CVNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CandidateSkill]    Script Date: 10/5/2023 10:42:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CandidateSkill](
	[CVNo] [int] NOT NULL,
	[SkillNo] [int] NOT NULL,
 CONSTRAINT [PK_CandidateSkill_1] PRIMARY KEY CLUSTERED 
(
	[CVNo] ASC,
	[SkillNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job]    Script Date: 10/5/2023 10:42:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job](
	[JobId] [int] NOT NULL,
	[JobTitle] [nvarchar](250) NOT NULL,
	[JobDescription] [nvarchar](max) NOT NULL,
	[RequiredSkillId] [int] NOT NULL,
	[RequiredExperience] [int] NULL,
	[RequiredMaxSalary] [int] NULL,
 CONSTRAINT [PK_Job] PRIMARY KEY CLUSTERED 
(
	[JobId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Skill]    Script Date: 10/5/2023 10:42:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Skill](
	[SkillNo] [int] IDENTITY(1,1) NOT NULL,
	[SkillName] [nvarchar](250) NULL,
 CONSTRAINT [PK_Skill] PRIMARY KEY CLUSTERED 
(
	[SkillNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Candidate] ON 

INSERT [dbo].[Candidate] ([CVNo], [FullName], [EmailAddress], [WorkExperienceYear], [ExpectedSalary]) VALUES (1, N'Nguyễn Văn A', N'a@gmail.com', 1, 4000)
INSERT [dbo].[Candidate] ([CVNo], [FullName], [EmailAddress], [WorkExperienceYear], [ExpectedSalary]) VALUES (2, N'Nguyễn Văn B', N'b@gmail.com', 2, 5000)
INSERT [dbo].[Candidate] ([CVNo], [FullName], [EmailAddress], [WorkExperienceYear], [ExpectedSalary]) VALUES (3, N'Nguyễn Văn C', N'c@gmail.com', 5, 8500)
INSERT [dbo].[Candidate] ([CVNo], [FullName], [EmailAddress], [WorkExperienceYear], [ExpectedSalary]) VALUES (4, N'Nguyễn Văn D', N'd@gmail.com', 4, 9000)
INSERT [dbo].[Candidate] ([CVNo], [FullName], [EmailAddress], [WorkExperienceYear], [ExpectedSalary]) VALUES (5, N'Nguyễn Văn E', N'e@gmail.com', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Candidate] OFF
GO
INSERT [dbo].[CandidateSkill] ([CVNo], [SkillNo]) VALUES (1, 1)
INSERT [dbo].[CandidateSkill] ([CVNo], [SkillNo]) VALUES (1, 3)
INSERT [dbo].[CandidateSkill] ([CVNo], [SkillNo]) VALUES (2, 1)
INSERT [dbo].[CandidateSkill] ([CVNo], [SkillNo]) VALUES (2, 2)
INSERT [dbo].[CandidateSkill] ([CVNo], [SkillNo]) VALUES (3, 4)
INSERT [dbo].[CandidateSkill] ([CVNo], [SkillNo]) VALUES (3, 5)
INSERT [dbo].[CandidateSkill] ([CVNo], [SkillNo]) VALUES (4, 2)
INSERT [dbo].[CandidateSkill] ([CVNo], [SkillNo]) VALUES (4, 3)
INSERT [dbo].[CandidateSkill] ([CVNo], [SkillNo]) VALUES (5, 2)
INSERT [dbo].[CandidateSkill] ([CVNo], [SkillNo]) VALUES (5, 4)
INSERT [dbo].[CandidateSkill] ([CVNo], [SkillNo]) VALUES (5, 5)
GO
INSERT [dbo].[Job] ([JobId], [JobTitle], [JobDescription], [RequiredSkillId], [RequiredExperience], [RequiredMaxSalary]) VALUES (1, N'Senior Full Stack Developer c#', N'Lập trình C#', 1, 1, 7000)
INSERT [dbo].[Job] ([JobId], [JobTitle], [JobDescription], [RequiredSkillId], [RequiredExperience], [RequiredMaxSalary]) VALUES (2, N'Chuyên viên lập trình Web (ReactJS, JavaScript, HTML, CSS)', N'11', 5, 2, 7000)
INSERT [dbo].[Job] ([JobId], [JobTitle], [JobDescription], [RequiredSkillId], [RequiredExperience], [RequiredMaxSalary]) VALUES (3, N'Fresher Backend Engineer (Java)', N'We are looking for experienced Senior Back-End Engineers (Java) to join our VinID product. This is a fantastic opportunity to work at a well-established and leading start-up in Vietnam as One Mount Group and you will be part of VinID - A digitalized ecosystem via a super App with diverse utilities from retails, E-commerce to Financial services serving people’s end-to-end needs in their daily activities.', 3, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Skill] ON 

INSERT [dbo].[Skill] ([SkillNo], [SkillName]) VALUES (1, N'C#')
INSERT [dbo].[Skill] ([SkillNo], [SkillName]) VALUES (2, N'Java')
INSERT [dbo].[Skill] ([SkillNo], [SkillName]) VALUES (3, N'Spring Boot (Java)')
INSERT [dbo].[Skill] ([SkillNo], [SkillName]) VALUES (4, N'Python')
INSERT [dbo].[Skill] ([SkillNo], [SkillName]) VALUES (5, N'HTML, CSS, Javascript')
SET IDENTITY_INSERT [dbo].[Skill] OFF
GO
ALTER TABLE [dbo].[CandidateSkill]  WITH CHECK ADD  CONSTRAINT [FK_CandidateSkill_Candidate] FOREIGN KEY([CVNo])
REFERENCES [dbo].[Candidate] ([CVNo])
GO
ALTER TABLE [dbo].[CandidateSkill] CHECK CONSTRAINT [FK_CandidateSkill_Candidate]
GO
ALTER TABLE [dbo].[CandidateSkill]  WITH CHECK ADD  CONSTRAINT [FK_CandidateSkill_Skill] FOREIGN KEY([SkillNo])
REFERENCES [dbo].[Skill] ([SkillNo])
GO
ALTER TABLE [dbo].[CandidateSkill] CHECK CONSTRAINT [FK_CandidateSkill_Skill]
GO
ALTER TABLE [dbo].[Job]  WITH CHECK ADD  CONSTRAINT [FK_Job_Skill] FOREIGN KEY([RequiredSkillId])
REFERENCES [dbo].[Skill] ([SkillNo])
GO
ALTER TABLE [dbo].[Job] CHECK CONSTRAINT [FK_Job_Skill]
GO