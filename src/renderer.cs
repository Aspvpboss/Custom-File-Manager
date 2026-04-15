

class Renderer{



    public static void Text_Left(string? String, int x, int y, ConsoleColor color){

        ArgumentNullException.ThrowIfNull(String);

        int maxLength = Console.WindowWidth - x;
        if (maxLength <= 0) return; // off screen, don't render
        string Truncated = String[..Math.Min(String.Length, maxLength)];

        try{

            Console.SetCursorPosition(y, x);
            Console.ForegroundColor = color;
            Console.Write(Truncated);

        }
        catch(Exception ex){

            Program.Cleanup();

            Console.WriteLine(ex.Message);

            throw;
        }

    }

    public static void Text_Center(string? String, int x, int y, ConsoleColor color){

        ArgumentNullException.ThrowIfNull(String);

        try{
            
            Console.SetCursorPosition(y, x - (String.Length / 2));
            Console.ForegroundColor = color;
            Console.Write(String);
            
        }
        catch(Exception ex){

            Program.Cleanup();

            Console.WriteLine(ex.Message);

            throw;
        }

    }


    public static void Text_Right(string? String, int x, int y, ConsoleColor color){

        ArgumentNullException.ThrowIfNull(String);

        try{
            
            Console.SetCursorPosition(y, x - String.Length);
            Console.ForegroundColor = color;
            Console.Write(String);
            
        }
        catch(Exception ex){

            Program.Cleanup();

            Console.WriteLine(ex.Message);

            throw;
        }

    }


}