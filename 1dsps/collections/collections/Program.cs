using System;
using System.Collections.Generic;

namespace collections
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Assignment 1: Grades avg with arrays
            // O: How many studens do you have?
            // I: 4
            // O: Grade for student 1
            // I: 12
            // O: Grade for student 2
            // I: 14
            // O: Grade for student 3
            // I: 12
            // O: Grade for student 4
            // I: 14
            // O: The average for following test
            // O: Student 1 has a score of 12
            // O: Student 2 has a score of 14
            // O: Student 3 has a score of 12
            // O: Student 4 has a score of 14
            // O: Total average is 13

            //Console.WriteLine("How many studens do you have?");
            //int amountOfStudents = Convert.ToInt16(Console.ReadLine());
            //int[] grades = new int[amountOfStudents];

            //// fill up the grades
            //for (int index = 0; index < grades.Length; index++)
            //{
            //    Console.WriteLine($"Grade for student {index + 1}");
            //    int grade = Convert.ToInt16(Console.ReadLine());

            //    grades[index] = grade;
            //}

            //// Output
            //double totalAmountOfGrades = 0;
            //for (int index = 0; index < grades.Length; index++)
            //{
            //    totalAmountOfGrades += grades[index];
            //    Console.WriteLine($"Grade for student {index + 1} is {grades[index]}");
            //}

            //double avg = totalAmountOfGrades / grades.Length;
            //Console.WriteLine($"Total average is {avg}");

            //List<string> kids = new List<string>() { "Steve", "Collin", "Sharon"};
            //string[] otherKids = { "Lisa", "Elien" };

            //kids.AddRange(otherKids);

            //kids.Insert(1, "Natascha");
            ////kids.Add("Steve");
            ////kids.Add("Collin");
            ////kids.Add("Sharon");

            ////kids.Remove("Collin");
            //kids.RemoveAt(1);

            //Console.WriteLine(kids.IndexOf("Sharon"));

            //// Loop over the kids
            //for (int index = 0; index < kids.Count; index++)
            //{
            //    Console.WriteLine(kids[index]);
            //}

            //foreach(string kid in kids)
            //{
            //    Console.WriteLine(kid);
            //}


            //List<string> kids = new List<string>() { "Steve", "Collin", "Sharon" };
            //kids.Add("Steve");

            // Assignment 1: Grades avg with arrays
            // O: When user type STOP show the average, otherwise add grade to grades
            // I: 12
            // I: 14
            // I: 12
            // I: 14
            // I: STOP
            // O: The average for following test
            // O: Student 1 has a score of 12
            // O: Student 2 has a score of 14
            // O: Student 3 has a score of 12
            // O: Student 4 has a score of 14
            // O: Total average is 13

            //Console.WriteLine("When user type STOP show the average, otherwise add grade to grades");

            //string commando = Console.ReadLine();
            //List<int> gradebook = new List<int>();

            //// Input of grades
            //while (commando.ToLower() != "stop")
            //{
            //    // Convert it and add into the list
            //    int grade = Convert.ToInt16(commando);
            //    gradebook.Add(grade);

            //    // Ask a new commando
            //    commando = Console.ReadLine();
            //}

            //// Output of grades
            //int totalAmountOfGrades = 0;
            //for (int index = 0; index < gradebook.Count; index++)
            //{
            //    Console.WriteLine($"Student {index + 1} has a score of {gradebook[index]}");

            //    totalAmountOfGrades += gradebook[index];
            //}

            //double avg = totalAmountOfGrades / gradebook.Count;

            //Console.WriteLine($"The avg is {avg}");


            //List<int> gradebook = new List<int>();
            // 
            // Assignment 3: Spelling checker
            // O: Give the name that the user has to spell
            // I: Jan
            // O: Allright can you spell the word? [use STOP to stop typing]
            // I: j
            // I: a
            // I: n
            // I: stop 
            // O: You spelled Jan correctly
            //

            // Version 1

            //Console.WriteLine("Give the name that the user has to spell");
            //string name = Console.ReadLine();

            //Console.WriteLine("Allright can you spell the word? [use STOP to stop typing]");

            //string commando = Console.ReadLine();
            //string spelledName = "";

            //while (commando.ToLower() != "stop")
            //{
            //    spelledName +=commando;

            //    commando = Console.ReadLine();
            //}

            //if (name == spelledName)
            //{
            //    Console.WriteLine("Correctly spelled");
            //} else
            //{
            //    Console.WriteLine("Not correctly spelled");
            //}

            //// Version 2
            //Console.WriteLine("Give the name that the user has to spell");
            //string name = Console.ReadLine();

            //Console.WriteLine("Allright can you spell the word? [use STOP to stop typing]");

            //string commando = Console.ReadLine();
            //List<string> spelledCharacters = new List<string>();

            //// Fill up our spelledCharacters list
            //while (commando.ToLower() != "stop")
            //{
            //    spelledCharacters.Add(commando);

            //    commando = Console.ReadLine();
            //}

            ////
            //bool isMatch = true;

            //for (var index = 0; index < spelledCharacters.Count; index++)
            //{
            //    if (spelledCharacters[index] != Convert.ToString(name[index]))
            //    {
            //        isMatch = false;
            //    } 
            //}

            //if (isMatch)
            //{
            //    Console.WriteLine("Correctly spelled");
            //} else
            //{
            //    Console.WriteLine("Not correctly spelled");
            //}

            //Dictionary<string, double> gradebook = new Dictionary<string, double>();

            //gradebook["collin"] = 20;
            //gradebook.Add("lisa", 12);

            //gradebook.Remove("Lisa");

            //foreach(string studentname in gradebook.Keys) {
            //    Console.WriteLine($"{studentname} has a score of {gradebook[studentname]}");
            //}

            //foreach (double grade in gradebook.Values)
            //{
            //    Console.WriteLine(grade);
            //}

            //foreach (var test in gradebook)
            //{
            //    Console.WriteLine(test.Key);
            //    Console.WriteLine(test.Value);
            //}

            //Console.Write(gradebook.Count);

            //Dictionary<string, List<int>> gradebook = new Dictionary<string, List<int>>();

            //gradebook["collin"] = new List<int>();
            //gradebook["collin"].Add(20);
            //gradebook["collin"].Add(12);
            //gradebook["collin"].Add(16);

            //gradebook["lisa"] = new List<int>();
            //gradebook["lisa"].Add(10);

            //foreach (var student in gradebook)
            //{
            //    double totalAmountOfGrades = 0;

            //    foreach(int grade in student.Value)
            //    {
            //        totalAmountOfGrades += grade;
            //    }

            //    double avg = totalAmountOfGrades / student.Value.Count;
            //    Console.WriteLine($"{student.Key} has an avg of {avg}"); 
            //}

            //
            // O: There are 2 students:
            // O: Collin has an average of 16
            // O: Lisa has an average of 10
            //


            // Using a dictionary list for todolist
            // Output: Add to dos in your dictionary, say STOP to enter the input of to dos
            // Input: learn c#
            // Input: learn javascript
            // Input: clean my room
            // Input: STOP
            // Output: Here are your todos:
            // Output: 1. learn c#
            // Output: 2. learn javascript
            // Output: 3. clean my room
            // Output: Do you wish to uncheck an item? (say STOP to stop the program)
            // Input: learn c#
            // Output: Here are your todos:
            // Output: 1. learn javascript
            // Output: 2. clean my room
            // Output: Here the checked todos:
            // Output: 1. learn c#
            //Dictionary<string, bool> todos = new Dictionary<string, bool>();


            //// Part 1: getting the data
            //Console.WriteLine("Add to dos in your dictionary, say STOP to enter the input of to dos");
            //string todo = Console.ReadLine();

            //while (todo.ToLower() != "stop")
            //{
            //    // add to do to to do - list 
            //    todos[todo] = true;

            //    // ask again a todo ar a stop
            //    todo = Console.ReadLine();
            //}

            //// Part 2 : displaying
            //foreach (var item in todos)
            //{
            //    Console.WriteLine(item.Key);
            //}

            //// Part 3: unchecking
            //Console.WriteLine("Do you wish to uncheck an item ? (say STOP to stop the program)");
            //string commando = Console.ReadLine();

            //while (commando != "stop")
            //{
            //    // check if it is existing and change the status of the todo
            //    if (todos.ContainsKey(commando))
            //    {
            //        todos[commando] = !todos[commando];

            //        // Show the unchecked items
            //        Console.WriteLine("Unchecked items:");
            //        foreach (var item in todos)
            //        {
            //            if (item.Value == true)
            //            {
            //                Console.WriteLine(item.Key);
            //            }
            //        }

            //        // Show the checked item
            //        Console.WriteLine("Checked items:");
            //        foreach (var item in todos)
            //        {
            //            if (item.Value == false)
            //            {
            //                Console.WriteLine(item.Key);
            //            }
            //        }
            //    }


            //    // Ask new commando
            //    commando = Console.ReadLine();
            //}


            //
            // Spotify
            // COMMANDS
            //     ADD A SONG
            //     LIST ALL ARTISTS
            //     LIST ALL SONGS OF ARTIST
            //     STOP

            // I: ADD A SONG
            // O: Name of artist:
            // I: Justin Bwieber
            // O: Name of song:
            // I: Baby
            // O: Justin Bwieber - Baby has been added
            //
            // I: ADD A SONG
            // O: Name of artist:
            // I: Justin Bwieber
            // O: Name of song:
            // I: Adult
            // O: Justin Bwieber - Adult has been added
            //
            // I: LIST ALL ARTISTS
            // O: 1. Justin Bwieber
            //
            // I: LIST ALL SONGS OF ARTIST
            // I: Justin Bwieber
            // O: 1. Baby
            // O: 2. Adult
            //
            // I: STOP
            // O: ThxBye


            //
            // Spotify
            // COMMANDS
            //     ADD A SONG
            //     LIST ARTISTS
            //     LIST SONGS OF ARTIST
            //     STOP

            //string commando = Console.ReadLine().ToLower();
            //Dictionary<string, List<string>> spotify = new Dictionary<string, List<string>>();

            //while (commando != "stop")
            //{

            //    switch (commando)
            //    {
            //        case "add a song":
            //            // Ask input 
            //            Console.WriteLine("Name of the artist");
            //            string artistname = Console.ReadLine();
            //            Console.WriteLine("Name of song");
            //            string songname = Console.ReadLine();

            //            // Check if artist name is existig, if not add new list to it
            //            if (spotify.ContainsKey(artistname) == false)
            //            {
            //                spotify[artistname] = new List<string>();
            //            }   

            //            // Check if song is already in the list 
            //            if (spotify[artistname].Contains(songname) == false)
            //            {
            //                spotify[artistname].Add(songname);
            //            } else
            //            {
            //                Console.WriteLine("Sorry, song is already in here");
            //            }


            //            break;
            //        case "list artists":
            //            // Loop over the artist 
            //            foreach (string artist in spotify.Keys)
            //            {
            //                Console.WriteLine(artist);
            //            }
            //            break;
            //        case "list songs of artist":
            //            Console.WriteLine("Which artist?");
            //            string artist2 = Console.ReadLine();

            //            // Check if artist is existing, if it is then show the songs
            //            if (spotify.ContainsKey(artist2))
            //            {
            //                // loop over the songs of an artist
            //                foreach (string song2 in spotify[artist2])
            //                {
            //                    Console.WriteLine(song2);
            //                }
            //            }

            //            break;
            //        default:
            //            Console.WriteLine("What bruh, I don't understand the commando");
            //            break;
            //    }

            //    // Ask new commando
            //    commando = Console.ReadLine().ToLower();

            //}

            // 1ste woord
            string word = Console.ReadLine(); // *-*
            string[] words = new string[word.Length];
            words[0] = word;

            // loop
            for (int index = 1; index < word.Length; index++)
            {
                words[index] = Console.ReadLine();
            }

            // Output
            for (int index = word.Length - 1; index >= 0; index++)
            {
                Console.WriteLine(words[index]);
            }





        }


    }
}


// 










// 
// Theory for list 
// 

// 
// Assignment 2: Grades avg with list  (IN GROUP)
// 







// Theory for dictionairy 
// 
// 
// Assignment 4: Gradebook with names  (IN GROUP)
// 

// Possible exercises
// 
// Assignment 5: Gradebook with names  (INDIVIDUAL)
// 



//
// Exercise:
// Gradebook
// COMMANDS
//     [ADD STUDENT] [ADD GRADE] [AVERAGE STUDENTS] [AVERAGE GRADES] [LIST STUDENTS] [STOP]
//
// I: ADD STUDENT
// O: What is the name of the student?
// I: Collin
// O: Collin added
//
// I: ADD STUDENT
// O: What is the name of the student?
// I: Elvis
// O: Elvis added
//
// I: ADD GRADE
// O: For what student?
// I: Collin
// O: What result
// I: 15
//
// I: ADD GRADE
// O: For what student?
// I: Elvis
// O: What result
// I: 17
//
// I: AVERAGE STUDENTS
// O: Avg collin is 15
// O: Avg elvis is 17
//
// I: AVERAGE GRADES
// O: Avg test 16
//
// I: LIST STUDENTS
// O: Students are Collin, Elvis

//

