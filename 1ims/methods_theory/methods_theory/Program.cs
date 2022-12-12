using System;
using System.Collections.Generic;

namespace methods_theory
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine(random.Next(0, 11));
     

            string assignment = Console.ReadLine().ToLower();

            switch (assignment)
            {
                case "introductie":
                    assignmentIntroductie();

                    break;
                case "oppervlakte":
                    assignmentOppervlaktes();
                    break;
                case "bandgenerator":
                    // AWESOME BANDNAME GENERATOR with 3 words
                    // { "the", "a", "not", "all"} => give me 1 random item back
                    // { "ugly", "awesome", "nice", "perfect", "hardcore"} => give me 1 random item back
                    // { "pigeon", "student", "bird", "flower", "jebus", "santan"} => give me 1 random item back
                    // Command YES or ADD NEW  to add new band name, Command STOP to stop the game
                    break;
            }
        }

        // Assignments
        static void assignmentIntroductie()
        {
            List<string> goats = new List<string>() { "T-rex", "Connie" };
            goats = reverseList(goats);
            printList(goats);
            int lengthOfGoats = getLengthOfList(goats);
            Console.WriteLine(lengthOfGoats);

            List<string> chickens = new List<string>() { "Tik", "Tok" };
            printList(chickens);
        }

        static void assignmentOppervlaktes()
        {
            //  
            // I: rectangle
            // O: give me height
            // I: 10
            // O: give me width
            // I: 5
            // O: The result is 50
            Console.WriteLine("What area calculate?[CIRCLE OR RECTANGLE]");
            string shape = Console.ReadLine().ToLower();

            switch (shape)
            {
                case "rectangle":
                    Console.WriteLine("Calculate area of a rectangle");
                    // Input van rectangle
                    int rectangleHeight = Convert.ToInt32(Console.ReadLine());
                    int rectangleWidth = Convert.ToInt32(Console.ReadLine());

                    // Output
                    printArea(calculateAreaOfRectangle(rectangleHeight, rectangleWidth));

                    break;
                case "circle":
                    Console.WriteLine("Calculate area of a circle");
                    // Input van circle
                    int radius = Convert.ToInt32(Console.ReadLine());

                    // Output
                    printArea(calculateAreaOfCircle(10));
                    break;
            }
        }

        // Generic functions
        static int calculateAreaOfRectangle(int height, int width = 10)
        {
            return height * width;
        }

        static double calculateAreaOfCircle(int radius)
        {
            return radius * radius * Math.PI;
        }

        static void printArea(int area)
        {
            Console.WriteLine("The area is " + area);
        }

        static void printArea(double area)
        {
            Console.WriteLine("The area is " + area);
        }

        static void printList(List <string> list)
        {
            foreach(string item in list)
            {
                Console.WriteLine(item);
            }
        }

        static int getLengthOfList(List<string> list)
        {
            return list.Count;
        }

        static List<string> reverseList(List<string> list)
        {
            List<string> newList = new List<string>();

            for(int index = list.Count - 1; index >= 0; index--)
            {
                newList.Add(list[index]);
            }

            return newList;
        }

    }

    
}


// - - - - Theory - - - - 

//
// Explain functions 
//





//
// Explain difference void and not void
//






//
// Explain parameters
//






//
// Random
//






//
// Explain Return
//





//
// Optional parameters
//





//
// Parameter overloading
//






// - - - - Practicum  - - - - 














// O: Hello to my crazy band generator

// O: You want to know a new band?
// I: YES
// O: the awesome jebus

// O: You want to know a new band?
// I: YES
// O: not ugly pigeon

// O: You want to know a new band?
// I: STOP
// O: THXBEY









// Golden boot voting
// Create text file 
// Collin - Lionel Messi 
// Elke - Kevin De Bruyne 
// Tristan - Lionel Messi 
// Charlie - Lionel Messi 
// O: Lionel Messi is the winner 











// Blackjack
// O: Welcome to the blackjack table 
// O: Commands
//      ----- CASE 1 ------
//      O: Your card is 5
//.     O:, Your total points are 5 want a new card? [Yes or No]
//      I: Yes
//      O: Your card is 1
//.     O: 1 is an ace . Option A: 1 point, Option B: 11 points [A or B]
//.     I: B
//.     O: Your total points are 16 want a new card? [Yes or No]
//      I: Yes
//      O: Your card is 3
//      O: Your total points are 19 want a new card? [Yes or No]
//.     I: No
//      O: Your total points are 19, lets see what the dealer does.
//      O: The dealer has card 5, so 5 in total;
//      O: The dealer wants a new card
//      O: The dealer has card 10, so 15 in total;
//      O: The dealer wants a new card
//      O: The dealer has card 8, so 23 in total;
//      O: The dealer is broke, player1 wins


















// SPOTIFY (WHUT AGAIN)
// FASE 1:
// COMMANDS
//   I: LIST
//      O: DUA LIPA - ONE KISS
//      O: THE BEATLES - HEY JUDE
//      O: GIVE NEW COMMANDO [LIST, ADD A SONG, STOP]
//   I: ADD A SONG
//      ----- CASE 1 ------
//      O: ASK ARTIST
//      I: DUA LIPA
//      O: NEW ARTIST, CAN YOU GIVE ME THE SONG NAME?
//      I: ONE KISS
//      O: I'VE ADDED DUA LIPA - ONE KISS
//      O: GIVE NEW COMMANDO [LIST, ADD A SONG, STOP]
//
//      ----- CASE 2 ------
//      O: ASK ARTIST
//      I: THE BEATLES
//      O: THE BEATLES IS IN LIST, DO YOU WANT TO THE SONG "YELLOW SUBMARINE" OVERWRITE?
//         ----- SUBCASE 2.1
//         I: Y
//         O: CAN YOU GIVE ME THE SONG?
//         I: HEY JUDE
//         O: I'VE ADDED THE BEATLES - HEY JUDE
//         O: GIVE NEW COMMANDO [LIST, ADD A SONG, STOP]
//
//         ----- SUBCASE 2.1
//         I: N
//         O: GIVE NEW COMMANDO [LIST, ADD A SONG, STOP]
//   I: STOP
//      O: GOODBYE
//   I: LIST SONGS
//      O: ERROR, I DON'T RECOGNISE THE COMMANDO

// SPOTIFY ARTIST CAN HAVE MULTIPLE SONGS
// FASE 2:
// COMMANDS
//   I: LIST
//      O: DUA LIPA - ONE KISS
//      O: THE BEATLES - HEY JUDE
//      O: THE BEATLES - YELLOW SUBMARINE
//      O: GIVE NEW COMMANDO [LIST, ADD A SONG, STOP]
//   I: ADD A SONG
//      ----- CASE 1 ------
//      O: ASK ARTIST
//      I: DUA LIPA
//      O: NEW ARTIST, CAN YOU GIVE ME THE SONG NAME?
//      I: ONE KISS
//      O: I'VE ADDED DUA LIPA - ONE KISS
//      O: GIVE NEW COMMANDO [LIST, ADD A SONG, STOP]
//
//      ----- CASE 2 ------
//      O: ASK ARTIST
//      I: THE BEATLES
//      O: THE BEATLES IS IN LIST, DO YOU WANT TO TO ADD A NEW SONG?
//         ----- SUBCASE 2.1
//         I: Y
//         O: CAN YOU GIVE ME THE SONG?
//         I: HEY JUDE
//         O: I'VE ADDED THE BEATLES - HEY JUDE
//         O: GIVE NEW COMMANDO [LIST, ADD A SONG, STOP]
//         -----SUBCASE 2.2
//         I: N
//         O: GIVE NEW COMMANDO [LIST, ADD A SONG, STOP]
//   I: STOP
//      O: GOODBYE
//   I: LIST SONGS
//      O: ERROR, I DON'T RECOGNISE THE COMMANDO

// SPOTIFY RECOGNIZE LIST AND LIST SONGS
// FASE 3:
// COMMANDS
//   I: LIST
//      O: DUA LIPA - ONE KISS
//      O: THE BEATLES - HEY JUDE
//      O: THE BEATLES - YELLOW SUBMARINE
//      O: GIVE NEW COMMANDO [LIST, LIST SONGS, ADD A SONG, STOP]
//   I: LIST SONGS
//      O: DUA LIPA - ONE KISS
//      O: THE BEATLES - HEY JUDE
//      O: THE BEATLES - YELLOW SUBMARINE
//      O: GIVE NEW COMMANDO [LIST, LIST SONGS, ADD A SONG, STOP]
//   I: ADD A SONG
//      ----- CASE 1 ------
//      O: ASK ARTIST
//      I: DUA LIPA
//      O: NEW ARTIST, CAN YOU GIVE ME THE SONG NAME?
//      I: ONE KISS
//      O: I'VE ADDED DUA LIPA - ONE KISS
//      O: GIVE NEW COMMANDO [LIST, ADD A SONG, STOP]
//
//      ----- CASE 2 ------
//      O: ASK ARTIST
//      I: THE BEATLES
//      O: THE BEATLES IS IN LIST, DO YOU WANT TO TO ADD A NEW SONG?
//         ----- SUBCASE 2.1
//         I: Y
//         O: CAN YOU GIVE ME THE SONG?
//         I: HEY JUDE
//         O: I'VE ADDED THE BEATLES - HEY JUDE
//         O: GIVE NEW COMMANDO [LIST, LIST SONGS, ADD A SONG, STOP]
//         -----SUBCASE 2.2
//         I: N
//         O: GIVE NEW COMMANDO [LIST, LIST SONGS, ADD A SONG, STOP]
//   I: STOP
//      O: GOODBYE
//   I: GIVE ME A SONG
//      O: ERROR, I DON'T RECOGNISE THE COMMANDO

// SPOTIFY PLAY A SONG

// FASE 4:
// COMMANDS
//   I: LIST
//      O: DUA LIPA - ONE KISS
//      O: THE BEATLES - HEY JUDE
//      O: THE BEATLES - YELLOW SUBMARINE
//      O: GIVE NEW COMMANDO [LIST, LIST SONGS, ADD A SONG, PLAY A SONG, STOP]
//   I: LIST SONGS
//      O: DUA LIPA - ONE KISS
//      O: THE BEATLES - HEY JUDE
//      O: THE BEATLES - YELLOW SUBMARINE
//      O: GIVE NEW COMMANDO [LIST, LIST SONGS, ADD A SONG, PLAY A SONG, STOP]
//   I: ADD A SONG
//      ----- CASE 1 ------
//      O: ASK ARTIST
//      I: DUA LIPA
//      O: NEW ARTIST, CAN YOU GIVE ME THE SONG NAME?
//      I: ONE KISS
//      O: I'VE ADDED DUA LIPA - ONE KISS
//      O: GIVE NEW COMMANDO [LIST, ADD A SONG, STOP]
//
//      ----- CASE 2 ------
//      O: ASK ARTIST
//      I: THE BEATLES
//      O: THE BEATLES IS IN LIST, DO YOU WANT TO TO ADD A NEW SONG?
//         ----- SUBCASE 2.1
//         I: Y
//         O: CAN YOU GIVE ME THE SONG?
//         I: HEY JUDE
//         O: I'VE ADDED THE BEATLES - HEY JUDE
//         O: GIVE NEW COMMANDO [LIST, LIST SONGS, ADD A SONG, PLAY A SONG, STOP]
//         -----SUBCASE 2.2
//         I: N
//         O: GIVE NEW COMMANDO [LIST, LIST SONGS, ADD A SONG, PLAY A SONG, STOP]
//   I: STOP
//      O: GOODBYE
//   I: PLAY ME A SONG
//      ----- CASE 1 ------
//      O: WHAT SONG DO YOU WANT TO HEAR?
//      I: DUA LIPA - ONE KISS
//      O: PLAYING DUA LIPA
//      O: GIVE NEW COMMANDO [LIST, LIST SONGS, ADD A SONG, PLAY A SONG, STOP]
//
//      ----- CASE 2 ------
//      O: WHAT SONG DO YOU WANT TO HEAR?
//      I: PEARL JAM - ALIVE
//      O: CAN NOT FIND THIS SONG
//      O: GIVE NEW COMMANDO [LIST, LIST SONGS, ADD A SONG, PLAY A SONG, STOP]
//   I: GIVE ME A SONG
//      O: ERROR, I DON'T RECOGNISE THE COMMANDO
//      O: GIVE NEW COMMANDO [LIST, LIST SONGS, ADD A SONG, PLAY A SONG, STOP]

// SPOTIFY ARTIST PLAY A RANDOM SONG
// FASE 5:
// COMMANDS
//   I: LIST
//      O: DUA LIPA - ONE KISS
//      O: THE BEATLES - HEY JUDE
//      O: THE BEATLES - YELLOW SUBMARINE
//      O: GIVE NEW COMMANDO [LIST, LIST SONGS, ADD A SONG, PLAY A SONG, STOP]
//   I: LIST SONGS
//      O: DUA LIPA - ONE KISS
//      O: THE BEATLES - HEY JUDE
//      O: THE BEATLES - YELLOW SUBMARINE
//      O: GIVE NEW COMMANDO [LIST, LIST SONGS, ADD A SONG, PLAY A SONG, STOP]
//   I: ADD A SONG
//      ----- CASE 1 ------
//      O: ASK ARTIST
//      I: DUA LIPA
//      O: NEW ARTIST, CAN YOU GIVE ME THE SONG NAME?
//      I: ONE KISS
//      O: I'VE ADDED DUA LIPA - ONE KISS
//      O: GIVE NEW COMMANDO [LIST, ADD A SONG, STOP]
//
//      ----- CASE 2 ------
//      O: ASK ARTIST
//      I: THE BEATLES
//      O: THE BEATLES IS IN LIST, DO YOU WANT TO TO ADD A NEW SONG?
//         ----- SUBCASE 2.1
//         I: Y
//         O: CAN YOU GIVE ME THE SONG?
//         I: HEY JUDE
//         O: I'VE ADDED THE BEATLES - HEY JUDE
//         O: GIVE NEW COMMANDO [LIST, LIST SONGS, ADD A SONG, PLAY A SONG, STOP]
//         -----SUBCASE 2.2
//         I: N
//         O: GIVE NEW COMMANDO [LIST, LIST SONGS, ADD A SONG, PLAY A SONG, STOP]
//   I: STOP
//      O: GOODBYE
//   I: PLAY ME A SONG
//      ----- CASE 1 ------
//      O: WHAT SONG DO YOU WANT TO HEAR?
//      I: DUA LIPA - ONE KISS
//      O: PLAYING DUA LIPA
//      O: GIVE NEW COMMANDO [LIST, LIST SONGS, ADD A SONG, PLAY A SONG, STOP]
//
//      ----- CASE 2 ------
//      O: WHAT SONG DO YOU WANT TO HEAR?
//      I: PEARL JAM - ALIVE
//      O: CAN NOT FIND THIS SONG
//      O: GIVE NEW COMMANDO [LIST, LIST SONGS, ADD A SONG, PLAY A SONG, STOP]
//   I: PLAY ME A RANDOM SONG
//      O: PLAYING DUA LIPA - ONE KISS
//      O: GIVE NEW COMMANDO [LIST, LIST SONGS, ADD A SONG, PLAY A SONG, STOP]
//   I: GIVE ME A SONG
//      O: ERROR, I DON'T RECOGNISE THE COMMANDO
//      O: GIVE NEW COMMANDO [LIST, LIST SONGS, ADD A SONG, PLAY A SONG, STOP]