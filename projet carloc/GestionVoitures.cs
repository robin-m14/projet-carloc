using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Text.Json;
using GestionVoituresApp;

namespace GestionVoituresApp // Un nom unique pour éviter le conflit
{
    public class GestionVoitures // Assurez-vous que c'est bien une classe
    {
        private List<Voiture> voitures = new List<Voiture>();
        private string filePath = "voitures.json";

        public GestionVoitures()
        {
            ChargerVoitures();
        }

        private void ChargerVoitures()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                voitures = JsonSerializer.Deserialize<List<Voiture>>(json) ?? new List<Voiture>();
            }
        }

        public void AjouterVoiture(string marque, string modele, string annee, decimal prix, string etat, int kilometrage, string carburant)
        {
            Voiture voiture = new Voiture
            {
                Marque = marque,
                Modele = modele,
                Annee = annee,
                Etat = etat,
                Prix = prix,
                Kilometrage = kilometrage,
                Carburant = carburant
            };

            voitures.Add(voiture);
            SauvegarderVoitures();
            Console.WriteLine("Voiture ajoutée avec succès !");
        }

        private void SauvegarderVoitures()
        {
            string json = JsonSerializer.Serialize(voitures, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }
        public List<Voiture> ObtenirVoitures()
{
            return voitures; // Assurez-vous que "listeVoitures" est bien la liste contenant les voitures ajoutées
}
        public void SupprimerVoiture(string marque, string modele, string annee, decimal prix, string etat, int kilometrage, string carburant, ListBox listBox)
        {
            if (voitures == null || !voitures.Any())
            {
                MessageBox.Show("Aucune voiture à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 🔹 Afficher la liste des voitures avant suppression
            Console.WriteLine("🔍 Liste actuelle des voitures AVANT suppression :");
            foreach (var voiture in voitures)
            {
                Console.WriteLine($"{voiture.Marque} {voiture.Modele} {voiture.Annee} {voiture.Prix} {voiture.Etat} {voiture.Kilometrage} {voiture.Carburant}");
            }

            // 🔹 Rechercher la voiture à supprimer
            Voiture voitureASupprimer = voitures.FirstOrDefault(v =>
                string.Equals(v.Marque, marque, StringComparison.OrdinalIgnoreCase) &&
                string.Equals(v.Modele, modele, StringComparison.OrdinalIgnoreCase) &&
                string.Equals(v.Annee, annee, StringComparison.OrdinalIgnoreCase) &&
                v.Prix == prix &&
                string.Equals(v.Etat, etat, StringComparison.OrdinalIgnoreCase) &&
                v.Kilometrage == kilometrage &&
                string.Equals(v.Carburant, carburant, StringComparison.OrdinalIgnoreCase));

            if (voitureASupprimer != null)
            {
                voitures.Remove(voitureASupprimer);
                MessageBox.Show("Voiture supprimée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("❌ Aucune voiture trouvée avec ces critères.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // 🔹 Mettre à jour la ListBox
            listBox.Items.Clear();
            foreach (var voiture in voitures)
            {
                listBox.Items.Add($"{voiture.Marque} {voiture.Modele} - {voiture.Annee} - {voiture.Prix}€ - {voiture.Etat} - {voiture.Kilometrage} - {voiture.Carburant}");
            }

            // 🔹 Vérifier la liste après suppression
            Console.WriteLine("📌 Liste des voitures APRÈS suppression :");
            foreach (var voiture in voitures)
            {
                Console.WriteLine($"{voiture.Marque} {voiture.Modele} {voiture.Annee} {voiture.Prix} {voiture.Etat} {voiture.Kilometrage} {voiture.Carburant}");
            }
        }

    }
}
