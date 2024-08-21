namespace CaesarCipher
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
  ____                              ____ _       _               
 / ___|__ _  ___  ___  __ _ _ __   / ___(_)_ __ | |__   ___ _ __ 
| |   / _` |/ _ \/ __|/ _` | '__| | |   | | '_ \| '_ \ / _ \ '__|
| |__| (_| |  __/\__ \ (_| | |    | |___| | |_) | | | |  __/ |   
 \____\__,_|\___||___/\__,_|_|     \____|_| .__/|_| |_|\___|_|   
                                          |_|                    
");

            while (true)
            {
                Console.Write("Message: ");
                var message = Console.ReadLine();
                while (message == string.Empty)
                {
                    Console.Write("Message can't be empty, enter message: ");
                    message = Console.ReadLine();
                }
                Console.Write("Enter shift: ");
                int shift;
                while (!int.TryParse(Console.ReadLine(), out shift))
                    Console.Write("Enter integer number: ");

                var encodedMessage = string.Empty;
                Console.Write("[E]ncode or [D]ecode: ");
                do
                {
                    switch (Console.ReadKey().KeyChar.ToString().ToUpper())
                    {
                        case "E":
                            encodedMessage = CaesarCipher.Encode(message, shift);
                            Console.WriteLine($"\nEncoded message: {encodedMessage}"); 
                            break;
                        case "D":
                            encodedMessage = CaesarCipher.Decode(message, shift);
                            Console.WriteLine($"\nDecoded message: {encodedMessage}"); 
                            break;
                        default:
                            Console.Write("\n[E]ncode or [D]ecode: "); break;
                    }
                } while (encodedMessage == string.Empty);

                Console.Write("Enter to continue, Esc to quit: ");
                ConsoleKey keyChar = Console.ReadKey(true).Key;
                while(keyChar != ConsoleKey.Enter && keyChar != ConsoleKey.Escape)
                {
                    Console.Write("\nEnter to continue, Esc to quit: ");
                    keyChar = Console.ReadKey(true).Key;
                }
                if (keyChar == ConsoleKey.Escape)
                    return;
                Console.WriteLine(); Console.WriteLine();
            }
        }
    }
}
