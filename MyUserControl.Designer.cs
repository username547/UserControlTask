namespace UserControlTask
{
    partial class MyUserControl
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
            userControlLabel = new Label();
            userControlTextBox = new TextBox();
            userControlBtn = new Button();
            SuspendLayout();
            // 
            // userControlLabel
            // 
            userControlLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userControlLabel.AutoSize = true;
            userControlLabel.Location = new Point(3, 3);
            userControlLabel.Name = "userControlLabel";
            userControlLabel.Size = new Size(0, 20);
            userControlLabel.TabIndex = 0;
            // 
            // userControlTextBox
            // 
            userControlTextBox.Location = new Point(3, 26);
            userControlTextBox.Name = "userControlTextBox";
            userControlTextBox.Size = new Size(140, 27);
            userControlTextBox.TabIndex = 1;
            // 
            // userControlBtn
            // 
            userControlBtn.Location = new Point(149, 26);
            userControlBtn.Name = "userControlBtn";
            userControlBtn.Size = new Size(27, 27);
            userControlBtn.TabIndex = 2;
            userControlBtn.Text = "👁\r\n";
            userControlBtn.UseVisualStyleBackColor = true;
            userControlBtn.Click += userControlBtn_Click;
            // 
            // MyUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(userControlBtn);
            Controls.Add(userControlTextBox);
            Controls.Add(userControlLabel);
            MinimumSize = new Size(180, 58);
            Name = "MyUserControl";
            Size = new Size(180, 58);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userControlLabel;
        private TextBox userControlTextBox;
        private Button userControlBtn;
    }
}
