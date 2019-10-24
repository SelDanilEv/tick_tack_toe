using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tick_tack_toe
{
    public partial class Play : Form
    {
        public Play()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }


        private void butstop_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butreset_Click(object sender, EventArgs e)
        {
            int[] value = new int[9];
            int[] score = new int[2];
            for (int i = 0; i < 9; i++)
            {
                ClassPlay.currentValue[i] = value[i] = ClassPlay.startValue[i];
            }
            for (int i = 0; i < 2; i++)
            {
                ClassPlay.currentScore[i] = score[i] = ClassPlay.startScore[i];
            }
            ClassMove.move = false;
            textscorep1.Text = score[0].ToString();
            textscorep2.Text = score[1].ToString();
            textBox1.Text = "1";
            textBox2.Text = "2";
            textBox3.Text = "3";
            textBox4.Text = "4";
            textBox5.Text = "5";
            textBox6.Text = "6";
            textBox7.Text = "7";
            textBox8.Text = "8";
            textBox9.Text = "9";
            textmove.Text = "P1";
            ClassPlay.game = true;
            ClassPlay.toGame = 0;
            ClassPlay.n = 10;
            ClassPlay.restartRights = false;
        }

        private void SetTheScore()
        {
            int[] value = new int[9];
            int[] score = new int[2];
            for (int i = 0; i < 9; i++)
            {
                ClassPlay.currentValue[i] = value[i] = ClassPlay.startValue[i];
            }
            for (int i = 0; i < 2; i++)
            {
                score[i] = ClassPlay.currentScore[i];
            }
            ClassMove.numOfGame = !ClassMove.numOfGame;
            ClassMove.move = ClassMove.numOfGame;
            textscorep1.Text = score[0].ToString();
            textscorep2.Text = score[1].ToString();
            textBox1.Text = "1";
            textBox2.Text = "2";
            textBox3.Text = "3";
            textBox4.Text = "4";
            textBox5.Text = "5";
            textBox6.Text = "6";
            textBox7.Text = "7";
            textBox8.Text = "8";
            textBox9.Text = "9";
            if (ClassMove.move)
                textmove.Text = "P2";
            else
                textmove.Text = "P1";
            ClassPlay.game = true;
            ClassPlay.toGame = 0;
            ClassPlay.n = 10;
            ClassPlay.restartRights = false;
            if (ClassSettings.cbsettings)
            {
                if ((ClassPlay.currentScore[0] == ClassSettings.maxvalue) || (ClassPlay.currentScore[1] == ClassSettings.maxvalue))
                {
                    if (ClassPlay.currentScore[0] == ClassSettings.maxvalue) MessageBox.Show("PLAYER 1 WON");
                    else MessageBox.Show("\tPLAYER 2 WON");
                }
            }
        }



        private void Play_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1':
                    if (ClassPlay.game)
                    {
                        ClassPlay.n = 0;
                        if (ClassPlay.currentValue[ClassPlay.n] == 0)
                        {
                            ClassMove.Invertmove();
                            if (ClassMove.move == true)
                            {
                                textBox1.Text = "O";
                                textmove.Text = "P2";
                                ClassPlay.currentValue[ClassPlay.n] = 1;
                            }
                            else
                            {
                                textBox1.Text = "X";
                                textmove.Text = "P1";
                                ClassPlay.currentValue[ClassPlay.n] = 2;
                            }
                            ClassCheck.CheckForWon();
                            if (ClassPlay.game == false)
                            {
                                ClassPlay.restartRights = true;
                            }
                        }
                    }
                    break;
                case '2':
                    if (ClassPlay.game)
                    {
                        ClassPlay.n = 1;
                        if (ClassPlay.currentValue[ClassPlay.n] == 0)
                        {
                            ClassMove.Invertmove();
                            if (ClassMove.move == true)
                            {
                                textBox2.Text = "O";
                                textmove.Text = "P2";
                                ClassPlay.currentValue[ClassPlay.n] = 1;
                            }
                            else
                            {
                                textBox2.Text = "X";
                                textmove.Text = "P1";
                                ClassPlay.currentValue[ClassPlay.n] = 2;
                            }
                            ClassCheck.CheckForWon();
                            if (ClassPlay.game == false)
                            {
                                ClassPlay.restartRights = true;
                            }
                        }
                    }
                    break;
                case '3':
                    if (ClassPlay.game)
                    {
                        ClassPlay.n = 2;
                        if (ClassPlay.currentValue[ClassPlay.n] == 0)
                        {
                            ClassMove.Invertmove();
                            if (ClassMove.move == true)
                            {
                                textBox3.Text = "O";
                                textmove.Text = "P2";
                                ClassPlay.currentValue[ClassPlay.n] = 1;
                            }
                            else
                            {
                                textBox3.Text = "X";
                                textmove.Text = "P1";
                                ClassPlay.currentValue[ClassPlay.n] = 2;
                            }
                            ClassCheck.CheckForWon();
                            if (ClassPlay.game == false)
                            {
                                ClassPlay.restartRights = true;
                            }
                        }
                    }
                    break;
                case '4':
                    if (ClassPlay.game)
                    {
                        ClassPlay.n = 3;
                        if (ClassPlay.currentValue[ClassPlay.n] == 0)
                        {
                            ClassMove.Invertmove();
                            if (ClassMove.move == true)
                            {
                                textBox4.Text = "O";
                                textmove.Text = "P2";
                                ClassPlay.currentValue[ClassPlay.n] = 1;
                            }
                            else
                            {
                                textBox4.Text = "X";
                                textmove.Text = "P1";
                                ClassPlay.currentValue[ClassPlay.n] = 2;
                            }
                            ClassCheck.CheckForWon();
                            if (ClassPlay.game == false)
                            {
                                ClassPlay.restartRights = true;
                            }
                        }
                    }
                    break;
                case '5':
                    if (ClassPlay.game)
                    {
                        ClassPlay.n = 4;
                        if (ClassPlay.currentValue[ClassPlay.n] == 0)
                        {
                            ClassMove.Invertmove();
                            if (ClassMove.move == true)
                            {
                                textBox5.Text = "O";
                                textmove.Text = "P2";
                                ClassPlay.currentValue[ClassPlay.n] = 1;
                            }
                            else
                            {
                                textBox5.Text = "X";
                                textmove.Text = "P1";
                                ClassPlay.currentValue[ClassPlay.n] = 2;
                            }
                            ClassCheck.CheckForWon();
                            if (ClassPlay.game == false)
                            {
                                ClassPlay.restartRights = true;
                            }
                        }
                    }
                    break;
                case '6':
                    if (ClassPlay.game)
                    {
                        ClassPlay.n = 5;
                        if (ClassPlay.currentValue[ClassPlay.n] == 0)
                        {
                            ClassMove.Invertmove();
                            if (ClassMove.move == true)
                            {
                                textBox6.Text = "O";
                                textmove.Text = "P2";
                                ClassPlay.currentValue[ClassPlay.n] = 1;
                            }
                            else
                            {
                                textBox6.Text = "X";
                                textmove.Text = "P1";
                                ClassPlay.currentValue[ClassPlay.n] = 2;
                            }
                            ClassCheck.CheckForWon();
                            if (ClassPlay.game == false)
                            {
                                ClassPlay.restartRights = true;
                            }
                        }
                    }
                    break;
                case '7':
                    if (ClassPlay.game)
                    {
                        ClassPlay.n = 6;
                        if (ClassPlay.currentValue[ClassPlay.n] == 0)
                        {
                            ClassMove.Invertmove();
                            if (ClassMove.move == true)
                            {
                                textBox7.Text = "O";
                                textmove.Text = "P2";
                                ClassPlay.currentValue[ClassPlay.n] = 1;
                            }
                            else
                            {
                                textBox7.Text = "X";
                                textmove.Text = "P1";
                                ClassPlay.currentValue[ClassPlay.n] = 2;
                            }
                            ClassCheck.CheckForWon();
                            if (ClassPlay.game == false)
                            {
                                ClassPlay.restartRights = true;
                            }
                        }
                    }
                    break;
                case '8':
                    if (ClassPlay.game)
                    {
                        ClassPlay.n = 7;
                        if (ClassPlay.currentValue[ClassPlay.n] == 0)
                        {
                            ClassMove.Invertmove();
                            if (ClassMove.move == true)
                            {
                                textBox8.Text = "O";
                                textmove.Text = "P2";
                                ClassPlay.currentValue[ClassPlay.n] = 1;
                            }
                            else
                            {
                                textBox8.Text = "X";
                                textmove.Text = "P1";
                                ClassPlay.currentValue[ClassPlay.n] = 2;
                            }
                            ClassCheck.CheckForWon();
                            if (ClassPlay.game == false)
                            {
                                ClassPlay.restartRights = true;
                            }
                        }
                    }
                    break;
                case '9':
                    if (ClassPlay.game)
                    {
                        ClassPlay.n = 8;
                        if (ClassPlay.currentValue[ClassPlay.n] == 0)
                        {
                            ClassMove.Invertmove();
                            if (ClassMove.move == true)
                            {
                                textBox9.Text = "O";
                                textmove.Text = "P2";
                                ClassPlay.currentValue[ClassPlay.n] = 1;
                            }
                            else
                            {
                                textBox9.Text = "X";
                                textmove.Text = "P1";
                                ClassPlay.currentValue[ClassPlay.n] = 2;
                            }
                            ClassCheck.CheckForWon();
                            if (ClassPlay.game == false)
                            {
                                ClassPlay.restartRights = true;
                            }
                        }
                    }
                    break;
                case ' ':
                    if (ClassPlay.restartRights) SetTheScore();
                    if (ClassSettings.cbsettings)
                    {
                        if ((ClassPlay.currentScore[0] == ClassSettings.maxvalue) || (ClassPlay.currentScore[1] == ClassSettings.maxvalue))
                        {
                            butreset_Click(sender, e);
                        }
                    }
                    break;
            }
        }

        private void Play_Load(object sender, EventArgs e)
        {
            SendKeys.Send("{tab}");
        }
        //private void Form1_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyData != Keys.L) return;
        //    //чота делаем
        //}
    }
}
