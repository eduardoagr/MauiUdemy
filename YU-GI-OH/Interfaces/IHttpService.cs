namespace YU_GI_OH.Interfaces {
    public interface IHttpService {

        Task<object> GetAsync(string url);
        Task<byte[]> GetByteArrayAsync(string url);
    }
}
