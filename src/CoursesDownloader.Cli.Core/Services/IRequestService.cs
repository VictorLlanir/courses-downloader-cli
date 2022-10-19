namespace CoursesDownloader.Cli.Core.Services
{
    public interface IRequestService
    {
        Task<T> MakeRequest<T>(HttpRequestMessage message) where T : class;
    }
}
