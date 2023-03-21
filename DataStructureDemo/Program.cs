﻿using System;
using System.Collections.Generic;

namespace DataStructureDemo
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Data Structures Problem!");
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            Console.WriteLine("Nodes in the list:");
            list.Display();

            // node in reverse order
            list.AddInReverseOrder(70);

            Console.WriteLine("\nNodes after adding node in reverse order:");
            list.Display();

            // node at a particular position
            list.InsertAtParticularPosition(2, 25);

            Console.WriteLine("\nNodes after inserting node at position 1:");
            list.Display();

            // Remove first node
            list.RemoveFirstNode();

            Console.WriteLine("\nNodes after removing first node:");
            list.Display();
        }
    }
}