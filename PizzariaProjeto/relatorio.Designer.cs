namespace PizzariaProjeto
{
    partial class relatorio
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pizzariaDataSet = new PizzariaProjeto.pizzariaDataSet();
            this.fechamentoCAIXABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fechamentoCAIXATableAdapter = new PizzariaProjeto.pizzariaDataSetTableAdapters.fechamentoCAIXATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pizzariaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechamentoCAIXABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.Black;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.fechamentoCAIXABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PizzariaProjeto.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(117, 47);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(482, 242);
            this.reportViewer1.TabIndex = 0;
            // 
            // pizzariaDataSet
            // 
            this.pizzariaDataSet.DataSetName = "pizzariaDataSet";
            this.pizzariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fechamentoCAIXABindingSource
            // 
            this.fechamentoCAIXABindingSource.DataMember = "fechamentoCAIXA";
            this.fechamentoCAIXABindingSource.DataSource = this.pizzariaDataSet;
            // 
            // fechamentoCAIXATableAdapter
            // 
            this.fechamentoCAIXATableAdapter.ClearBeforeFill = true;
            // 
            // relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PizzariaProjeto.Properties.Resources.l121preto;
            this.ClientSize = new System.Drawing.Size(647, 330);
            this.Controls.Add(this.reportViewer1);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "relatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Relatório";
            this.Load += new System.EventHandler(this.relatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pizzariaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechamentoCAIXABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource fechamentoCAIXABindingSource;
        private pizzariaDataSet pizzariaDataSet;
        private pizzariaDataSetTableAdapters.fechamentoCAIXATableAdapter fechamentoCAIXATableAdapter;
    }
}