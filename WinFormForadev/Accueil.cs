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

            // TODO Methode

            List<Rubrique> listeRubriques = DAOPrincipale.GetRubriques();

            BindingSource bsRubriques = new BindingSource();
            bsRubriques.DataSource = listeRubriques;
            cbxListeRubriques.DataSource = bsRubriques.DataSource;
            cbxListeRubriques.DataSource = listeRubriques;
            cbxListeRubriques.DisplayMember = "NOM_RUBRIQUE";

        }
    }
}
