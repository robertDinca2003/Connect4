using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics g;

        int[,] connect = new int[7,6];

        int currentTurn ;

        bool gameEnd = true ;

        int total;

        void win()
        {
            if (total != 46)
                lblCurrentTurn.Text = "Player " + currentTurn.ToString() + " won!";
            else
                lblCurrentTurn.Text = "Draw!";
            gameEnd = true;
        }

        void verif()
        {
            if (total == 48) {win(); return; }
            bool winner;
            for(int i = 0; i < 6; i++)
                for(int j = 5; j >= 0; j--)
                {
                    winner = true;
                    //MessageBox.Show(i.ToString() + "  " + j.ToString());
                    for (int k = 0; k <= 3; k++)
                         if (i+k > 6 ||connect[i + k, j] != currentTurn ) winner = false;
                    if (winner) { win(); return; }

                    winner = true;

                    for (int k = 0; k <= 3; k++)
                        if (j + k > 5 || connect[i, j + k] != currentTurn) winner = false;
                    if(winner) { win(); return; }

                    winner = true;

                    for (int k = 0; k <= 3; k++)
                        if (j + k > 5 || i+k>6|| connect[i+k, j + k] != currentTurn) winner = false;
                    if (winner) { win(); return; }

                    winner = true;

                    for (int k = 0; k <= 3; k++)
                        if (j - k < 0 || i + k > 6 || connect[i + k, j - k] != currentTurn) winner = false;
                    if (winner) { win(); return; }
                }
        }

        void MakeMove(int x ,int y)
        {
            
            if (x < 0 || y < 0 ) return;
            x = x / 70;
            y = y / 70; 
            if (x > 6) return;
            //MessageBox.Show(x.ToString() + "  " + y.ToString());
            for (y = 5; y >= 0; y--) if (connect[x, y] == 0) break;
            if (y < 0) return;
            connect[x, y] = currentTurn;
           // MessageBox.Show(connect[x,y].ToString() );
            if (currentTurn == 1)
                g.FillEllipse(new SolidBrush(Color.Red), 100 + x * 70, 200 + y * 70, 60, 60);
            else
                g.FillEllipse(new SolidBrush(Color.Yellow), 100 + x * 70, 200 + y * 70, 60, 60);
            verif();
            if (gameEnd) return;
            if (currentTurn == 1) currentTurn = 2;
            else currentTurn = 1;
            lblCurrentTurn.Text = "Current Turn: " + currentTurn.ToString();
            total++;

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            gameEnd = false;

            btn_exit.Visible = false;
            btn_exit.Enabled = false;

            btn_play.Enabled = false;
            btn_play.Visible = false;

            btn_back.Visible = true;
            btn_back.Enabled = true;

            lblCurrentTurn.Visible = true;

            total = 0;

            for (int i = 0; i <= 6; i++)
                for (int j = 0; j <= 5; j++)
                    connect[i, j] = 0;

            g = panelGame.CreateGraphics();

            g.FillRectangle(new SolidBrush(Color.SteelBlue), 70, 170, 540, 460);
            for(int i = 0; i < 6; i++ )
                for(int j = 0; j < 7; j++)
                {
                    g.FillEllipse(new SolidBrush(Color.PapayaWhip), 100 + j * 70, 200 + i * 70, 60, 60);
                }
            currentTurn = 1;
            lblCurrentTurn.Text = "Current Turn: " + currentTurn.ToString();
        }

        private void panelGame_MouseClick(object sender, MouseEventArgs e)
        {
            if (gameEnd) return;
            int x = e.X- 100;
            int y = e.Y - 200;
            MakeMove(x, y);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            gameEnd = true;

            g.Clear(Color.PapayaWhip);

            for (int i = 0; i <= 6; i++)
                for (int j = 0; j <= 5; j++)
                    connect[i, j] = 0;

            lblCurrentTurn.Visible = false;

            btn_exit.Visible = true;
            btn_exit.Enabled = true;

            btn_play.Enabled = true;
            btn_play.Visible = true;

            btn_back.Visible = false;
            btn_back.Enabled = false;

            
        }
    }
}
