using System;
using System.Collections.Generic;
using System.Text;

namespace projetppe.Modele
{
    public class Personnel
    {
        private int id;
        private string nom;
        private string prenom;
        private DateTime datedebut;
        private DateTime datefin;
        private string role;
        private bool suspendu;

        public int Id { get => id; }
        public string Nom { get => nom; set => nom = value; }

        public string Prenom { get => prenom; set => prenom = value; }
        public DateTime DateDebut { get => datedebut; set => datedebut = value; }
        public DateTime DateFin { get => datefin; set => datefin = value; }

        public string Role { get => Role; set => Role = value; }

        public bool Suspendu { get => suspendu; set => suspendu = value; }
        public Personnel(int id, string nom, string prenom, DateTime datedebut, DateTime datefin, string role, bool suspendu )
        {
            this.nom = nom;
            this.prenom = prenom;
            this.id = id;
            this.datedebut = datedebut;
            this.datefin = datefin;
            this.role = role;
            this.suspendu = suspendu;
        }

        public Personnel (int id, string nom, string prenom, string role, bool suspendu)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.id = id;
            this.role = role;
            this.suspendu = suspendu;
        }
    }
}
