

using Tyuiu.KhudoiberdievDB.Sprint1.Task2.V22.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint1.Task2.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {  
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int  x = 1;
            int  y = 2;
            int  z = 3;
            
            var  res = ds.CalculateAVGValue( x,  y, z);
            Assert.AreEqual(2, res);

        }

        
    }
}