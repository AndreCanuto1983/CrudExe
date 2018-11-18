using Loja.ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja.VIEW
{
    public partial class FrmBloqModulos : Form
    {
        public FrmBloqModulos()
        {
            InitializeComponent();
        }

        private void rdbGrupo_CheckedChanged(object sender, EventArgs e)
        {
            //if (rdbGrupoMod.Checked == true)
            //{
            //    txtCodGrupoG.Enabled = true;
            //    txtCodUsuarioM.Enabled = false;
            //}
        }

        private void rdbUsuario_CheckedChanged(object sender, EventArgs e)
        {
            //if (rdbUsuarioMod.Checked == true)
            //{
            //    txtCodGrupoG.Enabled = false;
            //    txtCodUsuarioM.Enabled = true;
            //}
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnC_Grupo_Click(object sender, EventArgs e)
        {
            FrmC_GrupoUsuario frmC_GrupoFunc = new FrmC_GrupoUsuario();
            frmC_GrupoFunc.ShowDialog();
        }

        private void btnC_Usuario_Click(object sender, EventArgs e)
        {
            FrmC_Usuario frmC_Usuario = new FrmC_Usuario();
            frmC_Usuario.ShowDialog();
        }

        private void PreencherModulo(C_ControleUsuarioENT c_controleUsuarioEnt)
        {
            //preencho a classe C_UsuarioENT
            //if (txtCodBloqMod.Text != "")
            //{
            //    c_controleUsuarioEnt.codigo = Convert.ToInt16(txtCodBloqMod.Text);
            //}
            //c_controleUsuarioEnt.codModulo = Convert.ToInt16(txtCodMod.Text);
            //c_controleUsuarioEnt.modulo = txtModG.Text;
            //c_controleUsuarioEnt.bloquearModulo = ckbBloqMod.Checked;
        }
        private void CarregarTela(C_ControleUsuarioENT c_controleUsuarioEnt)
        {
            //Exibo os dados na tela
            //txtCodBloqMod.Text = c_controleUsuarioEnt.codigo.ToString();
            //txtCodMod.Text = c_controleUsuarioEnt.codModulo.ToString();
            //txtModG.Text = c_controleUsuarioEnt.modulo;
            //switch (c_controleUsuarioEnt.bloquearModulo)
            //{
            //    case true:
            //        ckbBloqMod.Checked = true;
            //        break;
            //    case false:
            //        ckbBloqMod.Checked = false;
            //        break;
            //}
        }

        private void btnGravarMod_Click(object sender, EventArgs e)
        {
            //C_ControleUsuarioENT c_controleUsuarioEnt = new C_ControleUsuarioENT();
            //if (txtCodBloqMod.Text != "") //rotina para atualizar
            //{
            //    DialogResult dialogo = MessageBox.Show("Deseja realmente alterar este registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //    if (dialogo == DialogResult.Yes)
            //    {
            //        if (txtCodMod.Text == "")
            //        {
            //            MessageBox.Show("Informe o módulo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            txtCodMod.Focus();
            //        }
            //        else
            //        {
            //            string retorno = "";
            //            try
            //            {
            //                PreencherModulo(c_controleUsuarioEnt);
            //                retorno = c_usuarioBll.Atualizar(c_usuarioEnt);
            //                Convert.ToInt16(retorno);
            //                MessageBox.Show("Registro " + retorno + " alterado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                retorno = string.Empty;
            //                retorno = c_usuarioBll.CarregarGrade(grdC_Usuarios);
            //                Convert.ToInt16(retorno);
            //                txtTotal.Text = retorno;
            //            }
            //            catch
            //            {
            //                MessageBox.Show("Falha: " + retorno, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            }
            //        }
            //    }
            //    else //(dialogo == DialogResult.No)
            //    {
            //        txtCodBloqMod.Focus();
            //    }
            //}
            //else if (txtCodBloqMod.Text == "") //rotina para gravar
            //{
            //    if (txtUsuario.Text == "")
            //    {
            //        MessageBox.Show("Informe o usuário.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        txtUsuario.Focus();
            //    }
            //    else if (txtSenha.Text == "")
            //    {
            //        MessageBox.Show("Informe a senha.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        txtSenha.Focus();
            //    }
            //    else if (txtCodGrupo.Text == "" || txtGrupo.Text == "")
            //    {
            //        MessageBox.Show("Informe o grupo corretamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        txtCodGrupo.Focus();
            //    }
            //    else if (clstEmpresa.CheckedItems.Count < 1)
            //    {
            //        MessageBox.Show("Marque ao menos uma empresa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        clstEmpresa.Focus();
            //    }
            //    else
            //    {

            //        try
            //        {
            //            PreencherModulo();
            //            string retorno = c_usuarioBll.BuscarPorNome(c_usuarioEnt);
            //            if (retorno == "1")
            //            {
            //                try
            //                {
            //                    Convert.ToInt16(retorno);
            //                    MessageBox.Show("O usuário: " + c_usuarioEnt.usuario + ", já existe no banco de dados e está cadastrado com o código " + c_usuarioEnt.codigo + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                    txtCodigo.Focus();
            //                }
            //                catch
            //                {
            //                    MessageBox.Show("Falha: " + retorno, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //                }
            //            }
            //            else if (retorno == "0" || retorno != "1")
            //            {
            //                retorno = "";
            //                try
            //                {
            //                    funcoes.PreencherListaEmpresasDoUsuario(c_usuarioEnt, clstEmpresa); //esta funcção pega as empresas do usuário
            //                    retorno = c_usuarioBll.Gravar(c_usuarioEnt);
            //                    Convert.ToInt16(retorno);
            //                    txtCodigo.Text = retorno.ToString();
            //                    MessageBox.Show("Registro " + retorno + " gravado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                    retorno = "";
            //                    retorno = c_usuarioBll.CarregarGrade(grdC_Usuarios);
            //                    Convert.ToInt16(retorno);
            //                    txtTotal.Text = retorno;
            //                }
            //                catch
            //                {
            //                    MessageBox.Show("Falha: " + retorno, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //                }
            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show("Falha: " + ex.Message, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        }
            //    }
            //}
        }
    }
}
