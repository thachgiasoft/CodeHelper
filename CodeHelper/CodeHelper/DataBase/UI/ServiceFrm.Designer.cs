﻿namespace CodeHelper.DataBaseHelper
{
    partial class ServiceFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnValidateSql = new System.Windows.Forms.Button();
            this.btntConvertCondtionDomainToDto = new System.Windows.Forms.Button();
            this.btnConvertCondtionDtoToDomain = new System.Windows.Forms.Button();
            this.btnGenSearchConditionDto = new System.Windows.Forms.Button();
            this.btnGenEFFunction = new System.Windows.Forms.Button();
            this.btnGenSqlFunction = new System.Windows.Forms.Button();
            this.btnGenSearchResultInfo = new System.Windows.Forms.Button();
            this.btnGenSearchConditionInfo = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.textEditorControl_Output = new ICSharpCode.TextEditor.TextEditorControl();
            this.textEditorControl = new ICSharpCode.TextEditor.TextEditorControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "名字";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(75, 13);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(466, 21);
            this.txtName.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(462, 41);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(543, 41);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnValidateSql);
            this.splitContainer1.Panel1.Controls.Add(this.btntConvertCondtionDomainToDto);
            this.splitContainer1.Panel1.Controls.Add(this.btnConvertCondtionDtoToDomain);
            this.splitContainer1.Panel1.Controls.Add(this.btnGenSearchConditionDto);
            this.splitContainer1.Panel1.Controls.Add(this.btnGenEFFunction);
            this.splitContainer1.Panel1.Controls.Add(this.btnGenSqlFunction);
            this.splitContainer1.Panel1.Controls.Add(this.btnGenSearchResultInfo);
            this.splitContainer1.Panel1.Controls.Add(this.btnGenSearchConditionInfo);
            this.splitContainer1.Panel1.Controls.Add(this.btnQuery);
            this.splitContainer1.Panel1.Controls.Add(this.txtName);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnSave);
            this.splitContainer1.Panel1.Controls.Add(this.btnCancel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(835, 596);
            this.splitContainer1.SplitterDistance = 108;
            this.splitContainer1.TabIndex = 11;
            // 
            // btnValidateSql
            // 
            this.btnValidateSql.Location = new System.Drawing.Point(487, 69);
            this.btnValidateSql.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnValidateSql.Name = "btnValidateSql";
            this.btnValidateSql.Size = new System.Drawing.Size(75, 23);
            this.btnValidateSql.TabIndex = 19;
            this.btnValidateSql.Text = "验证sql";
            this.btnValidateSql.UseVisualStyleBackColor = true;
            this.btnValidateSql.Click += new System.EventHandler(this.btnValidateSql_Click);
            // 
            // btntConvertCondtionDomainToDto
            // 
            this.btntConvertCondtionDomainToDto.Location = new System.Drawing.Point(316, 70);
            this.btntConvertCondtionDomainToDto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btntConvertCondtionDomainToDto.Name = "btntConvertCondtionDomainToDto";
            this.btntConvertCondtionDomainToDto.Size = new System.Drawing.Size(165, 23);
            this.btntConvertCondtionDomainToDto.TabIndex = 18;
            this.btntConvertCondtionDomainToDto.Text = "查询条件Domain转DTO";
            this.btntConvertCondtionDomainToDto.UseVisualStyleBackColor = true;
            this.btntConvertCondtionDomainToDto.Click += new System.EventHandler(this.btntConvertConditionDomainToDto_Click);
            // 
            // btnConvertCondtionDtoToDomain
            // 
            this.btnConvertCondtionDtoToDomain.Location = new System.Drawing.Point(145, 70);
            this.btnConvertCondtionDtoToDomain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConvertCondtionDtoToDomain.Name = "btnConvertCondtionDtoToDomain";
            this.btnConvertCondtionDtoToDomain.Size = new System.Drawing.Size(165, 23);
            this.btnConvertCondtionDtoToDomain.TabIndex = 17;
            this.btnConvertCondtionDtoToDomain.Text = "查询条件DTO转Domain";
            this.btnConvertCondtionDtoToDomain.UseVisualStyleBackColor = true;
            this.btnConvertCondtionDtoToDomain.Click += new System.EventHandler(this.btnConvertConditionDtoToDomain_Click);
            // 
            // btnGenSearchConditionDto
            // 
            this.btnGenSearchConditionDto.Location = new System.Drawing.Point(25, 70);
            this.btnGenSearchConditionDto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenSearchConditionDto.Name = "btnGenSearchConditionDto";
            this.btnGenSearchConditionDto.Size = new System.Drawing.Size(114, 23);
            this.btnGenSearchConditionDto.TabIndex = 16;
            this.btnGenSearchConditionDto.Text = "生成查询条件DTO";
            this.btnGenSearchConditionDto.UseVisualStyleBackColor = true;
            this.btnGenSearchConditionDto.Click += new System.EventHandler(this.btnGenSearchConditionDto_Click);
            // 
            // btnGenEFFunction
            // 
            this.btnGenEFFunction.Location = new System.Drawing.Point(339, 41);
            this.btnGenEFFunction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenEFFunction.Name = "btnGenEFFunction";
            this.btnGenEFFunction.Size = new System.Drawing.Size(100, 23);
            this.btnGenEFFunction.TabIndex = 15;
            this.btnGenEFFunction.Text = "生成EF查询方法";
            this.btnGenEFFunction.UseVisualStyleBackColor = true;
            this.btnGenEFFunction.Click += new System.EventHandler(this.btnGenEFFunction_Click);
            // 
            // btnGenSqlFunction
            // 
            this.btnGenSqlFunction.Location = new System.Drawing.Point(221, 41);
            this.btnGenSqlFunction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenSqlFunction.Name = "btnGenSqlFunction";
            this.btnGenSqlFunction.Size = new System.Drawing.Size(112, 23);
            this.btnGenSqlFunction.TabIndex = 14;
            this.btnGenSqlFunction.Text = "生成sql查询方法";
            this.btnGenSqlFunction.UseVisualStyleBackColor = true;
            // 
            // btnGenSearchResultInfo
            // 
            this.btnGenSearchResultInfo.Location = new System.Drawing.Point(118, 41);
            this.btnGenSearchResultInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenSearchResultInfo.Name = "btnGenSearchResultInfo";
            this.btnGenSearchResultInfo.Size = new System.Drawing.Size(97, 23);
            this.btnGenSearchResultInfo.TabIndex = 13;
            this.btnGenSearchResultInfo.Text = "生成查询结果类";
            this.btnGenSearchResultInfo.UseVisualStyleBackColor = true;
            // 
            // btnGenSearchConditionInfo
            // 
            this.btnGenSearchConditionInfo.Location = new System.Drawing.Point(24, 41);
            this.btnGenSearchConditionInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenSearchConditionInfo.Name = "btnGenSearchConditionInfo";
            this.btnGenSearchConditionInfo.Size = new System.Drawing.Size(88, 23);
            this.btnGenSearchConditionInfo.TabIndex = 12;
            this.btnGenSearchConditionInfo.Text = "生成查询条件";
            this.btnGenSearchConditionInfo.UseVisualStyleBackColor = true;
            this.btnGenSearchConditionInfo.Click += new System.EventHandler(this.btnGenSearchConditionInfo_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(543, 11);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 11;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.textEditorControl_Output);
            this.splitContainer2.Panel1.Controls.Add(this.textEditorControl);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer2.Size = new System.Drawing.Size(835, 484);
            this.splitContainer2.SplitterDistance = 334;
            this.splitContainer2.TabIndex = 0;
            // 
            // textEditorControl_Output
            // 
            this.textEditorControl_Output.Dock = System.Windows.Forms.DockStyle.Top;
            this.textEditorControl_Output.IsReadOnly = false;
            this.textEditorControl_Output.Location = new System.Drawing.Point(0, 166);
            this.textEditorControl_Output.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEditorControl_Output.Name = "textEditorControl_Output";
            this.textEditorControl_Output.Size = new System.Drawing.Size(835, 166);
            this.textEditorControl_Output.TabIndex = 1;
            // 
            // textEditorControl
            // 
            this.textEditorControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.textEditorControl.IsReadOnly = false;
            this.textEditorControl.Location = new System.Drawing.Point(0, 0);
            this.textEditorControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEditorControl.Name = "textEditorControl";
            this.textEditorControl.Size = new System.Drawing.Size(835, 166);
            this.textEditorControl.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(835, 146);
            this.dataGridView1.TabIndex = 0;
            // 
            // ServiceFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 596);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ServiceFrm";
            this.Text = "查询语句";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnQuery;
        //private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSql;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSql;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private ICSharpCode.TextEditor.TextEditorControl textEditorControl;
        private System.Windows.Forms.Button btnGenEFFunction;
        private System.Windows.Forms.Button btnGenSqlFunction;
        private System.Windows.Forms.Button btnGenSearchResultInfo;
        private System.Windows.Forms.Button btnGenSearchConditionInfo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ICSharpCode.TextEditor.TextEditorControl textEditorControl_Output;
        private System.Windows.Forms.Button btnGenSearchConditionDto;
        private System.Windows.Forms.Button btnConvertCondtionDtoToDomain;
        private System.Windows.Forms.Button btntConvertCondtionDomainToDto;
        private System.Windows.Forms.Button btnValidateSql;
    }
}