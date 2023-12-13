using Microsoft.Reporting.WinForms;
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
    public partial class fReportFailingScore : Form
    {
        EFDbContext db = new EFDbContext();
        string classSubjectName;
        string subjectName;
        public fReportFailingScore(string ClassSubjectName, string SubjectName)
        {
            InitializeComponent();
            classSubjectName = ClassSubjectName;
            subjectName = SubjectName;
        }
        private void fReportFailingScore_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(classSubjectName);
            try
            {
                var reportViewer = new ReportViewer
                {
                    ProcessingMode = ProcessingMode.Local
                };
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource(
                    "ds_Score",
                    db.Scores.Where(c => c.ClassSubject.ClassName.Contains(classSubjectName)
                    && (c.MidtermScore + c.FinalScore) / 2.0 < 4.0).Select(p => new
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
                reportViewer.LocalReport.ReportPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\rListfailingSubject.rdlc";
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
