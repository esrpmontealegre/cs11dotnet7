namespace EarlClass.IntegrationTests.Controllers
{
    public class EarlControllerTest
    {
        public class Get : EarlControllerTest
        {
            [Fact]
            public void MustReturnExpectedSTR()
            {
                //Arrange
                var st = new EarlController();

            //Act
            var res = st.Get();
            //Assert
            Assert.Collection(res.Value,x => Assert.Equal("val1",x), x => Assert.Equal("val2",x));



            }
        }
    }
}