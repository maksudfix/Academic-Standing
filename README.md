# Student Academic Level Management System

A simple C# Console Application that manages student academic levels using an enum, classes, properties, constructors, lists, and iteration.

## Features

* Store multiple student records
* Assign academic levels using `AcademicStanding`
* Store student name and ID
* Display student information
* Use `List<Student>` to manage multiple students
* Use `foreach` to display all students
* Use console colors for presentation

## Code Structure
AcademicStanding
 ├── Freshman
 ├── Sophomore
 ├── Junior
 └── Senior

Student
 ├── Name
 ├── ID
 ├── Year
 ├── Student()
 └── DisplayInfo()

AcademicLevel
 └── Main()
      ├── Create Student List
      ├── Assign Academic Levels
      └── Display Student Information

## Concepts Used

* Enum — `AcademicStanding` represents the student's academic level.
* Class & Objects — `Student` represents individual student records.
* Properties — Stores `Name`, `ID`, and `Year`.
* Constructor — Initializes student information.
* List<T> — Stores multiple students.
* foreach — Iterates through the student list.
* Console Colors — Improves console presentation.

## Sample Output
---Student Information---

Student Name: Maksud
Student ID: 22103265
Academic Level: Senior

---Student Information---

Student Name: Abdullah
Student ID: 23103265
Academic Level: Junior

## Technologies

*C# • .NET Console Application • Classes • Objects • Enum • List<T> • Constructors • Properties • foreach • Console Colors*
