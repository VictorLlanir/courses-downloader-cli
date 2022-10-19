using CommandLine.Text;
using CommandLine;
using CoursesDownloader.Cli.Core.Enums;

namespace CoursesDownloader.Cli.Core.Models
{
    public class DownloadModel
    {
        public DownloadModel(ECourse courseType, string username, string password, string lectureId, bool convert = false, EFormat? format = null)
        {
            CourseType = courseType;
            Username = username;
            Password = password;
            LectureId = lectureId;
            Convert = convert;
            Format = format;
        }

        public ECourse CourseType { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string LectureId { get; set; }
        public bool Convert { get; set; }
        public EFormat? Format { get; set; }
    }
}
