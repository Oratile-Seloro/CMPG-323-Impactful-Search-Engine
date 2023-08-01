namespace SU2_Act1
{
    partial class frmSQLDatabase
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnMoveData = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbxDatabase = new System.Windows.Forms.GroupBox();
            this.dgvClientList = new System.Windows.Forms.DataGridView();
            this.gbxListbox = new System.Windows.Forms.GroupBox();
            this.lstClientList = new System.Windows.Forms.ListBox();
            this.gbxDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientList)).BeginInit();
            this.gbxListbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(40, 318);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(102, 49);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(175, 318);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(111, 49);
            this.btnDisplay.TabIndex = 1;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnMoveData
            // 
            this.btnMoveData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveData.Location = new System.Drawing.Point(324, 318);
            this.btnMoveData.Name = "btnMoveData";
            this.btnMoveData.Size = new System.Drawing.Size(121, 49);
            this.btnMoveData.TabIndex = 2;
            this.btnMoveData.Text = "Move Data";
            this.btnMoveData.UseVisualStyleBackColor = true;
            this.btnMoveData.Click += new System.EventHandler(this.btnMoveData_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(773, 318);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(165, 49);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbxDatabase
            // 
            this.gbxDatabase.Controls.Add(this.dgvClientList);
            this.gbxDatabase.Location = new System.Drawing.Point(12, 44);
            this.gbxDatabase.Name = "gbxDatabase";
            this.gbxDatabase.Size = new System.Drawing.Size(493, 235);
            this.gbxDatabase.TabIndex = 4;
            this.gbxDatabase.TabStop = false;
            this.gbxDatabase.Text = "Database Data";
            // 
            // dgvClientList
            // 
            this.dgvClientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientList.Location = new System.Drawing.Point(17, 19);
            this.dgvClientList.Name = "dgvClientList";
            this.dgvClientList.Size = new System.Drawing.Size(458, 196);
            this.dgvClientList.TabIndex = 1;
            // 
            // gbxListbox
            // 
            this.gbxListbox.Controls.Add(this.lstClientList);
            this.gbxListbox.Location = new System.Drawing.Point(524, 44);
            this.gbxListbox.Name = "gbxListbox";
            this.gbxListbox.Size = new System.Drawing.Size(497, 235);
            this.gbxListbox.TabIndex = 0;
            this.gbxListbox.TabStop = false;
            this.gbxListbox.Text = "Listbox Data";
            // 
            // lstClientList
            // 
            this.lstClientList.FormattingEnabled = true;
            this.lstClientList.Location = new System.Drawing.Point(16, 16);
            this.lstClientList.Name = "lstClientList";
            this.lstClientList.Size = new System.Drawing.Size(465, 199);
            this.lstClientList.TabIndex = 0;
            // 
            // frmSQLDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 425);
            this.Controls.Add(this.gbxListbox);
            this.Controls.Add(this.gbxDatabase);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMoveData);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnConnect);
            this.Name = "frmSQLDatabase";
            this.Text = "SQL Database Server";
            this.gbxDatabase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientList)).EndInit();
            this.gbxListbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnMoveData;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbxDatabase;
        private System.Windows.Forms.GroupBox gbxListbox;
        private System.Windows.Forms.DataGridView dgvClientList;
        private System.Windows.Forms.ListBox lstClientList;
    }
}

