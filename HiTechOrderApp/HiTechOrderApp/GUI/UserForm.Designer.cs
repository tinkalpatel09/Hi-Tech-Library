namespace HiTechOrderApp.GUI
{
    partial class UserForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBox1Input = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.listViewEmployeeTable = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonList = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCreatePsw = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.textBoxUserJobTitle = new System.Windows.Forms.TextBox();
            this.textBoxUserLastName = new System.Windows.Forms.TextBox();
            this.textBoxUserFirstName = new System.Windows.Forms.TextBox();
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 330);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "label6";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(460, 23);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 24);
            this.btnSearch.TabIndex = 40;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textBox1Input
            // 
            this.textBox1Input.Location = new System.Drawing.Point(315, 27);
            this.textBox1Input.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1Input.Name = "textBox1Input";
            this.textBox1Input.Size = new System.Drawing.Size(97, 20);
            this.textBox1Input.TabIndex = 46;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Select the Search option",
            "User ID",
            "First Name",
            "Last Name",
            "Job Title"});
            this.comboBox1.Location = new System.Drawing.Point(180, 27);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 45;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Search By";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(573, 195);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 19);
            this.btnExit.TabIndex = 42;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // listViewEmployeeTable
            // 
            this.listViewEmployeeTable.BackColor = System.Drawing.Color.Coral;
            this.listViewEmployeeTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewEmployeeTable.GridLines = true;
            this.listViewEmployeeTable.HideSelection = false;
            this.listViewEmployeeTable.Location = new System.Drawing.Point(89, 139);
            this.listViewEmployeeTable.Margin = new System.Windows.Forms.Padding(2);
            this.listViewEmployeeTable.Name = "listViewEmployeeTable";
            this.listViewEmployeeTable.Size = new System.Drawing.Size(408, 106);
            this.listViewEmployeeTable.TabIndex = 43;
            this.listViewEmployeeTable.UseCompatibleStateImageBehavior = false;
            this.listViewEmployeeTable.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Employee ID";
            this.columnHeader1.Width = 119;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "First Name";
            this.columnHeader2.Width = 122;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Last Name";
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Job Title";
            this.columnHeader4.Width = 187;
            // 
            // buttonList
            // 
            this.buttonList.Location = new System.Drawing.Point(201, 90);
            this.buttonList.Margin = new System.Windows.Forms.Padding(2);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(188, 32);
            this.buttonList.TabIndex = 41;
            this.buttonList.Text = "List Of Employee";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCreatePsw);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.textBoxUserJobTitle);
            this.groupBox1.Controls.Add(this.textBoxUserLastName);
            this.groupBox1.Controls.Add(this.textBoxUserFirstName);
            this.groupBox1.Controls.Add(this.textBoxUserID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(38, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(707, 194);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Table";
            // 
            // buttonCreatePsw
            // 
            this.buttonCreatePsw.Location = new System.Drawing.Point(294, 134);
            this.buttonCreatePsw.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCreatePsw.Name = "buttonCreatePsw";
            this.buttonCreatePsw.Size = new System.Drawing.Size(118, 33);
            this.buttonCreatePsw.TabIndex = 12;
            this.buttonCreatePsw.Text = "Create PassWord";
            this.buttonCreatePsw.UseVisualStyleBackColor = true;
            this.buttonCreatePsw.Click += new System.EventHandler(this.buttonCreatePsw_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(294, 100);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 26);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(294, 60);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 26);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(294, 28);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // textBoxUserJobTitle
            // 
            this.textBoxUserJobTitle.Location = new System.Drawing.Point(106, 147);
            this.textBoxUserJobTitle.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUserJobTitle.Name = "textBoxUserJobTitle";
            this.textBoxUserJobTitle.Size = new System.Drawing.Size(114, 20);
            this.textBoxUserJobTitle.TabIndex = 7;
            // 
            // textBoxUserLastName
            // 
            this.textBoxUserLastName.Location = new System.Drawing.Point(106, 106);
            this.textBoxUserLastName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUserLastName.Name = "textBoxUserLastName";
            this.textBoxUserLastName.Size = new System.Drawing.Size(110, 20);
            this.textBoxUserLastName.TabIndex = 6;
            // 
            // textBoxUserFirstName
            // 
            this.textBoxUserFirstName.Location = new System.Drawing.Point(106, 66);
            this.textBoxUserFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUserFirstName.Name = "textBoxUserFirstName";
            this.textBoxUserFirstName.Size = new System.Drawing.Size(111, 20);
            this.textBoxUserFirstName.TabIndex = 5;
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Location = new System.Drawing.Point(106, 31);
            this.textBoxUserID.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.Size = new System.Drawing.Size(111, 20);
            this.textBoxUserID.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Job Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Tag = "";
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.buttonList);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.listViewEmployeeTable);
            this.groupBox2.Controls.Add(this.textBox1Input);
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Location = new System.Drawing.Point(38, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(707, 263);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Info";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBox1Input;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListView listViewEmployeeTable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCreatePsw;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textBoxUserJobTitle;
        private System.Windows.Forms.TextBox textBoxUserLastName;
        private System.Windows.Forms.TextBox textBoxUserFirstName;
        private System.Windows.Forms.TextBox textBoxUserID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}