using BA.CarWashingApp.UI;
using BA.CarWashingApp.UI.Forms;
using System.Runtime.InteropServices;

namespace BA.CarWashingApp.UI
{
    public partial class Home : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public Home()
        {
            InitializeComponent();
            random = new Random();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    //    panelTitleBar.BackColor = color;
                    //    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    //    ThemeColor.PrimaryColor = color;
                    //    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    //    btnCloseChildForm.Visible = true;
                    //}
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        public void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            this.panelCenter.Controls.Add(childForm);
            this.panelCenter.Tag = childForm;
            childForm.Show();
            label1.Text = childForm.Text;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void bntMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //private void Kayýt_Click(object sender, EventArgs e)
        //{
        //    ActivateButton(sender);
        //    PersonelKayýt personelKayýt = new PersonelKayýt();
        //    personelKayýt.anasayfa = this;
        //    OpenChildForm(personelKayýt, sender);
        //}

        //private void Ozluk_Click(object sender, EventArgs e)
        //{
        //    ActivateButton(sender);
        //    PersonelÖzlükBilgileri personelOzluk = new PersonelÖzlükBilgileri();
        //    personelOzluk.anasayfa = this;
        //    OpenChildForm(personelOzluk, sender);
        //}

        //private void Egitim_Click(object sender, EventArgs e)
        //{
        //    ActivateButton(sender);
        //    PersonelEðitimBilgileri personelEgitim = new PersonelEðitimBilgileri();
        //    personelEgitim.anasayfa = this;
        //    OpenChildForm(personelEgitim, sender);
        //}

        //private void Izin_Click(object sender, EventArgs e)
        //{
        //    ActivateButton(sender);
        //    PersonelÝzinBilgileri personelIzin = new PersonelÝzinBilgileri();
        //    personelIzin.anasayfa = this;
        //    OpenChildForm(personelIzin, sender);
        //}

        //private void Maas_Click(object sender, EventArgs e)
        //{
        //    ActivateButton(sender);
        //    PersonelMaaþBilgileri personelMaas = new PersonelMaaþBilgileri();
        //    personelMaas.anasayfa = this;
        //    OpenChildForm(personelMaas, sender);
        //}

        //private void Avans_Click(object sender, EventArgs e)
        //{
        //    ActivateButton(sender);
        //    PersonelAvansBilgileri personelAvans = new PersonelAvansBilgileri();
        //    personelAvans.anasayfa = this;
        //    OpenChildForm(personelAvans, sender);
        //}

        //private void Bordro_Click(object sender, EventArgs e)
        //{
        //    ActivateButton(sender);
        //    PersonelBordroBilgileri personelBordro = new PersonelBordroBilgileri();
        //    personelBordro.anasayfa = this;
        //    OpenChildForm(personelBordro, sender);
        //}

        private void Ayarlar_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
    }
}