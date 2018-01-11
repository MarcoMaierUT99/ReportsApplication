namespace ReportsApplication5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.GetFlowValueByUUTIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportDataSet = new ReportsApplication5.ReportDataSet();
            this.GetDeltaPFilterByUUTIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GetCleanGasDataByUUTIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GetHeaderInfoByUUTIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GetUUTIDbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GetRawGasDataByUUTIDbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GetDeltaPFilterByUUTIDBbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GetCleanGasByUUTIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GetFlowValueByUUTIDTableAdapter = new ReportsApplication5.ReportDataSetTableAdapters.GetFlowValueByUUTIDTableAdapter();
            this.getDeltaPFilterByUUTIDTableAdapter = new ReportsApplication5.ReportDataSetTableAdapters.GetDeltaPFilterByUUTIDTableAdapter();
            this.getCleanGasDataByUUTIDTableAdapter = new ReportsApplication5.ReportDataSetTableAdapters.GetCleanGasDataByUUTIDTableAdapter();
            this.getHeaderInfoByUUTIDTableAdapter = new ReportsApplication5.ReportDataSetTableAdapters.GetHeaderInfoByUUTIDTableAdapter();
            this.uUT_RESULTTableAdapter = new ReportsApplication5.ReportDataSetTableAdapters.UUT_RESULTTableAdapter();
            this.getRawGasDataByUUTIDTableAdapter = new ReportsApplication5.ReportDataSetTableAdapters.GetRawGasDataByUUTIDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GetFlowValueByUUTIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetDeltaPFilterByUUTIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetCleanGasDataByUUTIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetHeaderInfoByUUTIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetUUTIDbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetRawGasDataByUUTIDbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetDeltaPFilterByUUTIDBbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetCleanGasByUUTIDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GetFlowValueByUUTIDBindingSource
            // 
            this.GetFlowValueByUUTIDBindingSource.DataMember = "GetFlowValueByUUTID";
            this.GetFlowValueByUUTIDBindingSource.DataSource = this.ReportDataSet;
            // 
            // ReportDataSet
            // 
            this.ReportDataSet.DataSetName = "ReportDataSet";
            this.ReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GetDeltaPFilterByUUTIDBindingSource
            // 
            this.GetDeltaPFilterByUUTIDBindingSource.DataMember = "GetDeltaPFilterByUUTID";
            this.GetDeltaPFilterByUUTIDBindingSource.DataSource = this.ReportDataSet;
            // 
            // GetCleanGasDataByUUTIDBindingSource
            // 
            this.GetCleanGasDataByUUTIDBindingSource.DataMember = "GetCleanGasDataByUUTID";
            this.GetCleanGasDataByUUTIDBindingSource.DataSource = this.ReportDataSet;
            // 
            // GetHeaderInfoByUUTIDBindingSource
            // 
            this.GetHeaderInfoByUUTIDBindingSource.DataMember = "GetHeaderInfoByUUTID";
            this.GetHeaderInfoByUUTIDBindingSource.DataSource = this.ReportDataSet;
            // 
            // GetUUTIDbindingSource
            // 
            this.GetUUTIDbindingSource.DataMember = "UUT_RESULT";
            this.GetUUTIDbindingSource.DataSource = this.ReportDataSet;
            // 
            // GetRawGasDataByUUTIDbindingSource
            // 
            this.GetRawGasDataByUUTIDbindingSource.DataMember = "GetRawGasDataByUUTID";
            this.GetRawGasDataByUUTIDbindingSource.DataSource = this.ReportDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Flow";
            reportDataSource1.Value = this.GetFlowValueByUUTIDBindingSource;
            reportDataSource2.Name = "DeltaPFilter";
            reportDataSource2.Value = this.GetDeltaPFilterByUUTIDBindingSource;
            reportDataSource3.Name = "CleanGas";
            reportDataSource3.Value = this.GetCleanGasDataByUUTIDBindingSource;
            reportDataSource4.Name = "HeaderInfo";
            reportDataSource4.Value = this.GetHeaderInfoByUUTIDBindingSource;
            reportDataSource5.Name = "UUTID";
            reportDataSource5.Value = this.GetUUTIDbindingSource;
            reportDataSource6.Name = "RawGas";
            reportDataSource6.Value = this.GetRawGasDataByUUTIDbindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication5.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(909, 475);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.RenderingComplete += new Microsoft.Reporting.WinForms.RenderingCompleteEventHandler(this.reportViewer1_RenderingComplete);
            // 
            // GetDeltaPFilterByUUTIDBbindingSource
            // 
            this.GetDeltaPFilterByUUTIDBbindingSource.DataMember = "GetDeltaPFilterByUUTID";
            this.GetDeltaPFilterByUUTIDBbindingSource.DataSource = this.ReportDataSet;
            // 
            // GetCleanGasByUUTIDBindingSource
            // 
            this.GetCleanGasByUUTIDBindingSource.DataMember = "GetCleanGasDataByUUTID";
            this.GetCleanGasByUUTIDBindingSource.DataSource = this.ReportDataSet;
            // 
            // GetFlowValueByUUTIDTableAdapter
            // 
            this.GetFlowValueByUUTIDTableAdapter.ClearBeforeFill = true;
            // 
            // getDeltaPFilterByUUTIDTableAdapter
            // 
            this.getDeltaPFilterByUUTIDTableAdapter.ClearBeforeFill = true;
            // 
            // getCleanGasDataByUUTIDTableAdapter
            // 
            this.getCleanGasDataByUUTIDTableAdapter.ClearBeforeFill = true;
            // 
            // getHeaderInfoByUUTIDTableAdapter
            // 
            this.getHeaderInfoByUUTIDTableAdapter.ClearBeforeFill = true;
            // 
            // uUT_RESULTTableAdapter
            // 
            this.uUT_RESULTTableAdapter.ClearBeforeFill = true;
            // 
            // getRawGasDataByUUTIDTableAdapter
            // 
            this.getRawGasDataByUUTIDTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 475);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GetFlowValueByUUTIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetDeltaPFilterByUUTIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetCleanGasDataByUUTIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetHeaderInfoByUUTIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetUUTIDbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetRawGasDataByUUTIDbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetDeltaPFilterByUUTIDBbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetCleanGasByUUTIDBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GetFlowValueByUUTIDBindingSource;
        private ReportDataSet ReportDataSet;
        private ReportDataSetTableAdapters.GetFlowValueByUUTIDTableAdapter GetFlowValueByUUTIDTableAdapter;
        private System.Windows.Forms.BindingSource GetDeltaPFilterByUUTIDBbindingSource;
        private ReportDataSetTableAdapters.GetDeltaPFilterByUUTIDTableAdapter getDeltaPFilterByUUTIDTableAdapter;
        private System.Windows.Forms.BindingSource GetCleanGasByUUTIDBindingSource;
        private ReportDataSetTableAdapters.GetCleanGasDataByUUTIDTableAdapter getCleanGasDataByUUTIDTableAdapter;
        private System.Windows.Forms.BindingSource GetHeaderInfoByUUTIDBindingSource;
        private ReportDataSetTableAdapters.GetHeaderInfoByUUTIDTableAdapter getHeaderInfoByUUTIDTableAdapter;
        private System.Windows.Forms.BindingSource GetDeltaPFilterByUUTIDBindingSource;
        private System.Windows.Forms.BindingSource GetCleanGasDataByUUTIDBindingSource;
        private System.Windows.Forms.BindingSource GetUUTIDbindingSource;
        private ReportDataSetTableAdapters.UUT_RESULTTableAdapter uUT_RESULTTableAdapter;
        private System.Windows.Forms.BindingSource GetRawGasDataByUUTIDbindingSource;
        private ReportDataSetTableAdapters.GetRawGasDataByUUTIDTableAdapter getRawGasDataByUUTIDTableAdapter;
        
    }
}

