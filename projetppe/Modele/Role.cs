using System;
using System.Collections.Generic;
using System.Text;

namespace projetppe.Modele
{
    internal class Role
    {
        private int id;
        private string libelle;


        public int Id { get => id; }
        public string Libelle { get => libelle; set => libelle = value; }


        public Role (int id, string libelle)
        {
            this.id = id;
            this.libelle=libelle;
        }
    }
}
