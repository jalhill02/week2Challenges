
    {
        var date1 = new DateTime(2020, 9, 8, 14, 30, 0);
        Console.WriteLine(date1);
        var date2 = DateTime.Now;

        string currentTime = Console.WriteLine(date2.ToShortTimeString);

        if (currentTime < 12:00 PM)
        {
            Console.WriteLine("Good morning!");
        }


        else if (6:00 PM > currentTime && currentTime >= 12:00 PM)
        {

            Console.WriteLine("Good after noon");
        }

        else if (6:00 PM < currentTime && currentTime < 8:00 PM)
        {

            Console.WriteLine("Good evening!");
        }
        else
        {
            Console.WriteLine("Good night");
        }

    }

}
