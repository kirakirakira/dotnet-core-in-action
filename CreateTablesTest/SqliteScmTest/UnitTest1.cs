using Xunit;
using System.Linq;
using WidgetScmDataAccess;

namespace SqliteScmTest;

public class UnitTest1 : IClassFixture<SampleScmDataFixture>
{
    private SampleScmDataFixture fixture;
    private ScmContext context;
    public UnitTest1(SampleScmDataFixture fixture)
    {
        this.fixture = fixture;
        this.context = new ScmContext(fixture.Connection);
    }

    [Fact]
    public void Test1()
    {
        var parts = context.Parts;
        Assert.Single(parts);

        var part = parts.First();
        Assert.Equal("8289 L-shaped plate", part.Name);

        var inventory = context.Inventory;
        Assert.Single(inventory);

        var item = inventory.First();
        Assert.Equal(part.Id, item.PartTypeId);
        Assert.Equal(100, item.Count);
        Assert.Equal(10, item.OrderThreshold);
    }

    [Fact]
    public void Test2()
    {
    }
}
