using ltwin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ltwin
{
    public partial class DailyPlan : Form
    {
        private DateTime date;
        private PlanData job;
        private FlowLayoutPanel fPanel; // Khai báo FlowLayoutPanel

        public DailyPlan(DateTime date, PlanData job)
        {
            InitializeComponent();
            this.date = date;
            this.job = job;

            fPanel = new FlowLayoutPanel(); // Khởi tạo FlowLayoutPanel
            fPanel.Dock = DockStyle.Fill; // Đặt thuộc tính Dock để điều chỉnh kích thước tự động
            pnlJob.Controls.Add(fPanel);

            dtpkDate.Value = date;
            ShowJobByDate(date);
        }

        private void ShowJobByDate(DateTime date)
        {
            fPanel.Controls.Clear();
            if (job != null && job.Job != null)
            {
                List<PlanItem> todayJob = GetJobByDay(date);
                foreach (PlanItem item in todayJob)
                {
                    AddJob(item);
                }
            }
        }

        private void AddJob(PlanItem job)
        {
            AJob aJob = new AJob(job);
            aJob.Edited += AJob_Edited;
            aJob.Deleted += AJob_Deleted;
            fPanel.Controls.Add(aJob);
        }

        private void AJob_Deleted(object sender, EventArgs e)
        {
            AJob uc = sender as AJob;
            PlanItem job = uc.Job;

            fPanel.Controls.Remove(uc);
            this.job.Job.Remove(job);
        }

        private void AJob_Edited(object sender, EventArgs e)
        {
            // Đây là nơi để xử lý khi công việc được sửa
        }

        private List<PlanItem> GetJobByDay(DateTime date)
        {
            return job.Job.Where(p => p.Date.Date == date.Date).ToList();
        }

        private void dtpkDate_ValueChanged(object sender, EventArgs e)
        {
            // Xóa tất cả các công việc hiện tại
            fPanel.Controls.Clear();

            // Hiển thị các công việc mới cho ngày mới
            ShowJobByDate((sender as DateTimePicker).Value);
        }


       

        private void mnsiAddJob_Click(object sender, EventArgs e)
        {
            PlanItem item = new PlanItem() { Date = dtpkDate.Value };
            job.Job.Add(item);
            AddJob(item);
        }

        private void mnsiToDay_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = DateTime.Now;
        }
    }
}
    

