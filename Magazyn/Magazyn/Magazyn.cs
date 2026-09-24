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
        public string[,,] pulka;
        public Magazyn()
        {
            pulka = new string[2, 5, 5] 
            { 
                { 
                    { "", "", "rock", "paper", "paper" },
                    { "paper", "", "", "scizzors", "" },
                    { "", "", "paper", "paper", ""},
                    { "paper", "scizzors", "paper", "scizzors", "rock"},
                    { "", "paper", "scizzors", "rock", "rock"},
                },
                { 
                    { "paper", "paper", "rock", "", ""},
                    { "scizzors", "", "rock", "rock", "rock"},
                    { "", "scizzors", "", "scizzors", ""},
                    { "rock", "rock", "paper", "", ""},
                    {"paper", "rock", "", "paper", "" }
                }
            };
        }
        public Magazyn(int s, int h, int l)
        {
            pulka = new string[s, h, l];
        }
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
                        pulka[i, j, k] = "";
                    }
                }
            }
        }
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
                            if(pulka[i, j, k] == "rock")
                            {
                                wynik = (i + ", " + j + ", " + k);
                                pulka[i, j, k] = "";
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
                            if (pulka[i, j, k] == "paper")
                            {
                                wynik = (i + ", " + j + ", " + k);
                                pulka[i, j, k] = "";
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
                            if (pulka[i, j, k] == "scizzors")
                            {
                                wynik = (i + ", " + j + ", " + k);
                                pulka[i, j, k] = "";
                                return wynik;
                            }
                        }
                    }
                }
            }
            return "Not Selected Item For Takeout. Select 0 for rock, 1 for paper, or 2 for scizzors.";

        }

        public string Wez_wybrany(int a, int b, int c)
        {
            if (pulka[a, b, c] != "")
            {
                string wynik = pulka[a, b, c];
                pulka[a, b, c] = "";
                return ("Wzięto " + wynik);
            }
            return "Pułka była pusta";
        }
        public string Wloz_pierwszy(int a)
        {
            if (a>=0 && a <= 2)
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
                            if (pulka[i, j, k] == "")
                            {
                                string wynik = (i + ", " + j + ", " + k);
                                if(a==0)
                                {
                                    pulka[i, j, k] = "rock";
                                }
                                else if (a == 1)
                                {
                                    pulka[i, j, k] = "paper";
                                }
                                else
                                {
                                    pulka[i, j, k] = "scizzors";
                                }
                                    return wynik;
                            }
                        }
                    }
                }
            }
            return "Not Selected Item For Input. Select 0 for rock, 1 for paper, or 2 for scizzors.";
        }
        public string Wloz_wybrany(int a, int b, int c, int d)
        {
            if(d>=0 && d <= 2)
            {
                if (pulka[a,b,c] == "")
                {
                    if (d == 0)
                    {
                        pulka[a, b, c] = "rock";
                        return "Wlozono kamien";
                    }else if (d == 0)
                    {
                        pulka[a, b, c] = "paper";
                        return "Wlozono papier";
                    }
                    else
                    {
                        pulka[a, b, c] = "scizzors";
                        return "Wlozono nozyce";
                    }
                }
                return "Pulka byla zajeta";
            }
            return "Wpisz poprawny przedmiot do wlożenia";
        }
    }
}
