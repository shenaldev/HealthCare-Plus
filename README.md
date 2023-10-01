# HealthCare Plus

Healthcare Plus is a user-friendly Hospital Management System using Windows Forms in conjunction with C# for the application logic and Microsoft SQL Server as the database backend. This comprehensive system streamlines various healthcare processes, making it an invaluable tool for hospital administration and healthcare providers. With this application, hospital staff can efficiently manage patient records, including personal details, and appointments, facilitating quicker and more accurate patient care. The system also offers a scheduling module that simplifies the process of booking patient appointments and tracking physician availability.

## Project Setup Guide

Follow these steps to set up the Healthcare Plus project on your local development environment.

### Step 1: Clone the Repository

1. Open Microsoft Visual Studio 2022.
2. Click on "File" in the menu bar and select "Open" > "Project/Solution..."
3. In the "Open Project" dialog, navigate to the directory where you want to clone the repository.
4. Paste the repository URL into the "File name" field or click on "Browse" to find the repository.
5. Click "Open" to clone the repository to your local machine.

### Step 2: Create the Database

1. Open Microsoft SQL Server Management Studio.
2. Connect to your SQL Server instance.
3. In the Object Explorer, right-click on "Databases" and select "New Database..."
4. Name the database "Healthcareplus" and configure any additional settings as needed.
5. Click "OK" to create the database.

### Step 3: Execute SQL Script

1. In SQL Server Management Studio, ensure you are connected to the "Healthcareplus" database.
2. Open the "Create-Tables_SQL.sql" script from the cloned repository in Visual Studio or your preferred code editor.
3. Execute the SQL script by selecting all the SQL commands and clicking "Execute" or pressing `F5`. This will create the necessary tables and schema in the "Healthcareplus" database.

### Step 4: Connect Database in Visual Studio

1. Open your project in Microsoft Visual Studio.
2. Locate the connection string in your project configuration or settings.
3. Update the connection string to point to your "Healthcareplus" database in SQL Server.
   Example Connection String:
   ```csharp
   "Server=YourServerName;Database=Healthcareplus;User Id=YourUsername;Password=YourPassword;"

Please make sure to replace `"YourServerName"`, `"YourUsername"`, and `"YourPassword"` in the connection string with the actual SQL Server instance details you're using.

### Default Admin Logins
`email: admin@healthcareplus.com
password: j@lmd45!k`

---

## System Demo

![Login Page](https://i.imgur.com/TgHIJH2.png)

#### Admin Dashboard

![Screenshot 1](https://i.imgur.com/uJMJ0on.png)

![Screenshot 2](https://i.imgur.com/lxiXsn6.png)

![Screenshot 3](https://i.imgur.com/fvMEBYO.png)

#### Staff Dashboard

![Imgur](https://i.imgur.com/OwGTsM7.png)

![Imgur](https://i.imgur.com/D6RJNxl.png)

![Imgur](https://i.imgur.com/NLWz7Nb.png)

![Imgur](https://i.imgur.com/WTpglVE.png)

![Imgur](https://i.imgur.com/7BcaraH.png)

## License

This project is released under the [MIT License](LICENSE), with the following clarification:

**Non-Commercial Use Only:** This software is provided for non-commercial purposes. You are free to use, modify, and distribute the software as long as it is not used for commercial activities. For commercial use or licensing inquiries, please contact the project maintainers.
