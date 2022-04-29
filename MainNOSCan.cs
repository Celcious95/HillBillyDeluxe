namespace VendingMachine

{
    class program
    {
        private static void Main()
        
        {
            var Buddy = false;
            Console.Clear();
            Console.WriteLine("Stop thinking, spend the money here at the DimsDale DimiDome");
            var SodaMachine = new DrinkMachine();
            
            Console.WriteLine("Give me all your change bro");
            var money = Console.ReadLine(); 
            int TheMoney = int.Parse(money);
            SodaMachine.depositeCoin(TheMoney);
            do{
            SodaMachine.DisplayDrinkSelections();
            // bool Leftover = SodaMachine.checkTotal();
            // Console.WriteLine(Leftover);
            Console.WriteLine(" Heres Your Change " +  SodaMachine.runningTotal + " Get Lost ");
            Console.WriteLine("Buy One For Your Friend");
            var Friend = Console.ReadLine();
            
            if (Friend == "yes")
            {            
                Buddy = true;  
            }
            else 
            {
                Buddy = false;
            }
            }
            while (Buddy == true);            
        }
    }
}
