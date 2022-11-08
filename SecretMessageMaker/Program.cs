using System;

namespace SecretMessageMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Encrypter encrypter = new Encrypter();
            string message = "Hello";
            string encryptedMessage = encrypter.Encrypt(message, 1);
            Console.WriteLine(encryptedMessage);
            string decryptedMessage = encrypter.Decrypt(encryptedMessage, 1);
            Console.WriteLine(decryptedMessage);
            Console.Read();
        }
    }
}