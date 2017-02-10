using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loopy
{
    class LoopyProject
    {
        //Joseph's Loopy Project :D
        public static void Main(string[] args)
        {

            double multip = 0.0;            // initalizing the values for the multipliyer and Final Weight which will chance based on what the user inputs
            double FinalWeight = 0.0;       // so the compiler won't have to assume default values and return an error  
            String Planet = "";             // intialized a string to have its values updated after the user makes the appropriate choice
            
            double weight;                  //weight and PlanetChoice are used to store the # values of what the user inputs 
            int PlanetChoice;               //
            Boolean flag = true;            // A Boolean used to check a condition in the switch statement. The default is set to true. 

            /* Created a integer called Restart to manipulate as my while-loop condition
             * the While-loop encases the entire code so it can loop from the start menu 
             * as long as the value of Restart is > 0 */

            int Restart = 1;  
            while (Restart > 0)
            {
                /*Basic screen of the layout of what the user will see on the console.
                 the \n are just line breaks for formatting purposes */

                Console.WriteLine("Menu of Planets");
                Console.WriteLine("==== == ========\n");
                Console.WriteLine("1. Mercury   2. Venus    3. Mars  ");
                Console.WriteLine("4. Jupiter   5. Saturn   6. Uranus");
                Console.WriteLine("7. Neptune   8. Pluto    9. <Quit>");
                Console.WriteLine("\n\n");

                /*Shows the user the message to enter their value into the variable 'weight'*/
                Console.Write("Hello!\nPlease enter your weight in pounds: ");
                weight = Convert.ToDouble(Console.ReadLine());                
                

                /*This while loop is there to check if the user inputted an 'weight' value that is < or = 0
                 * as weight can't be 0 or negative (On earth anyway, gravity and all).
                 * It will keep looping until the user enters a valid >0 number.
                 * It however, will not be able to catch strings and will crash if a non-number string is input
                 */
                while (weight <= 0)
                {
                    Console.WriteLine("\n\nExcuse me, your weight CANNOT be 0 or negative");
                    Console.Write("Please enter your weight again in pounds, PLEASE: ");
                    weight = Convert.ToDouble(Console.ReadLine());
                }
               
             
                Console.Write("Please enter the # for your menu choice: ");  //Like 'weight' this asks the user for an integer value
                PlanetChoice = Convert.ToInt32(Console.ReadLine());          //corresponding to the menu selection scren above
    
                switch (PlanetChoice)
                {                                      //Using a switch statement is more efficient (memory-wise) than a giant 
                    case 1:                            //nested if-else statement. It looks for the user input and matches the value 
                    multip = 0.37;                     //of the menu choice to their approrpiate case #
                    Planet = "Mercury";                //updating the values of the multiplier and stores the name of the Planet
                        break;                         //A 'break;' is inserted at the end of the cases 1-8 and default to 
                                                       //advance past the switch statement
                    case 2:
                    multip = 0.88;
                    Planet = "Venus";
                        break;

                    case 3:
                    multip = 0.38;
                    Planet = "Mars";
                        break;

                    case 4:
                     multip = 2.64;
                    Planet = "Jupiter";
                        break;
                    case 5:
                    multip = 1.15;
                    Planet = "Saturn";
                        break;

                    case 6:
                    multip = 1.15;
                    Planet = "Uranus";
                        break; 

                     case 7:
                    multip = 1.12;
                    Planet = "Neptune";
                        break;

                    case 8:
                    multip = 0.04;
                    Planet = "Pluto";
                        break;

                    case 9:
                        Console.WriteLine("\n\n\n=============");       //if 9. <quit> was chosen, it will lead to a Good-Bye screen 
                        Console.WriteLine(" Good Bye !  ");             //as shown here, and then set the value of our Restart value to 0,
                        Console.WriteLine("=============");             //making the condition for our loop false. 
                        Restart = 0;                                    //'Continue;' is used instead of break to skip any remaining code
                        continue;                                       // thus ending our program
                        
                    default:
                        Console.WriteLine("That is an invalid input");   //default is used to catch any values not specified in our case.
                        flag = false;                                    //therefore any value that is not 1-9 will point to default - including
                        break;                                           //strings. instead of skipping the rest of the code 
                                                                         //the flag is set to false and a break; is inserted and will advance
                                                                         //the user to the continuation screen below in case they want to try again.
            }                                 
                if (flag == true)   //Note that none of the cases 1-8 contain the flag variable. This means that it is , 
                                    //as true (the default value given). It will advance the user to the result screen within the if statement
                {
                    FinalWeight = weight * multip;  
                    Console.WriteLine("Your weight of " + weight + " pounds on Earth would be " + FinalWeight + " pounds on " + Planet + ".");
                   
                    /* The formula for the new weight is their earth weight multiplied by the multiplier of their respective planet.
                     * Finally the user is shown text containing all 3 variables; earth weight, new weight, and the planet chosen*/
                }              

                String EndChoice;                                               //A string is created to store the user's input
                                                                                //for the continuation screen. 
                    Console.WriteLine("=============================\n");       //It asks the user to type 'Y' or 'N' and places the
                    Console.WriteLine("Would you like to continue?");           //the value onto the EndChoice
                    Console.Write("Please Enter Y for Yes and N for No: ");     //*note that default also sends us here to the continuation 
                    EndChoice = Console.ReadLine();                             //screen and skips the Final Weight screen output statement
                    Console.WriteLine("\n\n");                                  //as the value is of flag turns to false. It gives the 
                                                                                //user an opportunity to continue if they wish to.
                  
                 while (EndChoice !="Y" && EndChoice !="N")                     //After the user enters their value into Endchoice
                {                                                               //this While loop is there to check if the user 
                    Console.WriteLine("\nInvalid Input");                       //entered 'Y' or 'N'. If they did not, it will 
                    Console.WriteLine("would you like want to continue?");      //catch it and let them know it was an "invalid input"
                    Console.Write("\nPlease Enter Y for Yes and N for No:");    // and ask them to enter a proper value of 'Y' or 'N'.
                    EndChoice = Console.ReadLine();                             //This repeats until the user enters either 'Y' or 'N'
                    Console.WriteLine("\n\n");

                    if (EndChoice == "Y")                                       //After fulfilling the condition of our while loop just 
                    {                                                           //above, it will check if it is 'Y'. If it is, it will add
                        Restart = Restart++;                                    //+1 to our Restart value. It makes our Restart While loop
                    }                                                           //condition true (1+1)>0 and thus continues the loop from
                    else if (EndChoice == "N")                                  //the menu screen. It is not a true infinite loop as it is
                    {                                                           //limited by the maximum value of int32 which is 2^32 
                        Console.WriteLine("\n\n\n=============");               //or a little bit > 2 billion repetitions
                        Console.WriteLine(" Good Bye !  ");
                        Console.WriteLine("=============");                     //if the user decides they do not want to continue 
                        Console.ReadLine();                                     //it sets the value of Restart to 0. Just like case 9
                        Restart = 0;                                            //it will set our Restart value to 0, ending our
                                                                                //Restart While Loop, and ending our program
                    }
                }

        

            }
            }
        }
    }

