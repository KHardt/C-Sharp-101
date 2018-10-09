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