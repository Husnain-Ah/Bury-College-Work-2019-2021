using System;

namespace EscapeGame16
{
    class Program
    {
        private static StoreRoom startingStoreRoom = new StoreRoom();
        private static StoreRoom emptyStoreRoom = new StoreRoom("Store 2", "This is an empty store", "on", "open");
        private static Kitchen theKitchen = new Kitchen("The Kitchen", "This is a kitchen. it has two storerooms and a locked door leading to the livingroom");
        private static LivingRoom theLivingRoom = new LivingRoom("The Living room", "This is the Livingroom");
        
        private static Key blueKey = new Key("Blue Key", "This key can be used to unlock a door", "blue");
        private static Key redKey = new Key("Red Key");


        static void PlayGame(PlayerClass player)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Escape Game");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome, " + player.UserName + ", " + "You are starting with a score of : " + player.getScore().ToString());
            Console.WriteLine("");
            Console.WriteLine("you will need to escape this room");
            Console.WriteLine("Escape the room!");
            Console.WriteLine("");
            Console.WriteLine(player.getPlayerDetails());

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press enter to begin... ");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void StartStoreRoom(ref PlayerClass player)
        {
            string userInput = "";
            do
            {
                do
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Escape Game: the unknown beginning");
                    Console.WriteLine(startingStoreRoom.getRoomDetails());
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Would you like to:");
                    Console.WriteLine("     [1] Run forward ");
                    Console.WriteLine("     [2] feel the walls for a light switch ");
                    userInput = Console.ReadLine();
                    if (userInput[0] == '1')
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        player.updateScore(-10);
                        Console.WriteLine("You run forward and bang your head, knocking yourself out");
                        Console.WriteLine("... you wake up some time later");
                        Console.WriteLine("Your score is now: " + player.getScore());
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("press enter to continue");
                        Console.ReadLine();
                    }
                } while (userInput[0] != '2');

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("You found a switch on the wall - press enter to turn it on");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("press enter to turn on the switch");
                Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(startingStoreRoom.setLightStatus());
                Console.WriteLine(startingStoreRoom.getRoomDetails());
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Would you like to:");
                Console.WriteLine("     [1] look at the door ");
                Console.WriteLine("     [2] open the door ");
                userInput = Console.ReadLine();
                if (userInput[0] == '1')
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    player.updateScore(-10);
                    Console.WriteLine("While looking at the door you feel bored and fall asleep...");
                    Console.WriteLine("... you wake up some time later");
                    Console.WriteLine("Your score is now: " + player.getScore());
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("press enter to continue");
                    Console.ReadLine();
                    Console.WriteLine(startingStoreRoom.setLightStatus());
                }
            } while (userInput[0] != '2');
            AreaComplete(ref player);
        }

        static void StartKitchen(ref PlayerClass player)
        {
            string userInput = "";
            do
            {
                do
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Escape Game: the kitchen");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(theKitchen.getRoomDetails());
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Press enter to walk forward");
                    userInput = Console.ReadLine();

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("As you walk forward a sensor activates...");
                    Console.WriteLine(theKitchen.setLightStatus());
                    Console.WriteLine("you can see a table with a small object on it");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Would you like to:");
                    Console.WriteLine("     [1] repeat the room details ");
                    Console.WriteLine("     [2] walk around the room ");
                    Console.WriteLine("     [3] walk over to the table and inspect the small object ");
                    Console.WriteLine("     [4] investigate what is inside the other room ");
                    userInput = Console.ReadLine();

                    if (userInput[0] == '1')
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(theKitchen.getRoomDetails());
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("press enter to continue");
                        Console.ReadLine();
                    }

                    else if (userInput[0] == '2')
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(theKitchen.getRoomDetails());
                        Console.WriteLine("you spend some time walking around the room");
                        Console.WriteLine("... eventually you stop and realise you are back where you started");
                        player.updateScore(-10);
                        theKitchen.setLightStatus();
                        Console.WriteLine("Your score is now: " + player.getScore());
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("press enter to continue");
                        Console.ReadLine();
                    }

                    else if (userInput[0] == '4')
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("you enter the store room");
                        Console.WriteLine(emptyStoreRoom.getRoomDetails());
                        Console.WriteLine("... as the store room is empty you turn around and go back into the kitchen");
                        Console.WriteLine(theKitchen.setLightStatus());
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("press enter to continue");
                        Console.ReadLine();
                    }

                } while (userInput[0] != '3');

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("you walk up to the table and inspect the object: ");
                Console.WriteLine("...");
                Console.WriteLine(blueKey.getItemDetails());
                Console.WriteLine("...");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Would you like to:");
                Console.WriteLine("     [1] repeat all of the room details so far");
                Console.WriteLine("     [2] discard the item ");
                Console.WriteLine("     [3] take the item and walk over to the locked door");
                userInput = Console.ReadLine();

                if (userInput[0] == '1')
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(theKitchen.getRoomDetails());
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("press enter to continue");
                    Console.ReadLine();
                }

                else if (userInput[0] == '2')
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(theKitchen.getRoomDetails());
                    Console.WriteLine("the key has been lost!");
                    Console.WriteLine("... you are unable to leave the room.");
                    Console.WriteLine("the room will be reset");
                    player.updateScore(-50);
                    theKitchen.setLightStatus();
                    Console.WriteLine("Your score is now: " + player.getScore());
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("press enter to continue");
                    Console.ReadLine();
                } 
            } while (userInput[0] != '3');

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("you walk over to the door. it has a blue lock");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("press enter to use the key in the lock");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(theKitchen.setLivingRoomDoorStatus(true));

            AreaComplete(ref player);

        }

        static void StartLivingRoom(ref PlayerClass player)
        {
            string userInput = "";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Escape Game: the kitchen");
            Console.ForegroundColor = ConsoleColor.Cyan;

            AreaComplete(ref player);
        }

        static void AreaComplete(ref PlayerClass playerObject)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            playerObject.updateScore(10);
            Console.WriteLine("The door opens and you walk out of the room");
            Console.WriteLine("... well done you have escaped the room");
            Console.WriteLine("Your score is now: " + playerObject.getScore());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("press enter to continue");
            Console.ReadLine();
        }

        static void gameComplete(ref PlayerClass player)
        {
            Console.WriteLine("well done you have completed the game: ");
            Console.WriteLine(player.getPlayerDetails());
            Console.WriteLine("press enter");
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("welcome to the escape game");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;

            string userName, password;
            Console.WriteLine("Please enter your name");
            userName = Console.ReadLine();
            Console.WriteLine("Please enter your password");
            password = Console.ReadLine();
            Console.Clear();

            PlayerClass player1 = new PlayerClass(userName, password, 1, 100);

            PlayGame(player1);
            StartStoreRoom(ref player1);
            StartKitchen(ref player1);
            StartLivingRoom(ref player1);
            gameComplete(ref player1);
            
        }
    }
}
