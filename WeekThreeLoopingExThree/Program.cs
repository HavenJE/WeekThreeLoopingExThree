// Exercise 3
// Write an application named EnterUpperLetters that asks the user to type an uppercase letter from the keyboard.
// If the character entered is an uppercase letter, display OK. If it is not an uppercase letter, display an error message.
// The program continues until the user types an exclamation mark(!).

class EnterUpperLetters
{
    static void Main()
    {
        string stopSign = "!";
        char userLetter;
        // bool result;

        Console.WriteLine("Please enter an Uppercase letter below: ");
        userLetter = Convert.ToChar(Console.ReadLine());

        while (userLetter != '!')
        {
            while (Char.IsUpper(userLetter) == true)
            {
                
                Console.WriteLine("Okay {0}", userLetter);
                userLetter = char.ToUpper(userLetter);
                userLetter = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("That was not an uppercase! {0}", userLetter);
            Console.WriteLine("Please enter an Uppercase letter below: ");
            userLetter = Convert.ToChar(Console.ReadLine());
        }
    }
}