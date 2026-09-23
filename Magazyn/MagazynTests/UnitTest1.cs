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
    }
}