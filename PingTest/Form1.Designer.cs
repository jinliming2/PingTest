namespace PingTest {
    partial class Form1 {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "FFFF:FFFF:FFFF:FFFF:FFFF:FFFF:FFFF:FFFF",
            "Net"}, -1);
            System.Windows.Forms.ColumnHeader columnHeader1;
            System.Windows.Forms.ColumnHeader columnHeader2;
            System.Windows.Forms.ColumnHeader columnHeader3;
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.lstIp = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.NumericUpDown();
            this.txtTimeout = new System.Windows.Forms.NumericUpDown();
            this.labTip = new System.Windows.Forms.Label();
            this.txtThread = new System.Windows.Forms.NumericUpDown();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThread)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(this.lstIp, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(12);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            tableLayoutPanel1.Size = new System.Drawing.Size(1008, 605);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lstIp
            // 
            this.lstIp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1,
            columnHeader2,
            columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstIp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstIp.FullRowSelect = true;
            this.lstIp.GridLines = true;
            this.lstIp.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem6});
            this.lstIp.Location = new System.Drawing.Point(15, 15);
            this.lstIp.Name = "lstIp";
            this.lstIp.ShowGroups = false;
            this.lstIp.ShowItemToolTips = true;
            this.lstIp.Size = new System.Drawing.Size(978, 540);
            this.lstIp.TabIndex = 1;
            this.lstIp.UseCompatibleStateImageBehavior = false;
            this.lstIp.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "IP";
            columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Comment";
            columnHeader2.Width = 430;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Ping";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "TTL";
            this.columnHeader4.Width = 40;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Information";
            this.columnHeader5.Width = 120;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(this.btnAdd);
            flowLayoutPanel1.Controls.Add(this.btnDelete);
            flowLayoutPanel1.Controls.Add(this.btnStart);
            flowLayoutPanel1.Controls.Add(this.txtThread);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(this.txtNum);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(this.txtTimeout);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(this.labTip);
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new System.Drawing.Point(15, 561);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(978, 29);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(900, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "重载";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(819, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(738, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(609, 3);
            this.txtNum.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.txtNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(36, 21);
            this.txtNum.TabIndex = 4;
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNum.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(562, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(41, 29);
            label1.TabIndex = 6;
            label1.Text = "次数：";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTimeout
            // 
            this.txtTimeout.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.txtTimeout.Location = new System.Drawing.Point(503, 3);
            this.txtTimeout.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.txtTimeout.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtTimeout.Name = "txtTimeout";
            this.txtTimeout.Size = new System.Drawing.Size(53, 21);
            this.txtTimeout.TabIndex = 8;
            this.txtTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTimeout.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(438, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(59, 29);
            label2.TabIndex = 7;
            label2.Text = "|||超时：";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labTip
            // 
            this.labTip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labTip.AutoSize = true;
            this.labTip.Location = new System.Drawing.Point(432, 0);
            this.labTip.Name = "labTip";
            this.labTip.Size = new System.Drawing.Size(0, 29);
            this.labTip.TabIndex = 5;
            this.labTip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(651, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(41, 29);
            label3.TabIndex = 9;
            label3.Text = "线程：";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtThread
            // 
            this.txtThread.Location = new System.Drawing.Point(698, 3);
            this.txtThread.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.txtThread.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtThread.Name = "txtThread";
            this.txtThread.Size = new System.Drawing.Size(34, 21);
            this.txtThread.TabIndex = 10;
            this.txtThread.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtThread.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 605);
            this.Controls.Add(tableLayoutPanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ping Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThread)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListView lstIp;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown txtNum;
        private System.Windows.Forms.Label labTip;
        private System.Windows.Forms.NumericUpDown txtTimeout;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.NumericUpDown txtThread;
    }
}

