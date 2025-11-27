Business business = new Business();

List<Gebruiker> gebruikers = business.GenerateStudents();

foreach (string result in business.GetGebruikerInformatie(gebruikers))
{
    Console.WriteLine(result);
}