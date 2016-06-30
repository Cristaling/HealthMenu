using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthMenu
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Creare_cont_client form = new Creare_cont_client(this);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Autentificare_client form = new Autentificare_client(this);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        public void updateDataBase()
        {
            this.subcomenziTableAdapter.Update(gooD_FOODDataSet1);
            this.meniuTableAdapter.Update(gooD_FOODDataSet1);
            this.comenziTableAdapter.Update(gooD_FOODDataSet1);
            this.clientiTableAdapter.Update(gooD_FOODDataSet1);
        }

        /*public void loadMenu()
        {
            String menuFile = Properties.Resources.meniu;
            String[] meniu = menuFile.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            int i = 6;
            GOOD_FOODDataSet.MeniuRow row; 
            while (i < meniu.Count())
            {
                row = gooD_FOODDataSet1.
                i+=6;
            }
        }*/

        public void pullDataBase()
        {
            // TODO: This line of code loads data into the 'gooD_FOODDataSet1.Subcomenzi' table. You can move, or remove it, as needed.
            this.subcomenziTableAdapter.Fill(this.gooD_FOODDataSet1.Subcomenzi);
            // TODO: This line of code loads data into the 'gooD_FOODDataSet1.Meniu' table. You can move, or remove it, as needed.
            this.meniuTableAdapter.Fill(this.gooD_FOODDataSet1.Meniu);
            // TODO: This line of code loads data into the 'gooD_FOODDataSet1.Comenzi' table. You can move, or remove it, as needed.
            this.comenziTableAdapter.Fill(this.gooD_FOODDataSet1.Comenzi);
            // TODO: This line of code loads data into the 'gooD_FOODDataSet1.Clienti' table. You can move, or remove it, as needed.
            this.clientiTableAdapter.Fill(this.gooD_FOODDataSet1.Clienti);
        }

        public void setupAutoIncrement()
        {
            gooD_FOODDataSet1.Clienti.id_clientColumn.AutoIncrement = true;
            gooD_FOODDataSet1.Clienti.id_clientColumn.AutoIncrementSeed = gooD_FOODDataSet1.Clienti.Rows.Count;
            gooD_FOODDataSet1.Clienti.id_clientColumn.AutoIncrementStep = 1;
            gooD_FOODDataSet1.Meniu.id_produsColumn.AutoIncrement = true;
            gooD_FOODDataSet1.Meniu.id_produsColumn.AutoIncrementSeed = gooD_FOODDataSet1.Meniu.Rows.Count + 1;
            gooD_FOODDataSet1.Meniu.id_produsColumn.AutoIncrementStep = 1;
            gooD_FOODDataSet1.Subcomenzi.id_subcomandaColumn.AutoIncrement = true;
            gooD_FOODDataSet1.Subcomenzi.id_subcomandaColumn.AutoIncrementSeed = gooD_FOODDataSet1.Subcomenzi.Rows.Count;
            gooD_FOODDataSet1.Subcomenzi.id_subcomandaColumn.AutoIncrementStep = 1;
            gooD_FOODDataSet1.Comenzi.id_comandaColumn.AutoIncrement = true;
            gooD_FOODDataSet1.Comenzi.id_comandaColumn.AutoIncrementSeed = gooD_FOODDataSet1.Comenzi.Rows.Count;
            gooD_FOODDataSet1.Comenzi.id_comandaColumn.AutoIncrementStep = 1;
        }

        public GOOD_FOODDataSet getDataBase()
        {
            return gooD_FOODDataSet1;
        }

        private void Start_Load(object sender, EventArgs e)
        {
            pullDataBase();
            setupAutoIncrement();
            //Nu putem incarca meniul de fiecare data, deoarece dupa prima folosire a programului el va exista deja in baza de date
            //Astfel, meniul trebuie introdus direct in baza de date inainte de compilare
            //loadMenu();
        }
    }
}
