﻿using System;
using System.Collections.Generic;

namespace MSDN_Example02
{
    public class Part : IEquatable<Part>, IComparable<Part>
    {
        public string PartName { get; set; }
        public int PartId { get; set; }
        public override string ToString()
        {
            return "ID: " + PartId + " Name: " + PartName;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Part objAsPart = obj as Part;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }
        public int SortByNameAscending(string name1, string name2)
        {
            return name1.CompareTo(name2);
        }
        // Default comparer for Part type.
        public int CompareTo(Part comparePart)
        {
            // A null value means that this object is greater.
            if (comparePart == null)
                return 1;

            else
                return this.PartId.CompareTo(comparePart.PartId);
        }
        public override int GetHashCode()
        {
            return PartId;
        }
        public bool Equals(Part other)
        {
            if (other == null) return false;
            return (this.PartId.Equals(other.PartId));
        }
        // Should also override == and != operators.

        class Program
        {
            static void Main(string[] args)
            {
                List<Part> parts = new List<Part>();

                // Add parts to the list.
                parts.Add(new Part() { PartName = "regular seat", PartId = 1434 });
                parts.Add(new Part() { PartName = "crank arm", PartId = 1234 });
                parts.Add(new Part() { PartName = "shift lever", PartId = 1634 }); ;
                // Name intentionally left null.
                parts.Add(new Part() { PartId = 1334 });
                parts.Add(new Part() { PartName = "banana seat", PartId = 1444 });
                parts.Add(new Part() { PartName = "cassette", PartId = 1534 });

                //Wite out the parts in the list. This will call the overridden
                //ToString method in the Part class.
                Console.WriteLine("\nBefore sort:");
                foreach (Part aPart in parts)
                {
                    Console.WriteLine(aPart);
                }

                // Call Sort on the list. This will use the 
                // default comparer, which is the Compare method 
                // implemented on Part.
                parts.Sort();

                Console.WriteLine("\nAfter sort by part number:");
                foreach (Part aPart in parts)
                {
                    Console.WriteLine(aPart);
                }
                parts.Sort(delegate (Part x, Part y)
                {
                    if (x.PartName == null && y.PartName == null) return 0;
                    else if (x.PartName == null) return -1;
                    else if (y.PartName == null) return 1;
                    else return x.PartName.CompareTo(y.PartName);
                });

                Console.WriteLine("\nAfter sort by name:");
                foreach (Part aPart in parts)
                {
                    Console.WriteLine(aPart);
                }

                Console.Read();
            }
        }
    }
}
