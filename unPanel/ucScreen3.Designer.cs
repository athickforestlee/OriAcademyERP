
namespace OriAcademyProject.unPanel
{
    partial class ucScreen3
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
            this.btnFindStudent = new System.Windows.Forms.Button();
            this.txtStudentFindname = new System.Windows.Forms.TextBox();
            this.txtStudentFindnum = new System.Windows.Forms.TextBox();
            this.txtStudentFindCategory = new System.Windows.Forms.TextBox();
            this.lblStudentFind = new System.Windows.Forms.Label();
            this.lblStudentFindCategory = new System.Windows.Forms.Label();
            this.txtTeacherName_LectureInfo_3 = new System.Windows.Forms.TextBox();
            this.lblTeacherName_LectureInfo3 = new System.Windows.Forms.Label();
            this.btnSaveLecture_3 = new System.Windows.Forms.Button();
            this.btnDeleteLecture_3 = new System.Windows.Forms.Button();
            this.btnAddLecture_3 = new System.Windows.Forms.Button();
            this.txtLectureroom_LectureInfo_3 = new System.Windows.Forms.TextBox();
            this.txtLecturePrice_LectureInfo_3 = new System.Windows.Forms.TextBox();
            this.txtLectureName_LectureInfo_3 = new System.Windows.Forms.TextBox();
            this.lblLectureroom_LectureInfo3 = new System.Windows.Forms.Label();
            this.txtLectureNum_LectureInfo_3 = new System.Windows.Forms.TextBox();
            this.lblLecturePrice_LectureInfo_3 = new System.Windows.Forms.Label();
            this.lblLectureName_LectureInfo_3 = new System.Windows.Forms.Label();
            this.lblLectureNum_LectureInfo_3 = new System.Windows.Forms.Label();
            this.lblStudentList_3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.sphone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stdnum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AllstudentList_3 = new System.Windows.Forms.ListView();
            this.paynum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lecnum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LectureInfoList_3 = new System.Windows.Forms.ListView();
            this.lvLecture_View_3 = new System.Windows.Forms.ListView();
            this.lvStudentList_View_3 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnFindStudent
            // 
            this.btnFindStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(235)))), ((int)(((byte)(247)))));
            this.btnFindStudent.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFindStudent.Location = new System.Drawing.Point(815, 19);
            this.btnFindStudent.Name = "btnFindStudent";
            this.btnFindStudent.Size = new System.Drawing.Size(75, 30);
            this.btnFindStudent.TabIndex = 3;
            this.btnFindStudent.Text = "조회";
            this.btnFindStudent.UseVisualStyleBackColor = false;
            this.btnFindStudent.Click += new System.EventHandler(this.btnFindStudent_Click);
            // 
            // txtStudentFindname
            // 
            this.txtStudentFindname.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtStudentFindname.Location = new System.Drawing.Point(661, 21);
            this.txtStudentFindname.Name = "txtStudentFindname";
            this.txtStudentFindname.Size = new System.Drawing.Size(139, 31);
            this.txtStudentFindname.TabIndex = 2;
            // 
            // txtStudentFindnum
            // 
            this.txtStudentFindnum.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtStudentFindnum.Location = new System.Drawing.Point(515, 21);
            this.txtStudentFindnum.Name = "txtStudentFindnum";
            this.txtStudentFindnum.Size = new System.Drawing.Size(139, 31);
            this.txtStudentFindnum.TabIndex = 1;
            // 
            // txtStudentFindCategory
            // 
            this.txtStudentFindCategory.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtStudentFindCategory.Location = new System.Drawing.Point(183, 21);
            this.txtStudentFindCategory.Name = "txtStudentFindCategory";
            this.txtStudentFindCategory.ReadOnly = true;
            this.txtStudentFindCategory.Size = new System.Drawing.Size(141, 31);
            this.txtStudentFindCategory.TabIndex = 14;
            this.txtStudentFindCategory.Text = "오리원_강의정보";
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
            // txtTeacherName_LectureInfo_3
            // 
            this.txtTeacherName_LectureInfo_3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtTeacherName_LectureInfo_3.Location = new System.Drawing.Point(489, 597);
            this.txtTeacherName_LectureInfo_3.MaxLength = 5;
            this.txtTeacherName_LectureInfo_3.Name = "txtTeacherName_LectureInfo_3";
            this.txtTeacherName_LectureInfo_3.Size = new System.Drawing.Size(100, 27);
            this.txtTeacherName_LectureInfo_3.TabIndex = 6;
            // 
            // lblTeacherName_LectureInfo3
            // 
            this.lblTeacherName_LectureInfo3.AutoSize = true;
            this.lblTeacherName_LectureInfo3.BackColor = System.Drawing.Color.White;
            this.lblTeacherName_LectureInfo3.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTeacherName_LectureInfo3.Location = new System.Drawing.Point(428, 597);
            this.lblTeacherName_LectureInfo3.Name = "lblTeacherName_LectureInfo3";
            this.lblTeacherName_LectureInfo3.Size = new System.Drawing.Size(61, 23);
            this.lblTeacherName_LectureInfo3.TabIndex = 83;
            this.lblTeacherName_LectureInfo3.Text = "강사명";
            // 
            // btnSaveLecture_3
            // 
            this.btnSaveLecture_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(235)))), ((int)(((byte)(247)))));
            this.btnSaveLecture_3.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSaveLecture_3.Location = new System.Drawing.Point(1092, 595);
            this.btnSaveLecture_3.Name = "btnSaveLecture_3";
            this.btnSaveLecture_3.Size = new System.Drawing.Size(75, 30);
            this.btnSaveLecture_3.TabIndex = 11;
            this.btnSaveLecture_3.Text = "저장";
            this.btnSaveLecture_3.UseVisualStyleBackColor = false;
            this.btnSaveLecture_3.Click += new System.EventHandler(this.btnSaveLecture_3_Click);
            // 
            // btnDeleteLecture_3
            // 
            this.btnDeleteLecture_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(235)))), ((int)(((byte)(247)))));
            this.btnDeleteLecture_3.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDeleteLecture_3.Location = new System.Drawing.Point(1011, 595);
            this.btnDeleteLecture_3.Name = "btnDeleteLecture_3";
            this.btnDeleteLecture_3.Size = new System.Drawing.Size(75, 30);
            this.btnDeleteLecture_3.TabIndex = 10;
            this.btnDeleteLecture_3.Text = "삭제";
            this.btnDeleteLecture_3.UseVisualStyleBackColor = false;
            this.btnDeleteLecture_3.Click += new System.EventHandler(this.btnDeleteLecture_3_Click);
            // 
            // btnAddLecture_3
            // 
            this.btnAddLecture_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(235)))), ((int)(((byte)(247)))));
            this.btnAddLecture_3.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAddLecture_3.Location = new System.Drawing.Point(930, 595);
            this.btnAddLecture_3.Name = "btnAddLecture_3";
            this.btnAddLecture_3.Size = new System.Drawing.Size(75, 30);
            this.btnAddLecture_3.TabIndex = 9;
            this.btnAddLecture_3.Text = "추가";
            this.btnAddLecture_3.UseVisualStyleBackColor = false;
            this.btnAddLecture_3.Click += new System.EventHandler(this.btnAddLecture_3_Click);
            // 
            // txtLectureroom_LectureInfo_3
            // 
            this.txtLectureroom_LectureInfo_3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtLectureroom_LectureInfo_3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtLectureroom_LectureInfo_3.Location = new System.Drawing.Point(658, 597);
            this.txtLectureroom_LectureInfo_3.MaxLength = 4;
            this.txtLectureroom_LectureInfo_3.Name = "txtLectureroom_LectureInfo_3";
            this.txtLectureroom_LectureInfo_3.Size = new System.Drawing.Size(100, 27);
            this.txtLectureroom_LectureInfo_3.TabIndex = 7;
            this.txtLectureroom_LectureInfo_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLectureroom_LectureInfo_3_KeyPress);
            // 
            // txtLecturePrice_LectureInfo_3
            // 
            this.txtLecturePrice_LectureInfo_3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtLecturePrice_LectureInfo_3.HideSelection = false;
            this.txtLecturePrice_LectureInfo_3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtLecturePrice_LectureInfo_3.Location = new System.Drawing.Point(812, 597);
            this.txtLecturePrice_LectureInfo_3.MaxLength = 7;
            this.txtLecturePrice_LectureInfo_3.Name = "txtLecturePrice_LectureInfo_3";
            this.txtLecturePrice_LectureInfo_3.Size = new System.Drawing.Size(100, 27);
            this.txtLecturePrice_LectureInfo_3.TabIndex = 8;
            this.txtLecturePrice_LectureInfo_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLecturePrice_LectureInfo_3_KeyPress);
            // 
            // txtLectureName_LectureInfo_3
            // 
            this.txtLectureName_LectureInfo_3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtLectureName_LectureInfo_3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtLectureName_LectureInfo_3.Location = new System.Drawing.Point(320, 597);
            this.txtLectureName_LectureInfo_3.MaxLength = 5;
            this.txtLectureName_LectureInfo_3.Name = "txtLectureName_LectureInfo_3";
            this.txtLectureName_LectureInfo_3.Size = new System.Drawing.Size(100, 27);
            this.txtLectureName_LectureInfo_3.TabIndex = 5;
            // 
            // lblLectureroom_LectureInfo3
            // 
            this.lblLectureroom_LectureInfo3.AutoSize = true;
            this.lblLectureroom_LectureInfo3.BackColor = System.Drawing.Color.White;
            this.lblLectureroom_LectureInfo3.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblLectureroom_LectureInfo3.Location = new System.Drawing.Point(596, 597);
            this.lblLectureroom_LectureInfo3.Name = "lblLectureroom_LectureInfo3";
            this.lblLectureroom_LectureInfo3.Size = new System.Drawing.Size(61, 23);
            this.lblLectureroom_LectureInfo3.TabIndex = 75;
            this.lblLectureroom_LectureInfo3.Text = "강의실";
            // 
            // txtLectureNum_LectureInfo_3
            // 
            this.txtLectureNum_LectureInfo_3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtLectureNum_LectureInfo_3.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtLectureNum_LectureInfo_3.Location = new System.Drawing.Point(152, 597);
            this.txtLectureNum_LectureInfo_3.MaxLength = 3;
            this.txtLectureNum_LectureInfo_3.Name = "txtLectureNum_LectureInfo_3";
            this.txtLectureNum_LectureInfo_3.Size = new System.Drawing.Size(100, 27);
            this.txtLectureNum_LectureInfo_3.TabIndex = 4;
            this.txtLectureNum_LectureInfo_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLectureNum_LectureInfo_3_KeyPress);
            // 
            // lblLecturePrice_LectureInfo_3
            // 
            this.lblLecturePrice_LectureInfo_3.AutoSize = true;
            this.lblLecturePrice_LectureInfo_3.BackColor = System.Drawing.Color.White;
            this.lblLecturePrice_LectureInfo_3.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblLecturePrice_LectureInfo_3.Location = new System.Drawing.Point(765, 597);
            this.lblLecturePrice_LectureInfo_3.Name = "lblLecturePrice_LectureInfo_3";
            this.lblLecturePrice_LectureInfo_3.Size = new System.Drawing.Size(44, 23);
            this.lblLecturePrice_LectureInfo_3.TabIndex = 74;
            this.lblLecturePrice_LectureInfo_3.Text = "금액";
            // 
            // lblLectureName_LectureInfo_3
            // 
            this.lblLectureName_LectureInfo_3.AutoSize = true;
            this.lblLectureName_LectureInfo_3.BackColor = System.Drawing.Color.White;
            this.lblLectureName_LectureInfo_3.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblLectureName_LectureInfo_3.Location = new System.Drawing.Point(258, 597);
            this.lblLectureName_LectureInfo_3.Name = "lblLectureName_LectureInfo_3";
            this.lblLectureName_LectureInfo_3.Size = new System.Drawing.Size(61, 23);
            this.lblLectureName_LectureInfo_3.TabIndex = 73;
            this.lblLectureName_LectureInfo_3.Text = "강의명";
            // 
            // lblLectureNum_LectureInfo_3
            // 
            this.lblLectureNum_LectureInfo_3.AutoSize = true;
            this.lblLectureNum_LectureInfo_3.BackColor = System.Drawing.Color.White;
            this.lblLectureNum_LectureInfo_3.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblLectureNum_LectureInfo_3.Location = new System.Drawing.Point(72, 597);
            this.lblLectureNum_LectureInfo_3.Name = "lblLectureNum_LectureInfo_3";
            this.lblLectureNum_LectureInfo_3.Size = new System.Drawing.Size(78, 23);
            this.lblLectureNum_LectureInfo_3.TabIndex = 72;
            this.lblLectureNum_LectureInfo_3.Text = "강의번호";
            // 
            // lblStudentList_3
            // 
            this.lblStudentList_3.AutoSize = true;
            this.lblStudentList_3.BackColor = System.Drawing.Color.White;
            this.lblStudentList_3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStudentList_3.Location = new System.Drawing.Point(44, 94);
            this.lblStudentList_3.Name = "lblStudentList_3";
            this.lblStudentList_3.Size = new System.Drawing.Size(166, 28);
            this.lblStudentList_3.TabIndex = 71;
            this.lblStudentList_3.Text = "[전체학생리스트]";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(44, 376);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 28);
            this.label11.TabIndex = 66;
            this.label11.Text = "[강의정보]";
            // 
            // sphone
            // 
            this.sphone.Text = "핸드폰번호";
            this.sphone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sphone.Width = 200;
            // 
            // sname
            // 
            this.sname.Text = "성명";
            this.sname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sname.Width = 140;
            // 
            // stdnum
            // 
            this.stdnum.Text = "학생번호";
            this.stdnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stdnum.Width = 140;
            // 
            // AllstudentList_3
            // 
            this.AllstudentList_3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stdnum,
            this.sname,
            this.sphone});
            this.AllstudentList_3.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AllstudentList_3.FullRowSelect = true;
            this.AllstudentList_3.GridLines = true;
            this.AllstudentList_3.HideSelection = false;
            this.AllstudentList_3.Location = new System.Drawing.Point(347, 126);
            this.AllstudentList_3.Name = "AllstudentList_3";
            this.AllstudentList_3.Size = new System.Drawing.Size(577, 192);
            this.AllstudentList_3.TabIndex = 67;
            this.AllstudentList_3.UseCompatibleStateImageBehavior = false;
            this.AllstudentList_3.View = System.Windows.Forms.View.Details;
            this.AllstudentList_3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.AllstudentList_3_MouseDoubleClick);
            // 
            // paynum
            // 
            this.paynum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.paynum.Width = 0;
            // 
            // price
            // 
            this.price.Text = "금액";
            this.price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.price.Width = 100;
            // 
            // loc
            // 
            this.loc.Text = "강의실";
            this.loc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loc.Width = 120;
            // 
            // pname
            // 
            this.pname.Text = "강사명";
            this.pname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pname.Width = 120;
            // 
            // lname
            // 
            this.lname.Text = "강의명";
            this.lname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lname.Width = 120;
            // 
            // lecnum
            // 
            this.lecnum.Text = "강의번호";
            this.lecnum.Width = 120;
            // 
            // LectureInfoList_3
            // 
            this.LectureInfoList_3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lecnum,
            this.lname,
            this.pname,
            this.loc,
            this.price,
            this.paynum});
            this.LectureInfoList_3.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LectureInfoList_3.FullRowSelect = true;
            this.LectureInfoList_3.GridLines = true;
            this.LectureInfoList_3.HideSelection = false;
            this.LectureInfoList_3.Location = new System.Drawing.Point(278, 398);
            this.LectureInfoList_3.Name = "LectureInfoList_3";
            this.LectureInfoList_3.Size = new System.Drawing.Size(673, 168);
            this.LectureInfoList_3.TabIndex = 68;
            this.LectureInfoList_3.UseCompatibleStateImageBehavior = false;
            this.LectureInfoList_3.View = System.Windows.Forms.View.Details;
            this.LectureInfoList_3.Click += new System.EventHandler(this.LectureInfoList_3_Click);
            // 
            // lvLecture_View_3
            // 
            this.lvLecture_View_3.HideSelection = false;
            this.lvLecture_View_3.Location = new System.Drawing.Point(31, 356);
            this.lvLecture_View_3.Name = "lvLecture_View_3";
            this.lvLecture_View_3.Size = new System.Drawing.Size(1169, 290);
            this.lvLecture_View_3.TabIndex = 69;
            this.lvLecture_View_3.UseCompatibleStateImageBehavior = false;
            // 
            // lvStudentList_View_3
            // 
            this.lvStudentList_View_3.HideSelection = false;
            this.lvStudentList_View_3.Location = new System.Drawing.Point(31, 72);
            this.lvStudentList_View_3.Name = "lvStudentList_View_3";
            this.lvStudentList_View_3.Size = new System.Drawing.Size(1169, 274);
            this.lvStudentList_View_3.TabIndex = 70;
            this.lvStudentList_View_3.UseCompatibleStateImageBehavior = false;
            // 
            // ucScreen3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtTeacherName_LectureInfo_3);
            this.Controls.Add(this.lblTeacherName_LectureInfo3);
            this.Controls.Add(this.btnSaveLecture_3);
            this.Controls.Add(this.btnDeleteLecture_3);
            this.Controls.Add(this.btnAddLecture_3);
            this.Controls.Add(this.txtLectureroom_LectureInfo_3);
            this.Controls.Add(this.txtLecturePrice_LectureInfo_3);
            this.Controls.Add(this.txtLectureName_LectureInfo_3);
            this.Controls.Add(this.lblLectureroom_LectureInfo3);
            this.Controls.Add(this.txtLectureNum_LectureInfo_3);
            this.Controls.Add(this.lblLecturePrice_LectureInfo_3);
            this.Controls.Add(this.lblLectureName_LectureInfo_3);
            this.Controls.Add(this.lblLectureNum_LectureInfo_3);
            this.Controls.Add(this.lblStudentList_3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.AllstudentList_3);
            this.Controls.Add(this.LectureInfoList_3);
            this.Controls.Add(this.lvLecture_View_3);
            this.Controls.Add(this.lvStudentList_View_3);
            this.Controls.Add(this.btnFindStudent);
            this.Controls.Add(this.txtStudentFindname);
            this.Controls.Add(this.txtStudentFindnum);
            this.Controls.Add(this.txtStudentFindCategory);
            this.Controls.Add(this.lblStudentFind);
            this.Controls.Add(this.lblStudentFindCategory);
            this.Name = "ucScreen3";
            this.Size = new System.Drawing.Size(1280, 720);
            this.Load += new System.EventHandler(this.ucScreen3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFindStudent;
        private System.Windows.Forms.TextBox txtStudentFindname;
        private System.Windows.Forms.TextBox txtStudentFindnum;
        private System.Windows.Forms.TextBox txtStudentFindCategory;
        private System.Windows.Forms.Label lblStudentFind;
        private System.Windows.Forms.Label lblStudentFindCategory;
        private System.Windows.Forms.TextBox txtTeacherName_LectureInfo_3;
        private System.Windows.Forms.Label lblTeacherName_LectureInfo3;
        private System.Windows.Forms.Button btnSaveLecture_3;
        private System.Windows.Forms.Button btnDeleteLecture_3;
        private System.Windows.Forms.Button btnAddLecture_3;
        private System.Windows.Forms.TextBox txtLectureroom_LectureInfo_3;
        private System.Windows.Forms.TextBox txtLecturePrice_LectureInfo_3;
        private System.Windows.Forms.TextBox txtLectureName_LectureInfo_3;
        private System.Windows.Forms.Label lblLectureroom_LectureInfo3;
        private System.Windows.Forms.TextBox txtLectureNum_LectureInfo_3;
        private System.Windows.Forms.Label lblLecturePrice_LectureInfo_3;
        private System.Windows.Forms.Label lblLectureName_LectureInfo_3;
        private System.Windows.Forms.Label lblLectureNum_LectureInfo_3;
        private System.Windows.Forms.Label lblStudentList_3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ColumnHeader sphone;
        private System.Windows.Forms.ColumnHeader sname;
        private System.Windows.Forms.ColumnHeader stdnum;
        private System.Windows.Forms.ColumnHeader paynum;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader loc;
        private System.Windows.Forms.ColumnHeader pname;
        private System.Windows.Forms.ColumnHeader lname;
        private System.Windows.Forms.ColumnHeader lecnum;
        private System.Windows.Forms.ListView lvLecture_View_3;
        private System.Windows.Forms.ListView lvStudentList_View_3;
        public System.Windows.Forms.ListView LectureInfoList_3;
        public System.Windows.Forms.ListView AllstudentList_3;
    }
}
