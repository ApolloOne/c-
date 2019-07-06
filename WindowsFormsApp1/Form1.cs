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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            KetNoiSQL();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DELL\SQLEXPRESS;Initial Catalog=test;Integrated Security=True");
        private void KetNoiSQL() {
            con.Open();
            Console.WriteLine("Opend Database");
            SqlCommand command = new SqlCommand("Select MaKhachHang from KhachHang ;",con);
            Console.WriteLine(command.ExecuteScalar());
            con.Close();
            Console.WriteLine("Closed Database");
        }
    }
}
