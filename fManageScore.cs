using ScoreManagement.Models;

namespace ScoreManagement
{
    public partial class fManageScore : Form
    {
        EFDbContext db = new EFDbContext();
        string studentID, studentName;
        public fManageScore()
        {
            InitializeComponent();
        }

        private void btNewScore_Click(object sender, EventArgs e)
        {
            string facultyID = cbFaculty.SelectedValue == null ? null : cbFaculty.SelectedValue.ToString();
            string subjectID = cbSubjectName.SelectedValue == null ? null : cbSubjectName.SelectedValue.ToString();
            string classSubjectID = cbClassSubject.SelectedValue == null ? null : cbClassSubject.SelectedValue.ToString();
            if (!Utility.IsOpeningForm("fNewManageScore"))
            {
                fNewManageScore f = new fNewManageScore(facultyID, subjectID, classSubjectID);
                //f.MdiParent = this.MdiParent;
                f.Show();
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fManageScore_Load(object sender, EventArgs e)
        {
            cbFaculty.DisplayMember = "FacultyName";
            cbFaculty.ValueMember = "FacultyID";
            cbFaculty.DataSource = db.Faculties.Select(p => new
            {
                p.FacultyName,
                p.FacultyID
            }).ToList();
            cbFaculty.Text = null;
            cbFaculty_SelectedIndexChanged(sender, e);
            cbSubjectName_SelectedIndexChanged(sender, e);
            //comboBox1_SelectedIndexChanged(sender, e);
        }

        private void cbFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSubjectName.DisplayMember = "SubjectName";
            cbSubjectName.ValueMember = "SubjectID";
            cbSubjectName.DataSource = db.Subjects.Where(o => o.FacultyID == cbFaculty.SelectedValue)
                .Select(p => new { p.SubjectID, p.SubjectName }).ToList();
            cbSubjectName.Text = null;

        }


        private void cbSubjectName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbClassSubject.DisplayMember = "ClassName";
            cbClassSubject.ValueMember = "ClassSubjectID";
            cbClassSubject.DataSource = db.ClassSubjects.Where(o => o.SubjectID == Convert.ToInt64(cbSubjectName.SelectedValue))
                .Select(p => new { p.ClassSubjectID, p.ClassName }).ToList();
            cbClassSubject.Text = null;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Scores.Where(c => c.ClassSubjectID == cbClassSubject.SelectedValue).Select(p => new
            {
                StudentID = p.AccountID,
                StudentName = p.Account.Name,
                p.Account.GroupClassID,
                p.SubjectID,
                p.MidtermScore,
                p.FinalScore,
                AverageScore = Convert.ToString((p.MidtermScore + p.FinalScore) / 2.0),
                Failed = ((p.MidtermScore + p.FinalScore) / 2.0 < 4.0 ? true : false)
            }).ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("Delete"))
            {
                //string value;
                //MessageBox.Show(dataGridView1.SelectedRows[0].Cells["MSSV"].Value.ToString());
                if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                    studentID = selectedRow.Cells["StudentID"].Value.ToString();
                    studentName = selectedRow.Cells["StudentName"].Value.ToString();
                }
                Score score = db.Scores.Single(c => c.AccountID.Equals(studentID) &&
                c.ClassSubjectID.Equals(cbClassSubject.SelectedValue));
                if (MessageBox.Show("Bạn có chắc muốn xoá điểm môn " + cbClassSubject.Text + " của sinh viên " + studentName + " không?", "Xoá điểm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        db.Scores.Remove(score);
                        db.SaveChanges();
                        comboBox1_SelectedIndexChanged(sender, e);
                        MessageBox.Show("Xoá thành công!", "Thành công", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xoá thất bại! Error: " + ex.Message, "Thất bại", MessageBoxButtons.OK);
                    }
                }
                fManageScore_Activated(sender, e);
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("Edit"))
            {
                object selectedItem = cbClassSubject.SelectedValue;
                if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Edit"].Index)
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                    studentID = selectedRow.Cells["StudentID"].Value.ToString();
                    studentName = selectedRow.Cells["StudentName"].Value.ToString();
                }
                Score score = db.Scores.Single(c => c.AccountID.Equals(studentID) &&
                c.ClassSubjectID.Equals(cbClassSubject.SelectedValue));
                fEditScore f = new fEditScore(score.AccountID, score.ClassSubjectID);
                f.Text = "Sửa điểm sinh viên [" + studentName + "]";
                f.Show();

            }
            //dataGridView1.Refresh();
        }

        private void fManageScore_Activated(object sender, EventArgs e)
        {
            comboBox1_SelectedIndexChanged(sender, e);
            //dataGridView1.Refresh();
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Scores.Where(c => c.ClassSubjectID.Equals(cbClassSubject.SelectedValue) && c.AccountID.Contains(txtStudentID.Text)).Select(p => new
            {
                StudentID = p.AccountID,
                StudentName = p.Account.Name,
                p.Account.GroupClassID,
                p.SubjectID,
                p.MidtermScore,
                p.FinalScore,
                AverageScore = Convert.ToString((p.MidtermScore + p.FinalScore) / 2.0),
                Failed = (Convert.ToDouble(p.AverageScore) < 4.0)
            }).ToList();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //dataGridView1.Refresh();
            comboBox1_SelectedIndexChanged(sender, e);
        }
    }
}