

namespace WindowsFormsApp2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.uzer_panel_kam = new System.Windows.Forms.Panel();
            this.user_pictureBox_kam = new System.Windows.Forms.PictureBox();
            this.uzer_panel_noz = new System.Windows.Forms.Panel();
            this.user_pictureBox_noz = new System.Windows.Forms.PictureBox();
            this.user_panel_bum = new System.Windows.Forms.Panel();
            this.user_pictureBox_bum = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comp_pictureBox_kam = new System.Windows.Forms.PictureBox();
            this.comp_pictureBox_bum = new System.Windows.Forms.PictureBox();
            this.comp_pictureBox_noz = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label_messege = new System.Windows.Forms.Label();
            this.label_comp = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правилаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оАвтореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.uzer_panel_kam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_pictureBox_kam)).BeginInit();
            this.uzer_panel_noz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_pictureBox_noz)).BeginInit();
            this.user_panel_bum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_pictureBox_bum)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comp_pictureBox_kam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp_pictureBox_bum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp_pictureBox_noz)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uzer_panel_kam
            // 
            this.uzer_panel_kam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uzer_panel_kam.Controls.Add(this.user_pictureBox_kam);
            this.uzer_panel_kam.Location = new System.Drawing.Point(57, 100);
            this.uzer_panel_kam.Name = "uzer_panel_kam";
            this.uzer_panel_kam.Size = new System.Drawing.Size(120, 120);
            this.uzer_panel_kam.TabIndex = 0;
            this.uzer_panel_kam.MouseEnter += new System.EventHandler(this.Uzer_panel_kam_MouseEnter);
            // 
            // user_pictureBox_kam
            // 
            this.user_pictureBox_kam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.user_pictureBox_kam.Image = ((System.Drawing.Image)(resources.GetObject("user_pictureBox_kam.Image")));
            this.user_pictureBox_kam.Location = new System.Drawing.Point(0, 0);
            this.user_pictureBox_kam.Name = "user_pictureBox_kam";
            this.user_pictureBox_kam.Size = new System.Drawing.Size(118, 118);
            this.user_pictureBox_kam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.user_pictureBox_kam.TabIndex = 2;
            this.user_pictureBox_kam.TabStop = false;
            this.user_pictureBox_kam.Visible = false;
            this.user_pictureBox_kam.Click += new System.EventHandler(this.PictureBox_kam_Click);
            this.user_pictureBox_kam.MouseClick += new System.Windows.Forms.MouseEventHandler(this.User_pictureBox_kam_MouseClick);
            // 
            // uzer_panel_noz
            // 
            this.uzer_panel_noz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uzer_panel_noz.Controls.Add(this.user_pictureBox_noz);
            this.uzer_panel_noz.Location = new System.Drawing.Point(212, 100);
            this.uzer_panel_noz.Name = "uzer_panel_noz";
            this.uzer_panel_noz.Size = new System.Drawing.Size(120, 120);
            this.uzer_panel_noz.TabIndex = 1;
            this.uzer_panel_noz.Paint += new System.Windows.Forms.PaintEventHandler(this.Uzer_panel_noz_Paint);
            this.uzer_panel_noz.MouseEnter += new System.EventHandler(this.Uzer_panel_noz_MouseEnter);
            // 
            // user_pictureBox_noz
            // 
            this.user_pictureBox_noz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.user_pictureBox_noz.Image = ((System.Drawing.Image)(resources.GetObject("user_pictureBox_noz.Image")));
            this.user_pictureBox_noz.Location = new System.Drawing.Point(0, 0);
            this.user_pictureBox_noz.Name = "user_pictureBox_noz";
            this.user_pictureBox_noz.Size = new System.Drawing.Size(118, 118);
            this.user_pictureBox_noz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.user_pictureBox_noz.TabIndex = 4;
            this.user_pictureBox_noz.TabStop = false;
            this.user_pictureBox_noz.Visible = false;
            this.user_pictureBox_noz.Click += new System.EventHandler(this.PictureBox_noz_Click);
            this.user_pictureBox_noz.MouseClick += new System.Windows.Forms.MouseEventHandler(this.User_pictureBox_noz_MouseClick);
            // 
            // user_panel_bum
            // 
            this.user_panel_bum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_panel_bum.Controls.Add(this.user_pictureBox_bum);
            this.user_panel_bum.Location = new System.Drawing.Point(365, 100);
            this.user_panel_bum.Name = "user_panel_bum";
            this.user_panel_bum.Size = new System.Drawing.Size(120, 120);
            this.user_panel_bum.TabIndex = 1;
            this.user_panel_bum.MouseEnter += new System.EventHandler(this.User_panel_bum_MouseEnter);
            // 
            // user_pictureBox_bum
            // 
            this.user_pictureBox_bum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.user_pictureBox_bum.Image = ((System.Drawing.Image)(resources.GetObject("user_pictureBox_bum.Image")));
            this.user_pictureBox_bum.Location = new System.Drawing.Point(0, 0);
            this.user_pictureBox_bum.Name = "user_pictureBox_bum";
            this.user_pictureBox_bum.Size = new System.Drawing.Size(118, 118);
            this.user_pictureBox_bum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.user_pictureBox_bum.TabIndex = 3;
            this.user_pictureBox_bum.TabStop = false;
            this.user_pictureBox_bum.Visible = false;
            this.user_pictureBox_bum.Click += new System.EventHandler(this.PictureBox_bum_Click);
            this.user_pictureBox_bum.MouseClick += new System.Windows.Forms.MouseEventHandler(this.User_pictureBox_bum_MouseClick);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.comp_pictureBox_kam);
            this.panel4.Controls.Add(this.comp_pictureBox_bum);
            this.panel4.Controls.Add(this.comp_pictureBox_noz);
            this.panel4.Location = new System.Drawing.Point(614, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(120, 120);
            this.panel4.TabIndex = 1;
            // 
            // comp_pictureBox_kam
            // 
            this.comp_pictureBox_kam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comp_pictureBox_kam.Image = ((System.Drawing.Image)(resources.GetObject("comp_pictureBox_kam.Image")));
            this.comp_pictureBox_kam.Location = new System.Drawing.Point(0, 0);
            this.comp_pictureBox_kam.Name = "comp_pictureBox_kam";
            this.comp_pictureBox_kam.Size = new System.Drawing.Size(118, 118);
            this.comp_pictureBox_kam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.comp_pictureBox_kam.TabIndex = 3;
            this.comp_pictureBox_kam.TabStop = false;
            this.comp_pictureBox_kam.Visible = false;
            // 
            // comp_pictureBox_bum
            // 
            this.comp_pictureBox_bum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comp_pictureBox_bum.Image = ((System.Drawing.Image)(resources.GetObject("comp_pictureBox_bum.Image")));
            this.comp_pictureBox_bum.Location = new System.Drawing.Point(0, 0);
            this.comp_pictureBox_bum.Name = "comp_pictureBox_bum";
            this.comp_pictureBox_bum.Size = new System.Drawing.Size(118, 118);
            this.comp_pictureBox_bum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.comp_pictureBox_bum.TabIndex = 4;
            this.comp_pictureBox_bum.TabStop = false;
            this.comp_pictureBox_bum.Visible = false;
            // 
            // comp_pictureBox_noz
            // 
            this.comp_pictureBox_noz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comp_pictureBox_noz.Image = ((System.Drawing.Image)(resources.GetObject("comp_pictureBox_noz.Image")));
            this.comp_pictureBox_noz.Location = new System.Drawing.Point(0, 0);
            this.comp_pictureBox_noz.Name = "comp_pictureBox_noz";
            this.comp_pictureBox_noz.Size = new System.Drawing.Size(118, 118);
            this.comp_pictureBox_noz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.comp_pictureBox_noz.TabIndex = 2;
            this.comp_pictureBox_noz.TabStop = false;
            this.comp_pictureBox_noz.Visible = false;
            this.comp_pictureBox_noz.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 300;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // label_messege
            // 
            this.label_messege.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_messege.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_messege.Location = new System.Drawing.Point(58, 34);
            this.label_messege.Name = "label_messege";
            this.label_messege.Size = new System.Drawing.Size(426, 33);
            this.label_messege.TabIndex = 2;
            this.label_messege.Text = "Выбери свою фигуру";
            this.label_messege.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_messege.Click += new System.EventHandler(this.Label_messege_Click);
            // 
            // label_comp
            // 
            this.label_comp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_comp.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_comp.Location = new System.Drawing.Point(615, 34);
            this.label_comp.Name = "label_comp";
            this.label_comp.Size = new System.Drawing.Size(118, 43);
            this.label_comp.TabIndex = 3;
            this.label_comp.Text = "Компьютер";
            this.label_comp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_score
            // 
            this.label_score.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_score.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_score.Location = new System.Drawing.Point(58, 264);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(676, 39);
            this.label_score.TabIndex = 4;
            this.label_score.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_score.Click += new System.EventHandler(this.label_score_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правилаToolStripMenuItem,
            this.оАвтореToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.закрытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // правилаToolStripMenuItem
            // 
            this.правилаToolStripMenuItem.Name = "правилаToolStripMenuItem";
            this.правилаToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.правилаToolStripMenuItem.Text = "Правила";
            this.правилаToolStripMenuItem.Click += new System.EventHandler(this.правилаToolStripMenuItem_Click);
            // 
            // оАвтореToolStripMenuItem
            // 
            this.оАвтореToolStripMenuItem.Name = "оАвтореToolStripMenuItem";
            this.оАвтореToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.оАвтореToolStripMenuItem.Text = "О авторе";
            this.оАвтореToolStripMenuItem.Click += new System.EventHandler(this.оАвтореToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label_comp);
            this.Controls.Add(this.label_messege);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.user_panel_bum);
            this.Controls.Add(this.uzer_panel_noz);
            this.Controls.Add(this.uzer_panel_kam);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Камень-Ножницы-Буммага";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.uzer_panel_kam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.user_pictureBox_kam)).EndInit();
            this.uzer_panel_noz.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.user_pictureBox_noz)).EndInit();
            this.user_panel_bum.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.user_pictureBox_bum)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comp_pictureBox_kam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp_pictureBox_bum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp_pictureBox_noz)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel uzer_panel_kam;
        private System.Windows.Forms.Panel uzer_panel_noz;
        private System.Windows.Forms.Panel user_panel_bum;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox user_pictureBox_kam;
        private System.Windows.Forms.PictureBox user_pictureBox_bum;
        private System.Windows.Forms.PictureBox user_pictureBox_noz;
        private System.Windows.Forms.PictureBox comp_pictureBox_noz;
        private System.Windows.Forms.PictureBox comp_pictureBox_kam;
        private System.Windows.Forms.PictureBox comp_pictureBox_bum;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label_messege;
        private System.Windows.Forms.Label label_comp;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правилаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оАвтореToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

