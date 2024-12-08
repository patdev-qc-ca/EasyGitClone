using System;
using System.Runtime.InteropServices;
using System.Diagnostics;
#pragma warning disable CS8622 // La nullabilité des types référence dans le type du paramètre ne correspond pas au délégué cible (probablement en raison des attributs de nullabilité).
#pragma warning disable CS8602 // Déréférencement d'une éventuelle référence null.
namespace EasyGitClone
{
    public partial class Form1 : Form
    {
        [DllImport("shell32.dll", CharSet = CharSet.Auto)] private static extern int ShellAbout(IntPtr hWnd, string szApp, string szOtherStuff, IntPtr hIcon);
        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) { e.Effect = DragDropEffects.Copy; }
            else { e.Effect = DragDropEffects.None; }
        }
        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) { textBox1.Text = e.Data.GetData(DataFormats.Text) as string; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.InitialDirectory = Environment.CurrentDirectory;
            folderBrowserDialog1.Multiselect = false;
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.DesktopDirectory;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string test = Clipboard.GetText();
            if (test.Substring(0, 18).ToLower() == "https://github.com")
            {
                textBox1.Text = test + ".git";
                test = textBox1.Text;
                if (test.Length > 4)
                {
                    if (test.Substring(test.Length - 4, 4).ToLower() == ".git")
                    {
                        string nPath = test.Replace("https://github.com", "").Replace(".git", "").Replace("/", "\\");
                        textBox3.Text = textBox2.Text + nPath;
                    }
                }
            }
            else
            {
                MessageBox.Show(test + " n'est pas conforme au format attendu");
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string cmd = $"\"C:\\Program Files\\Git\\bin\\git.exe\" clone {textBox1.Text} \"{textBox3.Text}\"";
            if (MessageBox.Show(cmd, "Continuer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Process.Start(new ProcessStartInfo(cmd) { UseShellExecute = false });

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Text = Application.ProductName + " " + Application.ProductVersion + " " + Environment.OSVersion.Platform + " " + Environment.OSVersion.VersionString;
            textBox2.Text = Environment.CurrentDirectory;
            textBox1.AllowDrop = true;
            textBox1.DragEnter += new DragEventHandler(textBox1_DragEnter);
            textBox1.DragDrop += new DragEventHandler(textBox1_DragDrop);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShellAbout(this.Handle, Application.ProductName.ToString(), $"Version {Application.ProductVersion}\n(c) 2024 Patrice Waechter-Ebling", IntPtr.Zero);
        }
    }
}
