namespace UserControlTask
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            myUserControl1 = new MyUserControl();
            PersonList = new FlowLayoutPanel();
            btnCreate = new Button();
            label1 = new Label();
            label2 = new Label();
            TextBoxCount = new TextBox();
            TextBoxAge = new TextBox();
            SuspendLayout();
            // 
            // myUserControl1
            // 
            myUserControl1.LabelText = "Название поля";
            myUserControl1.Location = new Point(608, 12);
            myUserControl1.MinimumSize = new Size(180, 58);
            myUserControl1.Name = "myUserControl1";
            myUserControl1.Size = new Size(180, 58);
            myUserControl1.TabIndex = 0;
            myUserControl1.TextBoxText = "Содержимое";
            // 
            // PersonList
            // 
            PersonList.Location = new Point(12, 76);
            PersonList.Name = "PersonList";
            PersonList.Size = new Size(776, 362);
            PersonList.TabIndex = 1;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(12, 12);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Добавить";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(271, 12);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 3;
            label1.Text = "Кол. записей";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(271, 45);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 4;
            label2.Text = "Сумма лет";
            // 
            // TextBoxCount
            // 
            TextBoxCount.ImeMode = ImeMode.Off;
            TextBoxCount.Location = new Point(376, 9);
            TextBoxCount.Name = "TextBoxCount";
            TextBoxCount.Size = new Size(52, 27);
            TextBoxCount.TabIndex = 5;
            // 
            // TextBoxAge
            // 
            TextBoxAge.Location = new Point(376, 42);
            TextBoxAge.Name = "TextBoxAge";
            TextBoxAge.Size = new Size(52, 27);
            TextBoxAge.TabIndex = 6;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TextBoxAge);
            Controls.Add(TextBoxCount);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCreate);
            Controls.Add(PersonList);
            Controls.Add(myUserControl1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Form";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MyUserControl myUserControl1;
        private FlowLayoutPanel PersonList;
        private Button btnCreate;
        private Label label1;
        private Label label2;
        private TextBox TextBoxCount;
        private TextBox TextBoxAge;
    }
}
