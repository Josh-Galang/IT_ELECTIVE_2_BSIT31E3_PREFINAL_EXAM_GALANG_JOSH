namespace ExamMVC.Models
{
    public class Question
    {
        public int Number { get; set; }
        public string Text { get; set; } = string.Empty;
        public List<Option> Options { get; set; } = new();
        public string CorrectLetter { get; set; } = string.Empty;
        public string Explanation { get; set; } = string.Empty;
    }

    public class Option
    {
        public string Letter { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;
    }
}
