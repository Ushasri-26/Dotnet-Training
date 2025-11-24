namespace UnitTest
{
    // attributes: test, testcase, testcasesource
    //ignore, category, onetimesetup, onetimeteardown
    //setup, teardown
    public class Tests
    {
        [SetUp]// calls before running each test
        public void T1()
        {
            //logic (are u admin or not)
        }
        [TearDown] // calls after running each teat method
        public void T2()
        {
            //do logging activity
        }
        [OneTimeSetUp]// calls before running test
        public void T3()
        {
            //database connection logic goes here
        }
        [OneTimeTearDown]//calls after the test is executed
        public void T4()
        {
            //close the database connection
        }
        // this is where unit testing happens
        // what to test?

        // how to do unit test?

        [Test]
        //[TestCase(10,10,20)] // parameterized test
        [TestCaseSource(nameof(MyCombination))]
        public void Test1(int a, int b , int c)
        {// how to test add metho?
            // step-1 Arrange
            //Keeping objects and required parameter ready
            // whatever its required to test Add Keep everything ready
            MyMath ob = new MyMath();
            //int a = 5;
            //int b = 6;
            //step-2 Act
            //Executes add method and retreive the result
            int result = ob.Add(a, b);
            //step-3 Assert
            //i am expecting output as 11
            //whether program will return same output or not
            Assert.That(result, Is.EqualTo(20));// it always takes 2 parameters
            // this method is to create to Test add method
        }
        private static object[] MyCombination =
            {
     new object[] { 1, 2, 3 },
     new object[] { 4, 5,9 },
     new object[] { 6, 7,13 },
     new object[] { 8, 9,17 }
    };
        //static IEnumerable<object[]> GetDataFromCsv()
        //{
        //    foreach (var line in File.ReadAllLines(""))
        //    {
        //        var parts = line.Split(',');
        //        yield return new object[]
        //        {
        // int.Parse(parts[0]),
        // int.Parse(parts[1]),
        // int.Parse(parts[2])
        //        };
        //    }
        //}

        [Test]
        [Ignore("not yet ready....")]
        public void Test2()
        {
            // this method is created to test Multiply method


            MyMath ob = new MyMath();
            int a = 5;
            int b = 10;

            int result = ob.Multiply(a, b);

            Assert.That(result, Is.EqualTo(50));
        } 
    }
}
