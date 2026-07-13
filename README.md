# Cyber Security Practical — Final Year Project

A Windows desktop application built in C# (.NET Framework, WinForms) as my Final Year Project for the Diploma in Information Technology Infrastructure Cyber Security (ITCSI) at the New Era Institute of Vocational and Continuing Education (NEIVCE), Malaysia.

## Background

Software development requires balancing performance, security, and reliability — which takes significant time to review, test, and debug. This project explores that process hands-on by building a security-focused desktop tool from the ground up: designing the architecture, implementing the features, and testing the final product.

## Purpose

The goal of this project is to help users understand and experience computer security concepts in a practical way. Rather than just explaining network security theory, the app pairs educational content (network threats, why computer security matters, etc.) with small, functional security tools the user can actually try — such as checking computer performance, scanning file hashes, and hiding their IP address.

**Development goals:**
- Optimize performance and reliability, even with larger data volumes
- Provide a clean, simple user interface and experience
- Build out proper testing to ensure software quality

## What it does

- **User accounts** – Login and registration system backed by a MySQL database.
- **Computer performance monitoring** – View real-time system performance and resource usage.
- **File scanning (MD5Scanner)** – Computes the MD5 hash of a selected file, useful for verifying file integrity or checking for known malicious files.
- **VirusTotal integration** – Uses an embedded browser (Microsoft WebView2) to check scanned files/URLs against VirusTotal (available in Simple and Advanced scan modes).
- **VPN / Free VPN** – Lets the user connect to a VPN and hide their IP address directly from the app.
- **Knowledge base** – In-app educational content covering cyber security concepts.
- **Contact & Help pages** – In-app support and guidance for users.
- **Software update & logout** – Basic app maintenance and session handling.

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

This project was built as part of my Diploma in ITCSI (Information Technology Infrastructure Cyber Security) at NEIVCE, Malaysia. It's shared here for portfolio purposes. The full FYP report (background, methodology, flowcharts, testing plan, and full source code listing) was submitted separately as part of the academic requirements.
