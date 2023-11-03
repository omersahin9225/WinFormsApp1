namespace WinFormsApp1
{
    partial class Snakes
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            lblP = new Label();
            lblScore = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 400);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Red;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(91, 119);
            label1.Name = "label1";
            label1.Size = new Size(63, 18);
            label1.TabIndex = 1;
            label1.Text = "START";
            label1.Click += label1_Click;
            // 
            // lblP
            // 
            lblP.AutoSize = true;
            lblP.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblP.Location = new Point(98, 50);
            lblP.Name = "lblP";
            lblP.Size = new Size(55, 18);
            lblP.TabIndex = 2;
            lblP.Text = "PUAN";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblScore.Location = new Point(114, 86);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(18, 18);
            lblScore.TabIndex = 3;
            lblScore.Text = "0";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblScore);
            groupBox1.Controls.Add(lblP);
            groupBox1.Location = new Point(505, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(236, 167);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // Snakes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Snakes";
            Text = "Form1";
            KeyDown += Snakes_KeyDown;
            Resize += Snakes_Resize;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label lblP;
        private Label lblScore;
        private GroupBox groupBox1;
    }
}