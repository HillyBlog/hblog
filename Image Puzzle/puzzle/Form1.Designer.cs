namespace WindowsFormsApplication1
{
    partial class frmPuzzleGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPuzzleGame));
            this.gbPuzzleBox = new System.Windows.Forms.GroupBox();
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.pbx2 = new System.Windows.Forms.PictureBox();
            this.pbx3 = new System.Windows.Forms.PictureBox();
            this.pbx4 = new System.Windows.Forms.PictureBox();
            this.pbx5 = new System.Windows.Forms.PictureBox();
            this.pbx6 = new System.Windows.Forms.PictureBox();
            this.pbx7 = new System.Windows.Forms.PictureBox();
            this.pbx8 = new System.Windows.Forms.PictureBox();
            this.pbx9 = new System.Windows.Forms.PictureBox();
            this.gbOriginal = new System.Windows.Forms.GroupBox();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblMovesMade = new System.Windows.Forms.Label();
            this.lblTimeElapsed = new System.Windows.Forms.Label();
            this.tmrTimeElapse = new System.Windows.Forms.Timer(this.components);
            this.btnPause = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caraBermainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tentangGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tentang = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.gbPuzzleBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx9)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tentang.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPuzzleBox
            // 
            this.gbPuzzleBox.Controls.Add(this.pbx1);
            this.gbPuzzleBox.Controls.Add(this.pbx2);
            this.gbPuzzleBox.Controls.Add(this.pbx3);
            this.gbPuzzleBox.Controls.Add(this.pbx4);
            this.gbPuzzleBox.Controls.Add(this.pbx5);
            this.gbPuzzleBox.Controls.Add(this.pbx6);
            this.gbPuzzleBox.Controls.Add(this.pbx7);
            this.gbPuzzleBox.Controls.Add(this.pbx8);
            this.gbPuzzleBox.Controls.Add(this.pbx9);
            this.gbPuzzleBox.Location = new System.Drawing.Point(10, 65);
            this.gbPuzzleBox.Name = "gbPuzzleBox";
            this.gbPuzzleBox.Size = new System.Drawing.Size(325, 310);
            this.gbPuzzleBox.TabIndex = 0;
            this.gbPuzzleBox.TabStop = false;
            this.gbPuzzleBox.Text = "Puzzle";
            // 
            // pbx1
            // 
            this.pbx1.Location = new System.Drawing.Point(17, 23);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(97, 89);
            this.pbx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx1.TabIndex = 0;
            this.pbx1.TabStop = false;
            this.pbx1.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx2
            // 
            this.pbx2.Location = new System.Drawing.Point(114, 23);
            this.pbx2.Name = "pbx2";
            this.pbx2.Size = new System.Drawing.Size(97, 89);
            this.pbx2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx2.TabIndex = 0;
            this.pbx2.TabStop = false;
            this.pbx2.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx3
            // 
            this.pbx3.Location = new System.Drawing.Point(211, 23);
            this.pbx3.Name = "pbx3";
            this.pbx3.Size = new System.Drawing.Size(97, 89);
            this.pbx3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx3.TabIndex = 0;
            this.pbx3.TabStop = false;
            this.pbx3.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx4
            // 
            this.pbx4.Location = new System.Drawing.Point(17, 112);
            this.pbx4.Name = "pbx4";
            this.pbx4.Size = new System.Drawing.Size(97, 89);
            this.pbx4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx4.TabIndex = 0;
            this.pbx4.TabStop = false;
            this.pbx4.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx5
            // 
            this.pbx5.Location = new System.Drawing.Point(114, 112);
            this.pbx5.Name = "pbx5";
            this.pbx5.Size = new System.Drawing.Size(97, 89);
            this.pbx5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx5.TabIndex = 0;
            this.pbx5.TabStop = false;
            this.pbx5.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx6
            // 
            this.pbx6.Location = new System.Drawing.Point(211, 112);
            this.pbx6.Name = "pbx6";
            this.pbx6.Size = new System.Drawing.Size(97, 89);
            this.pbx6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx6.TabIndex = 0;
            this.pbx6.TabStop = false;
            this.pbx6.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx7
            // 
            this.pbx7.Location = new System.Drawing.Point(17, 201);
            this.pbx7.Name = "pbx7";
            this.pbx7.Size = new System.Drawing.Size(97, 89);
            this.pbx7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx7.TabIndex = 0;
            this.pbx7.TabStop = false;
            this.pbx7.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx8
            // 
            this.pbx8.Location = new System.Drawing.Point(114, 201);
            this.pbx8.Name = "pbx8";
            this.pbx8.Size = new System.Drawing.Size(97, 89);
            this.pbx8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx8.TabIndex = 0;
            this.pbx8.TabStop = false;
            this.pbx8.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx9
            // 
            this.pbx9.Location = new System.Drawing.Point(211, 201);
            this.pbx9.Name = "pbx9";
            this.pbx9.Size = new System.Drawing.Size(97, 89);
            this.pbx9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx9.TabIndex = 0;
            this.pbx9.TabStop = false;
            this.pbx9.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // gbOriginal
            // 
            this.gbOriginal.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.original;
            this.gbOriginal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbOriginal.Location = new System.Drawing.Point(82, 19);
            this.gbOriginal.Name = "gbOriginal";
            this.gbOriginal.Size = new System.Drawing.Size(173, 145);
            this.gbOriginal.TabIndex = 0;
            this.gbOriginal.TabStop = false;
            // 
            // btnShuffle
            // 
            this.btnShuffle.BackColor = System.Drawing.Color.White;
            this.btnShuffle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnShuffle.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShuffle.Location = new System.Drawing.Point(27, 361);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(86, 42);
            this.btnShuffle.TabIndex = 1;
            this.btnShuffle.Text = "Ulang";
            this.btnShuffle.UseVisualStyleBackColor = false;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.White;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnQuit.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(232, 361);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(86, 42);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.Text = "Udahan";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblMovesMade
            // 
            this.lblMovesMade.AutoSize = true;
            this.lblMovesMade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovesMade.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMovesMade.Location = new System.Drawing.Point(13, 421);
            this.lblMovesMade.Name = "lblMovesMade";
            this.lblMovesMade.Size = new System.Drawing.Size(135, 19);
            this.lblMovesMade.TabIndex = 2;
            this.lblMovesMade.Text = "Banyaknya klik :";
            // 
            // lblTimeElapsed
            // 
            this.lblTimeElapsed.AutoSize = true;
            this.lblTimeElapsed.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeElapsed.Location = new System.Drawing.Point(2, 17);
            this.lblTimeElapsed.Name = "lblTimeElapsed";
            this.lblTimeElapsed.Size = new System.Drawing.Size(160, 45);
            this.lblTimeElapsed.TabIndex = 3;
            this.lblTimeElapsed.Text = "00:00:00";
            // 
            // tmrTimeElapse
            // 
            this.tmrTimeElapse.Enabled = true;
            this.tmrTimeElapse.Interval = 900;
            this.tmrTimeElapse.Tick += new System.EventHandler(this.UpdateTimeElapsed);
            // 
            // btnPause
            // 
            this.btnPause.Enabled = false;
            this.btnPause.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(127, 361);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(86, 42);
            this.btnPause.TabIndex = 4;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.PauseOrResume);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.caraBermainToolStripMenuItem,
            this.tentangGameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(368, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.mainToolStripMenuItem.Text = "Main";
            this.mainToolStripMenuItem.Click += new System.EventHandler(this.mainToolStripMenuItem_Click);
            // 
            // caraBermainToolStripMenuItem
            // 
            this.caraBermainToolStripMenuItem.Name = "caraBermainToolStripMenuItem";
            this.caraBermainToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.caraBermainToolStripMenuItem.Text = "Bantuan";
            this.caraBermainToolStripMenuItem.Click += new System.EventHandler(this.caraBermainToolStripMenuItem_Click);
            // 
            // tentangGameToolStripMenuItem
            // 
            this.tentangGameToolStripMenuItem.Name = "tentangGameToolStripMenuItem";
            this.tentangGameToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.tentangGameToolStripMenuItem.Text = "Tentang Game";
            this.tentangGameToolStripMenuItem.Click += new System.EventHandler(this.tentangGameToolStripMenuItem_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.gbOriginal);
            this.panel3.Location = new System.Drawing.Point(20, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(338, 450);
            this.panel3.TabIndex = 6;
            this.panel3.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(16, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 212);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "dan mengacak gambar kembali";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "agar tidak berjalan";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(226, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "memindahkan gambar ketempat kosong/hitam";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(229, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "\"Banyaknya klik\" menghitung berapa kali anda";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(273, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tombol \"Udahan\" berfungsi untuk keluar dari permainan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tombol \"Pause\" berfungsi untuk menjeda timer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(276, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tombol \"Ulang\" berfungsi untuk mereset timer permainan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "sehingga tersusun menjadi seperti gambar diatas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Klik gambar untuk memindahkannya ketempat yang kosong";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "CARA BERMAIN";
            // 
            // tentang
            // 
            this.tentang.Controls.Add(this.label26);
            this.tentang.Controls.Add(this.label25);
            this.tentang.Controls.Add(this.label16);
            this.tentang.Controls.Add(this.label24);
            this.tentang.Controls.Add(this.label15);
            this.tentang.Controls.Add(this.label20);
            this.tentang.Controls.Add(this.label21);
            this.tentang.Controls.Add(this.label19);
            this.tentang.Controls.Add(this.label22);
            this.tentang.Controls.Add(this.label18);
            this.tentang.Controls.Add(this.label17);
            this.tentang.Controls.Add(this.label23);
            this.tentang.Controls.Add(this.label14);
            this.tentang.Controls.Add(this.label13);
            this.tentang.Controls.Add(this.richTextBox1);
            this.tentang.Controls.Add(this.label12);
            this.tentang.Controls.Add(this.groupBox2);
            this.tentang.Location = new System.Drawing.Point(13, 30);
            this.tentang.Name = "tentang";
            this.tentang.Size = new System.Drawing.Size(338, 449);
            this.tentang.TabIndex = 8;
            this.tentang.Visible = false;
            this.tentang.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(18, 267);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(290, 20);
            this.label26.TabIndex = 5;
            this.label26.Text = "SEKILAS TENTANG PEMBUATAN GAME";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(18, 223);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 14);
            this.label16.TabIndex = 5;
            this.label16.Text = "Nomor Absen";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(122, 209);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(56, 14);
            this.label24.TabIndex = 5;
            this.label24.Text = "X RPL 2";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(18, 209);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 14);
            this.label15.TabIndex = 5;
            this.label15.Text = "Kelas";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(102, 223);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(14, 14);
            this.label20.TabIndex = 5;
            this.label20.Text = ":";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(102, 209);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(14, 14);
            this.label21.TabIndex = 5;
            this.label21.Text = ":";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(102, 213);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(14, 14);
            this.label19.TabIndex = 5;
            this.label19.Text = ":";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(102, 195);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(14, 14);
            this.label22.TabIndex = 5;
            this.label22.Text = ":";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(102, 199);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(14, 14);
            this.label18.TabIndex = 5;
            this.label18.Text = ":";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(102, 195);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(14, 14);
            this.label17.TabIndex = 5;
            this.label17.Text = ":";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(122, 195);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(154, 14);
            this.label23.TabIndex = 5;
            this.label23.Text = "Juan Charistheas Hawu";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(18, 195);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 14);
            this.label14.TabIndex = 5;
            this.label14.Text = "Nama";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(18, 174);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 14);
            this.label13.TabIndex = 5;
            this.label13.Text = "Pembuat";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(21, 287);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(302, 150);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 18);
            this.label12.TabIndex = 3;
            this.label12.Text = "TENTANG GAME";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.original;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Location = new System.Drawing.Point(19, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(136, 112);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPause);
            this.panel1.Controls.Add(this.lblTimeElapsed);
            this.panel1.Controls.Add(this.lblMovesMade);
            this.panel1.Controls.Add(this.btnQuit);
            this.panel1.Controls.Add(this.btnShuffle);
            this.panel1.Controls.Add(this.gbPuzzleBox);
            this.panel1.Location = new System.Drawing.Point(10, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 450);
            this.panel1.TabIndex = 7;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(122, 223);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(21, 14);
            this.label25.TabIndex = 5;
            this.label25.Text = "33";
            // 
            // frmPuzzleGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 499);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tentang);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPuzzleGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Picture Puzzle-Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AskPermissionBeforeQuite);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbPuzzleBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx9)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tentang.ResumeLayout(false);
            this.tentang.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPuzzleBox;
        private System.Windows.Forms.GroupBox gbOriginal;
        private System.Windows.Forms.PictureBox pbx3;
        private System.Windows.Forms.PictureBox pbx9;
        private System.Windows.Forms.PictureBox pbx6;
        private System.Windows.Forms.PictureBox pbx2;
        private System.Windows.Forms.PictureBox pbx8;
        private System.Windows.Forms.PictureBox pbx5;
        private System.Windows.Forms.PictureBox pbx1;
        private System.Windows.Forms.PictureBox pbx7;
        private System.Windows.Forms.PictureBox pbx4;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblMovesMade;
        private System.Windows.Forms.Label lblTimeElapsed;
        private System.Windows.Forms.Timer tmrTimeElapse;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caraBermainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tentangGameToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel tentang;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label25;
    }
}

