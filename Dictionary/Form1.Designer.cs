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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dictionary));
            this.wordTextBox = new System.Windows.Forms.TextBox();
            this.meaningBox = new System.Windows.Forms.TextBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.connectionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wordTextBox
            // 
            this.wordTextBox.AcceptsTab = true;
            this.wordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wordTextBox.AutoCompleteCustomSource.AddRange(new string[] {
            "  "});
            this.wordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.wordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wordTextBox.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordTextBox.ForeColor = System.Drawing.Color.White;
            this.wordTextBox.Location = new System.Drawing.Point(31, 71);
            this.wordTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.wordTextBox.Name = "wordTextBox";
            this.wordTextBox.Size = new System.Drawing.Size(273, 25);
            this.wordTextBox.TabIndex = 0;
            this.wordTextBox.TextChanged += new System.EventHandler(this.wordTextBox_TextChanged);
            // 
            // meaningBox
            // 
            this.meaningBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.meaningBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.meaningBox.ForeColor = System.Drawing.Color.White;
            this.meaningBox.Location = new System.Drawing.Point(21, 116);
            this.meaningBox.Margin = new System.Windows.Forms.Padding(12);
            this.meaningBox.Multiline = true;
            this.meaningBox.Name = "meaningBox";
            this.meaningBox.ReadOnly = true;
            this.meaningBox.Size = new System.Drawing.Size(463, 280);
            this.meaningBox.TabIndex = 1;
            // 
            // checkButton
            // 
            this.checkButton.FlatAppearance.BorderSize = 0;
            this.checkButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.checkButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.checkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkButton.Location = new System.Drawing.Point(323, 68);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(88, 30);
            this.checkButton.TabIndex = 2;
            this.checkButton.Text = "Translate";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.playButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Image = global::Dictionary.Properties.Resources.play;
            this.playButton.Location = new System.Drawing.Point(437, 68);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(30, 30);
            this.playButton.TabIndex = 2;
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // connectionLabel
            // 
            this.connectionLabel.AutoSize = true;
            this.connectionLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.connectionLabel.Location = new System.Drawing.Point(165, 25);
            this.connectionLabel.Name = "connectionLabel";
            this.connectionLabel.Size = new System.Drawing.Size(167, 19);
            this.connectionLabel.TabIndex = 3;
            this.connectionLabel.Text = "No Network Connection!";
            this.connectionLabel.Visible = false;
            // 
            // Dictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(505, 417);
            this.Controls.Add(this.connectionLabel);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.meaningBox);
            this.Controls.Add(this.wordTextBox);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Dictionary";
            this.Text = "Dictionary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox wordTextBox;
        private System.Windows.Forms.Button checkButton;
        public System.Windows.Forms.TextBox meaningBox;
        private System.Windows.Forms.Button playButton;
        public System.Windows.Forms.Label connectionLabel;
    }
}

