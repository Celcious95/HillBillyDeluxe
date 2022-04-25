// See https://aka.ms/new-console-template for more information

//Vending Machine Code Start
//Thge purpose of this app is to be a vending machine program which
//will allow the user to make a selection of their
//choice, but requires the simulation of them inputing coins into it, 
//making sure that they entered enough money and then they can make a
//selection of their drink(s)

//The program will take place in the console. The user
//will be prompted to enter a number on the screen, then press
//the enter key to simulate money being put into the
//machine. A drink selection can be made once there
//has been enough money inputed into the machine.
//A list available berverages will then be displayd
//with a correspondinf keyboard key highlighted that
//represents the user choosing that particular drink.
//once the user has made their choice a message will
//appear that thanks the user and telling them to enjoy
//the rest of their day. They will also recieve their change
//from the transaction and it will be returned to them.

//The Algorithms and the Conditions.
//The end user should be promted to keep entering money 
//until enough has been recieved by the machine. 
//Another part of the prompt should include what is
//considered a valued entry. if the user enters an 
//invalid amount, the user will be told to retry until
//the valid entry is made.
//After each coin has been inserted the user will be
//shown how much they have put in so far in addition
//to the original prompt. The price of every drink will
//be defaulted to $1.50 to keep things more simple.
//after enough money has been entered into the machine,
//the drink machine should display a minimum of 3 se;ections
//then the user should input the key corresponding to the 
//beverage that they desire.
//After the selection has been inpute a message will tell the user
//confirming the item they had selected and also return the 
//change that they have leftover.

//My Notes and Restrictions with the Machine.
//The only valid entrys for the coins are...
//5, 10,25, and 100 (assume that 150 is $1.50)

//Sample Input/Output

//********************\\

// C for Coke-Cola
// P for Pepesi
// M for Mountain Dew 
// I can add more options if it is needed.

//*********************\\

namespace VendingMachine
{
    class DrinkMachine
    {
        const int DrinkCost = 150;
        public int RunningTotal {get; set;}
        public DrinkMachine()  
       
        {
            runningTotal = 0;
        }
        
        public void depositeCoin(int money)
        {
            //--The only entrys accepted are 1, 5, 10, 25, 50, 100, and a 10000 for when you want to flex--\\
            //--I can fill in some of the gaps if needs be --\\
            switch (money)
            {
                 case (1):
                runningTotal += 1;
                break;

                case (5):
                runningTotal += 5;
                break;
                
                case (10):
                runningTotal += 10;
                break;

                case (25):
                runningTotal += 25;
                break;

                case (50):
                runningTotal += 50;
                break;

                case (100):
                runningTotal += 100;
                break;

                 case (10000):
                runningTotal += 10000;
                break;

                default:
                    Console.WriteLine("You have made an invalid input");
                    break;
            }
        }

        public bool checkTotal()
        {
           
            if(RunningTotal >= DrinkCost)
                return true;
            else
                return false;

        }
        public void DisplayDrinkSelections()
        {
            Console.WriteLine("*******************");
            Console.WriteLine("*** M - Mountain Dew");
            Console.WriteLine("*** P - Pepsi");
            Console.WriteLine("*** C - Coke ");
            Console.WriteLine("*** E - Monster Energy");
            Console.WriteLine("*** R - RockStar Energy");
            Console.WriteLine("*** B - Bai");
            Console.WriteLine("*******************");
            
            Console.WriteLine();
            Console.WriteLine("Please Input Your Selection Here");

            MakeDrinkSelection(Convert.ToChar(Console.ReadLine().ToUpper()));

        }

        private void MakeDrinkSelection(char selectionOK)

        {
            bool SelectionOK = false;
            while (!selectionOK) 
            {
                switch (selection)
                {
                        case 'M':
                        Console.WriteLine("You have chosen Mountain Dew");
                        selectionOK = true;
                        break;
                        default:

                        case 'P':
                        Console.WriteLine("You have chosen a Pepesi");
                        selectionOK = true;
                        break;

                        case 'E':
                        Console.WriteLine("You have chosen a Monster");
                        selectionOK = true;
                        break;

                        case 'R':
                        Console.WriteLine("You have chosen a Rock-Star");
                        selectionOK = true;
                        break;

                        case 'B':
                        Console.WriteLine("You have chosen a bottle of Bai");
                        selectionOK = true;
                        break;

                        case 'C':
                        Console.WriteLine("You have chosen Coke-Cola");
                        selectionOK = true;
                        break;


                }
            }
        }
    } 
}