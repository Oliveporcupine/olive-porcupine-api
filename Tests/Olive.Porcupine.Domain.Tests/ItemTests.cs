using Olive.Porcupine.Domain.Catalog;

namespace Olive.Porcupine.Domain.Tests;

[TestClass]
public class ItemTests
{
    [TestMethod]
    public void Can_Create_New_Item()
    {
        //Aranage
        var item = new Item("Name", "Description", "Brand", 10.00m);

        // Act (empty)

        //Assert
        Assert.AreEqual("Name", item.Name);
        Assert.AreEqual("Description", item.Description);
        Assert.AreEqual("Brand", item.Brand);
        Assert.AreEqual(10.00m, item.Price);
    }
    
}