namespace usercontrol
{
    partial class panel_two
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panelTwoLabelOne = new System.Windows.Forms.Label();
            this.panelTwoLabelTwo = new System.Windows.Forms.Label();
            this.panelTwoInputTwo = new System.Windows.Forms.TextBox();
            this.panelTwoSubmit = new System.Windows.Forms.Button();
            this.panelTwoInputOne = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Panel Two!";
            // 
            // panelTwoLabelOne
            // 
            this.panelTwoLabelOne.AutoSize = true;
            this.panelTwoLabelOne.Location = new System.Drawing.Point(34, 85);
            this.panelTwoLabelOne.Name = "panelTwoLabelOne";
            this.panelTwoLabelOne.Size = new System.Drawing.Size(60, 14);
            this.panelTwoLabelOne.TabIndex = 1;
            this.panelTwoLabelOne.Text = "Input One";
            // 
            // panelTwoLabelTwo
            // 
            this.panelTwoLabelTwo.AutoSize = true;
            this.panelTwoLabelTwo.Location = new System.Drawing.Point(34, 148);
            this.panelTwoLabelTwo.Name = "panelTwoLabelTwo";
            this.panelTwoLabelTwo.Size = new System.Drawing.Size(59, 14);
            this.panelTwoLabelTwo.TabIndex = 2;
            this.panelTwoLabelTwo.Text = "Input Two";
            // 
            // panelTwoInputTwo
            // 
            this.panelTwoInputTwo.Location = new System.Drawing.Point(36, 176);
            this.panelTwoInputTwo.Name = "panelTwoInputTwo";
            this.panelTwoInputTwo.Size = new System.Drawing.Size(145, 21);
            this.panelTwoInputTwo.TabIndex = 4;
            // 
            // panelTwoSubmit
            // 
            this.panelTwoSubmit.Location = new System.Drawing.Point(36, 224);
            this.panelTwoSubmit.Name = "panelTwoSubmit";
            this.panelTwoSubmit.Size = new System.Drawing.Size(75, 25);
            this.panelTwoSubmit.TabIndex = 5;
            this.panelTwoSubmit.Text = "Submit";
            this.panelTwoSubmit.UseVisualStyleBackColor = true;
            this.panelTwoSubmit.Click += new System.EventHandler(this.panelTwoSubmit_Click);
            // 
            // panelTwoInputOne
            // 
            this.panelTwoInputOne.Location = new System.Drawing.Point(36, 102);
            this.panelTwoInputOne.Name = "panelTwoInputOne";
            this.panelTwoInputOne.Size = new System.Drawing.Size(145, 21);
            this.panelTwoInputOne.TabIndex = 3;
            // 
            // panel_two
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.panelTwoSubmit);
            this.Controls.Add(this.panelTwoInputTwo);
            this.Controls.Add(this.panelTwoInputOne);
            this.Controls.Add(this.panelTwoLabelTwo);
            this.Controls.Add(this.panelTwoLabelOne);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "panel_two";
            this.Size = new System.Drawing.Size(651, 495);
            this.Load += new System.EventHandler(this.panel_two_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label panelTwoLabelOne;
        private System.Windows.Forms.Label panelTwoLabelTwo;
        private System.Windows.Forms.TextBox panelTwoInputTwo;
        private System.Windows.Forms.Button panelTwoSubmit;
        private System.Windows.Forms.TextBox panelTwoInputOne;
    }
}
