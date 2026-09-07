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
            new Question
            {
                Number = 8,
                Text = "In the following example, what is SectionId?\npublic int SectionId { get; set; }\npublic Section Section { get; set; }",
                Options = new List<Option>
                {
                    new Option { Letter = "A", Text = "Primary key of Student" },
                    new Option { Letter = "B", Text = "Foreign key referencing Section" },
                    new Option { Letter = "C", Text = "Navigation property" },
                    new Option { Letter = "D", Text = "Database connection string" }
                },
                CorrectLetter = "B",
                Explanation = "SectionId is the scalar property that links a Student row to its related Section row — a foreign key."
            },
            new Question
            {
                Number = 9,
                Text = "What is the purpose of a navigation property such as public Section Section { get; set; }?",
                Options = new List<Option>
                {
                    new Option { Letter = "A", Text = "It stores the database password" },
                    new Option { Letter = "B", Text = "It represents a relationship to another entity" },
                    new Option { Letter = "C", Text = "It creates a new database" },
                    new Option { Letter = "D", Text = "It validates the student's name" }
                },
                CorrectLetter = "B",
                Explanation = "A navigation property lets you access the related entity object directly, representing the relationship in code."
            },
            new Question
            {
                Number = 10,
                Text = "What does .Include() generally allow EF Core to do?",
                Options = new List<Option>
                {
                    new Option { Letter = "A", Text = "Delete the Section table" },
                    new Option { Letter = "B", Text = "Load related Section data together with Students" },
                    new Option { Letter = "C", Text = "Create a new Student" },
                    new Option { Letter = "D", Text = "Validate Student input" }
                },
                CorrectLetter = "B",
                Explanation = ".Include() performs eager loading, pulling in related entity data (like Section) along with the main query."
            },
            new Question
            {
                Number = 11,
                Text = "Why might a ViewModel be used when displaying Student and Section information?",
                Options = new List<Option>
                {
                    new Option { Letter = "A", Text = "To replace the database" },
                    new Option { Letter = "B", Text = "To combine or shape the data specifically needed by the view" },
                    new Option { Letter = "C", Text = "To automatically create database tables" },
                    new Option { Letter = "D", Text = "To prevent controllers from using LINQ" }
                },
                CorrectLetter = "B",
                Explanation = "A ViewModel tailors and combines exactly the fields a view needs, decoupled from the raw entity shape."
            },
            new Question
            {
                Number = 12,
                Text = "Consider this query:\nvar students = _context.Students.Include(s => s.Section).ToList();\nWhat is the main benefit of Include(s => s.Section)?",
                Options = new List<Option>
                {
                    new Option { Letter = "A", Text = "It loads the related Section navigation property" },
                    new Option { Letter = "B", Text = "It creates a Section object manually" },
                    new Option { Letter = "C", Text = "It removes the foreign key" },
                    new Option { Letter = "D", Text = "It prevents the query from accessing the database" }
                },
                CorrectLetter = "A",
                Explanation = "Include(s => s.Section) eagerly loads each Student's related Section so it's populated without extra queries."
            },
            new Question
            {
                Number = 13,
                Text = "Which type of validation occurs in the browser before a request is sent to the server?",
                Options = new List<Option>
                {
                    new Option { Letter = "A", Text = "Database-level validation" },
                    new Option { Letter = "B", Text = "Client-side validation" },
                    new Option { Letter = "C", Text = "Server-side validation" },
                    new Option { Letter = "D", Text = "EF Core migration validation" }
                },
                CorrectLetter = "B",
                Explanation = "Client-side validation runs in the browser (e.g., via JavaScript) before the form is submitted to the server."
            },
            new Question
            {
                Number = 14,
                Text = "Why is server-side validation still necessary if client-side validation exists?",
                Options = new List<Option>
                {
                    new Option { Letter = "A", Text = "Client-side validation can be bypassed" },
                    new Option { Letter = "B", Text = "Client-side validation automatically modifies the database" },
                    new Option { Letter = "C", Text = "Server-side validation only works with SQLite" },
                    new Option { Letter = "D", Text = "Client-side validation cannot display messages" }
                },
                CorrectLetter = "A",
                Explanation = "Client-side checks can be disabled or bypassed, so the server must re-validate to protect data integrity."
            },
            new Question
            {
                Number = 15,
                Text = "A school requires every student to have a unique Student Number. Which rule best represents this requirement?",
                Options = new List<Option>
                {
                    new Option { Letter = "A", Text = "Student Number should always be nullable" },
                    new Option { Letter = "B", Text = "Student Number should be unique" },
                    new Option { Letter = "C", Text = "Student Number should always be the same" },
                    new Option { Letter = "D", Text = "Student Number should contain only spaces" }
                },
                CorrectLetter = "B",
                Explanation = "The requirement directly translates to a uniqueness constraint on Student Number."
            },
            new Question
            {
                Number = 16,
                Text = "Which is the best reason for having a database-level unique constraint on StudentNumber?",
                Options = new List<Option>
                {
                    new Option { Letter = "A", Text = "It protects data integrity even if application-level validation is bypassed" },
                    new Option { Letter = "B", Text = "It makes Razor Views render faster" },
                    new Option { Letter = "C", Text = "It removes the need for a Controller" },
                    new Option { Letter = "D", Text = "It automatically creates a ViewModel" }
                },
                CorrectLetter = "A",
                Explanation = "A database-level constraint is the last line of defense, enforcing uniqueness even if app-level checks are skipped."
            },
            new Question
            {
                Number = 17,
                Text = "What is the purpose of a try...catch block in a controller?",
                Options = new List<Option>
                {
                    new Option { Letter = "A", Text = "To create navigation properties" },
                    new Option { Letter = "B", Text = "To catch and handle exceptions that may occur during execution" },
                    new Option { Letter = "C", Text = "To generate database tables" },
                    new Option { Letter = "D", Text = "To perform client-side validation" }
                },
                CorrectLetter = "B",
                Explanation = "try...catch lets the controller gracefully catch and handle runtime exceptions instead of crashing."
            },
            new Question
            {
                Number = 18,
                Text = "Which middleware is commonly used in ASP.NET Core for centralized exception handling?",
                Options = new List<Option>
                {
                    new Option { Letter = "A", Text = "UseDatabase()" },
                    new Option { Letter = "B", Text = "UseExceptionHandler()" },
                    new Option { Letter = "C", Text = "UseValidationHandler()" },
                    new Option { Letter = "D", Text = "UseMvcDatabase()" }
                },
                CorrectLetter = "B",
                Explanation = "UseExceptionHandler() is the built-in middleware for centralized, app-wide exception handling."
            },
            // Questions are added incrementally, one per commit.
        };
    }
}
