using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Xml.Schema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace SimonSays
{
    public partial class GameScreen : UserControl
    {
        int guess;
        Random randGen = new Random();
        int randNum;
        int delayTime = 300;

        string greenText = "Green\nGreen\nGreen";
        string redText = "Red\nRed\nRed";
        string yellowText = "Yellow\nYellow\nYellow";
        string blueText = "Blue\nBlue\nBlue";
        FontFamily family = new FontFamily("NSimSun");
        int fontStyle = (int)FontStyle.Bold;
        int emSize = 30;
        Point origin = new Point(0, 0);
        StringFormat format = StringFormat.GenericDefault;

        SoundPlayer greenGuess = new SoundPlayer(Properties.Resources.green);
        SoundPlayer redGuess = new SoundPlayer(Properties.Resources.red);
        SoundPlayer yellowGuess = new SoundPlayer(Properties.Resources.yellow);
        SoundPlayer blueGuess = new SoundPlayer(Properties.Resources.blue);
        SoundPlayer gameOver = new SoundPlayer(Properties.Resources.mistake);

        Button[] buttons = new Button[4];
        SoundPlayer[] soundPlayers = new SoundPlayer[4];
        Color[] colour1 = new Color[4];
        Color[] colour2 = new Color[4];

        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            Form1.randomizerList.Clear();

            #region button text
            //Turning the buttons into text
            GraphicsPath greenTextPath = new GraphicsPath();
            GraphicsPath redTextPath = new GraphicsPath();
            GraphicsPath yellowTextPath = new GraphicsPath();
            GraphicsPath blueTextPath = new GraphicsPath();

            greenTextPath.AddString(greenText, family, fontStyle, emSize, origin, format);
            redTextPath.AddString(redText, family, fontStyle, emSize, origin, format);
            yellowTextPath.AddString(yellowText, family, fontStyle, emSize, origin, format);
            blueTextPath.AddString(blueText, family, fontStyle, emSize, origin, format);

            Region green = new Region(greenTextPath);
            Region red = new Region(redTextPath);
            Region yellow = new Region(yellowTextPath);
            Region blue = new Region(blueTextPath);

            greenButton.Region = yellow;
            redButton.Region = green;
            yellowButton.Region = blue;
            blueButton.Region = red;
            #endregion

            #region adding objects into arrays
            buttons[0] = (greenButton);
            buttons[1] = (redButton);
            buttons[2] = (yellowButton);
            buttons[3] = (blueButton);

            soundPlayers[0] = (greenGuess);
            soundPlayers[1] = (redGuess);
            soundPlayers[2] = (yellowGuess);
            soundPlayers[3] = (blueGuess);

            colour1[0] = (Color.Lime);
            colour1[1] = (Color.Red);
            colour1[2] = (Color.LightYellow);
            colour1[3] = (Color.Blue);

            colour2[0] = (Color.ForestGreen);
            colour2[1] = (Color.DarkRed);
            colour2[2] = (Color.Goldenrod);
            colour2[3] = (Color.DarkBlue);
            #endregion

            ComputerTurn();
            Refresh();
            Thread.Sleep(delayTime);
        }

        private void ComputerTurn()
        {
            Thread.Sleep(delayTime);

            #region button text
            randNum = randGen.Next(0, 4);
            Form1.randomizerList.Add(randNum);

            greenButton.Enabled = false;
            redButton.Enabled = false;
            yellowButton.Enabled = false;
            blueButton.Enabled = false;

            //Turning the buttons into text
            GraphicsPath greenTextPath = new GraphicsPath();
            GraphicsPath redTextPath = new GraphicsPath();
            GraphicsPath yellowTextPath = new GraphicsPath();
            GraphicsPath blueTextPath = new GraphicsPath();

            greenTextPath.AddString(greenText, family, fontStyle, emSize, origin, format);
            redTextPath.AddString(redText, family, fontStyle, emSize, origin, format);
            yellowTextPath.AddString(yellowText, family, fontStyle, emSize, origin, format);
            blueTextPath.AddString(blueText, family, fontStyle, emSize, origin, format);

            Region green = new Region(greenTextPath);
            Region red = new Region(redTextPath);
            Region yellow = new Region(yellowTextPath);
            Region blue = new Region(blueTextPath);

            //randomizing the words on each button
            randNum = randGen.Next(1, 4);
            if (randNum == 1)
            {
                greenButton.Region = yellow;
                redButton.Region = green;
                yellowButton.Region = blue;
                blueButton.Region = red;
            }
            if (randNum == 2)
            {
                greenButton.Region = blue;
                redButton.Region = yellow;
                yellowButton.Region = red;
                blueButton.Region = green;
            }
            if (randNum == 3)
            {
                greenButton.Region = red;
                redButton.Region = blue;
                yellowButton.Region = green;
                blueButton.Region = yellow;
            }

            greenButton.Enabled = true;
            redButton.Enabled = true;
            yellowButton.Enabled = true;
            blueButton.Enabled = true;
            #endregion

            //green is 0, red is 1, yellow is 2, blue is 3
            for (int i = 0; i < Form1.randomizerList.Count; i++)
            {
                if (Form1.randomizerList[i] == 0)
                {
                    GameLogic(0);
                }
                else if (Form1.randomizerList[i] == 1)
                {
                    GameLogic(1);
                }
                else if (Form1.randomizerList[i] == 2)
                {
                    GameLogic(2);
                }
                else
                {
                    GameLogic(3);
                }
            }
            guess = 0;
        }

        //button logic upon presses
        private void greenButton_Click(object sender, EventArgs e)
        {
            if (Form1.randomizerList[guess] == 0)
            {
                GameLogic(0);
            }
            else
            {
                GameOver();
            }
            if (Form1.randomizerList.Count == guess)
            {
                ComputerTurn();
            }
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            if (Form1.randomizerList[guess] == 1)
            {
                GameLogic(1);
            }
            else
            {
                GameOver();
            }
            if (Form1.randomizerList.Count == guess)
            {
                ComputerTurn();
            }
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            if (Form1.randomizerList[guess] == 2)
            {
                GameLogic(2);
            }
            else
            {
                GameOver();
            }
            if (Form1.randomizerList.Count == guess)
            {
                ComputerTurn();
            }
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            if (Form1.randomizerList[guess] == 3)
            {
                GameLogic(3);
            }
            else
            {
                GameOver();
            }
            if (Form1.randomizerList.Count == guess)
            {
                ComputerTurn();
            }
        }

        //invisible buttons
        private void greenButton2_Click(object sender, EventArgs e)
        {
            if (Form1.randomizerList[guess] == 0)
            {
                GameLogic(0);
            }
            else
            {
                GameOver();
            }
            if (Form1.randomizerList.Count == guess)
            {
                ComputerTurn();
            }
        }

        private void redButton2_Click(object sender, EventArgs e)
        {
            if (Form1.randomizerList[guess] == 1)
            {
                GameLogic(1);
            }
            else
            {
                GameOver();
            }
            if (Form1.randomizerList.Count == guess)
            {
                ComputerTurn();
            }
        }

        private void yellowButton2_Click(object sender, EventArgs e)
        {
            if (Form1.randomizerList[guess] == 2)
            {
                GameLogic(2);
            }
            else
            {
                GameOver();
            }
            if (Form1.randomizerList.Count == guess)
            {
                ComputerTurn();
            }
        }

        private void blueButton2_Click(object sender, EventArgs e)
        {
            if (Form1.randomizerList[guess] == 3)
            {
                GameLogic(3);
            }
            else
            {
                GameOver();
            }
            if (Form1.randomizerList.Count == guess)
            {
                ComputerTurn();
            }
        }

        //game over method
        public void GameOver()
        {
            gameOver.Play();
            Thread.Sleep(delayTime);

            Form f = this.FindForm();
            f.Controls.Remove(this);
            GameOverScreen go = new GameOverScreen();
            f.Controls.Add(go);
        }

        //runs game logic based on which button is sent
        public void GameLogic(int i)
        {
            Thread.Sleep(delayTime);
            buttons[i].BackColor = colour1[i];
            soundPlayers[i].Play();
            Refresh();
            Thread.Sleep(delayTime);
            buttons[i].BackColor = colour2[i];
            Refresh();
            Thread.Sleep(delayTime);
            guess++;
        }
    }
}