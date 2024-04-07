using Newtonsoft.Json;

internal class GovApiWrapper : IDisposable
{
    private readonly HttpClient _httpClient;
    private readonly string _baseUri;
    private bool _disposed;

    public GovApiWrapper(string baseUri)
    {
        _httpClient = new HttpClient();
        _baseUri = baseUri;
        _disposed = false;
    }

    public async Task<T> GetAsync<T>(string endpoint)
    {
        CheckDisposed();
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
        CheckDisposed();
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

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                // Dispose managed resources
                _httpClient.Dispose();
            }

            // Dispose unmanaged resources

            _disposed = true;
        }
    }

    private void CheckDisposed()
    {
        if (_disposed)
        {
            throw new ObjectDisposedException(nameof(GovApiWrapper), $"The {this.GetType().Name} object has been disposed.");
        }
    }
}
