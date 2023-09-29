using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Net.Http.Json;

namespace Earl.IntegrationTest.Controllers;

public class EarlControllerTest:IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient _httpClient;
    public EarlControllerTest(WebApplicationFactory<Program> webApplicationFactory)
    {
        _httpClient= webApplicationFactory.CreateHttpClient();  
    }

    public class Get : EarlControllerTest
    {
        public Get(WebApplicationFactory<Program> webApplicationFactory):base(webApplicationFactory)
        {

        }

        [Fact]

        public async Task Must_respond_a_status_200_OK()
        {
            var result = await _httpClient.GetAsync("/api/earl");

            Assert.Equal(HttpStatusCode.OK, result.StatusCode);
        }

        [Fact]

        public async Task Must_respond_the_expected_strings()
        {
            var result = await _httpClient.GetFromJsonAsync<string[]>("/api/earl");
            Assert.Collection(result, x => Assert.Equal("val1", x), x => Assert.Equal("val2", x));
        }



    }
    
}