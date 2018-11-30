using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WerewolfClient
{
    public partial class HowToForm : Form
    {
        public HowToForm()
        {
            InitializeComponent();

            English_Language(false);
            Thai_Language(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void BtnEng_Click(object sender, EventArgs e)
        {
            English_Language(true);
            Thai_Language(false);
        }

        private void BtnTh_Click(object sender, EventArgs e)
        {
            English_Language(false);
            Thai_Language(true);
        }

        private void English_Language(bool Click)
        {
            VillagerEng.Visible = Click;
            DoctorEng.Visible = Click;
            GunnerEng.Visible = Click;
            JailerEng.Visible = Click;
            PriestEng.Visible = Click;
            SeerEng.Visible = Click;
            BodyguardEng.Visible = Click;
            MediumEng.Visible = Click;

            FoolEng.Visible = Click;
            AuraseerEng.Visible = Click;
            HeadhunterEng.Visible = Click;
            SerialkillerEng.Visible = Click;
            WerewolfEng.Visible = Click;
            WolfshamanEng.Visible = Click;
            WolfseerEng.Visible = Click;
            AlphawerewolfEng.Visible = Click;
        }

        private void Thai_Language(bool Click)
        {
            VillagerTh.Visible = Click;
            DoctorTh.Visible = Click;
            GunnerTh.Visible = Click;
            JailerTh.Visible = Click;
            PriestTh.Visible = Click;
            SeerTh.Visible = Click;
            BodyguardTh.Visible = Click;
            MediumTh.Visible = Click;

            FoolTh.Visible = Click;
            AuraseerTh.Visible = Click;
            HeadhunterTh.Visible = Click;
            SerialkillerTh.Visible = Click;
            WerewolfTh.Visible = Click;
            WolfshamanTh.Visible = Click;
            WolfseerTh.Visible = Click;
            AlphawerewolfTh.Visible = Click;
        }
    }
}
