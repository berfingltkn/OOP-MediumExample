using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Program
    {
        static void Main(string[] args)
        {
            //goruldugu uzere Muhendis,Yonetici ve SatisTemsilcisi classlarını Calısan classı ile işaretleyebiliyoruz
            Calisan[] calisanlar = {
        new Muhendis(),
        new Yonetici(),
        new SatisTemsilcisi()
    };

            // Her çalışanın sorumluluklarını görelim
            foreach (var calisan in calisanlar)
            {
                calisan.CalisanSorumlulukları();
            }
        }
    }
}

public class Calisan
{
    public virtual void CalisanSorumlulukları()
    {
        Console.WriteLine("Çalışan sorumluluklarını yerine getiriyor.");
    }
}

// Mühendis sınıfı, Çalışan sınıfından kalıtım alır
public class Muhendis : Calisan
{
    public override void CalisanSorumlulukları()
    {
        Console.WriteLine("Mühendis, yeni özellikler geliştiriyor ve hataları düzeltmektedir.");
    }
}

// Yönetici sınıfı, Çalışan sınıfından kalıtım alır
public class Yonetici : Calisan
{
    public override void CalisanSorumlulukları()
    {
        Console.WriteLine("Yönetici, ekibi yönetmekte ve işleri koordine etmektedir.");
    }
}

// Satış Temsilcisi sınıfı, Çalışan sınıfından kalıtım alır
public class SatisTemsilcisi : Calisan
{
    public override void CalisanSorumlulukları()
    {
        Console.WriteLine("Satış Temsilcisi, müşterilerle görüşmekte ve satışları artırmaktadır.");
    }
}