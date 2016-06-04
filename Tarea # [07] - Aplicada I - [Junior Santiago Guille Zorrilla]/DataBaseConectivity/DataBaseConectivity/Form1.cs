using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DataBaseConectivity
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Ventas1;Data Source=JR\SQLEXPRESS");
            /*SE PONE @ PORQUE LA BASE DE DATO SE LLAMA JR\SQLEXPRESS..Entoces tiene '\' 
            y para que lo acepte  se le pone @..*/
            try
            {
                con.Open();
                statuslbl.Text = "Conexion Realizada";

                SqlCommand cmd = con.CreateCommand();

                cmd.CommandText = "Insert into TestTable([Name] , [Age] ,[Gender], [Email] , [Password]) values ('"+nameTxtbox.Text+"','"+ageTxtbox.Text+"','"+genderTxtbox.Text+"','"+EmailTxtbox.Text+ "','"+PasswordTxtbox.Text+"')";
                try
                {
                 
                    cmd.ExecuteNonQuery();


                    statuslbl.Text = "Guardado exitoso";
                }catch(Exception)
                {
                    statuslbl.Text = "Querry executon error";

                }
              

                 }
             catch (Exception)
                    {
                      statuslbl.Text = ("La conexion no se realizo");
                 
                    }

        }
    }
}
