using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OriAcademyProject.unPanel
{
    public partial class ucScreen2 : UserControl
    {
        private string StrSQL = "Data Source=localhost;Database=orieduaca;User Id=root;Password=oracle";
        private string Data_Num = null;

        string stdnum_1 = "";

        public ucScreen2()
        {
            InitializeComponent();
        }

        // 수납여부 정보 
        private void payment_View()
        {
            this.LecturepaymentstatusList.Items.Clear();

            var MConn = new MySqlConnection(StrSQL);
            MConn.Open();

            var Comm = new MySqlCommand("SELECT P.lecnum, L.lecnum, lname, price, paymentyn, paynum, P.stdnum, loc, S.stdnum, sname, sphone FROM payment P LEFT JOIN lecture L ON P.lecnum = L.lecnum LEFT JOIN student S ON P.stdnum = S.stdnum WHERE P.stdnum = '" + stdnum_1 + "'", MConn);


            var myRead = Comm.ExecuteReader();

            while (myRead.Read())
            {
                var strArray = new String[]
                {
                    myRead["paynum"].ToString(),
                    myRead["lecnum"].ToString(),
                    myRead["lname"].ToString(),
                    myRead["price"].ToString(),
                    myRead["paymentyn"].ToString()
                };

                var lvt = new ListViewItem(strArray);
                this.LecturepaymentstatusList.Items.Add(lvt);
            }
            myRead.Close();
            MConn.Close();

        }

        // 학생리스트뷰
        private void student_View()
        {
            this.AllstudentList.Items.Clear();

            var MConn = new MySqlConnection(StrSQL);
            MConn.Open();

            var Comm = new MySqlCommand("Select*From student", MConn);
            var myRead = Comm.ExecuteReader();

            while (myRead.Read())
            {
                var strArray = new String[]
                {
                    myRead["stdnum"].ToString(),
                    myRead["sname"].ToString(),
                    myRead["sphone"].ToString()
                };

                var lvt = new ListViewItem(strArray);
                this.AllstudentList.Items.Add(lvt);
            }
            myRead.Close();
            MConn.Close();
        }

        private void ucScreen2_Load(object sender, EventArgs e)
        {
            this.AllstudentList.Items.Clear();
            this.LecturepaymentstatusList.Items.Clear();
            student_View();
        }

        private void Control_Clear()
        {
            this.txtname.Clear();
            this.txtnum.Clear();
            this.txtprice.Clear();
            this.txtstatus.Clear();
        }

        private void btnFindStudent_Click(object sender, EventArgs e)
        {
            this.AllstudentList.Items.Clear();
            var Conn = new MySqlConnection(StrSQL);
            Conn.Open();

            string readstdnum = this.txtStudentFind.Text;
            string readstdname = this.txtStudentFindName.Text;


            string Sql = "SELECT * FROM student WHERE stdnum LIKE '%" + readstdnum + "%' AND sname LIKE '%" + readstdname + "%'";
            // SELECT * FROM student WHERE stdnum like '%변수%' AND sname LIKE '%변수%'

            var Comm = new MySqlCommand(Sql, Conn);
            var myRead_1 = Comm.ExecuteReader();

            while (myRead_1.Read())
            {
                var strArray = new String[]
                {
                    myRead_1["stdnum"].ToString(),
                    myRead_1["sname"].ToString(),
                    myRead_1["sphone"].ToString()
                };

                var lvt = new ListViewItem(strArray);
                this.AllstudentList.Items.Add(lvt);
            }
            myRead_1.Close();
            Conn.Close();
        }

        private void btnpaymentsave_Click(object sender, EventArgs e)
        {
            if ((txtstatus.Text == "Y" || txtstatus.Text == "N") && (this.txtnum.Text != "" && this.txtname.Text != "" && this.txtprice.Text != "" && this.txtstatus.Text != ""))
            {
                var Conn = new MySqlConnection(StrSQL);
                Conn.Open();

                string paynum_1 = this.LecturepaymentstatusList.SelectedItems[0].SubItems[0].Text;
                var Comm = new MySqlCommand("update payment set paymentyn='" + this.txtstatus.Text + "' WHERE paynum = '" + paynum_1 + "'", Conn);
                var myRead = Comm.ExecuteReader();

                while (myRead.Read())
                {
                    var strArray = new String[]
                    {
                            myRead["paymentyn"].ToString()
                    };
                    var lvt = new ListViewItem(strArray);
                    this.LecturepaymentstatusList.Items.Add(lvt);
                }
                myRead.Close();
                Conn.Close();

                MessageBox.Show("데이터가 정상적으로 수정되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Y 또는 N 으로만 입력해 주세요.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            payment_View();
            Control_Clear();
        }

        private void AllstudentList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            stdnum_1 = AllstudentList.SelectedItems[0].SubItems[0].Text;

            payment_View();
        }

        private void LecturepaymentstatusList_Click(object sender, EventArgs e)
        {
            this.txtnum.Text = this.LecturepaymentstatusList.SelectedItems[0].SubItems[1].Text;
            this.txtname.Text = this.LecturepaymentstatusList.SelectedItems[0].SubItems[2].Text;
            this.txtprice.Text = this.LecturepaymentstatusList.SelectedItems[0].SubItems[3].Text;
            this.txtstatus.Text = this.LecturepaymentstatusList.SelectedItems[0].SubItems[4].Text;
            Data_Num = this.LecturepaymentstatusList.SelectedItems[0].SubItems[1].Text;
        }
    }
}
