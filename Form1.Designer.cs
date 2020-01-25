namespace konoplev_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.create = new System.Windows.Forms.ToolStripMenuItem();
            this.create_small = new System.Windows.Forms.ToolStripMenuItem();
            this.create_medium = new System.Windows.Forms.ToolStripMenuItem();
            this.create_large = new System.Windows.Forms.ToolStripMenuItem();
            this.save = new System.Windows.Forms.ToolStripMenuItem();
            this.quit = new System.Windows.Forms.ToolStripMenuItem();
            this.wall_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.lava_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.plr_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.coin_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.about_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.wall_btn,
            this.lava_btn,
            this.plr_btn,
            this.coin_btn,
            this.exit_btn,
            this.about_btn});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.create,
            this.save,
            this.открытьToolStripMenuItem,
            this.quit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // create
            // 
            this.create.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.create_small,
            this.create_medium,
            this.create_large});
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(224, 26);
            this.create.Text = "Создать";
            // 
            // create_small
            // 
            this.create_small.Name = "create_small";
            this.create_small.Size = new System.Drawing.Size(207, 26);
            this.create_small.Text = "Малый 50x25";
            this.create_small.Click += new System.EventHandler(this.create_small_Click);
            // 
            // create_medium
            // 
            this.create_medium.Name = "create_medium";
            this.create_medium.Size = new System.Drawing.Size(207, 26);
            this.create_medium.Text = "Средний 100x50";
            this.create_medium.Click += new System.EventHandler(this.create_medium_Click);
            // 
            // create_large
            // 
            this.create_large.Name = "create_large";
            this.create_large.Size = new System.Drawing.Size(207, 26);
            this.create_large.Text = "Большой 200x50";
            this.create_large.Click += new System.EventHandler(this.create_large_Click);
            // 
            // save
            // 
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(224, 26);
            this.save.Text = "Сохранить как";
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // quit
            // 
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(224, 26);
            this.quit.Text = "Выйти";
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // wall_btn
            // 
            this.wall_btn.Enabled = false;
            this.wall_btn.Image = global::konoplev_2.Properties.Resources.wall;
            this.wall_btn.Name = "wall_btn";
            this.wall_btn.Size = new System.Drawing.Size(83, 24);
            this.wall_btn.Tag = "0";
            this.wall_btn.Text = "Стена";
            this.wall_btn.Click += new System.EventHandler(this.tool_click);
            // 
            // lava_btn
            // 
            this.lava_btn.Enabled = false;
            this.lava_btn.Image = global::konoplev_2.Properties.Resources.tnt;
            this.lava_btn.Name = "lava_btn";
            this.lava_btn.Size = new System.Drawing.Size(77, 24);
            this.lava_btn.Tag = "1";
            this.lava_btn.Text = "Лава";
            this.lava_btn.Click += new System.EventHandler(this.tool_click);
            // 
            // plr_btn
            // 
            this.plr_btn.Enabled = false;
            this.plr_btn.Image = global::konoplev_2.Properties.Resources.player_ico;
            this.plr_btn.Name = "plr_btn";
            this.plr_btn.Size = new System.Drawing.Size(85, 24);
            this.plr_btn.Tag = "2";
            this.plr_btn.Text = "Игрок";
            this.plr_btn.Click += new System.EventHandler(this.tool_click);
            // 
            // coin_btn
            // 
            this.coin_btn.Enabled = false;
            this.coin_btn.Image = global::konoplev_2.Properties.Resources.coin_ico;
            this.coin_btn.Name = "coin_btn";
            this.coin_btn.Size = new System.Drawing.Size(103, 24);
            this.coin_btn.Tag = "3";
            this.coin_btn.Text = "Монетка";
            this.coin_btn.Click += new System.EventHandler(this.tool_click);
            // 
            // exit_btn
            // 
            this.exit_btn.Enabled = false;
            this.exit_btn.Image = global::konoplev_2.Properties.Resources.escape;
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(186, 24);
            this.exit_btn.Tag = "4";
            this.exit_btn.Text = "Выход из лабиринта";
            this.exit_btn.Click += new System.EventHandler(this.tool_click);
            // 
            // about_btn
            // 
            this.about_btn.Name = "about_btn";
            this.about_btn.Size = new System.Drawing.Size(118, 24);
            this.about_btn.Text = "О программе";
            this.about_btn.Click += new System.EventHandler(this.about_btn_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(327, 297);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактор карт 2049";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem create;
        private System.Windows.Forms.ToolStripMenuItem create_small;
        private System.Windows.Forms.ToolStripMenuItem create_medium;
        private System.Windows.Forms.ToolStripMenuItem create_large;
        private System.Windows.Forms.ToolStripMenuItem quit;
        private System.Windows.Forms.ToolStripMenuItem save;
        private System.Windows.Forms.ToolStripMenuItem wall_btn;
        private System.Windows.Forms.ToolStripMenuItem lava_btn;
        private System.Windows.Forms.ToolStripMenuItem plr_btn;
        private System.Windows.Forms.ToolStripMenuItem exit_btn;
        private System.Windows.Forms.ToolStripMenuItem about_btn;
        private System.Windows.Forms.ToolStripMenuItem coin_btn;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
    }
}

