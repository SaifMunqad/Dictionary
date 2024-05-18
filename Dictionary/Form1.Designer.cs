namespace Dictionary
{
    partial class Dictionary
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
            this.wordTextBox = new System.Windows.Forms.TextBox();
            this.meaningBox = new System.Windows.Forms.TextBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wordTextBox
            // 
            this.wordTextBox.AcceptsTab = true;
            this.wordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wordTextBox.AutoCompleteCustomSource.AddRange(new string[] {
            "  "});
            this.wordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wordTextBox.Location = new System.Drawing.Point(54, 108);
            this.wordTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.wordTextBox.Name = "wordTextBox";
            this.wordTextBox.Size = new System.Drawing.Size(273, 20);
            this.wordTextBox.TabIndex = 0;
            this.wordTextBox.TextChanged += new System.EventHandler(this.wordTextBox_TextChanged);
            // 
            // meaningBox
            // 
            this.meaningBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.meaningBox.Location = new System.Drawing.Point(54, 153);
            this.meaningBox.Margin = new System.Windows.Forms.Padding(0);
            this.meaningBox.Multiline = true;
            this.meaningBox.Name = "meaningBox";
            this.meaningBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.meaningBox.Size = new System.Drawing.Size(415, 219);
            this.meaningBox.TabIndex = 1;
            // 
            // checkButton
            // 
            this.checkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkButton.Location = new System.Drawing.Point(330, 103);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(75, 28);
            this.checkButton.TabIndex = 2;
            this.checkButton.Text = "button1";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // playButton
            // 
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Location = new System.Drawing.Point(411, 103);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(58, 28);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // Dictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 417);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.meaningBox);
            this.Controls.Add(this.wordTextBox);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Dictionary";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox wordTextBox;
        private System.Windows.Forms.Button checkButton;
        public System.Windows.Forms.TextBox meaningBox;
        private System.Windows.Forms.Button playButton;
    }
}

