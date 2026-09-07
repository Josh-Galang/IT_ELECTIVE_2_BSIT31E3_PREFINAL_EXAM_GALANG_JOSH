# Galang, Josh
**Class:** IT Elective 2 – Web System and Technologies &nbsp;|&nbsp; **Section:** BSIT31E3

---

## IT_ELECTIVE_2_BSIT31E3_PREFINAL_EXAM_GALANG_JOSH

An ASP.NET Core MVC application that presents the Prefinal Examination
(20-item multiple choice) as an interactive, exam-styled web page —
each question is shown together with the chosen answer and a short
explanation of why it's correct. No database is used; all exam data
lives in-memory in `Data/QuestionBank.cs`.

### Tech stack
- ASP.NET Core MVC (.NET 8)
- Razor Views
- Plain CSS (no external UI framework) — custom "exam paper" theme

### Project structure
```
ExamMVC/
├── Controllers/
│   └── HomeController.cs      # Loads the question bank and passes it to the view
├── Models/
│   └── Question.cs            # Question model (number, text, options, answer, explanation)
├── Data/
│   └── QuestionBank.cs        # In-memory list of all 20 questions & answers
├── Views/
│   ├── Home/Index.cshtml      # Renders every question as an answer-key card
│   └── Shared/_Layout.cshtml  # Page layout / header
└── wwwroot/css/site.css       # Custom styling
```

### Running the app
```bash
cd ExamMVC
dotnet run
```
Then open the URL shown in the console (e.g. `http://localhost:5000`).

### How this repo was built
Every exam item was added and committed individually — commit history
reflects each of the 20 questions being answered one at a time, on top
of the initial project scaffold.
