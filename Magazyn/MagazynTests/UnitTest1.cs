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
        [Fact]

        public void Test3()
        {
            Magazyn m1= new();
            string pozycja = m1.Wez_pierwszy(1);

            Assert.Matches("0, 0, 3", pozycja);
        }
        [Fact]
        public void Test4()
        {
            Magazyn m1 = new();
            string pozycja = m1.Wloz_pierwszy(2);

            Assert.Matches("0, 0, 0", pozycja);
        }
    }
}