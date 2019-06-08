namespace CrimeReport_Windows
{
    partial class View_FIR
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_FIR));
            this.CrimeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrimeArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label1 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblCrimeText = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvCrimeSearch = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrimeSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // CrimeType
            // 
            this.CrimeType.HeaderText = "CrimeType";
            this.CrimeType.Name = "CrimeType";
            // 
            // CrimeArea
            // 
            this.CrimeArea.HeaderText = "CrimeArea";
            this.CrimeArea.Name = "CrimeArea";
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(324, 39);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(110, 24);
            this.Label1.TabIndex = 259;
            this.Label1.Text = "FIR Details";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.Color.Transparent;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.White;
            this.lblType.Location = new System.Drawing.Point(363, 86);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(53, 13);
            this.lblType.TabIndex = 258;
            this.lblType.Text = "To Date";
            // 
            // lblCrimeText
            // 
            this.lblCrimeText.AutoSize = true;
            this.lblCrimeText.BackColor = System.Drawing.Color.Transparent;
            this.lblCrimeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrimeText.ForeColor = System.Drawing.Color.White;
            this.lblCrimeText.Location = new System.Drawing.Point(101, 86);
            this.lblCrimeText.Name = "lblCrimeText";
            this.lblCrimeText.Size = new System.Drawing.Size(65, 13);
            this.lblCrimeText.TabIndex = 257;
            this.lblCrimeText.Text = "From Date";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Location = new System.Drawing.Point(573, 123);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 254;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // dgvCrimeSearch
            // 
            this.dgvCrimeSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCrimeSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.CrimeType,
            this.CrimeArea});
            this.dgvCrimeSearch.Location = new System.Drawing.Point(105, 162);
            this.dgvCrimeSearch.Name = "dgvCrimeSearch";
            this.dgvCrimeSearch.Size = new System.Drawing.Size(543, 235);
            this.dgvCrimeSearch.TabIndex = 252;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch.Location = new System.Drawing.Point(474, 123);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 253;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(190, 86);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(152, 20);
            this.dateTimePicker1.TabIndex = 261;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(445, 86);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(152, 20);
            this.dateTimePicker2.TabIndex = 262;
            // 
            // View_FIR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(749, 457);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblCrimeText);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvCrimeSearch);
            this.Controls.Add(this.btnSearch);
            
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrimeSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn CrimeType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrimeArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label lblType;
        internal System.Windows.Forms.Label lblCrimeText;
        private System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.DataGridView dgvCrimeSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}