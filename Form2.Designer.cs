namespace TICTACTOE
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            label5 = new Label();
            keluar = new Button();
            button10 = new Button();
            C3 = new Button();
            B3 = new Button();
            A3 = new Button();
            C2 = new Button();
            B2 = new Button();
            A2 = new Button();
            C1 = new Button();
            B1 = new Button();
            A1 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(325, 25);
            label2.Name = "label2";
            label2.Size = new Size(145, 40);
            label2.TabIndex = 4;
            label2.Text = "Player 2 (X)";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(30, 25);
            label1.Name = "label1";
            label1.Size = new Size(145, 40);
            label1.TabIndex = 5;
            label1.Text = "Player 1 (O)";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(243, 617);
            label6.Name = "label6";
            label6.Size = new Size(181, 34);
            label6.TabIndex = 17;
            label6.Text = "Score Player 1 :";
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(243, 572);
            label5.Name = "label5";
            label5.Size = new Size(181, 34);
            label5.TabIndex = 18;
            label5.Text = "Score Player 1 :";
            label5.Click += label5_Click;
            // 
            // keluar
            // 
            keluar.BackColor = Color.Transparent;
            keluar.ForeColor = SystemColors.ActiveCaptionText;
            keluar.Location = new Point(22, 617);
            keluar.Name = "keluar";
            keluar.Size = new Size(153, 49);
            keluar.TabIndex = 15;
            keluar.Text = "Keluar";
            keluar.UseVisualStyleBackColor = false;
            keluar.Click += keluar_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.Transparent;
            button10.ForeColor = SystemColors.ActiveCaptionText;
            button10.Location = new Point(22, 565);
            button10.Name = "button10";
            button10.Size = new Size(153, 49);
            button10.TabIndex = 16;
            button10.Text = "Reset";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // C3
            // 
            C3.BackColor = Color.Transparent;
            C3.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold);
            C3.ForeColor = Color.Red;
            C3.Location = new Point(326, 395);
            C3.Name = "C3";
            C3.Size = new Size(153, 153);
            C3.TabIndex = 6;
            C3.UseVisualStyleBackColor = false;
            C3.Click += button_Click;
            // 
            // B3
            // 
            B3.BackColor = Color.Transparent;
            B3.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold);
            B3.ForeColor = Color.Red;
            B3.Location = new Point(326, 243);
            B3.Name = "B3";
            B3.Size = new Size(153, 153);
            B3.TabIndex = 7;
            B3.UseVisualStyleBackColor = false;
            B3.Click += button_Click;
            // 
            // A3
            // 
            A3.BackColor = Color.Transparent;
            A3.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold);
            A3.ForeColor = Color.Red;
            A3.Location = new Point(326, 91);
            A3.Name = "A3";
            A3.Size = new Size(153, 153);
            A3.TabIndex = 8;
            A3.UseVisualStyleBackColor = false;
            A3.Click += button_Click;
            // 
            // C2
            // 
            C2.BackColor = Color.Transparent;
            C2.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold);
            C2.ForeColor = Color.Red;
            C2.Location = new Point(174, 395);
            C2.Name = "C2";
            C2.Size = new Size(153, 153);
            C2.TabIndex = 9;
            C2.UseVisualStyleBackColor = false;
            C2.Click += button_Click;
            // 
            // B2
            // 
            B2.BackColor = Color.Transparent;
            B2.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold);
            B2.ForeColor = Color.Red;
            B2.Location = new Point(174, 243);
            B2.Name = "B2";
            B2.Size = new Size(153, 153);
            B2.TabIndex = 10;
            B2.UseVisualStyleBackColor = false;
            B2.Click += button_Click;
            // 
            // A2
            // 
            A2.BackColor = Color.Transparent;
            A2.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold);
            A2.ForeColor = Color.Red;
            A2.Location = new Point(174, 91);
            A2.Name = "A2";
            A2.Size = new Size(153, 153);
            A2.TabIndex = 11;
            A2.UseVisualStyleBackColor = false;
            A2.Click += button_Click;
            // 
            // C1
            // 
            C1.BackColor = Color.Transparent;
            C1.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold);
            C1.ForeColor = Color.Red;
            C1.Location = new Point(22, 396);
            C1.Name = "C1";
            C1.Size = new Size(153, 153);
            C1.TabIndex = 12;
            C1.UseVisualStyleBackColor = false;
            C1.Click += button_Click;
            // 
            // B1
            // 
            B1.BackColor = Color.Transparent;
            B1.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold);
            B1.ForeColor = Color.Red;
            B1.Location = new Point(22, 243);
            B1.Name = "B1";
            B1.Size = new Size(153, 153);
            B1.TabIndex = 13;
            B1.UseVisualStyleBackColor = false;
            B1.Click += button_Click;
            // 
            // A1
            // 
            A1.BackColor = Color.Transparent;
            A1.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold);
            A1.ForeColor = Color.Red;
            A1.Location = new Point(22, 91);
            A1.Name = "A1";
            A1.Size = new Size(153, 153);
            A1.TabIndex = 14;
            A1.UseVisualStyleBackColor = false;
            A1.Click += button_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(500, 719);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(keluar);
            Controls.Add(button10);
            Controls.Add(C3);
            Controls.Add(B3);
            Controls.Add(A3);
            Controls.Add(C2);
            Controls.Add(B2);
            Controls.Add(A2);
            Controls.Add(C1);
            Controls.Add(B1);
            Controls.Add(A1);
            Name = "Form2";
            Text = "TicTacToe";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Button keluar;
        private Button button10;
        private Button C3;
        private Button B3;
        private Button A3;
        private Button C2;
        private Button B2;
        private Button A2;
        private Button C1;
        private Button B1;
        private Button A1;
    }
}