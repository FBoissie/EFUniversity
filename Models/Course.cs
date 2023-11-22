public class Course
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int Credits { get; set; }
    public List<Enrollment> Enrollments { get; set; }

    public override string ToString() //renvoie ce qu'il y'a en dessous lorsqu'on fait un writeline, sinon ne renvoie que le nom de la classe
    {
        return $"{Id} - {Title} - {Credits} credits";
    }
    //override permet de réécrire ToString car elle existe de base dans toutes les classes
}