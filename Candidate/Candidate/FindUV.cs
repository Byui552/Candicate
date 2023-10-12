using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using DAL.Models;
using NPOI;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.XSSF.UserModel;

namespace Candidate
{
    public partial class FindUV : Form
    {
        JobServices jobServices = new JobServices();
        CandidateServices CS = new CandidateServices();
        public FindUV()
        {
            InitializeComponent();
        }

        private void FindUV_Load(object sender, EventArgs e)
        {
            cmbVTUT.DataSource = jobServices.GetAllJob();
            cmbVTUT.DisplayMember = "JobTitle";
            cmbVTUT.ValueMember = "JobId";
        }

        private void cmbVTUT_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Job j = cmbVTUT.SelectedItem as Job;
                if (j.RequiredExperience != null)
                    txtMinEX.Text = j.RequiredExperience.ToString();
                else
                    txtMinEX.Text = "0";
                if (j.RequiredMaxSalary != null)
                    txtSalary2.Text = j.RequiredMaxSalary.ToString();
                else 
                    txtSalary2.Text = "0";
                txtSkill.Text = j.RequiredSkillId.ToString();

                var listCandidate = CS.GetCandidateSkills(j.RequiredSkillId, int.Parse(txtMinEX.Text), int.Parse(txtSalary2.Text));
                FillDgv(listCandidate);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillDgv(List<CandidateSkill> listCandidate)
        {
            dgvFindUV.Rows.Clear();
            foreach (CandidateSkill candidateSkill in listCandidate)
            {
                int newRow = dgvFindUV.Rows.Add();
                dgvFindUV.Rows[newRow].Cells[0].Value = candidateSkill.CVNo;
                dgvFindUV.Rows[newRow].Cells[1].Value = candidateSkill.Candidate.FullName;
                dgvFindUV.Rows[newRow].Cells[2].Value = candidateSkill.Candidate.EmailAddress;
                dgvFindUV.Rows[newRow].Cells[3].Value = candidateSkill.Candidate.WorkExperienceYear;
                dgvFindUV.Rows[newRow].Cells[4].Value = candidateSkill.Candidate.ExpectedSalary;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ToExcel(saveFileDialog.FileName);
            }
        }

        private void ToExcel(string fileName)
        {
            // khởi tạo wb rỗng
            XSSFWorkbook wb = new XSSFWorkbook();

            // Tạo ra 1 sheet
            ISheet sheet = wb.CreateSheet();
            try
            {
                

                // Bắt đầu ghi lên sheet

                // Tạo row
                var row0 = sheet.CreateRow(0);
                // Merge lại row đầu 3 cột
                row0.CreateCell(0); // tạo ra cell trc khi merge
                CellRangeAddress cellMerge = new CellRangeAddress(0, 0, 0, 2);
                sheet.AddMergedRegion(cellMerge);
                row0.GetCell(0).SetCellValue("Thông tin ứng viên");

                var row1 = sheet.CreateRow(1);
                row1.CreateCell(0).SetCellValue("CVNo");
                row1.CreateCell(1).SetCellValue("Họ và Tên");
                row1.CreateCell(2).SetCellValue("Email");
                row1.CreateCell(3).SetCellValue("Kinh nghiệm");
                row1.CreateCell(4).SetCellValue("Mức lương");

                int rowIndex = 2;
                foreach (DataGridViewRow item in dgvFindUV.Rows)
                {
                    var newRow = sheet.CreateRow(rowIndex);
                    newRow.CreateCell(0).SetCellValue(item.Cells[0].Value.ToString());
                    newRow.CreateCell(1).SetCellValue(item.Cells[1].Value.ToString());
                    newRow.CreateCell(2).SetCellValue(item.Cells[2].Value.ToString());
                    newRow.CreateCell(3).SetCellValue(item.Cells[3].Value.ToString());
                    newRow.CreateCell(4).SetCellValue(item.Cells[4].Value.ToString());
                    rowIndex++;
                }

                FileStream fs = new FileStream(fileName, FileMode.CreateNew);
                wb.Write(fs);
                MessageBox.Show("Lưu thành công !!!", "Thông báo", MessageBoxButtons.OK);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                wb = null;
                sheet = null;
            }

        }
    }
}
