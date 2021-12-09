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
    public partial class ucScreen3 : UserControl
    {

        private string strSQL = "Data Source = localhost; Database = orieduaca; User Id=root; Password=oracle";

        string stdnum_3 = "";
        string Data_Num = "";

        public ucScreen3()
        {
            InitializeComponent();
        }

        

        private void Control_Clear_1()
        {
            this.txtLectureNum_LectureInfo_3.Clear();
            this.txtLectureName_LectureInfo_3.Clear();
            this.txtTeacherName_LectureInfo_3.Clear();
            this.txtLectureroom_LectureInfo_3.Clear();
            this.txtLecturePrice_LectureInfo_3.Clear();
        }

        private void Control_Clear_2()
        {
            this.txtStudentFindnum.Clear();
            this.txtStudentFindname.Clear();
        }

        private void btnFindStudent_Click(object sender, EventArgs e)
        {
            this.AllstudentList_3.Items.Clear();
            var Conn = new MySqlConnection(strSQL);
            Conn.Open();

            string readstdnum = this.txtStudentFindnum.Text;
            string readstdname = this.txtStudentFindname.Text;

            string Sql = "SELECT * FROM student WHERE stdnum LIKE '%" + readstdnum + "%' AND sname LIKE '%" + readstdname + "%'";

            var Comm = new MySqlCommand(Sql, Conn);
            var myRead_1_3 = Comm.ExecuteReader();

            while (myRead_1_3.Read())
            {
                var strArray = new String[]
                {
                    myRead_1_3["stdnum"].ToString(),
                    myRead_1_3["sname"].ToString(),
                    myRead_1_3["sphone"].ToString()
                };

                var lvt = new ListViewItem(strArray);
                this.AllstudentList_3.Items.Add(lvt);
            }
            myRead_1_3.Close();
            Conn.Close();
        }

        // 전체학생리스트
        private void Student_View_3()
        {
            this.AllstudentList_3.Items.Clear();

            var MConn = new MySqlConnection(strSQL);
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
                this.AllstudentList_3.Items.Add(lvt);
            }
            myRead.Close();
            MConn.Close();
        }

        // 강의정보
        private void Lecture_View_3()
        {
            this.LectureInfoList_3.Items.Clear();

            var MConn = new MySqlConnection(strSQL);
            MConn.Open();

            var Comm = new MySqlCommand("SELECT S.stdnum, sname, sphone, email, zipcode, address, school, class, note, S.pname, pphone, paydate, bank, baccount, bname, paynum, P.stdnum, P.lecnum as plecnum, paymentyn, L.lecnum, lname, L.pname as lpname, loc, price FROM student S LEFT JOIN payment P ON S.stdnum = P.stdnum LEFT JOIN lecture L ON L.lecnum = P.lecnum WHERE S.stdnum = '" + stdnum_3 + "'", MConn);
            var myRead = Comm.ExecuteReader();

            while (myRead.Read())
            {
                var strArray = new String[]
                {
                    myRead["plecnum"].ToString(),
                    myRead["lname"].ToString(),
                    myRead["lpname"].ToString(),
                    myRead["loc"].ToString(),
                    myRead["price"].ToString(),
                    myRead["paynum"].ToString()
                };

                var lvt = new ListViewItem(strArray);
                this.LectureInfoList_3.Items.Add(lvt);
            }
            myRead.Close();
            MConn.Close();
        }

        private void ucScreen3_Load(object sender, EventArgs e)
        {
            this.AllstudentList_3.Items.Clear();
            this.LectureInfoList_3.Items.Clear();
            Student_View_3();
        }

        // 추가 버튼
        private void btnAddLecture_3_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtLectureNum_LectureInfo_3.Text != "" && this.txtLectureName_LectureInfo_3.Text != "" && this.txtTeacherName_LectureInfo_3.Text != "" && this.txtLectureroom_LectureInfo_3.Text != "" && this.txtLecturePrice_LectureInfo_3.Text != "")
                {
                    var Conn = new MySqlConnection(strSQL);
                    Conn.Open();

                    string Sql = "insert into lecture(lecnum, lname, pname, loc, price) values('";
                    Sql += this.txtLectureNum_LectureInfo_3.Text + "','" + this.txtLectureName_LectureInfo_3.Text + "','"
                        + this.txtTeacherName_LectureInfo_3.Text + "','" + this.txtLectureroom_LectureInfo_3.Text + "','"
                        + this.txtLecturePrice_LectureInfo_3.Text + "');";
                    Sql += "insert into payment(stdnum, lecnum, paymentyn) values("
                        + stdnum_3 + "," + this.txtLectureNum_LectureInfo_3.Text + ",'N');";


                    var Comm = new MySqlCommand(Sql, Conn);
                    int i = Comm.ExecuteNonQuery();
                    Conn.Close();

                    if (i == 2)
                    {
                        MessageBox.Show("추가되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Lecture_View_3();
                    }
                    else
                    {
                        MessageBox.Show("추가되지 않았습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Lecture_View_3();
                    }
                }
                else
                {
                    MessageBox.Show("모든 데이터가 입력되지 않았습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("강의번호 중복.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 삭제 버튼
        private void btnDeleteLecture_3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("선택하신 항목을 삭제하시겠습니까?", "항목삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (LectureInfoList_3.SelectedItems.Count > 0)
                {
                    var Conn = new MySqlConnection(strSQL);
                    Conn.Open();

                    string lec_3 = this.txtLectureNum_LectureInfo_3.Text;
                    string paynum_1 = LectureInfoList_3.SelectedItems[0].SubItems[5].Text;

                    string Sql = "DELETE FROM lecture WHERE lecnum = " + lec_3 + ";";
                    Sql += "DELETE FROM payment WHERE paynum = " + paynum_1 + ";";

                    var Comm = new MySqlCommand(Sql, Conn);
                    int i = Comm.ExecuteNonQuery();
                    Conn.Close();

                    MessageBox.Show("삭제되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Lecture_View_3();
                    Control_Clear_1();
                    Control_Clear_2();
                }
                else
                {
                    MessageBox.Show("선택된 항목이 없습니다.");
                }
            }


        }

        // 저장 버튼
        private void btnSaveLecture_3_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtLectureNum_LectureInfo_3.Text != "" && this.txtLectureName_LectureInfo_3.Text != "" && this.txtTeacherName_LectureInfo_3.Text != "" && this.txtLectureroom_LectureInfo_3.Text != "" && this.txtLecturePrice_LectureInfo_3.Text != "")
                {
                    var Conn = new MySqlConnection(strSQL);
                    Conn.Open();

                    var MySqlAdapter = new MySqlDataAdapter("SELECT * FROM lecture", Conn);

                    var ds = new DataSet();
                    MySqlAdapter.Fill(ds, "dsTable");

                    var dt = ds.Tables["dsTable"].Select("lecnum = " + Convert.ToInt32(this.Data_Num),
                        null, DataViewRowState.CurrentRows);

                    DataRow drTemp;
                    drTemp = dt[0];
                    drTemp["lecnum"] = this.txtLectureNum_LectureInfo_3.Text;
                    drTemp["lname"] = this.txtLectureName_LectureInfo_3.Text;
                    drTemp["pname"] = this.txtTeacherName_LectureInfo_3.Text;
                    drTemp["loc"] = this.txtLectureroom_LectureInfo_3.Text;
                    drTemp["price"] = this.txtLecturePrice_LectureInfo_3.Text;

                    var cmdBuild = new MySqlCommandBuilder(MySqlAdapter);
                    MySqlAdapter.UpdateCommand = cmdBuild.GetUpdateCommand();
                    MySqlAdapter.Update(ds, "dsTable");
                    cmdBuild.Dispose();

                    MessageBox.Show("데이터가 정상적으로 수정되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Lecture_View_3();
                    Control_Clear_1();
                    Control_Clear_2();
                }
                else
                {
                    MessageBox.Show("텍스트박스를 채워주세요.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("강의번호 중복.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LectureInfoList_3_Click(object sender, EventArgs e)
        {
            this.txtLectureNum_LectureInfo_3.Text = this.LectureInfoList_3.SelectedItems[0].SubItems[0].Text;
            this.txtLectureName_LectureInfo_3.Text = this.LectureInfoList_3.SelectedItems[0].SubItems[1].Text;
            this.txtTeacherName_LectureInfo_3.Text = this.LectureInfoList_3.SelectedItems[0].SubItems[2].Text;
            this.txtLectureroom_LectureInfo_3.Text = this.LectureInfoList_3.SelectedItems[0].SubItems[3].Text;
            this.txtLecturePrice_LectureInfo_3.Text = this.LectureInfoList_3.SelectedItems[0].SubItems[4].Text;

            Data_Num = this.LectureInfoList_3.SelectedItems[0].SubItems[0].Text;
        }

        // 전체학생리스트 더블클릭 시
        private void AllstudentList_3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            stdnum_3 = AllstudentList_3.SelectedItems[0].SubItems[0].Text;

            Lecture_View_3();
        }

        // 강의번호 textbox 입력 시 숫자 입력만 가능하게 하는 코드
        private void txtLectureNum_LectureInfo_3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == '-'))

            {
                e.Handled = true;
            }
        }

        // 강의실 textbox 입력 시 숫자 입력만 가능하게 하는 코드
        private void txtLectureroom_LectureInfo_3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == '-'))

            {
                e.Handled = true;
            }
        }

        // 금액 textbox 입력 시 숫자 입력만 가능하게 하는 코드
        private void txtLecturePrice_LectureInfo_3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == '-'))

            {
                e.Handled = true;
            }
        }

    }
}
