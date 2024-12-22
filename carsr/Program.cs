using System;

    namespace project
    {
        class Cars
        {
            public string Name;
            public string Color;
            private string Model;
            protected double Motor;
            protected int Speed;

            
            
        }

        class Mustang : Cars
        {
            public  Mustang()
            {
                Name = "mustang";
                Color = "Red";
                Speed = 190;
                Motor = 375;
                
                
                
            }

            public void Run()
            {
                Console.WriteLine(Name+"\n"+Color+"\n"+Speed+"kmh\n"+Motor+" hp");
            }

            
        }

        class Mercedes : Cars
        {
            public Mercedes()
            {
                Name = "Mercedes";
                Color = "Green";
                Speed = 350 ;
                Motor = 600;
                
                
            }

            public void Run()
            {
                Console.WriteLine(Name+" \n"+Color+" \n"+Speed+"kmh\n"+Motor+"hp");
            }

            
        }

        class Program
        {
            static void Main(string[] args)
            {
                Mustang mustang = new Mustang();
                Mercedes mercedes = new Mercedes();
                mustang.Run();
                Console.WriteLine();
                mercedes.Run();
                
              
            }
            
        }
}