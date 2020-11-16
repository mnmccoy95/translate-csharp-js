using System;
using System.Collections.Generic;
using System.Linq;

namespace dinner_party
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Guest> guests = GetGuests();
            List<Table> tables = GetTables();
            foreach(Guest MyGuest in guests)
            {
                List<string> occupations = tables[0].TableGuests.Select(g => g.Occupation).ToList();
                if (occupations.Exists(occupation => occupation == MyGuest.Occupation))
                {
                    tables[1].TableGuests.Add(MyGuest);
                }
                else
                {
                    tables[0].TableGuests.Add(MyGuest);
                }
            }

            foreach(Table table in tables)
            {
                Console.WriteLine(table.TableName);
                foreach(Guest MyGuest in table.TableGuests)
                {
                    Console.WriteLine($"{MyGuest.Name} ({MyGuest.Occupation}) {MyGuest.Bio}");
                }
            }
        }

        public static List<Guest> GetGuests()
        {
            List<Guest> guests = new List<Guest> {
                new Guest {
                    Name = "Marilyn Monroe",
                    Occupation = "entertainer",
                    Bio = "(1926 - 1962) American actress, singer, model"
                },
                new Guest {
                    Name = "Abraham Lincoln",
                    Occupation = "politician",
                    Bio = "(1809 - 1865) US President during American civil war"
                },
                new Guest {
                    Name = "Martin Luther King",
                    Occupation = "activist",
                    Bio = "(1929 - 1968)  American civil rights campaigner"
                },
                new Guest {
                    Name = "Rosa Parks",
                    Occupation = "activist",
                    Bio = "(1913 - 2005)  American civil rights activist"
                },
                new Guest {
                    Name = "Peter Sellers",
                    Occupation = "entertainer",
                    Bio = "(1925 - 1980) British actor and comedian"
                },
                new Guest {
                    Name = "Alan Turing",
                    Occupation = "computer scientist",
                    Bio = "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"
                },
                new Guest {
                    Name = "Admiral Grace Hopper (1906–1992) – developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds",
                    Occupation = "computer scientist",
                    Bio = "(1906–1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"
                },
                new Guest {
                    Name = "Indira Gandhi",
                    Occupation = "politician",
                    Bio = "(1917 - 1984) Prime Minister of India 1966 - 1977"
                }
            };
            return guests;
        }

        public static List<Table> GetTables()
        {
            List<Table> tables = new List<Table> {
                new Table {
                    TableName = "Table 1",
                    TableGuests = new List<Guest>{}
                },
                new Table {
                    TableName = "Table 2",
                    TableGuests = new List<Guest>{}
                },
            };
            return tables;
        }
    }
    public class Guest
    {
        public string Name { get; set; }
        public string Occupation { get; set; }
        public string Bio { get; set; }
    }
    public class Table
    {
        public string TableName { get; set; }
        public List<Guest> TableGuests { get; set; }
    }
}
