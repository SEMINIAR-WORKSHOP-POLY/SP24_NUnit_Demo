using DemoNUnit;

namespace StudentAverageTest
{
    [TestFixture]
    public class Tests
    {
        StudentAverage studentAverage;
        [SetUp]
        public void Setup()
        {
            studentAverage = new StudentAverage();
        }

        [Test]//Check diemTB = -1  -> nem ngoai le
        public void Test1()
        {
            Assert.Throws<ArgumentException>(() => studentAverage.getAverageRank(-1));
            //Assert.Throws<ArgumentException>(() => studentAverage.getAverageRank(11));
        }
        [Test]
        public void Test2()
        {
            Assert.Throws<ArgumentException>(() => studentAverage.getAverageRank(11));
        }
        [Test]
        public void Test3()
        {
            //Xuat sac
            double averageScore = 9.2;
            //Act
            string result = studentAverage.getAverageRank(averageScore);
            Assert.That(result, Is.EqualTo("Xuất sắc"));

        }
        [Test]
        public void Test4()
        {
            //Xuat sac
            double averageScore = 8.5;
            //Act
            string result = studentAverage.getAverageRank(averageScore);
            Assert.That(result, Is.EqualTo("Giỏi"));

        }
        [Test]
        public void Test5()
        {
            //Xuat sac
            double averageScore = 7.5;
            //Act
            string result = studentAverage.getAverageRank(averageScore);
            Assert.That(result, Is.EqualTo("Khá"));

        }
        [Test]
        public void Test6()
        {
            //Xuat sac
            double averageScore = 6.5;
            //Act
            string result = studentAverage.getAverageRank(averageScore);
            Assert.That(result, Is.EqualTo("Trung bình"));

        }
        [Test]
        public void Test7()
        {
            //Xuat sac
            double averageScore = 4;
            //Act
            string result = studentAverage.getAverageRank(averageScore);
            Assert.That(result, Is.EqualTo("Yếu"));
        }

    }
}