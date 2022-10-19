using CommandLine;
using CoursesDownloader.Cli.Core.Enums;

namespace CoursesDownloader.Cli.Core.Commands
{
    [Verb("download", aliases: new[] { "d" }, HelpText = "Faz o download da aula de um curso específico")]
    public sealed class DownloadCommand
    {
        [Option('c', "course", HelpText = "Curso cuja aula será baixada. Pode ser COF ou ICLS.", Required = true)]
        public ECourse CourseType { get; set; }
        [Option('u', "username", HelpText = "Usuário a ser autenticado.", Required = true)]
        public string Username { get; set; }
        [Option('p', "password", HelpText = "Senha para a autenticação", Required = true)]
        public string Password { get; set; }
        [Option("lecture", HelpText = "ID da aula a ser baixada", Required = true)]
        public string LectureId { get; set; }
        [Option("convert", HelpText = "Indica se a aula baixada deve ser convertida após o download")]
        public bool Convert { get; set; }
        [Option("format", HelpText = "Indica para qual formato a aula baixada deve ser convertida")]
        public EFormat? Format { get; set; }
    }
}
