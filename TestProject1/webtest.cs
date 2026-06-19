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
    }
}