using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentExercises
{
    
    public class Instructor {
        public string firstName {get; set;}
        public string lastName {get; set;}
        
        public string SlackHandle { get; set;}

        public Cohort InstructorCohort { get; set;}

       // public Instructor (string firstName, string lastName) 
        //{
            
        //}

        public void AssignExercise (Exercise exercise, Student student) {
            student.ExerciseList.Add(exercise);
    }
    
        
    }

}



/*

Instructor
You must define a type for representing an instructor in code.

First name
Last name
Slack handle
The instructor's cohort
A method to assign an exercise to a student

 */