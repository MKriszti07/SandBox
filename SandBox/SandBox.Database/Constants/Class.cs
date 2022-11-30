using Microsoft.Extensions.Logging;

namespace SandBox.Database.Constants
{
    public class Class
    {
        private readonly ILogger<Class> _logger;

        private static readonly Lazy<Class> _instance
            = new(() => {
                var loggerFactory = new LoggerFactory();
                var logger = new Logger<Class>(loggerFactory);
                return new Class(logger);
            });

        private Class(ILogger<Class> logger)
        {
            _logger = logger;
        }

        public static Class Instance => _instance.Value;

        //public static IEnumerable<ClassType> ClassTypes { get; } = 
        //    Enum.GetValues(typeof(ClassType)).Cast<ClassType>().Select(x => x.GetGradeOneNumberName());

        //public static IEnumerable<string> GradesAsOneNumber { get; } =
        //    Enum.GetValues(typeof(Grade)).Cast<Grade>().Select(x => x.GetGradeOneNumberName());
    }
}
