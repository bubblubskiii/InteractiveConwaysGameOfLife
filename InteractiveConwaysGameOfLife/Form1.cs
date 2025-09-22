using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InteractiveConwaysGameOfLife
{
    public partial class Form1 : Form
    {

        private const int gridSize = 10;
        private const int cellSize = 40;
        
        // main array that holds the cells 
        public  int[,] gameArray = new int[gridSize, gridSize];
        public int[,] gameArrayDupe = new int[gridSize, gridSize];
        

        public Form1()
        {
            InitializeComponent();


            gamePanel.Paint += gamePanel_Paint;

            // prevents any flickering
          //  gamePanel.DoubleBuffered(true);

        }



        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void MainGame()
        {
            // a temp array to store the next iteration's cells
            int[,] workingArray = new int[10, 10];
            workingArray = FillArrayWithZeros(10, 10);


            // looping through each cell in the gameArray

            for (int row = 0; row < gameArray.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < gameArray.GetLength(1) - 1; col++)
                {
                    int neighbours = ReturnNeighbours(gameArray, row, col);

                    //Console.WriteLine(neighbours);


                    // checks if the cell is alive, and then applies conway's rules 
                    if (gameArray[row, col] == 1)
                    {
                        // if cell has either 2 or 3 neighbouring cells then it will live
                        if ((neighbours == 2) || (neighbours == 3))

                        {
                            workingArray[row, col] = 1;
                        }
                        else
                        {
                            workingArray[row, col] = 0;
                        }
                    }
                    // applying conways rules to the dead cells
                    else
                    {
                        if (neighbours == 3)
                        {
                            workingArray[row, col] = 1;
                        }
                    }

                }
            }

            gameArray = workingArray;

           // Thread.Sleep(250);

            // refreshing the panel
            gamePanel.Invalidate();
        }

        static int ReturnNeighbours(int[,] gameArray, int row, int col)
        {
            int neighbours = 0;

            int rowLimit = gameArray.GetLength(0) - 1;
            int colLimit = gameArray.GetLength(1) - 1;



            // Min and Max is used to find out whether the neighbouring value will be in boundary of array
            // like a typewriter 
            for (int y = Math.Max(0, row - 1); y <= Math.Min(rowLimit, row + 1); y++)
            {
                for (int x = Math.Max(0, col - 1); x <= Math.Min(colLimit, col + 1); x++)
                {

                    // outputs everything except the centre cell
                    if (x != col || y != row)
                    {

                        if (gameArray[y, x] == 1)
                        {

                            neighbours++;
                            //Console.WriteLine("(" + col + "," + row + ")" + neighbours);
                        }
                    }
                }
            }

            return neighbours;
        }

        static int[,] FillArrayWithZeros(int numRows, int numCols)
        {

            int[,] temp = new int[numRows, numCols];

            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    temp[i, j] = 0;
                }
            }

            return temp;
        }




        private void gamePanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            for (int row = 0; row < gridSize; row++)
            {
                for (int col = 0; col < gridSize; col++)
                {
                    Rectangle rect = new Rectangle(col * cellSize, row * cellSize, cellSize, cellSize); // creating a graphics obj for each cell
                    graphics.DrawRectangle(Pens.Black, rect); // grid outline

                    // if cell is alive colouring it in
                    if (gameArray[row, col] == 1)
                    {
                        graphics.FillRectangle(Brushes.LightSteelBlue, rect);
                        graphics.DrawRectangle(Pens.Black, rect);
                    }
                }
            }
        }


        // detects input from user and then either turns a cell on or off depending on its current state
        private void gamePanel_MouseClick(object sender, MouseEventArgs e)
        {
            
            int row = e.Y / cellSize;
            int col = e.X / cellSize;

            if(row >= 0 && row < gridSize && col >= 0 && col < gridSize)
            {
                if (gameArray[row, col] == 0)
                {
                    gameArray[row, col] = 1;
                }
                else
                {
                    gameArray[row, col] = 0;
                }

            }

            Console.WriteLine($"Clicked row={row}, col={col}, state={gameArray[row, col]}");

            gamePanel.Invalidate();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            timer1.Start();
           
        }

        private void btnStepByOne_Click(object sender, EventArgs e)
        {
            MainGame();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // each tick 
            MainGame();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }



        private void btnResetGrid_Click(object sender, EventArgs e)
        {
            gameArray = gameArrayDupe;
            gamePanel.Invalidate();
        }

        private void btnSaveGrid_Click(object sender, EventArgs e)
        {
            gameArrayDupe = gameArray;
        }
    }



}
