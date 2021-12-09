using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace OriAcademyProject
{
    public partial class Form1 : Form
    {
        unPanel.ucScreen1 ucSc1 = new unPanel.ucScreen1();
        unPanel.ucScreen2 ucSc2 = new unPanel.ucScreen2();
        unPanel.ucScreen3 ucSc3 = new unPanel.ucScreen3();
        unPanel.ucScreen5 ucSc5 = new unPanel.ucScreen5();
        unPanel.ucScreen0 ucSc0 = new unPanel.ucScreen0();

        public Form1()
        {
            InitializeComponent();
            Pan_PageCenter_0.Controls.Add(ucSc0);
        }

        private void lbl_PersonalInformation_0_Click(object sender, EventArgs e)
        {
            Pan_PageCenter_0.Controls.Clear();
            Pan_PageCenter_0.Controls.Add(ucSc1);
        }

        private void lbl_PaymentInformation_0_Click(object sender, EventArgs e)
        {
            Pan_PageCenter_0.Controls.Clear();
            Pan_PageCenter_0.Controls.Add(ucSc2);
            ucSc2.LecturepaymentstatusList.Items.Clear();
            ucSc2.AllstudentList.Items.Clear();
        }

        private void lbl_ClassInformation_Click(object sender, EventArgs e)
        {
            Pan_PageCenter_0.Controls.Clear();
            Pan_PageCenter_0.Controls.Add(ucSc3);
            ucSc3.LectureInfoList_3.Items.Clear();
            ucSc3.AllstudentList_3.Items.Clear();
        }

        private void lbl_ReportInformation_0_Click(object sender, EventArgs e)
        {
            Pan_PageCenter_0.Controls.Clear();
            Pan_PageCenter_0.Controls.Add(ucSc5);
            ucSc5.lvscore.Items.Clear();
            ucSc5.lvstd.Items.Clear();
        }
    }
}
