namespace SumOfTwo
{
    partial class SumForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SumForm));
            this.firstBox = new System.Windows.Forms.TextBox();
            this.secondBox = new System.Windows.Forms.TextBox();
            this.labelPlus = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstBox
            // 
            this.firstBox.Location = new System.Drawing.Point(52, 40);
            this.firstBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.firstBox.Name = "firstBox";
            this.firstBox.Size = new System.Drawing.Size(89, 24);
            this.firstBox.TabIndex = 0;
            // 
            // secondBox
            // 
            this.secondBox.Location = new System.Drawing.Point(202, 41);
            this.secondBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.secondBox.Name = "secondBox";
            this.secondBox.Size = new System.Drawing.Size(93, 24);
            this.secondBox.TabIndex = 1;
            // 
            // labelPlus
            // 
            this.labelPlus.AutoSize = true;
            this.labelPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlus.Location = new System.Drawing.Point(162, 39);
            this.labelPlus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPlus.Name = "labelPlus";
            this.labelPlus.Size = new System.Drawing.Size(25, 25);
            this.labelPlus.TabIndex = 2;
            this.labelPlus.Text = "+";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(52, 85);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(243, 56);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // SumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 199);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelPlus);
            this.Controls.Add(this.secondBox);
            this.Controls.Add(this.firstBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SumForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sum of Two";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstBox;
        private System.Windows.Forms.TextBox secondBox;
        private System.Windows.Forms.Label labelPlus;
        private System.Windows.Forms.Button buttonStart;
    }
}

