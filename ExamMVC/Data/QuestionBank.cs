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
            // Questions are added incrementally, one per commit.
        };
    }
}
