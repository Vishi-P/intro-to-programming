using Alba;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using References.Api.Links;

namespace References.Tests.Links;

public class AddingAllLinks
{
    [Fact]
    public async Task CanAddLink()
    {
        var linkToAdd = new LinkCreateRequest("https://www.github.com", "Source control Hub");
        var host = await AlbaHost.For<Program>();

        var postResponse = await host.Scenario(api =>
        {
            api.Post.Json(linkToAdd).ToUrl("/links");
            api.StatusCodeShouldBeOk();
        });

        Assert.NotNull(postResponse);

        var postEntityResponse = postResponse.ReadAsJson<LinkEntity>();

        Assert.NotNull(postEntityResponse);

        Assert.Equal(linkToAdd.Href, postEntityResponse.Href);
        Assert.Equal(linkToAdd.Description, postEntityResponse.Description);

        var getResponse = await host.Scenario(api =>
        {
            api.Get.Url("/links");
        });

        var getResponseBody = getResponse.ReadAsJson<LinkEntity>();

        Assert.NotNull(getResponseBody);
        Assert.Contains(getResponseBody, postEntityResponse);

    }
}
