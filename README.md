# FYP Diploma Project

A Windows desktop security utility built in C# (.NET Framework, WinForms) as my Final Year Project (FYP) for my diploma.

## What it does

The application is an all-in-one system security and monitoring tool with the following features:

- **User accounts** – Login and registration system backed by a MySQL database.
- **File scanning (MD5Scanner)** – Computes the MD5 hash of a selected file, useful for verifying file integrity or checking for known malicious files.
- **VirusTotal integration** – Uses an embedded browser (Microsoft WebView2) to check scanned files against VirusTotal.
- **VPN / Free VPN** – Lets the user connect to a VPN directly from the app.
- **System performance & usage monitoring** – Displays system performance and resource usage stats.
- **Knowledge base & Help** – In-app knowledge/help sections for user guidance.
- **Contact page** – Basic contact information screen.

## Tech stack

- **Language:** C#
- **Framework:** .NET Framework 4.8, Windows Forms
- **UI library:** ComponentFactory Krypton Toolkit, MetroModernUI
- **Database:** MySQL (via `MySql.Data`)
- **Browser engine:** Microsoft Edge WebView2 (for VirusTotal integration)
- **Other libraries:** BouncyCastle (cryptography), Google.Protobuf

## Getting started

1. Open `Final.sln` in Visual Studio (2019 or later recommended).
2. Restore NuGet packages (Visual Studio should do this automatically on build).
3. Set up a local MySQL database named `myweb` and update the connection string in `Final/SQL_Database.cs` with your own credentials.
4. Build and run the project (`Program.cs` is the entry point, starting from `Form1`).

## Note

This project was built as part of an academic diploma program. It's shared here for portfolio purposes.
