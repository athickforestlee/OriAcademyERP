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

namespace OriAcademyProject.unPanel
{
    public partial class ucScreen5 : UserControl
    {
        string stdnum = "";

        private string StrSQL = "Data Source = localhost;Database = orieduaca; User Id=root;Password=oracle";
        private string Data_Num = null;

        public ucScreen5()
        {
            InitializeComponent();
        }

        private void lvstd_View()
        {
            this.lvstd.Items.Clear();

            var MConn = new MySqlConnection(StrSQL);
            MConn.Open();

            var Comm = new MySqlCommand("SELECT * FROM student", MConn);
            var myRead = Comm.ExecuteReader(); // insert에는 executenonquery. 조회에는 executereader

            while (myRead.Read())
            {
                var strArray = new String[] {
                    myRead["stdnum"].ToString(),
                    myRead["sname"].ToString(),
                    myRead["sphone"].ToString()
                };

                var lvt = new ListViewItem(strArray);
                this.lvstd.Items.Add(lvt);

            }
            myRead.Close();
            MConn.Close();
        }

        private void lvscore_View()
        {
            this.lvscore.Items.Clear();

            var MConn = new MySqlConnection(StrSQL);
            MConn.Open();

            var Comm = new MySqlCommand("SELECT * FROM student S1 LEFT JOIN score S2 ON S1.stdnum = S2.stdnum WHERE S1.stdnum = '" + stdnum + "'", MConn);
            var myRead = Comm.ExecuteReader(); // insert에는 executenonquery. 조회에는 executereader

            while (myRead.Read())
            {
                var strArray = new String[] {
                    myRead["scorenum"].ToString(),
                    myRead["semester"].ToString(),
                    myRead["studyname"].ToString(),
                    myRead["examname"].ToString(),
                    myRead["type"].ToString(),
                    myRead["score"].ToString(),
                    myRead["stdnum"].ToString()
                };

                var lvt = new ListViewItem(strArray);
                this.lvscore.Items.Add(lvt);

            }
            myRead.Close();
            MConn.Close();
        }

        private void lvscore_View2()
        {
            this.lvscore.Items.Clear();

            var MConn = new MySqlConnection(StrSQL);
            MConn.Open();

            stdnum = "";

            var Comm = new MySqlCommand("SELECT scorenum, semester, studyname, examname, type, score, S1.stdnum FROM score S1 LEFT JOIN student S2 ON S1.stdnum = S2.stdnum WHERE S1.stdnum = '" + stdnum + "'", MConn);
            var myRead = Comm.ExecuteReader(); // insert에는 executenonquery. 조회에는 executereader

            while (myRead.Read())
            {
                var strArray = new String[] {
                    myRead["scorenum"].ToString(),
                    myRead["semester"].ToString(),
                    myRead["studyname"].ToString(),
                    myRead["examname"].ToString(),
                    myRead["type"].ToString(),
                    myRead["score"].ToString(),
                    myRead["stdnum"].ToString()
                };

                var lvt = new ListViewItem(strArray);
                this.lvscore.Items.Add(lvt);

            }
            myRead.Close();
            MConn.Close();
        }

        private void ucScreen5_Load(object sender, EventArgs e)
        {
            this.lvstd.Items.Clear();
            this.lvscore.Items.Clear();
            lvstd_View();
        }

        private void Control_Clear1()
        {
            this.tboxscorenum.Clear();
            this.tboxsemester.Clear();
            this.tboxstudynm.Clear();
            this.tboxtestnm.Clear();
            this.tboxtype.Clear();
            this.tboxscore.Clear();
        }

        private void Control_Clear2()
        {
            this.txt_StudentFind_5.Clear();
            this.txt_StudentFindName_5.Clear();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.tboxscorenum.Text != "" && this.tboxsemester.Text != "" && this.tboxstudynm.Text != "" && this.tboxtestnm.Text != "" && this.tboxtype.Text != "" && this.tboxscore.Text != "")
                {
                    if (this.tboxscorenum.Text.Length < 11)
                    {
                        var Conn = new MySqlConnection(StrSQL);
                        Conn.Open();

                        string scstdnum = lvscore.SelectedItems[0].SubItems[6].Text;
                        string Sql = "INSERT INTO score(scorenum, semester, studyname, examname, type, score, stdnum) values(";
                        Sql += this.tboxscorenum.Text + ",'" + this.tboxsemester.Text + "','" + this.tboxstudynm.Text + "','" + this.tboxtestnm.Text + "','" + this.tboxtype.Text + "','" + this.tboxscore.Text + "'," + scstdnum + ")";

                        var Comm = new MySqlCommand(Sql, Conn);
                        int i = Comm.ExecuteNonQuery();
                        Conn.Close();

                        if (i == 1)
                        {
                            MessageBox.Show("데이터 추가됨.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lvscore_View();
                            Control_Clear1();
                            Control_Clear2();
                        }
                        else
                        {
                            MessageBox.Show("데이터 추가 실패.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("성적번호는 10자리 이하로 입력하세요.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("성적번호 중복.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("선택하신 항목이 삭제 됩니다.\r계속 하시겠습니까?", "항목 삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)

            {

                if (lvscore.SelectedItems.Count > 0)

                {

                    var Conn = new MySqlConnection(StrSQL);
                    Conn.Open();

                    string scorenum = lvscore.SelectedItems[0].SubItems[0].Text;
                    string Sql = "DELETE FROM score WHERE scorenum = ";
                    Sql += scorenum;

                    var Comm = new MySqlCommand(Sql, Conn);
                    int j = Comm.ExecuteNonQuery();
                    Conn.Close();

                    MessageBox.Show("데이터 삭제됨.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lvscore_View();
                    Control_Clear1();
                    Control_Clear2();
                }

                else

                {

                    MessageBox.Show("선택된 항목이 없습니다.");

                }

            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.tboxscorenum.Text != "" && this.tboxsemester.Text != "" && this.tboxstudynm.Text != "" && this.tboxtestnm.Text != "" && this.tboxtype.Text != "" && this.tboxscore.Text != "")
                {
                    if (this.tboxscorenum.Text.Length < 11)
                    {
                            var Conn = new MySqlConnection(StrSQL);
                            Conn.Open();

                            var MySqlAdapter = new MySqlDataAdapter("SELECT * FROM score", Conn);

                            var ds = new DataSet();
                            MySqlAdapter.Fill(ds, "dsTable");

                            var dt = ds.Tables["dsTable"].Select("scorenum = " + Convert.ToInt32(this.Data_Num),
                                null, DataViewRowState.CurrentRows);

                            DataRow drTemp;
                            drTemp = dt[0];
                            drTemp["scorenum"] = this.tboxscorenum.Text;
                            drTemp["semester"] = this.tboxsemester.Text;
                            drTemp["studyname"] = this.tboxstudynm.Text;
                            drTemp["examname"] = this.tboxtestnm.Text;
                            drTemp["type"] = this.tboxtype.Text;
                            drTemp["score"] = this.tboxscore.Text;

                            var cmdBuild = new MySqlCommandBuilder(MySqlAdapter);
                            MySqlAdapter.UpdateCommand = cmdBuild.GetUpdateCommand();
                            MySqlAdapter.Update(ds, "dsTable");
                            cmdBuild.Dispose();

                            MessageBox.Show("데이터 수정됨.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lvscore_View();
                            Control_Clear1();
                            Control_Clear2();
                    }
                    else
                    {
                        MessageBox.Show("성적 번호는 10자리 이하로 입력하세요.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("성적번호 중복.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_FindStudent_5_Click(object sender, EventArgs e)
        {
            this.lvstd.Items.Clear();

            var MConn = new MySqlConnection(StrSQL);
            MConn.Open();

            string readstdnum = this.txt_StudentFind_5.Text;
            string readstdnm = this.txt_StudentFindName_5.Text;

            var Comm = new MySqlCommand("SELECT * FROM student WHERE stdnum like '%" + readstdnum + "%' AND sname LIKE '%" + readstdnm + "%'", MConn);
            var myRead = Comm.ExecuteReader(); // insert에는 executenonquery. 조회에는 executereader

            while (myRead.Read())
            {
                var strArray = new String[] {
                    myRead["stdnum"].ToString(),
                    myRead["sname"].ToString(),
                    myRead["sphone"].ToString()
                };

                var lvt = new ListViewItem(strArray);
                this.lvstd.Items.Add(lvt);

            }
            myRead.Close();
            MConn.Close();


            Control_Clear1();
            lvscore_View2();
        }

        private void lvstd_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            stdnum = lvstd.SelectedItems[0].SubItems[0].Text;
            lvscore_View();
        }

        private void lvscore_Click(object sender, EventArgs e)
        {
            this.tboxscorenum.Text = this.lvscore.SelectedItems[0].SubItems[0].Text;
            this.tboxsemester.Text = this.lvscore.SelectedItems[0].SubItems[1].Text;
            this.tboxstudynm.Text = this.lvscore.SelectedItems[0].SubItems[2].Text;
            this.tboxtestnm.Text = this.lvscore.SelectedItems[0].SubItems[3].Text;
            this.tboxtype.Text = this.lvscore.SelectedItems[0].SubItems[4].Text;
            this.tboxscore.Text = this.lvscore.SelectedItems[0].SubItems[5].Text;
            Data_Num = this.lvscore.SelectedItems[0].SubItems[0].Text;
        }
    }
}
