using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleCode;


namespace TriangleCode.Tests
{
  [TestClass]
  public class CalcTest
  {
    [TestMethod]
    public void Calc_TriangleTypeChecker_Scalene()
    {
        Triangle testTriangle = new Triangle(3,4,5);
        // any necessary logic to prep for test; instantiating new classes, etc.
        Assert.AreEqual("This is a Scalene Triangle", Triangle.Calc(3,4,5));
    }
  }
}