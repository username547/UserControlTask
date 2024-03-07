namespace UserControlTask
{
    partial class PersonRecordEditDialog
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            TextBoxID = new TextBox();
            TextBoxName = new TextBox();
            TextBoxSurname = new TextBox();
            TextBoxPatronymic = new TextBox();
            TextBoxAge = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 1;
            label2.Text = "Имя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 115);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 2;
            label3.Text = "Фамилия";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 168);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 3;
            label4.Text = "Отчество";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 221);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 4;
            label5.Text = "Возраст";
            // 
            // TextBoxID
            // 
            TextBoxID.Location = new Point(12, 32);
            TextBoxID.Name = "TextBoxID";
            TextBoxID.ReadOnly = true;
            TextBoxID.Size = new Size(194, 27);
            TextBoxID.TabIndex = 5;
            // 
            // TextBoxName
            // 
            TextBoxName.Location = new Point(12, 85);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.Size = new Size(194, 27);
            TextBoxName.TabIndex = 6;
            // 
            // TextBoxSurname
            // 
            TextBoxSurname.Location = new Point(12, 138);
            TextBoxSurname.Name = "TextBoxSurname";
            TextBoxSurname.Size = new Size(194, 27);
            TextBoxSurname.TabIndex = 7;
            // 
            // TextBoxPatronymic
            // 
            TextBoxPatronymic.Location = new Point(12, 191);
            TextBoxPatronymic.Name = "TextBoxPatronymic";
            TextBoxPatronymic.Size = new Size(194, 27);
            TextBoxPatronymic.TabIndex = 8;
            // 
            // TextBoxAge
            // 
            TextBoxAge.Location = new Point(12, 244);
            TextBoxAge.Name = "TextBoxAge";
            TextBoxAge.Size = new Size(194, 27);
            TextBoxAge.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 277);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(112, 277);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // PersonRecordEditDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(222, 317);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(TextBoxAge);
            Controls.Add(TextBoxPatronymic);
            Controls.Add(TextBoxSurname);
            Controls.Add(TextBoxName);
            Controls.Add(TextBoxID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PersonRecordEditDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PersonRecordEditDialog";
            Load += PersonRecordEditDialog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TextBoxID;
        private TextBox TextBoxName;
        private TextBox TextBoxSurname;
        private TextBox TextBoxPatronymic;
        private TextBox TextBoxAge;
        private Button btnSave;
        private Button btnCancel;
    }
}