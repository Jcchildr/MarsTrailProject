using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsTrail
{
    class ProgramUI
    {
        public void Run()
        {
            Menu();
        }
        /*Goal (Similar to Oregon Trail): Fly from Earth to Mars in a spaceship
             * Main menu: 1. Start your advenure, 2. Facts about Mars, 3. Exit [x]
             * Name characters: up to 5 (option to autofill names) [x]
             * Name the spacecraft [x]
             * Destinations along the way: Moon, 
             * Obstacles include: aliens, asteroids, broken thruster, magnetic field breaks navigation
             * Random Events: Radiation poisoning, bad Tang flavor, routine maintenance results in death during space walk
             * If you reach Mars, congratulations!
             * If you don't reach Mars, bad luck. Would you like to try again?
             */
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning == true)
            {
                Console.WriteLine("Select a menu option:\n" +
                    "1. Start Your Mars Adventure\n" +
                    "2. Facts About Mars\n" +
                    "3. Exit\n");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        StartAdventure();
                        break;
                    case "2":
                        FactsAboutMars();
                        break;
                    case "3":
                        Console.WriteLine("Goodbye!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;
                }
                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void StartAdventure()
        {
            bool keepRunning = true;
            Console.Clear();
            Console.WriteLine("Now let's name your spaceship! Be creative: ");
            string userSpaceShip = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Now tell me your name and the names of your 4 friends you are bringing along: ");
            string userNameOne = Console.ReadLine();
            string userNameTwo = Console.ReadLine();
            string userNameThree = Console.ReadLine();
            string userNameFour = Console.ReadLine();
            string userNameFive = Console.ReadLine();



            Console.Clear();
            Console.WriteLine($"Welcome aboard the {userSpaceShip}! {userNameOne}, {userNameTwo}, {userNameThree}, {userNameFour}, {userNameFive} your adventure to Mars begins now!");
            Console.WriteLine("Begin countdown 3...");
            Console.ReadLine();
            Console.WriteLine("2...");
            Console.ReadLine();
            Console.WriteLine("1...");
            Console.ReadLine();
            Console.WriteLine("And we have liftoff!");
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("On your journey to Mars, you'll make a few stops.  Your first destination is the moon.");
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Be wary of the dangers of traveling through space..");
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Traveling at 240,000MPG your shuttle reaches the moon in 3 days. One of the crew sees a small unidentified flying object.");
            Console.WriteLine("Do you want to inspect the UFO? (y/n)");
            string inspectUFO = Console.ReadLine().ToLower();

            if (inspectUFO == "y")
            {
                Console.WriteLine("The UFO is filled with angry aliens, do you try to interact or flee? (i/f)");
                string alienResponse = Console.ReadLine().ToLower();
                if (alienResponse == "i")
                {
                    Console.WriteLine($"You're crew comes under a barrage of heavy fire! You're ship is just able to get away.");
                    Console.ReadLine();
                    Console.WriteLine($"{userNameThree} is mortally wounded.. they won't make it through the night.");
                }
                else
                {
                    Console.WriteLine("You travel onward past the darkside of the moon.");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("You travel onward past the darkside of the moon.");
                Console.ReadLine();
            }

            Console.Clear();
            Console.WriteLine("A month goes by on the shuttle. The passengers are in good health. The shuttle remains fully operational and Mars is slowly growing in your field of view.");
            RandomEvents();

            Console.Clear();
            Console.WriteLine("Over the communication system you hear reports of a solar flare that has a good chance of starting in 6 days. Luckily the shuttle has a radiation panic room just for this exact purpose.");
            Console.WriteLine("It is the captains choice on how long you and your crew will stay remain in the panic room.");
            Console.WriteLine("How many days will the crew remain in the panic room?? one/two/three");
            string panicRoomInput = Console.ReadLine().ToLower();
            string panicOne = "one";
            string panicTwo = "two";
            string panicThree = "three";

            if (panicRoomInput == panicOne)
            {
                Console.WriteLine($"{userNameFour} ventures out to check the radiation levels. When they return {userNameFour} is pale...soon they begin vomiting blood.");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"Another month goes by on board the shuttle. {userNameFour} has succumb to extreme radiation poisoning. Morale on the {userSpaceShip} is low. The red planet continues to grow larger.");
                Console.ReadLine();
            }
            else if (panicRoomInput == panicTwo)
            {
                Console.WriteLine($"{userNameFour} ventures out to check the radiation levels. Whey they return {userNameFour} looks a little queasy, but says levels are close to normal. After 6 more hours you an the crew continue on.");
                Console.ReadLine();
                Console.Clear();
            }
            else if (panicRoomInput == panicThree)
            {
                Console.WriteLine($"{userNameFour} ventures out to check the radiation levels. When they return {userNameFour} says the levels are safe. You and your crew continue on.");
                Console.ReadLine();
                Console.Clear();
            }

            Console.WriteLine($"After 3 months, the passengers aboard {userSpaceShip} are in good health. The shuttle continues to operate well.  All passengers look forward to a successful landing.");
            RandomEvents();
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("With 5 days remaining before touchdown on Mars, the crew realizes that a sensor is broken on a thruster.  The thruster needs to be fixed in order to land safely.");
            Console.WriteLine("Option one: ignore the issue and hope for the best.");
            Console.WriteLine("Option two: send two to fix the sensor.");
            Console.WriteLine("Option three: ask the AI system installed for assistance.");
            Console.WriteLine("Option four: risk a life to complete a space walk to fix the issue.");
            Console.WriteLine("Type one/two/three/four");
            string thrusterInput = Console.ReadLine().ToLower();
            Console.Clear();
            string thrusterOne = "one";
            string thrusterTwo = "two";
            string thrusterThree = "three";
            string thrusterFour = "four";

            while (keepRunning == true)
            {
                switch (thrusterInput)
                {
                    case "one":
                        Console.WriteLine($"By choosing to be negligent, {userNameFive} doesn't know it yet, but they won't make it.");
                        Console.ReadLine();
                        Console.Clear();
                        EndOfGame();
                        break;
                    case "two":
                        Console.WriteLine($"{userNameOne} ventures out while {userNameFive} checks the lines.");
                        Console.WriteLine($"While working inside, {userNameTwo} sees debris heading toward {userSpaceShip}!");
                        Console.WriteLine($"{userNameOne} and {userNameFive} act in desperation but are hit by the debris and pushed into the depths of space.");
                        Console.ReadLine();
                        Console.Clear();
                        EndOfGame();
                        break;
                    case "three":
                        Console.WriteLine($"The AI unit HAL/AL 9000-series relizes that the mission will ultimatly fail as long as there are people alive. The AI begins eliminating people one by one. You lose.");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Goodbye!");
                        keepRunning = false;
                        Environment.Exit(1);
                        break;
                    case "four":
                        Console.WriteLine($"{userNameFive} puts on their spacesuit to complete a spacewalk in the hopes of fixing the broken sensor.");
                        Console.WriteLine($"The task is nearly complete when {userNameOne} comes over the radio and reports that oxygen is running low.");
                        Console.WriteLine($"After a tense moment not knowing if {userNameOne} would make it, {userNameOne} returns safely to {userSpaceShip}.");
                        Console.WriteLine("There's a sigh of relief as you and your crew set your next goal on landing.");
                        Console.ReadLine();
                        Console.Clear();
                        EndOfGame();
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;
                }
            }

            void EndOfGame()
            {
                Console.WriteLine("As you begin your landing on Mars, you take care to double-check that all parts of your ship are functioning for landing safely.");
                Console.WriteLine("You and your crew deploy a parachute successfully to help slow your speed.  You give the instruction to turn boosters on to slow your momentum.");
                Console.WriteLine("Which speed do you want to choose to land on mars? type 10mph/6mph/2mph");
                string landingSpeed = Console.ReadLine();
                string landingOne = "10mph";
                string landingTwo = "6mph";
                string landingThree = "2mph";

                if (landingSpeed == landingOne)
                {
                    Console.WriteLine($"You descended too quickly. You broke the landing legs on the {userSpaceShip}. You will not be able to make it home safely. You lose.");
                    Environment.Exit(1);
                }
                else if (landingSpeed == landingTwo)
                {
                    Console.WriteLine("You successfully landed!  Enjoy your time on Mars!");
                }
                else if (landingSpeed == landingThree)
                {
                    Console.WriteLine("You successfully landed!  Enjoy your time on Mars!");
                }
            }

            void RandomEvents()
            {
                Random random = new Random();
                int randomNumber = random.Next(100);

                if (randomNumber < 50)
                {
                    Console.WriteLine("Routine maintenance. The space ship is still fully functional.");
                }
                else if (randomNumber > 50)
                {
                    Console.WriteLine("Your crew fell ill by having bad Tang.");
                }
                else
                {
                    Console.WriteLine("Your ship blew up. You lose.");
                    Console.ReadLine();
                }
            }

        }
        void FactsAboutMars()
        {
            Console.WriteLine("Facts about Mars: ");
            Console.WriteLine("One year on Mars is 687 Earth days. That is equivalent to about two years here on Earth");
            Console.WriteLine("Pack some warm clothes...the average temperature on Mars is -81 degrees Fahrenheit.");
            Console.WriteLine("Mars has two moons, Phobos and Deimos. I wonder what the tides would be like if Mars had water!");
            Console.WriteLine("Ever dream about dunking a basketball? Your dream may come true when visiting Mars. You will experience 62.5% less gravity!");
            Console.WriteLine("All facts are courtesy of mars.NASA.gov");



            // 1 way to improve would be to promt user for a name
            // if its not a valid name or some 'exit option, then you stop adding new users
            // New users can be added to a list
            // IE)
            //List<string> users = new List<string>(); // ["Joe", "John" ]
            //bool keepAddingUsers = true;
            //while (keepAddingUsers == true)
            //{
            //    Console.WriteLine("Enter a new username, or enter 'Quit' to exit out");
            //    string username = Console.ReadLine();
            //    if (username != "Quit")
            //    {
            //        users.Add(username);
            //    }
            //    else
            //    {
            //        keepAddingUsers = false;
            //    }
            //}
        }
    }
}

