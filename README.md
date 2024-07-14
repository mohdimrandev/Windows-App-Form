# Windows Form Application

This application facilitates the management of form submissions and entries, offering a comprehensive suite of features. Users can handle submissions efficiently through functionalities that allow for creating new entries, viewing existing submissions, editing and deleting submissions, searching submissions by email, and utilizing keyboard shortcuts for streamlined operations.

## Table of Contents

- [Introduction](#introduction)
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Setup](#setup)
- [Prerequisite](#prerequisite)
- [Run the Application](#run-the-application)
- [Usage](#usage)
- [Keyboard Shortcuts](#keyboard-shortcuts)
- [Video](#video)

## Introduction

The Windows Form Application is designed to streamline the process of viewing and creating form submissions through an intuitive user interface. It enables users to efficiently navigate through existing submissions, edit and delete entries, search submissions by email, and create new submissions. Additionally, the application incorporates advanced features such as a stopwatch for precise time measurement during form filling.

## Features

### Main Form

- Click on `View Submissions` to load View Submissions Form.
- Click on `Create New Submission` to open the Create Submission Form.

### View Submissions

- View the following input fields created by the `Create New Submission` form for each submission:
  - Name
  - Email
  - Phone Number
  - GitHub repository link
  - Stopwatch Time
- Navigate through submissions using `Previous` and `Next` buttons.
- Search submissions by email.
- Edit existing submissions.
- Delete submissions.

### Create New Submission

- Input fields for Name, Email, Phone Number, and GitHub repository link.
- Stopwatch feature to measure time, with pause and resume functionality.
- Submit new entries to the backend.

## Technologies Used

### Languages:

![Visual Basic](https://img.shields.io/badge/visual_basic-004e8c?style=for-the-badge&logo=visualbasic)

### Tools:

![Visual Studio](https://img.shields.io/badge/visual%20studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white) 

## Prerequisite

### Before running this project locally, make sure you have:

- Visual Studio Community Edition: Download from [https://visualstudio.microsoft.com/](https://visualstudio.microsoft.com/). 

Note: During installation, ensure you select the `.NET desktop environment` to support development for Windows desktop applications.

## Setup

### 1. Clone the repository

- Clone the repository using the following command:
  ```cmd
  git clone https://github.com/mohdimrandev/Windows-Form-App.git
  ```

### 2. Navigate to the project directory

- Change to the project directory using the following command:

  ```cmd
  cd Windows-Form-App
  ```

### 3. Open in Visual Studio

- Open `Windows App Form.sln` using Visual Studio.
- Navigate to Solution Explorer and open `Form1.vb`, `ViewSubmissionsForm.vb`, and `CreateSubmissionForm.vb` to open their respective design tabs.
- Right-click on `Form1.vb`, `ViewSubmissionsForm.vb`, and `CreateSubmissionForm.vb` in Solution Explorer and select "View Code" to open their respective code-behind files.

### 4. Install Newtonsoft.Json

- Right-click on the project in Solution Explorer > "Manage NuGet Packages..."
- Search for `Newtonsoft.Json` and install the latest version.

### 5. Install Backend Dependencies

- Start the backend server by following instructions in [backend repository's](https://github.com/mohdimrandev/express-server) README.md to clone the backend repository, install dependencies, and start the server.
- Install Dependencies and Start the Server:
  ```cmd
  npm install
  npm start
  ```
  This command will start the backend server, which will listen for requests on `http://localhost:3000`.
- Ensure you have started the backend server.

## Run the Application

- Build and run the application from Visual Studio.

## Usage

### Main Form

- Click on "View Submissions" to load existing submissions (Use `Ctrl + V`).
- Click on "Create New Submission" to open the submission form (Use `Ctrl + N`).

### View Submissions:

- View the data submitted through the Create New Submission form.
- Navigate through submissions using "Previous" and "Next" buttons.
- Use `Ctrl + P` to navigate to the previous entry.
- Use `Ctrl + N` to navigate to the next entry.
- Search submissions by email (Use `Ctrl + F`).
- Edit existing submissions (Use `Ctrl + E`).
- Delete submissions (Use `Ctrl + D`).
- Use `Ctrl + S` to save a submission (after editing).

#### Create New Submission:

- Fill in the required fields (Name, Email, Phone, GitHub link).
- Use `Ctrl + S` to submit the form.
- Use `Ctrl + T` to toggle the stopwatch.

## Keyboard Shortcuts

### Global Shortcuts:

- `Ctrl + V`: View Submissions
- `Ctrl + N`: Create New Submission
- `Ctrl + P`: Previous Entry
- `Ctrl + N`: Next Entry
- `Ctrl + F`: Search by Email
- `Ctrl + E`: Edit Submission
- `Ctrl + S`: Save Submission (after editing)

## Video

[Demo Video](https://youtu.be/hZbGzhk-1Co)
