namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            tbr_size.Maximum = 30; //Maximum value of trackbar
            tbr_size.Minimum = 8; //Minimum value of trackbar
            tbr_size.TickFrequency = 2; //Change frequency of each trackbar tick.

            int passSize = tbr_size.Value;

        }

        //Shows the password length depending on the trackbar value.
        private void tbr_size_Scroll(object sender, EventArgs e)
        {
            lbl_size.Text = "" + tbr_size.Value;
        }

        private void bt_Generate_Click(object sender, EventArgs e)
        {
            if(anyCheck() == false)
            {
                MessageBox.Show("You must select at least one option.");
                return;
            }
            txt_pwd.Text = "";
            var characters = "";

            if (cbox_cLetter.Checked)
            {
                characters += "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            }
            if (cbox_cNumber.Checked)
            {
                characters += "1234567890";
            }
            if (cbox_cSpecial.Checked)
            {
                characters += "!@#$%&*-/+";
            }

            var password = new char[tbr_size.Value];
            var random = new Random();

            for(int i = 0; i < password.Length; i++)
            {
                if (cbox_cStartUpper.Checked)
                {
                    do
                    {
                        password[0] = characters[random.Next(characters.Length)];
                    } while (!char.IsUpper(password[0]));
                }                
                password[i] = characters[random.Next(characters.Length)];
            }
            for (int i = 0; i < password.Length; i++)
            {
                txt_pwd.Text += password[i];
            }
            

        }

        private bool anyCheck()
        {
            if(cbox_cLetter.Checked || cbox_cNumber.Checked || cbox_cSpecial.Checked || cbox_cStartUpper.Checked)
            {
                return true;
            } else
            {
                return false;
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}