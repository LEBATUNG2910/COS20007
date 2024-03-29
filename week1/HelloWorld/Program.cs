﻿using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Message myMessage;
            Message[] messages = new Message[5];
            string name;

            myMessage = new Message("Hello World - from Message Object ");
            myMessage.Print();

            messages[0] = new Message("Welcome back!");
            messages[1] = new Message("What a lovely name");
            messages[2] = new Message("Great name");
            messages[3] = new Message("Oh hi!");
            messages[4] = new Message("That is a silly name");

            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();

            if (name.ToLower() == "mark")
            {
                messages[0].Print();
            }

            else if (name.ToLower() == "fred")
            {
                messages[1].Print();
            }

            else if (name.ToLower() == "wilma")
            {
                messages[2].Print();
            }

            else if (name.ToLower() == "alice")
            {
                messages[3].Print();
            }

            else
            {
                messages[4].Print();
            }

            Console.ReadLine();
        }
    }
}