namespace CaesarCipher
{
    public class Program
    {
        static void Main(string[] args)
        {
            CaesarCipher cipher = new CaesarCipher();

            cipher.Message = "Lorem ipsum";
            cipher.Shift = 7;
            cipher.Encode();
            Console.WriteLine(cipher.EncodedMessage);
        }
    }
}
