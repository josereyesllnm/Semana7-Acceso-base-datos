﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana7_Acceso_base_datos
{
    public partial class login : Form
    {
     
        public login()
        {
            InitializeComponent();
        }

        public object Source { get; private set; }

        private void bentrar_access_Click_Click(object sender, EventArgs e)
        {
            try
            {
                //Creado la variable para la nueva conexion
                OleDbConnection conexion_access = new OleDbConnection();

                //Cadena de conexión para la base de datos
                //Se recomienda generar la cadena de conexion para evitar errores
                conexion_access.ConnectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source =
                C:\Base de Datos\login.mdb;Persist Security Info=False;";


                //Abriendo conexion
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
                        menu fm = new menu();
                        fm.Show(); //abrir menu
                    }

                }//Cierre de ciclo for

            }//Cierre de Try

            //Si la conexion falla muestra mensaje de error
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                //en caso que usuario y clave sean incorrectos mostrar mensaje de error
                MessageBox.Show("Error de usuario o clave de acceso", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                txtusuario.Focus();
            }

            //Finalizando la conexión
           

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}


 