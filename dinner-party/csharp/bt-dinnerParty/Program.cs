using System;
using System.Collections.Generic;
using System.Linq;

namespace bt_dinnerParty
{
    class Program
    {
        static void Main(string[] args)

        {
            List<Guest> theGuests = GetGuests();
            // List<Table> tables = GetTable();
            List<string> tables = new List<string>() {};

            foreach (Guest guest in theGuests)
            {
                List<string> table1Occupations = tables[0].Select(g => g.Occupation);
                if (table1Occupations.Contains(guest.Occupation))
                {
                    tables[1].Add(guest);
                }
                else
                {
                    tables[0].Add(guest);
                }
            }

        }

        public static List<Table> GetTable()
        {
            List<Table> tables = new List<Table>
            {
                new Table
                {
                Tables = "Table 1"
                },
                new Table
                {
                Tables = "Table 2"
                },
            };
            return tables;
        }

        public static List<Guest> GetGuests()
        {
            List<Guest> guest = new List<Guest>
            {
                new Guest
                {
                    Name = "Marilyn Monroe",
                        Occupation = "entertainer",
                        Bio = new List<string> { "(1926 - 1962) American actress, singer, model" },
                },
                new Guest
                {
                    Name = "Abraham Lincoln",
                        Occupation = "politician",
                        Bio = new List<string> { "(1809 - 1865) US President during American civil war" },
                },
                new Guest
                {
                    Name = "Martin Luther King",
                        Occupation = "activist",
                        Bio = new List<string> { "(1929 - 1968)  American civil rights campaigner" },
                },
                new Guest
                {
                    Name = "Rosa Parks",
                        Occupation = "activist",
                        Bio = new List<string> { "(1913 - 2005)  American civil rights activist" },
                },
                new Guest
                {
                    Name = "Peter Selllers",
                        Occupation = "entertainer",
                        Bio = new List<string> { "(1925 - 1980) British actor and comedian" },
                },
                new Guest
                {
                    Name = "Alan Turing",
                        Occupation = "computer scientist",
                        Bio = new List<string> { "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world" },
                },
                new Guest
                {
                    Name = "Admiral Grace Hopper",
                        Occupation = "computer scientist",
                        Bio = new List<string> { "(1906–1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds" },
                },
                new Guest
                {
                    Name = "Indira Gandhi",
                        Occupation = "politician",
                        Bio = new List<string> { "(1917 - 1984) Prime Minister of India 1966 - 1977" },
                },
            };
            return guest;
        }

    }

    public class Guest
    {
        public string Name { get; set; }
        public string Occupation { get; set; }
        public List<string> Bio { get; set; }

    }

    public class Table
    {
        public string Tables { get; set; }

    }
}