using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CookieMonster
{
    public partial class Form1 : Form
    {
        private Playground pg;

        public Form1()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            PbPlayground.ClientSize = new Size(1000, 550);
            PbPlayground.BackColor = Color.Yellow;
            LblNrOfMoves.Text = "no moves yet";
            pg = new Playground();
        }

        private void StartLevel(int i)
        {
            Graphics graphics = CreateGraphics();
            pg = new Playground();
            string filename = @"..\..\..\levels\level" + Convert.ToString(i) + ".txt";
            pg.StartLevelFromFile(filename);
            PbPlayground.Refresh();
            LblNrOfMoves.Text = "no moves yet";
        }
        private void BtnLevel1_Click(object sender, EventArgs e)
        {
            StartLevel(1);
        }

        private void BtnLevel2_Click(object sender, EventArgs e)
        {
            StartLevel(2);
            //BERT: level 2 can be played in 6 moves.
            //BERT: The total nr of cookies is 3 (mod 4).
            //BERT: If you click an outer plate the total nr of cookies stays the same (mod 4).
            //BERT: if you click the middle plate, the nr of cookies becomes 1 less (mod 4).
        }

        private void BtnLevel3_Click(object sender, EventArgs e)
        {
            StartLevel(3);
            //BERT: level 3 seems difficult, but if you change the coordinates a bit, you see all plates
            //BERT: on a single line: A - G - F - C - ...
        }

        private void BtnLevel4_Click(object sender, EventArgs e)
        {
            StartLevel(4);
        }

        private void PbPlayground_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            PbPlayground.BackColor = Color.Yellow;
            pg.DrawAllLines(gr);
            pg.DrawAllPlates(gr, ImageList);
            LblNrOfMoves.Text = pg.NrOfMoves != 0 ? pg.NrOfMoves.ToString() : "no moves yet";
        }

        private void PbPlayground_MouseUp(object sender, MouseEventArgs e)
        {
            Plate plate = pg.GetPlate(e.X, e.Y);
            if (plate != null)
            {
                plate.AddCookie();
                foreach (Plate item in plate.Neighbors)
                    item.AddCookie();
                pg.IncrementNrOfMoves();
                PbPlayground.Invalidate();
                if (pg.CheckWin())
                    MessageBox.Show("Yay you won!");
            }
        }
    }
}
