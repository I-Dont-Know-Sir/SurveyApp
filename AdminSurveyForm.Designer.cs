
namespace SurvayApp
{
    partial class AdminSurveyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSurveyForm));
            this.btnExit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.survaeyInformationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surveyInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new SurvayApp.DatabaseDataSet();
            this.btnPrint = new System.Windows.Forms.Button();
            this.surveyInfoTableAdapter = new SurvayApp.DatabaseDataSetTableAdapters.SurveyInfoTableAdapter();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.cmbSurveyType = new System.Windows.Forms.ComboBox();
            this.txtAnswer4 = new System.Windows.Forms.TextBox();
            this.txtAnswer3 = new System.Windows.Forms.TextBox();
            this.txtAnswer2 = new System.Windows.Forms.TextBox();
            this.txtAnswer1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.errorProviderforQuestion = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderforAns1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderforAns2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderforAns3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderforAns4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderforCombobox = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surveyInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderforQuestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderforAns1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderforAns2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderforAns3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderforAns4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderforCombobox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(13, 411);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 31);
            this.btnExit.TabIndex = 37;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.survaeyInformationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.surveyInfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 375);
            this.dataGridView1.TabIndex = 38;
            // 
            // survaeyInformationDataGridViewTextBoxColumn
            // 
            this.survaeyInformationDataGridViewTextBoxColumn.DataPropertyName = "Survaey_Information";
            this.survaeyInformationDataGridViewTextBoxColumn.HeaderText = "Survey Information";
            this.survaeyInformationDataGridViewTextBoxColumn.Name = "survaeyInformationDataGridViewTextBoxColumn";
            this.survaeyInformationDataGridViewTextBoxColumn.ReadOnly = true;
            this.survaeyInformationDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.survaeyInformationDataGridViewTextBoxColumn.Width = 600;
            // 
            // surveyInfoBindingSource
            // 
            this.surveyInfoBindingSource.DataMember = "SurveyInfo";
            this.surveyInfoBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(643, 31);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(91, 26);
            this.btnPrint.TabIndex = 39;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // surveyInfoTableAdapter
            // 
            this.surveyInfoTableAdapter.ClearBeforeFill = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(470, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 378);
            this.panel1.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Question";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(129, 33);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(311, 26);
            this.txtQuestion.TabIndex = 42;
            this.txtQuestion.Validating += new System.ComponentModel.CancelEventHandler(this.txtQuestion_Validating);
            // 
            // cmbSurveyType
            // 
            this.cmbSurveyType.FormattingEnabled = true;
            this.cmbSurveyType.Items.AddRange(new object[] {
            "Radio button",
            "Combo box",
            "Check box"});
            this.cmbSurveyType.Location = new System.Drawing.Point(129, 179);
            this.cmbSurveyType.Name = "cmbSurveyType";
            this.cmbSurveyType.Size = new System.Drawing.Size(311, 28);
            this.cmbSurveyType.TabIndex = 49;
            this.cmbSurveyType.Validating += new System.ComponentModel.CancelEventHandler(this.cmbSurveyType_Validating);
            // 
            // txtAnswer4
            // 
            this.txtAnswer4.Location = new System.Drawing.Point(298, 128);
            this.txtAnswer4.Name = "txtAnswer4";
            this.txtAnswer4.Size = new System.Drawing.Size(142, 26);
            this.txtAnswer4.TabIndex = 47;
            this.txtAnswer4.Validating += new System.ComponentModel.CancelEventHandler(this.txtAnswer4_Validating);
            // 
            // txtAnswer3
            // 
            this.txtAnswer3.Location = new System.Drawing.Point(129, 128);
            this.txtAnswer3.Name = "txtAnswer3";
            this.txtAnswer3.Size = new System.Drawing.Size(147, 26);
            this.txtAnswer3.TabIndex = 46;
            this.txtAnswer3.Validating += new System.ComponentModel.CancelEventHandler(this.txtAnswer3_Validating);
            // 
            // txtAnswer2
            // 
            this.txtAnswer2.Location = new System.Drawing.Point(298, 87);
            this.txtAnswer2.Name = "txtAnswer2";
            this.txtAnswer2.Size = new System.Drawing.Size(142, 26);
            this.txtAnswer2.TabIndex = 45;
            this.txtAnswer2.Validating += new System.ComponentModel.CancelEventHandler(this.txtAnswer2_Validating);
            // 
            // txtAnswer1
            // 
            this.txtAnswer1.Location = new System.Drawing.Point(129, 87);
            this.txtAnswer1.Name = "txtAnswer1";
            this.txtAnswer1.Size = new System.Drawing.Size(148, 26);
            this.txtAnswer1.TabIndex = 44;
            this.txtAnswer1.Validating += new System.ComponentModel.CancelEventHandler(this.txtAnswer1_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Answer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(12, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "Survey type";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Green;
            this.btnSubmit.Location = new System.Drawing.Point(344, 225);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(96, 30);
            this.btnSubmit.TabIndex = 50;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // errorProviderforQuestion
            // 
            this.errorProviderforQuestion.ContainerControl = this;
            // 
            // errorProviderforAns1
            // 
            this.errorProviderforAns1.ContainerControl = this;
            // 
            // errorProviderforAns2
            // 
            this.errorProviderforAns2.ContainerControl = this;
            // 
            // errorProviderforAns3
            // 
            this.errorProviderforAns3.ContainerControl = this;
            // 
            // errorProviderforAns4
            // 
            this.errorProviderforAns4.ContainerControl = this;
            // 
            // errorProviderforCombobox
            // 
            this.errorProviderforCombobox.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(474, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 51;
            this.label4.Text = "Survey Analysis";
            // 
            // AdminSurveyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 452);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAnswer1);
            this.Controls.Add(this.txtAnswer2);
            this.Controls.Add(this.txtAnswer3);
            this.Controls.Add(this.txtAnswer4);
            this.Controls.Add(this.cmbSurveyType);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnExit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AdminSurveyForm";
            this.Text = "Survey Form";
            this.Load += new System.EventHandler(this.AdminSurveyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surveyInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderforQuestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderforAns1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderforAns2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderforAns3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderforAns4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderforCombobox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource surveyInfoBindingSource;
        private DatabaseDataSetTableAdapters.SurveyInfoTableAdapter surveyInfoTableAdapter;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.ComboBox cmbSurveyType;
        private System.Windows.Forms.TextBox txtAnswer4;
        private System.Windows.Forms.TextBox txtAnswer3;
        private System.Windows.Forms.TextBox txtAnswer2;
        private System.Windows.Forms.TextBox txtAnswer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ErrorProvider errorProviderforQuestion;
        private System.Windows.Forms.ErrorProvider errorProviderforAns1;
        private System.Windows.Forms.ErrorProvider errorProviderforAns2;
        private System.Windows.Forms.ErrorProvider errorProviderforAns3;
        private System.Windows.Forms.ErrorProvider errorProviderforAns4;
        private System.Windows.Forms.ErrorProvider errorProviderforCombobox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn survaeyInformationDataGridViewTextBoxColumn;
    }
}