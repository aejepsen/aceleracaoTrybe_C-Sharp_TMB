﻿using calendar_events;
using System;

public class Program
{

    public static void Main(string[] args)
    {
        EventList myEventList = new EventList();
        myEventList.Add(new Event("Evento sem descrição", "2015-05-05"));
        myEventList.Add(new Event("Evento completo", "2015-05-05", "esse vai ser bom"));

        Console.WriteLine(myEventList.SearchByDate("2015-05-05"));
    }

}