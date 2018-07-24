namespace Renamer
{
    partial class MainForm
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
            this.btnGo = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTxtToFind = new System.Windows.Forms.Label();
            this.txtTxtToFind = new System.Windows.Forms.TextBox();
            this.txtSearchString = new System.Windows.Forms.TextBox();
            this.lblSearchString = new System.Windows.Forms.Label();
            this.lblFolder = new System.Windows.Forms.Label();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.lblTxtToReplace = new System.Windows.Forms.Label();
            this.txtTxtToReplace = new System.Windows.Forms.TextBox();
            this.rbReplace = new System.Windows.Forms.RadioButton();
            this.rbPrepend = new System.Windows.Forms.RadioButton();
            this.rbPostpend = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(402, 169);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "Go!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.82609F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.17391F));
            this.tableLayoutPanel1.Controls.Add(this.lblTxtToFind, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtTxtToFind, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtSearchString, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblSearchString, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFolder, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtFolder, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTxtToReplace, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtTxtToReplace, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 11);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(460, 110);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblTxtToFind
            // 
            this.lblTxtToFind.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTxtToFind.AutoSize = true;
            this.lblTxtToFind.Location = new System.Drawing.Point(3, 52);
            this.lblTxtToFind.Name = "lblTxtToFind";
            this.lblTxtToFind.Size = new System.Drawing.Size(145, 26);
            this.lblTxtToFind.TabIndex = 1;
            this.lblTxtToFind.Text = "Text to Find";
            this.lblTxtToFind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTxtToFind
            // 
            this.txtTxtToFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTxtToFind.Location = new System.Drawing.Point(154, 55);
            this.txtTxtToFind.Name = "txtTxtToFind";
            this.txtTxtToFind.Size = new System.Drawing.Size(303, 20);
            this.txtTxtToFind.TabIndex = 3;
            // 
            // txtSearchString
            // 
            this.txtSearchString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchString.Location = new System.Drawing.Point(154, 29);
            this.txtSearchString.Name = "txtSearchString";
            this.txtSearchString.Size = new System.Drawing.Size(303, 20);
            this.txtSearchString.TabIndex = 2;
            this.txtSearchString.Text = "*.*";
            // 
            // lblSearchString
            // 
            this.lblSearchString.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchString.AutoSize = true;
            this.lblSearchString.Location = new System.Drawing.Point(3, 26);
            this.lblSearchString.Name = "lblSearchString";
            this.lblSearchString.Size = new System.Drawing.Size(145, 26);
            this.lblSearchString.TabIndex = 0;
            this.lblSearchString.Text = "Files to Rename";
            this.lblSearchString.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFolder
            // 
            this.lblFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(3, 0);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(145, 26);
            this.lblFolder.TabIndex = 4;
            this.lblFolder.Text = "Folder";
            this.lblFolder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFolder
            // 
            this.txtFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFolder.Location = new System.Drawing.Point(154, 3);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(303, 20);
            this.txtFolder.TabIndex = 5;
            // 
            // lblTxtToReplace
            // 
            this.lblTxtToReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTxtToReplace.AutoSize = true;
            this.lblTxtToReplace.Location = new System.Drawing.Point(3, 78);
            this.lblTxtToReplace.Name = "lblTxtToReplace";
            this.lblTxtToReplace.Size = new System.Drawing.Size(145, 32);
            this.lblTxtToReplace.TabIndex = 6;
            this.lblTxtToReplace.Text = "TextToReplace";
            this.lblTxtToReplace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTxtToReplace
            // 
            this.txtTxtToReplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTxtToReplace.Location = new System.Drawing.Point(154, 81);
            this.txtTxtToReplace.Name = "txtTxtToReplace";
            this.txtTxtToReplace.Size = new System.Drawing.Size(303, 20);
            this.txtTxtToReplace.TabIndex = 7;
            // 
            // rbReplace
            // 
            this.rbReplace.AutoSize = true;
            this.rbReplace.Checked = true;
            this.rbReplace.Location = new System.Drawing.Point(20, 128);
            this.rbReplace.Name = "rbReplace";
            this.rbReplace.Size = new System.Drawing.Size(65, 17);
            this.rbReplace.TabIndex = 2;
            this.rbReplace.TabStop = true;
            this.rbReplace.Text = "Replace";
            this.rbReplace.UseVisualStyleBackColor = true;
            this.rbReplace.CheckedChanged += new System.EventHandler(this.rbReplace_CheckedChanged);
            // 
            // rbPrepend
            // 
            this.rbPrepend.AutoSize = true;
            this.rbPrepend.Location = new System.Drawing.Point(20, 152);
            this.rbPrepend.Name = "rbPrepend";
            this.rbPrepend.Size = new System.Drawing.Size(65, 17);
            this.rbPrepend.TabIndex = 3;
            this.rbPrepend.Text = "Prepend";
            this.rbPrepend.UseVisualStyleBackColor = true;
            this.rbPrepend.CheckedChanged += new System.EventHandler(this.rbPrepend_CheckedChanged);
            // 
            // rbPostpend
            // 
            this.rbPostpend.AutoSize = true;
            this.rbPostpend.Location = new System.Drawing.Point(20, 175);
            this.rbPostpend.Name = "rbPostpend";
            this.rbPostpend.Size = new System.Drawing.Size(70, 17);
            this.rbPostpend.TabIndex = 4;
            this.rbPostpend.TabStop = true;
            this.rbPostpend.Text = "Postpend";
            this.rbPostpend.UseVisualStyleBackColor = true;
            this.rbPostpend.CheckedChanged += new System.EventHandler(this.rbPostpend_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 203);
            this.Controls.Add(this.rbPostpend);
            this.Controls.Add(this.rbPrepend);
            this.Controls.Add(this.rbReplace);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnGo);
            this.MaximumSize = new System.Drawing.Size(508, 242);
            this.MinimumSize = new System.Drawing.Size(508, 242);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renamer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblSearchString;
        private System.Windows.Forms.Label lblTxtToFind;
        private System.Windows.Forms.TextBox txtSearchString;
        private System.Windows.Forms.TextBox txtTxtToFind;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Label lblTxtToReplace;
        private System.Windows.Forms.TextBox txtTxtToReplace;
        private System.Windows.Forms.RadioButton rbReplace;
        private System.Windows.Forms.RadioButton rbPrepend;
        private System.Windows.Forms.RadioButton rbPostpend;
    }
}

