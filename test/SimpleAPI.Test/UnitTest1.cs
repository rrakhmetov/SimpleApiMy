namespace SimpleAPI.Test;

using Microsoft.AspNetCore.Mvc;
using SimpleAPI.Controllers;

public class UnitTest1
{
    ValuesController controller = new ValuesController();
    [Fact]
    public void GetReturnsMyName() {
        var returnValue = controller.Get(1);
        Assert.Equal("my stuff", returnValue.Value);
    }

    [Fact]
    public void Test1()
    {

    }
}