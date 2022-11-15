using StudentServiceLib;
namespace lab9
{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod5()
        {
            Student student = new Student();
            student.Score = 11;

        }
        [TestMethod]
        public void TestMethod1()
        {
            Student student = new Student();
            student.Score = 10;

            char ssScore = student.getLetterScore();

            Assert.AreEqual('A', ssScore);

        }

        [TestMethod]
        public void TestMethod2()
        {
            Student student = new Student();
            student.Score = 7;

            char ssScore = student.getLetterScore();

            Assert.AreEqual('B', ssScore);

        }

        [TestMethod]
        public void TestMethod3()
        {
            Student student = new Student();
            student.Score = 5;

            char ssScore = student.getLetterScore();

            Assert.AreEqual('C', ssScore);

        }

        [TestMethod]
        public void TestMethod4()
        {
            Student student = new Student();
            student.Score = 3.2;

            char ssScore = student.getLetterScore();

            Assert.AreEqual('E', ssScore);

        }
    }
}