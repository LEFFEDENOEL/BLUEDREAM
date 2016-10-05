using DAOForadev;
using Foradev;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormForadev
{
    public partial class AccueilForum : Form
    {
        public AccueilForum()
        {
            InitializeComponent();

            //Appel de la liste créé dans la classe d'accés aux données
            List<Rubrique> listeRubriques = DAOPrincipale.GetRubriques();

            //Alimentation du bindingsource avec la liste créé par la méthode GetRubriques()
            BindingSource bsRubriques = new BindingSource();
            bsRubriques.DataSource = listeRubriques;

            //Affectation de la combobox Rubriques
            cbxListeRubriques.DataSource = bsRubriques.DataSource;
            cbxListeRubriques.DataSource = listeRubriques;
            cbxListeRubriques.DisplayMember = "NOM_RUBRIQUE";
        }

        /// <summary>
        /// Méthode qui charge le datagridview Sujets sur sélection combobox Rubriques
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxListeRubriques_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Appel de la liste créé dans dans la classe d'accés aux données            
            List<Sujet> listeSujets = DAOPrincipale.GetSujetsByRubrique(cbxListeRubriques.SelectedValue.ToString());
            //Alimentation du bindingsource avec la liste créé
            BindingSource bsSujets = new BindingSource();
            //Affectation et paramétrage du datagridview         
            bsSujets.DataSource = listeSujets;
            dgvSujets.DataSource = bsSujets.DataSource;
            dgvSujets.Columns[0].Visible = false;

            dgvSujets.Columns[1].HeaderText = "Pseudo";
            dgvSujets.Columns[1].Width = 125;
            dgvSujets.Columns[2].HeaderText = "Titre";
            dgvSujets.Columns[2].Width = 125;
            dgvSujets.Columns[3].HeaderText = "Date";
            dgvSujets.Columns[3].Width = 100;
            dgvSujets.Columns[4].HeaderText = "Texte";

            string idSujet = dgvSujets.CurrentRow.Cells[0].Value.ToString();

        }


    }
}
