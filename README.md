StudyTracker 📚

A simple C# Windows Forms application designed to track and log your study hours. 
This tool helps you manage study sessions, stay focused, and maintain a history of your academic progress.

✨ Features
- Customizable Timer: Set study sessions using hours, minutes, and seconds.
- Subject Tracking: Tag your sessions with specific subjects or task names.
- Session Controls: Easily Start, Stop, and Reset the timer.
- Automatic Logging: Saves your session data to a local text file.
- History View: Access the "Status" tab to review all past study sessions.

🚀 Usage
- Setup: Open the application and enter the subject or task you are studying.
- Set Timer: Enter your desired study duration (Hours/Minutes/Seconds).
- Start: Click Start Timer to begin your session.
- Notification: The app will notify you once the session is complete.
- Control: You can use Stop Timer at any time if you need a break.
- Save Progress: Once you're finished, go to the Timer Menu and select Save Progress to log your time.
- Review: Switch to the Status tab to view your saved session history.

🛠 Technical Notes
- Data Storage: The application saves logs to a static file path. You can customize the storage location directly in the source code:
```csharp
// Example path modification
string filePath = @"C:\YourDirectory\StudyLogs.txt";```

⚠️ Disclaimer
This is an educational project. It is intended for learning purposes and is not designed for full-scale production or critical time-tracking reliability.
Features and data handling are simplified for educational clarity.
