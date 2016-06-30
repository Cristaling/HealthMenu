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
    public partial class Autentificare_client : Form
    {

        Start parent;

        public Autentificare_client(Start form)
        {
            parent = form;
            InitializeComponent();
        }

        public int validareDate()
        {
            GOOD_FOODDataSet dataB = parent.getDataBase();
            foreach(GOOD_FOODDataSet.ClientiRow row in dataB.Clienti.Rows){
                if (row.email == textBox1.Text && row.parola == textBox2.Text)
                {
                    return row.id_client;
                }
            }
            ErrorLabel.Text = "Eroare autentificare!";
            return -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int userID = validareDate();
            if (userID >= 0)
            {
                Optiuni form = new Optiuni(parent, userID);
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
        }
    }
}
