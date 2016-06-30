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
    public partial class Creare_cont_client : Form
    {

        Start parent;

        public Creare_cont_client(Start form)
        {
            parent = form;
            InitializeComponent();
        }

        private void Creare_cont_client_Load(object sender, EventArgs e)
        {
            
        }

        public bool validareDate()
        {
            //PAROLA
            if (textBox4.Text != textBox5.Text)
            {
                ErrorLabel.Text = "Parolele introduse sunt diferite";
                textBox4.Text = "";
                textBox5.Text = "";
            }
            //EMAIL
            String email = textBox6.Text;
            bool ok = true;
            if (!email.Contains('@'))
            {
                ok = false;
            }
            if (!email.Contains(".com") && !email.Contains(".ro") && !email.Contains(".hu") && !email.Contains(".gov") && !email.Contains(".tk") && !email.Contains(".ru"))
            {
                ok = false;
            }
            if (!ok)
            {
                ErrorLabel.Text = "Adresa de email nu este valida";
            }
            else
            {
                GOOD_FOODDataSet dataB = parent.getDataBase();
                foreach (GOOD_FOODDataSet.ClientiRow row in dataB.Clienti.Rows)
                {
                    if (row.email == email)
                    {
                        ok = false;
                        ErrorLabel.Text = "Adresa de email exista deja in baza de date";
                    }
                }
            }
            return ok;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validareDate())
            {
                GOOD_FOODDataSet dataB = parent.getDataBase();
                GOOD_FOODDataSet.ClientiRow client = dataB.Clienti.NewClientiRow();
                client.nume = textBox1.Text;
                client.prenume = textBox2.Text;
                client.adresa = textBox3.Text;
                client.parola = textBox4.Text;
                client.email = textBox6.Text;
                client.kcal_zilnice = 2000;
                dataB.Clienti.Rows.Add(client);
                parent.updateDataBase();
                this.Close();
            }
        }
    }
}
