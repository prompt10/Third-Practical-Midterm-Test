using System;

namespace Third_Practical_Midterm_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int unit_No1Box, unit_No2Box, unit_No3Box, aTake, bTake;
            int BoxNum;
            bool done = false;

            //Box drafting phase
            do
            {
                Console.Write("Please input the amount of unit in 1st Box; ");
                unit_No1Box = int.Parse(Console.ReadLine());
            } while (unit_No1Box <= 0);
            do
            {
                Console.Write("Please input the amount of unit in 2nd Box; ");
                unit_No2Box = int.Parse(Console.ReadLine());
            } while (unit_No2Box <= 0);
            do
            {
                Console.Write("Please input the amount of unit in 3rd Box; ");
                unit_No3Box = int.Parse(Console.ReadLine());
            } while (unit_No3Box <= 0);

            //2-player cycle loop
            while (!done)
            {
                //A-choose&takes phase
                do
                {
                    Console.WriteLine("A turn:");
                    Console.Write("A takes from box No. ");
                    BoxNum = int.Parse(Console.ReadLine());
                    if (BoxNum == 1 && unit_No1Box > 0)
                    {
                        Console.WriteLine("A takes from box No.1 for:");
                        do
                        {
                            aTake = int.Parse(Console.ReadLine());
                            Console.Write(" unit(s)");
                            if (aTake == 1 || aTake == 2)
                            {
                                unit_No1Box = unit_No1Box - aTake;
                                Console.WriteLine("Now Box No.1 has {0} unit(s) left, Box No.2 has {1} unit(s) left, Box No.3 has {2} unit(s) left", unit_No1Box, unit_No2Box, unit_No3Box);
                            }
                            else
                            {
                                Console.WriteLine("Please input your take again.");
                            }
                        } while (aTake != 1 && aTake != 2);
                    }
                    if (BoxNum == 2 && unit_No2Box > 0)
                    {
                        Console.WriteLine("A takes from box No.2 for:");
                        do
                        {
                            aTake = int.Parse(Console.ReadLine());
                            Console.Write(" unit(s)");
                            if (aTake == 1 || aTake == 2)
                            {
                                unit_No2Box = unit_No2Box - aTake;
                                Console.WriteLine("Now Box No.1 has {0} unit(s) left, Box No.2 has {1} unit(s) left, Box No.3 has {2} unit(s) left", unit_No1Box, unit_No2Box, unit_No3Box);
                            }
                            else
                            {
                                Console.WriteLine("Please input your take again.");
                            }
                        } while (aTake != 1 && aTake != 2);
                    }
                    if (BoxNum == 3 && unit_No3Box > 0)
                    {
                        Console.WriteLine("A takes from box No.3 for:");
                        do
                        {
                            aTake = int.Parse(Console.ReadLine());
                            Console.Write(" unit(s)");
                            if (aTake == 1 || aTake == 2)
                            {
                                unit_No3Box = unit_No3Box - aTake;
                                Console.WriteLine("Now Box No.1 has {0} unit(s) left, Box No.2 has {1} unit(s) left, Box No.3 has {2} unit(s) left", unit_No1Box, unit_No2Box, unit_No3Box);
                            }
                            else
                            {
                                Console.WriteLine("Please input your take again.");
                            }
                        } while (aTake != 1 && aTake != 2);
                    }
                    //else
                    //{
                    //    Console.WriteLine("Please choose another box");
                    //}
                    //victory condition check
                    if (unit_No1Box == 0 && unit_No2Box == 0 && unit_No3Box == 0)
                    {
                        Console.WriteLine("All box out, B IS THE WINNER");
                        done = true;
                    }
                } while (BoxNum < 1 && BoxNum > 3);

                //B-choose&takes phase
                do
                {
                    Console.WriteLine("B turn:");
                    Console.Write("B takes from box No. ");
                    BoxNum = int.Parse(Console.ReadLine());
                    if (BoxNum == 1 && unit_No1Box > 0)
                    {
                        Console.WriteLine("B takes from box No.1 for:");
                        do
                        {
                            bTake = int.Parse(Console.ReadLine());
                            Console.Write(" unit(s)");
                            if (bTake == 1 || bTake == 2)
                            {
                                unit_No1Box = unit_No1Box - bTake;
                                Console.WriteLine("Now Box No.1 has {0} unit(s) left, Box No.2 has {1} unit(s) left, Box No.3 has {2} unit(s) left", unit_No1Box, unit_No2Box, unit_No3Box);
                            }
                            else
                            {
                                Console.WriteLine("Please input your take again.");
                            }
                        } while (bTake != 1 && bTake != 2);
                    }
                    if (BoxNum == 2 && unit_No2Box > 0)
                    {
                        Console.WriteLine("B takes from box No.2 for:");
                        do
                        {
                            bTake = int.Parse(Console.ReadLine());
                            Console.Write(" unit(s)");
                            if (bTake == 1 || bTake == 2)
                            {
                                unit_No2Box = unit_No2Box - bTake;
                                Console.WriteLine("Now Box No.1 has {0} unit(s) left, Box No.2 has {1} unit(s) left, Box No.3 has {2} unit(s) left", unit_No1Box, unit_No2Box, unit_No3Box);
                            }
                            else
                            {
                                Console.WriteLine("Please input your take again.");
                            }
                        } while (bTake != 1 && bTake != 2);
                    }
                    if (BoxNum == 3 && unit_No3Box > 0)
                    {
                        Console.WriteLine("B takes from box No.3 for:");
                        do
                        {
                            bTake = int.Parse(Console.ReadLine());
                            Console.Write(" unit(s)");
                            if (bTake == 1 || bTake == 2)
                            {
                                unit_No3Box = unit_No3Box - bTake;
                                Console.WriteLine("Now Box No.1 has {0} unit(s) left, Box No.2 has {1} unit(s) left, Box No.3 has {2} unit(s) left", unit_No1Box, unit_No2Box, unit_No3Box);
                            }
                            else
                            {
                                Console.WriteLine("Please input your take again.");
                            }
                        } while (bTake != 1 && bTake != 2);
                    }
                    //else
                    //{
                    //    Console.WriteLine("Please choose another box");
                    //}
                    //victory condition check
                    if (unit_No1Box == 0 && unit_No2Box == 0 && unit_No3Box == 0)
                    {
                        Console.WriteLine("All box out, A IS THE WINNER");
                        done = true;
                    }
                } while (BoxNum < 1 && BoxNum > 3);
            }
        }
    }
}
