using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction2
{
    public class Program
    {
        static void Main(string[] args)
        {

            Gitar gitar = new Gitar();
            Piyano piyano = new Piyano();

            gitar.Cal();
            piyano.Cal();

           
            


        }
    }
}

public abstract class MuzikAleti
{
    public string Model { get; set; }
    public string Marka { get; set; }
    public int Fiyat { get; set; }

    public abstract void Cal();
}
public class Gitar:MuzikAleti {

    public int TelSayisi { get; set; }



    public override void Cal()
    {
        Console.WriteLine("Gitar çalınıyor(gitar sesi) .");
    }
}
public class Piyano : MuzikAleti
{
    public int TusSayisi { get; set; }


    public override void Cal()
    {
        Console.WriteLine("Piyano çalınıyor(piyano sesi) .");
    }
}