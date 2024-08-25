    static void Menu(){
        Console.Clear();

        Console.WriteLine("S = Segundo => 10s = 10 segundos");
        Console.WriteLine("M = Minuto => 1m = 1 minuto");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("Quanto tempo deseja contar?");

        //ToLower -> converte tudo para minusculo, resolvendo o problema caso o usuário digite 10S ou 10M. 

        string data = Console.ReadLine().ToLower();

        // método chamado subtring - todos strings tem. 
        //Pegando o ultimo caractere digitado pelo usuário.

        char type = char.Parse(data.Substring(data.Length-1, 1));

        //Data.Length -> pega todos os caracteres 
        int time = int.Parse(data.Substring(0,data.Length-1));
        int multiplier = 1; 

        if(type == 'm'){
            multiplier = 60;
        }
         if (time == 0){
            System.Environment.Exit(0);
         }

        PreStart(time * multiplier);

         
    }
    static void PreStart(int time){
        Console.Clear();

        Console.WriteLine("Ready...");
        Thread.Sleep(1000);

        Console.WriteLine("Set...");
        Thread.Sleep(1000);

        Console.WriteLine("Go!!!");
        Thread.Sleep(1000);

        Start(time);

    }
    static void Start(int time){
    
        int currentTime = 0; 

        while (currentTime != time)
        {
            Console.Clear();
            currentTime++; 
            Console.WriteLine(currentTime); 
            //Em outras versões do .NET seria necessário acrescentar o using system.Threading.
            Thread.Sleep(1000);
        }

        Console.Clear(); 
        Console.WriteLine("Stopwatch finalizado");
        Thread.Sleep(2500);
        Menu();
    }


    Menu();


