using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace projet_carloc
{
    public partial class F : Form
    {
        string identifiant = "";
        string email = "";
        string motdepasse = "";
        public F()
        {
            InitializeComponent();
        }

        private void F_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            identifiant = textBox1.Text;
            if (identifiant.Length < 4)
            {
                textBox2.Enabled = false;
            }
            else
            {
                textBox2.Enabled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (email.Length <= 4)
            {
                textBox3.Enabled = true;
            }
            else
            {
                textBox3.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            identifiant = textBox1.Text;
            email = textBox2.Text;
            if (identifiant.Length <= 4)
            {
                MessageBox.Show("Vous n'avez pas le nombre de caractères requis pour votre identifiant");
            }

            bool EmailIsValid = false;
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                EmailIsValid = addr.Address == email;
            }
            catch
            {
                EmailIsValid = false;
            }
            if (!EmailIsValid)
            {
                MessageBox.Show("Veuillez entrer un email valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            motdepasse = textBox3.Text;
            if (motdepasse.Length < 6 || !motdepasse.Any(char.IsUpper) || !motdepasse.Any(char.IsDigit))
            {
                MessageBox.Show("Le mot de passe doit contenir au moins 6 caractères, une majuscule et un chiffre.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            groupBox2.Enabled = true;
            MessageBox.Show("Bienvenue " + identifiant + ", votre compte a bien été créé !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == identifiant && textBox5.Text == motdepasse)
            {
                toolStripStatusLabel1.Text = identifiant;
                tabPage2.Enabled = true;
                MessageBox.Show("Connexion réussi !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vérifiez vos informations !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
