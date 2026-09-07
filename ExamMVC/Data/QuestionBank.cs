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
            // Questions are added incrementally, one per commit.
        };
    }
}
