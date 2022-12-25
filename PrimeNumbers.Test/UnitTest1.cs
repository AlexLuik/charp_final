namespace PrimeNumbers.Test

{
    public class Tests
    {
        [TestCase(31)]
        [TestCase(109)]
        [TestCase(571)]
        [TestCase(997)]
        public void NumberPrimeTrue(int n)
        {
            Assert.True(isPrimeNumber.PrimeNumb(n));
        }

        [TestCase(9)]
        [TestCase(38)]
        [TestCase(412)]
        [TestCase(874)]
        public void NumberPrimeNoTrue(int n)
        {
            Assert.False(isPrimeNumber.PrimeNumb(n));

        }
    }
}