Business business = new Business();

List<Student> studenten = business.GenerateStudents();

foreach (string result in business.PrintStudentInformatie(studenten))
{
    Console.WriteLine(result);
}