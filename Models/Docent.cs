public class Docent : Gebruiker
{
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
}