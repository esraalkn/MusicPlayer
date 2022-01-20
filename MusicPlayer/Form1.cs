using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog()==DialogResult.OK) //openfiledialog browse ye bastığımızda dosyaları açıcak 
            {
                textBox1.Text = openFileDialog2.FileName; //Seçtiğimiz müzik dosyasının adı textbox da yazacak.
            }
            Player.URL = textBox1.Text;//Müzik dosyasının adı playerda yazacak.
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.play(); //Windows Media Player a ait kontrol metotları var!
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.pause();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.stop();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();//Exit a basıldığında programın kapatılmasını istiyoruz.
        }
    }
}
