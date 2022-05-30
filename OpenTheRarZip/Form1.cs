using Aspose.Zip;
using Aspose.Zip.Rar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTheRarZip.Models;

namespace OpenTheRarZip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string type = null;
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        string folderName;
        ForKey fk = new ForKey();

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Rar - Zip Seçiniz";
            ofd.Filter = "(Rar-Zip) |*.Rar;*.Zip;*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;
                button2.Enabled = true;
            }
            // Veri Tipini Buluyoruz
            string ext = Path.GetExtension(ofd.SafeFileName);
            type = ext.ToLower();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fbd.ShowDialog();
            folderName = fbd.SelectedPath;
            timer1.Start();
            progressBar1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Hide();
            button2.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                textBox2.Text = fk.SadeceSayilar(trackBar1.Value);
                if (textBox1.Text != "")
                {
                    if (type == ".zip")
                    {
                        using (FileStream AppFile = File.Open(textBox1.Text, FileMode.Open))
                        {
                            using (var archive = new Archive(AppFile, new ArchiveLoadOptions() { DecryptionPassword = $@"{textBox2.Text}" }))
                            {
                                progressBar1.Show();
                                try
                                {
                                    archive.ExtractToDirectory($@"{folderName}\Files\");
                                    timer1.Stop();
                                    MessageBox.Show($@"Zip Şifresi: {textBox2.Text}", "Şifre Bulundu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                catch (Exception ex)
                                {

                                    //throw;
                                }
                                progressBar1.Hide();
                            }
                        }
                    }
                    if (type == ".rar")
                    {
                        RarArchive archive = new RarArchive(textBox1.Text);
                        try
                        {


                            archive.ExtractToDirectory($@"{folderName}\Files\", $@"{textBox2.Text}");

                            long size = 0;
                            string[] folders = Directory.GetFiles($@"{folderName}\Files\", "*.*", SearchOption.AllDirectories);
                            foreach (string folder in folders)
                            {
                                FileInfo fileInfo = new FileInfo(folder);
                                size += fileInfo.Length;
                            }
                            if (size > 10)
                            {
                                timer1.Stop();
                                MessageBox.Show($@"Rar Şifresi: {textBox2.Text}","Şifre Bulundu",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                        catch (Exception ex)
                        {

                            //throw;
                        }
                    }
                }
            }
            if (radioButton2.Checked == true)
            {
                textBox2.Text = fk.SadeceKucukHarfler(trackBar1.Value);
                if (textBox1.Text != "")
                {
                    if (type == ".zip")
                    {
                        using (FileStream AppFile = File.Open(textBox1.Text, FileMode.Open))
                        {
                            using (var archive = new Archive(AppFile, new ArchiveLoadOptions() { DecryptionPassword = $@"{textBox2.Text}" }))
                            {
                                progressBar1.Show();
                                try
                                {
                                    archive.ExtractToDirectory($@"{folderName}\Files\");
                                    timer1.Stop();
                                    MessageBox.Show($@"Zip Şifresi: {textBox2.Text}", "Şifre Bulundu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                catch (Exception ex)
                                {

                                    //throw;
                                }
                                progressBar1.Hide();
                            }
                        }
                    }
                    if (type == ".rar")
                    {
                        RarArchive archive = new RarArchive(textBox1.Text);
                        try
                        {


                            archive.ExtractToDirectory($@"{folderName}\Files\", $@"{textBox2.Text}");

                            long size = 0;
                            string[] folders = Directory.GetFiles($@"{folderName}\Files\", "*.*", SearchOption.AllDirectories);
                            foreach (string folder in folders)
                            {
                                FileInfo fileInfo = new FileInfo(folder);
                                size += fileInfo.Length;
                            }
                            if (size > 10)
                            {
                                timer1.Stop();
                                MessageBox.Show($@"Rar Şifresi: {textBox2.Text}", "Şifre Bulundu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                        catch (Exception ex)
                        {

                            //throw;
                        }
                    }
                }

            }
            if (radioButton3.Checked == true)
            {
                textBox2.Text = fk.SadeceBuyukHarfler(trackBar1.Value);
                if (textBox1.Text != "")
                {
                    if (type == ".zip")
                    {
                        using (FileStream AppFile = File.Open(textBox1.Text, FileMode.Open))
                        {
                            using (var archive = new Archive(AppFile, new ArchiveLoadOptions() { DecryptionPassword = $@"{textBox2.Text}" }))
                            {
                                progressBar1.Show();
                                try
                                {
                                    archive.ExtractToDirectory($@"{folderName}\Files\");
                                    timer1.Stop();
                                    MessageBox.Show($@"Zip Şifresi: {textBox2.Text}", "Şifre Bulundu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                catch (Exception ex)
                                {

                                    //throw;
                                }
                                progressBar1.Hide();
                            }
                        }
                    }
                    if (type == ".rar")
                    {
                        RarArchive archive = new RarArchive(textBox1.Text);
                        try
                        {


                            archive.ExtractToDirectory($@"{folderName}\Files\", $@"{textBox2.Text}");

                            long size = 0;
                            string[] folders = Directory.GetFiles($@"{folderName}\Files\", "*.*", SearchOption.AllDirectories);
                            foreach (string folder in folders)
                            {
                                FileInfo fileInfo = new FileInfo(folder);
                                size += fileInfo.Length;
                            }
                            if (size > 10)
                            {
                                timer1.Stop();
                                MessageBox.Show($@"Rar Şifresi: {textBox2.Text}", "Şifre Bulundu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                        catch (Exception ex)
                        {

                            //throw;
                        }
                    }
                }

            }
            if (radioButton4.Checked == true)
            {
                textBox2.Text = fk.BuyukVeKucukHarfler(trackBar1.Value);
                if (textBox1.Text != "")
                {
                    if (type == ".zip")
                    {
                        using (FileStream AppFile = File.Open(textBox1.Text, FileMode.Open))
                        {
                            using (var archive = new Archive(AppFile, new ArchiveLoadOptions() { DecryptionPassword = $@"{textBox2.Text}" }))
                            {
                                progressBar1.Show();
                                try
                                {
                                    archive.ExtractToDirectory($@"{folderName}\Files\");
                                    timer1.Stop();
                                    MessageBox.Show($@"Zip Şifresi: {textBox2.Text}", "Şifre Bulundu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                catch (Exception ex)
                                {

                                    //throw;
                                }
                                progressBar1.Hide();
                            }
                        }
                    }
                    if (type == ".rar")
                    {
                        RarArchive archive = new RarArchive(textBox1.Text);
                        try
                        {


                            archive.ExtractToDirectory($@"{folderName}\Files\", $@"{textBox2.Text}");

                            long size = 0;
                            string[] folders = Directory.GetFiles($@"{folderName}\Files\", "*.*", SearchOption.AllDirectories);
                            foreach (string folder in folders)
                            {
                                FileInfo fileInfo = new FileInfo(folder);
                                size += fileInfo.Length;
                            }
                            if (size > 10)
                            {
                                timer1.Stop();
                                MessageBox.Show($@"Rar Şifresi: {textBox2.Text}", "Şifre Bulundu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                        catch (Exception ex)
                        {

                            //throw;
                        }
                    }
                }

            }
            if (radioButton5.Checked == true)
            {
                textBox2.Text = fk.BuyukVeKucukHarflerVeSayilar(trackBar1.Value);
                if (textBox1.Text != "")
                {
                    if (type == ".zip")
                    {
                        using (FileStream AppFile = File.Open(textBox1.Text, FileMode.Open))
                        {
                            using (var archive = new Archive(AppFile, new ArchiveLoadOptions() { DecryptionPassword = $@"{textBox2.Text}" }))
                            {
                                progressBar1.Show();
                                try
                                {
                                    archive.ExtractToDirectory($@"{folderName}\Files\");
                                    timer1.Stop();
                                    MessageBox.Show($@"Zip Şifresi: {textBox2.Text}", "Şifre Bulundu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                catch (Exception ex)
                                {

                                    //throw;
                                }
                                progressBar1.Hide();
                            }
                        }
                    }
                    if (type == ".rar")
                    {
                        RarArchive archive = new RarArchive(textBox1.Text);
                        try
                        {


                            archive.ExtractToDirectory($@"{folderName}\Files\", $@"{textBox2.Text}");

                            long size = 0;
                            string[] folders = Directory.GetFiles($@"{folderName}\Files\", "*.*", SearchOption.AllDirectories);
                            foreach (string folder in folders)
                            {
                                FileInfo fileInfo = new FileInfo(folder);
                                size += fileInfo.Length;
                            }
                            if (size > 10)
                            {
                                timer1.Stop();
                                MessageBox.Show($@"Rar Şifresi: {textBox2.Text}", "Şifre Bulundu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                        catch (Exception ex)
                        {

                            //throw;
                        }
                    }
                }

            }
            if (radioButton6.Checked == true)
            {
                textBox2.Text = fk.BuyukVeKucukHarflerVeSayilarVeSimgeler(trackBar1.Value);
                if (textBox1.Text != "")
                {
                    if (type == ".zip")
                    {
                        using (FileStream AppFile = File.Open(textBox1.Text, FileMode.Open))
                        {
                            using (var archive = new Archive(AppFile, new ArchiveLoadOptions() { DecryptionPassword = $@"{textBox2.Text}" }))
                            {
                                progressBar1.Show();
                                try
                                {
                                    archive.ExtractToDirectory($@"{folderName}\Files\");
                                    timer1.Stop();
                                    MessageBox.Show($@"Zip Şifresi: {textBox2.Text}", "Şifre Bulundu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                catch (Exception ex)
                                {

                                    //throw;
                                }
                                progressBar1.Hide();
                            }
                        }
                    }
                    if (type == ".rar")
                    {
                        RarArchive archive = new RarArchive(textBox1.Text);
                        try
                        {


                            archive.ExtractToDirectory($@"{folderName}\Files\", $@"{textBox2.Text}");

                            long size = 0;
                            string[] folders = Directory.GetFiles($@"{folderName}\Files\", "*.*", SearchOption.AllDirectories);
                            foreach (string folder in folders)
                            {
                                FileInfo fileInfo = new FileInfo(folder);
                                size += fileInfo.Length;
                            }
                            if (size > 10)
                            {
                                timer1.Stop();
                                MessageBox.Show($@"Rar Şifresi: {textBox2.Text}", "Şifre Bulundu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                        catch (Exception ex)
                        {

                            //throw;
                        }
                    }
                }

            }


        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = trackBar1.Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://memleketyazilim.com/");
        }
    }
}
