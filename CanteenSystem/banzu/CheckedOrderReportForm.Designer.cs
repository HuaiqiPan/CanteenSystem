namespace CanteenSystem.banzu
{
    partial class CheckedOrderReportForm
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.CheckedOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkedOrderDataSet = new CanteenSystem.banzu.CheckedOrderDataSet();
            this.MenuCheckedOrder_RBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.checkedOrderDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CheckedOrderTableAdapter = new CanteenSystem.banzu.CheckedOrderDataSetTableAdapters.CheckedOrderTableAdapter();
            this.MenuCheckedOrder_RTableAdapter = new CanteenSystem.banzu.CheckedOrderDataSetTableAdapters.MenuCheckedOrder_RTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CheckedOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedOrderDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuCheckedOrder_RBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedOrderDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckedOrderBindingSource
            // 
            this.CheckedOrderBindingSource.DataMember = "CheckedOrder";
            this.CheckedOrderBindingSource.DataSource = this.checkedOrderDataSet;
            // 
            // checkedOrderDataSet
            // 
            this.checkedOrderDataSet.DataSetName = "CheckedOrderDataSet";
            this.checkedOrderDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MenuCheckedOrder_RBindingSource
            // 
            this.MenuCheckedOrder_RBindingSource.DataMember = "MenuCheckedOrder_R";
            this.MenuCheckedOrder_RBindingSource.DataSource = this.checkedOrderDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.DocumentMapWidth = 1;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CheckedOrderBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.MenuCheckedOrder_RBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CanteenSystem.banzu.CheckedOrderReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(811, 1061);
            this.reportViewer1.TabIndex = 0;
            // 
            // checkedOrderDataSetBindingSource
            // 
            this.checkedOrderDataSetBindingSource.DataSource = this.checkedOrderDataSet;
            this.checkedOrderDataSetBindingSource.Position = 0;
            // 
            // CheckedOrderTableAdapter
            // 
            this.CheckedOrderTableAdapter.ClearBeforeFill = true;
            // 
            // MenuCheckedOrder_RTableAdapter
            // 
            this.MenuCheckedOrder_RTableAdapter.ClearBeforeFill = true;
            // 
            // CheckedOrderReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 1061);
            this.Controls.Add(this.reportViewer1);
            this.Name = "CheckedOrderReportForm";
            this.Text = "CheckedOrderReportForm";
            this.Load += new System.EventHandler(this.CheckedOrderReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CheckedOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedOrderDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuCheckedOrder_RBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedOrderDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource checkedOrderDataSetBindingSource;
        private CheckedOrderDataSet checkedOrderDataSet;
        private System.Windows.Forms.BindingSource CheckedOrderBindingSource;
        private CheckedOrderDataSetTableAdapters.CheckedOrderTableAdapter CheckedOrderTableAdapter;
        private System.Windows.Forms.BindingSource MenuCheckedOrder_RBindingSource;
        private CheckedOrderDataSetTableAdapters.MenuCheckedOrder_RTableAdapter MenuCheckedOrder_RTableAdapter;
    }
}