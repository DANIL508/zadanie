using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        string user_figure;
        string comp_figure;
        int score_wins = 0;
        int score_lose = 0;
        int score_draw = 0;
        string mode = "show";

        Random rand = new Random();
       
        public Form1()
        {
            InitializeComponent();
            show_score();
            
            
        }
   

        private void start_game()
        {
            if (mode != "game")
            {
                label_messege.Text = "Выбери свою фигуру";
                mode = "game";
            }   
           
        }
        private void show_user_figure(string figure)
        {
            start_game();
            user_pictureBox_kam.Visible = figure == ("kam");
           user_pictureBox_noz.Visible = figure == ("noz");
           user_pictureBox_bum.Visible = figure == ("bum");
            user_figure = figure;
        }

        private void show_comp_figure(string figure)
        {
            comp_pictureBox_kam.Visible = figure == ("kam");
            comp_pictureBox_noz.Visible = figure == ("noz");
            comp_pictureBox_bum.Visible = figure == ("bum");
            comp_figure = figure;
        }



        private void Uzer_panel_kam_MouseEnter(object sender, EventArgs e)
        {
            user_pictureBox_kam.Visible = true;
            user_pictureBox_noz.Visible = false;
            user_pictureBox_bum.Visible = false;
        }

        private void Uzer_panel_noz_MouseEnter(object sender, EventArgs e)
        {
            user_pictureBox_kam.Visible = false;
            user_pictureBox_noz.Visible = true;
            user_pictureBox_bum.Visible = false;
        }

        private void User_panel_bum_MouseEnter(object sender, EventArgs e)
        {
            user_pictureBox_kam.Visible = false;
            user_pictureBox_noz.Visible = false;
            user_pictureBox_bum.Visible = true;
        }

        

        private void Uzer_panel_noz_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SaveFile(label_score.Text, "Итог.txt");
        }

       

        private void PictureBox_noz_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox_bum_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox_kam_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (mode == "game") ;
            use_comp_random_figure();
        }
        private void use_comp_random_figure()
        {
            int f = rand.Next(1, 4);
            if (f == 1) show_comp_figure("kam");
            if (f == 2) show_comp_figure("noz");
            if (f == 3) show_comp_figure("bum");
        }

        void show_score()
        {
            label_score.Text =
                " Победы: " + score_wins.ToString() +
                " Поражения: " + score_lose.ToString() +
                " Ничья: " + score_lose.ToString();
        }

        private void User_pictureBox_kam_MouseClick(object sender, MouseEventArgs e)
        {
            check_result();
        }

        private void User_pictureBox_noz_MouseClick(object sender, MouseEventArgs e)
        {
            check_result();
        }

        private void User_pictureBox_bum_MouseClick(object sender, MouseEventArgs e)
        {
            check_result();
        }

        private void check_result()
        {
            mode = "show";
            int wins = 0;
            int lose = 0;
            int draw = 0;
            if (user_figure == comp_figure)
                draw = 1;
            else
            {
                if (user_figure == "kam")
                    if (comp_figure == "noz")
                        wins = 1;
                    else
                        lose = 1;
                if (user_figure == "noz")
                    if(comp_figure == "bum")
                        wins = 1;
                    else
                        lose = 1;
                if (user_figure == "bum")
                    if (comp_figure == "kam")
                        wins = 1;
                    else
                        lose = 1;
            }
            score_wins += wins;
            score_lose += lose;
            score_draw += draw;
            if (wins > 0)
                label_messege.Text = " Победа! :) ";
            if (lose > 0)
                label_messege.Text = " Поражение! :) ";
            if (draw > 0)
                label_messege.Text = " Ничья! :) ";
            show_score();
        }

        private void Label_messege_Click(object sender, EventArgs e)
        {

        }

        private void оАвтореToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Демаков Данила Дмитриевич " +
                "студент группы ИР-21");
        }

        private void правилаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Ножницы режут бумагу " +
                " Бумага накрывает камень " +
                " Камень затупляет ножницы ");
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        void SaveFile(string chto, string gde)
        {
            if (chto.Count()>1)
            {
                if (File.Exists(gde))
                    File.Create(gde).Close();
                File.WriteAllText(gde, chto);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void label_score_Click(object sender, EventArgs e)
        {

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
