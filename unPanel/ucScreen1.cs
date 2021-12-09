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
    public partial class ucScreen1 : UserControl
    {
        string stdnum = "";

        private string strSQL = "Data Source = localhost; Database = orieduaca; User Id=root;Password=oracle";
        private string Data_Num = null;

        public ucScreen1()
        {
            InitializeComponent();
        }

        //|----------------------------|
        //|화면 내 텍스트박스 비우는 함수 |
        //|----------------------------|
        private void AllClear_1()
        {
            this.txt_StudentNum_1.Clear(); //학생번호
            this.txt_StudentName_1.Clear(); //성명
            this.txt_StudentPhoneNum_1.Clear(); //전화번호
            this.txt_StudentEmail_1.Clear(); //이메일
            this.txt_StudentPlaceNum_1.Clear(); //주소 지번
            this.txt_StudentPlaceDetail_1.Clear(); //주소 상세
            this.txt_StudentSchool_1.Clear(); //학교
            this.txt_StudentClass_1.Clear(); // 학년/반
            this.txt_StudentExtraInfo_1.Clear(); // 특이사항

            this.txt_ParentName_1.Clear(); //보호자 성명
            this.txt_ParentPhoneNum_1.Clear(); //보호자 전화번호
            this.txt_ParentPayday_1.Clear(); //수납일(매월)
            this.txt_ParentBank_1.Clear(); //거래은행
            this.txt_ParentBankNum_1.Clear(); //계좌번호
            this.txt_ParentBankOwner_1.Clear(); //부모님 성함
        }

        //|----------------------------|
        //|검색 텍스트 박스  비우는 함수 |
        //|----------------------------|
        private void FindTextBoxClear_1()
        {
            this.txt_FindStudentNumberInsertBox_1.Clear(); //학생번호 검색칸 Clear
            this.txt_FindStudentNameInsertBox_1.Clear(); // 학생이름 검색칸 Clear
        }

        //|--------------------------|
        //|데이터 테이블 불러오는 함수 |
        //|--------------------------|
        private void View_1()
        {
            this.lv_StudentList_1.Items.Clear();
            var Mconn = new MySqlConnection(strSQL);
            Mconn.Open();

            var Comm = new MySqlCommand("Select * From student", Mconn);
            var MyRead = Comm.ExecuteReader();

            while (MyRead.Read())
            {
                var strArray = new string[] {
                    MyRead["stdnum"].ToString(), //학생번호
                    MyRead["sname"].ToString(),  //성명
                    MyRead["sphone"].ToString(), //전화번호
                    MyRead["email"].ToString(),  //이메일
                    MyRead["zipcode"].ToString(),  //주소(지번)
                    MyRead["address"].ToString(),  //주소(상세주소)
                    MyRead["school"].ToString(),  //학교
                    MyRead["class"].ToString(),  //학년/반
                    MyRead["note"].ToString(),  //특이사항

                    MyRead["pname"].ToString(), //보호자 성명
                    MyRead["pphone"].ToString(), //보호자 전화번호
                    MyRead["paydate"].ToString(), //수납일(매월)
                    MyRead["bank"].ToString(),  //거래은행
                    MyRead["baccount"].ToString(),  //계좌번호
                    MyRead["bname"].ToString()  //계좌주 성명
                };

                var lvt = new ListViewItem(strArray);
                this.lv_StudentList_1.Items.Add(lvt);
            }
            MyRead.Close();
            Mconn.Close();
        }
        //|--------------------------------------------|
        //|학생 리스트(하단부) 클릭시 텍스트박스 글자 생성 |
        //|--------------------------------------------|
        private void lv_StudentList_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_StudentList_1.SelectedItems.Count > 0)
            {
                this.txt_StudentNum_1.Text = this.lv_StudentList_1.SelectedItems[0].SubItems[0].Text; //학생번호
                this.txt_StudentName_1.Text = this.lv_StudentList_1.SelectedItems[0].SubItems[1].Text; //성명
                this.txt_StudentPhoneNum_1.Text = this.lv_StudentList_1.SelectedItems[0].SubItems[2].Text; //전화번호
                this.txt_StudentEmail_1.Text = this.lv_StudentList_1.SelectedItems[0].SubItems[3].Text; //이메일
                this.txt_StudentPlaceNum_1.Text = this.lv_StudentList_1.SelectedItems[0].SubItems[4].Text; //주소(지번)
                this.txt_StudentPlaceDetail_1.Text = this.lv_StudentList_1.SelectedItems[0].SubItems[5].Text; //주소(상세)
                this.txt_StudentSchool_1.Text = this.lv_StudentList_1.SelectedItems[0].SubItems[6].Text; //학교
                this.txt_StudentClass_1.Text = this.lv_StudentList_1.SelectedItems[0].SubItems[7].Text; //학년/반
                this.txt_StudentExtraInfo_1.Text = this.lv_StudentList_1.SelectedItems[0].SubItems[8].Text; //특이사항

                this.txt_ParentName_1.Text = this.lv_StudentList_1.SelectedItems[0].SubItems[9].Text; //보호자성명
                this.txt_ParentPhoneNum_1.Text = this.lv_StudentList_1.SelectedItems[0].SubItems[10].Text; //보호자 번호
                this.txt_ParentPayday_1.Text = this.lv_StudentList_1.SelectedItems[0].SubItems[11].Text; //수납일(매월)
                this.txt_ParentBank_1.Text = this.lv_StudentList_1.SelectedItems[0].SubItems[12].Text; //거래은행
                this.txt_ParentBankNum_1.Text = this.lv_StudentList_1.SelectedItems[0].SubItems[13].Text; //계좌번호
                this.txt_ParentBankOwner_1.Text = this.lv_StudentList_1.SelectedItems[0].SubItems[14].Text; //계좌소유주

                Data_Num = this.lv_StudentList_1.SelectedItems[0].SubItems[0].Text;
            }
        }
        //|--------------------------|
        //|데이터 저장 버튼 및 이벤트  |
        //|--------------------------|
        private void btn_SaveStudent_1_Click(object sender, EventArgs e)
        {
            try
            {
                //if 해당 칸이 비어 있지 않다면...
                if (this.txt_StudentNum_1.Text != ""
                    && this.txt_StudentName_1.Text != "")
                {
                    var Conn = new MySqlConnection(strSQL);
                    Conn.Open();

                    var MySqlAdapter = new MySqlDataAdapter("Select * From Student", Conn);

                    var ds = new DataSet();
                    MySqlAdapter.Fill(ds, "dsTable");

                    //재정의
                    var dt = ds.Tables["dsTable"].Select("stdnum =" + Convert.ToInt32(this.Data_Num), null, DataViewRowState.CurrentRows);

                    DataRow drTemp;
                    drTemp = dt[0];
                    drTemp["stdnum"] = this.txt_StudentNum_1.Text; //학생번호
                    drTemp["sname"] = this.txt_StudentName_1.Text; //성명
                    drTemp["sphone"] = this.txt_StudentPhoneNum_1.Text; //전화번호
                    drTemp["email"] = this.txt_StudentEmail_1.Text;  //이메일
                    drTemp["zipcode"] = this.txt_StudentPlaceNum_1.Text;  //주소(지번)
                    drTemp["address"] = this.txt_StudentPlaceDetail_1.Text;  //주소(상세주소)
                    drTemp["school"] = this.txt_StudentSchool_1.Text;  //학교
                    drTemp["class"] = this.txt_StudentClass_1.Text;  //학년/반
                    drTemp["note"] = this.txt_StudentExtraInfo_1.Text;  //특이사항

                    drTemp["pname"] = this.txt_ParentName_1.Text; //보호자 성명
                    drTemp["pphone"] = this.txt_ParentPhoneNum_1.Text; //보호자 전화번호
                    drTemp["paydate"] = this.txt_ParentPayday_1.Text; //수납일(매월)
                    drTemp["bank"] = this.txt_ParentBank_1.Text; //거래은행
                    drTemp["baccount"] = this.txt_ParentBankNum_1.Text; //계좌번호
                    drTemp["bname"] = this.txt_ParentBankOwner_1.Text; //계좌 소유주

                    var cmdBuild = new MySqlCommandBuilder(MySqlAdapter);
                    MySqlAdapter.UpdateCommand = cmdBuild.GetUpdateCommand();
                    MySqlAdapter.Update(ds, "dsTable");
                    cmdBuild.Dispose();

                    MessageBox.Show("데이터가 정상적으로 수정되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    View_1();
                    AllClear_1();

                }
                else
                {
                    MessageBox.Show("필수 데이터가 기재되지 않았습니다\r(학생번호, 학생이름 확인).", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("학생번호 중복.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //|--------------------------|
        //|학생정보 추가, 수정 이벤트  |
        //|--------------------------|
        private void btn_AddStudent_1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_StudentNum_1.Text != ""
                    && this.txt_StudentName_1.Text != "")
                {
                    var Conn = new MySqlConnection(strSQL);
                    Conn.Open();

                    string Sql = "insert into student(stdnum, sname, sphone, email, zipcode, address, school, class, note, pname, pphone, paydate, bank, baccount, bname) values(";
                    Sql += this.txt_StudentNum_1.Text + ",'"  //학생번호(학번)
                        + this.txt_StudentName_1.Text + "','"  //성명
                        + this.txt_StudentPhoneNum_1.Text + "','"  //전화번호
                        + this.txt_StudentEmail_1.Text + "','" //이메일
                        + this.txt_StudentPlaceNum_1.Text + "','" //주소(지번)
                        + this.txt_StudentPlaceDetail_1.Text + "','" //주소(상세주소)
                        + this.txt_StudentSchool_1.Text + "','" //학교
                        + this.txt_StudentClass_1.Text + "','" //학년/반
                        + this.txt_StudentExtraInfo_1.Text + "','" //특이사항

                        + this.txt_ParentName_1.Text + "','" //보호자 성함
                        + this.txt_ParentPhoneNum_1.Text + "','" //보호자 전화번호
                        + this.txt_ParentPayday_1.Text + "','" //수납일(매월)
                        + this.txt_ParentBank_1.Text + "','"//거래은행
                        + this.txt_ParentBankNum_1.Text + "','" //계좌번호
                        + this.txt_ParentBankOwner_1.Text + "'" //예금주 정보
                        + ")";

                    var Comm = new MySqlCommand(Sql, Conn);
                    int i = Comm.ExecuteNonQuery();
                    Conn.Close();

                    if (i == 1)
                    {
                        MessageBox.Show("데이터가 정상적으로 저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        View_1();
                        AllClear_1();
                    }
                    else
                    {
                        MessageBox.Show("데이터가 정상적으로 저장되지 않았습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("필수 데이터가 기재되지 않았습니다\r(학생번호, 학생이름 확인).", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("학생번호 중복.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //|--------------------------|
        //|학생정보 삭제 이벤트        |
        //|--------------------------|
        private void btn_DeleteStudent_1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("선택하신 항목이 삭제 됩니다.\r계속 하시겠습니까?", "항목 삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)

            {

                if (lv_StudentList_1.SelectedItems.Count > 0)

                {

                    var Conn = new MySqlConnection(strSQL);
                    Conn.Open();

                    string stdnum = lv_StudentList_1.SelectedItems[0].SubItems[0].Text;
                    string Sql = "DELETE FROM student WHERE stdnum = ";
                    Sql += stdnum;

                    var Comm = new MySqlCommand(Sql, Conn);
                    int j = Comm.ExecuteNonQuery();
                    Conn.Close();

                    MessageBox.Show("데이터 삭제됨.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    View_1();
                    AllClear_1();
                }

                else

                {

                    MessageBox.Show("선택된 항목이 없습니다.");

                }

            }
        }
        //|--------------------------|
        //|학생정보 조회 이벤트        |
        //|--------------------------|
        private void ucScreen5_Click(object sender, EventArgs e)
        {
            this.lv_StudentList_1.Items.Clear();
            var Conn = new MySqlConnection(strSQL);
            Conn.Open();

            //변수 설정(학번 입력 텍스트박스 $ 성명 입력 텍스트박스)
            string input_studentNum_1 = this.txt_FindStudentNumberInsertBox_1.Text;
            string input_studentName_1 = this.txt_FindStudentNameInsertBox_1.Text;

            var Comm = new MySqlCommand("SELECT * FROM student WHERE stdnum like '%" + input_studentNum_1 + "%' AND sname LIKE '%" + input_studentName_1 + "%'", Conn);
            var myRead = Comm.ExecuteReader(); // insert에는 executenonquery. 조회에는 executereader

            while (myRead.Read())
            {
                var strArray_1 = new String[]
                {
                   myRead["stdnum"].ToString(),
                   myRead["sname"].ToString(),
                   myRead["sphone"].ToString(),
                   myRead["email"].ToString(),
                   myRead["zipcode"].ToString(),
                   myRead["address"].ToString(),
                   myRead["school"].ToString(),
                   myRead["class"].ToString(),
                   myRead["note"].ToString(),
                   myRead["pname"].ToString(),
                   myRead["pphone"].ToString(),
                   myRead["paydate"].ToString(),
                   myRead["bank"].ToString(),
                   myRead["baccount"].ToString(),
                   myRead["bname"].ToString()
                };

                var lvt_1 = new ListViewItem(strArray_1);
                this.lv_StudentList_1.Items.Add(lvt_1);
            }
            myRead.Close();
            Conn.Close();
        }

        private void ucScreen1_Load(object sender, EventArgs e)
        {
            View_1();
        }

        private void txt_StudentNum_1_TextChanged(object sender, EventArgs e) //학생번호 텍스트박스 입력제한
        {
            if (txt_StudentNum_1.Text.Length >= 8)
            {
                MessageBox.Show("학생번호를 초과하여 입력하였습니다.");
                this.txt_StudentNum_1.Clear();
            }
        }

        private void txt_StudentName_1_TextChanged(object sender, EventArgs e) //학생성명 텍스트 박스 입력제한
        {
            if (txt_StudentName_1.Text.Length >= 6)
            {
                MessageBox.Show("학생성명를 초과하여 입력하였습니다.");
                this.txt_StudentName_1.Clear();
            }
        }

        private void txt_StudentPhoneNum_1_TextChanged(object sender, EventArgs e) //학생번호 텍스트 박스 입력제한
        {
            if (txt_StudentPhoneNum_1.Text.Length >= 12)
            {
                MessageBox.Show("학생번호를 초과하여 입력하였습니다.");
                this.txt_StudentPhoneNum_1.Clear();
            }
        }

        private void txt_StudentEmail_1_TextChanged(object sender, EventArgs e)  //학생메일 텍스트 박스 입력제한
        {
            if (txt_StudentEmail_1.Text.Length >= 31)
            {
                MessageBox.Show("학생메일을 초과하여 입력하였습니다.");
                this.txt_StudentEmail_1.Clear();
            }
        }

        private void txt_StudentPlaceNum_1_TextChanged(object sender, EventArgs e) //학생주소(우편번호) 텍스트 박스 입력제한
        {
            if (txt_StudentPlaceNum_1.Text.Length >= 6)
            {
                MessageBox.Show("우편번호를 초과하여 입력하였습니다.");
                this.txt_StudentPlaceNum_1.Clear();
            }
        }

        private void txt_StudentPlaceDetail_1_TextChanged(object sender, EventArgs e) //학생주소 텍스트 박스 입력제한
        {
            if (txt_StudentPlaceDetail_1.Text.Length >= 51)
            {
                MessageBox.Show("주소를 초과하여 입력하였습니다.");
                this.txt_StudentPlaceDetail_1.Clear();
            }
        }

        private void txt_StudentSchool_1_TextChanged(object sender, EventArgs e) //학교명 텍스트 박스 입력제한
        {
            if (txt_StudentSchool_1.Text.Length >= 16)
            {
                MessageBox.Show("학교명을 초과하여 입력하였습니다.");
                this.txt_StudentSchool_1.Clear();
            }
        }

        private void txt_StudentClass_1_TextChanged(object sender, EventArgs e) //학생 학년/반 입력제한
        {
            if (txt_StudentClass_1.Text.Length >= 5)
            {
                MessageBox.Show("학년/반을 초과하여 입력하였습니다.");
                this.txt_StudentClass_1.Clear();
            }
        }

        private void txt_StudentExtraInfo_1_TextChanged(object sender, EventArgs e) //학생특이사항 입력제한
        {
            if (txt_StudentExtraInfo_1.Text.Length >= 200)
            {
                MessageBox.Show("특이사항을 초과하여 입력하였습니다.");
                this.txt_StudentExtraInfo_1.Clear();
            }
        }

        private void txt_ParentName_1_TextChanged(object sender, EventArgs e) //보호자 성함 입력제한
        {
            if (txt_ParentName_1.Text.Length >= 6)
            {
                MessageBox.Show("보호자 성명을 초과하여 입력하였습니다.");
                this.txt_ParentName_1.Clear();
            }
        }

        private void txt_ParentPhoneNum_1_TextChanged(object sender, EventArgs e) //보호자 전화번호 입력제한
        {
            if (txt_ParentPhoneNum_1.Text.Length >= 12)
            {
                MessageBox.Show("보호자 전화번호를 초과하여 입력하였습니다.");
                this.txt_ParentPhoneNum_1.Clear();
            }
        }

        private void txt_ParentPayday_1_TextChanged(object sender, EventArgs e) //수납일(매월) 입력제한
        {
            if (txt_ParentPayday_1.Text.Length >= 3)
            {
                MessageBox.Show("수납일을 초과하여 입력하였습니다.");
                this.txt_ParentPayday_1.Clear();
            }
        }

        private void txt_ParentBank_1_TextChanged(object sender, EventArgs e) //거래은행 입력제한
        {
            if (txt_ParentBank_1.Text.Length >= 9)
            {
                MessageBox.Show("거래은행을 초과하여 입력하였습니다.");
                this.txt_ParentBank_1.Clear();
            }
        }

        private void txt_ParentBankNum_1_TextChanged(object sender, EventArgs e) //계좌번호 입력제한
        {
            if (txt_ParentBankNum_1.Text.Length >= 21)
            {
                MessageBox.Show("계좌번호를 초과하여 입력하였습니다.");
                this.txt_ParentBankNum_1.Clear();
            }
        }

        private void txt_ParentBankOwner_1_TextChanged(object sender, EventArgs e) //예금주 입력제한
        {
            if (txt_ParentBankOwner_1.Text.Length >= 6)
            {
                MessageBox.Show("예금주명을 초과하여 입력하였습니다.");
                this.txt_ParentBankOwner_1.Clear();
            }
        }
    }
}
