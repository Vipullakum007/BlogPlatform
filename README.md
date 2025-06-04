# 📝 BloggingPlatform

**BloggingPlatform** is a web application built with ASP.NET Core that allows users to create, manage, and view blogs. It supports user authentication, author profiles, and blog categorization, making it easy for authors to manage their blogs and for readers to filter content by categories.There is an Admin Dashboard also to manage all Reported Blogs.

## Demo Video

Drive link : https://drive.google.com/file/d/1FM5k1FwzIvDzNcXtEfs6gxhRStftfOWx/view?usp=drive_link

https://github.com/user-attachments/assets/32deee6c-60b3-44cc-98bc-466d3a9ff119

## Screenshots

### Login Page

![Login Page](/BloggingPlatform/wwwroot/ScreenShots/Login.png)

### SignUp Page

![Sign Up Page](/BloggingPlatform/wwwroot/ScreenShots/SIgnup.png)

### Validation 

![Validation Page](/BloggingPlatform/wwwroot/ScreenShots/ValidationLogin.png)

### Home Page

![Home Page](/BloggingPlatform/wwwroot/ScreenShots/Home.png)

### FilterByCategory

![Filter By Category](/BloggingPlatform/wwwroot/ScreenShots/SortByCategory.png)

![Filter By Category](/BloggingPlatform/wwwroot/ScreenShots/SortByCategory2.png)

#### After Filter

![After Filter](/BloggingPlatform/wwwroot/ScreenShots/AfterFilter.png)

### Create Blog Page

![Create Blog Page](/BloggingPlatform/wwwroot/ScreenShots/CreateBlog.png)

### My Blog Page

![My Blog Page](/BloggingPlatform/wwwroot/ScreenShots/MyBlogs.png)

### Liked Blog Page

![Liked Blog Page](/BloggingPlatform/wwwroot/ScreenShots/LikedBlogs.png)



## 📑 Features

- 🖊️ **Blog Management**: Create, edit, and delete blogs.
- 👤 **User Authentication**: Secure login for authors.
- 📜 **Profile Management**: View and edit author profiles.
- 🏷️ **Category Filtering**: Filter blogs by categories.
- 💬 **Comments System**: Readers can comment on blog posts (Future feature).
- 👍**Like System**: Users can like Blogs
- **Reporting Functionality** : User can report blog with an Reason
- ⚙️ **Admin Dashboard**: Admin can manages the reported blogs

## 🛠️ Tech Stack

- **Backend**: ASP.NET Core MVC
- **Frontend**: Razor Pages, HTML5, CSS3, Bootstrap
- **Database**: SQL Server (Entity Framework Core)
- **Session Management**: ASP.NET Core Session
- **Version Control**: Git

## 🚀 Getting Started

### Prerequisites

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

### Installation

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/yourusername/BloggingPlatform.git
   ```
2. **Navigate to the project directory**:
   ```bash
   cd BloggingPlatform
   ```
3. **Configure the Database**:
   - Update the `appsettings.json` file with your SQL Server connection string:
     ```json
     "ConnectionStrings": {
       "DefaultConnection": "Server=your_server;Database=BloggingPlatformDb;Trusted_Connection=True;"
     }
     ```

4. **Run Entity Framework Migrations**:
   ```bash
   dotnet ef database update
   ```

5. **Run the Application**:
   ```bash
   dotnet run
   ```

6. **Visit the Application**:
   Open your browser and navigate to `http://localhost:{port}`.

## 🧑‍💻 Usage

### User Authentication

- Authors need to log in to create and manage their blogs.
- Use the **Sign Up** or **Login** option to access your profile.

### Blog Creation

1. Navigate to the **Create Blog** page from the dashboard.
2. Fill in the blog title, content, and select the appropriate category.
3. Submit the blog and it will appear on the homepage.

### Profile Management

- Users can edit their profile by clicking the **Profile** link in the navigation bar.
- All profile fields except for `Role` and `CreatedAt` are editable.

### Filtering Blogs by Category

- Use the dropdown menu in the blog listing to filter blogs by specific categories.
- You can select multiple categories and click **Apply Filters**.

## 🗂️ Project Structure

```plaintext
BloggingPlatform/
│
├── Controllers/
│   └── BlogController.cs
│   └── AuthorController.cs
│
├── Models/
│   └── Entity/
│       └── Blog.cs
│       └── Author.cs
│       └── Category.cs
│
├── Views/
│   └── Blog/
│   └── Author/
│
├── Migrations/
│
├── wwwroot/
│   └── css/
│   └── js/
│
├── appsettings.json
├── Startup.cs
└── Program.cs
```

## ✨ Future Features

- 🔔 **Notifications**: Notify users when new blogs are posted in their preferred categories.
- 📊 **Blog Analytics**: Provide analytics for authors to track the performance of their posts.

## 🤝 Contributing

Contributions are welcome! Please fork this repository and submit a pull request.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/YourFeature`)
3. Commit your Changes (`git commit -m 'Add some feature'`)
4. Push to the Branch (`git push origin feature/YourFeature`)
5. Open a Pull Request

---

### 👨‍💻 Author

- **Vipul Lakum** - [Vipul Lakum's Github Profile](https://github.com/Vipullakum007)
- **Archan Sureja** - [ArchanSureja](https://github.com/ArchanSureja)
