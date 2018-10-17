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

        

        
    }
}