using RestSharp;

namespace eva01_radar.ApiRequest;

public class Request : IRequest
{
    private const string BaseUrl = "https://feeds.meteoalarm.org/api/v1/";
    
    public string Get()
    {
        try
        {
            RestClientOptions options = new(BaseUrl)
            {
                ThrowOnAnyError = true
            };
            
            RestClient client = new(options);
            RestRequest request = new("warnings/feeds-poland/");

            string response = client.Execute(request).Content;
            
            if (response == null)
            {
                throw new Exception("Response is null");
            }

            return response;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}