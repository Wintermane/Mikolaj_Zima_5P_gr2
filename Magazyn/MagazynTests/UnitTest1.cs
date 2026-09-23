namespace Magazyn
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Magazyn m1 = new Magazyn();
            Assert.Equal(25, m1.pulka.Length);
            //Test tworzenia normalnej tablicy;
        }
        [Fact]
        public void Test2()
        {
            int w = 5;
            int h = 6;
            int l = 7;
            Magazyn m1 = new Magazyn(5,6,7);
            Assert.Equal(210, m1.pulka.Length);
            //Test tworzenia normalnej tablicy;
        }
        [Fact]

        public void Test3()
        {
            Magazyn m1 = new Magazyn();
            string pozycja = m1.Wez(1);

            Assert.Matches("0, 0, 3", pozycja);
        }
    }
}