namespace Demo
{
    using System;
    public class Test : BaseTest, ITest, INewTest
    {
        public void NewTestMethod()
        {
            throw new NotImplementedException();
        }

        public void TestMethod(int number)
        {
            throw new System.NotImplementedException();
        }

        public string TestWriter()
        {
            throw new System.NotImplementedException();

        }
    }
}