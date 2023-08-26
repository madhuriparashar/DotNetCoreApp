using CoreWebAPIAzure;
using CoreWebAPIAzure.Controllers;
using Xunit;

namespace CoreWebAPIAzure.Test;
//Unit Test
public class UnitTest1
{

    ValuesController valController = new ValuesController();        //Arrange
    [Fact]  // Arrange, Act, Assert
    public void Test1()
    {   
        var test = valController.Get(1);                            //Act
        Assert.Equal("Yukti", test);
    }
}