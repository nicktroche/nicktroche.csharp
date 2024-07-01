using System;

class Program
{
    static void Main()
    {
        // Unit Test #1
        string inputMessage1 = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.";
        Console.WriteLine("Unit Test 1: " + Twitter(inputMessage1));

        // Unit Test #2
        string inputMessage2 = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Id semper risus in hendrerit. Viverra mauris in aliquam sem. Arcu felis bibendum ut tristique et egestas quis. Pretium fusce id velit ut tortor pretium viverra suspendisse. Arcu cursus vitae congue mauris rhoncus aenean vel elit. In nisl nisi scelerisque eu ultrices. Mattis enim ut tellus elementum sagittis vitae et leo duis. In massa tempor nec feugiat. Feugiat nibh sed pulvinar proin. Elit ullamcorper dignissim cras tincidunt lobortis feugiat vivamus at. Scelerisque eu ultrices vitae auctor eu augue ut. Ac turpis egestas integer eget aliquet nibh praesent tristique. Viverra suspendisse potenti nullam ac tortor. Tortor id aliquet lectus proin. Dictum non consectetur a erat nam at lectus urna duis. Dui vivamus arcu felis bibendum ut tristique et egestas.";
        Console.WriteLine("Unit Test 2: " + Twitter(inputMessage2));

        // Unit Test #3
        string inputMessage3 = "Massa vitae tortor condimentum lacinia quis vel eros donec ac.";
        Console.WriteLine("Unit Test 3: " + Twitter(inputMessage3));

        // Unit Test #4
        string inputMessage4 = "Platea dictumst quisque sagittis purus sit amet volutpat consequat mauris.";
        Console.WriteLine("Unit Test 4: " + Twitter(inputMessage4));
    }

    static string Twitter(string message)
    {
        if (message.Length <= 140)
        {
            return "Posted";
        }
        else
        {
            return "Rejected";
        }
    }
}
