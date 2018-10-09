using System;
using System.Collections.Generic;

namespace StudentExercises
{
    
    public class Student {
        public string firstName {get; set;}
        public string lastName {get; set;}
        
        public string SlackHandle { get; set;}

        public string Cohort { get; set;}

        public List<Exercise> ExerciseList = new List<Exercise> (); 
    }

}


/*


First name
Last name
Slack handle
The student's cohort
The collection of exercises that the student is currently working on

 */