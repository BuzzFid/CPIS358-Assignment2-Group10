# FCIT Event Finder

This is a project I made for the CPIS358 course (Internet Applications and Web Programming) at FCIT, KAU.

The idea is simple: FCIT students post their events (workshops, competitions, club activities) and other students can come here and see them instead of searching randomly on WhatsApp or Twitter/X.

## What it does

- Shows a list of all events
- You can click an event to see more details about it
- If you're logged in, you can add, edit, or delete events
- You can search for an event by name, organizer, or location
- You can register/login (using ASP.NET Identity)
- There's a contact page if someone wants to reach out

## Built with

- ASP.NET Core MVC (.NET 10)
- Entity Framework Core (Code First + Migrations)
- SQL Server
- Bootstrap + jQuery for the frontend
- ASP.NET Identity for login/register

## Folder structure

Controllers/ -> Home, Account, Events controllers
Models/ -> Event model
Views/ -> the Razor pages (html basically)
Data/ -> DbContext + migrations
wwwroot/ -> css, js, images, bootstrap files

## How to run it

1. Clone the project
2. Open it in Visual Studio (or VS Code)
3. Check appsettings.json and make sure the connection string matches your SQL Server / LocalDB
4. Run this to create the database: dotnet ef database update
5. Then just run the project: dotnet run
6. Open the link it gives you in the browser

## Notes

- Create / Edit / Delete only works if you're logged in
- Made this with my group for a college assignment, not a real production app

## Team

Group 10 - CPIS358

## Contact

aalsebaee0002@stu.kau.edu.sa
