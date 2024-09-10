
using Microsoft.VisualBasic;

class Program {
    static void Main(string[] args) {
        PlayGame();
        
    }


    class Question{
        public string Text{get; set;}
        public string[] Options{get; set;}
        public char CorrectAnswer{get; set;}

        public Question (string text, string[] options, char correctAnswer) {
            Text = text;
            Options = options;
            correctAnswer = CorrectAnswer;
        }
    }

    static void PlayGame() {
        List<Question> questions = new List<Question> {
            new Question("Vad är Tysklands huvudstad?", new string[] { "a) Afrika", "b) Österike", "c) Berlin"}, 'c'),
            new Question("Vilken fotbollspelare är bäst", new string[] { "a) Ronaldo", "b) Messi", "c) Elis"}, 'b'),
            new Question("Bästa FPS Shooter spelet", new string[] { "a) Counter-Strike", "b) Pubg", "c) Fortnite"}, 'a'),
        };
        
        int points = 0;

        foreach(var question in questions) {

        }

    }

    static bool AskQuestion(Question question) {
        Console.WriteLine(question.Text);
        foreach(var option in question.Options){
            Console.WriteLine(option);
        }

        char answer = GetValidAnswer();
        return answer == question.CorrectAnswer;

    }

    static char GetValidAnswer() {

    }
    
}


