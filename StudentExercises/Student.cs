using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentExercises
{
    
    public class Student {
        public string firstName {get; set;}
        public string lastName {get; set;}
        
        public string SlackHandle { get; set;}

        public Cohort Cohort { get; set;} //attaching between two like ERD 1 to many

        public List<Exercise> ExerciseList = new List<Exercise> (); //many to many
    }

}


/*


First name
Last name
Slack handle
The student's cohort
The collection of exercises that the student is currently working on

 */