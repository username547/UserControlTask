using System.ComponentModel;

namespace UserControlTask
{
    public partial class MyUserControl : UserControl
    {
        public MyUserControl()
        {
            InitializeComponent();
            userControlTextBox.UseSystemPasswordChar = true;
        }

        [Browsable(true)]
        public string LabelText
        {
            get => userControlLabel.Text;
            set => userControlLabel.Text = value;
        }

        [Browsable(true)]
        public string TextBoxText
        {
            get => userControlTextBox.Text;
            set => userControlTextBox.Text = value;
        }

        private void userControlBtn_Click(object sender, EventArgs e) =>
            userControlTextBox.UseSystemPasswordChar = !userControlTextBox.UseSystemPasswordChar;
    }
}
