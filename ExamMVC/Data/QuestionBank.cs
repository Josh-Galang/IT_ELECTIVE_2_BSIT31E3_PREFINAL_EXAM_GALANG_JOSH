using ExamMVC.Models;

namespace ExamMVC.Data
{
    /// <summary>
    /// In-memory answer key for the IT Elective 2 Prefinal Examination.
    /// No database is used — questions are appended here one at a time.
    /// </summary>
    public static class QuestionBank
    {
        public static List<Question> GetAll() => new()
        {
            new Question
            {
                Number = 1,
                Text = "What is the main problem solved by using a database instead of an in-memory collection?",
                Options = new List<Option>
                {
                    new Option { Letter = "A", Text = "It makes C# code shorter" },
                    new Option { Letter = "B", Text = "It prevents the application from restarting" },
                    new Option { Letter = "C", Text = "It allows data to persist after the application stops" },
                    new Option { Letter = "D", Text = "It removes the need for MVC" }
                },
                CorrectLetter = "C",
                Explanation = "A database keeps data around after the application stops, unlike an in-memory collection which is lost when the app ends."
            },
            new Question
            {
                Number = 2,
                Text = "Which approach is being used when an existing database is used to generate EF Core entity classes?",
                Options = new List<Option>
                {
                    new Option { Letter = "A", Text = "Code-First" },
                    new Option { Letter = "B", Text = "Database-First" },
                    new Option { Letter = "C", Text = "Model-First" },
                    new Option { Letter = "D", Text = "Controller-First" }
                },
                CorrectLetter = "B",
                Explanation = "Generating entity classes FROM an existing database is the Database-First approach."
            },
            new Question
            {
                Number = 3,
                Text = "What is the primary purpose of Entity Framework Core?",
                Options = new List<Option>
                {
                    new Option { Letter = "A", Text = "To create HTML pages automatically" },
                    new Option { Letter = "B", Text = "To replace the MVC Controller" },
                    new Option { Letter = "C", Text = "To map objects in code to relational database data" },
                    new Option { Letter = "D", Text = "To replace the C# compiler" }
                },
                CorrectLetter = "C",
                Explanation = "EF Core is an ORM: it maps C# objects to rows/tables in a relational database."
            },
            new Question
            {
                Number = 4,
                Text = "Which EF Core component is primarily responsible for communicating with the database?",
                Options = new List<Option>
                {
                    new Option { Letter = "A", Text = "DbContext" },
                    new Option { Letter = "B", Text = "DbSetView" },
                    new Option { Letter = "C", Text = "ControllerContext" },
                    new Option { Letter = "D", Text = "RazorContext" }
                },
                CorrectLetter = "A",
                Explanation = "DbContext manages the connection, tracks entities, and communicates with the database."
            },
            new Question
            {
                Number = 5,
                Text = "What does the following command primarily do?\ndotnet ef dbcontext scaffold \"ConnectionString\" Microsoft.EntityFrameworkCore.SqlServer -o Models",
                Options = new List<Option>
                {
                    new Option { Letter = "A", Text = "Deletes the database" },
                    new Option { Letter = "B", Text = "Creates a new MVC project" },
                    new Option { Letter = "C", Text = "Generates EF Core models and a DbContext from an existing database" },
                    new Option { Letter = "D", Text = "Starts the MVC application" }
                },
                CorrectLetter = "C",
                Explanation = "The 'dbcontext scaffold' command reverse-engineers an existing database into EF Core model classes and a DbContext."
            },
            new Question
            {
                Number = 6,
                Text = "Where is a database connection string commonly stored in an ASP.NET Core MVC application?",
                Options = new List<Option>
                {
                    new Option { Letter = "A", Text = "Program.cs only" },
                    new Option { Letter = "B", Text = "appsettings.json" },
                    new Option { Letter = "C", Text = "Index.cshtml" },
                    new Option { Letter = "D", Text = "Student.cs" }
                },
                CorrectLetter = "B",
                Explanation = "Connection strings are conventionally stored in appsettings.json under a \"ConnectionStrings\" section."
            },
            new Question
            {
                Number = 7,
                Text = "A Student belongs to exactly one Section, while a Section can contain many students. What type of relationship is this?",
                Options = new List<Option>
                {
                    new Option { Letter = "A", Text = "One-to-One" },
                    new Option { Letter = "B", Text = "One-to-Many" },
                    new Option { Letter = "C", Text = "Many-to-Many" },
                    new Option { Letter = "D", Text = "Many-to-One only" }
                },
                CorrectLetter = "B",
                Explanation = "One Section relates to many Students, which is the definition of a One-to-Many relationship."
            },
            // Questions are added incrementally, one per commit.
        };
    }
}
