namespace mmc
{
    partial class uiMainForm
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
            this.uiDepartmentTreeView = new System.Windows.Forms.TreeView();
            this.uiEmployeeListView = new System.Windows.Forms.ListView();
            this.uiDepartmentLabel = new System.Windows.Forms.Label();
            this.uiEmployeeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uiDepartmentTreeView
            // 
            this.uiDepartmentTreeView.Location = new System.Drawing.Point(12, 25);
            this.uiDepartmentTreeView.Name = "uiDepartmentTreeView";
            this.uiDepartmentTreeView.Size = new System.Drawing.Size(153, 225);
            this.uiDepartmentTreeView.TabIndex = 0;
            // 
            // uiEmployeeListView
            // 
            this.uiEmployeeListView.Location = new System.Drawing.Point(171, 25);
            this.uiEmployeeListView.MultiSelect = false;
            this.uiEmployeeListView.Name = "uiEmployeeListView";
            this.uiEmployeeListView.Size = new System.Drawing.Size(403, 225);
            this.uiEmployeeListView.TabIndex = 1;
            this.uiEmployeeListView.UseCompatibleStateImageBehavior = false;
            // 
            // uiDepartmentLabel
            // 
            this.uiDepartmentLabel.AutoSize = true;
            this.uiDepartmentLabel.Location = new System.Drawing.Point(22, 9);
            this.uiDepartmentLabel.Name = "uiDepartmentLabel";
            this.uiDepartmentLabel.Size = new System.Drawing.Size(87, 13);
            this.uiDepartmentLabel.TabIndex = 2;
            this.uiDepartmentLabel.Text = "Подразделения";
            // 
            // uiEmployeeLabel
            // 
            this.uiEmployeeLabel.AutoSize = true;
            this.uiEmployeeLabel.Location = new System.Drawing.Point(186, 9);
            this.uiEmployeeLabel.Name = "uiEmployeeLabel";
            this.uiEmployeeLabel.Size = new System.Drawing.Size(66, 13);
            this.uiEmployeeLabel.TabIndex = 3;
            this.uiEmployeeLabel.Text = "Сотрудники";
            // 
            // uiMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 262);
            this.Controls.Add(this.uiEmployeeLabel);
            this.Controls.Add(this.uiDepartmentLabel);
            this.Controls.Add(this.uiEmployeeListView);
            this.Controls.Add(this.uiDepartmentTreeView);
            this.Name = "uiMainForm";
            this.Text = "MMC";
            this.Load += new System.EventHandler(this.uiMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView uiDepartmentTreeView;
        private System.Windows.Forms.ListView uiEmployeeListView;
        private System.Windows.Forms.Label uiDepartmentLabel;
        private System.Windows.Forms.Label uiEmployeeLabel;
    }
}

