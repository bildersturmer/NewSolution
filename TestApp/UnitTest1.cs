using NewSolution;


namespace TestApp;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        Assert.Equals(AppClass.testName,"App Class" );
    }
}