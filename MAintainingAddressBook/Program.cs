﻿using System;
using MaintainingAddressBook;
public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("********** Welcome in this Address Book ************");
        AddressBook addressBook = new AddressBook();
        Console.WriteLine("Please Enter the Information");
        bool check = true;
        Console.WriteLine(" Enter the Zero to Stop The Execution 0\n Display The Information1\n Edit the Information 2\n");

        while (check)
        {
            Console.WriteLine("***** Please Enter The Above Information *******");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1: addressBook.Display(); break;
                case 2:
                    Console.WriteLine("Enter the Name for Edit the Information");
                    string name = Console.ReadLine();
                    addressBook.EditContactInAddressBook(name); break;
                case 0: check = false; break;
            }

        }
    }
}
