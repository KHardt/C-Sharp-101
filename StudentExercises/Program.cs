using System;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Exercise SmashFace = new Exercise()
            {
                Name = "Smash my face",
                Language = "Python",
            };

             Exercise PunchFace = new Exercise()
            {
                Name = "Punch my face",
                Language = "C#",
            };

             Exercise GutPunch = new Exercise()
            {
                Name = "Punch in gut",
                Language = "ISODUM",
            };

             Exercise EsteemKill = new Exercise()
            {
                Name = "Good Luck",
                Language = "CVerySharp",
            };

            
             Cohort Cohort45 = new Cohort()
            {
                Name = "Cohort 45",
            };

              Cohort Cohort46 = new Cohort()
            {
                Name = "Cohort 46",
            };

              Cohort Cohort47 = new Cohort()
            {
                Name = "Cohort 47",
            };

            Student Klaus  = new Student()
            {
                firstName = "Klaus",
                lastName = "Hardt",
                SlackHandle = "ookie",
                StudentCohort = Cohort45
            };

             Student Matt  = new Student()
            {
                firstName = "Matt",
                lastName = "Harding",
                SlackHandle = "dook",
                StudentCohort = Cohort46
            };

            Student Ricky  = new Student()
            {
                firstName = "Ricky",
                lastName = "Burden",
                SlackHandle = "dooker",
                StudentCohort = Cohort47
            };
            Student Fig  = new Student()
            {
                firstName = "Fig",
                lastName = "Newton",
                SlackHandle = "mook",
                StudentCohort = Cohort46
            };

            Instructor DrDoom = new Instructor()
            {
                firstName = "Dr",
                lastName = "Doom",
                SlackHandle = "Doomy",
                InstructorCohort = Cohort45
            };

            Instructor DrDespair = new Instructor()
            {
                firstName = "D",
                lastName = "Despair",
                SlackHandle = "Despairy",
                InstructorCohort = Cohort46
            };

            Instructor DrHappy = new Instructor()
            {
                firstName = "Really",
                lastName = "Happy",
                SlackHandle = "HappyFace",
                InstructorCohort = Cohort47
            };

            DrDoom.AssignExercise(SmashFace, Klaus);
            DrDoom.AssignExercise(PunchFace, Klaus);
            DrDespair.AssignExercise(SmashFace, Fig);
            Klaus.ExerciseList.ForEach(emp => Console.WriteLine(emp.Name));
            //drives me nuts there's not more req to console log to verify
            DrDespair.AssignExercise(PunchFace, Fig);
            DrHappy.AssignExercise(SmashFace, Ricky);
            DrHappy.AssignExercise(EsteemKill, Ricky);

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