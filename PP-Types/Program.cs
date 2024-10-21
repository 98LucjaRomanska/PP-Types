// Write required code.

// Data - do not change it in code!
using System.ComponentModel.DataAnnotations;

string[] names = {
    "Mickey Mouse", "Minnie Mouse", "Donald Duck", "Goofy", "Pluto", "Daisy Duck", "Simba", "Nala", 
    "Timon", "Pumbaa", "Mufasa", "Ariel", "Flounder", "Sebastian", "Ursula", "Belle", "Beast", "Gaston", 
    "Cinderella", "Prince Charming", "Aurora", "Maleficent", "Rapunzel", "Flynn Rider", "Elsa", "Anna", 
    "Olaf", "Moana", "Maui", "Hercules"
};


// Print all array elements, *perLine* elements per one line
// After all elements except last one should be ", " - also on the end of lines.
// After last element should be ".".
void PrintGroups(string[] t, int perLine)
{

    for (int i = 0; i < names.Length; i++)
    {
        int j = i + 1; //j - counter
        if (i != names.Length - 1)
        {
            if (j%perLine != 0)
                Console.Write(names[i] + ",");
            else
                Console.WriteLine(names[i]+ ",");

        }
        else
            Console.Write(names[^1] + ".");

    }
    Console.WriteLine(names.Count());

}


// Print all array elements in *perLine* columns.
// Each column must have given *width* (number of chars).
// Columns should be separated by "| ".
// If element is too long it should be trimmed.

void PrintColumns(string[] t, int perLine, int width)
{

    for (int count = 0; count < names.Length; count++)
    {
        int j = width - names[count].Length; //how much blank spaces I need to produce
       
        //Console.Write(name.Length);
        if (names[count].Length <= width && (count+1) %perLine != 0) // && 20/ 4 = 5 r.0 18/4= 4r2 wynik = 2
        {
            Console.Write(names[count]);
            for (int i = 0; i < j; i++)
            {
                Console.Write(" ");         //untill "i" reaches 16  
            }
            Console.Write("| ");
        }
        else if(names[count].Length <= width && (count+1) %perLine == 0)
        {

            Console.Write(names[count]);
            for (int i = 0; i < j; i++)
            {
                Console.Write(" ");
            }
            Console.Write("\n");
        }
        else if(names[count].Length > width && (count + 1)% perLine != 0)
        {
            Console.Write(names[count][..width]+"| ");
        }
        else if(names[count].Length > width && (count + 1) %perLine ==0)
        {
            //int length_set = width + 1;
            Console.Write(names[count][..width]+"\n");
        }

    }
}
    // Test how your functions work. 
    // You can temprary comment some lines not needed for current testing.


    Console.WriteLine("\nPrintGroups(names, 3):\n");
    PrintGroups(names, 3);
    /*
    Mickey Mouse, Minnie Mouse, Donald Duck,
    Goofy, Pluto, Daisy Duck,
    Simba, Nala, Timon,
    Pumbaa, Mufasa, Ariel,
    Flounder, Sebastian, Ursula,
    Belle, Beast, Gaston,
    Cinderella, Prince Charming, Aurora,
    Maleficent, Rapunzel, Flynn Rider,
    Elsa, Anna, Olaf,
    Moana, Maui, Hercules.
    */

    Console.WriteLine("\nPrintGroups(names, 5):\n");
    PrintGroups(names, 5);
    /*
    Mickey Mouse, Minnie Mouse, Donald Duck, Goofy, Pluto,
    Daisy Duck, Simba, Nala, Timon, Pumbaa,
    Mufasa, Ariel, Flounder, Sebastian, Ursula,
    Belle, Beast, Gaston, Cinderella, Prince Charming,
    Aurora, Maleficent, Rapunzel, Flynn Rider, Elsa,
    Anna, Olaf, Moana, Maui, Hercules. 
    */

    Console.WriteLine("\nPrintGroups(names, 7):\n");
    PrintGroups(names, 7);
    /*
    Mickey Mouse, Minnie Mouse, Donald Duck, Goofy, Pluto, Daisy Duck, Simba,
    Nala, Timon, Pumbaa, Mufasa, Ariel, Flounder, Sebastian,
    Ursula, Belle, Beast, Gaston, Cinderella, Prince Charming, Aurora,
    Maleficent, Rapunzel, Flynn Rider, Elsa, Anna, Olaf, Moana,
    Maui, Hercules.
    */

    // For width = 40 don't worry if result will be wrapped due to screen width.
    Console.WriteLine("\nPrintGroups(names, 40):\n");
    PrintGroups(names, 40);
    /*
    Mickey Mouse, Minnie Mouse, Donald Duck, Goofy, Pluto, Daisy Duck, Simba, Nala, Timon, Pumbaa, Mufasa, Ariel, Flounder,
    Sebastian, Ursula, Belle, Beast, Gaston, Cinderella, Prince Charming, Aurora, Maleficent, Rapunzel, Flynn Rider, Elsa, A
    nna, Olaf, Moana, Maui, Hercules.
    */

    Console.WriteLine("\n\nPrintColumns(names, 4, 17):\n");
    PrintColumns(names, 4, 17);
    /*
    Mickey Mouse     | Minnie Mouse     | Donald Duck      | Goofy
    Pluto            | Daisy Duck       | Simba            | Nala
    Timon            | Pumbaa           | Mufasa           | Ariel
    Flounder         | Sebastian        | Ursula           | Belle
    Beast            | Gaston           | Cinderella       | Prince Charming
    Aurora           | Maleficent       | Rapunzel         | Flynn Rider
    Elsa             | Anna             | Olaf             | Moana
    Maui             | Hercules         |
    */

    Console.WriteLine("\n\nPrintColumns(names, 5, 15):\n");
    PrintColumns(names, 5, 15);
    /*
    Mickey Mouse   | Minnie Mouse   | Donald Duck    | Goofy          | Pluto
    Daisy Duck     | Simba          | Nala           | Timon          | Pumbaa
    Mufasa         | Ariel          | Flounder       | Sebastian      | Ursula
    Belle          | Beast          | Gaston         | Cinderella     | Prince Charming
    Aurora         | Maleficent     | Rapunzel       | Flynn Rider    | Elsa
    Anna           | Olaf           | Moana          | Maui           | Hercules
    */

    Console.WriteLine("\n\nPrintColumns(names, 7, 10):\n");
    PrintColumns(names, 7, 10);

/*
Mickey Mou| Minnie Mou| Donald Duc| Goofy     | Pluto     | Daisy Duck| Simba     | Nala
Timon     | Pumbaa    | Mufasa    | Ariel     | Flounder  | Sebastian | Ursula    | Belle
Beast     | Gaston    | Cinderella| Prince Cha| Aurora    | Maleficent| Rapunzel  | Flynn Ride
Elsa      | Anna      | Olaf      | Moana     | Maui      | Hercules  |
*/
