/*==============================================================================
 *
 * Enigma Machine encrypt and decrpyt function
 *
 * Copyright © Dorset Software Services Ltd, 2022
 *
 * TSD Section: P020 Begineers guide to Programming Task Set 4 Task 1 
 *
 *============================================================================*/
/// <summary>
/// Task 1 for Task Set 4 P020, including encrpyt and decrpyt
/// </summary>
public class Task1
{   
    /// <summary>
    /// Encrpyt of wheel 1.
    /// </summary>
    /// <param name="position"> position of input between 0-25 (a-z) </param>
    /// <returns> the char (0-25) of wheel 1 encrpytion </returns>
    public static int WheelOneIndexRelationship(int position)
    {
        int[] outPutArray = new int[26] { 25, 24, 23, 22, 21, 20, 19, 18, 17, 
            16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0};
        return outPutArray[position];
    }
    /// <summary>
    /// Encrpyt of wheel 2.
    /// </summary>
    /// <param name="position"> position of input between 0-25 (a-z) </param>
    /// <returns> the char (0-25) of wheel 2 encrpytion </returns>
    public static int WheelTwoIndexRelationship(int position)
    {
        int[] outPutArray = new int[26] { 3, 10, 11, 19, 21, 0, 20, 18, 2, 7,
            9, 12, 1, 8, 22, 23, 17, 6, 5, 16, 15, 14, 24, 4, 25, 13};
        return outPutArray[position];
    }
    /// <summary>
    /// Encrpyt of wheel 3.
    /// </summary>
    /// <param name="position"> position of input between 0-25 (a-z) </param>
    /// <returns> the char (0-25) of wheel 3 encrpytion </returns>
    public static int WheelThreeIndexRelationship(int position)
    {
        int[] outPutArray = new int[26] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19,
            21, 23, 25, 0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24};
        return outPutArray[position];
    }
    /// <summary>
    ///  output the order of a-z after orientation
    /// </summary>
    /// <param name="orientation"> number of orientation </param>
    /// <param name="position"> orginail position of 
    /// a-z before orientation </param>
    /// <returns> the char output after orientation </returns>
    public static char OutputOrientationOrder(int orientation, int position)
    {
        int[] outputOrder = new int[26];
        for (int i = 0; i < 26; i++)
        {
            outputOrder[i] = (26 + i - orientation) % 26;
        }
        return (char)(outputOrder[position]+65);
    }
    /// <summary>
    /// Encrypt a char with corresponding wheel 
    /// </summary>
    /// <param name="wheelNumber"> the wheel number of encrpytion </param>
    /// <param name="orientation"> the number of orientation </param>
    /// <param name="plainText"> the charfor encrpytion </param>
    /// <returns> the encrpyted character </returns>
    public static char Encrypt(int wheelNumber, int orientation, char plainText)
    {
        int newPositionIndex;
        if (wheelNumber == 1)
        {
            int intPlainText = (int)plainText;
            newPositionIndex = WheelOneIndexRelationship((intPlainText +
                orientation - 65) % 26);
            return OutputOrientationOrder(orientation, newPositionIndex);

        }
        else if (wheelNumber == 2)
        {
            int intPlainText = (int)plainText;
            newPositionIndex = WheelTwoIndexRelationship((intPlainText +
                orientation - 65) % 26);
            return OutputOrientationOrder(orientation, newPositionIndex);
        }
        else if (wheelNumber == 3)
        {
            int intPlainText = (int)plainText;
            newPositionIndex = WheelThreeIndexRelationship((intPlainText +
                orientation - 65) % 26);
            return OutputOrientationOrder(orientation, newPositionIndex);
        }
        else
        {
            Console.WriteLine("Please Input Wheel Number 1-3");
            return 'A';
        }
    }
    /// <summary>
    /// for decrypt that reserved the process of orientation position
    /// </summary>
    /// <param name="orientation"> number of orientation </param>
    /// <param name="cipherText"> the encrpyted text </param>
    /// <returns> the position index after orientation </returns>
    public static int OutputOrientationPosition(
        int orientation, char cipherText)
    {
        int[] outputOrder = new int[26];
        int cipherTextIndex = (int)cipherText;
        cipherTextIndex -= 65;

        for (int i = 0; i < 26; i++)
        {
            outputOrder[i] = (26 + i - orientation) % 26;
        }
        return Array.IndexOf(outputOrder, cipherTextIndex);
    }
    /// <summary>
    /// decrpyt array for wheel 1
    /// </summary>
    /// <param name="position"> the position of array after encrpytion</param>
    /// <returns> the position index before encrpytion of wheel 1 </returns>
    public static int WheelOneReverseRelationship(int position)
    {
        int[] outPutArray = new int[26] { 25, 24, 23, 22, 21, 20, 19, 18, 17,
            16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0};

        return Array.IndexOf(outPutArray, position);
    }
    /// <summary>
    /// decrpyt array for wheel 2
    /// </summary>
    /// <param name="position"> the position of array after encrpytion</param>
    /// <returns> the position index before encrpytion of wheel 2 </returns>
    public static int WheelTwoReverseRelationship(int position)
    {
        int[] outPutArray = new int[26] { 3, 10, 11, 19, 21, 0, 20, 18, 2, 7,
            9, 12, 1, 8, 22, 23, 17, 6, 5, 16, 15, 14, 24, 4, 25, 13};
        return Array.IndexOf(outPutArray, position);
    }
    /// <summary>
    /// decrpyt array for wheel 3
    /// </summary>
    /// <param name="position"> the position of array after encrpytion</param>
    /// <returns> the position index before encrpytion of wheel 3 </returns>
    public static int WheelThreeReverseRelationship(int position)
    {
        int[] outPutArray = new int[26] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19,
            21, 23, 25, 0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24};
        return Array.IndexOf(outPutArray, position);
    }
    /// <summary>
    ///  decrpytion function 
    /// </summary>
    /// <param name="wheelNumber"> the wheel number to decrpyt </param>
    /// <param name="orientation"> the number of orientation in encrypt</param>
    /// <param name="cipherText"> the encrpyted text to decrpyt</param>
    /// <returns></returns>
    public static char Decrypt(int wheelNumber, int orientation,
        char cipherText)
    {
        int intPlainText;
        int originalPositionIndex;
        if (wheelNumber == 1)
        {
            originalPositionIndex = OutputOrientationPosition
                (orientation, cipherText);
            intPlainText = WheelOneReverseRelationship(originalPositionIndex);
            intPlainText = ((intPlainText + 26 - orientation) % 26) + 65;
            return (char)intPlainText;

        }
        else if (wheelNumber == 2)
        {
            originalPositionIndex = OutputOrientationPosition
                (orientation, cipherText);
            intPlainText = WheelTwoReverseRelationship(originalPositionIndex);
            intPlainText = ((intPlainText + 26 - orientation) % 26) + 65;
            return (char)intPlainText;

        }
        else if (wheelNumber == 3)
        {
            originalPositionIndex = OutputOrientationPosition
                (orientation, cipherText);
            intPlainText = WheelThreeReverseRelationship(originalPositionIndex);
            intPlainText = ((intPlainText + 26 - orientation) % 26) + 65;
            return (char)intPlainText;

        }
        else
        {
            Console.WriteLine("Please Input Wheel Number 1-3");
            return 'A';
        }
    }
    /// <summary>
    /// test function to ensure same setting of encrpytion and decrpytion return
    /// the same value of wheel 1.
    /// </summary>
    public static void WheelOneTest()
    {
        Console.WriteLine(Encrypt(1, 5, 'A'));
        Console.WriteLine(Decrypt(1, 5, 'P'));
        Console.WriteLine(Encrypt(1, 20, 'B'));
        Console.WriteLine(Decrypt(1, 20, 'K'));
    }
    /// <summary>
    /// test function to ensure same setting of encrpytion and decrpytion return
    /// the same value of wheel 2.
    /// </summary>
    public static void WheelTwoTest()
    {
        Console.WriteLine(Encrypt(2, 5, 'A'));
        Console.WriteLine(Decrypt(2, 5, 'V'));
        Console.WriteLine(Encrypt(2, 20, 'B'));
        Console.WriteLine(Decrypt(2, 20, 'U'));
    }
    /// <summary>
    /// test function to ensure same setting of encrpytion and decrpytion return
    /// the same value of wheel 3.
    /// </summary>
    public static void WheelThreeTest()
    {
        Console.WriteLine(Encrypt(3, 5, 'A'));
        Console.WriteLine(Decrypt(3, 5, 'G'));
        Console.WriteLine(Encrypt(3, 20, 'B'));
        Console.WriteLine(Decrypt(3, 20, 'W'));
    }
    /// <summary>
    /// Main function to perform the test
    /// </summary>
    public static void Main()
    {
        WheelThreeTest();
    }
}
