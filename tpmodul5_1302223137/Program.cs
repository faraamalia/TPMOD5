using System.Runtime.CompilerServices;
internal class Program
{
    private static void Main(string[] args)
    {

        HaloGeneric.SapaUser<string>("Farah");

        DataGeneric<string> ObjData1 = new DataGeneric<string>("1302223137");
        ObjData1.PrintData();

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

//Soal No.6
class DataGeneric<T>
{
    private T data;


    public DataGeneric(T inputUser)
    {
        this.data = inputUser;

    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + data);
    }
}

