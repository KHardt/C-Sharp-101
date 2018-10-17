using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Sqlite;
using System.Collections;
using Dapper;
//using DapperDepartments.Models;

namespace StudentExercises
{
    public class DatabaseInterface
    {
        public static SqliteConnection Connection
        {
            get
            {
                string _connectionString = $"Data Source=./StudentExercises.db";
                return new SqliteConnection(_connectionString);
            }
        }


        public static void CheckExerciseTable()
        {
            SqliteConnection db = DatabaseInterface.Connection;

            try
            {
                List<Exercise> exercisesList = db.Query<Exercise>
                    ("SELECT Id FROM Exercise").ToList();
            }
            catch (System.Exception ex)
            {
                if (ex.Message.Contains("no such table"))
                {
                    db.Execute(@"CREATE TABLE `Exercise` (
                        `Id` INTEGER PRIMARY KEY AUTOINCREMENT,
                        `exerciseName` TEXT NOT NULL, `language` TEXT NOT NULL
                    )");

                    db.Execute(@"
                    INSERT INTO Exercise (exerciseName, language) VALUES ('smash my face', 'Python');
                    INSERT INTO Exercise (exerciseName, language) VALUES ('punch my face', 'C#');
                    INSERT INTO Exercise (exerciseName, language) VALUES ('punch in gut', 'ISODUM');
                    INSERT INTO Exercise (exerciseName, language) VALUES ('Good Luck', 'CVerySharp');
                    ");
                }
            }
        }

        public static void CheckInstructorsTable()
        {
            SqliteConnection db = DatabaseInterface.Connection;

            try
            {
                List<Instructor> instructorList = db.Query<Instructor>
                    ("SELECT Id FROM Instructor").ToList();
            }
            catch (System.Exception ex)
            {
                if (ex.Message.Contains("no such table"))
                {
                    db.Execute(@"CREATE TABLE `Instructor` (
                        `Id` INTEGER PRIMARY KEY AUTOINCREMENT,
                        `lastName` TEXT NOT NULL, `cohort` INT NOT NULL
                    )");

                    db.Execute(@"
                    INSERT INTO Instructor (lastName, ) VALUES ('smash my face', 'Python');
                    INSERT INTO Instructor (exerciseName, language) VALUES ('punch my face', 'C#');
                    INSERT INTO Instructor (exerciseName, language) VALUES ('punch in gut', 'ISODUM');
                    INSERT INTO Instructor (exerciseName, language) VALUES ('Good Luck', 'CVerySharp');
                    ");
                }
            }
        }

public static void CheckStudentTable()
        {
            SqliteConnection db = DatabaseInterface.Connection;

            try
            {
                List<Student> studentList = db.Query<Student>
                    ("SELECT Id FROM Student").ToList();
            }
            catch (System.Exception ex)
            {
                if (ex.Message.Contains("no such table"))
                {
                    db.Execute(@"CREATE TABLE `Student` (
                        `Id` INTEGER PRIMARY KEY AUTOINCREMENT,
                        `firstName` TEXT NOT NULL, `lastName` TEXT NOT NULL
                    )");

                    db.Execute(@"
                    INSERT INTO Exercise (exerciseName, language) VALUES ('smash my face', 'Python');
                    INSERT INTO Exercise (exerciseName, language) VALUES ('punch my face', 'C#');
                    INSERT INTO Exercise (exerciseName, language) VALUES ('punch in gut', 'ISODUM');
                    INSERT INTO Exercise (exerciseName, language) VALUES ('Good Luck', 'CVerySharp');
                    ");
                }
            }
        }


        public static void CheckStudentExercisesTable()
        {
            SqliteConnection db = DatabaseInterface.Connection;

            List<string> StudentExerciseList = db.Query<string>("Select Id from StudentExercises").ToList();
        }

        


        

        
    }
}