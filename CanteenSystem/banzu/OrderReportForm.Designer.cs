namespace CanteenSystem.banzu
{
    partial class OrderReportForm
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
            this.menuOrderRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderDataSet = new CanteenSystem.OrderDataSet();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.menuOrder_RTableAdapter = new CanteenSystem.OrderDataSetTableAdapters.MenuOrder_RTableAdapter();
            this.orderTableAdapter = new CanteenSystem.OrderDataSetTableAdapters.OrderTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.menuOrderRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuOrderRBindingSource
            // 
            this.menuOrderRBindingSource.DataMember = "MenuOrder_R";
            this.menuOrderRBindingSource.DataSource = this.orderDataSet;
            // 
            // orderDataSet
            // 
            this.orderDataSet.DataSetName = "OrderDataSet";
            this.orderDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.orderDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.menuOrderRBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.orderBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CanteenSystem.banzu.OrderReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(812, 1061);
            this.reportViewer1.TabIndex = 0;
            // 
            // menuOrder_RTableAdapter
            // 
            this.menuOrder_RTableAdapter.ClearBeforeFill = true;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // OrderReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 1061);
            this.Controls.Add(this.reportViewer1);
            this.Name = "OrderReportForm";
            this.Text = "OrderReportForm";
            this.Load += new System.EventHandler(this.OrderReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuOrderRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private OrderDataSet orderDataSet;
        private System.Windows.Forms.BindingSource menuOrderRBindingSource;
        private OrderDataSetTableAdapters.MenuOrder_RTableAdapter menuOrder_RTableAdapter;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private OrderDataSetTableAdapters.OrderTableAdapter orderTableAdapter;
    }
}