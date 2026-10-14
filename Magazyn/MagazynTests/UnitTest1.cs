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
            m1.Wloz_pierwszy(p1);
            Assert.NotEqual(p1, m1.pulka[0,0,0]);
            //Poprawne trzymanie produktu w pulce
        }
    }
}