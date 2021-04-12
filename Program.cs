//Made by AnonimKisi
using System;

namespace Encryption_and_Decryption
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Made by AnonimKisi";
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("Encryption: 1");
            Console.WriteLine("Decryption: 2");
            Console.Write("\nInput: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------------------------------------------------------------------");
            switch (input)
            {
                case 1:
                    Console.Write("Write the text that you wish you encrypt: ");
                    string text = Console.ReadLine();
                    char[] chars = text.ToCharArray(0, text.Length);
                    Console.Write("\nEncrypted version: ");

                    foreach (char letters in chars)
                    {
                        int storing_encrypted_data = 1;
                        storing_encrypted_data = ((int)letters) - 95;

                        if (letters == ' ')
                        {
                            storing_encrypted_data = 0;
                        }

                        char new_words = (char)(storing_encrypted_data + 99);
                        new_words = Char.ToLower(new_words);

                        if (new_words == 'İ')
                        {
                            new_words = 'I';
                        }

                        if (new_words == 'ı')
                        {
                            new_words = 'i';
                        }

                        if (storing_encrypted_data == 0)
                        {
                            new_words = ' ';
                        }

                        if ((storing_encrypted_data + 99) > 122)
                        {
                            new_words = (char)(storing_encrypted_data + 73);
                            new_words = Char.ToLower(new_words);
                        }

                        Console.Write(new_words);
                    }

                    Console.WriteLine();
                    Main();
                    break;

                //---------------------------------------------------------------------------------------------------------

                case 2:
                    Console.Write("Write the encrypted text that you wish you decrypt: ");
                    text = Console.ReadLine();
                    chars = text.ToCharArray(0, text.Length);
                    Console.Write("\nDecrypted version: ");

                    foreach (char letters in chars)
                    {
                        int storing_encrypted_data = 1;

                        storing_encrypted_data = (int)letters - 4;

                        if (storing_encrypted_data < 97)
                        {
                            storing_encrypted_data = (storing_encrypted_data + 26);
                        }

                        if (letters == ' ')
                        {
                            storing_encrypted_data = 0;
                        }

                        char new_words = (char)storing_encrypted_data;
                        new_words = Char.ToLower(new_words);

                        if (storing_encrypted_data == 0)
                        {
                            new_words = ' ';
                        }

                        Console.Write(new_words);
                    }

                    Console.WriteLine();
                    Main();
                    break;
            }

            Console.ReadKey(true);
        }
    }
}
