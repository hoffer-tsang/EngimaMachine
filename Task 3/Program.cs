/*==============================================================================
 *
 * The Simulation wtihout increment orientation
 *
 * Copyright © Dorset Software Services Ltd, 2022
 *
 * TSD Section: P020 Begineers guide to Programming Task Set 4 Task 3 
 *
 *============================================================================*/
/// <summary>
/// Class for Task Set 4 Task 3
/// </summary>
public class Task3
{
    /// <summary>
    /// The Main to run the simulation without increment orientation.
    /// </summary>
    public static void Main()
    {
        Console.WriteLine("Please enter orientation for wheel 1: ");
        string? userInput1 = Console.ReadLine();
        Console.WriteLine("Please enter orientation for wheel 2: ");
        string? userInput2 = Console.ReadLine();
        Console.WriteLine("Please enter orientation for wheel 3: ");
        string? userInput3 = Console.ReadLine();
        Console.WriteLine("Please enter a line of text: ");
        string? userInputText = Console.ReadLine();
        if (userInput1 == null||userInput2 == null||
            userInput3 == null||userInputText == null)
        {
            Console.WriteLine("Please follow the instructions!");
        }
        else
        {
            int orientation1 = int.Parse(userInput1);
            int orientation2 = int.Parse(userInput2);
            int orientation3 = int.Parse(userInput3);
            userInputText = userInputText.ToUpper();
            string text = String.Concat(userInputText.Where(
                c => !Char.IsWhiteSpace(c)));
            Console.WriteLine(text);
            char[] inputChar = text.ToCharArray();
            char[] outputChar = new char[inputChar.Length];

            for (int i = 0; i < inputChar.Length; i++)
            {
                char encryptC = inputChar[i];
                encryptC = Task1.Encrypt(1, orientation1, encryptC);
                encryptC = Task1.Encrypt(2, orientation2, encryptC);
                encryptC = Task1.Encrypt(3, orientation3, encryptC);
                encryptC = Task2.Reflect(encryptC);
                encryptC = Task1.Decrypt(3, orientation3, encryptC);
                encryptC = Task1.Decrypt(2, orientation2, encryptC);
                encryptC = Task1.Decrypt(1, orientation1, encryptC);
                outputChar[i] = encryptC;
            }

            Console.WriteLine("Encrypted Message:");
            Console.WriteLine(new String(outputChar));
        }
    }
}

