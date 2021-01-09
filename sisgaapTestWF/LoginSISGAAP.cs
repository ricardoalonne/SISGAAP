using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sisgaapCoreWF.Controllers;
using System.Data.SqlClient;
using sisgaapCore.Entities;
using sisgaapCore;
using System.Runtime.InteropServices;

namespace sisgaapTestWF
{
    public partial class LoginSISGAAP : Form
    {
        public LoginSISGAAP()
        {
            InitializeComponent();
        }

        UsuarioCtr Usuario_Ctr = new UsuarioCtr();
        Usuario usuario = new Usuario();

        RolCtr Rol_Ctr = new RolCtr();
        Rol rol = new Rol();

        PersonalCtr Personal_Ctr = new PersonalCtr();
        Personal personal = new Personal();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void textBox_usuario_Enter(object sender, EventArgs e)
        {
            if (textBox_usuario.Text == "USUARIO")
            {
                textBox_usuario.Text = "";
                textBox_usuario.ForeColor = Color.LightGray;
            }
        }

        private void textBox_usuario_Leave(object sender, EventArgs e)
        {
            if (textBox_usuario.Text == "")
            {
                textBox_usuario.Text = "USUARIO";
                textBox_usuario.ForeColor = Color.FromArgb(247,247,247);
            }
        }

        private void textBox_contraseña_Enter(object sender, EventArgs e)
        {
            if (textBox_contraseña.Text == "CONTRASEÑA")
            {
                textBox_contraseña.Text = "";
                textBox_contraseña.ForeColor = Color.LightGray;
                textBox_contraseña.UseSystemPasswordChar = true;
            }
        }

        private void textBox_contraseña_Leave(object sender, EventArgs e)
        {
            if (textBox_contraseña.Text == "")
            {
                textBox_contraseña.Text = "CONTRASEÑA";
                textBox_contraseña.ForeColor = Color.FromArgb(247, 247, 247);
                textBox_contraseña.UseSystemPasswordChar = false;
            }
        }

        private void button_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginSISGAAP_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel_login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button_iniciar_sesion_Click(object sender, EventArgs e)
        {
            if (textBox_usuario.Text == "" || textBox_contraseña.Text == "")
            {
                MessageBox.Show("ERROR!! ESPACIOS EN BLANCO!!");
                return;
            }
            string s = textBox_usuario.Text;
            string[] separando = s.Split('_');
            if (separando[0] == "SA")
            {
                SupervisorAlmacen sa = new SupervisorAlmacen();
                usuario.codigoUsuario = textBox_usuario.Text;
                usuario.password = textBox_contraseña.Text;
                Usuario_Ctr.CargarUsuario(usuario);
                rol.numeroRol = usuario.numeroRol;
                Rol_Ctr.CargarRol(rol);
                sa.labelrol.Text = rol.nombreRol;
                personal.codigoUsuario = usuario.codigoUsuario;
                Personal_Ctr.CargarPersonal(personal);
                sa.labelnombre.Text = personal.nombres;
                sa.labelapellido.Text = personal.apellidos;
                sa.labelcorreo.Text = personal.correo;
                sa.Show();
                this.Visible=false;
            }
            else if(separando[0] == "SP")
            {
                SupervisorProduccion sa = new SupervisorProduccion();
                usuario.codigoUsuario = textBox_usuario.Text;
                usuario.password = textBox_contraseña.Text;
                Usuario_Ctr.CargarUsuario(usuario);
                rol.numeroRol = usuario.numeroRol;
                Rol_Ctr.CargarRol(rol);
                sa.labelrol.Text = rol.nombreRol;
                personal.codigoUsuario = usuario.codigoUsuario;
                Personal_Ctr.CargarPersonal(personal);
                sa.labelnombre.Text = personal.nombres;
                sa.labelapellido.Text = personal.apellidos;
                sa.labelcorreo.Text = personal.correo;
                sa.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("ERROR!! DATOS INCORRECTOS");
                return;
            }
        }
    }
}
