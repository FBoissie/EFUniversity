Console.WriteLine("Hello World!");

//SeedData.Init(); 
//appelle la méthode Init qui va créer les differents Student à la volée
//c'est en réalité une fonction car elle est static => on n'a pas a l'initialiser pour la lancer
//=> on fait pas SeedData = new SeedData => création de l'objet 
//=> quand c'est static on peut fouiller dans la méthode sans qu'elle soit appelée => les variables sont tjrs existantes
//=> les variables existent dans le contexte
// NE DOIT ETRE LANCE QU'UNE SEULE FOIS

UniversityContext context = new UniversityContext();
//interface avec la bdd => contient plein de méthode pour gérer la bdd 

//Courses est une des tables/paramètres de la bdd crée dans UniversityContext.cs
var courses = context.Courses.OrderBy(q => q.Title);
Console.WriteLine("All courses :");
foreach (var course in courses)
{
    Console.WriteLine("- " + course); //appelle la méthode redéfinie ToString de la classe Course
}

var students = context.Students.OrderBy(q => q.LastName);
Console.WriteLine("All students :");
foreach (var student in students)
{
    Console.WriteLine("- " + student);
}


