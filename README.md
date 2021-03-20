# RT Class Feedback (Archived, Not Active)
A C# application for Students to anonymously communicate with an instructor their level of understanding and pose questions.

## Project changed
- Changed project design to a web app to increase flexibility and reduce footprint. Project had no plans to use mobile features and will now be built in HTML/JS with a C# backend. This repository will be maintained for reference only.

## Problem Statement
- Teaching in the virtual format sucks:
  - It is difficult to read your student’s body language to figure out if they understand the context
  - There is not a good method of polling for understanding
  - Some students do not ask questions because they are afraid of looking dumb

## Solution
A Xamarin (cross-platform .NET application) to allow for communicating with the class is real time.
- Student voting on understanding of material with visualization
- Messaging that allows for the instructor to highlight messages, fade out read messages, and students to anonymously submit messages
- (Future) Instructor’s tool to send multiple choice questions to the class and check responses to test understanding

## Design
- User Interface built in XAML (4 Pages)
  - Welcome
  - Room Creator Setup
  - User Setup
  - Class Room
- Backend code built in C#
  - Utilized for all event handling, establishment of object data types
- Rest Architecture for server-client synchronization
  - Post
  - Get
  - Put
  - Delete
