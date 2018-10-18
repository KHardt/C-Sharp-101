using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Sqlite;
using Dapper;
namespace StudentExercises {
    class Program {
        static void Main (string[] args) {

            SqliteConnection db = DatabaseInterface.Connection;
            DatabaseInterface.CheckExerciseTable();
            //DatabaseInterface.CheckTable();
            List<Exercise> exercisesList = db.Query<Exercise>(@"SELECT * FROM Exercise").ToList();
            
            DatabaseInterface.CheckInstructorsTable();
            db.Query<Instructor, Cohort, Instructor>(@"
            SELECT i.Id,
            i.lastName,
            c.Id,
            c.cohortName
            FROM Instructor i
            JOIN Cohort c ON c.Id = i.Cohort",
            (generatedInstructor, generatedCohort) =>
            {
                generatedInstructor.cohort = generatedCohort;
                return generatedInstructor;
            })
            .ToList()
            .ForEach(ins => Console.WriteLine($"{ins.lastName} {ins.firstName} is in {ins.cohort.cohortName}"));
           

           //add to joiner table StudentExercises
           //db.Execute(@"Insert into StudentExercises (studentId, exerciseId) Values (2, 3)");


            DatabaseInterface.CheckStudentTable();
            db.Query<Student, Cohort, Student>(@"
            SELECT s.`Id `,
            s.lastName,
            c.Id,
            c.cohortName
            FROM Student s
            JOIN Cohort c ON c.Id = s.cohort",
            (generatedStudent, generatedCohort) =>
            {
                generatedStudent.Cohort = generatedCohort;
                return generatedStudent;
            })
            .ToList()
            .ForEach(stu => Console.WriteLine($"{stu.lastName} {stu.firstName} is in {stu.Cohort.cohortName}"));
           
            List<Student> ExercisesList = db.Query<Student>(@"
            SELECT * FROM Exercise").ToList().ForEach(s => Console.WriteLine($"{s.lastName} {s.ExerciseList}"));


            /* 
            Dictionary<string, List<Student>> report = new Dictionary<string, List<Student>>();
            IEnumerable<int> StudentExer = db.Query<int>((@"
            SELECT studentId,
            exerciseId
            from StudentExercises
            JOIN Exercise e ON 
            
            ")
        */
            /* 
            DatabaseInterface.CheckStudentExercisesTable();
            db.Query<Student, Exercise, Student>(@"
            SELECT s.Id,
            s.lastName,
            e.Id,
            e.exerciseName
            
*/
            //instructorList.ForEach(i => Console.WriteLine($"{i.lastName}"));
            //exercisesList.ForEach(exer => Console.WriteLine($"{exer.exerciseName} {exer.language}"));

            //var newList2 = from e in exercisesList
                //where e.language == "Python"
            //select e;
            //oreach (Exercise i in newList2) {
           //Console.WriteLine(i.exerciseName);
           // }

            //db.Execute(@"INSERT INTO Exercise (exerciseName, language) VALUES ('omg no', 'SQL');");

            //Console.WriteLine(exercisesList);
            exercisesList.ForEach(exer => Console.WriteLine($"{exer.exerciseName} {exer.language}"));

            //db.Execute(@"DELETE FROM Exercise where exerciseName = 'omg no'");
/*
            Exercise SmashFace = new Exercise () {
                exerciseName = "Smash my face",
                language = "Python",
            };

            Exercise PunchFace = new Exercise () {
                exerciseName = "Punch my face",
                language = "C#",
            };

            Exercise GutPunch = new Exercise () {
                exerciseName = "Punch in gut",
                language = "ISODUM",
            };

            Exercise EsteemKill = new Exercise () {
                exerciseName = "Good Luck",
                language = "CVerySharp",
            };

            Cohort Cohort45 = new Cohort () {
                cohortName = "Cohort 45",
            };

            Cohort Cohort46 = new Cohort () {
                cohortName = "Cohort 46",
            };

            Cohort Cohort47 = new Cohort () {
                cohortName = "Cohort 47",
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
                cohort = Cohort45
            };

            Instructor DrDespair = new Instructor () {
                firstName = "D",
                lastName = "Despair",
                SlackHandle = "Despairy",
                cohort = Cohort46
            };

            Instructor DrHappy = new Instructor () {
                firstName = "Really",
                lastName = "Happy",
                SlackHandle = "HappyFace",
                cohort = Cohort47
            };

            DrDoom.AssignExercise (SmashFace, Klaus);
            DrDoom.AssignExercise (PunchFace, Klaus);
            DrDespair.AssignExercise (SmashFace, Fig);
            //Klaus.ExerciseList.ForEach(emp => Console.WriteLine(emp.Name));
            //drives me nuts there's not more req to console log to verify
            DrDespair.AssignExercise (PunchFace, Fig);
            DrHappy.AssignExercise (SmashFace, Ricky);
            DrHappy.AssignExercise (EsteemKill, Ricky);
            DrDoom.RemoveExercise(SmashFace, Klaus);
            DrDoom.RemoveExercise(PunchFace, Klaus);

            List<Student> students = new List<Student> ();
            students.Add (Klaus);
            students.Add (Ricky);
            students.Add (Fig);
            //students.ForEach (pl2 => Console.WriteLine (pl2.lastName));

            List<Exercise> exercises = new List<Exercise> ();
            exercises.Add (SmashFace);
            exercises.Add (PunchFace);
            exercises.Add (EsteemKill);
            exercises.Add (GutPunch);

            List<Instructor> instructors = new List<Instructor> ();
            instructors.Add (DrDoom);
            instructors.Add (DrDespair);
            instructors.Add (DrHappy);
            
            List<Cohort> cohorts = new List<Cohort> ();
            cohorts.Add (Cohort45);
            cohorts.Add (Cohort46);
            cohorts.Add (Cohort47);

//List<Exercise> newList = from e in exercises
var newList = from e in exercises
where e.language == "Python"
select e;
foreach (Exercise i in newList) {
           //Console.WriteLine(i.exerciseName);
}

IEnumerable<Cohort> cohortList = from c in cohorts 
where c.cohortName == "Cohort 45"
select c;
foreach (Cohort i in cohortList) {
    //Console.WriteLine(i.Name + " is the best");
};

List<Instructor> newInstructorList = (from i in instructors
where i.cohort == Cohort45
select i).ToList();
foreach (Instructor i in newInstructorList) {
    //Console.WriteLine(i.firstName + i.lastName);
}

IEnumerable<Student> newStudentList = from s in students
orderby s.lastName
select s; //s is a callback or lamda 
foreach (Student s in newStudentList) {
    //Console.WriteLine(s.lastName);
}


 foreach (Exercise ex in exercises) {
                List<string> assignedStudents = new List<string> ();

                foreach (Student stu in students) {
                    if (stu.ExerciseList.Contains (ex)) {
                        assignedStudents.Add (stu.firstName);
                    }
                }
                    Console.WriteLine ($"{ex.Name} is being worked on by {String.Join(", ", assignedStudents)}");
 }

 foreach (Student s in students) {
    string sExercises = "";
    int count = 0;

    foreach (Exercise e in s.ExerciseList) {
        if (count == 0) {
            sExercises = $"{e.exerciseName} in {e.language}";
            count ++;
        } else {
                sExercises = $"{e.exerciseName} in {e.language} and {sExercises}.";
                count++;
                    }
                }

                //Console.WriteLine ($"{s.lastName} of {s.StudentCohort.Name} is working on {sExercises}");

 }         


 IEnumerable<Student> studentWithNone = students.Where(stu =>
 stu.ExerciseList.Count ==0 ); //ToList() or Count() doesnt matter
 foreach (var stu in studentWithNone) {
     //Console.WriteLine(stu.lastName);
 }


 var numberOfStudentEachCohort = students.GroupBy(c => c.StudentCohort.cohortName);
 foreach (var studentGroup in numberOfStudentEachCohort) {
     //Console.WriteLine($"{studentGroup.Key} has {studentGroup.Count()} student");
 }
 
//list within a list. Need to iterate over both- build up a string
            //students.AddRange (exercises);

            var i = 
            for (i = 0; i < 10; i++) {
                for (int j = i; j < 10; j++)
                    Console.WriteLine ("Value of i: {0}, J: {1} ", i, j);
            }



 
            
//db.Execute(@"INSERT INTO Instructor (firstName, lastName, slackHandle, cohort) VALUES ('Jim', 'Carey', 'PetDet', 1);");

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