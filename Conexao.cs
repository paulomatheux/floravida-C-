using System;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Colors;
using iText.Kernel.Pdf.Canvas.Draw;

namespace floravida
{
    class Conexao
    {
        private static SQLiteConnection conexao;
        private static SQLiteConnection ConexaoBanco()
        {
            string path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            conexao = new SQLiteConnection("Data Source = " + path + "\\controle.db");
            conexao.Open();
            return conexao;
        }

        public static DataTable Users()
        {
            DataTable table = new DataTable();
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM users";
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    adapter.Fill(table);
                    ConexaoBanco().Close();
                    return table;
                }
            }
            catch (Exception ex)
            {
                ConexaoBanco().Close();
                throw ex;
            }
        }

        public static void Cadastra(String sql)
        {
            try
            {
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                ConexaoBanco().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                ConexaoBanco().Close();
            }
        }

        public static DataTable Consulta(string sql)
        {
            DataTable table = new DataTable();

            sql = sql.Replace("/", "-");
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = sql;
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    adapter.Fill(table);
                    ConexaoBanco().Close();
                    return table;
                }
            }
            catch (Exception ex)
            {
                ConexaoBanco().Close();
                throw ex;
            }
        }

        public static void GeraPdf(DataTable tabela, String tipo) {
            String caminho;
            String paciente = "";
            String sus = "";
            if (tabela.Rows.Count > 0) {
                try {
                    caminho = SaveDialog(tipo);
                    if (caminho.Equals("Cancelado")) {
                        Console.WriteLine("Cancelado");
                    } else if (caminho.Contains("Error")) {
                        Console.WriteLine(caminho);
                    } else if (caminho.Equals("noname")) {
                        Console.WriteLine("Escolha um nome");
                    } else {

                        if (tipo.Contains("Estoque")) {
                            tipo = "ESTOQUE";
                        } else if (tipo.Contains("Paciente")) {
                            paciente = tipo.Substring(31, tipo.Length - 31);
                            sus = tipo.Substring(0, 18);
                            tipo = "Relatório de Paciente";
                        } else if (tipo.Contains("Histórico Geral")) {
                            if (tipo.Length > 20) {
                                sus = tipo.Substring(24, tipo.Length - 25);
                                String sql = "SELECT nome FROM paciente WHERE sus ='" + sus + "'";
                                Console.WriteLine(sql);
                                DataTable tab = new DataTable();
                                tab = Consulta(sql);
                                if (tab.Rows.Count > 0) {
                                    paciente = tab.Rows[0][0].ToString();
                                    Console.WriteLine(paciente);
                                }
                            }
                            tipo = "Histórico Geral";
                        }


                        DateTime data = DateTime.Now;

                        // Must have write permissions to the path folder
                        PdfWriter writer = new PdfWriter(caminho);
                        PdfDocument pdf = new PdfDocument(writer);
                        Document document = new Document(pdf);

                        // Header
                        Paragraph header = new Paragraph(tipo)
                           .SetTextAlignment(TextAlignment.CENTER)
                           .SetFontSize(20);

                        // New line
                        Paragraph newline = new Paragraph(new Text("\n"));

                        document.Add(newline);
                        document.Add(header);

                        Paragraph subheader = new Paragraph();

                        if (tipo.Contains("Paciente") | tipo.Contains("Histórico Geral")) {
                            if (paciente.Length > 0) {
                                newline = new Paragraph(new Text("\n"));
                                document.Add(newline);
                                subheader = new Paragraph(paciente)
                                   .SetTextAlignment(TextAlignment.CENTER)
                                   .SetFontSize(15);
                                document.Add(subheader);
                            }
                        }

                        if (tipo.Contains("Paciente") | tipo.Contains("Histórico Geral")) {
                            subheader = new Paragraph(sus)
                               .SetTextAlignment(TextAlignment.CENTER)
                               .SetFontSize(15);
                            document.Add(subheader);
                        }

                        // Line separator
                        LineSeparator ls = new LineSeparator(new SolidLine());
                        document.Add(ls);

                        // Add image
                        //Image img = new Image(ImageDataFactory
                        //   .Create(@"..\..\image.jpg"))
                        //   .SetTextAlignment(TextAlignment.CENTER);
                        //document.Add(img);

                        // Table
                        Table table = new Table(tabela.Columns.Count, false);
                        Cell col;
                        for (int i = 0; i < tabela.Columns.Count; i++) {
                            col = new Cell(1, 1)
                           .SetBackgroundColor(ColorConstants.GRAY)
                           .SetTextAlignment(TextAlignment.CENTER)
                           .Add(new Paragraph(tabela.Columns[i].ToString()));
                            table.AddCell(col);
                        }

                        int counter = 0;
                        for (int i = 0; i < tabela.Rows.Count; i++) {
                            counter = 0;
                            while (counter < tabela.Columns.Count) {
                                String cell = tabela.Rows[i][counter].ToString();
                                if (cell.Contains("00:00:00")) {
                                    cell = cell.Remove(11, 8);
                                }

                                Cell celula = new Cell(1, 1)
                                    .SetTextAlignment(TextAlignment.CENTER)
                                    .Add(new Paragraph(cell));
                                table.AddCell(celula);
                                counter++;
                            }
                        }

                        table.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                        document.Add(newline);
                        document.Add(table);

                        // Page numbers
                        int n = pdf.GetNumberOfPages();
                        for (int i = 1; i <= n; i++) {
                            document.ShowTextAligned(new Paragraph(String
                               .Format("page" + i + " of " + n + "\n" + data.ToShortDateString())),
                               559, 806, i, TextAlignment.RIGHT,
                               VerticalAlignment.TOP, 0);
                        }

                        // Add sub-header
                        
                        //document.ShowTextAligned(new Paragraph(String.Format(data.ToShortDateString())), 559, 806, 0, TextAlignment.RIGHT, VerticalAlignment.TOP, 0);
                        //

                        // Close document
                        document.Close();
                    }
                 } catch (Exception ex) {
                    Console.WriteLine(ex);
                }
            } else {
                MessageBox.Show("Não há registros na tabela.");
                }
            }

        public static String SaveDialog(String tipo) {
            if (tipo.Contains("Paciente")) {
                tipo = tipo.Remove(0, 18);
            }
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            DateTime data = DateTime.Now;
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog1.Filter = "Todos arquivos(*.*)|*.* |PDF(.pdf)|*.pdf";
            saveFileDialog1.FileName = "Relatório" + tipo + data.ToShortDateString().Replace("/", "-");
            saveFileDialog1.DefaultExt = ".pdf";
            saveFileDialog1.AddExtension = true;
            
            DialogResult result = saveFileDialog1.ShowDialog();
            try { 
                if (result == DialogResult.OK && saveFileDialog1.FileName != null) {
                    Console.WriteLine(saveFileDialog1.FileName);
                    return saveFileDialog1.FileName;
                } else if (saveFileDialog1.FileName == null) {
                    return "noname";
                } else if (result == DialogResult.Cancel) {
                    return "Cancelado";
                }
            } catch (Exception ex) {
                Console.WriteLine(ex);
                return "Error " + ex.ToString();
            }
            return "null";
        }
    }
}

