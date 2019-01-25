namespace Fontchaos
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
            this.ChooseFileTextBox = new System.Windows.Forms.TextBox();
            this.ChooseFileButton = new System.Windows.Forms.Button();
            this.RandomizeButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ChooseFileTextBox
            // 
            this.ChooseFileTextBox.Location = new System.Drawing.Point(115, 12);
            this.ChooseFileTextBox.Name = "ChooseFileTextBox";
            this.ChooseFileTextBox.Size = new System.Drawing.Size(217, 22);
            this.ChooseFileTextBox.TabIndex = 0;
            // 
            // ChooseFileButton
            // 
            this.ChooseFileButton.Location = new System.Drawing.Point(12, 11);
            this.ChooseFileButton.Name = "ChooseFileButton";
            this.ChooseFileButton.Size = new System.Drawing.Size(97, 23);
            this.ChooseFileButton.TabIndex = 1;
            this.ChooseFileButton.Text = "Choose file";
            this.ChooseFileButton.UseVisualStyleBackColor = true;
            this.ChooseFileButton.Click += new System.EventHandler(this.GetFileClick);
            // 
            // RandomizeButton
            // 
            this.RandomizeButton.Location = new System.Drawing.Point(12, 40);
            this.RandomizeButton.Name = "RandomizeButton";
            this.RandomizeButton.Size = new System.Drawing.Size(320, 36);
            this.RandomizeButton.TabIndex = 2;
            this.RandomizeButton.Text = "Randomize";
            this.RandomizeButton.UseVisualStyleBackColor = true;
            this.RandomizeButton.Click += new System.EventHandler(this.RandomizeButtonClick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 99);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(673, 554);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 665);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.RandomizeButton);
            this.Controls.Add(this.ChooseFileButton);
            this.Controls.Add(this.ChooseFileTextBox);
            this.Name = "Form1";
            this.Text = "FontChaos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ChooseFileTextBox;
        private System.Windows.Forms.Button ChooseFileButton;
        private System.Windows.Forms.Button RandomizeButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

