using System;
using System.Collections.Generic;

namespace StudentExercises
{
    
    public class Cohort {
        public string Name {get; set;}
     
        
        public List<Student> StudentList = new List<Student> (); 


        public List<Instructor> InstructorList = new List<Instructor> (); 
    }

}








/*
Cohort
You must define a type for representing a cohort in code.

The cohort's name (Evening Cohort 6, Day Cohort 25, etc.)
The collection of students in the cohort.
The collection of instructors in the cohort.

 */