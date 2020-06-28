using ProjetoMVCD09.BLL;
using ProjetoMVCD09.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoMVCD09.UI
{
    public partial class SignIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviarD09_Click(object sender, EventArgs e)
        {
            try
            {
                msgerror.Visible = false;
                DTOMVC dtomvc = new DTOMVC();
                dtomvc.Cpf_cliente = txtCpfD09.Text;
                dtomvc.Nome_cliente = txtNomeD09.Text;
                dtomvc.Nome_mae = txtNomeMaeD09.Text;

                BLLMVC bllmvc = new BLLMVC();
                if(bllmvc.consultabeneficio(dtomvc.Cpf_cliente,dtomvc.Nome_cliente,dtomvc.Nome_mae)==true)
                {
                    msgerror.Visible = true;
                    msgerror.Text = "Beneficiário Localizado no Banco de dados. Processo em Análise";
                }
                else
                {
                    msgerror.Visible = true;
                    msgerror.Text = "Beneficiário Não Localizado no Banco de dados. Benefício Negado";
                }
            }
            catch(Exception err)
            {
                msgerror.Visible = true;
                msgerror.Text = err.Message;
            }
        }
    }
}