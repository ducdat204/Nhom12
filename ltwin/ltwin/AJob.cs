using System;
using System.Windows.Forms;
using ltwin;

namespace ltwin
{
    public partial class AJob : UserControl
    {
        private PlanItem job;

        public PlanItem Job
        {
            get { return job; }
            set { job = value; }
        }

        public event EventHandler Edited;
        public event EventHandler Deleted;

        public AJob(PlanItem job)
        {
            InitializeComponent();
            cbStatus.DataSource = PlanItem.ListStatus;
            this.Job = job;
            ShowInfo();
        }

        private void ShowInfo()
        {
            txbJob.Text = Job.Job;
            nmFromHours.Value = Job.FromTime.X;
            nmFromMinute.Value = Job.FromTime.Y;
            nmToHours.Value = Job.ToTime.X;
            nmToMinute.Value = Job.ToTime.Y;
            cbStatus.SelectedIndex = PlanItem.ListStatus.IndexOf(Job.Status);
            ckbDone.Checked = PlanItem.ListStatus.IndexOf(Job.Status) == (int)EPlanItem.DONE;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Deleted != null)
                Deleted(this, new EventArgs());
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Job.Job = txbJob.Text;
            Job.FromTime = new System.Drawing.Point((int)nmFromHours.Value, (int)nmFromMinute.Value);
            Job.ToTime = new System.Drawing.Point((int)nmToHours.Value, (int)nmToMinute.Value);
            Job.Status = PlanItem.ListStatus[cbStatus.SelectedIndex];

            if (Edited != null)
                Edited(this, new EventArgs());
        }

        private void ckbDone_CheckedChanged(object sender, EventArgs e)
        {
            cbStatus.SelectedIndex = ckbDone.Checked ? (int)EPlanItem.DONE : (int)EPlanItem.DOING;
        }
    }
}
