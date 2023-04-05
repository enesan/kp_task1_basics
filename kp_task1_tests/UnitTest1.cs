

namespace kp_task1_tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    [DataRow(22)]
    [DataRow(34)]
    [DataRow(10)]
    public void Task1_EvenAnd2Signs_True(int value)
    {
        bool resultValue = Program.Task1(value);
        
        Assert.IsTrue(resultValue);
    }

    [TestMethod]
    [DataRow(33)]
    [DataRow(9)]
    [DataRow(100)]
    [DataRow(71)]
    public void Task1_NotEvenAnd2Signs_False(int value)
    {
        bool resultValue = Program.Task2(value);
        
        Assert.IsFalse(resultValue);
    }

    [TestMethod]
    [DataRow(1221)]
    [DataRow(9999)]
    public void Task2_4SignsMirror_True(int value)
    {
        bool result = Program.Task2(value);
        
        Assert.IsTrue(result);
    }

    [TestMethod]
    [DataRow(99)]
    [DataRow(999)]
    [DataRow(1222)]
    [DataRow(2221)]
    [DataRow(1212)]
    public void Task2_OtherValues_False(int value)
    {
        bool result = Program.Task2(value);
        
        Assert.IsFalse(result);
    }

    [TestMethod]
    [DataRow(1.3, 1)]
    [DataRow(-1.3, 1)]
    [DataRow(2, 0)]
    [DataRow(-1, 0)]
    public void Task3_return_1(int x, int y)
    {
        int result = Program.Task3(x, y);

        Assert.Equals(result, 1);
    }
    
    [TestMethod]
    [DataRow(-1.3, -1)]
    [DataRow(1.3, -1)]
    [DataRow(0, 0)]
    [DataRow(0.5, 0.5)]
    [DataRow(1.5, 1.5)]
    public void Task3_return_0(int x, int y)
    {
        int result = Program.Task3(x, y);

        Assert.Equals(result, 1);
    }
    
    [TestMethod]
    [DataRow(0.4, 0.5)]
    [DataRow(-0.1, 0.2)]
    [DataRow(1, 0)]
    [DataRow(0, 1)]
    public void Task4_return_0(int x, int y)
    {
        int result = Program.Task4(x, y);

        Assert.Equals(result, 0);
    }
    
    [TestMethod]
    [DataRow(0.2, 0)]
    [DataRow(1.3, -1)]
    [DataRow(1.5, 1.5)]
    public void Task4_return_y(int x, int y)
    {
        int result = Program.Task4(x, y);

        Assert.Equals(result, y);
    }
    
    [TestMethod]
    [DataRow(0, 0)]
    [DataRow(0, 1)]
    [DataRow(0.1, 0.3)]
    [DataRow(-0.1, 0.3)]
    public void Task5_return_sumXandY(int x, int y)
    {
        int result = Program.Task5(x, y);

        Assert.Equals(result, x + y);
    }
    
    [TestMethod]
    [DataRow(1, 1)]
    [DataRow(0, -1)]
    [DataRow(-1, 0)]
    public void Task5_return_subtractXandY(int x, int y)
    {
        int result = Program.Task5(x, y);

        Assert.Equals(result, x - y);
    }

    
    [TestMethod]
    [DataRow(1,2, 1)]
    [DataRow(2,2, 4)]
    [DataRow(3,2, 27)]
    public void Task7_returnValueSquare(int number, int mantissa, int resultValue)
    {
        long result = Program.Task7(number, mantissa);

        Assert.Equals(result, resultValue);
    }
    
    
}