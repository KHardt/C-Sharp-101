insert into Cohort (cohortName) values ("dayCohort45");
insert into Cohort (cohortName) values ("dayCohort46");
insert into Cohort (cohortName) values ("dayCohort47");

select * from Exercise;

insert into Exercise (exerciseName, language)  values("smash my face", "Python");
insert into Exercise (exerciseName, language)  values("punch my face", "C#");
insert into Exercise (exerciseName, language)  values("punch in gut", "ISODUM");
insert into Exercise (exerciseName, language)  values("good luck", "CVerySharp");

insert into Instructor (firstName, lastName, slackHandle, cohort) values("Dr", "Doom", "Doomy", 1);
select * from Instructor;
insert into Instructor (firstName, lastName, slackHandle, cohort) values("D", "Despair", "Despairy", 2);
insert into Instructor (firstName, lastName, slackHandle, cohort) values("Really", "Happy", "Happyface", 3);

select * from Cohort;
insert into Student (firstName, lastName, slackHandle, cohort) values("Klaus", "Hardt", "ookie", 1);
insert into Student (firstName, lastName, slackHandle, cohort) values("Matt", "Harding", "dook", 2);
insert into Student (firstName, lastName, slackHandle, cohort) values("Ricky", "Burden", "dooker", 3);
insert into Student (firstName, lastName, slackHandle, cohort) values("Fig", "Newton", "mook", 2);
select * from Student

insert into StudentExercises(studentId, exerciseId) values (4, 2);
select * from Student;
select * from Exercise;
select * from StudentExercises;
