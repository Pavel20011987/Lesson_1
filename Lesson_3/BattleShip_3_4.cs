using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    class BattleShip_3_4
    {
        class Place
        {
            int line, bykva;
            string[] four = new string[4];
            string[] one = new string[4];
            string[][] three;
            string[][] two;
            string[][] MyPlace;
            string[][] HisPlace;
            string[][] HisPlaceBuf;

            string[] fourC = new string[4];
            string[] oneC = new string[4];
            string[][] threeC;
            string[][] twoC;

            string MyFaire;
            string HisFaire;

            public Place()
            {
                MyPlace = new string[10][];
                for (int i = 0; i < 10; i++)
                    MyPlace[i] = new string[10];
                for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        MyPlace[i][j] = ".";
                HisPlaceBuf = new string[10][];
                for (int i = 0; i < 10; i++)
                    HisPlaceBuf[i] = new string[10];
                for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        HisPlaceBuf[i][j] = ".";
                HisPlace = new string[10][];
                for (int i = 0; i < 10; i++)
                    HisPlace[i] = new string[10];
                for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        HisPlace[i][j] = ".";

                three = new string[2][];
                for (int i = 0; i < 2; i++)
                    three[i] = new string[3];

                two = new string[3][];
                for (int i = 0; i < 3; i++)
                    two[i] = new string[2];

                threeC = new string[2][];
                for (int i = 0; i < 2; i++)
                    threeC[i] = new string[3];

                twoC = new string[3][];
                for (int i = 0; i < 3; i++)
                    twoC[i] = new string[2];
            }
            public void Output()
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("      My Flot                      Robot Flot");
                Console.WriteLine("  1 2 3 4 5 6 7 8 9 10        1 2 3 4 5 6 7 8 9 10        1 2 3 4 5 6 7 8 9 10");
                for (int i = 0, k = 65; i < 10; i++, k++)
                {
                    Console.Write("{0}", Convert.ToChar(k));
                    for (int j = 0; j < 10; j++)
                        Console.Write(" {0}", MyPlace[i][j]);
                    Console.Write("       {0}", Convert.ToChar(k));
                    for (int j = 0; j < 10; j++)
                        Console.Write(" {0}", HisPlaceBuf[i][j]);
                    Console.Write("       {0}", Convert.ToChar(k));
                    for (int j = 0; j < 10; j++)
                        Console.Write(" {0}", HisPlace[i][j]);
                    Console.WriteLine();
                }
            }
            /*        Моё поле        */
            public void ForFour()
            {
                bool off = false;
                while (off != true)
                {
                    int prom = 0;
                    Random rand = new Random();
                    bykva = rand.Next(0, 10);
                    line = rand.Next(0, 10);
                    if (bykva > 2)
                    {
                        while (prom != 4)
                        {
                            MyPlace[bykva][line] = "#";
                            four[prom] = Translate(bykva);
                            four[prom] += (line + 1).ToString();
                            bykva--;
                            prom++;
                        }
                        off = true;
                    }
                    else if (bykva < 3)
                    {
                        while (prom != 4)
                        {
                            MyPlace[bykva][line] = "#";
                            four[prom] = Translate(bykva);
                            four[prom] += (line + 1).ToString();
                            bykva++;
                            prom++;
                        }
                        off = true;
                    }
                }
            }
            public void ForOne(int pos)
            {
                bool off = false;
                while (off != true)
                {
                    Random rand = new Random();
                    bykva = rand.Next(0, 10);
                    one[pos] = Translate(bykva);
                    line = rand.Next(0, 10);
                    if ((bykva > 0 && bykva < 9) && (line > 0 && line < 9) && MyPlace[bykva][line] != "#" && MyPlace[bykva][line + 1] != "#" &&
                        MyPlace[bykva][line - 1] != "#" && MyPlace[bykva - 1][line] != "#" && MyPlace[bykva - 1][line + 1] != "#" &&
                        MyPlace[bykva - 1][line - 1] != "#" && MyPlace[bykva + 1][line] != "#" && MyPlace[bykva + 1][line + 1] != "#" && MyPlace[bykva + 1][line - 1] != "#")
                    {
                        MyPlace[bykva][line] = "#";
                        one[pos] += (line + 1).ToString();
                        off = true;
                    }
                    else if (line == 0 && (bykva > 0 && bykva < 9) && MyPlace[bykva][line] != "#" && MyPlace[bykva][line + 1] != "#" &&
                        MyPlace[bykva - 1][line] != "#" && MyPlace[bykva - 1][line + 1] != "#" && MyPlace[bykva + 1][line] != "#" && MyPlace[bykva + 1][line + 1] != "#")
                    {
                        MyPlace[bykva][line] = "#";
                        one[pos] += (line + 1).ToString();
                        off = true;
                    }
                    else if (line == 9 && (bykva > 0 && bykva < 9) && MyPlace[bykva][line] != "#" && MyPlace[bykva][line - 1] != "#" &&
                        MyPlace[bykva - 1][line] != "#" && MyPlace[bykva - 1][line - 1] != "#" && MyPlace[bykva + 1][line] != "#" && MyPlace[bykva + 1][line - 1] != "#")
                    {
                        MyPlace[bykva][line] = "#";
                        one[pos] += (line + 1).ToString();
                        off = true;
                    }
                    else if (bykva == 0 && (line > 0 && line < 9) && MyPlace[bykva][line] != "#" && MyPlace[bykva][line + 1] != "#" &&
                        MyPlace[bykva][line - 1] != "#" && MyPlace[bykva + 1][line] != "#" && MyPlace[bykva + 1][line + 1] != "#" && MyPlace[bykva + 1][line - 1] != "#")
                    {
                        MyPlace[bykva][line] = "#";
                        one[pos] += (line + 1).ToString();
                        off = true;
                    }
                    else if (bykva == 9 && (line > 0 && line < 9) && MyPlace[bykva][line] != "#" && MyPlace[bykva][line + 1] != "#" &&
                        MyPlace[bykva][line - 1] != "#" && MyPlace[bykva - 1][line] != "#" && MyPlace[bykva - 1][line + 1] != "#" && MyPlace[bykva - 1][line - 1] != "#")
                    {
                        MyPlace[bykva][line] = "#";
                        one[pos] += (line + 1).ToString();
                        off = true;
                    }
                    else if (bykva == 0 && line == 0 && MyPlace[bykva][line] != "#" && MyPlace[bykva + 1][line] != "#" &&
                        MyPlace[bykva][line + 1] != "#" && MyPlace[bykva + 1][line + 1] != "#")
                    {
                        MyPlace[bykva][line] = "#";
                        one[pos] += (line + 1).ToString();
                        off = true;
                    }
                    else if (bykva == 9 && line == 0 && MyPlace[bykva][line] != "#" && MyPlace[bykva][line + 1] != "#" &&
                        MyPlace[bykva - 1][line] != "#" && MyPlace[bykva - 1][line + 1] != "#")
                    {
                        MyPlace[bykva][line] = "#";
                        one[pos] += (line + 1).ToString();
                        off = true;
                    }
                    else if (bykva == 0 && line == 9 && MyPlace[bykva][line] != "#" && MyPlace[bykva][line - 1] != "#" &&
                        MyPlace[bykva + 1][line] != "#" && MyPlace[bykva + 1][line - 1] != "#")
                    {
                        MyPlace[bykva][line] = "#";
                        one[pos] += (line + 1).ToString();
                        off = true;
                    }
                    else if (bykva == 9 && line == 9 && MyPlace[bykva][line] != "#" && MyPlace[bykva][line - 1] != "#" &&
                        MyPlace[bykva - 1][line] != "#" && MyPlace[bykva - 1][line - 1] != "#")
                    {
                        MyPlace[bykva][line] = "#";
                        one[pos] += (line + 1).ToString();
                        off = true;
                    }
                }
            }
            public void ForThree(int pos)
            {
                bool off = false;
                while (off != true)
                {
                    int prom = 0;
                    Random rand = new Random();
                    bykva = rand.Next(0, 10);
                    line = rand.Next(0, 10);
                    if ((bykva > 2 && bykva < 9) && (line > 0 && line < 9) && MyPlace[bykva][line] != "#" &&
                        MyPlace[bykva][line + 1] != "#" && MyPlace[bykva][line - 1] != "#" && MyPlace[bykva - 1][line] != "#" &&
                        MyPlace[bykva - 1][line - 1] != "#" && MyPlace[bykva - 1][line + 1] != "#" && MyPlace[bykva - 2][line] != "#" &&
                        MyPlace[bykva - 2][line - 1] != "#" && MyPlace[bykva - 2][line + 1] != "#" && MyPlace[bykva + 1][line] != "#" &&
                        MyPlace[bykva + 1][line - 1] != "#" && MyPlace[bykva + 1][line - 1] != "#" && MyPlace[bykva - 3][line] != "#" &&
                        MyPlace[bykva - 3][line - 1] != "#" && MyPlace[bykva - 3][line + 1] != "#")
                    {
                        while (prom != 3)
                        {
                            MyPlace[bykva][line] = "#";
                            three[pos][prom] = Translate(bykva);
                            three[pos][prom] += (line + 1).ToString();
                            bykva--;
                            prom++;
                        }
                        off = true;
                    }
                    else if (bykva == 9 && (line > 0 && line < 9) && MyPlace[bykva][line] != "#" && MyPlace[bykva][line + 1] != "#" &&
                        MyPlace[bykva][line - 1] != "#" && MyPlace[bykva - 1][line] != "#" && MyPlace[bykva - 1][line + 1] != "#" &&
                        MyPlace[bykva - 1][line - 1] != "#" && MyPlace[bykva - 2][line] != "#" && MyPlace[bykva - 2][line + 1] != "#" &&
                        MyPlace[bykva - 2][line - 1] != "#" && MyPlace[bykva - 3][line] != "#" && MyPlace[bykva - 3][line + 1] != "#" &&
                        MyPlace[bykva - 3][line - 1] != "#")
                    {
                        while (prom != 3)
                        {
                            MyPlace[bykva][line] = "#";
                            three[pos][prom] = Translate(bykva);
                            three[pos][prom] += (line + 1).ToString();
                            bykva--;
                            prom++;
                        }
                        off = true;
                    }
                    else if ((bykva > 2 && bykva < 9) && line == 0 && MyPlace[bykva][line] != "#" && MyPlace[bykva][line + 1] != "#" &&
                        MyPlace[bykva + 1][line] != "#" && MyPlace[bykva + 1][line + 1] != "#" && MyPlace[bykva - 1][line] != "#" &&
                        MyPlace[bykva - 1][line + 1] != "#" && MyPlace[bykva - 2][line] != "#" && MyPlace[bykva - 2][line + 1] != "#" &&
                        MyPlace[bykva - 3][line] != "#" && MyPlace[bykva - 3][line + 1] != "#")
                    {
                        while (prom != 3)
                        {
                            MyPlace[bykva][line] = "#";
                            three[pos][prom] = Translate(bykva);
                            three[pos][prom] += (line + 1).ToString();
                            bykva--;
                            prom++;
                        }
                        off = true;
                    }
                    else if (bykva == 9 && line == 0 && MyPlace[bykva][line] != "#" && MyPlace[bykva][line + 1] != "#" &&
                        MyPlace[bykva - 1][line] != "#" && MyPlace[bykva - 1][line + 1] != "#" && MyPlace[bykva - 2][line] != "#" &&
                        MyPlace[bykva - 2][line + 1] != "#" && MyPlace[bykva - 3][line] != "#" && MyPlace[bykva - 3][line + 1] != "#")
                    {
                        while (prom != 3)
                        {
                            MyPlace[bykva][line] = "#";
                            three[pos][prom] = Translate(bykva);
                            three[pos][prom] += (line + 1).ToString();
                            bykva--;
                            prom++;
                        }
                        off = true;
                    }
                    else if ((bykva > 0 && bykva < 3) && line == 0 && MyPlace[bykva][line] != "#" && MyPlace[bykva][line + 1] != "#" &&
                        MyPlace[bykva - 1][line] != "#" && MyPlace[bykva - 1][line + 1] != "#" && MyPlace[bykva + 1][line] != "#" &&
                        MyPlace[bykva + 1][line + 1] != "#" && MyPlace[bykva + 2][line] != "#" && MyPlace[bykva + 2][line + 1] != "#" &&
                        MyPlace[bykva + 3][line] != "#" && MyPlace[bykva + 3][line + 1] != "#")
                    {
                        while (prom != 3)
                        {
                            MyPlace[bykva][line] = "#";
                            three[pos][prom] = Translate(bykva);
                            three[pos][prom] += (line + 1).ToString();
                            bykva++;
                            prom++;
                        }
                        off = true;
                    }
                    else if (bykva == 0 && line == 0 && MyPlace[bykva][line] != "#" && MyPlace[bykva][line + 1] != "#" &&
                        MyPlace[bykva + 1][line] != "#" && MyPlace[bykva + 1][line + 1] != "#" && MyPlace[bykva + 2][line] != "#" &&
                        MyPlace[bykva + 2][line + 1] != "#" && MyPlace[bykva + 3][line] != "#" && MyPlace[bykva + 3][line + 1] != "#")
                    {
                        while (prom != 3)
                        {
                            MyPlace[bykva][line] = "#";
                            three[pos][prom] = Translate(bykva);
                            three[pos][prom] += (line + 1).ToString();
                            bykva++;
                            prom++;
                        }
                        off = true;
                    }
                    else if ((bykva > 0 && bykva < 3) && (line > 0 && line < 9) && MyPlace[bykva][line] != "#" &&
                        MyPlace[bykva][line + 1] != "#" && MyPlace[bykva][line - 1] != "#" && MyPlace[bykva - 1][line] != "#" &&
                        MyPlace[bykva - 1][line - 1] != "#" && MyPlace[bykva - 1][line + 1] != "#" && MyPlace[bykva + 1][line] != "#" &&
                        MyPlace[bykva + 1][line - 1] != "#" && MyPlace[bykva + 1][line + 1] != "#" && MyPlace[bykva + 2][line] != "#" &&
                        MyPlace[bykva + 2][line - 1] != "#" && MyPlace[bykva + 2][line + 1] != "#" && MyPlace[bykva + 3][line] != "#" &&
                        MyPlace[bykva + 3][line - 1] != "#" && MyPlace[bykva + 3][line + 1] != "#")
                    {
                        while (prom != 3)
                        {
                            MyPlace[bykva][line] = "#";
                            three[pos][prom] = Translate(bykva);
                            three[pos][prom] += (line + 1).ToString();
                            bykva++;
                            prom++;
                        }
                        off = true;
                    }
                    else if (bykva == 0 && (line > 0 && line < 9) && MyPlace[bykva][line] != "#" && MyPlace[bykva][line + 1] != "#" &&
                        MyPlace[bykva][line - 1] != "#" && MyPlace[bykva + 1][line] != "#" && MyPlace[bykva + 1][line + 1] != "#" &&
                        MyPlace[bykva + 1][line - 1] != "#" && MyPlace[bykva + 2][line] != "#" && MyPlace[bykva + 2][line + 1] != "#" &&
                        MyPlace[bykva + 2][line - 1] != "#" && MyPlace[bykva + 3][line] != "#" && MyPlace[bykva + 3][line + 1] != "#" &&
                        MyPlace[bykva + 3][line - 1] != "#")
                    {
                        while (prom != 3)
                        {
                            MyPlace[bykva][line] = "#";
                            three[pos][prom] = Translate(bykva);
                            three[pos][prom] += (line + 1).ToString();
                            bykva++;
                            prom++;
                        }
                        off = true;
                    }
                    else if ((bykva > 2 && bykva < 9) && line == 9 && MyPlace[bykva][line] != "#" && MyPlace[bykva][line - 1] != "#" &&
                        MyPlace[bykva + 1][line] != "#" && MyPlace[bykva + 1][line - 1] != "#" && MyPlace[bykva - 1][line] != "#" &&
                        MyPlace[bykva - 1][line - 1] != "#" && MyPlace[bykva - 2][line] != "#" && MyPlace[bykva - 2][line - 1] != "#" &&
                        MyPlace[bykva - 3][line] != "#" && MyPlace[bykva - 3][line - 1] != "#")
                    {
                        while (prom != 3)
                        {
                            MyPlace[bykva][line] = "#";
                            three[pos][prom] = Translate(bykva);
                            three[pos][prom] += (line + 1).ToString();
                            bykva--;
                            prom++;
                        }
                        off = true;
                    }
                    else if (bykva == 9 && line == 9 && MyPlace[bykva][line] != "#" && MyPlace[bykva][line - 1] != "#" &&
                        MyPlace[bykva - 1][line] != "#" && MyPlace[bykva - 1][line - 1] != "#" && MyPlace[bykva - 2][line] != "#" &&
                        MyPlace[bykva - 2][line - 1] != "#" && MyPlace[bykva - 3][line] != "#" && MyPlace[bykva - 3][line - 1] != "#")
                    {
                        while (prom != 3)
                        {
                            MyPlace[bykva][line] = "#";
                            three[pos][prom] = Translate(bykva);
                            three[pos][prom] += (line + 1).ToString();
                            bykva--;
                            prom++;
                        }
                        off = true;
                    }
                    else if ((bykva > 0 && bykva < 3) && line == 9 && MyPlace[bykva][line] != "#" && MyPlace[bykva][line - 1] != "#" &&
                        MyPlace[bykva - 1][line] != "#" && MyPlace[bykva - 1][line - 1] != "#" && MyPlace[bykva + 1][line] != "#" &&
                        MyPlace[bykva + 1][line - 1] != "#" && MyPlace[bykva + 2][line] != "#" && MyPlace[bykva + 2][line - 1] != "#" &&
                        MyPlace[bykva + 3][line] != "#" && MyPlace[bykva + 3][line - 1] != "#")
                    {
                        while (prom != 3)
                        {
                            MyPlace[bykva][line] = "#";
                            three[pos][prom] = Translate(bykva);
                            three[pos][prom] += (line + 1).ToString();
                            bykva++;
                            prom++;
                        }
                        off = true;
                    }
                    else if (bykva == 0 && line == 9 && MyPlace[bykva][line] != "#" && MyPlace[bykva][line - 1] != "#" &&
                        MyPlace[bykva + 1][line] != "#" && MyPlace[bykva + 1][line - 1] != "#" && MyPlace[bykva + 2][line] != "#" &&
                        MyPlace[bykva + 2][line - 1] != "#" && MyPlace[bykva + 3][line] != "#" && MyPlace[bykva + 3][line - 1] != "#")
                    {
                        while (prom != 3)
                        {
                            MyPlace[bykva][line] = "#";
                            three[pos][prom] = Translate(bykva);
                            three[pos][prom] += (line + 1).ToString();
                            bykva++;
                            prom++;
                        }
                        off = true;
                    }
                }
            }
            public void ForTwo(int pos)
            {
                bool off = false;
                while (off != true)
                {
                    int prom = 0;
                    Random rand = new Random();
                    bykva = rand.Next(0, 10);
                    line = rand.Next(0, 10);
                    if ((bykva > 2 && bykva < 9) && (line > 0 && line < 9) && MyPlace[bykva][line] != "#" &&
                        MyPlace[bykva][line + 1] != "#" && MyPlace[bykva][line - 1] != "#" && MyPlace[bykva - 1][line] != "#" &&
                        MyPlace[bykva - 1][line - 1] != "#" && MyPlace[bykva - 1][line + 1] != "#" && MyPlace[bykva - 2][line] != "#" &&
                        MyPlace[bykva - 2][line - 1] != "#" && MyPlace[bykva - 2][line + 1] != "#" && MyPlace[bykva + 1][line] != "#" &&
                        MyPlace[bykva + 1][line - 1] != "#" && MyPlace[bykva + 1][line - 1] != "#")
                    {
                        while (prom != 2)
                        {
                            MyPlace[bykva][line] = "#";
                            two[pos][prom] = Translate(bykva);
                            two[pos][prom] += (line + 1).ToString();
                            bykva--;
                            prom++;
                        }
                        off = true;
                    }
                    else if (bykva == 9 && (line > 0 && line < 9) && MyPlace[bykva][line] != "#" && MyPlace[bykva][line + 1] != "#" &&
                        MyPlace[bykva][line - 1] != "#" && MyPlace[bykva - 1][line] != "#" && MyPlace[bykva - 1][line + 1] != "#" &&
                        MyPlace[bykva - 1][line - 1] != "#" && MyPlace[bykva - 2][line] != "#" && MyPlace[bykva - 2][line + 1] != "#" &&
                        MyPlace[bykva - 2][line - 1] != "#")
                    {
                        while (prom != 2)
                        {
                            MyPlace[bykva][line] = "#";
                            two[pos][prom] = Translate(bykva);
                            two[pos][prom] += (line + 1).ToString();
                            bykva--;
                            prom++;
                        }
                        off = true;
                    }
                    else if ((bykva > 2 && bykva < 9) && line == 0 && MyPlace[bykva][line] != "#" && MyPlace[bykva][line + 1] != "#" &&
                        MyPlace[bykva + 1][line] != "#" && MyPlace[bykva + 1][line + 1] != "#" && MyPlace[bykva - 1][line] != "#" &&
                        MyPlace[bykva - 1][line + 1] != "#" && MyPlace[bykva - 2][line] != "#" && MyPlace[bykva - 2][line + 1] != "#")
                    {
                        while (prom != 2)
                        {
                            MyPlace[bykva][line] = "#";
                            two[pos][prom] = Translate(bykva);
                            two[pos][prom] += (line + 1).ToString();
                            bykva--;
                            prom++;
                        }
                        off = true;
                    }
                    else if (bykva == 9 && line == 0 && MyPlace[bykva][line] != "#" && MyPlace[bykva][line + 1] != "#" &&
                        MyPlace[bykva - 1][line] != "#" && MyPlace[bykva - 1][line + 1] != "#" && MyPlace[bykva - 2][line] != "#" &&
                        MyPlace[bykva - 2][line + 1] != "#")
                    {
                        while (prom != 2)
                        {
                            MyPlace[bykva][line] = "#";
                            two[pos][prom] = Translate(bykva);
                            two[pos][prom] += (line + 1).ToString();
                            bykva--;
                            prom++;
                        }
                        off = true;
                    }
                    else if ((bykva > 0 && bykva < 3) && line == 0 && MyPlace[bykva][line] != "#" && MyPlace[bykva][line + 1] != "#" &&
                        MyPlace[bykva - 1][line] != "#" && MyPlace[bykva - 1][line + 1] != "#" && MyPlace[bykva + 1][line] != "#" &&
                        MyPlace[bykva + 1][line + 1] != "#" && MyPlace[bykva + 2][line] != "#" && MyPlace[bykva + 2][line + 1] != "#")
                    {
                        while (prom != 2)
                        {
                            MyPlace[bykva][line] = "#";
                            two[pos][prom] = Translate(bykva);
                            two[pos][prom] += (line + 1).ToString();
                            bykva++;
                            prom++;
                        }
                        off = true;
                    }
                    else if (bykva == 0 && line == 0 && MyPlace[bykva][line] != "#" && MyPlace[bykva][line + 1] != "#" &&
                        MyPlace[bykva + 1][line] != "#" && MyPlace[bykva + 1][line + 1] != "#" && MyPlace[bykva + 2][line] != "#" &&
                        MyPlace[bykva + 2][line + 1] != "#")
                    {
                        while (prom != 2)
                        {
                            MyPlace[bykva][line] = "#";
                            two[pos][prom] = Translate(bykva);
                            two[pos][prom] += (line + 1).ToString();
                            bykva++;
                            prom++;
                        }
                        off = true;
                    }
                    else if ((bykva > 0 && bykva < 3) && (line > 0 && line < 9) && MyPlace[bykva][line] != "#" &&
                        MyPlace[bykva][line + 1] != "#" && MyPlace[bykva][line - 1] != "#" && MyPlace[bykva - 1][line] != "#" &&
                        MyPlace[bykva - 1][line - 1] != "#" && MyPlace[bykva - 1][line + 1] != "#" && MyPlace[bykva + 1][line] != "#" &&
                        MyPlace[bykva + 1][line - 1] != "#" && MyPlace[bykva + 1][line + 1] != "#" && MyPlace[bykva + 2][line] != "#" &&
                        MyPlace[bykva + 2][line - 1] != "#" && MyPlace[bykva + 2][line + 1] != "#")
                    {
                        while (prom != 2)
                        {
                            MyPlace[bykva][line] = "#";
                            two[pos][prom] = Translate(bykva);
                            two[pos][prom] += (line + 1).ToString();
                            bykva++;
                            prom++;
                        }
                        off = true;
                    }
                    else if (bykva == 0 && (line > 0 && line < 9) && MyPlace[bykva][line] != "#" && MyPlace[bykva][line + 1] != "#" &&
                        MyPlace[bykva][line - 1] != "#" && MyPlace[bykva + 1][line] != "#" && MyPlace[bykva + 1][line + 1] != "#" &&
                        MyPlace[bykva + 1][line - 1] != "#" && MyPlace[bykva + 2][line] != "#" && MyPlace[bykva + 2][line + 1] != "#" &&
                        MyPlace[bykva + 2][line - 1] != "#")
                    {
                        while (prom != 2)
                        {
                            MyPlace[bykva][line] = "#";
                            two[pos][prom] = Translate(bykva);
                            two[pos][prom] += (line + 1).ToString();
                            bykva++;
                            prom++;
                        }
                        off = true;
                    }
                    else if ((bykva > 2 && bykva < 9) && line == 9 && MyPlace[bykva][line] != "#" && MyPlace[bykva][line - 1] != "#" &&
                        MyPlace[bykva + 1][line] != "#" && MyPlace[bykva + 1][line - 1] != "#" && MyPlace[bykva - 1][line] != "#" &&
                        MyPlace[bykva - 1][line - 1] != "#" && MyPlace[bykva - 2][line] != "#" && MyPlace[bykva - 2][line - 1] != "#")
                    {
                        while (prom != 2)
                        {
                            MyPlace[bykva][line] = "#";
                            two[pos][prom] = Translate(bykva);
                            two[pos][prom] += (line + 1).ToString();
                            bykva--;
                            prom++;
                        }
                        off = true;
                    }
                    else if (bykva == 9 && line == 9 && MyPlace[bykva][line] != "#" && MyPlace[bykva][line - 1] != "#" &&
                        MyPlace[bykva - 1][line] != "#" && MyPlace[bykva - 1][line - 1] != "#" && MyPlace[bykva - 2][line] != "#" &&
                        MyPlace[bykva - 2][line - 1] != "#")
                    {
                        while (prom != 2)
                        {
                            MyPlace[bykva][line] = "#";
                            two[pos][prom] = Translate(bykva);
                            two[pos][prom] += (line + 1).ToString();
                            bykva--;
                            prom++;
                        }
                        off = true;
                    }
                    else if ((bykva > 0 && bykva < 3) && line == 9 && MyPlace[bykva][line] != "#" && MyPlace[bykva][line - 1] != "#" &&
                        MyPlace[bykva - 1][line] != "#" && MyPlace[bykva - 1][line - 1] != "#" && MyPlace[bykva + 1][line] != "#" &&
                        MyPlace[bykva + 1][line - 1] != "#" && MyPlace[bykva + 2][line] != "#" && MyPlace[bykva + 2][line - 1] != "#")
                    {
                        while (prom != 2)
                        {
                            MyPlace[bykva][line] = "#";
                            two[pos][prom] = Translate(bykva);
                            two[pos][prom] += (line + 1).ToString();
                            bykva++;
                            prom++;
                        }
                        off = true;
                    }
                    else if (bykva == 0 && line == 9 && MyPlace[bykva][line] != "#" && MyPlace[bykva][line - 1] != "#" &&
                        MyPlace[bykva + 1][line] != "#" && MyPlace[bykva + 1][line - 1] != "#" && MyPlace[bykva + 2][line] != "#" &&
                        MyPlace[bykva + 2][line - 1] != "#")
                    {
                        while (prom != 2)
                        {
                            MyPlace[bykva][line] = "#";
                            two[pos][prom] = Translate(bykva);
                            two[pos][prom] += (line + 1).ToString();
                            bykva++;
                            prom++;
                        }
                        off = true;
                    }
                }
            }
            /*================================*/

            /* Поле компьютера        */
            public void ForFourCom()
            {
                bool off = false;
                while (off != true)
                {
                    int prom = 0;
                    Random rand = new Random();
                    bykva = rand.Next(0, 10);
                    line = rand.Next(0, 10);
                    if (bykva > 2)
                    {
                        while (prom != 4)
                        {
                            HisPlace[bykva][line] = "#";
                            fourC[prom] = Translate(bykva);
                            fourC[prom] += (line + 1).ToString();
                            bykva--;
                            prom++;
                        }
                        off = true;
                    }
                    else if (bykva < 3)
                    {
                        while (prom != 4)
                        {
                            HisPlace[bykva][line] = "#";
                            fourC[prom] = Translate(bykva);
                            fourC[prom] += (line + 1).ToString();
                            bykva++;
                            prom++;
                        }
                        off = true;
                    }
                }
                //for (int i = 0; i < 4; i++) Console.WriteLine("четырехпалбука {0}", fourC[i]);
            }
            public void ForOneCom(int pos)
            {
                bool off = false;
                while (off != true)
                {
                    Random rand = new Random();
                    bykva = rand.Next(0, 10);
                    oneC[pos] = Translate(bykva);
                    line = rand.Next(0, 10);
                    if ((bykva > 0 && bykva < 9) && (line > 0 && line < 9) && HisPlace[bykva][line] != "#" && HisPlace[bykva][line + 1] != "#" &&
                        HisPlace[bykva][line - 1] != "#" && HisPlace[bykva - 1][line] != "#" && HisPlace[bykva - 1][line + 1] != "#" &&
                        HisPlace[bykva - 1][line - 1] != "#" && HisPlace[bykva + 1][line] != "#" && HisPlace[bykva + 1][line + 1] != "#" && HisPlace[bykva + 1][line - 1] != "#")
                    {
                        HisPlace[bykva][line] = "#";
                        oneC[pos] += (line + 1).ToString();
                        off = true;
                    }
                    else if (line == 0 && (bykva > 0 && bykva < 9) && HisPlace[bykva][line] != "#" && HisPlace[bykva][line + 1] != "#" &&
                        HisPlace[bykva - 1][line] != "#" && HisPlace[bykva - 1][line + 1] != "#" && HisPlace[bykva + 1][line] != "#" && HisPlace[bykva + 1][line + 1] != "#")
                    {
                        HisPlace[bykva][line] = "#";
                        oneC[pos] += (line + 1).ToString();
                        off = true;
                    }
                    else if (line == 9 && (bykva > 0 && bykva < 9) && HisPlace[bykva][line] != "#" && HisPlace[bykva][line - 1] != "#" &&
                        HisPlace[bykva - 1][line] != "#" && HisPlace[bykva - 1][line - 1] != "#" && HisPlace[bykva + 1][line] != "#" && HisPlace[bykva + 1][line - 1] != "#")
                    {
                        HisPlace[bykva][line] = "#";
                        oneC[pos] += (line + 1).ToString();
                        off = true;
                    }
                    else if (bykva == 0 && (line > 0 && line < 9) && HisPlace[bykva][line] != "#" && HisPlace[bykva][line + 1] != "#" &&
                        HisPlace[bykva][line - 1] != "#" && HisPlace[bykva + 1][line] != "#" && HisPlace[bykva + 1][line + 1] != "#" && HisPlace[bykva + 1][line - 1] != "#")
                    {
                        HisPlace[bykva][line] = "#";
                        oneC[pos] += (line + 1).ToString();
                        off = true;
                    }
                    else if (bykva == 9 && (line > 0 && line < 9) && HisPlace[bykva][line] != "#" && HisPlace[bykva][line + 1] != "#" &&
                        HisPlace[bykva][line - 1] != "#" && HisPlace[bykva - 1][line] != "#" && HisPlace[bykva - 1][line + 1] != "#" && HisPlace[bykva - 1][line - 1] != "#")
                    {
                        HisPlace[bykva][line] = "#";
                        oneC[pos] += (line + 1).ToString();
                        off = true;
                    }
                    else if (bykva == 0 && line == 0 && HisPlace[bykva][line] != "#" && HisPlace[bykva + 1][line] != "#" &&
                        HisPlace[bykva][line + 1] != "#" && HisPlace[bykva + 1][line + 1] != "#")
                    {
                        HisPlace[bykva][line] = "#";
                        oneC[pos] += (line + 1).ToString();
                        off = true;
                    }
                    else if (bykva == 9 && line == 0 && HisPlace[bykva][line] != "#" && HisPlace[bykva][line + 1] != "#" &&
                        HisPlace[bykva - 1][line] != "#" && HisPlace[bykva - 1][line + 1] != "#")
                    {
                        HisPlace[bykva][line] = "#";
                        oneC[pos] += (line + 1).ToString();
                        off = true;
                    }
                    else if (bykva == 0 && line == 9 && HisPlace[bykva][line] != "#" && HisPlace[bykva][line - 1] != "#" &&
                        HisPlace[bykva + 1][line] != "#" && HisPlace[bykva + 1][line - 1] != "#")
                    {
                        HisPlace[bykva][line] = "#";
                        oneC[pos] += (line + 1).ToString();
                        off = true;
                    }
                    else if (bykva == 9 && line == 9 && HisPlace[bykva][line] != "#" && HisPlace[bykva][line - 1] != "#" &&
                        HisPlace[bykva - 1][line] != "#" && HisPlace[bykva - 1][line - 1] != "#")
                    {
                        HisPlace[bykva][line] = "#";
                        oneC[pos] += (line + 1).ToString();
                        off = true;
                    }
                }
                //Console.WriteLine("однопалубка {0}", oneC[pos]);
            }
            public void ForThreeCom(int pos)
            {
                bool off = false;
                while (off != true)
                {
                    int prom = 0;
                    Random rand = new Random();
                    bykva = rand.Next(0, 10);
                    line = rand.Next(0, 10);
                    if ((bykva > 2 && bykva < 9) && (line > 0 && line < 9) && HisPlace[bykva][line] != "#" &&
                        HisPlace[bykva][line + 1] != "#" && HisPlace[bykva][line - 1] != "#" && HisPlace[bykva - 1][line] != "#" &&
                        HisPlace[bykva - 1][line - 1] != "#" && HisPlace[bykva - 1][line + 1] != "#" && HisPlace[bykva - 2][line] != "#" &&
                        HisPlace[bykva - 2][line - 1] != "#" && HisPlace[bykva - 2][line + 1] != "#" && HisPlace[bykva + 1][line] != "#" &&
                        HisPlace[bykva + 1][line - 1] != "#" && HisPlace[bykva + 1][line - 1] != "#" && HisPlace[bykva - 3][line] != "#" &&
                        HisPlace[bykva - 3][line - 1] != "#" && HisPlace[bykva - 3][line + 1] != "#")
                    {
                        while (prom != 3)
                        {
                            HisPlace[bykva][line] = "#";
                            threeC[pos][prom] = Translate(bykva);
                            threeC[pos][prom] += (line + 1).ToString();
                            bykva--;
                            prom++;
                        }
                        off = true;
                    }
                    else if (bykva == 9 && (line > 0 && line < 9) && HisPlace[bykva][line] != "#" && HisPlace[bykva][line + 1] != "#" &&
                        HisPlace[bykva][line - 1] != "#" && HisPlace[bykva - 1][line] != "#" && HisPlace[bykva - 1][line + 1] != "#" &&
                        HisPlace[bykva - 1][line - 1] != "#" && HisPlace[bykva - 2][line] != "#" && HisPlace[bykva - 2][line + 1] != "#" &&
                        HisPlace[bykva - 2][line - 1] != "#" && HisPlace[bykva - 3][line] != "#" && HisPlace[bykva - 3][line + 1] != "#" &&
                        HisPlace[bykva - 3][line - 1] != "#")
                    {
                        while (prom != 3)
                        {
                            HisPlace[bykva][line] = "#";
                            threeC[pos][prom] = Translate(bykva);
                            threeC[pos][prom] += (line + 1).ToString();
                            bykva--;
                            prom++;
                        }
                        off = true;
                    }
                    else if ((bykva > 2 && bykva < 9) && line == 0 && HisPlace[bykva][line] != "#" && HisPlace[bykva][line + 1] != "#" &&
                        HisPlace[bykva + 1][line] != "#" && HisPlace[bykva + 1][line + 1] != "#" && HisPlace[bykva - 1][line] != "#" &&
                        HisPlace[bykva - 1][line + 1] != "#" && HisPlace[bykva - 2][line] != "#" && HisPlace[bykva - 2][line + 1] != "#" &&
                        HisPlace[bykva - 3][line] != "#" && HisPlace[bykva - 3][line + 1] != "#")
                    {
                        while (prom != 3)
                        {
                            HisPlace[bykva][line] = "#";
                            threeC[pos][prom] = Translate(bykva);
                            threeC[pos][prom] += (line + 1).ToString();
                            bykva--;
                            prom++;
                        }
                        off = true;
                    }
                    else if (bykva == 9 && line == 0 && HisPlace[bykva][line] != "#" && HisPlace[bykva][line + 1] != "#" &&
                        HisPlace[bykva - 1][line] != "#" && HisPlace[bykva - 1][line + 1] != "#" && HisPlace[bykva - 2][line] != "#" &&
                        HisPlace[bykva - 2][line + 1] != "#" && HisPlace[bykva - 3][line] != "#" && HisPlace[bykva - 3][line + 1] != "#")
                    {
                        while (prom != 3)
                        {
                            HisPlace[bykva][line] = "#";
                            threeC[pos][prom] = Translate(bykva);
                            threeC[pos][prom] += (line + 1).ToString();
                            bykva--;
                            prom++;
                        }
                        off = true;
                    }
                    else if ((bykva > 0 && bykva < 3) && line == 0 && HisPlace[bykva][line] != "#" && HisPlace[bykva][line + 1] != "#" &&
                        HisPlace[bykva - 1][line] != "#" && HisPlace[bykva - 1][line + 1] != "#" && HisPlace[bykva + 1][line] != "#" &&
                        HisPlace[bykva + 1][line + 1] != "#" && HisPlace[bykva + 2][line] != "#" && HisPlace[bykva + 2][line + 1] != "#" &&
                        HisPlace[bykva + 3][line] != "#" && HisPlace[bykva + 3][line + 1] != "#")
                    {
                        while (prom != 3)
                        {
                            HisPlace[bykva][line] = "#";
                            threeC[pos][prom] = Translate(bykva);
                            threeC[pos][prom] += (line + 1).ToString();
                            bykva++;
                            prom++;
                        }
                        off = true;
                    }
                    else if (bykva == 0 && line == 0 && HisPlace[bykva][line] != "#" && HisPlace[bykva][line + 1] != "#" &&
                        HisPlace[bykva + 1][line] != "#" && HisPlace[bykva + 1][line + 1] != "#" && HisPlace[bykva + 2][line] != "#" &&
                        HisPlace[bykva + 2][line + 1] != "#" && HisPlace[bykva + 3][line] != "#" && HisPlace[bykva + 3][line + 1] != "#")
                    {
                        while (prom != 3)
                        {
                            HisPlace[bykva][line] = "#";
                            threeC[pos][prom] = Translate(bykva);
                            threeC[pos][prom] += (line + 1).ToString();
                            bykva++;
                            prom++;
                        }
                        off = true;
                    }
                    else if ((bykva > 0 && bykva < 3) && (line > 0 && line < 9) && HisPlace[bykva][line] != "#" &&
                        HisPlace[bykva][line + 1] != "#" && HisPlace[bykva][line - 1] != "#" && HisPlace[bykva - 1][line] != "#" &&
                        HisPlace[bykva - 1][line - 1] != "#" && HisPlace[bykva - 1][line + 1] != "#" && HisPlace[bykva + 1][line] != "#" &&
                        HisPlace[bykva + 1][line - 1] != "#" && HisPlace[bykva + 1][line + 1] != "#" && HisPlace[bykva + 2][line] != "#" &&
                        HisPlace[bykva + 2][line - 1] != "#" && HisPlace[bykva + 2][line + 1] != "#" && HisPlace[bykva + 3][line] != "#" &&
                        HisPlace[bykva + 3][line - 1] != "#" && HisPlace[bykva + 3][line + 1] != "#")
                    {
                        while (prom != 3)
                        {
                            HisPlace[bykva][line] = "#";
                            threeC[pos][prom] = Translate(bykva);
                            threeC[pos][prom] += (line + 1).ToString();
                            bykva++;
                            prom++;
                        }
                        off = true;
                    }
                    else if (bykva == 0 && (line > 0 && line < 9) && HisPlace[bykva][line] != "#" && HisPlace[bykva][line + 1] != "#" &&
                        HisPlace[bykva][line - 1] != "#" && HisPlace[bykva + 1][line] != "#" && HisPlace[bykva + 1][line + 1] != "#" &&
                        HisPlace[bykva + 1][line - 1] != "#" && HisPlace[bykva + 2][line] != "#" && HisPlace[bykva + 2][line + 1] != "#" &&
                        HisPlace[bykva + 2][line - 1] != "#" && HisPlace[bykva + 3][line] != "#" && HisPlace[bykva + 3][line + 1] != "#" &&
                        HisPlace[bykva + 3][line - 1] != "#")
                    {
                        while (prom != 3)
                        {
                            HisPlace[bykva][line] = "#";
                            threeC[pos][prom] = Translate(bykva);
                            threeC[pos][prom] += (line + 1).ToString();
                            bykva++;
                            prom++;
                        }
                        off = true;
                    }
                    else if ((bykva > 2 && bykva < 9) && line == 9 && HisPlace[bykva][line] != "#" && HisPlace[bykva][line - 1] != "#" &&
                        HisPlace[bykva + 1][line] != "#" && HisPlace[bykva + 1][line - 1] != "#" && HisPlace[bykva - 1][line] != "#" &&
                        HisPlace[bykva - 1][line - 1] != "#" && HisPlace[bykva - 2][line] != "#" && HisPlace[bykva - 2][line - 1] != "#" &&
                        HisPlace[bykva - 3][line] != "#" && HisPlace[bykva - 3][line - 1] != "#")
                    {
                        while (prom != 3)
                        {
                            HisPlace[bykva][line] = "#";
                            threeC[pos][prom] = Translate(bykva);
                            threeC[pos][prom] += (line + 1).ToString();
                            bykva--;
                            prom++;
                        }
                        off = true;
                    }
                    else if (bykva == 9 && line == 9 && HisPlace[bykva][line] != "#" && HisPlace[bykva][line - 1] != "#" &&
                        HisPlace[bykva - 1][line] != "#" && HisPlace[bykva - 1][line - 1] != "#" && HisPlace[bykva - 2][line] != "#" &&
                        HisPlace[bykva - 2][line - 1] != "#" && HisPlace[bykva - 3][line] != "#" && HisPlace[bykva - 3][line - 1] != "#")
                    {
                        while (prom != 3)
                        {
                            HisPlace[bykva][line] = "#";
                            threeC[pos][prom] = Translate(bykva);
                            threeC[pos][prom] += (line + 1).ToString();
                            bykva--;
                            prom++;
                        }
                        off = true;
                    }
                    else if ((bykva > 0 && bykva < 3) && line == 9 && HisPlace[bykva][line] != "#" && HisPlace[bykva][line - 1] != "#" &&
                        HisPlace[bykva - 1][line] != "#" && HisPlace[bykva - 1][line - 1] != "#" && HisPlace[bykva + 1][line] != "#" &&
                        HisPlace[bykva + 1][line - 1] != "#" && HisPlace[bykva + 2][line] != "#" && HisPlace[bykva + 2][line - 1] != "#" &&
                        HisPlace[bykva + 3][line] != "#" && HisPlace[bykva + 3][line - 1] != "#")
                    {
                        while (prom != 3)
                        {
                            HisPlace[bykva][line] = "#";
                            threeC[pos][prom] = Translate(bykva);
                            threeC[pos][prom] += (line + 1).ToString();
                            bykva++;
                            prom++;
                        }
                        off = true;
                    }
                    else if (bykva == 0 && line == 9 && HisPlace[bykva][line] != "#" && HisPlace[bykva][line - 1] != "#" &&
                        HisPlace[bykva + 1][line] != "#" && HisPlace[bykva + 1][line - 1] != "#" && HisPlace[bykva + 2][line] != "#" &&
                        HisPlace[bykva + 2][line - 1] != "#" && HisPlace[bykva + 3][line] != "#" && HisPlace[bykva + 3][line - 1] != "#")
                    {
                        while (prom != 3)
                        {
                            HisPlace[bykva][line] = "#";
                            threeC[pos][prom] = Translate(bykva);
                            threeC[pos][prom] += (line + 1).ToString();
                            bykva++;
                            prom++;
                        }
                        off = true;
                    }
                } //for (int i = 0; i < 2; i++)for(int j=0;j<3;j++) Console.WriteLine("{0}", threeC[i][j]);
            }
            public void ForTwoCom(int pos)
            {
                bool off = false;
                while (off != true)
                {
                    int prom = 0;
                    Random rand = new Random();
                    bykva = rand.Next(0, 10);
                    line = rand.Next(0, 10);
                    if ((bykva > 2 && bykva < 9) && (line > 0 && line < 9) && HisPlace[bykva][line] != "#" &&
                        HisPlace[bykva][line + 1] != "#" && HisPlace[bykva][line - 1] != "#" && HisPlace[bykva - 1][line] != "#" &&
                        HisPlace[bykva - 1][line - 1] != "#" && HisPlace[bykva - 1][line + 1] != "#" && HisPlace[bykva - 2][line] != "#" &&
                        HisPlace[bykva - 2][line - 1] != "#" && HisPlace[bykva - 2][line + 1] != "#" && HisPlace[bykva + 1][line] != "#" &&
                        HisPlace[bykva + 1][line - 1] != "#" && HisPlace[bykva + 1][line - 1] != "#")
                    {
                        while (prom != 2)
                        {
                            HisPlace[bykva][line] = "#";
                            twoC[pos][prom] = Translate(bykva);
                            twoC[pos][prom] += (line + 1).ToString();
                            bykva--;
                            prom++;
                        }
                        off = true;
                    }
                    else if (bykva == 9 && (line > 0 && line < 9) && HisPlace[bykva][line] != "#" && HisPlace[bykva][line + 1] != "#" &&
                        HisPlace[bykva][line - 1] != "#" && HisPlace[bykva - 1][line] != "#" && HisPlace[bykva - 1][line + 1] != "#" &&
                        HisPlace[bykva - 1][line - 1] != "#" && HisPlace[bykva - 2][line] != "#" && HisPlace[bykva - 2][line + 1] != "#" &&
                        HisPlace[bykva - 2][line - 1] != "#")
                    {
                        while (prom != 2)
                        {
                            HisPlace[bykva][line] = "#";
                            twoC[pos][prom] = Translate(bykva);
                            twoC[pos][prom] += (line + 1).ToString();
                            bykva--;
                            prom++;
                        }
                        off = true;
                    }
                    else if ((bykva > 2 && bykva < 9) && line == 0 && HisPlace[bykva][line] != "#" && HisPlace[bykva][line + 1] != "#" &&
                        HisPlace[bykva + 1][line] != "#" && HisPlace[bykva + 1][line + 1] != "#" && HisPlace[bykva - 1][line] != "#" &&
                        HisPlace[bykva - 1][line + 1] != "#" && HisPlace[bykva - 2][line] != "#" && HisPlace[bykva - 2][line + 1] != "#")
                    {
                        while (prom != 2)
                        {
                            HisPlace[bykva][line] = "#";
                            twoC[pos][prom] = Translate(bykva);
                            twoC[pos][prom] += (line + 1).ToString();
                            bykva--;
                            prom++;
                        }
                        off = true;
                    }
                    else if (bykva == 9 && line == 0 && MyPlace[bykva][line] != "#" && HisPlace[bykva][line + 1] != "#" &&
                        HisPlace[bykva - 1][line] != "#" && HisPlace[bykva - 1][line + 1] != "#" && HisPlace[bykva - 2][line] != "#" &&
                        HisPlace[bykva - 2][line + 1] != "#")
                    {
                        while (prom != 2)
                        {
                            HisPlace[bykva][line] = "#";
                            twoC[pos][prom] = Translate(bykva);
                            twoC[pos][prom] += (line + 1).ToString();
                            bykva--;
                            prom++;
                        }
                        off = true;
                    }
                    else if ((bykva > 0 && bykva < 3) && line == 0 && HisPlace[bykva][line] != "#" && HisPlace[bykva][line + 1] != "#" &&
                        HisPlace[bykva - 1][line] != "#" && HisPlace[bykva - 1][line + 1] != "#" && HisPlace[bykva + 1][line] != "#" &&
                        HisPlace[bykva + 1][line + 1] != "#" && HisPlace[bykva + 2][line] != "#" && HisPlace[bykva + 2][line + 1] != "#")
                    {
                        while (prom != 2)
                        {
                            HisPlace[bykva][line] = "#";
                            twoC[pos][prom] = Translate(bykva);
                            twoC[pos][prom] += (line + 1).ToString();
                            bykva++;
                            prom++;
                        }
                        off = true;
                    }
                    else if (bykva == 0 && line == 0 && HisPlace[bykva][line] != "#" && HisPlace[bykva][line + 1] != "#" &&
                        HisPlace[bykva + 1][line] != "#" && HisPlace[bykva + 1][line + 1] != "#" && HisPlace[bykva + 2][line] != "#" &&
                        HisPlace[bykva + 2][line + 1] != "#")
                    {
                        while (prom != 2)
                        {
                            HisPlace[bykva][line] = "#";
                            twoC[pos][prom] = Translate(bykva);
                            twoC[pos][prom] += (line + 1).ToString();
                            bykva++;
                            prom++;
                        }
                        off = true;
                    }
                    else if ((bykva > 0 && bykva < 3) && (line > 0 && line < 9) && HisPlace[bykva][line] != "#" &&
                        HisPlace[bykva][line + 1] != "#" && HisPlace[bykva][line - 1] != "#" && HisPlace[bykva - 1][line] != "#" &&
                        HisPlace[bykva - 1][line - 1] != "#" && HisPlace[bykva - 1][line + 1] != "#" && HisPlace[bykva + 1][line] != "#" &&
                        HisPlace[bykva + 1][line - 1] != "#" && HisPlace[bykva + 1][line + 1] != "#" && HisPlace[bykva + 2][line] != "#" &&
                        HisPlace[bykva + 2][line - 1] != "#" && HisPlace[bykva + 2][line + 1] != "#")
                    {
                        while (prom != 2)
                        {
                            HisPlace[bykva][line] = "#";
                            twoC[pos][prom] = Translate(bykva);
                            twoC[pos][prom] += (line + 1).ToString();
                            bykva++;
                            prom++;
                        }
                        off = true;
                    }
                    else if (bykva == 0 && (line > 0 && line < 9) && HisPlace[bykva][line] != "#" && HisPlace[bykva][line + 1] != "#" &&
                        HisPlace[bykva][line - 1] != "#" && HisPlace[bykva + 1][line] != "#" && HisPlace[bykva + 1][line + 1] != "#" &&
                        HisPlace[bykva + 1][line - 1] != "#" && HisPlace[bykva + 2][line] != "#" && HisPlace[bykva + 2][line + 1] != "#" &&
                        HisPlace[bykva + 2][line - 1] != "#")
                    {
                        while (prom != 2)
                        {
                            HisPlace[bykva][line] = "#";
                            twoC[pos][prom] = Translate(bykva);
                            twoC[pos][prom] += (line + 1).ToString();
                            bykva++;
                            prom++;
                        }
                        off = true;
                    }
                    else if ((bykva > 2 && bykva < 9) && line == 9 && HisPlace[bykva][line] != "#" && HisPlace[bykva][line - 1] != "#" &&
                        HisPlace[bykva + 1][line] != "#" && HisPlace[bykva + 1][line - 1] != "#" && HisPlace[bykva - 1][line] != "#" &&
                        HisPlace[bykva - 1][line - 1] != "#" && HisPlace[bykva - 2][line] != "#" && HisPlace[bykva - 2][line - 1] != "#")
                    {
                        while (prom != 2)
                        {
                            HisPlace[bykva][line] = "#";
                            twoC[pos][prom] = Translate(bykva);
                            twoC[pos][prom] += (line + 1).ToString();
                            bykva--;
                            prom++;
                        }
                        off = true;
                    }
                    else if (bykva == 9 && line == 9 && HisPlace[bykva][line] != "#" && HisPlace[bykva][line - 1] != "#" &&
                        HisPlace[bykva - 1][line] != "#" && HisPlace[bykva - 1][line - 1] != "#" && HisPlace[bykva - 2][line] != "#" &&
                        HisPlace[bykva - 2][line - 1] != "#")
                    {
                        while (prom != 2)
                        {
                            HisPlace[bykva][line] = "#";
                            twoC[pos][prom] = Translate(bykva);
                            twoC[pos][prom] += (line + 1).ToString();
                            bykva--;
                            prom++;
                        }
                        off = true;
                    }
                    else if ((bykva > 0 && bykva < 3) && line == 9 && HisPlace[bykva][line] != "#" && HisPlace[bykva][line - 1] != "#" &&
                        HisPlace[bykva - 1][line] != "#" && HisPlace[bykva - 1][line - 1] != "#" && HisPlace[bykva + 1][line] != "#" &&
                        HisPlace[bykva + 1][line - 1] != "#" && HisPlace[bykva + 2][line] != "#" && HisPlace[bykva + 2][line - 1] != "#")
                    {
                        while (prom != 2)
                        {
                            HisPlace[bykva][line] = "#";
                            twoC[pos][prom] = Translate(bykva);
                            twoC[pos][prom] += (line + 1).ToString();
                            bykva++;
                            prom++;
                        }
                        off = true;
                    }
                    else if (bykva == 0 && line == 9 && HisPlace[bykva][line] != "#" && HisPlace[bykva][line - 1] != "#" &&
                        HisPlace[bykva + 1][line] != "#" && HisPlace[bykva + 1][line - 1] != "#" && HisPlace[bykva + 2][line] != "#" &&
                        HisPlace[bykva + 2][line - 1] != "#")
                    {
                        while (prom != 2)
                        {
                            HisPlace[bykva][line] = "#";
                            twoC[pos][prom] = Translate(bykva);
                            twoC[pos][prom] += (line + 1).ToString();
                            bykva++;
                            prom++;
                        }
                        off = true;
                    }
                }
                // for (int i = 0; i < 2; i++) Console.WriteLine("двупалубка {0}", twoC[pos][i]);
            }
            /*===============================*/

            public string Translate(int s)
            {
                s += 65;
                return Convert.ToChar(s).ToString();
            }

            public void My_Faire()
            {
                Console.Write("Мой ход: ");
                MyFaire = Console.ReadLine();
                char a;
                if (MyFaire.Length < 3)
                {
                    a = MyFaire[1];
                    line = Convert.ToInt32(a - 48);
                    line--;
                }
                else line = 9;
                a = MyFaire[0];
                bykva = Convert.ToInt32(a - 65);

            }
            public void His_Faire()
            {
                Random rand = new Random();
                bykva = rand.Next(0, 10);
                line = rand.Next(0, 10);
                HisFaire = Translate(bykva);
                HisFaire += (line + 1).ToString();
                Console.WriteLine("Ход робота: {0}", HisFaire);
            }
            public void Result()
            {
                int p = 0;
                int fourCkol = 0, three1Ckol = 0, three2Ckol = 0, two1Ckol = 0, two2Ckol = 0, two3Ckol = 0;
                int fourMykol = 0, three1Mykol = 0, three2Mykol = 0, two1Mykol = 0, two2Mykol = 0, two3Mykol = 0;
                int MyN = 0, HisN = 0, vis1 = 0, vis2 = 0;
                //do
                //{
                while (p == 0)//(MyN != 9 || HisN != 9)
                {
                    while (vis1 != 1)
                    {
                        if (MyN == 10) { Console.WriteLine("*************ТЫ ВЫИГРАЛ(А)!!!*************"); p = 1; break; }
                        else if (HisN == 10) { Console.WriteLine("*************КОМРЬЮТЕР ВЫИГРАЛ!!!*************"); p = 1; break; }
                        vis2 = 0;
                        His_Faire();
                        if (HisFaire == one[0])
                        {
                            MyPlace[bykva][line] = "X";
                            Console.WriteLine("***Убил!!!***");
                            HisN++;
                            Output();
                            Console.WriteLine("Игрок-человек: пропускает...");
                        }
                        else if (HisFaire == one[1])
                        {
                            MyPlace[bykva][line] = "X";
                            Console.WriteLine("***Убил!!!***");
                            HisN++;
                            Output();
                            Console.WriteLine("Игрок-человек: пропускает...");
                        }
                        else if (HisFaire == one[2])
                        {
                            MyPlace[bykva][line] = "X";
                            Console.WriteLine("***Убил!!!***");
                            HisN++;
                            Output();
                            Console.WriteLine("Игрок-человек: пропускает...");
                        }
                        else if (HisFaire == one[3])
                        {
                            MyPlace[bykva][line] = "X";
                            Console.WriteLine("***Убил!!!***");
                            HisN++;
                            Output();
                            Console.WriteLine("Игрок-человек: пропускает...");
                        }
                        else if (HisFaire == four[0] || HisFaire == four[1] || HisFaire == four[2] || HisFaire == four[3])
                        {
                            if (fourMykol < 3)
                            {
                                MyPlace[bykva][line] = "X";
                                Console.WriteLine("***Ранил!!!***");
                                //HisN++;
                                Output();
                                Console.WriteLine("Игрок-человек: пропускает...");
                                fourMykol++;
                            }
                            else
                            {
                                MyPlace[bykva][line] = "X";
                                Console.WriteLine("***Убил!!!***");
                                HisN++;
                                Output();
                                Console.WriteLine("Игрок-человек: пропускает...");
                                fourMykol++;
                            }
                        }
                        else if (HisFaire == three[0][0] || HisFaire == three[0][1] || HisFaire == three[0][2])
                        {
                            if (three1Mykol < 2)
                            {
                                MyPlace[bykva][line] = "X";
                                Console.WriteLine("***Ранил!!!***");
                                //HisN++;
                                Output();
                                Console.WriteLine("Игрок-человек: пропускает...");
                                three1Mykol++;
                            }
                            else
                            {
                                MyPlace[bykva][line] = "X";
                                Console.WriteLine("***Убил!!!***");
                                HisN++;
                                Output();
                                Console.WriteLine("Игрок-человек: пропускает...");
                                three1Mykol++;
                            }
                        }
                        else if (HisFaire == three[1][0] || HisFaire == three[1][1] || HisFaire == three[1][2])
                        {
                            if (three2Mykol < 2)
                            {
                                MyPlace[bykva][line] = "X";
                                Console.WriteLine("***Ранил!!!***");
                                //HisN++;
                                Output();
                                Console.WriteLine("Игрок-человек: пропускает...");
                                three2Mykol++;
                            }
                            else
                            {
                                MyPlace[bykva][line] = "X";
                                Console.WriteLine("***Убил!!!***");
                                HisN++;
                                Output();
                                Console.WriteLine("Игрок-человек: пропускает...");
                                three2Mykol++;
                            }
                        }
                        else if (HisFaire == two[0][0] || HisFaire == two[0][1])
                        {
                            if (two1Mykol < 1)
                            {
                                MyPlace[bykva][line] = "X";
                                Console.WriteLine("***Ранил!!!***");
                                //HisN++;
                                Output();
                                Console.WriteLine("Игрок-человек: пропускает...");
                                two1Mykol++;
                            }
                            else
                            {
                                MyPlace[bykva][line] = "X";
                                Console.WriteLine("***Убил!!!***");
                                HisN++;
                                Output();
                                Console.WriteLine("Игрок-человек: пропускает...");
                                two1Mykol++;
                            }
                        }
                        else if (HisFaire == two[1][0] || HisFaire == two[1][1])
                        {
                            if (two2Mykol < 2)
                            {
                                MyPlace[bykva][line] = "X";
                                Console.WriteLine("***Ранил!!!***");
                                //HisN++;
                                Output();
                                Console.WriteLine("Игрок-человек: пропускает...");
                                two2Mykol++;
                            }
                            else
                            {
                                MyPlace[bykva][line] = "X";
                                Console.WriteLine("***Убил!!!***");
                                HisN++;
                                Output();
                                Console.WriteLine("Игрок-человек: пропускает...");
                                two2Mykol++;
                            }
                        }
                        else if (HisFaire == two[2][0] || HisFaire == two[2][1])
                        {
                            if (two3Mykol < 2)
                            {
                                MyPlace[bykva][line] = "X";
                                Console.WriteLine("***Ранил!!!***");
                                //HisN++;
                                Output();
                                Console.WriteLine("Игрок-человек: пропускает...");
                                two3Mykol++;
                            }
                            else
                            {
                                MyPlace[bykva][line] = "X";
                                Console.WriteLine("***Убил!!!***");
                                HisN++;
                                Output();
                                Console.WriteLine("Игрок-человек: пропускает...");
                                two3Mykol++;
                            }
                        }
                        else
                        {
                            Console.WriteLine("***Мимо!***");
                            MyPlace[bykva][line] = "o";
                            Output();
                            vis1 = 1;
                        }
                    }
                    //=======================================================================
                    while (vis2 != 1)
                    {
                        if (MyN == 10) { Console.WriteLine("*************ТЫ ВЫИГРАЛ(А)!!!*************"); p = 1; break; }
                        else if (HisN == 10) { Console.WriteLine("*************КОМПЬЮТЕР ВЫИГРАЛ!!!*************"); p = 1; break; }
                        vis1 = 0;
                        My_Faire();
                        if (MyFaire == oneC[0])
                        {
                            HisPlaceBuf[bykva][line] = "X";
                            Console.WriteLine("***Убил!!!***");
                            MyN++;// Console.WriteLine("MyN={0}", MyN);
                            Output();
                            Console.WriteLine("Компьютер: пропускает...");
                        }
                        else if (MyFaire == oneC[1])
                        {
                            HisPlaceBuf[bykva][line] = "X";
                            Console.WriteLine("***Убил!!!***");
                            MyN++;// Console.WriteLine("MyN={0}", MyN);
                            Output();
                            Console.WriteLine("Компьютер: пропускает...");
                        }
                        else if (MyFaire == oneC[2])
                        {
                            HisPlaceBuf[bykva][line] = "X";
                            Console.WriteLine("***Убил!!!***");
                            MyN++;  //Console.WriteLine("MyN={0}", MyN);
                            Output();
                            Console.WriteLine("Компьютер: пропускает...");
                        }
                        else if (MyFaire == oneC[3])
                        {
                            HisPlaceBuf[bykva][line] = "X";
                            Console.WriteLine("***Убил!!!***");
                            MyN++; // Console.WriteLine("MyN={0}", MyN);
                            Output();
                            Console.WriteLine("Компьютер: пропускает...");
                        }
                        else if (MyFaire == fourC[0] || MyFaire == fourC[1] || MyFaire == fourC[2] || MyFaire == fourC[3])
                        {
                            if (fourCkol < 3)
                            {
                                HisPlaceBuf[bykva][line] = "X";
                                Console.WriteLine("***Ранил!!!***");
                                //MyN++;
                                Output();
                                Console.WriteLine("Компьютер: пропускает...");
                                fourCkol++;
                            }
                            else
                            {
                                HisPlaceBuf[bykva][line] = "X";
                                Console.WriteLine("***Убил!!!***");
                                MyN++; // Console.WriteLine("MyN={0}", MyN);
                                Output();
                                Console.WriteLine("Компьютер: пропускает...");
                                fourCkol++;
                            }
                        }
                        else if (MyFaire == threeC[0][0] || MyFaire == threeC[0][1] || MyFaire == threeC[0][2])
                        {
                            if (three1Ckol < 2)
                            {
                                HisPlaceBuf[bykva][line] = "X";
                                Console.WriteLine("***Ранил!!!***");
                                //MyN++;
                                Output();
                                Console.WriteLine("Компьютер: пропускает...");
                                three1Ckol++;
                            }
                            else
                            {
                                HisPlaceBuf[bykva][line] = "X";
                                Console.WriteLine("***Убил!!!***");
                                MyN++;// Console.WriteLine("MyN={0}", MyN);
                                Output();
                                Console.WriteLine("Компьютер: пропускает...");
                                three1Ckol++;
                            }
                        }
                        else if (MyFaire == threeC[1][0] || MyFaire == threeC[1][1] || MyFaire == threeC[1][2])
                        {
                            if (three2Ckol < 2)
                            {
                                HisPlaceBuf[bykva][line] = "X";
                                Console.WriteLine("***Ранил!!!***");
                                // MyN++;
                                Output();
                                Console.WriteLine("Компьютер: пропускает...");
                                three2Ckol++;
                            }
                            else
                            {
                                HisPlaceBuf[bykva][line] = "X";
                                Console.WriteLine("***Убил!!!***");
                                MyN++; //Console.WriteLine("MyN={0}", MyN);
                                Output();
                                Console.WriteLine("Компьютер: пропускает...");
                                three2Ckol++;
                            }
                        }
                        else if (MyFaire == twoC[0][0] || MyFaire == twoC[0][1])
                        {
                            if (two1Ckol < 1)
                            {
                                HisPlaceBuf[bykva][line] = "X";
                                Console.WriteLine("***Ранил!!!***");
                                //MyN++;
                                Output();
                                Console.WriteLine("Компьютер: пропускает...");
                                two1Ckol++;
                            }
                            else
                            {
                                HisPlaceBuf[bykva][line] = "X";
                                Console.WriteLine("***Убил!!!***");
                                MyN++; // Console.WriteLine("MyN={0}", MyN);
                                Output();
                                Console.WriteLine("Компьютер: пропускает...");
                                two1Ckol++;
                            }
                        }
                        else if (MyFaire == twoC[1][0] || MyFaire == twoC[1][1])
                        {
                            if (two2Ckol < 1)
                            {
                                HisPlaceBuf[bykva][line] = "X";
                                Console.WriteLine("***Ранил!!!***");
                                // MyN++;
                                Output();
                                Console.WriteLine("Компьютер: пропускает...");
                                two2Ckol++;
                            }
                            else
                            {
                                HisPlaceBuf[bykva][line] = "X";
                                Console.WriteLine("***Убил!!!***");
                                MyN++; // Console.WriteLine("MyN={0}", MyN);
                                Output();
                                Console.WriteLine("Компьютер: пропускает...");
                                two2Ckol++;
                            }
                        }
                        else if (MyFaire == twoC[2][0] || MyFaire == twoC[2][1])
                        {
                            if (two3Ckol < 1)
                            {
                                HisPlaceBuf[bykva][line] = "X";
                                Console.WriteLine("***Ранил!!!***");
                                // MyN++;
                                Output();
                                Console.WriteLine("Компьютер: пропускает...");
                                two3Ckol++;
                            }
                            else
                            {
                                HisPlaceBuf[bykva][line] = "X";
                                Console.WriteLine("***Убил!!!***");
                                MyN++;  //Console.WriteLine("MyN={0}", MyN);
                                Output();
                                Console.WriteLine("Компьютер: пропускает...");
                                two3Ckol++;
                            }
                        }
                        else
                        {
                            Console.WriteLine("***Мимо!***");
                            HisPlaceBuf[bykva][line] = "o";
                            Output();
                            vis2 = 1;
                        }
                    }

                }

            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Place obj = new Place();
                // Инициализирую моё поле
                obj.ForFour();
                obj.ForThree(0);
                obj.ForThree(1);
                obj.ForTwo(0);
                obj.ForTwo(1);
                obj.ForTwo(2);
                obj.ForOne(0);
                obj.ForOne(1);
                obj.ForOne(2);
                obj.ForOne(3);
                // Инициализирую поле компьютера
                obj.ForFourCom();
                obj.ForThreeCom(0);
                obj.ForThreeCom(1);
                obj.ForTwoCom(0);
                obj.ForTwoCom(1);
                obj.ForTwoCom(2);
                obj.ForOneCom(0);
                obj.ForOneCom(1);
                obj.ForOneCom(2);
                obj.ForOneCom(3);
                obj.Output();
                obj.Result();
                Console.ReadLine();
            }
        }
    }
}

    