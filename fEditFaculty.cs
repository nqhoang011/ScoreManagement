using ScoreManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ScoreManagement
{
    public partial class fEditFaculty : Form
    {
        EFDbContext db = new EFDbContext();
        string FacultyID;
        Faculty faculty;
        public fEditFaculty(string facultyID)
        {
            InitializeComponent();
            this.FacultyID = facultyID;
        }

        private void fEditFalcuty_Load(object sender, EventArgs e)
        {
            faculty = db.Faculties.Single(c => c.FacultyID == FacultyID);
            txtFacultyName.Text = faculty.FacultyName;
            txtFacultyID.Text = faculty.FacultyID;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            faculty = db.Faculties.Single(c => c.FacultyID == FacultyID);
            if (string.IsNullOrWhiteSpace(txtFacultyName.Text))
            {
                toolTip1.Show("Tên khoa không được để trống!", txtFacultyName, 0, 0, 2000);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtFacultyID.Text))
            {
                toolTip1.Show("Mã khoa không được để trống!", txtFacultyID, 0, 0, 2000);
                return;
            }
            List<string> ID = db.Faculties.Select(p => p.FacultyID).ToList();
            if (ID.Contains(txtFacultyID.Text) && !txtFacultyID.Text.Equals(faculty.FacultyID))
            {
                toolTip1.Show("Mã khoa đã tồn tại!", txtFacultyID, 0, 0, 2000);
                return;
            }
            List<string> Name = db.Faculties.Select(p => p.FacultyName).ToList();
            if (Name.Contains(txtFacultyName.Text) && !txtFacultyName.Text.Equals(faculty.FacultyName))
            {
                toolTip1.Show("Tên khoa đã tồn tại!", txtFacultyName, 0, 0, 1000);
            }
            try
            {
                faculty.FacultyName = txtFacultyName.Text;
                faculty.FacultyID = txtFacultyID.Text;
                db.SaveChanges();
                toolTip1.Show("Lưu thay đổi thành công!", btSave, 0, 0, 2000);
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại! Error: " + ex.Message, btSave, 0, 0, 2000);
            }

        }
    }
}
