using System.Runtime.CompilerServices;
internal class Program
{
    private static void Main(string[] args)
    {

        HaloGeneric.SapaUser<string>("Farah");

    }
}

// Soal No.4
class HaloGeneric
{
    public static void SapaUser<T>(T inputUser)
    {

        Console.WriteLine("Halo user " + inputUser);
    }

}
