using PrimeNumber;

namespace PrimeNumber.Test

{
    public class Tests
    {
        [Test]
        public void NumberPrimeTrue()
        {
            Assert.True(isPrimeNumber.PrimeNumb(31));
            Assert.True(isPrimeNumber.PrimeNumb(109));
            Assert.True(isPrimeNumber.PrimeNumb(571));
            Assert.True(isPrimeNumber.PrimeNumb(997));
        }

        [Test]
        public void NumberPrimeNoTrue()
        {
            Assert.False(isPrimeNumber.PrimeNumb(9));
            Assert.False(isPrimeNumber.PrimeNumb(38));
            Assert.False(isPrimeNumber.PrimeNumb(412));
            Assert.False(isPrimeNumber.PrimeNumb(874));
        }
    }
}