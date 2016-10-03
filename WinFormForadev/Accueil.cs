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

            // TODO Methode bas de page

            //Appel de la liste créé dans la classe d'accés aux données
            List<Rubrique> listeRubriques = DAOPrincipale.GetRubriques();

            //Alimentation du bindingsource avec la liste créé par la méthode GetRubriques()
            BindingSource bsRubriques = new BindingSource();
            bsRubriques.DataSource = listeRubriques;
            //Affectation de la combobox
            cbxListeRubriques.DataSource = bsRubriques.DataSource;
            cbxListeRubriques.DataSource = listeRubriques;
            cbxListeRubriques.DisplayMember = "NOM_RUBRIQUE";

        }

        //private void cbxListeRubriques_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    string rubriqueChoisie = (string)cbxListeRubriques.SelectedItem;

        //    List<Sujet> listeSujets = DAOPrincipale.GetSujets();
        //    BindingSource bsSujets = new BindingSource();
        //    bsSujets.DataSource = listeSujets;
        //    dgvSujets.DataSource = bsSujets.DataSource;
        //    dgvSujets.DataSource = listeSujets;

        //}
    }
}
