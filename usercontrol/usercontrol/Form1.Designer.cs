namespace usercontrol
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelOneBtn = new System.Windows.Forms.Button();
            this.dataPanelDetails = new System.Windows.Forms.Panel();
            this.panelTwoBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.outputOneLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.OutputTwo = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel_one1 = new usercontrol.panel_one();
            this.panel_two1 = new usercontrol.panel_two();
            this.panel1.SuspendLayout();
            this.dataPanelDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Control Panel Application";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelTwoBtn);
            this.panel1.Controls.Add(this.panelOneBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 447);
            this.panel1.TabIndex = 2;
            // 
            // panelOneBtn
            // 
            this.panelOneBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelOneBtn.Location = new System.Drawing.Point(67, 149);
            this.panelOneBtn.Name = "panelOneBtn";
            this.panelOneBtn.Size = new System.Drawing.Size(87, 33);
            this.panelOneBtn.TabIndex = 0;
            this.panelOneBtn.Text = "Panel One";
            this.panelOneBtn.UseVisualStyleBackColor = true;
            this.panelOneBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataPanelDetails
            // 
            this.dataPanelDetails.Controls.Add(this.textBox2);
            this.dataPanelDetails.Controls.Add(this.OutputTwo);
            this.dataPanelDetails.Controls.Add(this.textBox1);
            this.dataPanelDetails.Controls.Add(this.outputOneLabel);
            this.dataPanelDetails.Controls.Add(this.label2);
            this.dataPanelDetails.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataPanelDetails.Location = new System.Drawing.Point(742, 0);
            this.dataPanelDetails.Name = "dataPanelDetails";
            this.dataPanelDetails.Size = new System.Drawing.Size(217, 447);
            this.dataPanelDetails.TabIndex = 3;
            // 
            // panelTwoBtn
            // 
            this.panelTwoBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTwoBtn.Location = new System.Drawing.Point(67, 221);
            this.panelTwoBtn.Name = "panelTwoBtn";
            this.panelTwoBtn.Size = new System.Drawing.Size(87, 33);
            this.panelTwoBtn.TabIndex = 1;
            this.panelTwoBtn.Text = "Panel Two";
            this.panelTwoBtn.UseVisualStyleBackColor = true;
            this.panelTwoBtn.Click += new System.EventHandler(this.panelTwoBtn_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "DATA:";
            // 
            // outputOneLabel
            // 
            this.outputOneLabel.AutoSize = true;
            this.outputOneLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputOneLabel.Location = new System.Drawing.Point(24, 97);
            this.outputOneLabel.Name = "outputOneLabel";
            this.outputOneLabel.Size = new System.Drawing.Size(60, 14);
            this.outputOneLabel.TabIndex = 1;
            this.outputOneLabel.Text = "Input One";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(25, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 21);
            this.textBox1.TabIndex = 2;
            // 
            // OutputTwo
            // 
            this.OutputTwo.AutoSize = true;
            this.OutputTwo.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputTwo.Location = new System.Drawing.Point(26, 154);
            this.OutputTwo.Name = "OutputTwo";
            this.OutputTwo.Size = new System.Drawing.Size(59, 14);
            this.OutputTwo.TabIndex = 3;
            this.OutputTwo.Text = "Input Two";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(25, 175);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 21);
            this.textBox2.TabIndex = 4;
            // 
            // panel_one1
            // 
            this.panel_one1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel_one1.Location = new System.Drawing.Point(242, 52);
            this.panel_one1.Name = "panel_one1";
            this.panel_one1.Size = new System.Drawing.Size(494, 379);
            this.panel_one1.TabIndex = 1;
            this.panel_one1.Load += new System.EventHandler(this.panel_one1_Load);
            // 
            // panel_two1
            // 
            this.panel_two1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel_two1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_two1.Location = new System.Drawing.Point(251, 52);
            this.panel_two1.Name = "panel_two1";
            this.panel_two1.Size = new System.Drawing.Size(485, 379);
            this.panel_two1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 447);
            this.Controls.Add(this.panel_one1);
            this.Controls.Add(this.panel_two1);
            this.Controls.Add(this.dataPanelDetails);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.dataPanelDetails.ResumeLayout(false);
            this.dataPanelDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private panel_one panel_one1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button panelOneBtn;
        private System.Windows.Forms.Panel dataPanelDetails;
        private System.Windows.Forms.Button panelTwoBtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label OutputTwo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label outputOneLabel;
        private System.Windows.Forms.Label label2;
        private panel_two panel_two1;
    }
}

