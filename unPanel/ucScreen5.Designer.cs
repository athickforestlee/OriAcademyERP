
namespace OriAcademyProject.unPanel
{
    partial class ucScreen5
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_FindStudent_5 = new System.Windows.Forms.Button();
            this.txt_StudentFindName_5 = new System.Windows.Forms.TextBox();
            this.txt_StudentFind_5 = new System.Windows.Forms.TextBox();
            this.txtStudentFindCategory = new System.Windows.Forms.TextBox();
            this.lblStudentFind = new System.Windows.Forms.Label();
            this.lblStudentFindCategory = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lvstd = new System.Windows.Forms.ListView();
            this.chstdnum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chsname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chsphone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tboxscore = new System.Windows.Forms.TextBox();
            this.tboxstudynm = new System.Windows.Forms.TextBox();
            this.tboxtype = new System.Windows.Forms.TextBox();
            this.tboxsemester = new System.Windows.Forms.TextBox();
            this.tboxtestnm = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxscorenum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvscore = new System.Windows.Forms.ListView();
            this.chscorenum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chsemester = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chstudyname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chexamname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chtype = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chscore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chscstdnum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnadd = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btn_FindStudent_5
            // 
            this.btn_FindStudent_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(235)))), ((int)(((byte)(247)))));
            this.btn_FindStudent_5.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_FindStudent_5.Location = new System.Drawing.Point(815, 19);
            this.btn_FindStudent_5.Name = "btn_FindStudent_5";
            this.btn_FindStudent_5.Size = new System.Drawing.Size(75, 30);
            this.btn_FindStudent_5.TabIndex = 17;
            this.btn_FindStudent_5.Text = "조회";
            this.btn_FindStudent_5.UseVisualStyleBackColor = false;
            this.btn_FindStudent_5.Click += new System.EventHandler(this.btn_FindStudent_5_Click);
            // 
            // txt_StudentFindName_5
            // 
            this.txt_StudentFindName_5.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_StudentFindName_5.Location = new System.Drawing.Point(661, 21);
            this.txt_StudentFindName_5.Name = "txt_StudentFindName_5";
            this.txt_StudentFindName_5.Size = new System.Drawing.Size(139, 31);
            this.txt_StudentFindName_5.TabIndex = 16;
            // 
            // txt_StudentFind_5
            // 
            this.txt_StudentFind_5.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_StudentFind_5.Location = new System.Drawing.Point(515, 21);
            this.txt_StudentFind_5.Name = "txt_StudentFind_5";
            this.txt_StudentFind_5.Size = new System.Drawing.Size(139, 31);
            this.txt_StudentFind_5.TabIndex = 15;
            // 
            // txtStudentFindCategory
            // 
            this.txtStudentFindCategory.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtStudentFindCategory.Location = new System.Drawing.Point(183, 21);
            this.txtStudentFindCategory.Name = "txtStudentFindCategory";
            this.txtStudentFindCategory.ReadOnly = true;
            this.txtStudentFindCategory.Size = new System.Drawing.Size(141, 31);
            this.txtStudentFindCategory.TabIndex = 14;
            this.txtStudentFindCategory.Text = "오리원_성적관리";
            // 
            // lblStudentFind
            // 
            this.lblStudentFind.AutoSize = true;
            this.lblStudentFind.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStudentFind.Location = new System.Drawing.Point(394, 21);
            this.lblStudentFind.Name = "lblStudentFind";
            this.lblStudentFind.Size = new System.Drawing.Size(134, 25);
            this.lblStudentFind.TabIndex = 13;
            this.lblStudentFind.Text = "학생번호/성명";
            // 
            // lblStudentFindCategory
            // 
            this.lblStudentFindCategory.AutoSize = true;
            this.lblStudentFindCategory.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStudentFindCategory.Location = new System.Drawing.Point(106, 21);
            this.lblStudentFindCategory.Name = "lblStudentFindCategory";
            this.lblStudentFindCategory.Size = new System.Drawing.Size(88, 25);
            this.lblStudentFindCategory.TabIndex = 12;
            this.lblStudentFindCategory.Text = "조직분류";
            this.lblStudentFindCategory.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(44, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 28);
            this.label3.TabIndex = 34;
            this.label3.Text = "[전체학생리스트]";
            // 
            // lvstd
            // 
            this.lvstd.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chstdnum,
            this.chsname,
            this.chsphone});
            this.lvstd.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lvstd.FullRowSelect = true;
            this.lvstd.GridLines = true;
            this.lvstd.HideSelection = false;
            this.lvstd.Location = new System.Drawing.Point(347, 126);
            this.lvstd.Name = "lvstd";
            this.lvstd.Size = new System.Drawing.Size(575, 165);
            this.lvstd.TabIndex = 33;
            this.lvstd.UseCompatibleStateImageBehavior = false;
            this.lvstd.View = System.Windows.Forms.View.Details;
            this.lvstd.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvstd_MouseDoubleClick);
            // 
            // chstdnum
            // 
            this.chstdnum.Text = "학생번호";
            this.chstdnum.Width = 140;
            // 
            // chsname
            // 
            this.chsname.Text = "성명";
            this.chsname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chsname.Width = 140;
            // 
            // chsphone
            // 
            this.chsphone.Text = "핸드폰번호";
            this.chsphone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chsphone.Width = 200;
            // 
            // tboxscore
            // 
            this.tboxscore.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxscore.Location = new System.Drawing.Point(709, 601);
            this.tboxscore.Name = "tboxscore";
            this.tboxscore.Size = new System.Drawing.Size(112, 27);
            this.tboxscore.TabIndex = 50;
            // 
            // tboxstudynm
            // 
            this.tboxstudynm.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxstudynm.Location = new System.Drawing.Point(709, 565);
            this.tboxstudynm.Name = "tboxstudynm";
            this.tboxstudynm.Size = new System.Drawing.Size(112, 27);
            this.tboxstudynm.TabIndex = 49;
            // 
            // tboxtype
            // 
            this.tboxtype.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxtype.Location = new System.Drawing.Point(479, 601);
            this.tboxtype.Name = "tboxtype";
            this.tboxtype.Size = new System.Drawing.Size(112, 27);
            this.tboxtype.TabIndex = 48;
            // 
            // tboxsemester
            // 
            this.tboxsemester.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxsemester.Location = new System.Drawing.Point(479, 565);
            this.tboxsemester.Name = "tboxsemester";
            this.tboxsemester.Size = new System.Drawing.Size(112, 27);
            this.tboxsemester.TabIndex = 47;
            // 
            // tboxtestnm
            // 
            this.tboxtestnm.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxtestnm.Location = new System.Drawing.Point(230, 601);
            this.tboxtestnm.Name = "tboxtestnm";
            this.tboxtestnm.Size = new System.Drawing.Size(112, 27);
            this.tboxtestnm.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(647, 601);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 23);
            this.label8.TabIndex = 45;
            this.label8.Text = "성적";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(642, 565);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 23);
            this.label7.TabIndex = 44;
            this.label7.Text = "과목명";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(388, 601);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 23);
            this.label6.TabIndex = 43;
            this.label6.Text = "수시/정시";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(405, 565);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 23);
            this.label5.TabIndex = 42;
            this.label5.Text = "학기";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(152, 601);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 23);
            this.label4.TabIndex = 41;
            this.label4.Text = "시험명";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(45, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 28);
            this.label2.TabIndex = 40;
            this.label2.Text = "[성적정보]";
            // 
            // tboxscorenum
            // 
            this.tboxscorenum.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxscorenum.Location = new System.Drawing.Point(230, 565);
            this.tboxscorenum.Name = "tboxscorenum";
            this.tboxscorenum.Size = new System.Drawing.Size(112, 27);
            this.tboxscorenum.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(149, 565);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 38;
            this.label1.Text = "성적번호";
            // 
            // lvscore
            // 
            this.lvscore.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chscorenum,
            this.chsemester,
            this.chstudyname,
            this.chexamname,
            this.chtype,
            this.chscore,
            this.chscstdnum});
            this.lvscore.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lvscore.FullRowSelect = true;
            this.lvscore.GridLines = true;
            this.lvscore.HideSelection = false;
            this.lvscore.Location = new System.Drawing.Point(286, 369);
            this.lvscore.Name = "lvscore";
            this.lvscore.Size = new System.Drawing.Size(726, 176);
            this.lvscore.TabIndex = 37;
            this.lvscore.UseCompatibleStateImageBehavior = false;
            this.lvscore.View = System.Windows.Forms.View.Details;
            this.lvscore.Click += new System.EventHandler(this.lvscore_Click);
            // 
            // chscorenum
            // 
            this.chscorenum.Text = "성적번호";
            this.chscorenum.Width = 100;
            // 
            // chsemester
            // 
            this.chsemester.Text = "학기";
            this.chsemester.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chsemester.Width = 120;
            // 
            // chstudyname
            // 
            this.chstudyname.Text = "과목명";
            this.chstudyname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chstudyname.Width = 100;
            // 
            // chexamname
            // 
            this.chexamname.Text = "시험명";
            this.chexamname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chexamname.Width = 140;
            // 
            // chtype
            // 
            this.chtype.Text = "수시/정시";
            this.chtype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chtype.Width = 100;
            // 
            // chscore
            // 
            this.chscore.Text = "성적";
            this.chscore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chscore.Width = 70;
            // 
            // chscstdnum
            // 
            this.chscstdnum.Text = "";
            this.chscstdnum.Width = 0;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(235)))), ((int)(((byte)(247)))));
            this.btnadd.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnadd.Location = new System.Drawing.Point(881, 580);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 30);
            this.btnadd.TabIndex = 17;
            this.btnadd.Text = "추가";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(235)))), ((int)(((byte)(247)))));
            this.btndelete.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btndelete.Location = new System.Drawing.Point(962, 580);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 30);
            this.btndelete.TabIndex = 17;
            this.btndelete.Text = "삭제";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(235)))), ((int)(((byte)(247)))));
            this.btnsave.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnsave.Location = new System.Drawing.Point(1043, 580);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 30);
            this.btnsave.TabIndex = 17;
            this.btnsave.Text = "저장";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(31, 72);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1169, 241);
            this.listView1.TabIndex = 53;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(31, 324);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(1169, 322);
            this.listView2.TabIndex = 54;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // ucScreen5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvstd);
            this.Controls.Add(this.lvscore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tboxscore);
            this.Controls.Add(this.tboxstudynm);
            this.Controls.Add(this.tboxtype);
            this.Controls.Add(this.tboxsemester);
            this.Controls.Add(this.tboxtestnm);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tboxscorenum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btn_FindStudent_5);
            this.Controls.Add(this.txt_StudentFindName_5);
            this.Controls.Add(this.txt_StudentFind_5);
            this.Controls.Add(this.txtStudentFindCategory);
            this.Controls.Add(this.lblStudentFind);
            this.Controls.Add(this.lblStudentFindCategory);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listView2);
            this.Name = "ucScreen5";
            this.Size = new System.Drawing.Size(1280, 720);
            this.Load += new System.EventHandler(this.ucScreen5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_FindStudent_5;
        private System.Windows.Forms.TextBox txt_StudentFindName_5;
        private System.Windows.Forms.TextBox txt_StudentFind_5;
        private System.Windows.Forms.TextBox txtStudentFindCategory;
        private System.Windows.Forms.Label lblStudentFind;
        private System.Windows.Forms.Label lblStudentFindCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader chstdnum;
        private System.Windows.Forms.ColumnHeader chsname;
        private System.Windows.Forms.ColumnHeader chsphone;
        private System.Windows.Forms.TextBox tboxscore;
        private System.Windows.Forms.TextBox tboxstudynm;
        private System.Windows.Forms.TextBox tboxtype;
        private System.Windows.Forms.TextBox tboxsemester;
        private System.Windows.Forms.TextBox tboxtestnm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxscorenum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader chscorenum;
        private System.Windows.Forms.ColumnHeader chsemester;
        private System.Windows.Forms.ColumnHeader chstudyname;
        private System.Windows.Forms.ColumnHeader chexamname;
        private System.Windows.Forms.ColumnHeader chtype;
        private System.Windows.Forms.ColumnHeader chscore;
        private System.Windows.Forms.ColumnHeader chscstdnum;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        public System.Windows.Forms.ListView lvscore;
        public System.Windows.Forms.ListView lvstd;
    }
}
