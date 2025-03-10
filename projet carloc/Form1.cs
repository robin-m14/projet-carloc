using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using GestionVoituresApp;
using System.Drawing.Text;

namespace projet_carloc
{
    public partial class F : Form
    {
        string identifiant = "";
        string email = "";
        string motdepasse = "";
        private GestionVoitures gestionVoitures = new GestionVoitures();
        string annee;

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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string marque = textBox6.Text;
                string modele = textBox7.Text;
                annee = numericUpDown1.Value.ToString();
                decimal prix;
                if (!decimal.TryParse(textBox9.Text.Replace(" ", "").Replace(",", "."), out prix))
                {
                    MessageBox.Show("Erreur : Veuillez entrer un prix valide (ex: 150000 ou 150000.50)", "Erreur de format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string etat = textBox10.Text.Trim();
                int kilometrage = int.Parse(textBox11.Text);
                string carburant = textBox12.Text;

                gestionVoitures.AjouterVoiture(marque, modele, annee, prix, etat, kilometrage, carburant);

                MessageBox.Show("Voiture ajoutée avec succès !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            MettreAJourListeVoitures();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void MettreAJourListeVoitures()
        {
            // Vider la ListBox avant de la remplir pour éviter les doublons
            listBox1.Items.Clear();

            // Récupérer toutes les voitures du catalogue
            List<Voiture> voitures = gestionVoitures.ObtenirVoitures();

            // Ajouter chaque voiture dans la ListBox
            foreach (Voiture voiture in voitures)
            {
                listBox1.Items.Add($"{voiture.Marque} {voiture.Modele} - {voiture.Annee} - {voiture.Prix}€ - {voiture.Etat} - {voiture.Kilometrage} - {voiture.Carburant}");
            }
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            string marque = textBox6.Text;
            string modele = textBox7.Text;
            string annee = numericUpDown1.Text;
            string etat = textBox10.Text;
            int kilometrage;
            decimal prix;
            string carburant = textBox12.Text;

            // Vérifier la conversion du prix
            if (!decimal.TryParse(textBox9.Text, out prix))
            {
                MessageBox.Show("Le prix doit être un nombre valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Vérifier la conversion du kilométrage
            if (!int.TryParse(textBox11.Text, out kilometrage))
            {
                MessageBox.Show("Le kilométrage doit être un nombre entier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Appel de la méthode de suppression
            gestionVoitures.SupprimerVoiture(marque, modele, annee, prix, etat, kilometrage, carburant, listBox1);
        }
    }
}
