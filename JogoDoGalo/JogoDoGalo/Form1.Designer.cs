namespace JogoDoGalo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            tlpPrincipal = new TableLayoutPanel();
            restart = new Button();
            tlpInterior = new TableLayoutPanel();
            tlpTabuleiro = new TableLayoutPanel();
            button8 = new Button();
            button7 = new Button();
            button5 = new Button();
            button6 = new Button();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            button3 = new Button();
            button0 = new Button();
            label = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tlpPrincipal.SuspendLayout();
            tlpInterior.SuspendLayout();
            tlpTabuleiro.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(115, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(252, 194);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tlpPrincipal
            // 
            tlpPrincipal.BackColor = Color.Transparent;
            tlpPrincipal.ColumnCount = 1;
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpPrincipal.Controls.Add(restart, 0, 2);
            tlpPrincipal.Controls.Add(pictureBox1, 0, 0);
            tlpPrincipal.Controls.Add(tlpInterior, 0, 1);
            tlpPrincipal.Dock = DockStyle.Fill;
            tlpPrincipal.Location = new Point(0, 0);
            tlpPrincipal.Name = "tlpPrincipal";
            tlpPrincipal.RowCount = 3;
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tlpPrincipal.Size = new Size(482, 553);
            tlpPrincipal.TabIndex = 10;
            // 
            // restart
            // 
            restart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            restart.BackColor = Color.FromArgb(247, 177, 17);
            restart.Font = new Font("Bauhaus 93", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            restart.ForeColor = Color.White;
            restart.Location = new Point(3, 486);
            restart.Name = "restart";
            restart.Size = new Size(476, 64);
            restart.TabIndex = 11;
            restart.Text = "REINICIAR";
            restart.UseVisualStyleBackColor = false;
            // 
            // tlpInterior
            // 
            tlpInterior.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpInterior.ColumnCount = 1;
            tlpInterior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpInterior.Controls.Add(tlpTabuleiro, 0, 1);
            tlpInterior.Controls.Add(label, 0, 0);
            tlpInterior.Location = new Point(3, 203);
            tlpInterior.Name = "tlpInterior";
            tlpInterior.RowCount = 2;
            tlpInterior.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpInterior.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpInterior.Size = new Size(476, 277);
            tlpInterior.TabIndex = 12;
            // 
            // tlpTabuleiro
            // 
            tlpTabuleiro.ColumnCount = 3;
            tlpTabuleiro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpTabuleiro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpTabuleiro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpTabuleiro.Controls.Add(button8, 2, 2);
            tlpTabuleiro.Controls.Add(button7, 1, 2);
            tlpTabuleiro.Controls.Add(button5, 2, 1);
            tlpTabuleiro.Controls.Add(button6, 0, 2);
            tlpTabuleiro.Controls.Add(button1, 1, 0);
            tlpTabuleiro.Controls.Add(button2, 2, 0);
            tlpTabuleiro.Controls.Add(button4, 1, 1);
            tlpTabuleiro.Controls.Add(button3, 0, 1);
            tlpTabuleiro.Controls.Add(button0, 0, 0);
            tlpTabuleiro.Dock = DockStyle.Fill;
            tlpTabuleiro.Location = new Point(3, 53);
            tlpTabuleiro.Name = "tlpTabuleiro";
            tlpTabuleiro.RowCount = 3;
            tlpTabuleiro.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlpTabuleiro.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlpTabuleiro.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlpTabuleiro.Size = new Size(470, 221);
            tlpTabuleiro.TabIndex = 1;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(128, 218, 5);
            button8.Dock = DockStyle.Fill;
            button8.Font = new Font("Segoe UI", 50F);
            button8.Location = new Point(315, 149);
            button8.Name = "button8";
            button8.Size = new Size(152, 69);
            button8.TabIndex = 9;
            button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(128, 218, 5);
            button7.Dock = DockStyle.Fill;
            button7.Font = new Font("Segoe UI", 50F);
            button7.Location = new Point(159, 149);
            button7.Name = "button7";
            button7.Size = new Size(150, 69);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(128, 218, 5);
            button5.Dock = DockStyle.Fill;
            button5.Font = new Font("Segoe UI", 50F);
            button5.Location = new Point(315, 76);
            button5.Name = "button5";
            button5.Size = new Size(152, 67);
            button5.TabIndex = 8;
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(128, 218, 5);
            button6.Dock = DockStyle.Fill;
            button6.Font = new Font("Segoe UI", 50F);
            button6.Location = new Point(3, 149);
            button6.Name = "button6";
            button6.Size = new Size(150, 69);
            button6.TabIndex = 3;
            button6.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 218, 5);
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Segoe UI", 50F);
            button1.Location = new Point(159, 3);
            button1.Name = "button1";
            button1.Size = new Size(150, 67);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 218, 5);
            button2.Dock = DockStyle.Fill;
            button2.Font = new Font("Segoe UI", 50F);
            button2.Location = new Point(315, 3);
            button2.Name = "button2";
            button2.Size = new Size(152, 67);
            button2.TabIndex = 7;
            button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(128, 218, 5);
            button4.Dock = DockStyle.Fill;
            button4.Font = new Font("Segoe UI", 50F);
            button4.Location = new Point(159, 76);
            button4.Name = "button4";
            button4.Size = new Size(150, 67);
            button4.TabIndex = 5;
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(128, 218, 5);
            button3.Dock = DockStyle.Fill;
            button3.Font = new Font("Segoe UI", 50F);
            button3.Location = new Point(3, 76);
            button3.Name = "button3";
            button3.Size = new Size(150, 67);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = false;
            // 
            // button0
            // 
            button0.BackColor = Color.FromArgb(128, 218, 5);
            button0.Dock = DockStyle.Fill;
            button0.Font = new Font("Segoe UI", 50F);
            button0.Location = new Point(3, 3);
            button0.Name = "button0";
            button0.Size = new Size(150, 67);
            button0.TabIndex = 1;
            button0.UseVisualStyleBackColor = false;
            // 
            // label
            // 
            label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label.AutoSize = true;
            label.BackColor = Color.SeaGreen;
            label.Font = new Font("Berlin Sans FB Demi", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.ForeColor = Color.White;
            label.Location = new Point(3, 0);
            label.Name = "label";
            label.Size = new Size(470, 50);
            label.TabIndex = 2;
            label.Text = "Pressiona um botão para jogar!";
            label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(482, 553);
            Controls.Add(tlpPrincipal);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tlpPrincipal.ResumeLayout(false);
            tlpInterior.ResumeLayout(false);
            tlpInterior.PerformLayout();
            tlpTabuleiro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private TableLayoutPanel tlpPrincipal;
        private Button restart;
        private TableLayoutPanel tlpInterior;
        private TableLayoutPanel tlpTabuleiro;
        private Button button8;
        private Button button7;
        private Button button5;
        private Button button6;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button3;
        private Button button0;
        private Label label;
    }
}
