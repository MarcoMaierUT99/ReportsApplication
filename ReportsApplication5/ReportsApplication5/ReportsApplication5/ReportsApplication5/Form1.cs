using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportsApplication5
{
    public partial class Form1 : Form
    {

        private int _UUTID;
        private string _modus;
        public Form1(int UUTID, string modus)
        {
            _UUTID = UUTID;
            _modus = modus;
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReportParameter myParameter = new ReportParameter("ReportParameter1", _modus);

            this.reportViewer1.LocalReport.SetParameters(myParameter);
            this.uUT_RESULTTableAdapter.Fill(this.ReportDataSet.UUT_RESULT);
                           
            this.GetFlowValueByUUTIDTableAdapter.Fill(this.ReportDataSet.GetFlowValueByUUTID, _UUTID);
            this.getDeltaPFilterByUUTIDTableAdapter.Fill(this.ReportDataSet.GetDeltaPFilterByUUTID, _UUTID);
            this.getCleanGasDataByUUTIDTableAdapter.Fill(this.ReportDataSet.GetCleanGasDataByUUTID, _UUTID);            
            this.getHeaderInfoByUUTIDTableAdapter.Fill(this.ReportDataSet.GetHeaderInfoByUUTID, _UUTID);
            this.getRawGasDataByUUTIDTableAdapter.Fill(this.ReportDataSet.GetRawGasDataByUUTID, _UUTID);

            this.reportViewer1.RefreshReport();            
        }             
               
        private void reportViewer1_RenderingComplete(object sender, Microsoft.Reporting.WinForms.RenderingCompleteEventArgs e)
        {
            this.reportViewer1.PrintDialog();
           
            string testRunNo = this.ReportDataSet.GetHeaderInfoByUUTID.Where(id => id.NAME == "TestRunString").FirstOrDefault().DATA;
            //testRunNo.Substring(0, 8);           
            testRunNo = testRunNo.TrimEnd('x');
            testRunNo += _UUTID.ToString();
            SavePDF(this.reportViewer1, @"C:\TEMP\" + testRunNo.Replace("/","-") + ".pdf");            
           
        }

        public void SavePDF(ReportViewer viewer, string savePath)
        {

            byte[] Bytes = viewer.LocalReport.Render(format: "PDF", deviceInfo: "");



            using (FileStream stream = new FileStream(savePath, FileMode.Create))
            {

                stream.Write(Bytes, 0, Bytes.Length);
            }

        }

        //private void reportViewer1_Load(object sender, EventArgs e)
        //{

        //}

        //private void GetUUTIDbindingSource_CurrentChanged(object sender, EventArgs e)
        //{

        //}



       
    }
}