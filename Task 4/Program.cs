/*==============================================================================
 *
 * The Simulation wtih increment orientation
 *
 * Copyright © Dorset Software Services Ltd, 2022
 *
 * TSD Section: P020 Begineers guide to Programming Task Set 4 Task 4 
 *
 *============================================================================*/

/// <summary>
/// Public class for Task Set 4 task 4
/// </summary>
public class Task4
{
    /// <summary>
    /// Perform the wheel rotation increment with necessary reset
    /// </summary>
    /// <param name="orientation"> the array stores the 
    /// 3 orientiaton for 3 wheels </param>
    /// <returns> the new orientation array </returns>
    public static int [] RotateWheel(int [] orientation)
    {
        orientation[0] += 1;
        if (orientation[0] == 26)
        {
            orientation[0] = 0;
            orientation[1] += 1;
            if(orientation[1] == 26)
            {
                orientation[1] = 0;
                orientation[2] += 1;
                if(orientation [2] == 26)
                {
                    orientation[2] = 0;
                }
            }
        }
        return orientation;
    }
    /// <summary>
    /// Main Function to perform the encrpytion with the orientation increment.
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
        if (userInput1 == null || userInput2 == null ||
            userInput3 == null || userInputText == null)
        {
            Console.WriteLine("Please follow the instructions!");
        }
        else
        {
            int[] orientation = new int[3];
            orientation[0] = int.Parse(userInput1);
            orientation[1] = int.Parse(userInput2);
            orientation[2] = int.Parse(userInput3);
            userInputText = userInputText.ToUpper();
            string text = String.Concat(userInputText.Where(
                c => !Char.IsWhiteSpace(c)));
            Console.WriteLine(text);
            char[] inputChar = text.ToCharArray();
            char[] outputChar = new char[inputChar.Length];

            for (int i = 0; i < inputChar.Length; i++)
            {
                char encryptC = inputChar[i];
                encryptC = Task1.Encrypt(1, orientation[0], encryptC);
                encryptC = Task1.Encrypt(2, orientation[1], encryptC);
                encryptC = Task1.Encrypt(3, orientation[2], encryptC);
                encryptC = Task2.Reflect(encryptC);
                encryptC = Task1.Decrypt(3, orientation[2], encryptC);
                encryptC = Task1.Decrypt(2, orientation[1], encryptC);
                encryptC = Task1.Decrypt(1, orientation[0], encryptC);
                outputChar[i] = encryptC;
                orientation = RotateWheel(orientation);
            }
            Console.WriteLine("Encrypted Message:");
            Console.WriteLine(new string(outputChar));
        }
    }
}

