using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Media;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Snakes_and_Ladders_Maths_Assignment
//By Grace Clarkson
{
    class Program
    {

        static void Main(string[] args)
        {
            //snake by grace clarkson

            //player position is (x, y) 
            int x = 0;
            int y = 0;

            int s = 2; //no. snakes in the game.
            //snake 1 start: input end: input       will need to change for each thingo a variable like snakeHead1 snakeTail1 etc.
            //snake 2 start end



            int l = 2; //no. ladders
                       //ladder 1 start: end,           change things at end naming as a variable instead, ladBase1 ladTop1 etc.
                       //ladder 2 start end;input

            //to display? y/n
            //for just roll number until finish,  ask y/n
            //or rolls and number of snakes and ladders. ask y/n
            //for times used ladders and times used snakes ask y/n
            //for the average of all of these ask y/n 



            int r = 0; //times rolled
            Random diceRoll = new Random();
            int i = 0;

            for (; ; ) //begin loop
            {



                if (i < 5)
                {
                    Console.WriteLine("53");
                    //game without wins first

                    Console.WriteLine("{0}, {1})", x, y);
                    //roll

                    int roll = diceRoll.Next(1, 7);
                    Console.WriteLine("rolled:{0}", roll);
                    r++; // evertime dice is rolled it goes up
                    Console.WriteLine("Rolled {0} times", r);


                    //check position for on ladder or snake change accordingly
                    //ladder 1

                    if (x == 5 && y == 7)
                    {
                        x = 7;
                        y = 9;
                        Console.WriteLine("ladder: 7, 9");
                        Console.WriteLine("71");
                    }
                    //ladder 2 - test
                    else if (x == 7 && y == 2)
                    {
                        Console.WriteLine("up Ladder2: 9, 4");
                        x = 9;
                        y = 4;
                        Console.WriteLine("79");

                    }
                    //snake 1
                    else if (x == 2 && y == 7)
                    {
                        x = 0;
                        y = 5;
                        Console.WriteLine("snake: 3,4");
                        Console.WriteLine("89");
                    }
                    //snake 2
                    else if (x == 7 && y == 10)
                    {
                        x = 5;
                        y = 8;
                        Console.WriteLine("95");
                        Console.WriteLine("down a snake: 5, 8");
                    }
                    else if (y == 0) //if row number is even or 0, player goes right and up
                    {
                        Console.WriteLine("103");
                        if (x + roll <= 10 && y < 10) //if won't go up a row
                        {
                            Console.WriteLine("106");
                            x += roll;
                            y = y;
                        }
                        

                        else if (x + roll <= 10 && y == 10)//last line
                        {
                            x = 10;
                            Console.WriteLine("109");
                        }
                        else if (x + roll == 11 && y < 10) //the rest are for did go up a row
                        {
                            x = 10;
                            y += 1;
                            Console.WriteLine("115");
                        }
                        else if (x + roll == 11 && y == 10) //when in top row
                        {
                            x = 10;
                            Console.WriteLine("120");
                        }
                        else if (x + roll == 12 && y < 10) //added y<10 so that it doesn't make x=9 and add to y incase already in top row
                        {
                            x = 9;
                            y++;
                            Console.WriteLine("126");
                        }
                        else if (x + roll == 12 && y == 10) //when in top row -> so if y is in the top row so don't add a 1 to it
                        {
                            x = 9;
                            Console.WriteLine("131");
                        }
                        else if (x + roll == 13 && y < 10)
                        {
                            x = 8;
                            y++;
                            Console.WriteLine("137");
                        }
                        else if (x + roll == 13 && y == 10)//when in top row
                        {
                            x = 8;
                            Console.WriteLine("142");
                        }
                        else if (x + roll == 14 && y < 10)
                        {
                            x = 7;
                            y++;
                            Console.WriteLine("148");
                        }
                        else if (x + roll == 14 && y == 10) //top row
                        {
                            x = 7;
                            Console.WriteLine("153");
                        }
                        else if (x + roll == 15 && y < 10)
                        {
                            x = 6;
                            y++;
                            Console.WriteLine("159");
                        }
                        else if (x + roll == 15 && y == 10)//top row
                        {
                            x = 6;
                            Console.WriteLine("164");
                        }
                        else if (x + roll == 16 && y < 10)
                        {
                            x = 5;
                            y++;
                            Console.WriteLine("170");
                        }
                        else if (x + roll == 16 && y == 10)
                        {
                            x = 5;
                            Console.WriteLine("175");
                        }
                    }

                    else if (y == 2) //if row number is even or 0, player goes right and up
                    {
                        Console.WriteLine("103");
                        if (x + roll <= 10 && y < 10) //if won't go up a row
                        {
                            Console.WriteLine("106");
                            x += roll;
                            y = y;
                        }


                        else if (x + roll <= 10 && y == 10)//last line
                        {
                            x = 10;
                            Console.WriteLine("109");
                        }
                        else if (x + roll == 11 && y < 10) //the rest are for did go up a row
                        {
                            x = 10;
                            y += 1;
                            Console.WriteLine("115");
                        }
                        else if (x + roll == 11 && y == 10) //when in top row
                        {
                            x = 10;
                            Console.WriteLine("120");
                        }
                        else if (x + roll == 12 && y < 10) //added y<10 so that it doesn't make x=9 and add to y incase already in top row
                        {
                            x = 9;
                            y++;
                            Console.WriteLine("126");
                        }
                        else if (x + roll == 12 && y == 10) //when in top row -> so if y is in the top row so don't add a 1 to it
                        {
                            x = 9;
                            Console.WriteLine("131");
                        }
                        else if (x + roll == 13 && y < 10)
                        {
                            x = 8;
                            y++;
                            Console.WriteLine("137");
                        }
                        else if (x + roll == 13 && y == 10)//when in top row
                        {
                            x = 8;
                            Console.WriteLine("142");
                        }
                        else if (x + roll == 14 && y < 10)
                        {
                            x = 7;
                            y++;
                            Console.WriteLine("148");
                        }
                        else if (x + roll == 14 && y == 10) //top row
                        {
                            x = 7;
                            Console.WriteLine("153");
                        }
                        else if (x + roll == 15 && y < 10)
                        {
                            x = 6;
                            y++;
                            Console.WriteLine("159");
                        }
                        else if (x + roll == 15 && y == 10)//top row
                        {
                            x = 6;
                            Console.WriteLine("164");
                        }
                        else if (x + roll == 16 && y < 10)
                        {
                            x = 5;
                            y++;
                            Console.WriteLine("170");
                        }
                        else if (x + roll == 16 && y == 10)
                        {
                            x = 5;
                            Console.WriteLine("175");
                        }
                    }

                    else if (y == 4) //if row number is even or 0, player goes right and up
                    {
                        Console.WriteLine("103");
                        if (x + roll <= 10 && y < 10) //if won't go up a row
                        {
                            Console.WriteLine("106");
                            x += roll;
                            y = y;
                        }
                        else if (x + roll <= 10 && y == 10)//last line
                        {
                            x = 10;
                            Console.WriteLine("109");
                        }
                        else if (x + roll == 11 && y < 10) //the rest are for did go up a row
                        {
                            x = 10;
                            y += 1;
                            Console.WriteLine("115");
                        }
                        else if (x + roll == 11 && y == 10) //when in top row
                        {
                            x = 10;
                            Console.WriteLine("120");
                        }
                        else if (x + roll == 12 && y < 10) //added y<10 so that it doesn't make x=9 and add to y incase already in top row
                        {
                            x = 9;
                            y++;
                            Console.WriteLine("126");
                        }
                        else if (x + roll == 12 && y == 10) //when in top row -> so if y is in the top row so don't add a 1 to it
                        {
                            x = 9;
                            Console.WriteLine("131");
                        }
                        else if (x + roll == 13 && y < 10)
                        {
                            x = 8;
                            y++;
                            Console.WriteLine("137");
                        }
                        else if (x + roll == 13 && y == 10)//when in top row
                        {
                            x = 8;
                            Console.WriteLine("142");
                        }
                        else if (x + roll == 14 && y < 10)
                        {
                            x = 7;
                            y++;
                            Console.WriteLine("148");
                        }
                        else if (x + roll == 14 && y == 10) //top row
                        {
                            x = 7;
                            Console.WriteLine("153");
                        }
                        else if (x + roll == 15 && y < 10)
                        {
                            x = 6;
                            y++;
                            Console.WriteLine("159");
                        }
                        else if (x + roll == 15 && y == 10)//top row
                        {
                            x = 6;
                            Console.WriteLine("164");
                        }
                        else if (x + roll == 16 && y < 10)
                        {
                            x = 5;
                            y++;
                            Console.WriteLine("170");
                        }
                        else if (x + roll == 16 && y == 10)
                        {
                            x = 5;
                            Console.WriteLine("175");
                        }
                    }

                    else if (y == 6) //if row number is even or 0, player goes right and up
                    {
                        Console.WriteLine("103");
                        if (x + roll <= 10 && y < 10) //if won't go up a row
                        {
                            Console.WriteLine("106");
                            x += roll;
                            y = y;
                        }


                        else if (x + roll <= 10 && y == 10)//last line
                        {
                            x = 10;
                            Console.WriteLine("109");
                        }
                        else if (x + roll == 11 && y < 10) //the rest are for did go up a row
                        {
                            x = 10;
                            y += 1;
                            Console.WriteLine("115");
                        }
                        else if (x + roll == 11 && y == 10) //when in top row
                        {
                            x = 10;
                            Console.WriteLine("120");
                        }
                        else if (x + roll == 12 && y < 10) //added y<10 so that it doesn't make x=9 and add to y incase already in top row
                        {
                            x = 9;
                            y++;
                            Console.WriteLine("126");
                        }
                        else if (x + roll == 12 && y == 10) //when in top row -> so if y is in the top row so don't add a 1 to it
                        {
                            x = 9;
                            Console.WriteLine("131");
                        }
                        else if (x + roll == 13 && y < 10)
                        {
                            x = 8;
                            y++;
                            Console.WriteLine("137");
                        }
                        else if (x + roll == 13 && y == 10)//when in top row
                        {
                            x = 8;
                            Console.WriteLine("142");
                        }
                        else if (x + roll == 14 && y < 10)
                        {
                            x = 7;
                            y++;
                            Console.WriteLine("148");
                        }
                        else if (x + roll == 14 && y == 10) //top row
                        {
                            x = 7;
                            Console.WriteLine("153");
                        }
                        else if (x + roll == 15 && y < 10)
                        {
                            x = 6;
                            y++;
                            Console.WriteLine("159");
                        }
                        else if (x + roll == 15 && y == 10)//top row
                        {
                            x = 6;
                            Console.WriteLine("164");
                        }
                        else if (x + roll == 16 && y < 10)
                        {
                            x = 5;
                            y++;
                            Console.WriteLine("170");
                        }
                        else if (x + roll == 16 && y == 10)
                        {
                            x = 5;
                            Console.WriteLine("175");
                        }
                    }

                    else if (y == 8) //if row number is even or 0, player goes right and up
                    {
                        Console.WriteLine("103");
                        if (x + roll <= 10 && y < 10) //if won't go up a row
                        {
                            Console.WriteLine("106");
                            x += roll;
                            y = y;
                        }
                        else if (x + roll <= 10 && y == 10)//last line
                        {
                            x = 10;
                            Console.WriteLine("109");
                        }
                        else if (x + roll == 11 && y < 10) //the rest are for did go up a row
                        {
                            x = 10;
                            y += 1;
                            Console.WriteLine("115");
                        }
                        else if (x + roll == 11 && y == 10) //when in top row
                        {
                            x = 10;
                            Console.WriteLine("120");
                        }
                        else if (x + roll == 12 && y < 10) //added y<10 so that it doesn't make x=9 and add to y incase already in top row
                        {
                            x = 9;
                            y++;
                            Console.WriteLine("126");
                        }
                        else if (x + roll == 12 && y == 10) //when in top row -> so if y is in the top row so don't add a 1 to it
                        {
                            x = 9;
                            Console.WriteLine("131");
                        }
                        else if (x + roll == 13 && y < 10)
                        {
                            x = 8;
                            y++;
                            Console.WriteLine("137");
                        }
                        else if (x + roll == 13 && y == 10)//when in top row
                        {
                            x = 8;
                            Console.WriteLine("142");
                        }
                        else if (x + roll == 14 && y < 10)
                        {
                            x = 7;
                            y++;
                            Console.WriteLine("148");
                        }
                        else if (x + roll == 14 && y == 10) //top row
                        {
                            x = 7;
                            Console.WriteLine("153");
                        }
                        else if (x + roll == 15 && y < 10)
                        {
                            x = 6;
                            y++;
                            Console.WriteLine("159");
                        }
                        else if (x + roll == 15 && y == 10)//top row
                        {
                            x = 6;
                            Console.WriteLine("164");
                        }
                        else if (x + roll == 16 && y < 10)
                        {
                            x = 5;
                            y++;
                            Console.WriteLine("170");
                        }
                        else if (x + roll == 16 && y == 10)
                        {
                            x = 5;
                            Console.WriteLine("175");
                        }
                    }

                    else if (y == 10 && x < 10) //if row number is even or 0, player goes right and up
                    {
                        Console.WriteLine("103");
                        if (x + roll <= 10 && y <= 10) //if won't go up a row
                        {
                            Console.WriteLine("106");
                            x += roll;
                        }
                        else if (x + roll <= 10 && y == 10)//last line
                        {
                            x = 10;
                            Console.WriteLine("109");
                        }
                        else if (x + roll == 11 && y < 10) //the rest are for did go up a row
                        {
                            x = 10;
                            y += 1;
                            Console.WriteLine("115");
                        }
                        else if (x + roll == 11 && y == 10) //when in top row
                        {
                            x = 10;
                            Console.WriteLine("120");
                        }
                        else if (x + roll == 12 && y < 10) //added y<10 so that it doesn't make x=9 and add to y incase already in top row
                        {
                            x = 9;
                            y++;
                            Console.WriteLine("126");
                        }
                        else if (x + roll == 12 && y == 10) //when in top row -> so if y is in the top row so don't add a 1 to it
                        {
                            x = 9;
                            Console.WriteLine("131");
                        }
                        else if (x + roll == 13 && y < 10)
                        {
                            x = 8;
                            y++;
                            Console.WriteLine("137");
                        }
                        else if (x + roll == 13 && y == 10)//when in top row
                        {
                            x = 8;
                            Console.WriteLine("142");
                        }
                        else if (x + roll == 14 && y < 10)
                        {
                            x = 7;
                            y++;
                            Console.WriteLine("148");
                        }
                        else if (x + roll == 14 && y == 10) //top row
                        {
                            x = 7;
                            Console.WriteLine("153");
                        }
                        else if (x + roll == 15 && y < 10)
                        {
                            x = 6;
                            y++;
                            Console.WriteLine("159");
                        }
                        else if (x + roll == 15 && y == 10)//top row
                        {
                            x = 6;
                            Console.WriteLine("164");
                        }
                        else if (x + roll == 16 && y < 10)
                        {
                            x = 5;
                            y++;
                            Console.WriteLine("170");
                        }
                        else if (x + roll == 16 && y == 10)
                        {
                            x = 5;
                            Console.WriteLine("175");
                        }
                    }

                    else if (y == 1 | y == 3 | y == 5 | y == 7 | y == 9) //y is odd
                    {
                        Console.WriteLine("181");
                        if (x - roll >= 0)
                        {
                            x -= roll;
                            Console.WriteLine("183");
                        }
                        //dont need a statement for y = 10 because if it is in the last row its even anyways.
                        else if (x - roll == -1)
                        {
                            x = 0;
                            ++y;
                            Console.WriteLine("191");
                        }
                        else if (x - roll == -2)
                        {
                            x = 1;
                            y++;
                            Console.WriteLine("197");
                        }
                        else if (x - roll == -3)
                        {
                            x = 2;
                            ++y;
                            Console.WriteLine("203");
                        }
                        else if (x - roll == -4)
                        {
                            x = 3;
                            ++y;
                            Console.WriteLine("209");
                        }
                        else if (x - roll == -5)
                        {
                            x = 4;
                            ++y;
                            Console.WriteLine("215");
                        }
                        else if (x - roll == -6)
                        {
                            x = 5;
                            ++y;
                            Console.WriteLine("221");
                        }





                    }

                    //output for winning game
                    else if (x == 10 && y == 10) //finished game
                    {
                        Console.WriteLine("Finsihed: Rolls {0}, snakes {1}, ladders {2}", r, s, l);
                        i += 1;
                        //reset
                        y = 0;
                        x = 0;
                        Console.WriteLine("232");
                        r = 0;

                    }
                    //in neither odd or even just for the loop to execute anyway while i < 5

                }
            }
            }
        }
    }

//output rolling number and run loads and count along check 5 rounds 5 times
//made ladders only changing 2 upwards annd 2 right
//make snakes only 2 down and 2 left
//make a fatter if statment, if y = 0 | y = divisible by 2/ than it needs to increase x
// if y is odd x = x - roll. and under that y statement have all of the ifs for x = -number. than x = something; y++;
//get average rolls: make it the only thing to display, run as many 'n' times as you like then copy and paste the column of roll number (the only thing in each row on console output) into excel collumn and average it
//could also display the ladder and snake uses just increment a value by 1 each time su for snake use and lu = times ladder used
// 