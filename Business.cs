public class Business
{
    public List<Gebruiker> GenerateStudents()
    {
        List<Gebruiker> gebruikers = new List<Gebruiker>();
        Student michiel = new Student("Wouters", 49);
        Student peeters = new Student("Peeters", 75);
        Student akimbo = new Student("Booyaws", 49);
        Student john = new Student("Woo", 69);
        Student arnold = new Student("Shwarzenegger", 100);
        Student bruce = new Student("Willis", 88);

        Docent frank = new Docent
        {
            AchterNaam = "De boze",
            VoorNaam = "Frank",
            Vakken = new List<string> { "Engels", "Frans", "Aardrijkskunde" }
        };

        Docent lilly = new Docent
        {
            AchterNaam = "Blye",
            VoorNaam = "Lilly",
            Vakken = new List<string> { "It Professional", "Exploring IT", "IT Casual" }
        };

        gebruikers.Add(michiel);
        gebruikers.Add(peeters);
        gebruikers.Add(frank);

        gebruikers.Add(akimbo);
        gebruikers.Add(john);
        gebruikers.Add(lilly);

        gebruikers.Add(arnold);
        gebruikers.Add(bruce);


        return gebruikers;
    }

    public List<string> PrintStudentInformatie(List<Student> studenten)
    {
        List<string> result = new List<string>();

        foreach (Student student in studenten)
        {
            result.Add(student.ToString());
        }

        return result;
    }


}