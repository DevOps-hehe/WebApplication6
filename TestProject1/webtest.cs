using WebApplication6.NewFolder;

namespace TestProject1
{
    public class webtest
    {
        [Fact]
        public void DemoTest()
        {
            int i = 1;
            bool result = false;
            if (i == 1) result = true;
            Assert.True(result, "value shhould be equal to 1");
        }


        [Fact]

        public void CheckAddFunction()
        {
            Functions func = new Functions();
            int y = func.Add(3, 2);

            bool result = false;

            if (y == 5) result = true;

            Assert.True(result, "value should be equal to 5");

        }
    }
}