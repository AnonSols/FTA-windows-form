namespace FitnessTracker.Views
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblWelcome;
        private Label lblDailyGoal;
        private Label lblCaloriesBurned;
        private ListBox lstRecent;
        private ListBox lstBreakdown;
        private Button btnLogActivity;
        private Button btnLogout;
        private Button btnSetGoal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblWelcome = new Label();
            lstRecent = new ListBox();
            lstBreakdown = new ListBox();
            btnLogActivity = new Button();
            btnLogout = new Button();
            btnSetGoal = new Button();
            lblDailyGoal = new Label();
            lblCaloriesBurned = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.DarkSlateBlue;
            lblWelcome.Location = new Point(39, 31);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(193, 40);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome Back!";
            // 
            // lstRecent
            // 
            lstRecent.Font = new Font("Segoe UI", 10F);
            lstRecent.ItemHeight = 17;
            lstRecent.Location = new Point(39, 163);
            lstRecent.Name = "lstRecent";
            lstRecent.Size = new Size(350, 106);
            lstRecent.TabIndex = 3;
            // 
            // lstBreakdown
            // 
            lstBreakdown.Font = new Font("Segoe UI", 10F);
            lstBreakdown.ItemHeight = 17;
            lstBreakdown.Location = new Point(425, 163);
            lstBreakdown.Name = "lstBreakdown";
            lstBreakdown.Size = new Size(350, 106);
            lstBreakdown.TabIndex = 4;
            // 
            // btnLogActivity
            // 
            btnLogActivity.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogActivity.ForeColor = Color.DarkSlateBlue;
            btnLogActivity.Location = new Point(70, 320);
            btnLogActivity.Name = "btnLogActivity";
            btnLogActivity.Size = new Size(150, 30);
            btnLogActivity.TabIndex = 5;
            btnLogActivity.Text = "Log Activity";
            btnLogActivity.Click += BtnLogActivity_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.DarkSlateBlue;
            btnLogout.Location = new Point(600, 320);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(150, 30);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.Click += BtnLogout_Click;
            // 
            // btnSetGoal
            // 
            btnSetGoal.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSetGoal.ForeColor = Color.DarkSlateBlue;
            btnSetGoal.Location = new Point(332, 320);
            btnSetGoal.Name = "btnSetGoal";
            btnSetGoal.Size = new Size(150, 30);
            btnSetGoal.TabIndex = 6;
            btnSetGoal.Text = "Set Goal";
            btnSetGoal.Click += BtnSetGoal_Click;
            // 
            // lblDailyGoal
            // 
            lblDailyGoal.Font = new Font("Segoe UI", 12F);
            lblDailyGoal.Location = new Point(264, 41);
            lblDailyGoal.Name = "lblDailyGoal";
            lblDailyGoal.Size = new Size(228, 30);
            lblDailyGoal.TabIndex = 1;
            // 
            // lblCaloriesBurned
            // 
            lblCaloriesBurned.Font = new Font("Segoe UI", 12F);
            lblCaloriesBurned.Location = new Point(507, 40);
            lblCaloriesBurned.Name = "lblCaloriesBurned";
            lblCaloriesBurned.Size = new Size(268, 30);
            lblCaloriesBurned.TabIndex = 2;
            lblCaloriesBurned.Click += lblCaloriesBurned_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkSlateBlue;
            label2.Location = new Point(39, 129);
            label2.Name = "label2";
            label2.Size = new Size(193, 31);
            label2.TabIndex = 9;
            label2.Text = "Recent Activities";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateBlue;
            label1.Location = new Point(425, 129);
            label1.Name = "label1";
            label1.Size = new Size(193, 31);
            label1.TabIndex = 10;
            label1.Text = "Activities Breakdown";
            // 
            // DashboardForm
            // 
            ClientSize = new Size(800, 400);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(lblWelcome);
            Controls.Add(lblDailyGoal);
            Controls.Add(lblCaloriesBurned);
            Controls.Add(lstRecent);
            Controls.Add(lstBreakdown);
            Controls.Add(btnLogActivity);
            Controls.Add(btnSetGoal);
            Controls.Add(btnLogout);
            Name = "DashboardForm";
            Text = "Dashboard";
            Load += DashboardForm_Load;
            ResumeLayout(false);
        }
        private Label label1;
        private Label label2;
    }
}
