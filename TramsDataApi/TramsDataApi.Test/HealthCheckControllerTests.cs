using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using Xunit;

namespace TramsDataApi.Test
{
    public class HealthCheckControllerTests : IClassFixture<WebApplicationFactory<TramsDataApi.Startup>>
    {
        private readonly HttpClient _client;

        public HealthCheckControllerTests(WebApplicationFactory<TramsDataApi.Startup> fixture)
        {
            _client = fixture.CreateClient();
            _client.BaseAddress = new Uri("https://trams-api.com/");
        }
        
        [Fact] public async Task Should_Get_401_Status_When_Not_Using_Correct_Api_Key()
        {
            var httpRequestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://trams-api.com/HealthCheck"),
                Headers = { 
                    { "ApiKey", "Incorrect Key" }
                }
            };
            
            var response = await _client.SendAsync(httpRequestMessage);
            
            response.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
        }

        [Fact] public async Task Should_Get_200_Status_When_Using_Correct_Api_Key()
        {
            var httpRequestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://trams-api.com/HealthCheck"),
                Headers = { 
                    { "ApiKey", "e5de93fa-0889-4b55-87cd-f5ffb4d3098b" }
                }
            };
            
            var response = await _client.SendAsync(httpRequestMessage);
            
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}