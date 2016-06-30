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
    public partial class Vizualizare_Comanda : Form
    {

        Start parent;
        Dictionary<int, int> comanda;
        int totPret;
        int totKcal;
        int necesar;
        int IDClient;

        public Vizualizare_Comanda(Start form, Dictionary<int, int> dic, int pretT, int KcalT, int nec, int IDC)
        {
            parent = form;
            comanda = dic;
            totPret = pretT;
            totKcal = KcalT;
            necesar = nec;
            IDClient = IDC;
            InitializeComponent();
        }

        public void fillComanda()
        {
            GOOD_FOODDataSet dataB = parent.getDataBase();
            foreach (GOOD_FOODDataSet.MeniuRow mrow in dataB.Meniu)
            {
                if (comanda.Keys.Contains(mrow.id_produs))
                {
                    int cantitate;
                    comanda.TryGetValue(mrow.id_produs, out cantitate);
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(Comanda_DataGridView);
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (row.Cells.IndexOf(cell) == 0)
                        {
                            cell.Value = mrow.denumire_produs;
                        }
                        else if (row.Cells.IndexOf(cell) == 1)
                        {
                            cell.Value = mrow.kcal;
                        }
                        else if (row.Cells.IndexOf(cell) == 2)
                        {
                            cell.Value = mrow.pret;
                        }
                        else if (row.Cells.IndexOf(cell) == 3)
                        {
                            cell.Value = cantitate;
                        }
                        else if (row.Cells.IndexOf(cell) == 4)
                        {
                            cell.Value = "Elimina";
                        }
                    }
                    Comanda_DataGridView.Rows.Add(row);
                }
            }
        }

        private void Vizualizare_Comanda_Load(object sender, EventArgs e)
        {
            fillComanda();
            Comanda_text1.Text = necesar.ToString();
            Comanda_text2.Text = totKcal.ToString();
            Comanda_text3.Text = totPret.ToString();
        }

        private void Comanda_DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                DataGridViewRow row = null;
                foreach (DataGridViewRow r in Comanda_DataGridView.Rows)
                {
                    if (Comanda_DataGridView.Rows.IndexOf(r) == e.RowIndex)
                    {
                        row = r;
                        break;
                    }
                }
                int cantitate = 1;
                int pret = 0;
                int Kcal = 0;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (row.Cells.IndexOf(cell) == 1)
                    {
                        Kcal = Convert.ToInt32(cell.Value.ToString());
                    }
                    else if (row.Cells.IndexOf(cell) == 2)
                    {
                        pret = Convert.ToInt32(cell.Value.ToString());
                    }
                    else if (row.Cells.IndexOf(cell) == 3)
                    {
                        cantitate = Convert.ToInt32(cell.Value.ToString());
                    }
                }
                totKcal = Convert.ToInt32(Comanda_text2.Text);
                totPret = Convert.ToInt32(Comanda_text3.Text);
                totKcal -= Kcal * cantitate;
                totPret -= pret * cantitate;
                Comanda_text2.Text = totKcal.ToString();
                Comanda_text3.Text = totPret.ToString();
                Comanda_DataGridView.Rows.Remove(row);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GOOD_FOODDataSet dataB = parent.getDataBase();
            GOOD_FOODDataSet.ComenziRow crow = dataB.Comenzi.NewComenziRow();
            crow.id_client = IDClient;
            crow.data_comanda = new DateTime();
            GOOD_FOODDataSet.SubcomenziRow scrow;
            foreach (DataGridViewRow r in Comanda_DataGridView.Rows)
            {
                int cantitate = 1;
                int IDProdus = 0;
                foreach (DataGridViewCell cell in r.Cells)
                {
                    if (r.Cells.IndexOf(cell) == 0)
                    {
                        foreach (GOOD_FOODDataSet.MeniuRow mr in dataB.Meniu)
                        {
                            if (mr.denumire_produs == cell.Value)
                            {
                                IDProdus = mr.id_produs;
                            }
                        }
                    }
                    else if (r.Cells.IndexOf(cell) == 3)
                    {
                        cantitate = Convert.ToInt32(cell.Value.ToString());
                    }
                }
                scrow = dataB.Subcomenzi.NewSubcomenziRow();
                scrow.cantitate = cantitate;
                scrow.id_produs = IDProdus;
                scrow.id_comanda = crow.id_comanda;
                dataB.Subcomenzi.Rows.Add(scrow);
            }
            dataB.Comenzi.Rows.Add(crow);
            parent.updateDataBase();
            MessageBox.Show("Comanda trimisa!");
            this.Close();
        }
    }
}
