using NewSolution;


namespace TestApp;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        Assert.AreEqual(AppClass.testName, "App Test");
    }
    
    [TestMethod]
    public void TestMethod2()
    {
        Assert.AreNotEqual(AppClass.testName, "Not App Test");
    }

    [TestMethod]
    public void TestMethod3()
    {
        Assert.AreEqual(AppClass.testName,"App Test" );
    }        
}