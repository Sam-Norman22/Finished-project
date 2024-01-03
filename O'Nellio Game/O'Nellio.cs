using GameboardGUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Newtonsoft.Json;

namespace Project_Start
{
    public partial class ONellio : Form
    {
        const int NUM_OF_BOARD_ROWS = 8;
        const int NUMBER_OF_BOARD_COL = 8;
        Point currentPos = new Point(-1, -1);


        GameboardImageArray _gameBoardGui;
        int[,] gameBoardData;
        string tileImagesDirPath = Directory.GetCurrentDirectory() + @"\images\";

        int count = 1;
        bool gameInProgress = false;
        
        public ONellio()
        {
            InitializeComponent();

            Point top = new Point(10, 43);
            Point bottom = new Point(10, 75);

            gameBoardData = this.MakeBoardArray();                                                                  //Initialize and create the gameboard

            try
            {
                _gameBoardGui = new GameboardImageArray(this, gameBoardData, top, bottom, 0, tileImagesDirPath);
                _gameBoardGui.TileClicked += new GameboardImageArray.TileClickedEventDelegate(GameTileClicked);
                
            }
            catch (Exception ex)
            {
                DialogResult = MessageBox.Show(ex.ToString(), "Game Board size problem", MessageBoxButtons.OK);
                this.Close();
            }
            
        }

        public int[,] MakeBoardArray()
        {
            int[,] boardArray = new int[NUM_OF_BOARD_ROWS, NUMBER_OF_BOARD_COL];
            int boardVal = 0;

            for (int row = 0; row < NUM_OF_BOARD_ROWS; row++)
            {
                boardVal = 10;
                for (int col = 0; col < NUMBER_OF_BOARD_COL; col++)                                             //Method to make the board array
                {
                    if (boardVal == 0) boardVal = 10;
                    else boardVal = 10;

                    boardArray[row, col] = boardVal;

                }

            }



            return boardArray;

        }
        

        private void GameTileClicked(object sender, EventArgs e)
        {
            int selectionRow = _gameBoardGui.GetCurrentRowIndex(sender);
            int selectionCol = _gameBoardGui.GetCurrentColumnIndex(sender);

            

            if (count % 2 == 0)
            {
                count = count;
            

                if (IsValidMove(selectionRow, selectionCol, 1))
                {
                    currentPos.Y = selectionCol;
                    currentPos.X = selectionRow;

                    gameBoardData[currentPos.X, currentPos.Y] = 1;

                    _gameBoardGui.SetTile(currentPos.X, currentPos.Y, "1");

                    FlipCounters(currentPos.X, currentPos.Y, 1);
                    count = count + 1;
                    p1Turn.Visible = false;                                                     //Method to dictate what happens when a game tile is clicked
                    p2Turn.Visible = true;
                }
                else
                {
                    MessageBox.Show("Invalid move");

                }
            }
            else
            {
                count = count;

                if (IsValidMove(selectionRow, selectionCol, 0))
                {
                    currentPos.Y = selectionCol;
                    currentPos.X = selectionRow;

                    gameBoardData[currentPos.X, currentPos.Y] = 0;

                    _gameBoardGui.SetTile(currentPos.X, currentPos.Y, "0");

                    FlipCounters(currentPos.X, currentPos.Y, 0);
                    count = count + 1;
                    p2Turn.Visible = false;
                    p1Turn.Visible = true;
                }
                else
                {
                    MessageBox.Show("Invalid move");
                }
            }
            UpdateCounters();
        }

        private bool IsValidMove(int row, int col, int currentPlayer)
        {
            
            for (int i = -1; i <= 1; i++)
            {
                for (int x = -1; x <= 1; x++)                                                     //Method checks if the move requested is a leagal move
                {
                    int adjacentRow = row + i;
                    int adjacentCol = col + x;

                    
                    if (adjacentRow >= 0 && adjacentRow < NUM_OF_BOARD_ROWS && adjacentCol >= 0 && adjacentCol < NUMBER_OF_BOARD_COL && gameBoardData[adjacentRow, adjacentCol] == 1 - currentPlayer)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private void FlipCounters(int row, int col, int currentPlayer)
        {
            
            FlipCountersInDirection(row, col, currentPlayer, 1, 0);
            FlipCountersInDirection(row, col, currentPlayer, -1, 0);                                         //Method checks vertically, horizontally, and diagonally and performs the FlipCountersInDirection
                                                                                                            // method
            FlipCountersInDirection(row, col, currentPlayer, 0, 1);
            FlipCountersInDirection(row, col, currentPlayer, 0, -1);
            
            FlipCountersInDirection(row, col, currentPlayer, 1, 1);
            FlipCountersInDirection(row, col, currentPlayer, 1, -1);
            FlipCountersInDirection(row, col, currentPlayer, -1, 1);
            FlipCountersInDirection(row, col, currentPlayer, -1, -1);
        }
        private void FlipCountersInDirection(int row, int col, int currentPlayer, int rowDirection, int colDirection)
        {
            int currentRow = row + rowDirection;
            int currentCol = col + colDirection;

            
            if (currentRow >= 0 && currentRow < NUM_OF_BOARD_ROWS && currentCol >= 0 && currentCol < NUMBER_OF_BOARD_COL)
            {
                
                List<Point> tilesToFlip = new List<Point>();
                                                                                                        //Method checks what counters need to be flipped and what direction to move in to check
                
                while (currentRow >= 0 && currentRow < NUM_OF_BOARD_ROWS && currentCol >= 0 && currentCol < NUMBER_OF_BOARD_COL && gameBoardData[currentRow, currentCol] == 1 - currentPlayer)
                {
                    tilesToFlip.Add(new Point(currentRow, currentCol));
                    currentRow += rowDirection;
                    currentCol += colDirection;
                }

                
                if (currentRow >= 0 && currentRow < NUM_OF_BOARD_ROWS && currentCol >= 0 && currentCol < NUMBER_OF_BOARD_COL && gameBoardData[currentRow, currentCol] == 10)  
                {
                    foreach (var tileToFlip in tilesToFlip)
                    {
                        gameBoardData[tileToFlip.X, tileToFlip.Y] = currentPlayer;
                        _gameBoardGui.SetTile(tileToFlip.X, tileToFlip.Y, currentPlayer.ToString());
                    }
                }
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gameInProgress == true) 
            {
                SaveGame();
                ResetGameBoard();
                UpdateTile(3, 3, "1");
                UpdateTile(4, 3, "0");
                UpdateTile(3, 4, "0");
                UpdateTile(4, 4, "1");
            }
            else if (gameInProgress == false)                                   //Method updates gameboard when game is not running, if it is running, the game can be saved in the users computer and a new
            {                                                                   //game will start
                
                UpdateTile(3, 3, "1");
                UpdateTile(4, 3, "0");
                UpdateTile(3, 4, "0");
                UpdateTile(4, 4, "1");
                gameInProgress = true;

            }
            
        }
        private void ResetGameBoard()
        {
            gameBoardData = MakeBoardArray();                                   //Method for resetting the gameboard
            _gameBoardGui.UpdateBoardGui(gameBoardData);
        }
        public class GameSave
        {
            public string[,] GameBoardState { get; set; }
            public Dictionary<string, int> PlayerScores { get; set; }

            public GameSave()                                                   
            {
                
                GameBoardState = new string[0, 0];                                      //Allows for saving of game
               
            }

            public GameSave(string[,] gameBoardState)
            {
                GameBoardState = gameBoardState;
                
            }
        }
        private void SaveGame()
        {

            GameSave gameSave = new GameSave
            {
                GameBoardState = GetGameBoardState(),
            };

            string json = JsonConvert.SerializeObject(gameSave);                                            //logic for saving of games

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                saveFileDialog.Title = "Save Game";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, json);
                }
            }
        }


        
        private int[,] GetGameBoardData()
        {
            return gameBoardData;
        }
        private string[,] GetGameBoardState()
        {
            
            int[,] gameBoardData = GetGameBoardData(); 

            
            int rows = gameBoardData.GetLength(0);                                              //Logic for getting the state of the gameboard so that it can be saved
            int cols = gameBoardData.GetLength(1);

            string[,] gameBoardDataAsString = new string[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int x = 0; x < cols; x++)
                {
                    gameBoardDataAsString[i, x] = gameBoardData[i, x].ToString();
                }
            }

            return gameBoardDataAsString;
        }

        private void UpdateTile(int row, int col, string tileValue)
        {
            
            _gameBoardGui.SetTile(row, col, tileValue);

            if (tileValue == "0")                                                           //Method to update tiles
            {
                gameBoardData[row, col] = 0;
            }
            else if (tileValue == "1")
            {
                gameBoardData[row, col] = 1;
            }
            
        }

        private void UpdateCounters()
        {
            
            int blackCount = CountBlackCounters(); 
            int whiteCount = CountWhiteCounters();                                              //Method to update the count of the counters on the board

            
            lbl_BlackCount.Text = $"{blackCount}";
            lbl_WhiteCount.Text = $"{whiteCount}";
        }

      
        private int CountBlackCounters()
        {
            int blackCount = 0;

            
            for (int row = 0; row < NUM_OF_BOARD_ROWS; row++)
            {
                for (int col = 0; col < NUMBER_OF_BOARD_COL; col++)                                 //Method to count black counters
                {
                    
                    if (gameBoardData[row, col] == 0)
                    {
                        blackCount = blackCount + 1;
                    }
                }
            }

            return blackCount;
        }

        private int CountWhiteCounters()
        {
            int WhiteCount = 0;

            
            for (int row = 0; row < NUM_OF_BOARD_ROWS; row++)
            {
                for (int col = 0; col < NUMBER_OF_BOARD_COL; col++)                                     //Method to count white counters
                {
                    
                    if (gameBoardData[row, col] == 1)
                    {
                        WhiteCount = WhiteCount + 1;
                    }
                }
            }

            return WhiteCount;
        }


        private void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveGame();
            ResetGameBoard();                                                                           //Method for when the save game button is clicked it will save the game
            gameInProgress = false;
        }

        

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            About About = new About();                                                                  //Method for the about button when clicked it will bring up the about window
            About.Show();
        }

        private void InformationBox_Click(object sender, EventArgs e)
        {
            if (InformationBox.Checked)
            {
                
                lbl_WhiteCount.Visible = true;
                lbl_BlackCount.Visible = true;
                ptc_BlackCounter.Visible = true;
                ptc_WhiteCounter.Visible = true;
                p1Name.Visible = true;
                p2Name.Visible = true;
                p1Turn.Visible = true;
                p2Turn.Visible = true; 
                ptc_bar.Visible = true;

            }                                                                                                //Method for when the information box is checked or not, will visualise or remove the informaton panel
            else if (!InformationBox.Checked)
            {
                
                lbl_WhiteCount.Visible = false;
                lbl_BlackCount.Visible = false;
                ptc_BlackCounter.Visible = false;
                ptc_WhiteCounter.Visible = false;
                p1Name.Visible = false;
                p2Name.Visible = false;
                p1Turn.Visible = false;
                p2Turn.Visible = false;
                ptc_bar.Visible = false;
            }
            
                
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gameInProgress == true)
            {
                SaveGame();
                this.Close();
            }                                                                               //Method for when the exit button is clicked, if there is a game it can be saved before the game closed, if theres
            else                                                                            //no game it close
            {
                this.Close();
            }
        }
    }

        
}

    