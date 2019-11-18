using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_71
{
    public partial class Form1 : Form
    {
        Random random = new Random();        

        public Form1()
        {
            InitializeComponent();
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            btnReset.Text = "Сброс";
            lblNumber.Text = "0";
            this.Text = "Удвоитель";            
        }

        int count = 0;
        int c = 0;
        int n = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            StartGame();            
        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            count++;
            label1.Text = count.ToString();
            Answer();
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            count++;
            label1.Text = count.ToString();
            Answer();
        }

        private void btnCommand3_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "0";
            count++;
            label1.Text = count.ToString();
            Answer();
        }

        private void lblNumber_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        public void Start_Click(object sender, EventArgs e)
        {            
            StartGame();               
        }

        public void StartGame()
        {
            int number = random.Next(5, 100);
            n = number;
            c = 0;
            while (n > 0)
            {
                if (n % 2 == 0)
                {
                    n = n / 2;
                    c++;
                }
                else
                {
                    n -= 1;
                    c++;
                }
            }
            MessageBox.Show($"Получите число {number} за {c} ходов", "Играть", MessageBoxButtons.OK);
            if (count != 0) count = 0;
            label1.Text = count.ToString();
            lblNumber.Text = 0.ToString();            
        }
        public void Answer()
        {            
            if (count >= c && lblNumber.Text != n.ToString())
            {                
                if (MessageBox.Show("Количество ходов закончилось\nПопробуете еще раз?", "Игра окончена", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    StartGame();
                }
                else
                {
                    Close();
                }
            }
            else if (lblNumber.Text == n.ToString())
            {                
                if (MessageBox.Show("Поздравляем! Вы победили\nПопробуете еще раз?", "Вы победили!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    StartGame();
                }
                else
                {
                    Close();
                }
            }
        }
    }
}
