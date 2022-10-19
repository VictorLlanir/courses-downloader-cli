namespace CoursesDownloader.Cli.Core.Services
{
    public interface IFileService
    {
        void SaveFileToFormat(string filePath, byte[] fileContent, string fileFormat);
        void DeleteFile(string filePath);
    }
}
