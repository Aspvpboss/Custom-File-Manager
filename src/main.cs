using System;



class Program{

    static void Main(){

        Init();


        while(true){

            if(Console.KeyAvailable && Console.ReadKey(true).KeyChar == 'Q'){
                break;
            }

        }
        
        Cleanup();

    }


    static void Init(){

        Console.Clear();
        Console.CursorVisible = false;

    }
    static void Cleanup(){

        Console.Clear();
        Console.CursorVisible = true;

    }
}

