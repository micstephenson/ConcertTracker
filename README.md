# 🎵 Concert Tracker

A cross-platform concert tracking application built with **Blazor Hybrid and .NET MAUI**.

Concert Tracker allows users to keep track of concerts they are planning to attend and concerts they have already attended. Users can add concert information, view upcoming and attended concerts, and rate concerts after attending them.

---

## ✨ Features

### 🎤 Add Concerts

Users can add concerts with information including:

- Artist
- Venue
- City
- Date
- Other relevant concert details

Concert information is saved to the application's database.

---

### 📅 Automatically Categorise Concerts

Concerts are automatically categorised based on their date.

- **Future concerts** → Upcoming
- **Past concerts** → Attended

This means users do not need to manually move concerts between lists.

---

### ⭐ Rate Attended Concerts

Concerts that have already taken place can be rated.

Upcoming concerts cannot be rated until their date has passed.

This allows users to keep a record of their experiences at concerts.

---

### 📍 City Autocomplete

The city field uses a public API to provide city suggestions while the user is typing.

This makes entering concert locations quicker and helps avoid inconsistent city names.

---

### 🏠 Home Page

The home page displays concerts that have already taken place and are available to be rated.

---

### 🎟️ Upcoming Concerts

The Upcoming page displays concerts that are scheduled for the future.

These concerts cannot be rated until they have taken place.

---

### 🎶 Attended Concerts

The Attended page displays concerts that have already taken place.

Users can rate these concerts and keep track of their previous concert experiences.

---

## 🧭 Application Structure

The application contains three main areas:

### Home / Landing Page

Displays past concerts that are available to rate.

### Add Concert

Allows users to enter information about a new concert.

The city field provides autocomplete suggestions using a public API.

### Concert Lists

The application separates concerts into:

- Upcoming
- Attended

Concerts are automatically placed into the appropriate category based on their date.

---

## 🛠️ Technologies Used

### Frontend

- **Blazor**
- **Blazor Hybrid**
- **Blazorise**
- **Bootstrap 5**
- **Font Awesome**

### Application Framework

- **.NET 9**
- **.NET MAUI**
- **C#**

### Database

- **Entity Framework Core**
- **Microsoft SQL Server**

### APIs

- Public city autocomplete API

### Development Tools

- Visual Studio
- Visual Studio Code
- .NET CLI
- Git / GitHub

---

## 🏗️ Architecture

Concert Tracker is built using the **Blazor Hybrid** approach.

Instead of running purely as a web application, Blazor components are hosted inside a native .NET MAUI application using the MAUI Blazor WebView.

This allows the application to combine:

- Web-based UI development with Blazor
- C# application logic
- Native cross-platform application capabilities through .NET MAUI

The project uses a single MAUI project to target multiple platforms.

---

## 📱 Supported Platforms

The project currently targets:

- Android
- iOS
- macOS through Mac Catalyst

The project is configured for:

```text
net9.0-android
net9.0-ios
net9.0-maccatalyst
```

Windows support is also configured when building on Windows.

---

## 🚀 Getting Started

### Prerequisites

Before running the application, install:

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- .NET MAUI workload
- Visual Studio or Visual Studio Code
- Xcode if running the application on macOS/iOS
- Android SDK and emulator if running on Android

---

## 📥 Clone the Repository

Clone the repository using Git:

```bash
git clone https://github.com/micstephenson/ConcertTracker.git
```

Then navigate into the project:

```bash
cd ConcertTracker
```

---

## 📦 Restore Dependencies

Restore the required .NET packages:

```bash
dotnet restore
```

---

## 🔨 Build the Application

Build the project with:

```bash
dotnet build
```

---

## 🍎 Run on macOS

The application can be run using the Mac Catalyst target.

```bash
dotnet build -t:Run -f net9.0-maccatalyst
```

This builds and launches the application as a Mac Catalyst application.

---

## 🤖 Run on Android

To build for Android:

```bash
dotnet build -f net9.0-android
```

To run the application on an Android emulator or connected device, make sure an Android emulator/device is configured and available.

You can then use the appropriate MAUI/Android run configuration through Visual Studio or your development environment.

---

## 🍎 Run on iOS

The application targets iOS using:

```text
net9.0-ios
```

An appropriate Xcode installation and iOS simulator/device configuration is required.

The application can be launched through Visual Studio or the appropriate .NET MAUI tooling.

---

## 🗄️ Database

Concert Tracker uses **Entity Framework Core** for database access.

The project includes SQL Server support and uses Entity Framework Core to manage and persist concert data.

The project also contains:

```text
ConcertsQuery1.sql
```

which contains SQL queries relating to the concert data.

> Database configuration may need to be updated depending on the environment in which the application is being run.

---

## 🔄 How Concert Classification Works

When a user adds a concert, the application checks the concert date.

```text
                 Add Concert
                     │
                     ▼
              Check Concert Date
                     │
          ┌──────────┴──────────┐
          │                     │
       Future                 Past
          │                     │
          ▼                     ▼
      Upcoming              Attended
          │                     │
       Cannot                  Can
       rate yet                rate
```

This means the application automatically determines whether a concert should appear in the Upcoming or Attended section.

---

## ⭐ Rating Logic

Ratings are only available for concerts that have already taken place.

### Upcoming

```text
Future date
    ↓
Upcoming
    ↓
Rating disabled
```

### Attended

```text
Past date
    ↓
Attended
    ↓
Rating enabled
```

---

## 📂 Project Structure

The project is organised into several areas:

```text
ConcertTracker/
│
├── Components/
│   ├── Layout/
│   ├── Pages/
│   └── ...
│
├── Data/
│
├── DataTransferObjects/
│
├── Interfaces/
│
├── Mappers/
│
├── Resources/
│   ├── AppIcon/
│   ├── Fonts/
│   ├── Images/
│   └── Splash/
│
├── App.xaml
├── App.xaml.cs
├── MainPage.xaml
├── MainPage.xaml.cs
├── MauiProgram.cs
│
├── ConcertTrackerBlazorHybridApp.csproj
├── ConcertTrackerBlazorHybridApp.slnx
│
└── ConcertsQuery1.sql
```

---

## 🎨 UI & Components

The application uses **Blazorise** alongside **Bootstrap 5** to create and structure the user interface.

Font Awesome icons are also used throughout the application.

The application combines reusable Blazor components with .NET MAUI's native application structure.

---

## 🧠 What I Learned

This project gave me experience working with:

- C#
- .NET
- .NET MAUI
- Blazor
- Blazor Hybrid
- Entity Framework Core
- SQL Server
- APIs
- Database persistence
- Cross-platform application development
- Reusable components
- UI design
- Application navigation
- Data validation
- Conditional application logic

It also gave me experience connecting frontend components to backend data and implementing application logic based on real-world data.

---

## 🔮 Future Improvements

Potential future improvements include:

- User accounts and authentication
- Cloud-based database hosting
- Concert search functionality
- Integration with music/event APIs
- Artist profiles
- Venue profiles
- Concert recommendations
- More detailed rating categories
- Photos and memories for attended concerts
- Calendar integration
- Notifications for upcoming concerts
- Improved filtering and sorting

---

## 👩🏾‍💻 Author

**Michaylia Stephenson**

Software Engineering student and developer interested in building creative, practical applications.

### GitHub

https://github.com/micstephenson

---

## 📄 License

This project was created as a personal software development project.
