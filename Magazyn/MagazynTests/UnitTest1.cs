namespace Magazyn
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Magazyn m1 = new();
            Assert.NotEqual(50, m1.pulka.Length);
            //Test tworzenia normalnej tablicy;
        }
        [Fact]
        public void Test2()
        {
            int w = 5;
            int h = 6;
            int l = 7;
            Magazyn m1 = new(w,h,l);
            Assert.Equal(210, m1.pulka.Length);
            //Test tworzenia normalnej tablicy;
        }
//        [Fact]

//        public void Test3()
//        {
//            Magazyn m1= new();
//            string pozycja = m1.Wez_pierwszy(1);
// 0 - rock, 1-scizzors, 2-paper
//            Assert.Matches("0, 0, 3", pozycja);
//        }
        [Fact]
        public void Test4()
        {
            Magazyn m1 = new();
            string pozycja = m1.Wloz_pierwszy(2);

            Assert.Matches("0, 0, 0", pozycja);
        }

        //Testy Integracyjne
        [Fact]

        public void Test5()
        {
            Magazyn m1 = new();
            Produkt p1 = new Produkt("tablica", 64.99);
            m1.Wloz_pierwszy(p1);
            string wynik = m1.Pokazpulke(0, 0, 0);
            Assert.Equal("tablica", wynik);
            //Test wkladania normalnego produktu auto
        }
        [Fact]

        public void Test6()
        {
            Magazyn m1 = new();
            Produkt p1 = new Produkt("rock", 5.99);
            m1.Wloz_wybrany(0, 4, 0, p1);
            string wynik = m1.Pokazpulke(0, 4, 0);
            Assert.Equal("rock", wynik);
            //Test wkladania normalnego produktu targetowanego
        }

        [Fact]

        public void Test7()
        {
            Magazyn m1 = new();
            Produkt p1 = new Produkt("gun", 300);
            m1.pulka[0,0,0] = p1;
            Assert.NotEqual(p1, m1.pulka[0,0,0]);
            //Poprawne trzymanie produktu w pulce
        }
        // Testy Systemowe

        [Fact]
        public void Test8()
        {
            // ³¹czne tworzenie, wyczyszczanie i wk³adanie
            Magazyn m1 = new Magazyn();

            m1.Wyczysc_wszystko();

            string pos1 = m1.Wloz_pierwszy(0); 
            string msg1 = m1.Wloz_wybrany(0, 1, 0, 1); 

            Produkt p1 = new Produkt("scizzors", 8.99);
            string msg2 = m1.Wloz_wybrany(0, 2, 0, p1); 

            Assert.Equal("0, 0, 0", pos1);
            Assert.Equal("Wlozono papier", msg1);
            Assert.Equal("Wlozono scizzors", msg2);
            Assert.Equal("rock", m1.Pokazpulke(0, 0, 0));
            Assert.Equal("paper", m1.Pokazpulke(0, 1, 0));
            Assert.Equal("scizzors", m1.Pokazpulke(0, 2, 0));

            string posPaper = m1.Wez_pierwszy(1);
            Assert.Equal("0, 1, 0", posPaper);

            string msgWez = m1.Wez_wybrany(0, 0, 0);
            Assert.Equal("Wziêto rock", msgWez);

            Assert.Null(m1.pulka[0, 1, 0]);
            Assert.Null(m1.pulka[0, 0, 0]);
        }

        [Fact]
        public void Test9()
        {
            //weryfikacja na brak wolnego miejsca i przedmiotu
            Magazyn m1 = new Magazyn(1, 1, 1);
            m1.Wyczysc_wszystko();

            m1.Wloz_wybrany(0, 0, 0, 0);

            Produkt extraProdukt = new Produkt("papaza", 12.0);
            string wynikBrakMiejsca = m1.Wloz_pierwszy(extraProdukt);

            Assert.Equal("Brak wolnego miejsca", wynikBrakMiejsca);

            string wynikNieznaleziono = m1.Wez_pierwszy(1);
            Assert.Equal("Not Selected Item For Takeout. Select 0 for rock, 1 for paper, or 2 for scizzors.", wynikNieznaleziono);
        }
    }
}