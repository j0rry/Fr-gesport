

using System.Formats.Asn1;

class Program {
    static void Main(string[] args) {
        System.Console.WriteLine("Frågesport!\n\nKlicka ENTER för att börja");
        Console.ReadLine();
        PlayGame();
    }

    class Question{ // Frågor hantering
        public string Text{get; set;}
        public string[] Options{get; set;}
        public char CorrectAnswer{get; set;}

        public Question (string text, string[] options, char correctAnswer) {
            Text = text;
            Options = options;
            CorrectAnswer = correctAnswer;
        }
    }

    static void PlayGame() {
        List<Question> questions = new List<Question> { // Frågor
            new Question("Vad är Tysklands huvudstad?", new string[] { "a) Afrika", "b) Österike", "c) Berlin"}, 'c'),
            new Question("Vilken fotbollspelare är bäst", new string[] { "a) Ronaldo", "b) Messi", "c) Elis"}, 'b'),
            new Question("Bästa FPS Shooter spelet", new string[] { "a) Counter-Strike", "b) League Of Legends", "c) Fortnite"}, 'a'),
            new Question("Hur många tidszoner finns i Ryssland?", new string[] { "a) 13", "b) 11", "c) 9"}, 'b'),
            new Question("Vad är Japans nationalblomma?", new string[] { "a) körsbärsblomma", "b) Solros", "c) ogräs"}, 'a'),
        };
        
        int points = 0;

        foreach(var question in questions) { // Loopa igenom frågorna
            if(AskQuestion(question)){
                points++;
            } else {
                points--;
            }
        }
        System.Console.WriteLine(ascii1());
        System.Console.WriteLine($"Du fick {points}/{questions.Count} poäng! \n \nTryck ENTER för att köra om!");
        Console.ReadLine();
        PlayGame();
    }

    static bool AskQuestion(Question question) { // Fråga spelaren
        Console.Clear();
        Console.WriteLine(question.Text);
        foreach(var option in question.Options){
            System.Console.WriteLine(option);  
        }

        char answer = GetInput();
        return answer == question.CorrectAnswer; // Om svaret är rätt returnera true
    }

    static char GetInput() { // Spelarens svar
        char answer;
        while(true){
            Console.Write("Svar: ");
            string input = Console.ReadLine().ToLower() ?? string.Empty;
            if(input.Length == 1 && "abc".Contains(input)){
                answer = input[0];
                break;
            } else {
                System.Console.WriteLine("Felaktigt svar, försök igen.");
            }
        }
        return answer;
    }

    static void RandomOrder<T>(List<T> questions){ // ändra list ordningen
        Random random = new Random();
        int n = questions.Count;
        while(n > 1){
            n--;
            int i = random.Next(n + 1);
            // Fortsätta Nästa lektion Ändra list ordningen
            // ...
        }
    }

    static string ascii1(){
        return """
                                |
                            \       /
                              .-"-.
                         --  /     \  --
        `~~^~^~^~^~^~^~^~^~^-=======-~^~^~^~~^~^~^~^~^~^~^~`
        `~^_~^~^~-~^_~^~^_~-=========- -~^~^~^-~^~^_~^~^~^~`
        `~^~-~~^~^~-^~^_~^~~ -=====- ~^~^~-~^~_~^~^~~^~-~^~`
        `~^~^~-~^~~^~-~^~~-~^~^~-~^~~^-~^~^~^-~^~^~^~^~~^~-`
        """;
    }
}


