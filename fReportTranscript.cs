using Microsoft.Reporting.WinForms;
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
    public partial class fReportTranscript : Form
    {
        EFDbContext db = new EFDbContext();
        string classSubjectName;
        string subjectName;
        public fReportTranscript(string ClassSubjectName, string SubjectName)
        {
            InitializeComponent();
            classSubjectName = ClassSubjectName;
            subjectName = SubjectName;
        }

        private void fReportTranscript_Load(object sender, EventArgs e)
        {
            try
            {
                var reportViewer = new ReportViewer
                {
                    ProcessingMode = ProcessingMode.Local
                };
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource(
                    "ds_View_AccountScore",
                    db.Scores.Where(c => c.ClassSubject.ClassName == classSubjectName).Select(p => new
                    {
                        StudentID = p.AccountID,
                        StudentName = p.Account.Name,
                        GroupClass = p.Account.GroupClass.GroupName,
                        p.MidtermScore,
                        p.FinalScore,
                        p.AverageScore,
                        Result = (p.AverageScore < 4.0 ? "Chưa đạt" : "Đạt")
                    }).ToList()
                ));
                reportViewer.Dock = DockStyle.Fill;
                reportViewer.LocalReport.ReportPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\rStudentScore.rdlc";
                ReportParameter[] parameters = new ReportParameter[2];
                parameters[0] = new ReportParameter("SubjectName", subjectName);
                parameters[1] = new ReportParameter("ClassSubjectName", classSubjectName);
                reportViewer.LocalReport.SetParameters(parameters);
                Controls.Add(reportViewer);
                reportViewer.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
