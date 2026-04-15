using System;



class Program{

    static void Main(){

        Init();

        try{
            while(true){

                if(Console.KeyAvailable && Console.ReadKey(true).KeyChar == 'Q'){
                    break;
                }
                
                Renderer.Text_Left("Ball", Console.WindowWidth - 2, 5, ConsoleColor.Cyan);

            }
        } 
        catch(Exception ex){
            Console.WriteLine(ex.Message);
        }
        
        Cleanup();

    }


    public static void Init(){

        Console.Clear();
        Console.CursorVisible = false;

    }
    public static void Cleanup(){

        Console.ResetColor();
        Console.Clear();
        Console.CursorVisible = true;

    }
}

