using System.Text.RegularExpressions;

namespace _5_regex
{
    public partial class Form1 : Form
    {
        /**
         *  Regex - Regular Expression
         *  عبارات با قاعده
         *  
         *  pattern -> text
         *  
         *  neveshtane pattern ❌
         *  estefade az pattern ✔️
         *  
         */
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBoxUserName.Text, @"[a..z]\w{2,}"))
            {
                MessageBox.Show("Invalid Username");
            }

            if (!Regex.IsMatch(textBoxEmail.Text, @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?", RegexOptions.IgnoreCase))
            {
                MessageBox.Show("Invalid Username");
            }
        }
    }
}