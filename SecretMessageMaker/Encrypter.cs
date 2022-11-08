namespace SecretMessageMaker
{
    public class Encrypter
    {
        private string alphabet = "abcdefghijklmnopqrstuvwxyz ";

        public string Encrypt(string message, int shift)
        {
            string encryptedMessage = "";
            foreach (char c in message.ToLower())
            {
                int index = alphabet.IndexOf(c);
                int newIndex = index + shift >= alphabet.Length ? index + shift - alphabet.Length : index + shift;
                char newChar = alphabet[newIndex];
                encryptedMessage += newChar;
            }
            return encryptedMessage;
        }
        
        public string Decrypt(string message, int shift)
        {
            string decryptedMessage = "";
            foreach (char c in message.ToLower())
            {
                int index = alphabet.IndexOf(c);
                int newIndex = index - shift < 0 ? index - shift + alphabet.Length : index - shift;
                char newChar = alphabet[newIndex];
                decryptedMessage += newChar;
            }
            return decryptedMessage;
        }
    }
}