using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana7_Acceso_base_datos
{
    public partial class login : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=JOSEREYES;Initial Catalog=login;Integrated Security=True");
        OleDbConnection conexion_access = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source =C:\Base de Datos\login.mdb;Persist Security Info=False;");
        MySqlConnection conn = new MySqlConnection("Server=localhost; Database=login; Uid=jose; Pwd=12345");

        public login()
        {
            InitializeComponent();
        }

 
        private void login_Load(object sender, EventArgs e)
        {

        }

       //BOTON DE SQL SERVER

        private void bentrar_sqlserver_Click_Click(object sender, EventArgs e)
        {
            {
                try
                {
         
                   
                    conexion.Open();
                    SqlCommand consulta = new SqlCommand("select usuario, clave from usuarios where usuario = '" + txtusuario + "'And clave = '" + txtclave.Text + "' ", conexion); 
                    
                    consulta.ExecuteNonQuery();
                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(consulta);

                    da.Fill(ds, "usuarios");

                  
                    DataRow registro;
                    registro = ds.Tables["usuarios"].Rows[0];

                   
                    if ((txtusuario.Text == registro["usuarios"].ToString()) || (txtclave.Text ==
                    registro["clave"].ToString()))
                    {
                        MessageBox.Show("    BIENVENIDO AL INICIO DE SQLSERVER   ");
                        sqlserver fm = new sqlserver();
                        fm.Show();
                       
                    }
                }
             
                catch
                {
                  
                    MessageBox.Show("Error de usuario o clave de acceso", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }


        }





        //
        //
        //BOTON DE MYSQL

        private void bentrar_mysql_Click_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlCommand Pedir = new MySqlCommand("Select Nombre, Clave, CORREO from usuarios where Nombre = '" + txtusuario.Text + "'And clave = '" + txtclave.Text + "'", conn);
                Pedir.ExecuteNonQuery();
                DataSet fe = new DataSet();
                MySqlDataAdapter te = new MySqlDataAdapter(Pedir);

                te.Fill(fe, "usuarios");

                DataRow res;
                res = fe.Tables["usuarios"].Rows[0];

                if ((txtusuario.Text == res["Nombre"].ToString()) || (txtclave.Text == res["Clave"].ToString()))
                {
                    MessageBox.Show("    BIENVENIDO AL INICIO DE MYSQL   ");
                    mysql fprincipal = new mysql();
                    fprincipal.Show();
                  

                }

            }
            catch
            {


              

                MessageBox.Show("Error de usuario o clave de acceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }







        //
        //
        //BOTON DE SALIR
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("   ¿ESTAS SEGURO QUE QUIERES SALIR?   ");
            Application.Exit();
        }




        //
        //
        //BOTON DE ACCESS

        private void bentrar_access_Click_Click(object sender, EventArgs e)
        {
            try
            {
              
                conexion_access.Open();

                //Consulta a tabla de usuarios en la base de datos
                //Para encontrar fila que tiene los datos del usuario y clave ingresados
                OleDbDataAdapter consulta = new OleDbDataAdapter("SELECT * FROM usuarios",
                conexion_access);

                //OleDbDataReader reader = command.ExecuteReader();
                DataSet resultado = new DataSet();
                consulta.Fill(resultado);

                foreach (DataRow registro in resultado.Tables[0].Rows)
                {
                    if ((txtusuario.Text == registro["nombre"].ToString()) && (txtclave.Text ==
                   registro["clave"].ToString()))
                    {
                        MessageBox.Show("    BIENVENIDO AL INICIO DE ACCESS   ");
                        access fm = new access();
                        fm.Show(); //abrir menu

                    }

                }//Cierre de ciclo for

                //Finalizando la conexión
                conexion_access.Close();

            }//Cierre de Try

            //Si la conexion falla muestra mensaje de error
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                //en caso que usuario y clave sean incorrectos mostrar mensaje de error
                MessageBox.Show("Error de usuario o clave de acceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); txtusuario.Focus();
                txtusuario.Focus();
            }
        }
    }
}


 