public class Student
{
    public int Id {get;set;}
    public string LastName{get;set;}
    public string FirstName{get;set;}
    public DateTime EnrollmentDate{get;set;}
    public List<Enrollment> Enrollments{get;set;}

public Student(int id, string lastName, string firstName) //constructeur
{
    Id = id;
    LastName = lastName;
    FirstName = firstName;
    EnrollmentDate = DateTime.Now;
    Enrollments = new List<Enrollment>();
}
    
}

