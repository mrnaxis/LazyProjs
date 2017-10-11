using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkLog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private IList<string> AnalisarArquivos(string path)
        {
            if (!string.IsNullOrEmpty(path))
            {
                string[] files = Directory.GetFiles(path);
                IList<string> returns = new List<string>();
                foreach (string f in files)
                {
                    if (f.ToLower().Contains(".txt"))
                    {
                        StreamReader stream = File.OpenText(f);
                        while (!stream.EndOfStream)
                        {
                            string content = stream.ReadLine();
                            if (content.ToLower().Contains("erro"))
                                returns.Add("Erro");
                            else if (!content.ToLower().Contains("erro"))
                                returns.Add("OK");
                        }
                        stream.Close();
                    }
                }
                return returns;
            }
            else
                return null;
        }

        private void MostrarResults(FolderBrowserDialog fd)
        {
            txDir.Text = lbPorc.Text = lbSucesso.Text = lbErros.Text = string.Empty;
            if (string.IsNullOrEmpty(txDir.Text) && fd != null)
                txDir.Text = fd.SelectedPath;

            IList<string> results = AnalisarArquivos(txDir.Text);
            if (results != null)
            {
                IList<string> ok = (from r in results
                                    where r == "OK"
                                    select r).ToList();
                IList<string> erro = (from r in results
                                      where r == "Erro"
                                      select r).ToList();

                lbSucesso.Text += ok.Count.ToString();
                lbErros.Text += erro.Count.ToString();
                int oks = ok.Count, erros = erro.Count;
                int tot = oks + erros;
                lbPorc.Text += ((oks * 100) / tot).ToString();
            }
            else if (string.IsNullOrEmpty(txDir.Text))
                lbError.Text = "Digite ou Selecione um Diretório Válido";
            else
                lbError.Text = "Algo de errado aconteceu =/";
        }

        private void btDir_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fd = new FolderBrowserDialog())
            {
                DialogResult dr = fd.ShowDialog();

                if (dr == DialogResult.OK && !string.IsNullOrEmpty(fd.SelectedPath))
                    MostrarResults(fd);
                else
                    lbError.Text = "Selecione um Diretório Válido";
            }
        }

        private void btVerificaLog_Click(object sender, EventArgs e)
        {
            MostrarResults(null);
        }
    }
}
