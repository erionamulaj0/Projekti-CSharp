namespace Projekti_CSharp
{
    partial class Përdoruesit
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mbiemriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fjalekalimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.punesimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gjiniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qytetiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perdoruesiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrtelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datelindjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regjistrohuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projekiEMDataSet = new Projekti_CSharp.ProjekiEMDataSet();
            this.regjistrohuTableAdapter = new Projekti_CSharp.ProjekiEMDataSetTableAdapters.regjistrohuTableAdapter();
            this.btnktheuR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regjistrohuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekiEMDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.emriDataGridViewTextBoxColumn,
            this.mbiemriDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.fjalekalimiDataGridViewTextBoxColumn,
            this.punesimiDataGridViewTextBoxColumn,
            this.gjiniaDataGridViewTextBoxColumn,
            this.qytetiDataGridViewTextBoxColumn,
            this.perdoruesiDataGridViewTextBoxColumn,
            this.nrtelDataGridViewTextBoxColumn,
            this.datelindjaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.regjistrohuBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1006, 721);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // emriDataGridViewTextBoxColumn
            // 
            this.emriDataGridViewTextBoxColumn.DataPropertyName = "emri";
            this.emriDataGridViewTextBoxColumn.HeaderText = "emri";
            this.emriDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emriDataGridViewTextBoxColumn.Name = "emriDataGridViewTextBoxColumn";
            this.emriDataGridViewTextBoxColumn.Width = 125;
            // 
            // mbiemriDataGridViewTextBoxColumn
            // 
            this.mbiemriDataGridViewTextBoxColumn.DataPropertyName = "mbiemri";
            this.mbiemriDataGridViewTextBoxColumn.HeaderText = "mbiemri";
            this.mbiemriDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mbiemriDataGridViewTextBoxColumn.Name = "mbiemriDataGridViewTextBoxColumn";
            this.mbiemriDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // fjalekalimiDataGridViewTextBoxColumn
            // 
            this.fjalekalimiDataGridViewTextBoxColumn.DataPropertyName = "fjalekalimi";
            this.fjalekalimiDataGridViewTextBoxColumn.HeaderText = "fjalekalimi";
            this.fjalekalimiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fjalekalimiDataGridViewTextBoxColumn.Name = "fjalekalimiDataGridViewTextBoxColumn";
            this.fjalekalimiDataGridViewTextBoxColumn.Width = 125;
            // 
            // punesimiDataGridViewTextBoxColumn
            // 
            this.punesimiDataGridViewTextBoxColumn.DataPropertyName = "punesimi";
            this.punesimiDataGridViewTextBoxColumn.HeaderText = "punesimi";
            this.punesimiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.punesimiDataGridViewTextBoxColumn.Name = "punesimiDataGridViewTextBoxColumn";
            this.punesimiDataGridViewTextBoxColumn.Width = 125;
            // 
            // gjiniaDataGridViewTextBoxColumn
            // 
            this.gjiniaDataGridViewTextBoxColumn.DataPropertyName = "gjinia";
            this.gjiniaDataGridViewTextBoxColumn.HeaderText = "gjinia";
            this.gjiniaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gjiniaDataGridViewTextBoxColumn.Name = "gjiniaDataGridViewTextBoxColumn";
            this.gjiniaDataGridViewTextBoxColumn.Width = 125;
            // 
            // qytetiDataGridViewTextBoxColumn
            // 
            this.qytetiDataGridViewTextBoxColumn.DataPropertyName = "qyteti";
            this.qytetiDataGridViewTextBoxColumn.HeaderText = "qyteti";
            this.qytetiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.qytetiDataGridViewTextBoxColumn.Name = "qytetiDataGridViewTextBoxColumn";
            this.qytetiDataGridViewTextBoxColumn.Width = 125;
            // 
            // perdoruesiDataGridViewTextBoxColumn
            // 
            this.perdoruesiDataGridViewTextBoxColumn.DataPropertyName = "perdoruesi";
            this.perdoruesiDataGridViewTextBoxColumn.HeaderText = "perdoruesi";
            this.perdoruesiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perdoruesiDataGridViewTextBoxColumn.Name = "perdoruesiDataGridViewTextBoxColumn";
            this.perdoruesiDataGridViewTextBoxColumn.Width = 125;
            // 
            // nrtelDataGridViewTextBoxColumn
            // 
            this.nrtelDataGridViewTextBoxColumn.DataPropertyName = "nrtel";
            this.nrtelDataGridViewTextBoxColumn.HeaderText = "nrtel";
            this.nrtelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nrtelDataGridViewTextBoxColumn.Name = "nrtelDataGridViewTextBoxColumn";
            this.nrtelDataGridViewTextBoxColumn.Width = 125;
            // 
            // datelindjaDataGridViewTextBoxColumn
            // 
            this.datelindjaDataGridViewTextBoxColumn.DataPropertyName = "datelindja";
            this.datelindjaDataGridViewTextBoxColumn.HeaderText = "datelindja";
            this.datelindjaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datelindjaDataGridViewTextBoxColumn.Name = "datelindjaDataGridViewTextBoxColumn";
            this.datelindjaDataGridViewTextBoxColumn.Width = 125;
            // 
            // regjistrohuBindingSource
            // 
            this.regjistrohuBindingSource.DataMember = "regjistrohu";
            this.regjistrohuBindingSource.DataSource = this.projekiEMDataSet;
            // 
            // projekiEMDataSet
            // 
            this.projekiEMDataSet.DataSetName = "ProjekiEMDataSet";
            this.projekiEMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // regjistrohuTableAdapter
            // 
            this.regjistrohuTableAdapter.ClearBeforeFill = true;
            // 
            // btnktheuR
            // 
            this.btnktheuR.BackColor = System.Drawing.Color.CadetBlue;
            this.btnktheuR.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnktheuR.ForeColor = System.Drawing.Color.MintCream;
            this.btnktheuR.Location = new System.Drawing.Point(12, 640);
            this.btnktheuR.Name = "btnktheuR";
            this.btnktheuR.Size = new System.Drawing.Size(232, 42);
            this.btnktheuR.TabIndex = 31;
            this.btnktheuR.Text = "Ktheu në Regjistrim";
            this.btnktheuR.UseVisualStyleBackColor = false;
            this.btnktheuR.Click += new System.EventHandler(this.btnktheuR_Click);
            // 
            // Përdoruesit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.btnktheuR);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Përdoruesit";
            this.Text = "Përdoruesit";
            this.Load += new System.EventHandler(this.Përdoruesit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regjistrohuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekiEMDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ProjekiEMDataSet projekiEMDataSet;
        private System.Windows.Forms.BindingSource regjistrohuBindingSource;
        private ProjekiEMDataSetTableAdapters.regjistrohuTableAdapter regjistrohuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mbiemriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fjalekalimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn punesimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gjiniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qytetiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perdoruesiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrtelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datelindjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnktheuR;
    }
}