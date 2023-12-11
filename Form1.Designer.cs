namespace Hasan.Badr_harjoitus_2
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
            OtsikkoLB = new Label();
            TulostussLB = new Label();
            ViestiTB = new TextBox();
            TulostaBT = new Button();
            SuspendLayout();
            // 
            // OtsikkoLB
            // 
            OtsikkoLB.AutoSize = true;
            OtsikkoLB.Font = new Font("Segoe Script", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            OtsikkoLB.Location = new Point(13, 13);
            OtsikkoLB.Name = "OtsikkoLB";
            OtsikkoLB.Size = new Size(288, 33);
            OtsikkoLB.TabIndex = 0;
            OtsikkoLB.Text = "Anna tulostettava teksti:";
            // 
            // TulostussLB
            // 
            TulostussLB.AutoSize = true;
            TulostussLB.Font = new Font("Segoe Script", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            TulostussLB.Location = new Point(13, 65);
            TulostussLB.Name = "TulostussLB";
            TulostussLB.Size = new Size(72, 33);
            TulostussLB.TabIndex = 1;
            TulostussLB.Text = "xxxx";
            TulostussLB.Visible = false;
            // 
            // ViestiTB
            // 
            ViestiTB.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ViestiTB.Location = new Point(307, 13);
            ViestiTB.Name = "ViestiTB";
            ViestiTB.Size = new Size(527, 35);
            ViestiTB.TabIndex = 2;
            // 
            // TulostaBT
            // 
            TulostaBT.FlatStyle = FlatStyle.System;
            TulostaBT.Location = new Point(645, 64);
            TulostaBT.Name = "TulostaBT";
            TulostaBT.Size = new Size(189, 34);
            TulostaBT.TabIndex = 3;
            TulostaBT.Text = "Tulosta teksti";
            TulostaBT.UseVisualStyleBackColor = true;
            TulostaBT.Click += TulostaBT_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(879, 196);
            Controls.Add(TulostaBT);
            Controls.Add(ViestiTB);
            Controls.Add(TulostussLB);
            Controls.Add(OtsikkoLB);
            ForeColor = Color.MintCream;
            Name = "Form1";
            Text = "Harjoitus 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label OtsikkoLB;
        private Label TulostussLB;
        private TextBox ViestiTB;
        private Button TulostaBT;
    }
}