namespace CoursesDownloader.Cli.Core.Services
{
    public interface IConvertService
    {
        void ConvertFileToFormat(string filePath, string fileFormat);
    }
}
