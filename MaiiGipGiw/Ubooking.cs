using Cassandra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaiiGipGiw
{
    public partial class Ubooking : Form
    {
        public Ubooking()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           /* try
            {

                Cluster cluster = Cluster.Builder().AddContactPoint("127.0.0.1").Build(); //connect server
                ISession session = cluster.Connect("maii"); //connect to database
                session.Execute("insert into test (id,firstname,lastname) values ('000035', 'Austin', 'Bob')"); //insert
                MessageBox.Show("Ok");
            }
            catch (Exception c)
            {
                MessageBox.Show("not");
            }*/
        }
    }
}
