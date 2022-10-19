using CoursesDownloader.Cli.Core.Models;

namespace CoursesDownloader.Cli.Core.Services
{
    public interface IDownloadService
    {
        Task<byte[]> Download(DownloadModel downloadModel);
    }
}
