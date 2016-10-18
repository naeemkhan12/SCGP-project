using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;

namespace Login
{
    public partial class TeacherEdit : DevExpress.XtraEditors.XtraUserControl
    {
        private String tName = null , fName = null, addr = null , qualf = null ;

        private System.Text.RegularExpressions.Regex e_mail = new System.Text.RegularExpressions.Regex("[a-b 0-9]+@namal.edu.pk");
        private System.Text.RegularExpressions.Regex field = new System.Text.RegularExpressions.Regex("B.Sc | BEng [a-z A-Z]+");
        private System.Text.RegularExpressions.Regex contact_no = new System.Text.RegularExpressions.Regex(" 03[0-4][0-9]-[0-9]{7}");
      //  private System.Text.RegularExpressions.Regex uob = new System.Text.RegularExpressions.Regex("[0-9]{8}");

     //   private short year;
        static String connectionString = "Server=localhost; Database=segp; Uid=root; pwd=";
        MySqlConnection conn = new MySqlConnection(connectionString);
        String ss = "select * from Students where Year='Year-1'";


        public Boolean isValidInput(String email, String field, String cntct, String uob)
        {
            if (this.e_mail.IsMatch(email) && this.field.IsMatch(field) && this.contact_no.IsMatch(cntct))
            {

                return true;
            }
            return false;
        }



        public TeacherEdit()
        {
            InitializeComponent();
        }

        private void StudentEdit_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Red;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.White;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
            button1.BackColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
            button1.BackColor = Color.DarkGreen;
        }
    }
}
