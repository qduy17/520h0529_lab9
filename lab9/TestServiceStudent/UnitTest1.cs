using StudentServiceLib;
namespace TestServiceStudent
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            StudentService studentService = new StudentService();
            Student student1 = new Student();
            student1.Id = 1;
            student1.Name = "Khoa";
            student1.Age = 19;

            bool a =  studentService.addStudent(student1);
            Assert.AreEqual(true, a);
        }
    }
}