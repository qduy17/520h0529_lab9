using StudentServiceLib;
namespace lab9
{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Student student = new Student();
            student.Score = 10;

            char ssScore = student.getLetterScore();

            Assert.AreEqual('A', ssScore);

        }
    }
}