using DesafioPOO.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        // TODO: Realizar os testes com as classes Nokia e Iphone
        Iphone i = new("11999999999", "IPHONE 15 PRO", "123455BCC", 164);
        Nokia n = new("11999999777", "NOKIA ULTRA 3", "ZZXAA11", 64);

        i.Ligar();
        i.ReceberLigacao();
        i.InstalarAplicativo("IOS");
        Console.WriteLine("###########################");
        n.Ligar();
        n.ReceberLigacao();
        n.InstalarAplicativo("Android");
    }
}
