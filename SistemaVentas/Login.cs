﻿using CapaDatos;
using System;
using System.Windows.Forms;

namespace SistemaVentas
{
    public partial class Login : Form
    {


        public Login()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int IdUsuario = CD_Usuario.LoginUsuario(txtUsuario.Text, txtClave.Text);
            if (IdUsuario != 0)
            {
                MDIMaster frm = new MDIMaster(IdUsuario);
                frm.Show();
                this.Hide();
                frm.FormClosing += Frm_Closing;
            }
            else
            {
                MessageBox.Show("No se econtraron coincidencias del usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private void Frm_Closing(object sender, FormClosingEventArgs e)
        {
            txtUsuario.Text = "";
            txtClave.Text = "";
            txtUsuario.Focus();
            this.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
