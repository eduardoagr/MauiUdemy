namespace YU_GI_OH.Services;
public class HttpService(HttpClient client) : IHttpService {
    public async Task<T> GetAsync<T>(string url) {

        try {

            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode) {

                var json = await response.Content.ReadAsStringAsync();
                Debug.WriteLine($"Received JSON: {json}");

                var data = await response.Content.ReadFromJsonAsync<T>();
                return data;
            }
        } catch (Exception e) {

            Debug.WriteLine(e.Message);
        }
        return default;
    }


    public async Task<byte[]> GetByteArrayAsync(string url) {

        try {

            using var res = await client.GetAsync(url);
            if (res.IsSuccessStatusCode) {
                using var stream = await res.Content.ReadAsStreamAsync();
                using var memoryStream = new MemoryStream();
                await stream.CopyToAsync(memoryStream);
                return memoryStream.ToArray();
            }
        } catch (Exception e) {
            Debug.WriteLine(e.Message);
        }

        return default;
    }
}

