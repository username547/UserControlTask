namespace UserControlTask
{
    partial class PersonRecordUserControl
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
            label1 = new Label();
            TextBoxID = new TextBox();
            label2 = new Label();
            TextBoxName = new TextBox();
            label3 = new Label();
            TextBoxSurname = new TextBox();
            label4 = new Label();
            TextBoxPatronymic = new TextBox();
            label5 = new Label();
            TextBoxAge = new TextBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 3);
            label1.Margin = new Padding(3);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // TextBoxID
            // 
            TextBoxID.Location = new Point(3, 29);
            TextBoxID.Name = "TextBoxID";
            TextBoxID.ReadOnly = true;
            TextBoxID.Size = new Size(45, 27);
            TextBoxID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 3);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 2;
            label2.Text = "Имя";
            // 
            // TextBoxName
            // 
            TextBoxName.Location = new Point(54, 29);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.ReadOnly = true;
            TextBoxName.Size = new Size(125, 27);
            TextBoxName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(185, 3);
            label3.Margin = new Padding(3);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 4;
            label3.Text = "Фамилия";
            // 
            // TextBoxSurname
            // 
            TextBoxSurname.Location = new Point(185, 29);
            TextBoxSurname.Name = "TextBoxSurname";
            TextBoxSurname.ReadOnly = true;
            TextBoxSurname.Size = new Size(125, 27);
            TextBoxSurname.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(316, 3);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 6;
            label4.Text = "Отчество";
            // 
            // TextBoxPatronymic
            // 
            TextBoxPatronymic.Location = new Point(316, 29);
            TextBoxPatronymic.Name = "TextBoxPatronymic";
            TextBoxPatronymic.ReadOnly = true;
            TextBoxPatronymic.Size = new Size(125, 27);
            TextBoxPatronymic.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(447, 3);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 8;
            label5.Text = "Возраст";
            // 
            // TextBoxAge
            // 
            TextBoxAge.Location = new Point(447, 29);
            TextBoxAge.Name = "TextBoxAge";
            TextBoxAge.ReadOnly = true;
            TextBoxAge.Size = new Size(64, 27);
            TextBoxAge.TabIndex = 9;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(527, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Изменить";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(527, 31);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // PersonRecordUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(TextBoxAge);
            Controls.Add(label5);
            Controls.Add(TextBoxPatronymic);
            Controls.Add(label4);
            Controls.Add(TextBoxSurname);
            Controls.Add(label3);
            Controls.Add(TextBoxName);
            Controls.Add(label2);
            Controls.Add(TextBoxID);
            Controls.Add(label1);
            Name = "PersonRecordUserControl";
            Size = new Size(629, 63);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TextBoxID;
        private Label label2;
        private TextBox TextBoxName;
        private Label label3;
        private TextBox TextBoxSurname;
        private Label label4;
        private TextBox TextBoxPatronymic;
        private Label label5;
        private TextBox TextBoxAge;
        private Button btnUpdate;
        private Button btnDelete;
    }
}
