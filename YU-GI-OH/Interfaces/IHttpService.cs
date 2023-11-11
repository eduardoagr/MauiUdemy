namespace YU_GI_OH.Interfaces {
    public interface IHttpService {

        Task<T> GetAsync<T>(string url);
        Task<byte[]> GetByteArrayAsync(string url);
    }
}
