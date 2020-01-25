using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace konoplev_2
{
    public partial class Form1 : Form
    {
        char[,] map;
        int map_h, map_w, cur, playerX = -1, playerY = -1;
        bool started = false;
        char pressed = '0';
        Bitmap fig;
        public Form1()
        {
            InitializeComponent();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (started && this.WindowState != FormWindowState.Minimized)
            {
                cur = (this.Width - 100) / map_w;
                if (cur * map_h >= this.Height - 100) cur = (this.Height - 100) / map_h;
                fig = new Bitmap(this.Width, this.Height);
                Graphics frame;
                var dirt = new TextureBrush(Properties.Resources.dirt);
                var floor = new Bitmap(Properties.Resources.floor);
                var wall = new Bitmap(Properties.Resources.wall);
                var coins = new Bitmap(Properties.Resources.coins);
                var escape = new Bitmap(Properties.Resources.escape);
                var tnt = new Bitmap(Properties.Resources.tnt);
                var player = new Bitmap(Properties.Resources.player);
                frame = Graphics.FromImage(fig);
                frame.FillRectangle(dirt, 0, 0, this.Width, this.Height);
                e.Graphics.DrawImage(fig, 0, 0);
                fig = new Bitmap(cur * map_w, cur * map_h);
                frame = Graphics.FromImage(fig);
                for (int y = 0, i = 0; i < map_h; i++)
                {
                    for (int x = 0, j = 0; j < map_w; j++)
                    {
                        if (map[i, j] == '0') frame.DrawImage(wall, x, y, cur, cur);
                        else if (map[i, j] == '*') frame.DrawImage(tnt, x, y, cur, cur);
                        else if (map[i, j] == '$') frame.DrawImage(coins, x, y, cur, cur);
                        else if (map[i, j] == '?') frame.DrawImage(escape, x, y, cur, cur);
                        else if (map[i, j] == '&') frame.DrawImage(player, x, y, cur, cur);
                        else frame.DrawImage(floor, x, y, cur, cur);
                        x += cur;
                    }
                    y += cur;
                }
                e.Graphics.DrawImage(fig, (this.Width - fig.Width) / 2, (this.Height - fig.Height) / 2);
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            repaint(sender);
        }

        void turn_on_btn()
        {
            coin_btn.Enabled = true;
            lava_btn.Enabled = true;
            wall_btn.Enabled = true;
            plr_btn.Enabled = true;
            exit_btn.Enabled = true;
        }

        void create_arr()
        {
            map = new char[map_h + 2, map_w + 2];
            for (int i = 0; i < map_h; i++)
            {
                for (int j = 0; j < map_w; j++)
                {
                    if ((i == 1 && j != 0 && j != map_w - 1) || (map_h - 2 == i && j != map_w - 1 && j != 0)) map[i, j] = '0';
                    else if ((j == 1 && i != 0 && i != map_h - 1) || (j == map_w - 2 && i != map_h - 1 && i != 0)) map[i, j] = '0';
                    else map[i, j] = ' ';
                }
            }
            turn_on_btn();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (started)
            {
                SaveFileDialog savefile = new SaveFileDialog();
                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    string current_line = "";
                    string[] current_arr = new string[map_h];
                    for (int i = 0; i < map_h; i++)
                    {
                        for (int j = 0; j < map_w; j++)
                        {
                            current_line += map[i, j];
                        }
                        current_arr[i] = current_line;
                        current_line = "";
                    }
                    File.WriteAllLines(savefile.InitialDirectory + savefile.FileName, current_arr);
                }
            }
            else MessageBox.Show("Сперва вы должны создать проект!", "Я запрещаю)0)");
        }

        void repaint(object sender)
        {
            Graphics g = CreateGraphics();
            Rectangle rec = new Rectangle();
            PaintEventArgs es = new PaintEventArgs(g, rec);
            Form1_Paint(sender, es);
        }

        private void create_small_Click(object sender, EventArgs e)
        {
            map_h = 25;
            map_w = 50;
            create_arr();
            started = true;
            repaint(sender);
        }

        private void create_medium_Click(object sender, EventArgs e)
        {
            map_h = 50;
            map_w = 100;
            create_arr();
            started = true;
            repaint(sender);
        }

        private void about_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа была разработана для приложения \"Лабиринт\", " +
                "и её использовние с другими приложениями может привести к подрыву нашей Галактики. " +
                "Автор не несёт никакой ответственности за причинённые неудобства и психологические травмы!    :)", "О программе");
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            map_h = 0;
            map_w = 0;
            OpenFileDialog openfile = new OpenFileDialog();
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                var arr = File.ReadAllLines(openfile.InitialDirectory + openfile.FileName);
                var i = 0; var j = 0;
                foreach (var line in arr)
                {
                    foreach (var el in line)
                    {
                        j++;
                        map_w++;
                    }
                    map_w = j;
                    j = 0;
                    i++;
                    map_h++;
                }
                create_arr();
                i = 0;
                j = 0;
                foreach (var line in arr)
                {
                    foreach (var el in line)
                    {
                        map[i, j] = el;
                        j++;
                    }
                    j = 0;
                    i++;
                }
                started = true;
                repaint(sender);
            }
        }

        private void create_large_Click(object sender, EventArgs e)
        {
            map_h = 100;
            map_w = 200;
            create_arr();
            started = true;
            repaint(sender);
        }

        private void tool_click(object sender, EventArgs e)
        {
            if (started)
            {
                switch ((sender as ToolStripMenuItem).Tag)
                {
                    case "0":
                        pressed = '0';
                        break;
                    case "1":
                        pressed = '*';
                        break;
                    case "2":
                        pressed = '&';
                        break;
                    case "3":
                        pressed = '$';
                        break;
                    case "4":
                        pressed = '?';
                        break;
                }
            }
        }

        void checkPos()
        {
            for (int i = 0; i < map_h; i++)
                for (int j = 0; j < map_w; j++)
                {
                    if (map[i, j] == '&')
                    {
                        playerX = j;
                        playerY = i;
                    }
                }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (started)
                {
                    int cur_plus_x = (this.Width - fig.Width) / 2, cur_plus_y = (this.Height - fig.Height) / 2;
                    if (e.Button == MouseButtons.Right) map[(e.Y - cur_plus_y) / cur, (e.X - cur_plus_x) / cur] = ' ';
                    else if (pressed == '&')
                    {
                        checkPos();
                        map[(e.Y - cur_plus_y) / cur, (e.X - cur_plus_x) / cur] = pressed;
                        if (playerX > -1 || playerY > -1)
                        {
                            map[playerY, playerX] = ' ';
                        }
                    }
                    else map[(e.Y - cur_plus_y) / cur, (e.X - cur_plus_x) / cur] = pressed;
                }
            }
            catch { }
            repaint(sender);
        }
    }
}
