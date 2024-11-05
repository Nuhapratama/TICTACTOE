namespace TICTACTOE
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
            toolStrip1 = new ToolStrip();
            A1 = new Button();
            A2 = new Button();
            A3 = new Button();
            B1 = new Button();
            B2 = new Button();
            B3 = new Button();
            C1 = new Button();
            C2 = new Button();
            C3 = new Button();
            button10 = new Button();
            label5 = new Label();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            keluar = new Button();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(500, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // A1
            // 
            A1.Font = new Font("Roboto", 16.2F, FontStyle.Bold);
            A1.Location = new Point(21, 127);
            A1.Name = "A1";
            A1.Size = new Size(153, 153);
            A1.TabIndex = 1;
            A1.UseVisualStyleBackColor = true;
            A1.Click += button_Click;
            // 
            // A2
            // 
            A2.Font = new Font("Roboto", 16.2F, FontStyle.Bold);
            A2.Location = new Point(173, 127);
            A2.Name = "A2";
            A2.Size = new Size(153, 153);
            A2.TabIndex = 1;
            A2.UseVisualStyleBackColor = true;
            A2.Click += button_Click;
            // 
            // A3
            // 
            A3.Font = new Font("Roboto", 16.2F, FontStyle.Bold);
            A3.Location = new Point(325, 127);
            A3.Name = "A3";
            A3.Size = new Size(153, 153);
            A3.TabIndex = 1;
            A3.UseVisualStyleBackColor = true;
            A3.Click += button_Click;
            // 
            // B1
            // 
            B1.Font = new Font("Roboto", 16.2F, FontStyle.Bold);
            B1.Location = new Point(21, 279);
            B1.Name = "B1";
            B1.Size = new Size(153, 153);
            B1.TabIndex = 1;
            B1.UseVisualStyleBackColor = true;
            B1.Click += button_Click;
            // 
            // B2
            // 
            B2.Font = new Font("Roboto", 16.2F, FontStyle.Bold);
            B2.Location = new Point(173, 279);
            B2.Name = "B2";
            B2.Size = new Size(153, 153);
            B2.TabIndex = 1;
            B2.UseVisualStyleBackColor = true;
            B2.Click += button_Click;
            // 
            // B3
            // 
            B3.Font = new Font("Roboto", 16.2F, FontStyle.Bold);
            B3.Location = new Point(325, 279);
            B3.Name = "B3";
            B3.Size = new Size(153, 153);
            B3.TabIndex = 1;
            B3.UseVisualStyleBackColor = true;
            B3.Click += button_Click;
            // 
            // C1
            // 
            C1.Font = new Font("Roboto", 16.2F, FontStyle.Bold);
            C1.Location = new Point(21, 432);
            C1.Name = "C1";
            C1.Size = new Size(153, 153);
            C1.TabIndex = 1;
            C1.UseVisualStyleBackColor = true;
            C1.Click += button_Click;
            // 
            // C2
            // 
            C2.Font = new Font("Roboto", 16.2F, FontStyle.Bold);
            C2.Location = new Point(173, 431);
            C2.Name = "C2";
            C2.Size = new Size(153, 153);
            C2.TabIndex = 1;
            C2.UseVisualStyleBackColor = true;
            C2.Click += button_Click;
            // 
            // C3
            // 
            C3.Font = new Font("Roboto", 16.2F, FontStyle.Bold);
            C3.Location = new Point(325, 431);
            C3.Name = "C3";
            C3.Size = new Size(153, 153);
            C3.TabIndex = 1;
            C3.UseVisualStyleBackColor = true;
            C3.Click += button_Click;
            // 
            // button10
            // 
            button10.Location = new Point(21, 601);
            button10.Name = "button10";
            button10.Size = new Size(153, 49);
            button10.TabIndex = 2;
            button10.Text = "Reset";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(242, 608);
            label5.Name = "label5";
            label5.Size = new Size(181, 34);
            label5.TabIndex = 3;
            label5.Text = "Score Player 1 :";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(242, 653);
            label6.Name = "label6";
            label6.Size = new Size(176, 34);
            label6.TabIndex = 3;
            label6.Text = "Score Player 1 :";
            label6.Click += label6_Click;
            // 
            // label1
            // 
            label1.Location = new Point(29, 88);
            label1.Name = "label1";
            label1.Size = new Size(145, 23);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Location = new Point(333, 88);
            label2.Name = "label2";
            label2.Size = new Size(145, 23);
            label2.TabIndex = 0;
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // keluar
            // 
            keluar.Location = new Point(21, 653);
            keluar.Name = "keluar";
            keluar.Size = new Size(153, 49);
            keluar.TabIndex = 2;
            keluar.Text = "Exit";
            keluar.UseVisualStyleBackColor = true;
            keluar.Click += Exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "666666666";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private Button A1;
        private Button A2;
        private Button A3;
        private Button B1;
        private Button B2;
        private Button B3;
        private Button C1;
        private Button C2;
        private Button C3;
        private Button button10;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label1;
        private Label label2;
        private Button keluar;
    }
}
