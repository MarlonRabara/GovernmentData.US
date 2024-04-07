using Newtonsoft.Json;

internal class GovApiWrapper
{
    private readonly HttpClient _httpClient;
    private readonly string _baseUri;

    public GovApiWrapper(string baseUri)
    {
        _httpClient = new HttpClient();
        _baseUri = baseUri;
    }

    public async Task<T> GetAsync<T>(string endpoint)
    {
        try
        {
            var response = await _httpClient.GetAsync(new Uri(_baseUri + endpoint));
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            if (string.IsNullOrEmpty(content))
            {
                return default(T);
            }
            return JsonConvert.DeserializeObject<T>(content);
        }
        catch (HttpRequestException e)
        {
            // Log the exception message and rethrow, or handle the exception based on your application's needs
            Console.WriteLine($"Request exception: {e.Message}");
            throw;
        }
        catch (Exception e)
        {
            // This will catch any other exceptions
            Console.WriteLine($"Unexpected error: {e.Message}");
            throw;
        }
    }

    public async Task PostAsync<T>(string endpoint, T data)
    {
        try
        {
            var content = new StringContent(JsonConvert.SerializeObject(data), System.Text.Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(new Uri(_baseUri + endpoint), content);
            response.EnsureSuccessStatusCode();
        }
        catch (HttpRequestException e)
        {
            // Log the exception message and rethrow, or handle the exception based on your application's needs
            Console.WriteLine($"Request exception: {e.Message}");
            throw;
        }
        catch (Exception e)
        {
            // This will catch any other exceptions
            Console.WriteLine($"Unexpected error: {e.Message}");
            throw;
        }
    }

    // Similarly, you can implement PutAsync, DeleteAsync etc.
}
