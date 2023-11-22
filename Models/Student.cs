public class Student
{
    public int Id { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public DateTime EnrollmentDate { get; set; }
    public List<Enrollment> Enrollments { get; set; }

    //constructeur non souhaité car création de Student directement 
    //à la volée via des {} dans SeedData et non des () tah un constructeur

    // public Student(int id, string lastName, string firstName) 
    // {
    //     Id = id;
    //     LastName = lastName;
    //     FirstName = firstName;
    //     EnrollmentDate = DateTime.Now;
    //     Enrollments = new List<Enrollment>();
    // }

    public override string ToString()
    {
        return $"{Id} - {LastName} {FirstName} - {EnrollmentDate}";
    }
}

