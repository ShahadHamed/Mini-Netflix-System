namespace project01
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ComboBox comboBoxMovies;
        private System.Windows.Forms.ComboBox comboBoxRate;
        private System.Windows.Forms.Button btnWatch;
        private System.Windows.Forms.Button btnRate;
        private System.Windows.Forms.DataGridView dataGridView1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblUser = new Label();
            comboBoxMovies = new ComboBox();
            comboBoxRate = new ComboBox();
            btnWatch = new Button();
            btnRate = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUser.ForeColor = Color.Yellow;
            lblUser.Location = new Point(50, 9);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(300, 25);
            lblUser.TabIndex = 0;
            lblUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxMovies
            // 
            comboBoxMovies.BackColor = Color.Black;
            comboBoxMovies.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMovies.ForeColor = Color.White;
            comboBoxMovies.Location = new Point(30, 50);
            comboBoxMovies.Name = "comboBoxMovies";
            comboBoxMovies.Size = new Size(200, 23);
            comboBoxMovies.TabIndex = 1;
            // 
            // comboBoxRate
            // 
            comboBoxRate.BackColor = Color.Black;
            comboBoxRate.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRate.ForeColor = Color.White;
            comboBoxRate.Location = new Point(30, 90);
            comboBoxRate.Name = "comboBoxRate";
            comboBoxRate.Size = new Size(200, 23);
            comboBoxRate.TabIndex = 2;
            // 
            // btnWatch
            // 
            btnWatch.BackColor = Color.DarkRed;
            btnWatch.ForeColor = Color.White;
            btnWatch.Location = new Point(250, 50);
            btnWatch.Name = "btnWatch";
            btnWatch.Size = new Size(100, 30);
            btnWatch.TabIndex = 3;
            btnWatch.Text = "Watch";
            btnWatch.UseVisualStyleBackColor = false;
            btnWatch.Click += btnWatch_Click;
            // 
            // btnRate
            // 
            btnRate.BackColor = Color.DarkBlue;
            btnRate.ForeColor = Color.White;
            btnRate.Location = new Point(250, 90);
            btnRate.Name = "btnRate";
            btnRate.Size = new Size(100, 30);
            btnRate.TabIndex = 4;
            btnRate.Text = "Rate";
            btnRate.UseVisualStyleBackColor = false;
            btnRate.Click += btnRate_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.Black;
            dataGridView1.Location = new Point(30, 140);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(320, 120);
            dataGridView1.TabIndex = 5;
            // 
            // Form1
            // 
            BackColor = Color.FromArgb(25, 25, 25);
            ClientSize = new Size(400, 280);
            Controls.Add(lblUser);
            Controls.Add(comboBoxMovies);
            Controls.Add(comboBoxRate);
            Controls.Add(btnWatch);
            Controls.Add(btnRate);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Mini Netflix";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }
    }
}