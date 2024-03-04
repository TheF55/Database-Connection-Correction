namespace Chapter_11_Database
{
    partial class DatabaseForm
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
            this.lnameTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.FixErrorsButton = new System.Windows.Forms.Button();
            this.idNoLabel = new System.Windows.Forms.Label();
            this.yearsLabel = new System.Windows.Forms.Label();
            this.lNameLabel = new System.Windows.Forms.Label();
            this.fNameLabel = new System.Windows.Forms.Label();
            this.IdNoTextBox = new System.Windows.Forms.TextBox();
            this.YearsTextBox = new System.Windows.Forms.TextBox();
            this.fNameTextBox = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.deletedDataGridView = new System.Windows.Forms.DataGridView();
            this.displayDataGridButton = new System.Windows.Forms.Button();
            this.restoreButton = new System.Windows.Forms.Button();
            this.MessageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.deletedDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lnameTextBox
            // 
            this.lnameTextBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.lnameTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.lnameTextBox.Location = new System.Drawing.Point(254, 206);
            this.lnameTextBox.Name = "lnameTextBox";
            this.lnameTextBox.Size = new System.Drawing.Size(124, 20);
            this.lnameTextBox.TabIndex = 37;
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.SystemColors.Desktop;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.titleLabel.Location = new System.Drawing.Point(212, 69);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(457, 63);
            this.titleLabel.TabIndex = 38;
            this.titleLabel.Text = "Database Connection Form";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NextButton.Location = new System.Drawing.Point(388, 259);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(86, 31);
            this.NextButton.TabIndex = 39;
            this.NextButton.Text = "&Next";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // FixErrorsButton
            // 
            this.FixErrorsButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.FixErrorsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FixErrorsButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FixErrorsButton.Location = new System.Drawing.Point(492, 259);
            this.FixErrorsButton.Name = "FixErrorsButton";
            this.FixErrorsButton.Size = new System.Drawing.Size(86, 31);
            this.FixErrorsButton.TabIndex = 40;
            this.FixErrorsButton.Text = "Fix Errors";
            this.FixErrorsButton.UseVisualStyleBackColor = false;
            this.FixErrorsButton.Click += new System.EventHandler(this.FixErrorsButton_Click);
            // 
            // idNoLabel
            // 
            this.idNoLabel.AutoSize = true;
            this.idNoLabel.Location = new System.Drawing.Point(215, 177);
            this.idNoLabel.Name = "idNoLabel";
            this.idNoLabel.Size = new System.Drawing.Size(33, 13);
            this.idNoLabel.TabIndex = 41;
            this.idNoLabel.Text = "IdNo:";
            // 
            // yearsLabel
            // 
            this.yearsLabel.AutoSize = true;
            this.yearsLabel.Location = new System.Drawing.Point(211, 244);
            this.yearsLabel.Name = "yearsLabel";
            this.yearsLabel.Size = new System.Drawing.Size(37, 13);
            this.yearsLabel.TabIndex = 42;
            this.yearsLabel.Text = "Years:";
            // 
            // lNameLabel
            // 
            this.lNameLabel.AutoSize = true;
            this.lNameLabel.Location = new System.Drawing.Point(187, 209);
            this.lNameLabel.Name = "lNameLabel";
            this.lNameLabel.Size = new System.Drawing.Size(61, 13);
            this.lNameLabel.TabIndex = 43;
            this.lNameLabel.Text = "Last Name:";
            // 
            // fNameLabel
            // 
            this.fNameLabel.AutoSize = true;
            this.fNameLabel.Location = new System.Drawing.Point(398, 209);
            this.fNameLabel.Name = "fNameLabel";
            this.fNameLabel.Size = new System.Drawing.Size(60, 13);
            this.fNameLabel.TabIndex = 44;
            this.fNameLabel.Text = "First Name:";
            this.fNameLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // IdNoTextBox
            // 
            this.IdNoTextBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.IdNoTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.IdNoTextBox.Location = new System.Drawing.Point(254, 174);
            this.IdNoTextBox.Name = "IdNoTextBox";
            this.IdNoTextBox.Size = new System.Drawing.Size(64, 20);
            this.IdNoTextBox.TabIndex = 45;
            // 
            // YearsTextBox
            // 
            this.YearsTextBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.YearsTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.YearsTextBox.Location = new System.Drawing.Point(254, 241);
            this.YearsTextBox.Name = "YearsTextBox";
            this.YearsTextBox.Size = new System.Drawing.Size(64, 20);
            this.YearsTextBox.TabIndex = 46;
            // 
            // fNameTextBox
            // 
            this.fNameTextBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.fNameTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.fNameTextBox.Location = new System.Drawing.Point(464, 206);
            this.fNameTextBox.Name = "fNameTextBox";
            this.fNameTextBox.Size = new System.Drawing.Size(124, 20);
            this.fNameTextBox.TabIndex = 47;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteButton.Location = new System.Drawing.Point(601, 259);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(86, 31);
            this.DeleteButton.TabIndex = 48;
            this.DeleteButton.Text = "&Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // deletedDataGridView
            // 
            this.deletedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deletedDataGridView.Location = new System.Drawing.Point(197, 364);
            this.deletedDataGridView.Name = "deletedDataGridView";
            this.deletedDataGridView.Size = new System.Drawing.Size(472, 150);
            this.deletedDataGridView.TabIndex = 49;
            this.deletedDataGridView.Visible = false;
            // 
            // displayDataGridButton
            // 
            this.displayDataGridButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.displayDataGridButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayDataGridButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.displayDataGridButton.Location = new System.Drawing.Point(149, 313);
            this.displayDataGridButton.Name = "displayDataGridButton";
            this.displayDataGridButton.Size = new System.Drawing.Size(99, 31);
            this.displayDataGridButton.TabIndex = 50;
            this.displayDataGridButton.Text = "Display Grid";
            this.displayDataGridButton.UseVisualStyleBackColor = false;
            this.displayDataGridButton.Click += new System.EventHandler(this.displayDataGridButton_Click);
            // 
            // restoreButton
            // 
            this.restoreButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.restoreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restoreButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.restoreButton.Location = new System.Drawing.Point(254, 313);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(99, 31);
            this.restoreButton.TabIndex = 51;
            this.restoreButton.Text = "Restore";
            this.restoreButton.UseVisualStyleBackColor = false;
            this.restoreButton.Visible = false;
            this.restoreButton.Click += new System.EventHandler(this.restoreButton_Click);
            // 
            // MessageLabel
            // 
            this.MessageLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MessageLabel.Location = new System.Drawing.Point(372, 434);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(118, 21);
            this.MessageLabel.TabIndex = 52;
            this.MessageLabel.Text = "No Records Found";
            this.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MessageLabel.Visible = false;
            // 
            // DatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 526);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.restoreButton);
            this.Controls.Add(this.displayDataGridButton);
            this.Controls.Add(this.deletedDataGridView);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.fNameTextBox);
            this.Controls.Add(this.YearsTextBox);
            this.Controls.Add(this.IdNoTextBox);
            this.Controls.Add(this.fNameLabel);
            this.Controls.Add(this.lNameLabel);
            this.Controls.Add(this.yearsLabel);
            this.Controls.Add(this.idNoLabel);
            this.Controls.Add(this.FixErrorsButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.lnameTextBox);
            this.Name = "DatabaseForm";
            this.Text = "Database Connection/ Correction";
            this.Load += new System.EventHandler(this.DatabaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deletedDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lnameTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button FixErrorsButton;
        private System.Windows.Forms.Label idNoLabel;
        private System.Windows.Forms.Label yearsLabel;
        private System.Windows.Forms.Label lNameLabel;
        private System.Windows.Forms.Label fNameLabel;
        private System.Windows.Forms.TextBox IdNoTextBox;
        private System.Windows.Forms.TextBox YearsTextBox;
        private System.Windows.Forms.TextBox fNameTextBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.DataGridView deletedDataGridView;
        private System.Windows.Forms.Button displayDataGridButton;
        private System.Windows.Forms.Button restoreButton;
        private System.Windows.Forms.Label MessageLabel;
    }
}

