namespace usercontrol
{
    partial class panel_one
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
            this.panelOneInputLabel = new System.Windows.Forms.Label();
            this.panelOneInputOne = new System.Windows.Forms.TextBox();
            this.panelOneLabelTwo = new System.Windows.Forms.Label();
            this.panelOneInputTwo = new System.Windows.Forms.TextBox();
            this.panelOneSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Panel One!";
            // 
            // panelOneInputLabel
            // 
            this.panelOneInputLabel.AutoSize = true;
            this.panelOneInputLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelOneInputLabel.Location = new System.Drawing.Point(45, 102);
            this.panelOneInputLabel.Name = "panelOneInputLabel";
            this.panelOneInputLabel.Size = new System.Drawing.Size(60, 14);
            this.panelOneInputLabel.TabIndex = 1;
            this.panelOneInputLabel.Text = "Input One";
            // 
            // panelOneInputOne
            // 
            this.panelOneInputOne.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelOneInputOne.Location = new System.Drawing.Point(45, 122);
            this.panelOneInputOne.Name = "panelOneInputOne";
            this.panelOneInputOne.Size = new System.Drawing.Size(141, 21);
            this.panelOneInputOne.TabIndex = 2;
            // 
            // panelOneLabelTwo
            // 
            this.panelOneLabelTwo.AutoSize = true;
            this.panelOneLabelTwo.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelOneLabelTwo.Location = new System.Drawing.Point(45, 154);
            this.panelOneLabelTwo.Name = "panelOneLabelTwo";
            this.panelOneLabelTwo.Size = new System.Drawing.Size(59, 14);
            this.panelOneLabelTwo.TabIndex = 3;
            this.panelOneLabelTwo.Text = "Input Two";
            // 
            // panelOneInputTwo
            // 
            this.panelOneInputTwo.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelOneInputTwo.Location = new System.Drawing.Point(45, 172);
            this.panelOneInputTwo.Name = "panelOneInputTwo";
            this.panelOneInputTwo.Size = new System.Drawing.Size(141, 21);
            this.panelOneInputTwo.TabIndex = 4;
            // 
            // panelOneSubmit
            // 
            this.panelOneSubmit.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelOneSubmit.Location = new System.Drawing.Point(44, 236);
            this.panelOneSubmit.Name = "panelOneSubmit";
            this.panelOneSubmit.Size = new System.Drawing.Size(75, 23);
            this.panelOneSubmit.TabIndex = 5;
            this.panelOneSubmit.Text = "Submit";
            this.panelOneSubmit.UseVisualStyleBackColor = true;
            this.panelOneSubmit.Click += new System.EventHandler(this.panelOneSubmit_Click);
            // 
            // panel_one
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Controls.Add(this.panelOneSubmit);
            this.Controls.Add(this.panelOneInputTwo);
            this.Controls.Add(this.panelOneLabelTwo);
            this.Controls.Add(this.panelOneInputOne);
            this.Controls.Add(this.panelOneInputLabel);
            this.Controls.Add(this.label1);
            this.Name = "panel_one";
            this.Size = new System.Drawing.Size(651, 460);
            this.Load += new System.EventHandler(this.panel_one_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label panelOneInputLabel;
        private System.Windows.Forms.TextBox panelOneInputOne;
        private System.Windows.Forms.Label panelOneLabelTwo;
        private System.Windows.Forms.TextBox panelOneInputTwo;
        private System.Windows.Forms.Button panelOneSubmit;
    }
}
