# Concert Tracker (Blazor Hybrid + .NET MAUI)

A **Blazor Hybrid** application built with **Blazor and .NET MAUI** that helps you track concerts you’ve **coming up** and concerts you’ve **attended**. You can:

- Add concerts with details (artist, venue, city, date, etc.)
- Use a **public API city autocomplete** while typing
- Rate concerts you’ve attended
- Save all data to a **database** (linked to the app)

---

## Features

### ✅ Add Concerts
- Enter concert details using the input form.
- Press **Add Concert** to store it in the database.

### ✅ Auto-Classify Concerts
- If the concert date is **in the future**, it is added to **Upcoming**.
  - You **cannot** rate it yet.
- If the concert date is **in the past**, it is added to **Attended** (or appears as past events on Home).
  - You **can** rate it.

### ✅ Rate Concerts
- Attended concerts are rateable.
- Past events appear on the **Home** page and can be rated from there.

### ✅ City Autocomplete
- While typing a city, the app uses a **public API** to suggest matching city names.

---

## Pages / Navigation

The app contains **3 pages**:

1. **Home / Landing Page**
   - Shows concerts that have passed and are available to rate.

2. **Add Concert Page**
   - Displays an input box guide describing what to enter in each field.
   - Includes **Add Concert** button to save the event.
   - City field includes autocomplete suggestions.

3. **Concert List Pages**
   - **Upcoming**: concerts scheduled for the future (rating disabled).
   - **Attended**: concerts you’ve been to (rating enabled).

---

## Tech Stack

- **Blazor**
- **.NET MAUI** (Blazor Hybrid)
- **Database** (linked for persistence)
- **Public City Autocomplete API**

---

## Getting Started

### Prerequisites
- Visual Studio (with the required .NET + MAUI workloads installed)
- .NET SDK compatible with the project
- Database/API configuration as required by the project

### Run the Application
1. Clone the repository.
2. Open the solution in **Visual Studio**.
3. Press **Run**.

---

## How It Works (Logic Overview)

When you add a concert:

1. The app checks the concert date.
2. It decides where the concert should be stored:
   - **Future date** → saved to **Upcoming**
   - **Past date** → saved to **Attended / Past**
3. Rating rules are applied automatically:
   - **Upcoming** concerts cannot be rated
   - **Attended / Past** concerts can be rated
4. The concert (and rating, if applicable) is stored in the **database**.

