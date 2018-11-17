
using ImageMagick;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exiff_değiştirici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ListBox lsbislem = new ListBox();
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Multiselect = true;
            op.Filter = "Resim dosyaları (*.jpg)|*.jpg*";
            op.ShowDialog();
            for (int i = 0; i < op.FileNames.Length; i++)
            {
                lsbResimlistesi.Items.Add(op.SafeFileNames[i]);
                lsbislem.Items.Add(op.FileNames[i]);
            }
           
          
            



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Hazır";
           
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lsbResimlistesi.Items.Remove(lsbResimlistesi.SelectedItem);
            lsbislem.Items.Remove(lsbislem.SelectedItem);
        }

        private void lsbResimlistesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < lsbislem.Items.Count; i++)
                {
                    int sonuc = lsbislem.Items[i].ToString().IndexOf(lsbResimlistesi.SelectedItem.ToString());
                    if (sonuc > 0)
                    {
                        lsbislem.SelectedItem = lsbislem.Items[i];
                    }
                }
                txtAciklama.Text = "";
                txtBaslik.Text = "";
                txtEtiketler.Text = "";
                txtKonu.Text = "";
                secilen = lsbislem.SelectedItem.ToString();

                using (MagickImage image = new MagickImage(secilen))
                {
                    try
                    {
                        ExifProfile profile2 = image.GetExifProfile();
                        
                        ExifValue Baslik = profile2.GetValue(ImageMagick.ExifTag.XPTitle);
                        ExifValue Aciklama = profile2.GetValue(ImageMagick.ExifTag.XPComment);
                        ExifValue Etiketler = profile2.GetValue(ImageMagick.ExifTag.XPKeywords);
                        ExifValue Konu = profile2.GetValue(ImageMagick.ExifTag.XPSubject);

                        txtBaslik.Text = Encoding.Unicode.GetString((byte[])Baslik.Value);
                        txtAciklama.Text = Encoding.Unicode.GetString((byte[])Aciklama.Value);
                        txtEtiketler.Text = Encoding.Unicode.GetString((byte[])Etiketler.Value);
                        txtKonu.Text = Encoding.Unicode.GetString((byte[])Konu.Value);
                    }
                    catch (Exception)
                    {


                    }






                }
            }
            catch (Exception)
            {

              
            }
           
        }
        string secilen = "";
        private void button4_Click(object sender, EventArgs e)
        {
            if (lsbResimlistesi.SelectedItem==null)
            {
                MessageBox.Show("Tekli düzenleme yapabilmek için önce seçim yapın !");
                return;
            }
            prgDurum.Maximum = 1;
      
            using (MagickImage image = new MagickImage(secilen))
            {
                toolStripStatusLabel1.Text = "Lütfen bekleyin.";
                ExifProfile profile2 = image.GetExifProfile();

                if (profile2==null)
                {
                    profile2 = new ExifProfile();
                }
                  
                
                  
                



                // ExifProfile profile = new ExifProfile();
                // profile = new ExifProfile();
                if (true)
                {

                }
                if (chbBaslik.Checked)
                {
                 //   profile2.RemoveValue(ImageMagick.ExifTag.XPTitle);
                    byte[] d = Encoding.Unicode.GetBytes(txtBaslik.Text);
                    profile2.SetValue(ImageMagick.ExifTag.XPTitle, d);
                    profile2.SetValue(ImageMagick.ExifTag.ImageDescription, txtBaslik.Text);
                
                }
                if (chbKonu.Checked)
                {
                   // profile2.RemoveValue(ImageMagick.ExifTag.XPSubject);
                    byte[] d = Encoding.Unicode.GetBytes(txtKonu.Text);
                    profile2.SetValue(ImageMagick.ExifTag.XPSubject, d);
                }
                if (chbEtiketler .Checked)
                {
                  //  profile2.RemoveValue(ImageMagick.ExifTag.XPKeywords);
                    profile2.RemoveValue(ImageMagick.ExifTag.XPKeywords);
                    byte[] d = Encoding.Unicode.GetBytes(txtEtiketler.Text);
                    profile2.SetValue(ImageMagick.ExifTag.XPKeywords, d);
                }

                if (chbAciklama .Checked)
                {
                  //  profile2.RemoveValue(ImageMagick.ExifTag.XPComment);
                    byte[] d = Encoding.Unicode.GetBytes(txtAciklama.Text);
                    profile2.SetValue(ImageMagick.ExifTag.XPComment, d);
                }
                foreach (var item in image.ProfileNames)
                {
                    image.RemoveProfile(item);
                }
                image.AddProfile(profile2);
                image.Write(secilen);
                prgDurum.Value = 1;
                lblDurum.Text = "İşlem başarılı";
                toolStripStatusLabel1.Text = "Hazır";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Lütfen bekleyin.";
            int toplam = 0;
            int basarili = 0;
            int basarisiz = 0;
            toplam =lsbislem .Items.Count;
            prgDurum.Maximum = toplam;

            for (int i = 0; i < lsbislem.Items.Count; i++)
            {
                try
                {
                    using (MagickImage image = new MagickImage(lsbislem .Items[i].ToString()))
                    {
                        ExifProfile profile2 = image.GetExifProfile();

                        if (profile2==null)
                        {
                            profile2 = new ExifProfile();
                        }
                      
                        



                        // ExifProfile profile = new ExifProfile();
                        // profile = new ExifProfile();
                        if (true)
                        {

                        }
                        if (chbBaslik.Checked)
                        {
                            byte[] d = Encoding.Unicode.GetBytes(txtBaslik.Text);
                            profile2.SetValue(ImageMagick.ExifTag.XPTitle, d);
                            profile2.SetValue(ImageMagick.ExifTag.ImageDescription, txtBaslik.Text);
                            // profile2.SetValue(ImageMagick.ExifTag.)
                        }
                        if (chbKonu.Checked)
                        {
                            byte[] d = Encoding.Unicode.GetBytes(txtKonu.Text);
                            profile2.SetValue(ImageMagick.ExifTag.XPSubject, d);
                        }
                        if (chbEtiketler.Checked)
                        {
                          //  profile2.RemoveValue(ImageMagick.ExifTag.XPKeywords);
                            byte[] d = Encoding.Unicode.GetBytes(txtEtiketler.Text);
                            profile2.SetValue(ImageMagick.ExifTag.XPKeywords, d);
                        }

                        if (chbAciklama.Checked)
                        {
                            byte[] d = Encoding.Unicode.GetBytes(txtAciklama.Text);
                            profile2.SetValue(ImageMagick.ExifTag.XPComment, d);
                        }
                        foreach (var item in image.ProfileNames)
                        {
                            image.RemoveProfile(item);
                        }
                        image.AddProfile(profile2);
                        image.Write(lsbislem .Items[i].ToString());
                        prgDurum.Value = 1;
                        basarili++;
                      
                    }
                }
                catch (Exception)
                {

                    basarisiz++;
                }
               finally

                {
                  
                }
             
                prgDurum.Value = basarisiz + basarili;
                lblDurum.Text = "Toplam işlem: " + toplam.ToString() + " Başarılı işlem:" + basarili.ToString() + " Başarısız işlem: " + basarisiz.ToString();
               
            }
            lblDurum.Text = "İşlem tamamlandı. Toplam işlem: " + toplam.ToString() + " Başarılı işlem:" + basarili.ToString() + " Başarısız işlem: " + basarisiz.ToString();
            toolStripStatusLabel1.Text = "Hazır";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.normyazilim.com");
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu program Norm Yazılım tarafından geliştirilmiş ve ücretsiz olarak kullanıma sunulmuştur. www.normyazilim.com","Program hakkında");
            
            
        }
    }
}
