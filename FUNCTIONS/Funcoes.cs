using Loja.VIEW;
using Loja.DATA;
using Loja.ENTITY;
using Loja.BUSINESS;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Text;

namespace Loja.FUNCTIONS
{
    public class Funcoes
    {
        Conexao conexao = new Conexao();

        public string GetVersion()
        {
            //pego a versão do assembyInfo, é implementada a cada compilada do sistema
            return System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        public void ApenasNumerosTracos(KeyPressEventArgs e)
        {
            // Aceita apenas Numeros, BackSpace, Espaço, enter, tab e traço "-".
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Escape) && !(e.KeyChar == (char)Keys.Enter) && !(e.KeyChar == (char)Keys.Tab) && !(e.KeyChar == '-'))
            {
                e.Handled = true; //usado para não emitir som             
                MessageBox.Show("É permitido apenas números e traços!");  //Se pressionar alguma letra exibirá uma mensagem
            }
        }

        public void ApenasNumeros(KeyPressEventArgs e)
        {
            // Aceita apenas Numeros, BackSpace, Espaço, enter e tab
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Escape) && !(e.KeyChar == (char)Keys.Enter) && !(e.KeyChar == (char)Keys.Tab))
            {
                e.Handled = true;
                MessageBox.Show("Digite apenas números!");  //Se pressionar alguma letra exibirá uma mensagem
            }
        }

        public void ApenasNumerosVirgula(KeyPressEventArgs e)
        {
            // Aceita apenas Numeros, BackSpace, Espaço, enter, tab e virgula.
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Escape) && !(e.KeyChar == (char)Keys.Enter) && !(e.KeyChar == (char)Keys.Tab) && !(e.KeyChar == ','))
            {
                e.Handled = true; //usado para não emitir som             
                MessageBox.Show("É permitido apenas números e virgula!");  //Se pressionar alguma letra exibirá uma mensagem
            }
        }

        public void ApenasNumerosPonto(KeyPressEventArgs e)
        {
            // Aceita apenas Numeros, BackSpace, Espaço, enter, tab e virgula.
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Escape) && !(e.KeyChar == (char)Keys.Enter) && !(e.KeyChar == (char)Keys.Tab) && !(e.KeyChar == '.'))
            {
                e.Handled = true; //usado para não emitir som             
                MessageBox.Show("É permitido apenas números e ponto(.)!");  //Se pressionar alguma letra exibirá uma mensagem
            }
        }

        public void ApenasLetras(KeyPressEventArgs e)
        {
            //permite digitar apenas letras, backspace, shift direito e esquerdo, espaço e tab no campo
            if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space) && !(e.KeyChar == (char)Keys.LShiftKey) && !(e.KeyChar == (char)Keys.RShiftKey) && !(e.KeyChar == (char)Keys.Tab))
            {
                e.Handled = true;
                MessageBox.Show("Digite apenas letras!");
            }
        }

        public void ApenasLetrasAsteristicos(KeyPressEventArgs e)
        {
            //permite digitar apenas letras, backspace, shift direito e esquerdo, espaço e tab no campo
            if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space) && !(e.KeyChar == (char)Keys.LShiftKey) && !(e.KeyChar == (char)Keys.RShiftKey) && !(e.KeyChar == (char)Keys.Tab) && !(e.KeyChar == '*'))
            {
                e.Handled = true;
                MessageBox.Show("Digite apenas letras!");
            }
        }

        public void LetrasMaiusculas(KeyPressEventArgs e, TextBox campo)
        {
            //deixa o textbox com letras maiúsculas
            if (Char.IsLower(e.KeyChar))
            {
                e.Handled = true;
                campo.SelectedText = Char.ToUpper(e.KeyChar).ToString();  //Converte o texto para caixa alta
            }
        }

        public void Sair(KeyEventArgs e, Form tela)
        {
            // Se apertar Esc sai da tela
            if (e.KeyValue.Equals(27)) //27 se refere ao Escape (Esc)
            {
                e.Handled = true; //usado para não emitir som             
                tela.Dispose();
            }
        }

        public string ConverterVirgulaParaPonto(string salario)
        {
            // Pode ser usado para concatenar também:  string sVariavelNova = sVariavel.Replace(" ", "-").Replace("!", "?");
            salario = salario.Replace(",", ".");
            return salario;
        }

        public string ConverterPontoParaVirgula(string texto)
        {
            texto = texto.Replace(".", ",");
            return texto;
        }

        public void VerificarDigitoDecimal(KeyPressEventArgs e, TextBox campo)
        {
            //se tiver ponto no campo eu converto para virgula
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = '.';
            }
            //Verifica se já existe mais de um ponto na string
            if ((campo.Text.Contains(".") && (e.KeyChar == '.')))
            {
                e.Handled = true; // Caso exista, aborte. Trava o campo
            }
        }

        public bool VerificaEmail(string strEmail)
        {
            //vericar se e-mail está no formato padrão
            string strModelo = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (System.Text.RegularExpressions.Regex.IsMatch(strEmail, strModelo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public byte[] ConverterFoto(PictureBox img)
        {
            //converter foto para vetor de byte para inserção no banco
            using (var stream = new System.IO.MemoryStream())
            {
                img.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                stream.Seek(0, System.IO.SeekOrigin.Begin);
                byte[] foto = new byte[stream.Length];
                stream.Read(foto, 0, System.Convert.ToInt32(stream.Length));
                return foto;
            }
        }

        public Image DesconverterFoto(byte[] foto)
        {
            //desconverto a foto para mostrar na tela
            Image img = null;
            MemoryStream ms = new MemoryStream(foto);
            byte[] fotoRetorno = new byte[0];
            if (ms.Equals(fotoRetorno))
            {
                img = Image.FromStream(ms);
            }
            return img;
            //if (leitor["Foto"] != DBNull.Value) //verifico se o retorno é null
            //{
            //    recupero a foto na linha abaixo
            //    Image img = null;
            //    byte[] foto = null;
            //    foto = (byte[])leitor["Foto"];
            //    MemoryStream ms = new MemoryStream(foto);
            //    img = Image.FromStream(ms);
            //    func.foto = img;
            //    fim recuperação imagem     
            //}
        }

        public void PesquisarImagem(OpenFileDialog oFileDialog, PictureBox imagem)
        {
            // valido a foto para exibir na tela
            oFileDialog.Filter = "Foto JPG|*.jpg|Foto JPEG|*.jpeg|Foto PNG|*.png|Foto bmp|*.bmp";

            DialogResult result = oFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string name = oFileDialog.FileName;

                if ((name == "openFileDialog") || (name == null))
                {
                    imagem.ImageLocation = @"E:\Sistema\Repositorio\Loja\IMAGENS\PNG\usuario.png";
                    //openFileDialog.FileName = "";
                }
                else
                {
                    System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(name);
                    System.Drawing.Bitmap bmp2 = new System.Drawing.Bitmap(bmp, imagem.Size); //pego a btnImagem e object tamanho
                    imagem.Image = bmp2; // carrego o picturebox com a imagem
                }
            }
            else
            {
                oFileDialog.FileName = "";
                imagem.ImageLocation = @"E:\Sistema\Repositorio\Loja\IMAGENS\PNG\usuario.png";
            }
            /*
                                       EXEMPLO DE TIPO DE ARQUIVOS
            dlg.Filter = "Word Documents|*.doc|Excel Worksheets|*.xls|PowerPoint Presentations|*.ppt" +
            "|Office Files|*.doc;*.xls;*.ppt" +
            "|All Files|*.*";
             
            * open file dialog é um componete encontrado no toolbox para abrir a caixa de dialogo do windows
            * pbImagem.ImageLocation = @"D:\Loja\Imagens\usuario1.png"; pega a imagem
            * Para gravar as fotos dentro da pasta >> D:\Loja\Fotos\
            * picImagem.Image.Save(@"D:\Loja\Fotos\" + codigo + ".jpg");  
            */
        }

        public void VerificarLogadoPorMarquina(LoginENT login)
        {
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@maquina", login.maquina);
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT * FROM Temp WHERE Maquina = @maquina");
                DataTable dt = conexao.Consultar(CommandType.Text, Convert.ToString(sql));
                foreach (DataRow dr in dt.Rows)
                {
                    login.codigo = Convert.ToInt16(dr["Codigo"]);
                    login.usuario = dr["Usuario"].ToString();
                    login.ativo = Convert.ToBoolean(dr["Ativo"]);
                    login.grupo = dr["Grupo"].ToString();
                    login.empresa_fantasia = dr["Empresa"].ToString();
                    login.maquina = dr["Maquina"].ToString();
                    login.versao = dr["Versao"].ToString();
                    login.data_ult_login = Convert.ToDateTime(dr["Data"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha: " + ex, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ExcluirTemp(LoginENT login)
        {
            try
            {
                Int16 qtde = 0;
                conexao.LimparParametros();
                conexao.AdicionarParametros("@usuario", login.usuario);
                conexao.AdicionarParametros("@maquina", login.maquina);
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT COUNT(Codigo) FROM Temp");
                qtde = Convert.ToInt16(conexao.Manipular(CommandType.Text, Convert.ToString(sql)));
                if (qtde < 2)
                {
                    sql.AppendLine("TRUNCATE TABLE Temp");
                    conexao.Manipular(CommandType.Text, Convert.ToString(sql));
                }
                else
                {
                    sql.AppendLine("DELETE FROM Temp WHERE Maquina = @maquina AND Usuario = @usuario");
                    conexao.Manipular(CommandType.Text, Convert.ToString(sql));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha: " + ex, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void MarcarEmpresas(CheckedListBox list)
        {
            for (int count = contador - 1; count > -1; count--) //coloco contador -1 para desconsiderar a opção todos do listbox
            {
                list.SetItemChecked(count, true);
            }

        }

        public void DesmarcarEmpresas(CheckedListBox list)
        {
            for (int count = contador - 1; count > -1; count--) //coloco contador -1 para desconsiderar a opção todos do listbox
            {
                list.SetItemChecked(count, false);
            }
        }

        public void PreencherListaEmpresasDoUsuario(C_UsuarioENT c_usuarioEnt, CheckedListBox listBox)
        {
            c_usuarioEnt.lista_empresa.Clear(); //limpop a lista de empresa
            for (int i = 0; i < listBox.Items.Count; i++) //verifico a quantidade de itens que existe no campo
            {
                if (listBox.GetItemChecked(i)) //verifico que o item na posição informada está marcado
                {
                    listBox.SelectedIndex = i; //mando o liste box selecionar o item marcado
                    c_usuarioEnt.lista_empresa.Add(Convert.ToInt16(listBox.SelectedValue)); //pego o valor(código da empresa) do item marcado                   
                }
            }
        }

        public int contador;
        public int PreencherTodasEmpresas(CheckedListBox listaEmpresa)
        {
            int count = 0;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT Codigo, Fantasia FROM Empresa");
                DataTable dt = conexao.Consultar(CommandType.Text, Convert.ToString(sql));
                foreach (DataRow dr in dt.Rows) //outra maneira de preencher o checkedlistbox
                {
                    listaEmpresa.DataSource = dt;
                    listaEmpresa.ValueMember = "Codigo";
                    listaEmpresa.DisplayMember = "Fantasia";
                    count = count + 1;
                }
                contador = count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha: " + ex, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return contador;
        }



        public void MarcarEmpresaDoUsuario(CheckedListBox listaEmpresa, string codigoUsuario)
        {
            try
            {
                int count = 0, empresa = 0;
                conexao.LimparParametros();
                conexao.AdicionarParametros("@codigo", codigoUsuario);
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT UE.Codigo AS 'Código', U.Codigo AS 'Cód. Usuario', E.Codigo AS 'Cód. Empresa', E.Fantasia ");
                sql.AppendLine("FROM Usuario_Empresa UE ");
                sql.AppendLine("INNER JOIN Usuario U ON UE.Usuario = U.Codigo ");
                sql.AppendLine("INNER JOIN Empresa E ON UE.Empresa = E.Codigo ");
                sql.AppendLine("WHERE E.Inativo = 0 AND U.Codigo = @codigo");
                DataTable dt = conexao.Consultar(CommandType.Text, Convert.ToString(sql));
                foreach (DataRow dr in dt.Rows)
                {
                    empresa = Convert.ToInt16(dr["Cód. Empresa"]);
                    if (empresa > 0) //se a empresa gerencial for = S então marco ela
                    {
                        listaEmpresa.SetItemChecked(empresa - 1, true);
                    }
                    else
                    {
                        listaEmpresa.SetItemChecked(empresa, false);
                    }
                    count = count + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha: " + ex, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public string VerificarMaquina()
        {
            //pego nome da máquina que está acessando o sistema
            string maquina = Environment.MachineName;
            return maquina;
        }

        public void VerificarAniversario(DateTimePicker dtNascimento, DateTimePicker dtCadastro, Label informativa, RadioButton Demitido)
        {
            if ((dtNascimento.Value.Month == DateTime.Now.Month) && (dtNascimento.Value.Year <= DateTime.Now.Year) && (Demitido.Checked == false))
            {
                informativa.Visible = true;
                informativa.Text = string.Empty;
                informativa.Text = "Funcionário Aniversariante do mês!";
            }
        }

        public void ExportarExcel(DataGridView grade, string texto)
        {
            //exportar dados para o excel
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Salvar Como Arquivo Excel";
                saveFileDialog.FileName = "Relatório";
                saveFileDialog.Filter = "Excel 2007|*.xlsx|Excel 2003|*.xls";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                    ExcelApp.Application.Workbooks.Add(Type.Missing);
                    ExcelApp.Cells[1, 2] = texto;
                    for (int coluna = 1; coluna < grade.Columns.Count + 1; coluna++)
                    {
                        ExcelApp.Cells[3, coluna] = grade.Columns[coluna - 1].HeaderText;
                    }

                    for (int linha = 0; linha < grade.Rows.Count; linha++)
                    {
                        for (int coluna = 0; coluna < grade.Columns.Count; coluna++)
                        {
                            ExcelApp.Cells[linha + 4, coluna + 1] = grade.Rows[linha].Cells[coluna].Value.ToString();
                        }
                    }
                    ExcelApp.Columns.AutoFit();
                    Microsoft.Office.Interop.Excel.Range celulas;
                    //Aqui para baixo configuro o texto de layout
                    celulas = ExcelApp.get_Range("A1", "E1");
                    celulas.MergeCells = true;
                    celulas.Font.Italic = true;
                    celulas.Font.Size = 20F;
                    celulas = ExcelApp.get_Range("A1", "F1"); //Recupero o conjunto de células de A1 até Z1
                    celulas.HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter; //centralizo as células                    
                    celulas.Font.Bold = true; //mudo a fonte para negrito

                    //Aqui para baixo configuro o nome da coluna
                    celulas = ExcelApp.get_Range("A3", "Z3");
                    celulas.Font.Size = 12F;
                    celulas.HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter; //centralizo as células                    
                    celulas.Font.Bold = true; //mudo a fonte para negrito
                    //celulas.Interior.Color = ColorTranslator.ToWin32(Color.LightGray); //mudo as cores das celulas
                    //celulas.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; //insiro a borda nas celulas            
                    ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog.FileName.ToString());
                    ExcelApp.ActiveWorkbook.Saved = true;
                    ExcelApp.Quit();
                    MessageBox.Show("Arquivo exportado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Inconsitência: " + ex.Message, "Possível falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}



//public void ExpPDF(DataGridView grade, string strPdfPatch, string strHeader)
//{
//    //cabeçalho
//    //System.IO.FileStream fs = new FileStream(strPdfPatch, FileMode.Create, FileAccess.Write, FileShare.None);
//    Document document = new Document();
//    document.SetPageSize(iTextSharp.text.PageSize.A4);
//    //PdfWriter writer = PdfWriter.GetInstance(document, fs);
//    document.Open();

//    BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
//    Font fntHead = new Font(bfntHead, 16, 1, BaseColor.GRAY);
//    Paragraph prgHeading = new Paragraph();
//    prgHeading.Alignment = Element.ALIGN_CENTER;
//    prgHeading.Add(new Chunk(strHeader.ToUpper(), fntHead));
//    document.Add(prgHeading);

//    //Linha separadora da grade
//    Paragraph paragraph = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 100.0F)));
//    document.Add(paragraph);
//    document.Add(new Chunk("\n", fntHead)); //pula linha após o separador

//    //criando o header da grade
//    PdfPTable pdfTable = new PdfPTable(grade.ColumnCount);
//    BaseFont btnColumHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
//    Font fntColumHeader = new Font(btnColumHeader, 10, 1, BaseColor.WHITE);
//    pdfTable.DefaultCell.Padding = 1;
//    //pdfTable.WidthPercentage = 100;
//    pdfTable.DefaultCell.Column.FilledWidth = 100;
//    pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
//    pdfTable.DefaultCell.BorderWidth = 1;

//    //Adicionando linha de cabeçalho
//    foreach (DataGridViewColumn column in grade.Columns)
//    {
//        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
//        //cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
//        pdfTable.AddCell(cell);
//    }

//    //Adicionando as linhas da grade
//    foreach (DataGridViewRow row in grade.Rows)
//    {
//        foreach (DataGridViewCell cell in row.Cells)
//        {
//            pdfTable.AddCell(cell.Value.ToString());
//        }
//    }

//    //Exportando para PDF, verificar o caminho abaixo
//    string folderPath = "D:\\LOJA\\Loja\\PDFs\\";
//    if (!Directory.Exists(folderPath))
//    {
//        Directory.CreateDirectory(folderPath);
//    }
//    using (FileStream stream = new FileStream(folderPath + "Relatório.pdf", FileMode.Create))
//    {
//        Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
//        PdfWriter.GetInstance(pdfDoc, stream);
//        pdfDoc.Open();
//        pdfDoc.Add(pdfTable);
//        pdfDoc.Close();
//        stream.Close();
//        DialogResult dialogo = MessageBox.Show("Arquivo exportado com sucesso! Deseja Abrir o arquivo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
//        if (dialogo == DialogResult.Yes)
//        {
//            System.Diagnostics.Process.Start(@"D:\LOJA\Loja\PDFs\Relatório.pdf");
//        }
//    }
//}
//public void ExportarPDF(DataTable dt, string strPdfPatch, string strHeader)
//{
//    System.IO.FileStream fs = new FileStream(strPdfPatch, FileMode.Create, FileAccess.Write, FileShare.None);
//    Document document = new Document();
//    document.SetPageSize(iTextSharp.text.PageSize.A4);
//    PdfWriter writer = PdfWriter.GetInstance(document, fs);
//    document.Open();

//    //cabeçalho
//    BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
//    Font fntHead = new Font(bfntHead, 16, 1, BaseColor.GRAY);
//    Paragraph prgHeading = new Paragraph();
//    prgHeading.Alignment = Element.ALIGN_CENTER;
//    prgHeading.Add(new Chunk(strHeader.ToUpper(), fntHead));
//    document.Add(prgHeading);

//    //Linha separadora da grade
//    Paragraph paragraph = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 100.0F)));
//    document.Add(paragraph);
//    document.Add(new Chunk("\n", fntHead)); //pula linha após o separador

//    PdfPTable pdfTable = new PdfPTable(dt.Columns.Count);
//    BaseFont btnColumHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
//    Font fntColumHeader = new Font(btnColumHeader, 10, 1, BaseColor.WHITE);
//    //criando o header da grade
//    for (int i = 1; i < dt.Columns.Count + 1; i++)
//    {
//        PdfPCell cell = new PdfPCell();
//        cell.BackgroundColor = BaseColor.GRAY;
//        cell.AddElement(new Chunk(dt.Columns[i].ColumnName.ToUpper(), fntColumHeader));
//        pdfTable.AddCell(cell);
//    }
//    //criando as demais linhas da tabela
//    for (int i = 0; i < dt.Rows.Count; i++)
//    {
//        for (int j = 0; j < dt.Columns.Count; j++)
//        {
//            pdfTable.AddCell(dt.Rows[i][j].ToString());
//        }
//    }
//    document.Add(pdfTable);
//    document.Close();
//    writer.Close();
//    fs.Close();
//    DialogResult dialogo = MessageBox.Show("Arquivo exportado com sucesso! Deseja Abrir o arquivo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
//    if (dialogo == DialogResult.Yes)
//    {
//        System.Diagnostics.Process.Start(@"D:\LOJA\Loja\PDFs\Relatório.pdf");
//    }
//}