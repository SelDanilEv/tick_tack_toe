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
    public partial class Menu1 : Form
    {
        Play play = new Play();
        Settings settings = new Settings();
        public Menu1()
        {
            InitializeComponent();
        }

        private void but_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_start_Click(object sender, EventArgs e)
        {
            play.ShowDialog();
        }

        private void butsettings_Click(object sender, EventArgs e)
        {
            settings.ShowDialog();
        }

        private void howToPlay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Справка\n" +
                "Игрок 1(P1)-НОЛИК  Игрок 2(P2)-Крестик\n" +
                "Право на первый ход меняется скаждой новой игрой\n" +
                "Для выбора ячейки нажмите соответсвующую клавишу\n" +
                "После факта выигрыша одного из игроков нажмите ПРОБЕЛ\n" +
                "В настройках можно поставить лимит побед\n" +
                "\n");
        }
       
    }
}
