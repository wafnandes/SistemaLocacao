using GirassoisLocacoes.Entidades;
using PdfSharp.Drawing.Layout;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GirassoisLocacoes.Negocio;
using System.Windows.Forms;

namespace GirassoisLocacoes.Commons
{
    public class GeraPDF
    {
        public GeraPDF() { }
        private static GeraPDF instance;

        public static GeraPDF Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GeraPDF();
                }
                return instance;
            }
        }

        #region "GeraPDFReservaA4"
        public void GeraPDFReservaA4(ENReserva entidade, List<ENReservaItens> entidadeItens, string filename)
        {
            try
            {
                ENReserva pEntidadeDados = (ENReserva)entidade;
                List<ENReservaItens> pEntidadeDadosItens = (List<ENReservaItens>)entidadeItens;


                PdfDocument document = new PdfDocument();
                XPen pen = new XPen(XColors.Black);
                XPoint ptBarraHorizontal1;
                XPoint ptBarraHorizontal2;
                XPoint ptBarraVertical1;
                XPoint ptBarraVertical2;
                XPoint ptBarraVertical3;
                XPoint ptBarraVertical4;
                XPoint ptBarraVertical5;
                XPoint ptBarraVertical6;
                XPoint ptBarraVertical7;
                XPoint ptBarraVertical8;
                XPoint ptBarraVertical9;
                XPoint ptBarraVertical10;
                XPoint ptBarraVertical11;
                XPoint ptBarraVertical12;
                XPoint ptBarraVertical13;
                XPoint ptBarraVertical14;
                XPoint ptBarraVertical15;
                XPoint ptBarraVertical16;
                XPoint ptBarraHorizontal3;
                XPoint ptBarraHorizontal4;

                // Criando documento e definindo as margens
                PdfPage page = document.AddPage();
                page.Size = PdfSharp.PageSize.A4;
                page.TrimMargins.Top = 20;

                // Inserindo logo
                XGraphics gfx = XGraphics.FromPdfPage(page);
                XTextFormatter tf = new XTextFormatter(gfx);
                //DrawImage(gfx, imageLoc, Convert.ToInt32((page.Width - 180)/2), 0, 180, 75);

                XFont font = new XFont("Sacramento", 80, XFontStyle.Regular);

                gfx.DrawString("Girassois", font, XBrushes.Black,
                                new XRect(0, 0, page.Width, page.Height),
                                XStringFormats.TopCenter);

                font = new XFont("Comfortaa", 16, XFontStyle.Bold);

                gfx.DrawString("LOCAÇÕES", font, XBrushes.Black,
                                new XRect(60, 80, page.Width, page.Height),
                                XStringFormats.TopCenter);

                XPdfFontOptions options = new XPdfFontOptions(PdfFontEncoding.Unicode);

                int xBarra = 40;
                int yBarra = 125;

                font = new XFont("Helvética", 12, XFontStyle.Bold, options);
                tf.Alignment = XParagraphAlignment.Center;

                tf.DrawString("DADOS DO CLIENTE", font, XBrushes.Black,
                                new XRect(0, yBarra, page.Width, page.Height),
                                XStringFormats.TopLeft);

                yBarra = 144;
                gfx.DrawRectangle(pen, xBarra, yBarra, 515, 28);

                font = new XFont("Helvética", 10, XFontStyle.Regular, options);
                tf.Alignment = XParagraphAlignment.Left;

                tf.DrawString("Nome: " + pEntidadeDados.nmCliente, font, XBrushes.Black,
                                new XRect(xBarra + 4, yBarra + 1, page.Width, page.Height),
                                XStringFormats.TopLeft);

                tf.DrawString("CPF: " + FormHelper.Instance.MascaraCPFCNPJ(pEntidadeDados.cpfcnpj), font, XBrushes.Black,
                                new XRect(xBarra + 261.5, yBarra + 1, page.Width, page.Height),
                                XStringFormats.TopLeft);

                tf.DrawString("Dt. Nasc: " + pEntidadeDados.dtNasc, font, XBrushes.Black,
                                new XRect(xBarra + 4, yBarra + 15, page.Width, page.Height),
                                XStringFormats.TopLeft);

                tf.DrawString("Telefone: " + FormHelper.Instance.MascaraTelefone(Convert.ToString(pEntidadeDados.telCliente)), font, XBrushes.Black,
                                new XRect(xBarra + 261.5, yBarra + 15, page.Width, page.Height),
                                XStringFormats.TopLeft);

                yBarra = 180;

                font = new XFont("Helvética", 12, XFontStyle.Bold, options);
                tf.Alignment = XParagraphAlignment.Center;

                tf.DrawString("ENDEREÇO", font, XBrushes.Black,
                                new XRect(0, yBarra, page.Width, page.Height),
                                XStringFormats.TopLeft);

                font = new XFont("Helvética", 10, XFontStyle.Regular, options);
                tf.Alignment = XParagraphAlignment.Left;

                yBarra = 200;

                var brush = new XSolidBrush(XColor.FromArgb(255, 229, 229, 229));
                gfx.DrawRectangle(brush, xBarra, yBarra + 56, 515, 14);

                gfx.DrawRectangle(pen, xBarra, yBarra, 515, 70);
                ptBarraHorizontal1 = new XPoint(xBarra, yBarra + 56);
                ptBarraHorizontal2 = new XPoint(page.Width - xBarra, yBarra + 56);
                ptBarraVertical1 = new XPoint(xBarra + 257.5, yBarra + 56);
                ptBarraVertical2 = new XPoint(xBarra + 257.5, yBarra + 70);
                gfx.DrawLine(pen, ptBarraHorizontal1, ptBarraHorizontal2);
                gfx.DrawLine(pen, ptBarraVertical1, ptBarraVertical2);

                tf.DrawString("Entregar em: " + pEntidadeDados.nmLocalEntrega, font, XBrushes.Black,
                                new XRect(xBarra + 4, yBarra + 1, page.Width, page.Height),
                                XStringFormats.TopLeft);

                tf.DrawString("CEP: " + FormHelper.Instance.MascaraCEP(pEntidadeDados.cep.ToString()), font, XBrushes.Black,
                                new XRect(xBarra + 261.5, yBarra + 29, page.Width, page.Height),
                                XStringFormats.TopLeft);

                tf.DrawString("Endereço: " + pEntidadeDados.endereco, font, XBrushes.Black,
                                new XRect(xBarra + 4, yBarra + 15, page.Width, page.Height),
                                XStringFormats.TopLeft);

                tf.DrawString("Complemento: " + pEntidadeDados.compl, font, XBrushes.Black,
                                new XRect(xBarra + 4, yBarra + 29, page.Width, page.Height),
                                XStringFormats.TopLeft);

                tf.DrawString("Bairro: " + pEntidadeDados.bairro, font, XBrushes.Black,
                                new XRect(xBarra + 4, yBarra + 43, page.Width, page.Height),
                                XStringFormats.TopLeft);

                if (pEntidadeDados.cidade != "")
                    tf.DrawString("Cidade: " + pEntidadeDados.cidade + " - " + pEntidadeDados.estado + ".", font, XBrushes.Black,
                                    new XRect(xBarra + 261.5, yBarra + 43, page.Width, page.Height),
                                    XStringFormats.TopLeft);
                else
                    tf.DrawString("Cidade: ", font, XBrushes.Black,
                                new XRect(xBarra + 261.5, yBarra + 43, page.Width, page.Height),
                                XStringFormats.TopLeft);

                tf.DrawString("Data de entrega: " + pEntidadeDados.strDtHrEntrega, font, XBrushes.Black,
                                new XRect(xBarra + 4, yBarra + 57, page.Width, page.Height),
                                XStringFormats.TopLeft);

                tf.DrawString("Data de devolução: " + pEntidadeDados.strDtHrDevolucao, font, XBrushes.Black,
                                new XRect(xBarra + 261.5, yBarra + 57, page.Width, page.Height),
                                XStringFormats.TopLeft);

                font = new XFont("Helvética", 12, XFontStyle.Bold, options);
                tf.Alignment = XParagraphAlignment.Center;

                yBarra = 278;

                tf.DrawString("LISTA DE SEPARAÇÃO", font, XBrushes.Black,
                                new XRect(0, yBarra, page.Width, page.Height),
                                XStringFormats.TopLeft);

                font = new XFont("Helvética", 10, XFontStyle.Bold, options);
                tf.Alignment = XParagraphAlignment.Left;


                yBarra = 298;

                //Montando linha base
                gfx.DrawRectangle(brush, xBarra, yBarra, 515, 14);

                ptBarraHorizontal1 = new XPoint(xBarra, yBarra);
                ptBarraHorizontal2 = new XPoint(page.Width - xBarra, yBarra);
                ptBarraVertical1 = new XPoint(xBarra, yBarra);
                ptBarraVertical2 = new XPoint(xBarra, yBarra + 14);
                ptBarraVertical3 = new XPoint(xBarra + 40, yBarra);
                ptBarraVertical4 = new XPoint(xBarra + 40, yBarra + 14);
                ptBarraVertical5 = new XPoint(xBarra + 215, yBarra);
                ptBarraVertical6 = new XPoint(xBarra + 215, yBarra + 14);
                ptBarraVertical7 = new XPoint(xBarra + 275, yBarra);
                ptBarraVertical8 = new XPoint(xBarra + 275, yBarra + 14);
                ptBarraVertical9 = new XPoint(xBarra + 335, yBarra);
                ptBarraVertical10 = new XPoint(xBarra + 335, yBarra + 14);
                ptBarraVertical11 = new XPoint(xBarra + 395, yBarra);
                ptBarraVertical12 = new XPoint(xBarra + 395, yBarra + 14);
                ptBarraVertical13 = new XPoint(xBarra + 455, yBarra);
                ptBarraVertical14 = new XPoint(xBarra + 455, yBarra + 14);
                ptBarraVertical15 = new XPoint(xBarra + 515, yBarra);
                ptBarraVertical16 = new XPoint(xBarra + 515, yBarra + 14);
                ptBarraHorizontal3 = new XPoint(xBarra, yBarra + 14);
                ptBarraHorizontal4 = new XPoint(page.Width - xBarra, yBarra + 14);

                gfx.DrawLine(pen, ptBarraHorizontal1, ptBarraHorizontal2);
                gfx.DrawLine(pen, ptBarraVertical1, ptBarraVertical2);
                gfx.DrawLine(pen, ptBarraHorizontal3, ptBarraHorizontal4);
                gfx.DrawLine(pen, ptBarraVertical3, ptBarraVertical4);
                gfx.DrawLine(pen, ptBarraVertical5, ptBarraVertical6);
                gfx.DrawLine(pen, ptBarraVertical7, ptBarraVertical8);
                gfx.DrawLine(pen, ptBarraVertical9, ptBarraVertical10);
                gfx.DrawLine(pen, ptBarraVertical11, ptBarraVertical12);
                gfx.DrawLine(pen, ptBarraVertical13, ptBarraVertical14);
                gfx.DrawLine(pen, ptBarraVertical15, ptBarraVertical16);


                tf.DrawString("Código", font, XBrushes.Black,
                                            new XRect(xBarra + 4, yBarra + 1, page.Width, page.Height),
                                            XStringFormats.TopLeft);
                tf.DrawString("Nome", font, XBrushes.Black,
                                            new XRect(xBarra + 44, yBarra + 1, page.Width, page.Height),
                                            XStringFormats.TopLeft);
                tf.DrawString("Vlr. Repo.", font, XBrushes.Black,
                                            new XRect(xBarra + 219, yBarra + 1, page.Width, page.Height),
                                            XStringFormats.TopLeft);
                tf.DrawString("Vlr. Unit.", font, XBrushes.Black,
                                            new XRect(xBarra + 279, yBarra + 1, page.Width, page.Height),
                                            XStringFormats.TopLeft);
                tf.DrawString("Vlr. Desc.", font, XBrushes.Black,
                                            new XRect(xBarra + 339, yBarra + 1, page.Width, page.Height),
                                            XStringFormats.TopLeft);
                tf.DrawString("Qtde.", font, XBrushes.Black,
                                            new XRect(xBarra + 399, yBarra + 1, page.Width, page.Height),
                                            XStringFormats.TopLeft);
                tf.DrawString("Vlr. Total", font, XBrushes.Black,
                                            new XRect(xBarra + 459, yBarra + 1, page.Width, page.Height),
                                            XStringFormats.TopLeft);

                font = new XFont("Helvética", 10, XFontStyle.Regular, options);

                yBarra = 312;

                foreach(ENReservaItens item in pEntidadeDadosItens)
                {
                    ptBarraHorizontal1 = new XPoint(xBarra, yBarra);
                    ptBarraHorizontal2 = new XPoint(page.Width - xBarra, yBarra);
                    ptBarraVertical1 = new XPoint(xBarra, yBarra);
                    ptBarraVertical2 = new XPoint(xBarra, yBarra + 16);
                    ptBarraVertical3 = new XPoint(xBarra + 40, yBarra);
                    ptBarraVertical4 = new XPoint(xBarra + 40, yBarra + 16);
                    ptBarraVertical5 = new XPoint(xBarra + 215, yBarra);
                    ptBarraVertical6 = new XPoint(xBarra + 215, yBarra + 16);
                    ptBarraVertical7 = new XPoint(xBarra + 275, yBarra);
                    ptBarraVertical8 = new XPoint(xBarra + 275, yBarra + 16);
                    ptBarraVertical9 = new XPoint(xBarra + 335, yBarra);
                    ptBarraVertical10 = new XPoint(xBarra + 335, yBarra + 16);
                    ptBarraVertical11 = new XPoint(xBarra + 395, yBarra);
                    ptBarraVertical12 = new XPoint(xBarra + 395, yBarra + 16);
                    ptBarraVertical13 = new XPoint(xBarra + 455, yBarra);
                    ptBarraVertical14 = new XPoint(xBarra + 455, yBarra + 16);
                    ptBarraVertical15 = new XPoint(xBarra + 515, yBarra);
                    ptBarraVertical16 = new XPoint(xBarra + 515, yBarra + 16);
                    ptBarraHorizontal3 = new XPoint(xBarra, yBarra + 16);
                    ptBarraHorizontal4 = new XPoint(page.Width - xBarra, yBarra + 16);

                    gfx.DrawLine(pen, ptBarraHorizontal1, ptBarraHorizontal2);
                    gfx.DrawLine(pen, ptBarraVertical1, ptBarraVertical2);
                    gfx.DrawLine(pen, ptBarraHorizontal3, ptBarraHorizontal4);
                    gfx.DrawLine(pen, ptBarraVertical3, ptBarraVertical4);
                    gfx.DrawLine(pen, ptBarraVertical5, ptBarraVertical6);
                    gfx.DrawLine(pen, ptBarraVertical7, ptBarraVertical8);
                    gfx.DrawLine(pen, ptBarraVertical9, ptBarraVertical10);
                    gfx.DrawLine(pen, ptBarraVertical11, ptBarraVertical12);
                    gfx.DrawLine(pen, ptBarraVertical13, ptBarraVertical14);
                    gfx.DrawLine(pen, ptBarraVertical15, ptBarraVertical16);

                    tf.DrawString(Funcoes.Formatar(item.cdItem,"000"), font, XBrushes.Black,
                                            new XRect(xBarra + 4, yBarra + 2, page.Width, page.Height),
                                            XStringFormats.TopLeft);

                    if(item.nmItem.Length > 30)
                        font = new XFont("Helvética", 8, XFontStyle.Regular, options);
                    else
                        font = new XFont("Helvética", 10, XFontStyle.Regular, options);

                    tf.DrawString(item.nmItem, font, XBrushes.Black,
                                                new XRect(xBarra + 44, yBarra + 4, page.Width, page.Height),
                                                XStringFormats.TopLeft);

                    font = new XFont("Helvética", 10, XFontStyle.Regular, options);

                    tf.DrawString("R$ " + Funcoes.Formatar(Convert.ToDouble(item.vlrReposicao),"N2"), font, XBrushes.Black,
                                                new XRect(xBarra + 219, yBarra + 2, page.Width, page.Height),
                                                XStringFormats.TopLeft);
                    tf.DrawString("R$ " + Funcoes.Formatar(Convert.ToDouble(item.vlrUnit), "N2"), font, XBrushes.Black,
                                                new XRect(xBarra + 279, yBarra + 2, page.Width, page.Height),
                                                XStringFormats.TopLeft);
                    tf.DrawString("R$ " + Funcoes.Formatar(Convert.ToDouble(item.vlrDesconto), "N2"), font, XBrushes.Black,
                                                new XRect(xBarra + 339, yBarra + 2, page.Width, page.Height),
                                                XStringFormats.TopLeft);
                    tf.DrawString(item.qtdeItem.ToString(), font, XBrushes.Black,
                                                new XRect(xBarra + 399, yBarra + 2, page.Width, page.Height),
                                                XStringFormats.TopLeft);
                    tf.DrawString("R$ " + Funcoes.Formatar(Convert.ToDouble(item.total), "N2"), font, XBrushes.Black,
                                                new XRect(xBarra + 459, yBarra + 2, page.Width, page.Height),
                                                XStringFormats.TopLeft);

                    yBarra += 16;
                }

                font = new XFont("Helvética", 10, XFontStyle.Bold, options);

                gfx.DrawRectangle(brush, xBarra + 395, yBarra, 120, 16);

                tf.DrawString("Valor Bruto", font, XBrushes.Black,
                                                new XRect(xBarra + 399, yBarra + 2, page.Width, page.Height),
                                                XStringFormats.TopLeft);

                font = new XFont("Helvética", 10, XFontStyle.Regular, options);

                tf.DrawString("R$ " + Funcoes.Formatar(Convert.ToDouble(pEntidadeDados.vlrReserva), "N2"), font, XBrushes.Black,
                                                new XRect(xBarra + 459, yBarra + 2, page.Width, page.Height),
                                                XStringFormats.TopLeft);

                yBarra += 16;
                font = new XFont("Helvética", 10, XFontStyle.Bold, options);

                tf.DrawString("Desconto", font, XBrushes.Black,
                                                new XRect(xBarra + 399, yBarra + 2, page.Width, page.Height),
                                                XStringFormats.TopLeft);

                font = new XFont("Helvética", 10, XFontStyle.Regular, options);

                tf.DrawString("R$ " + Funcoes.Formatar(Convert.ToDouble(pEntidadeDados.vlrDesconto), "N2"), font, XBrushes.Black,
                                                new XRect(xBarra + 459, yBarra + 2, page.Width, page.Height),
                                                XStringFormats.TopLeft);

                yBarra += 16;
                font = new XFont("Helvética", 10, XFontStyle.Bold, options);

                tf.DrawString("Desc. Itens", font, XBrushes.Black,
                                                new XRect(xBarra + 399, yBarra + 2, page.Width, page.Height),
                                                XStringFormats.TopLeft);

                font = new XFont("Helvética", 10, XFontStyle.Regular, options);

                tf.DrawString("R$ " + Funcoes.Formatar(Convert.ToDouble(pEntidadeDados.vlrDescontoItens), "N2"), font, XBrushes.Black,
                                                new XRect(xBarra + 459, yBarra + 2, page.Width, page.Height),
                                                XStringFormats.TopLeft);

                yBarra += 16;

                gfx.DrawRectangle(brush, xBarra + 395, yBarra, 120, 16);
                
                font = new XFont("Helvética", 10, XFontStyle.Bold, options);

                tf.DrawString("Valor Total", font, XBrushes.Black,
                                                new XRect(xBarra + 399, yBarra + 2, page.Width, page.Height),
                                                XStringFormats.TopLeft);

                font = new XFont("Helvética", 10, XFontStyle.Regular, options);

                tf.DrawString("R$ " + Funcoes.Formatar(Convert.ToDouble(pEntidadeDados.vlrTotal), "N2"), font, XBrushes.Black,
                                                new XRect(xBarra + 459, yBarra + 2, page.Width, page.Height),
                                                XStringFormats.TopLeft);

                yBarra = yBarra - 48;

                for (int i = 0; i < 4; i++)
                {
                    ptBarraHorizontal1 = new XPoint(xBarra + 395, yBarra);
                    ptBarraHorizontal2 = new XPoint(page.Width - xBarra, yBarra);
                    ptBarraVertical9 = new XPoint(xBarra + 395, yBarra);
                    ptBarraVertical10 = new XPoint(xBarra + 395, yBarra + 16);
                    ptBarraVertical11 = new XPoint(xBarra + 455, yBarra);
                    ptBarraVertical12 = new XPoint(xBarra + 455, yBarra + 16);
                    ptBarraVertical13 = new XPoint(xBarra + 515, yBarra);
                    ptBarraVertical14 = new XPoint(xBarra + 515, yBarra + 16);
                    ptBarraHorizontal3 = new XPoint(xBarra + 395, yBarra + 16);
                    ptBarraHorizontal4 = new XPoint(page.Width - xBarra, yBarra + 16);

                    gfx.DrawLine(pen, ptBarraHorizontal1, ptBarraHorizontal2);
                    gfx.DrawLine(pen, ptBarraHorizontal3, ptBarraHorizontal4);
                    gfx.DrawLine(pen, ptBarraVertical9, ptBarraVertical10);
                    gfx.DrawLine(pen, ptBarraVertical11, ptBarraVertical12);
                    gfx.DrawLine(pen, ptBarraVertical13, ptBarraVertical14);

                    yBarra += 16;
                }

                yBarra += 8;

                font = new XFont("Helvética", 12, XFontStyle.Bold, options);
                tf.Alignment = XParagraphAlignment.Center;

                tf.DrawString("OBSERVAÇÕES", font, XBrushes.Black,
                                new XRect(0, yBarra, page.Width, page.Height),
                                XStringFormats.TopLeft);

                yBarra += 20;

                ptBarraHorizontal1 = new XPoint(xBarra, yBarra);
                ptBarraHorizontal2 = new XPoint(page.Width - xBarra, yBarra);
                ptBarraVertical1 = new XPoint(xBarra, yBarra);
                ptBarraVertical2 = new XPoint(xBarra, yBarra + 28);
                ptBarraVertical15 = new XPoint(xBarra + 515, yBarra);
                ptBarraVertical16 = new XPoint(xBarra + 515, yBarra + 28);
                ptBarraHorizontal3 = new XPoint(xBarra, yBarra + 28);
                ptBarraHorizontal4 = new XPoint(page.Width - xBarra, yBarra + 28);

                gfx.DrawLine(pen, ptBarraHorizontal1, ptBarraHorizontal2);
                gfx.DrawLine(pen, ptBarraVertical1, ptBarraVertical2);
                gfx.DrawLine(pen, ptBarraHorizontal3, ptBarraHorizontal4);
                gfx.DrawLine(pen, ptBarraVertical15, ptBarraVertical16);

                font = new XFont("Helvética", 10, XFontStyle.Bold, options);
                tf.Alignment = XParagraphAlignment.Left;

                tf.DrawString(pEntidadeDados.observacao, font, XBrushes.Black,
                                            new XRect(xBarra + 4, yBarra + 1, page.Width, page.Height),
                                            XStringFormats.TopLeft);

                yBarra += 36;

                tf.Alignment = XParagraphAlignment.Center;
                font = new XFont("Helvética", 12, XFontStyle.Bold, options);

                tf.DrawString("NORMAS", font, XBrushes.Black,
                                                new XRect(0, yBarra, page.Width, page.Height),
                                                XStringFormats.TopLeft);

                tf.Alignment = XParagraphAlignment.Left;
                font = new XFont("Helvética", 10, XFontStyle.Regular, options);

                tf.DrawString("1. A quitação total do contrato precisa ser feita no ato da entrega dos itens.", font, XBrushes.Black,
                                                new XRect(xBarra, yBarra + 20, page.Width, page.Height),
                                                XStringFormats.TopLeft);

                tf.DrawString("2. Será cobrada relocação do material a cada 24 horas após a data de devolução acima.", font, XBrushes.Black,
                                                new XRect(xBarra, yBarra + 32, page.Width, page.Height),
                                                XStringFormats.TopLeft);

                tf.DrawString("3. Fica sob responsabilidade do contratante qualquer dano causado ao material locado.", font, XBrushes.Black,
                                                new XRect(xBarra, yBarra + 44, page.Width, page.Height),
                                                XStringFormats.TopLeft);

                tf.DrawString("4. Para locação de materiais é necessário um sinal de 20% (vinte por cento) do valor total do contrato.", font, XBrushes.Black,
                                                new XRect(xBarra, yBarra + 56, page.Width, page.Height),
                                                XStringFormats.TopLeft);

                tf.DrawString("5. Os materiais como: louças, talheres, rechaud, freezer, etc., devem ser devolvidos limpos à locadora.", font, XBrushes.Black,
                                                new XRect(xBarra, yBarra + 68, page.Width, page.Height),
                                                XStringFormats.TopLeft);

                tf.DrawString("6. O sinal referente à cláusula 4 ficará retido em caso de recisão do contrato.", font, XBrushes.Black,
                                                new XRect(xBarra, yBarra + 80, page.Width, page.Height),
                                                XStringFormats.TopLeft);

                tf.DrawString("7. O material deve ser conferido no ato da entrega no local solicitado.", font, XBrushes.Black,
                                                new XRect(xBarra, yBarra + 92, page.Width, page.Height),
                                                XStringFormats.TopLeft);




                filename = NEParametros.Instance.ObterCodParametro("diretorioPDFReservas").Tables[0].Rows[0]["codValorParametro"].ToString() + filename + ".pdf";

                // Save and start View
                document.Save(filename);
                if (FormHelper.Instance.Pergunta("Documento de reserva gerado com sucesso!\nDeseja visualizar?", true) == DialogResult.Yes)
                    Process.Start(filename);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
