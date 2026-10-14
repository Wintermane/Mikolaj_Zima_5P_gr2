using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Magazyn
{
    public class Magazyn
    {
        public Produkt[,,] pulka;
        public Magazyn()
        {
            pulka = new Produkt[2, 5, 5];
        }
        public Magazyn(int s, int h, int l)
        {
            pulka = new Produkt[s, h, l];
        }

        //Pokazuje wartosc wyznaczonej pulki
        public string Pokazpulke(int a, int b, int c)
        {
            string wynik = pulka[a, b, c].nazwa;
            return wynik;
        }

        //Usuwa wszystkie zawartosci pulki
        public void Wyczysc_wszystko()
        {
            int s = pulka.GetUpperBound(0) + 1;
            int h = pulka.GetUpperBound(1) + 1;
            int l = pulka.GetUpperBound(2) + 1;
            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    for (int k = 0; k < l; k++)
                    {
                        pulka[i, j, k] = null;
                    }
                }
            }
        }

        //Usuwa z pulki pierwsza zawartosc wybrana wartoscia a
        public string Wez_pierwszy(int a)
        {
            string wynik;
            if (a == 0)
            {
                int s = pulka.GetUpperBound(0) + 1;
                int h = pulka.GetUpperBound(1) + 1;
                int l = pulka.GetUpperBound(2) + 1;
                for (int i = 0; i < s; i++)
                {
                    for (int j = 0; j < h; j++)
                    {
                        for (int k = 0; k < l; k++)
                        {
                            if (pulka[i, j, k].nazwa == "rock")
                            {
                                wynik = (i + ", " + j + ", " + k);
                                pulka[i, j, k] = null;
                                return wynik;
                            }
                        }
                    }
                }
            }
            else if (a == 1)
            {
                int s = pulka.GetUpperBound(0) + 1;
                int h = pulka.GetUpperBound(1) + 1;
                int l = pulka.GetUpperBound(2) + 1;
                for (int i = 0; i < s; i++)
                {
                    for (int j = 0; j < h; j++)
                    {
                        for (int k = 0; k < l; k++)
                        {
                            if (pulka[i, j, k].nazwa == "paper")
                            {
                                wynik = (i + ", " + j + ", " + k);
                                pulka[i, j, k] = null;
                                return wynik;
                            }
                        }
                    }
                }
            }
            else if (a == 2)
            {
                int s = pulka.GetUpperBound(0) + 1;
                int h = pulka.GetUpperBound(1) + 1;
                int l = pulka.GetUpperBound(2) + 1;
                for (int i = 0; i < s; i++)
                {
                    for (int j = 0; j < h; j++)
                    {
                        for (int k = 0; k < l; k++)
                        {
                            if (pulka[i, j, k].nazwa == "scizzors")
                            {
                                wynik = (i + ", " + j + ", " + k);
                                pulka[i, j, k]=null;
                                return wynik;
                            }
                        }
                    }
                }
            }
            return "Not Selected Item For Takeout. Select 0 for rock, 1 for paper, or 2 for scizzors.";

        }

        //Usuwa wartosc z danej pulki
        public string Wez_wybrany(int a, int b, int c)
        {
            if (pulka[a, b, c] != null)
            {
                string wynik = pulka[a, b, c].nazwa;
                pulka[a, b, c] = null;
                return ("Wzięto " + wynik);
            }
            return "Pułka była pusta";
        }

        //Wklada zawartosc wyznaczona wartoscia a do pierwszego pustego pol pulki
        public string Wloz_pierwszy(int a)
        {
            if (a >= 0 && a <= 2)
            {
                int s = pulka.GetUpperBound(0) + 1;
                int h = pulka.GetUpperBound(1) + 1;
                int l = pulka.GetUpperBound(2) + 1;
                for (int i = 0; i < s; i++)
                {
                    for (int j = 0; j < h; j++)
                    {
                        for (int k = 0; k < l; k++)
                        {
                            if (pulka[i, j, k] == null)
                            {
                                string wynik = (i + ", " + j + ", " + k);
                                if (a == 0)
                                {
                                    Produkt p = new Produkt("rock", 5.99);
                                    pulka[i, j, k] = p;
                                }
                                else if (a == 1)
                                {
                                    Produkt p = new Produkt("paper", 2.99);
                                    pulka[i, j, k] = p;
                                }
                                else
                                {
                                    Produkt p = new Produkt("scizzors", 8.99);
                                    pulka[i, j, k] = p;
                                }
                                return wynik;
                            }
                        }
                    }
                }
            }
            return "Not Selected Item For Input. Select 0 for rock, 1 for paper, or 2 for scizzors.";
        }

        //wklada zawartosc wyznaczona wartoscia d do pola pulka[a,b,c]
        public string Wloz_wybrany(int a, int b, int c, int d)
        {
            if (d >= 0 && d <= 2)
            {
                if (pulka[a, b, c] == null)
                {
                    if (d == 0)
                    {
                        Produkt p = new Produkt("rock", 5.99);
                        pulka[a, b, c] = p;
                        return "Wlozono kamien";
                    }
                    else if (d == 1)
                    {
                        Produkt p = new Produkt("paper", 2.99);
                        pulka[a, b, c] = p;
                        return "Wlozono papier";
                    }
                    else
                    {
                        Produkt p = new Produkt("scizzors", 8.99);
                        pulka[a, b, c] = p;
                        return "Wlozono nozyce";
                    }
                }
                return "Pulka byla zajeta";
            }
            return "Wpisz poprawny przedmiot do wlożenia";
        }
    }
}
