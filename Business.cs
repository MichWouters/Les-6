public class Business
{
    public List<Student> GenerateStudents()
    {
        List<Student> studenten = new List<Student>();
        Student michiel = new Student("Wouters", 49);
        Student peeters = new Student("Peeters", 75);
        Student akimbo = new Student("Booyaws", 49);
        Student john = new Student("Woo", 69);
        Student arnold = new Student("Shwarzenegger", 100);
        Student bruce = new Student("Willis", 88);

        studenten.Add(michiel);
        studenten.Add(peeters);
        studenten.Add(akimbo);
        studenten.Add(john);
        studenten.Add(arnold);
        studenten.Add(bruce);
        return studenten;
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