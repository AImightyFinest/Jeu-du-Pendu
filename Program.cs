Console.WriteLine("Entre un mot à faire deviner: ");
string word = Console.ReadLine();

var charsToRemove = new string[] { " ", "-", "_" };
foreach (var c in charsToRemove)
{
    word = word.Replace(c, string.Empty);
}

string[] letters_to_guess = new string[word.Length];
string[] hidden_letters = new string[word.Length];

List<string> wrong_letters = new List<string>();
List<string> used_letters = new List<string>(); 

int lives = 5;

int i = 0;
foreach (char c in word)
{
    letters_to_guess[i] = c.ToString();
    hidden_letters[i] = "_";
    i++;
}

foreach (string letter in hidden_letters) {
    Console.Write(letter + " ");
}
Console.WriteLine();    

while (lives != 0)
{
    if (hidden_letters.All(letter => letter != "_"))
    {
        Console.WriteLine("Gagné !");
        break;
    }

    Console.WriteLine("Propose une lettre: ");
    string purposed_letter = Console.ReadLine(); 

    while (purposed_letter.Length != 1) {
        Console.WriteLine("1 seule lettre!!!");
        purposed_letter = Console.ReadLine(); 
    }

    if (!used_letters.Contains(purposed_letter))
    {
        used_letters.Add(purposed_letter);
    }
    else
    {
        Console.WriteLine("Tu as déjà proposé cette lettre.");
    }

    if (letters_to_guess.Contains(purposed_letter)) {
        for (int j = 0; j < letters_to_guess.Length; j++)
        {
            if (purposed_letter == letters_to_guess[j]) {
                hidden_letters[j] = purposed_letter;
            }
        }
    } else {
        lives--;
        wrong_letters.Add(purposed_letter);
    }

    foreach (string letter in hidden_letters) {
        Console.Write(letter + " ");
    }
    Console.WriteLine();

    Console.WriteLine("Lettres utilisées : " + string.Join(", ", used_letters));

    if (hidden_letters.All(letter => letter != "_")) {
        Console.WriteLine("Gagné !");
        break;
    }

    if (lives == 0) {
        Console.WriteLine("Perdu ! Le mot était : " + word);
        break;
    }
}
