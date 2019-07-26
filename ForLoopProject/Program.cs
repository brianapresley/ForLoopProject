using System;

namespace ForLoopProject {
    class Customer { // To find out if any customers are in SD or MT
        public string Name { get; set; }
        public string State { get; set; }
    }
    class Program {
        static void Main(string[] args) {

            Customer[] customers = {
                new Customer { Name = "PG", State = "OH" },
                new Customer { Name = "SDCust", State = "SD" },
                new Customer { Name = "MTCust", State = "MT" }
            };

            bool FoundSDCust = false;
            bool FoundMTCust = false;

            foreach(Customer cust in customers) {

                switch (cust.State) {
                    case "MT":
                        FoundMTCust = true;
                        break;
                    case "SD":
                        FoundSDCust = true;
                        break;
                }

                //if(cust.State == "MT") {
                //    FoundMTCust = true;
                //    continue; //Ends search for MT customers and forces loop to check for the next condition
                //}

                //if(cust.State == "SD") {
                //    FoundSDCust = true;
                //}

                //if (FoundMTCust && FoundSDCust) {
                //    break; //Ends search for MT and SD customers since they have already been located
                //}
            }
            Console.WriteLine($"Found MT customer: {FoundMTCust}");
            Console.WriteLine($"Found SD customer: {FoundSDCust}");
        }


        
    }
}




























//            int[] numbers = { 89, 188, 295, 943, 975, 277, 119,
//                            736, 952, 321, 521, 444, 758, 397,
//                            915, 878, 674, 701, 379, 331, 804,
//                            461, 459, 908, 373 };

//            string[] names = { "Brailee", "Briana", "Marianne", "Glenn", //To change the names to uppercase and concat all names 
//                                "Maggie", "Alex", "Jesse", "Titus" };

//            string allNames = ""; //To create a string variable, creates an empty string 

//            foreach(string name in names) {

//                string upperName = name.ToUpper();

//                allNames += upperName;
//            }

//            Console.WriteLine($"{allNames}"); // Or you can print using Console.Writeline(allNames)


//            int total = 0;

//            foreach(int Fred in numbers) {
//                total += Fred;
//            }

//            //for(int idx = 0; idx < ints.Length; idx++) {
//            //    total += ints[idx] * 3 / 4;
//            //}

//            decimal average = total / numbers.Length; //(decimal) is a CAST that treats the value after it as a different value type
//            Console.WriteLine($"Total: {total}, Average: {average}");
//        }
//    }
//}
