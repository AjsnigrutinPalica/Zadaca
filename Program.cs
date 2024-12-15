public class Program
{
    public static void Main(string[] args)
    {
        IzvedenaKlasa objekt = new IzvedenaKlasa();
        objekt.PrikaziPoruku();
    }
    public class BaznaKlasa
    {
        public virtual void PrikaziPoruku()
            {
            Console.WriteLine("pero");
            }

    }
    public class IzvedenaKlasa : BaznaKlasa
    {

    }

}