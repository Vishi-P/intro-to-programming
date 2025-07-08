using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References.Tests.Links;

internal class GettingAllLinks
{
    [Fact]
    public async Task GettingLinksReturnsA200Ok()
    {
        // GET /links
        var client = new HttpClient();
        client.BaseAddress = new Uri("http://localhost:1337");

        var response = await client.GetAsync("/links");
        Assert.NotNull(response);

        Assert.Equal(System.Net.Http.HttpStatusCode.OK, response.StatusCode);
    }
}