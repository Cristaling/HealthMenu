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
    public partial class Optiuni : Form
    {

        Start parent;
        int userID;
        GOOD_FOODDataSet.ClientiRow client;

        public Optiuni(Start form, int id)
        {
            parent = form;
            userID = id;
            InitializeComponent();
        }

        public void fetchUserData()
        {
            GOOD_FOODDataSet dataB = parent.getDataBase();
            foreach (GOOD_FOODDataSet.ClientiRow row in dataB.Clienti.Rows)
            {
                if (row.id_client == userID)
                {
                    client = row;
                    return;
                }
            }
        }

        public void fillComanda()
        {
            GOOD_FOODDataSet dataB = parent.getDataBase();
            foreach (GOOD_FOODDataSet.MeniuRow mrow in dataB.Meniu)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(Comanda_GridView);
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (row.Cells.IndexOf(cell) == 0)
                    {
                        cell.Value = mrow.id_produs;
                    }
                    else if (row.Cells.IndexOf(cell) == 1)
                    {
                        cell.Value = mrow.denumire_produs;
                    }
                    else if (row.Cells.IndexOf(cell) == 2)
                    {
                        cell.Value = mrow.denumire_produs;
                    }
                    else if (row.Cells.IndexOf(cell) == 3)
                    {
                        cell.Value = mrow.pret;
                    }
                    else if (row.Cells.IndexOf(cell) == 4)
                    {
                        cell.Value = mrow.kcal;
                    }
                    else if (row.Cells.IndexOf(cell) == 5)
                    {
                        cell.Value = mrow.felul;
                    }
                    else if (row.Cells.IndexOf(cell) == 6)
                    {
                        cell.Value = "1";
                    }
                    else if (row.Cells.IndexOf(cell) == 7)
                    {
                        cell.Value = "Adauga";
                    }
                }
                Comanda_GridView.Rows.Add(row);
            }
        }

        private void Optiuni_Load(object sender, EventArgs e)
        {
            fetchUserData();
            GenMeniu_text1.Text = client.kcal_zilnice.ToString();
            Comanda_text1.Text = client.kcal_zilnice.ToString();
            fillComanda();
            GrafTimer.Start();
        }

        private void CalcKcal_button1_Click(object sender, EventArgs e)
        {
            try
            {
                int varsta = Convert.ToInt32(CalcKcal_text1.Text);
                int inaltime = Convert.ToInt32(CalcKcal_text2.Text);
                int greutate = Convert.ToInt32(CalcKcal_text3.Text);
                varsta += inaltime;
                varsta += greutate;
                int Kcal;
                if (varsta < 250)
                {
                    Kcal = 1800;
                }
                else if (varsta > 275)
                {
                    Kcal = 2500;
                }
                else
                {
                    Kcal = 2200;
                }
                CalcKcal_text4.Text = Kcal.ToString();
                client.kcal_zilnice = Kcal;
                GenMeniu_text1.Text = client.kcal_zilnice.ToString();
                Comanda_text1.Text = client.kcal_zilnice.ToString();
                parent.updateDataBase();
                CalcKcal_ErrorLabel.Text = "";
            }
            catch (Exception ex)
            {
                CalcKcal_ErrorLabel.Text = "Datele introduse nu sunt valide";
            }
        }

        private void GenMeniu_button1_Click(object sender, EventArgs e)
        {
            int Kcal = client.kcal_zilnice;
            int buget = Convert.ToInt32(GenMeniu_text2.Text);
            GOOD_FOODDataSet dataB = parent.getDataBase();
            List<GOOD_FOODDataSet.MeniuRow> feluri1 = new List<GOOD_FOODDataSet.MeniuRow>();
            List<GOOD_FOODDataSet.MeniuRow> feluri2 = new List<GOOD_FOODDataSet.MeniuRow>();
            List<GOOD_FOODDataSet.MeniuRow> feluri3 = new List<GOOD_FOODDataSet.MeniuRow>();
            foreach (GOOD_FOODDataSet.MeniuRow row in dataB.Meniu.Rows)
            {
                if (row.felul == 1)
                {
                    feluri1.Add(row);
                }
                else if (row.felul == 2)
                {
                    feluri2.Add(row);
                }
                else if (row.felul == 3)
                {
                    feluri3.Add(row);
                }
            }
            int cost;
            int KcalCost;
            //Console.WriteLine("Generating Menu");
            foreach (GOOD_FOODDataSet.MeniuRow fel1 in feluri1)
            {
                foreach (GOOD_FOODDataSet.MeniuRow fel2 in feluri2)
                {
                    foreach (GOOD_FOODDataSet.MeniuRow fel3 in feluri3)
                    {
                        cost = fel1.pret + fel2.pret + fel3.pret;
                        KcalCost = fel1.kcal + fel2.kcal + fel3.kcal;
                        if (cost <= buget && KcalCost <= Kcal)
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(GenMeniu_GridView);
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                if (row.Cells.IndexOf(cell) == 0)
                                {
                                    cell.Value = fel1.denumire_produs;
                                }
                                else if (row.Cells.IndexOf(cell) == 1)
                                {
                                    cell.Value = fel2.denumire_produs;
                                }
                                else if (row.Cells.IndexOf(cell) == 2)
                                {
                                    cell.Value = fel3.denumire_produs;
                                }
                                else if (row.Cells.IndexOf(cell) == 3)
                                {
                                    cell.Value = KcalCost.ToString();
                                }
                                else if (row.Cells.IndexOf(cell) == 4)
                                {
                                    cell.Value = cost.ToString();
                                }
                            }
                            GenMeniu_GridView.Rows.Add(row);
                        }
                    }
                }
            }
        }

        private void GenMeniu_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                DataGridViewRow row = null;
                foreach (DataGridViewRow r in GenMeniu_GridView.Rows)
                {
                    if (GenMeniu_GridView.Rows.IndexOf(r) == e.RowIndex)
                    {
                        row = r;
                        break;
                    }
                }
                String fel1 = "";
                String fel2 = "";
                String fel3 = "";
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (row.Cells.IndexOf(cell) == 0)
                    {
                        fel1 = cell.Value.ToString();
                    }
                    else if (row.Cells.IndexOf(cell) == 1)
                    {
                        fel2 = cell.Value.ToString();
                    }
                    else if (row.Cells.IndexOf(cell) == 2)
                    {
                        fel3 = cell.Value.ToString();
                    }
                }
                int idProd1 = 1;
                int idProd2 = 2;
                int idProd3 = 3;
                GOOD_FOODDataSet dataB = parent.getDataBase();
                foreach(GOOD_FOODDataSet.MeniuRow mr in dataB.Meniu){
                    if(mr.denumire_produs == fel1){
                        idProd1 = mr.id_produs;
                    }
                    if(mr.denumire_produs == fel2){
                        idProd2 = mr.id_produs;
                    }
                    if(mr.denumire_produs == fel3){
                        idProd3 = mr.id_produs;
                    }
                }
                GOOD_FOODDataSet.ComenziRow crow = dataB.Comenzi.NewComenziRow();
                crow.id_client = userID;
                crow.data_comanda = new DateTime();
                GOOD_FOODDataSet.SubcomenziRow scrow = dataB.Subcomenzi.NewSubcomenziRow();
                scrow.cantitate = 1;
                scrow.id_produs = idProd1;
                scrow.id_comanda = crow.id_comanda;
                dataB.Subcomenzi.Rows.Add(scrow);
                scrow = dataB.Subcomenzi.NewSubcomenziRow();
                scrow.cantitate = 1;
                scrow.id_produs = idProd2;
                scrow.id_comanda = crow.id_comanda;
                dataB.Subcomenzi.Rows.Add(scrow);
                scrow = dataB.Subcomenzi.NewSubcomenziRow();
                scrow.cantitate = 1;
                scrow.id_produs = idProd3;
                scrow.id_comanda = crow.id_comanda;
                dataB.Subcomenzi.Rows.Add(scrow);
                dataB.Comenzi.Rows.Add(crow);
                parent.updateDataBase();
                MessageBox.Show("Comanda trimisa!");
                this.Close();
            }
        }

        Dictionary<int, int> comanda = new Dictionary<int, int>();
        Dictionary<int, int> comandaKcal = new Dictionary<int, int>();

        private void Comanda_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                DataGridViewRow row = null;
                foreach (DataGridViewRow r in Comanda_GridView.Rows)
                {
                    if (Comanda_GridView.Rows.IndexOf(r) == e.RowIndex)
                    {
                        row = r;
                        break;
                    }
                }
                int IDProdus = 0;
                int cantitate = 1;
                int pret = 0;
                int Kcal = 0;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (row.Cells.IndexOf(cell) == 0)
                    {
                        IDProdus = Convert.ToInt32(cell.Value.ToString());
                    }
                    else if (row.Cells.IndexOf(cell) == 3)
                    {
                        pret = Convert.ToInt32(cell.Value.ToString());
                    }
                    else if (row.Cells.IndexOf(cell) == 4)
                    {
                        Kcal = Convert.ToInt32(cell.Value.ToString());
                    }
                    else if (row.Cells.IndexOf(cell) == 6)
                    {
                        cantitate = Convert.ToInt32(cell.Value.ToString());
                    }
                }
                if (cantitate < 0)
                {
                    MessageBox.Show("Cantitate negativa");
                    return;
                }
                int totKcal = Convert.ToInt32(Comanda_text2.Text);
                int totPret = Convert.ToInt32(Comanda_text3.Text);
                totKcal += Kcal * cantitate;
                totPret += pret * cantitate;
                Comanda_text2.Text = totKcal.ToString();
                Comanda_text3.Text = totPret.ToString();
                comanda.Add(IDProdus, cantitate);
                comandaKcal.Add(IDProdus, Kcal);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int totKcal = Convert.ToInt32(Comanda_text2.Text);
            int totPret = Convert.ToInt32(Comanda_text3.Text);
            int nec = Convert.ToInt32(Comanda_text1.Text);
            Vizualizare_Comanda form = new Vizualizare_Comanda(parent, comanda, totPret, totKcal, nec, userID);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void GrafTimer_Tick(object sender, EventArgs e)
        {
            Bitmap frame = new Bitmap(panel1.Width, panel1.Height);
            using (Graphics gr = Graphics.FromImage(frame))
            {
                gr.Clear(Color.White);
                int actWid = frame.Width - 100;
                int actHei = frame.Height - 100;
                int maxVal = 1;
                Font font = new Font(FontFamily.Families[0], 12); 
                foreach (int val in comandaKcal.Keys)
                {
                    int val1;
                    int val2;
                    comandaKcal.TryGetValue(val, out val1);
                    comanda.TryGetValue(val, out val2);
                    if (val1 * val2 > maxVal)
                    {
                        maxVal = val1 * val2;
                    }
                }
                double scaleH = (double)actHei / (double)maxVal;
                double scaleW = (double)actWid / (double)comanda.Count;
                scaleH *= 100;
                //Console.WriteLine("{0} + {1} + {2}", actHei, scaleH, maxVal);
                int c = -1;
                GOOD_FOODDataSet dataB = parent.getDataBase();
                foreach (GOOD_FOODDataSet.MeniuRow row in dataB.Meniu.Rows)
                {
                    if (comanda.Keys.Contains(row.id_produs))
                    {
                        c++;
                        int val1;
                        int val2;
                        comandaKcal.TryGetValue(row.id_produs, out val1);
                        comanda.TryGetValue(row.id_produs, out val2);
                        val1 *= val2;
                        Color cc = Color.Red;
                        if (c % 2 == 1)
                        {
                            cc = Color.Blue;
                        }
                        Rectangle toFill = new Rectangle((int)(50 + c * scaleW), (int)(actHei - val1 * scaleH / 100), (int)(scaleW), (int)(val1 * scaleH / 100));
                        gr.FillRectangle(new SolidBrush(cc), toFill);
                        gr.DrawString(row.denumire_produs, font, new SolidBrush(Color.Black), new Point((int)(50 + c * scaleW), actHei + 5 + ((c % 2) * 15)));
                    }
                }
                /*foreach (int val in comandaKcal.Keys)
                {
                    c++;
                    int val1;
                    int val2;
                    comandaKcal.TryGetValue(val, out val1);
                    comanda.TryGetValue(val, out val2);
                    val1 *= val2;
                    Color cc = Color.Red;
                    if (c % 2 == 1)
                    {
                        cc = Color.Blue;
                    }
                    Rectangle toFill = new Rectangle((int)(50 + c * scaleW), (int)(actHei - val1 * scaleH / 100), (int)(scaleW), (int)(val1 * scaleH / 100));
                    gr.FillRectangle(new SolidBrush(cc), toFill);
                }*/

                gr.DrawLine(new Pen(Color.Black) ,new Point(49, 0), new Point(49, actHei + 5));
                gr.DrawLine(new Pen(Color.Black), new Point(45 + 1, actHei + 1), new Point(actWid + 50, actHei + 1));
                for (int i = 0; i <= actHei; i+=(int)scaleH)
                {
                    int val = (int)(((double)i / scaleH) * 100);
                    if (val % 100 > 50)
                    {
                        val /= 100;
                        val++;
                        val *= 100;
                    }
                    gr.DrawString(val.ToString(), font, new SolidBrush(Color.Black), new Point(10, actHei - i));
                    gr.DrawLine(new Pen(Color.Black), new Point(45 + 1, actHei - i), new Point(actWid + 50, actHei - i));
                }
            }
            using (Graphics gr = panel1.CreateGraphics())
            {
                gr.DrawImage(frame, Point.Empty);
            }
        }

    }
}
