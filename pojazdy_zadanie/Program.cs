using System;

public class Globals
{
    public static void Main()
    {
        Ladowy motor = new Ladowy();
        motor.czy_w_ruchu = true;
        motor.KM = 100f;
        motor.predkosc = 120f;
        motor.liczba_kol = 2;
        motor.paliwo = "benzyna";
        motor.ToString();
        
        
        Console.WriteLine();

        Hybrydowy amfibia = new Hybrydowy();
        amfibia.czy_w_ruchu = true;
        amfibia.KM = 25F;
        amfibia.predkosc = 40F;
        amfibia.paliwo = "olej";
        amfibia.ToString();

        Console.WriteLine();

        wodny statek = new wodny();
        statek.czy_w_ruchu = false;
        statek.KM = 1000F;
        statek.predkosc = 0F;
        statek.wypornosc = 10F;
        statek.paliwo = "olej";
        statek.ToString();

        Console.WriteLine();

        Powietrzny samolot = new Powietrzny();
        samolot.czy_w_ruchu = true;
        samolot.KM = 10000F;
        samolot.predkosc = 100F;
        samolot.paliwo = "wodór";
        samolot.ToString();
        Console.WriteLine();

    }
}

public class Pojazd : Globals
{
    public bool czy_w_ruchu;
    public float KM;
    public float predkosc;
    public string paliwo = " ";

}
public class Ladowy : Pojazd
{
    public Ladowy()
    {
        Console.Write(" Srodowisko ladowe - ");
    }
    public uint liczba_kol;
    public float czy_mozliwa_predkosc_ladowy(float predkosc)
    {
        while ((predkosc < 1F && predkosc != 0F) || predkosc > 350F)
        {
            Console.Write(" Wprowadz realna predkosc: ");

            predkosc = float.Parse(Console.ReadLine());
        }
        return predkosc;
    }
    public void ToString()
    {
        Console.Write(" Czy w ruchu: ");
        Console.Write(czy_w_ruchu);
        Console.Write(" Predkosc: ");
        Console.Write(czy_mozliwa_predkosc_ladowy(predkosc));
        Console.Write(" KM: ");
        Console.Write(KM);
        Console.Write(" Paliwo: ");
        Console.Write(paliwo);
    }

}
public class wodny : Pojazd
{
    public wodny()
    {
        Console.Write(" Srodowisko wodne - ");
    }
    public float wypornosc;
    public float czy_mozliwa_predkosc_wodna(float predkosc)
    {
        while ((predkosc < 1F && predkosc != 0F) || predkosc > 350F)
        {
            Console.Write(" Wprowadz realna predkosc: ");

            predkosc = float.Parse(Console.ReadLine());
        }
        return predkosc;

    }
    public void ToString()
    {
        Console.Write(" Czy w ruchu: ");
        Console.Write(czy_w_ruchu);
        Console.Write(" Predkosc: ");
        Console.Write(czy_mozliwa_predkosc_wodna(predkosc));
        Console.Write(" Wypornosc: ");
        Console.Write(wypornosc);
        Console.Write(" KM: ");
        Console.Write(KM);
        Console.Write(" Paliwo: ");
        Console.Write(paliwo);
    }
}

public class Powietrzny : Pojazd
{
    public Powietrzny()
    {
        Console.Write(" Srodowisko powietrzne - ");

    }
    public float czy_mozliwa_predkosc_powietrzny(float predkosc)
    {
        while ((predkosc < 20F && predkosc != 0F) || predkosc > 200F)
        {
            Console.Write(" Wprowadz realna predkosc: ");
            predkosc = float.Parse(Console.ReadLine());
        }
        return predkosc;
    }
    public void ToString()
    {
        Console.Write(" Czy w ruchu: ");
        Console.Write(czy_w_ruchu);

        Console.Write(" Predkosc: ");
        Console.Write(czy_mozliwa_predkosc_powietrzny(predkosc));

        Console.Write(" KM: ");
        Console.Write(KM);

        Console.Write(" Paliwo: ");
        Console.Write(paliwo);


    }
}
public class Hybrydowy : Pojazd
{
    public Hybrydowy()
    {
        Console.Write(" Srodowisko hybrydowe - ");

    }
    public float kontrola_predkosci(float predkosc)
    {
        while (predkosc < 0F)
        {
            Console.Write(" Wprowadz realna predkosc: ");
            predkosc = float.Parse(Console.ReadLine());
        }
        return predkosc;
    }
    public void ToString()
    {
        Console.Write(" Czy w ruchu: ");
        Console.Write(czy_w_ruchu);

        Console.Write(" Predkosc: ");
        Console.Write(kontrola_predkosci(predkosc));

        Console.Write(" KM: ");
        Console.Write(KM);

        Console.Write(" Paliwo: ");
        Console.Write(paliwo);

    }
}