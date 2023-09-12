namespace QuizManagement.Teacher_UC
{
    partial class UC_ViewDeleteQuestion
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ViewDeleteQuestion));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnSync = new PictureBox();
            comboSet = new Guna.UI2.WinForms.Guna2ComboBox();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            btnDelete = new Guna.UI2.WinForms.Guna2Button();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            ((System.ComponentModel.ISupportInitialize)btnSync).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnSync
            // 
            btnSync.Cursor = Cursors.Hand;
            btnSync.Image = (Image)resources.GetObject("btnSync.Image");
            btnSync.Location = new Point(563, 27);
            btnSync.Name = "btnSync";
            btnSync.Size = new Size(70, 70);
            btnSync.SizeMode = PictureBoxSizeMode.StretchImage;
            btnSync.TabIndex = 24;
            btnSync.TabStop = false;
            btnSync.Click += btnSync_Click;
            // 
            // comboSet
            // 
            comboSet.BackColor = Color.Transparent;
            comboSet.BorderColor = Color.Black;
            comboSet.CustomizableEdges = customizableEdges1;
            comboSet.DrawMode = DrawMode.OwnerDrawFixed;
            comboSet.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSet.FocusedColor = Color.FromArgb(94, 148, 255);
            comboSet.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            comboSet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboSet.ForeColor = Color.Black;
            comboSet.ItemHeight = 30;
            comboSet.Location = new Point(389, 204);
            comboSet.Name = "comboSet";
            comboSet.ShadowDecoration.CustomizableEdges = customizableEdges2;
            comboSet.Size = new Size(340, 36);
            comboSet.TabIndex = 23;
            comboSet.SelectedIndexChanged += comboSet_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(390, 170);
            label2.Name = "label2";
            label2.Size = new Size(49, 29);
            label2.TabIndex = 22;
            label2.Text = "Set";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(100, 51);
            label1.Name = "label1";
            label1.Size = new Size(445, 46);
            label1.TabIndex = 21;
            label1.Text = "View Delete Questions";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 25;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            dataGridView1.Location = new Point(178, 311);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 35;
            dataGridView1.Size = new Size(970, 394);
            dataGridView1.TabIndex = 25;
            dataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            dataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dataGridView1.ThemeStyle.BackColor = Color.White;
            dataGridView1.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridView1.ThemeStyle.HeaderStyle.Height = 25;
            dataGridView1.ThemeStyle.ReadOnly = false;
            dataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            dataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridView1.ThemeStyle.RowsStyle.Height = 35;
            dataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnDelete
            // 
            btnDelete.BorderRadius = 18;
            btnDelete.BorderThickness = 1;
            btnDelete.CustomizableEdges = customizableEdges3;
            btnDelete.DisabledState.BorderColor = Color.DarkGray;
            btnDelete.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDelete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDelete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDelete.FillColor = Color.Brown;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.HoverState.BorderColor = Color.Black;
            btnDelete.HoverState.FillColor = Color.White;
            btnDelete.HoverState.ForeColor = Color.Black;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageSize = new Size(30, 30);
            btnDelete.Location = new Point(792, 747);
            btnDelete.Name = "btnDelete";
            btnDelete.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnDelete.Size = new Size(203, 64);
            btnDelete.TabIndex = 26;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = this;
            // 
            // UC_ViewDeleteQuestion
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnDelete);
            Controls.Add(dataGridView1);
            Controls.Add(btnSync);
            Controls.Add(comboSet);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UC_ViewDeleteQuestion";
            Size = new Size(1924, 1050);
            Load += UC_ViewDeleteQuestion_Load;
            ((System.ComponentModel.ISupportInitialize)btnSync).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btnSync;
        private Guna.UI2.WinForms.Guna2ComboBox comboSet;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
