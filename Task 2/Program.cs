/*==============================================================================
 *
 * Enigma Machine reflect function
 *
 * Copyright © Dorset Software Services Ltd, 2022
 *
 * TSD Section: P020 Begineers guide to Programming Task Set 4 Task 2 
 *
 *============================================================================*/
/// <summary>
/// Class for Task Set 4 Task 2
/// </summary>
public class Task2
{
    /// <summary>
    /// Reflect function that reflect the wheels
    /// </summary>
    /// <param name="text"> character before reflect </param>
    /// <returns> the character after reflect </returns>
    public static char Reflect(char text)
    {
        int intText = (int)text;
        intText -= 65;
        int[] reflectArray = new int[26] {0,18,5,13,20,17,2,22,14,24,21,7,8,12,
            6,19,25,11,3,4,10,23,1,15,9,16};
        int reflectPosition = Array.IndexOf(reflectArray, intText);
        reflectPosition = (reflectPosition + 13) % 26;
        return (char)(reflectArray[reflectPosition] + 65);
    }
    /// <summary>
    /// The Main to test out the reflect function
    /// </summary>
    public static void Main()
    {
        Console.WriteLine(Reflect('A'));
    }
}
