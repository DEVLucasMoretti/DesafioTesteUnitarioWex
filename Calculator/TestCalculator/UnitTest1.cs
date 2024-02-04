using Calculator;
namespace TestCalculator
{
    public class UnitTest1 
    {

        public SystemCalculator BuildClass()
        {
            SystemCalculator calc = new SystemCalculator();
            return calc;
        }

        [Theory]             //valor 1 e 2 e o result é o resultado que se espera
        [InlineData (1,2,3)] //[InlineData (v1,v2,result) ]
        [InlineData (4,5,9)]
        public void TestSum(int v1, int v2, int result)
        {
            SystemCalculator calc = BuildClass();

            int resultCalc = calc.sum(v1,v2);
            Assert.Equal(result, resultCalc);

        }

        [Theory]             //valor 1 e 2 e o result é o resultado que se espera
        [InlineData(6, 2, 4)] //[InlineData (v1,v2,result) ]
        [InlineData(5, 5, 0)]
        public void TestSub(int v1, int v2, int result)
        {
            SystemCalculator calc = BuildClass();

            int resultCalc = calc.sub(v1, v2);
            Assert.Equal(result, resultCalc);

        }

        [Theory]             //valor 1 e 2 e o result é o resultado que se espera
        [InlineData(1, 2, 2)] //[InlineData (v1,v2,result) ]
        [InlineData(4, 5, 20)]
        public void TestMul(int v1, int v2, int result)
        {
            SystemCalculator calc = BuildClass();

            int resultCalc = calc.mult(v1, v2);
            Assert.Equal(result, resultCalc);

        }

        [Theory]             //valor 1 e 2 e o result é o resultado que se espera
        [InlineData(6, 2, 3)] //[InlineData (v1,v2,result) ]
        [InlineData(5, 5, 1)]
        public void TestDiv(int v1, int v2, int result)
        {
            SystemCalculator calc = BuildClass();

            int resultCalc = calc.div(v1, v2);
            Assert.Equal(result, resultCalc);

        }
        [Fact]
        public void TestDivZero()
        {
            SystemCalculator calc = BuildClass();
            Assert.Throws<Exception>(
                () => calc.div(3,0)
                );
        }

        [Fact]
        public void TestHistoric()
        {
            SystemCalculator calc = new SystemCalculator();
            calc.sum(1, 2);
            calc.sum(2, 5);
            calc.sum(3, 7);
            calc.sum(4, 8);

            var list = calc.historic();
            Assert.NotEmpty(list);
            Assert.Equal(3, list.Count);
        }
    }
}