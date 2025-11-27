public class Docent : Gebruiker
{
    public bool HasBedrijfswagen { get; set; } = false;

    public Docent()
    {
        HasBedrijfswagen = false;
    }

    private double salaris;
    public double Salaris
    {
        get { return salaris; }
        set
        {
            if (value < 2111.89)
            {
                salaris = 2111.89;
            }
            else
            {
                salaris = value;
            }
        }
    }

    public List<string> Vakken { get; set; }

    public override string ToString()
    {
        string result = $"Docent {VoorNaam} {AchterNaam} verdient {Salaris} per maand en geeft de volgende vakken:";

        foreach(string vak in Vakken)
        {
            result += $"\n{vak}";
        }

        return result;
    }
}