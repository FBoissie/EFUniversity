public class Enrollment
{
    public int Id{get;set;}
    public int CourseId{get;set;}
    public int StudentId{get;set;}
    public Grade? Grade{get;set;}
    public Course Course{get;set;}
    public Student Student{get;set;}
}

public enum Grade //enum is a set of named constants whose underlying type is numeric (int by default) 
{
    A, B, C, D, F
}

