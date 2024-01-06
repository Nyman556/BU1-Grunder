namespace grunder;

class Program
{
    static void Main(string[] args)
    {
        // Övning1();
        // Övning2();
        // Övning3();
        // Övning4();
        // Övning5();
        // Övning6();
        // Övning7();
        // Övning11();
        // Övning12();
        // övning13();
        
        static void Övning1() {
            string desc = "Hämta in text från konsolen med Console.ReadLine() och skriv sedan ut det med Console.WriteLine().";
            Console.WriteLine($"desc: {desc}");
            Console.Write("Input:");
            string? input = Console.ReadLine();
            Console.WriteLine(input);

        }

        static void Övning2() {
            string desc = "Hämta in två nummer med Console.ReadLine() och addera dem. Skriv ut resultatet i konsolen.";
            Console.WriteLine($"desc: {desc}");
            Console.Write("Input:");
            int? input = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input2:");
            int? input2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(input + input2);

        }

        static void Övning3() {
            string desc = "Skriv ett program som kan summera X antal nummer. Du väljer hur många tal med den första inputten. Skriv ut summan i konsolen.";
            Console.WriteLine($"desc: {desc}");
            Console.Write("X antal nummer:");
            int? count = Convert.ToInt32(Console.ReadLine());
            int total = 0;
            List<int> numbers = new List<int>();
            for(byte i = 0; i < count; i++) {
                Console.Write("Nummer:");
                int number = Convert.ToInt32(Console.ReadLine());
                total = total + number;
                numbers.Add(number);
            }
            string numberStr = string.Join(" + ", numbers);
            Console.WriteLine($"{total} // {numberStr}");
        }

        static void Övning4() {
            string desc = "Programmet skall skriva följande till konsolen: <name> är <age> år gammal och <height>cm lång.";
            Console.WriteLine($"desc: {desc}");
            Console.Write("Namn:");
            string? name = Console.ReadLine();
            Console.Write("Ålder:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Längd:");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{name} är {age} år gammal och {height}cm lång");
        }

        static void Övning5() {
            string desc = "Skriv ett program som kan räkna matematik. Man skall kunna skriva in två tal i konsolen och sedan en operation så utförs den av programmet.";
            Console.WriteLine($"desc: {desc}");
            int input = Convert.ToInt32(Console.ReadLine());
            string? op = Console.ReadLine();
            int input2 = Convert.ToInt32(Console.ReadLine());
            if(op == "*"){
                Console.WriteLine(input * input2);
            } else if (op == "+") {
                Console.WriteLine(input + input2);
            } else if (op == "/") {
                Console.WriteLine(input / input2);
            } else if (op == "-") {
                Console.WriteLine(input - input2);
            }
        }

        static void Övning6() {
            string desc = "Hämta in text från konsolen och skriv ut 'Palindrom' om texten är en palindrom och 'Inte palindrom' om texten inte är en palindrom.";
            Console.WriteLine($"desc: {desc}");
            string? input = Console.ReadLine();
            char[] inputArr = input.ToCharArray();
            Array.Reverse(inputArr);
            string inputRev = new string(inputArr);
            if(input == inputRev) {
                Console.WriteLine("palindrom");
            } else {
                Console.WriteLine("Inte en palindrom");
            }
        }

        static void Övning7() {
            string desc = "Skriv ett program som kan räkna ut fakulteter (factorial) från konsol input.";
            Console.WriteLine($"desc: {desc}");
            Console.Write("Input:");
            long result = 1;
            int input = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= input; i++)
            {
                result *= i;
            }
        Console.WriteLine(result);
        }

        /* Övning 8
        Lösning:
        length = 3;
        i = 0 1 2

     length|i| -1
	    3 - 0 - 1 = 2 = C
	    3 - 1 - 1 = 1 = B
	    3 - 2 - 1 = 0 = A

        Alltså blir det C, B, A
        */

        /* Övning 9
        Det bör inte funka då age ska vara en int och inte en sträng.
        */

        /* Övning 10
        Ironman is so cute! Cats are awesome.
        Hulk is so fancy. Cats are awesome.
        Superman is so fluffy! Cats are awesome.
        Black Widow is so fluffy! Cats are awesome.
        */

        static void Övning11() {
            string desc = "Skriv ett 'gissa nummret' spel. Spelet slumpar ett tal mellan 1 och 20 och så skall man försöka gissa vad nummret är.";
            Console.WriteLine($"desc: {desc}");
            Random random = new Random();
            int numberToGuess = random.Next(1, 20);
            byte lives = 5;
            do {
                Console.Write($"Lives: {lives} Guess:");
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess == numberToGuess) {
                    Console.WriteLine("You win!");
                    return;
                } else if (guess != numberToGuess) {
                    lives--;
                }
            } while (lives > 0);
            Console.WriteLine("You loose!");
        }

        static void Övning12() {
            string desc = "Bygg en BMI räknare. Hämta in vikt och längd från konsolen.";
            Console.WriteLine($"desc: {desc}");
            Console.Write("Vikt:");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Längd:");
            double height = Convert.ToDouble(Console.ReadLine());
            double bmi = weight / (height * height) * 10000;
            float dec = (float) bmi;
            Console.WriteLine($"BMI: {dec}");
        }

        static void övning13() {
            string desc = "Bygg ett hängagubbe spel som spelas i terminalen.";
            Console.WriteLine($"desc: {desc}");
            byte lives = 5;
            string[] secrets = { "hemligt", "cool", "johan" };
            Random random = new Random();
            int secretIndex = random.Next(0, secrets.Length);
            string secret = secrets[secretIndex];
            char[] lettersOfSecret = secret.ToCharArray();
            List<char> displayedLetters = new List<char>();
            foreach (char letter in lettersOfSecret) {
                displayedLetters.Add('_');
            }
            do {
                string displayedStr = string.Join(" ", displayedLetters.ToArray());
                Console.WriteLine(displayedStr);
                Console.WriteLine($"Lives: {lives} Guess a letter:");
                char? guess = Convert.ToChar(Console.ReadLine().ToLower());
                if (!lettersOfSecret.Contains(guess.Value)) {
                    lives--;
                }
                for (int i = 0; i < secret.Length; i++) {
                    if (guess == lettersOfSecret[i]) {
                        displayedLetters[i] = guess.Value;
                    }
                }
            } while (lives > 0 && displayedLetters.Contains('_'));
            Console.WriteLine(lives > 0 ? "You win!" : "You lose");
        }

    }
}
