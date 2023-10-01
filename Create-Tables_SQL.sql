USE [Healthcareplus]
GO

/****** Object:  Table [dbo].[Users]    Script Date: 10/1/2023 10:03:36 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[first_name] [varchar](150) NOT NULL,
	[last_name] [varchar](150) NOT NULL,
	[email] [varchar](150) NOT NULL,
	[password] [varchar](200) NOT NULL,
	[role] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [Unique_Email] UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_role]  DEFAULT ('patient') FOR [role]
GO

--INSERT ADMIN USER
INSERT INTO Users VALUES ('admin', 'system', 'admin@healthcareplus.com', '9F55A00DDFA94D7D27C80D9E56CBBD362AB8281C03E2ED5CD3B28AECAEAFCE00', 'admin');

USE [Healthcareplus]
GO

/****** Object:  Table [dbo].[StaffProfiles]    Script Date: 10/1/2023 10:06:07 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[StaffProfiles](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[contact_no] [varchar](12) NOT NULL,
	[address] [varchar](150) NOT NULL,
	[user_id] [bigint] NOT NULL,
 CONSTRAINT [PK_StaffProfile] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [CK_StaffProfile_ContactNo] UNIQUE NONCLUSTERED 
(
	[contact_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[StaffProfiles]  WITH CHECK ADD  CONSTRAINT [FK_StaffProfile_Users] FOREIGN KEY([user_id])
REFERENCES [dbo].[Users] ([id])
GO

ALTER TABLE [dbo].[StaffProfiles] CHECK CONSTRAINT [FK_StaffProfile_Users]
GO

USE [Healthcareplus]
GO

/****** Object:  Table [dbo].[Patients]    Script Date: 10/1/2023 10:06:29 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Patients](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[first_name] [varchar](150) NOT NULL,
	[last_name] [varchar](150) NOT NULL,
	[email] [varchar](150) NOT NULL,
	[contact_no] [varchar](12) NOT NULL,
	[address] [varchar](150) NOT NULL,
	[disease] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Patients] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [CK_Patients_ContactNo] UNIQUE NONCLUSTERED 
(
	[contact_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [Healthcareplus]
GO

/****** Object:  Table [dbo].[DoctorProfiles]    Script Date: 10/1/2023 10:06:38 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DoctorProfiles](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[qualification] [varchar](50) NOT NULL,
	[specialization] [varchar](100) NOT NULL,
	[contact_no] [varchar](12) NOT NULL,
	[location] [varchar](20) NOT NULL,
	[home_address] [varchar](150) NOT NULL,
	[hospital_address] [varchar](150) NOT NULL,
	[user_id] [bigint] NOT NULL,
 CONSTRAINT [PK_DoctorProfiles] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [CK_Contact_No] UNIQUE NONCLUSTERED 
(
	[contact_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[DoctorProfiles]  WITH CHECK ADD  CONSTRAINT [FK_DoctorProfiles_Users] FOREIGN KEY([user_id])
REFERENCES [dbo].[Users] ([id])
GO

ALTER TABLE [dbo].[DoctorProfiles] CHECK CONSTRAINT [FK_DoctorProfiles_Users]
GO

USE [Healthcareplus]
GO

/****** Object:  Table [dbo].[Schedules]    Script Date: 10/1/2023 10:06:53 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Schedules](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[doctor_id] [bigint] NOT NULL,
	[location] [varchar](50) NOT NULL,
	[room] [tinyint] NOT NULL,
	[start_date] [datetime] NOT NULL,
	[end_date] [datetime] NOT NULL,
	[updated_at] [timestamp] NULL,
 CONSTRAINT [PK_Schedules] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Schedules]  WITH CHECK ADD  CONSTRAINT [FK_Schedules_Users] FOREIGN KEY([doctor_id])
REFERENCES [dbo].[Users] ([id])
GO

ALTER TABLE [dbo].[Schedules] CHECK CONSTRAINT [FK_Schedules_Users]
GO

USE [Healthcareplus]
GO

/****** Object:  Table [dbo].[Appointments]    Script Date: 10/1/2023 10:07:18 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Appointments](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[appt_number] [int] NOT NULL,
	[payment_status] [varchar](10) NOT NULL,
	[schedule_id] [bigint] NOT NULL,
	[patient_id] [bigint] NOT NULL,
	[created_at] [datetime] NOT NULL,
 CONSTRAINT [PK_Appoinments] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Appointments] ADD  CONSTRAINT [DF_Appoinments_payment_status]  DEFAULT ('unpaid') FOR [payment_status]
GO

ALTER TABLE [dbo].[Appointments]  WITH CHECK ADD  CONSTRAINT [FK_Appoinments_Patients] FOREIGN KEY([patient_id])
REFERENCES [dbo].[Patients] ([id])
GO

ALTER TABLE [dbo].[Appointments] CHECK CONSTRAINT [FK_Appoinments_Patients]
GO

ALTER TABLE [dbo].[Appointments]  WITH CHECK ADD  CONSTRAINT [FK_Appoinments_Schedules] FOREIGN KEY([schedule_id])
REFERENCES [dbo].[Schedules] ([id])
GO

ALTER TABLE [dbo].[Appointments] CHECK CONSTRAINT [FK_Appoinments_Schedules]
GO

USE [Healthcareplus]
GO

/****** Object:  Table [dbo].[Appointment_Charges]    Script Date: 10/1/2023 10:07:37 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Appointment_Charges](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[title] [varchar](150) NOT NULL,
	[amount] [float] NOT NULL,
	[appointment_id] [bigint] NOT NULL,
 CONSTRAINT [PK_Appointment_Charges] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Appointment_Charges]  WITH CHECK ADD  CONSTRAINT [FK_Appointment_Charges_Appointments] FOREIGN KEY([appointment_id])
REFERENCES [dbo].[Appointments] ([id])
GO

ALTER TABLE [dbo].[Appointment_Charges] CHECK CONSTRAINT [FK_Appointment_Charges_Appointments]
GO

USE [Healthcareplus]
GO

/****** Object:  Table [dbo].[Payments]    Script Date: 10/1/2023 10:07:50 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Payments](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[payment_method] [varchar](50) NOT NULL,
	[total] [float] NOT NULL,
	[balance] [float] NULL,
	[status] [varchar](10) NOT NULL,
	[transaction_id] [varchar](150) NULL,
	[appointment_id] [bigint] NOT NULL,
	[created_at] [datetime] NOT NULL,
 CONSTRAINT [PK_Payments] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Payments]  WITH CHECK ADD  CONSTRAINT [FK_Payments_Appointments] FOREIGN KEY([appointment_id])
REFERENCES [dbo].[Appointments] ([id])
GO

ALTER TABLE [dbo].[Payments] CHECK CONSTRAINT [FK_Payments_Appointments]
GO

