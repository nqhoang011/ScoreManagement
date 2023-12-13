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

namespace ScoreManagement
{
    public partial class fEditGroupClass1 : Form
    {
        string groupClassID;
        EFDbContext db = new EFDbContext();
        public fEditGroupClass1(string groupClassID)
        {
            InitializeComponent();
            this.groupClassID = groupClassID;
        }

        private void fEditGroupClass1_Load(object sender, EventArgs e)
        {
            string facultyID = db.GroupClasses.Single(c => c.GroupClassID.Equals(groupClassID)).FacultyID;
            cbFaculty.ValueMember = "FacultyID";
            cbFaculty.DisplayMember = "FacultyName";
            cbFaculty.DataSource = db.Faculties.Select(p => new
            {
                p.FacultyID,
                p.FacultyName
            }).ToList();
            cbFaculty.Text = db.Faculties.Single(c => c.FacultyID.Equals(facultyID)).FacultyName;
            txtGroupClassName.Text = db.GroupClasses.Single(c => c.GroupClassID.Equals(groupClassID)).GroupName;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                GroupClass groupClass = db.GroupClasses.Single(c => c.GroupClassID.Equals(groupClassID));
                groupClass.GroupName = txtGroupClassName.Text;
                groupClass.FacultyID = cbFaculty.SelectedValue.ToString();
                db.SaveChanges();
                MessageBox.Show("Lưu thay đổi thành công!", "Thành công", MessageBoxButtons.OK);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu thay đổi thất bại! Error: " + ex.Message, "Thất bại", MessageBoxButtons.OK);
            }
        }
    }
}
