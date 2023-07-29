using KlaviyoSharp.Models;
using KlaviyoSharp.Models.Filters;

namespace KlaviyoSharp.Tests;

/// <summary>
/// Klaviyo API Client Tests. Only tests the /client endpoints.
/// </summary>
[Trait("Category", "ClientServices")]
public class ClientServices_Tests : IClassFixture<ClientServices_Tests_Fixture>
{
    private ClientServices_Tests_Fixture Fixture { get; }
    public ClientServices_Tests(ClientServices_Tests_Fixture fixture)
    {
        Fixture = fixture;
    }

    [Fact]
    public async Task CreateEvent()
    {
        var profile = (await Fixture.AdminApi.ProfileServices.GetProfiles()).Data.First();
        var newEvent = EventRequest.Create();
        Profile profile1 = Profile.Create();
        profile1.Attributes = new() { Email = profile.Attributes.Email };
        var metric = Metric.Create();
        metric.Attributes = new() { Name = "C# Test" };
        newEvent.Attributes = new()
        {
            Profile = new(profile1),
            Metric = new(metric),
            Time = DateTime.Now,
            Value = 12.99,
            UniqueId = Guid.NewGuid().ToString(),
            Properties = new() { { "test", "test" } }
        };

        Fixture.ClientApi.ClientServices.CreateEvent(newEvent).Wait();
        Assert.True(true);
    }

    [Fact]
    public void CreateSubscription()
    {
        //Get Sample Data List ID
        string _listId = Fixture.AdminApi.ListServices.GetLists(new() { "id" }, new Filter(FilterOperation.Equals, "name", "Sample Data List")).Result.Data.First().Id;
        Debug.WriteLine(_listId);
        var profile = Profile.Create();
        profile.Attributes = new() { Email = "test@test.com" };
        var newSubscription = Models.ClientSubscription.Create();
        newSubscription.Attributes = new()
        {
            CustomSource = "C# Test",
            Profile = new(profile)
        };
        newSubscription.Relationships = new()
        {
            List = new(new() { Type = "list", Id = _listId })
        };
        Fixture.ClientApi.ClientServices.CreateSubscription(newSubscription).Wait();
        Assert.True(true);
    }

    [Fact]
    public void UpsertProfile()
    {
        var newProfile = Models.ClientProfile.Create();

        newProfile.Attributes = new()
        {
            Id = "01H42N4KX4N2NV2CT2595KCG6Z",
            Email = "test@test.com",
            FirstName = "Test",
            LastName = "Profile",
            ExternalId = "TestAccount",
            Organization = "Test Organization",
            Title = "Test Title",
            ImageUrl = "https://dummyimage.com/300",
            Location = new()
            {
                Address1 = "1 Main St",
                Address2 = "Suite 101",
                Latitude = 42.35843,
                Longitude = -71.05977,
                Timezone = "America/New_York",
                City = "Boston",
                Region = "MA",
                Country = "USA",
                Zip = "02110"
            },
            Properties = new() { { "Last Test", DateTime.Now.ToString() } }
        };

        Fixture.ClientApi.ClientServices.UpsertProfile(newProfile).Wait();
        Assert.True(true);
    }
}

public class ClientServices_Tests_Fixture : IAsyncLifetime
{
    public KlaviyoClientApi ClientApi { get; } = new(Config.CompanyId);
    public KlaviyoAdminApi AdminApi { get; } = new(Config.ApiKey);
    public Task DisposeAsync()
    {
        return Task.CompletedTask;
    }

    public Task InitializeAsync()
    {
        return Task.CompletedTask;
    }
}