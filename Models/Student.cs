using System.Diagnostics.Contracts;

public class Student : Gebruiker
{
    public double Punten { get; set; }

    public bool IsAfgestudeerd { get; set; }

    public Student(string achternaam, double punten)
    {
        Punten = punten;
        AchterNaam = achternaam;
    }

    public string Resultaat
    {
        get
        {
            if (Punten >= 50)
            {
                return "Geslaagd";
            }
            else
            {
                return "Gebuisd";
            }
        }
    }

    public override string ToString()
    {
        return $"{AchterNaam} heeft {Punten} en " +
        $"is {Resultaat} en is afgestudeerd? {IsAfgestudeerd}";
    }
}