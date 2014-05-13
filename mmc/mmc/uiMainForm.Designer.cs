namespace Mmc
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
            this.fullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.birthDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uiDepartmentLabel = new System.Windows.Forms.Label();
            this.uiEmployeeLabel = new System.Windows.Forms.Label();
            this.uiMmcSplitContainer = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.uiMmcSplitContainer)).BeginInit();
            this.uiMmcSplitContainer.Panel1.SuspendLayout();
            this.uiMmcSplitContainer.Panel2.SuspendLayout();
            this.uiMmcSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiDepartmentTreeView
            // 
            this.uiDepartmentTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiDepartmentTreeView.Location = new System.Drawing.Point(11, 24);
            this.uiDepartmentTreeView.Name = "uiDepartmentTreeView";
            this.uiDepartmentTreeView.Size = new System.Drawing.Size(152, 238);
            this.uiDepartmentTreeView.TabIndex = 0;
            this.uiDepartmentTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.uiDepartmentTreeView_AfterSelect);
            // 
            // uiEmployeeListView
            // 
            this.uiEmployeeListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiEmployeeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fullName,
            this.birthDate});
            this.uiEmployeeListView.Location = new System.Drawing.Point(14, 24);
            this.uiEmployeeListView.MultiSelect = false;
            this.uiEmployeeListView.Name = "uiEmployeeListView";
            this.uiEmployeeListView.Size = new System.Drawing.Size(464, 238);
            this.uiEmployeeListView.TabIndex = 1;
            this.uiEmployeeListView.UseCompatibleStateImageBehavior = false;
            this.uiEmployeeListView.View = System.Windows.Forms.View.Details;
            // 
            // fullName
            // 
            this.fullName.Text = "Сотрудник";
            this.fullName.Width = 300;
            // 
            // birthDate
            // 
            this.birthDate.Text = "Дата рождения";
            this.birthDate.Width = 100;
            // 
            // uiDepartmentLabel
            // 
            this.uiDepartmentLabel.AutoSize = true;
            this.uiDepartmentLabel.Location = new System.Drawing.Point(16, 8);
            this.uiDepartmentLabel.Name = "uiDepartmentLabel";
            this.uiDepartmentLabel.Size = new System.Drawing.Size(87, 13);
            this.uiDepartmentLabel.TabIndex = 2;
            this.uiDepartmentLabel.Text = "Подразделения";
            // 
            // uiEmployeeLabel
            // 
            this.uiEmployeeLabel.AutoSize = true;
            this.uiEmployeeLabel.Location = new System.Drawing.Point(18, 8);
            this.uiEmployeeLabel.Name = "uiEmployeeLabel";
            this.uiEmployeeLabel.Size = new System.Drawing.Size(66, 13);
            this.uiEmployeeLabel.TabIndex = 3;
            this.uiEmployeeLabel.Text = "Сотрудники";
            // 
            // uiMmcSplitContainer
            // 
            this.uiMmcSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiMmcSplitContainer.Location = new System.Drawing.Point(1, 1);
            this.uiMmcSplitContainer.Name = "uiMmcSplitContainer";
            // 
            // uiMmcSplitContainer.Panel1
            // 
            this.uiMmcSplitContainer.Panel1.Controls.Add(this.uiDepartmentLabel);
            this.uiMmcSplitContainer.Panel1.Controls.Add(this.uiDepartmentTreeView);
            this.uiMmcSplitContainer.Panel1MinSize = 100;
            // 
            // uiMmcSplitContainer.Panel2
            // 
            this.uiMmcSplitContainer.Panel2.Controls.Add(this.uiEmployeeLabel);
            this.uiMmcSplitContainer.Panel2.Controls.Add(this.uiEmployeeListView);
            this.uiMmcSplitContainer.Panel2MinSize = 400;
            this.uiMmcSplitContainer.Size = new System.Drawing.Size(671, 273);
            this.uiMmcSplitContainer.SplitterDistance = 175;
            this.uiMmcSplitContainer.SplitterWidth = 6;
            this.uiMmcSplitContainer.TabIndex = 4;
            // 
            // uiMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 274);
            this.Controls.Add(this.uiMmcSplitContainer);
            this.Name = "uiMainForm";
            this.Text = "MMC";
            this.Load += new System.EventHandler(this.uiMainForm_Load);
            this.uiMmcSplitContainer.Panel1.ResumeLayout(false);
            this.uiMmcSplitContainer.Panel1.PerformLayout();
            this.uiMmcSplitContainer.Panel2.ResumeLayout(false);
            this.uiMmcSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiMmcSplitContainer)).EndInit();
            this.uiMmcSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView uiDepartmentTreeView;
        private System.Windows.Forms.ListView uiEmployeeListView;
        private System.Windows.Forms.Label uiDepartmentLabel;
        private System.Windows.Forms.Label uiEmployeeLabel;
        private System.Windows.Forms.ColumnHeader fullName;
        private System.Windows.Forms.ColumnHeader birthDate;
        private System.Windows.Forms.SplitContainer uiMmcSplitContainer;
    }
}

