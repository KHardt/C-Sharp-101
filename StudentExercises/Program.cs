using System;
using System.Collections.Generic;

namespace StudentExercises {
    class Program {
        static void Main (string[] args) {

            Exercise SmashFace = new Exercise () {
                Name = "Smash my face",
                Language = "Python",
            };

            Exercise PunchFace = new Exercise () {
                Name = "Punch my face",
                Language = "C#",
            };

            Exercise GutPunch = new Exercise () {
                Name = "Punch in gut",
                Language = "ISODUM",
            };

            Exercise EsteemKill = new Exercise () {
                Name = "Good Luck",
                Language = "CVerySharp",
            };

            Cohort Cohort45 = new Cohort () {
                Name = "Cohort 45",
            };

            Cohort Cohort46 = new Cohort () {
                Name = "Cohort 46",
            };

            Cohort Cohort47 = new Cohort () {
                Name = "Cohort 47",
            };

            Student Klaus = new Student () {
                firstName = "Klaus",
                lastName = "Hardt",
                SlackHandle = "ookie",
                StudentCohort = Cohort45
            };

            Student Matt = new Student () {
                firstName = "Matt",
                lastName = "Harding",
                SlackHandle = "dook",
                StudentCohort = Cohort46
            };

            Student Ricky = new Student () {
                firstName = "Ricky",
                lastName = "Burden",
                SlackHandle = "dooker",
                StudentCohort = Cohort47
            };
            Student Fig = new Student () {
                firstName = "Fig",
                lastName = "Newton",
                SlackHandle = "mook",
                StudentCohort = Cohort46
            };

            Instructor DrDoom = new Instructor () {
                firstName = "Dr",
                lastName = "Doom",
                SlackHandle = "Doomy",
                InstructorCohort = Cohort45
            };

            Instructor DrDespair = new Instructor () {
                firstName = "D",
                lastName = "Despair",
                SlackHandle = "Despairy",
                InstructorCohort = Cohort46
            };

            Instructor DrHappy = new Instructor () {
                firstName = "Really",
                lastName = "Happy",
                SlackHandle = "HappyFace",
                InstructorCohort = Cohort47
            };

            DrDoom.AssignExercise (SmashFace, Klaus);
            DrDoom.AssignExercise (PunchFace, Klaus);
            DrDespair.AssignExercise (SmashFace, Fig);
            //Klaus.ExerciseList.ForEach(emp => Console.WriteLine(emp.Name));
            //drives me nuts there's not more req to console log to verify
            DrDespair.AssignExercise (PunchFace, Fig);
            DrHappy.AssignExercise (SmashFace, Ricky);
            DrHappy.AssignExercise (EsteemKill, Ricky);

            List<Student> students = new List<Student> ();
            students.Add (Klaus);
            students.Add (Ricky);
            students.Add (Fig);
            students.ForEach (pl2 => Console.WriteLine (pl2.ExerciseList));

            List<Exercise> exercises = new List<Exercise> ();
            exercises.Add (SmashFace);
            exercises.Add (PunchFace);
            exercises.Add (EsteemKill);
            exercises.Add (GutPunch);

//list within a list. Need to iterate over both- build up a string
            //students.AddRange (exercises);
/* 
            var i = 
            for (i = 0; i < 10; i++) {
                for (int j = i; j < 10; j++)
                    Console.WriteLine ("Value of i: {0}, J: {1} ", i, j);
            }
*/


        }
    }
}

/*
Create 4, or more, exercises.
Create 3, or more, cohorts.
Create 4, or more, students and assign them to one of the cohorts.
Create 3, or more, instructors and assign them to one of the cohorts.
Have each instructor assign 2 exercises to each of the students.

 */