namespace WHAInsuranceAssessment
{
    partial class frmRiskAnalysis
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
            this.gridUnusualCustomers = new System.Windows.Forms.DataGridView();
            this.lblHeading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridUnusualCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // gridUnusualCustomers
            // 
            this.gridUnusualCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUnusualCustomers.Location = new System.Drawing.Point(12, 69);
            this.gridUnusualCustomers.Name = "gridUnusualCustomers";
            this.gridUnusualCustomers.RowTemplate.Height = 24;
            this.gridUnusualCustomers.Size = new System.Drawing.Size(372, 252);
            this.gridUnusualCustomers.TabIndex = 1;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(332, 13);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(336, 25);
            this.lblHeading.TabIndex = 2;
            this.lblHeading.Text = "William Hills Betting Risk Assessment";
            // 
            // frmRiskAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 586);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.gridUnusualCustomers);
            this.Name = "frmRiskAnalysis";
            this.Text = "William Hills Australia";
            this.Load += new System.EventHandler(this.frmRiskAssessment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridUnusualCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridUnusualCustomers;
        private System.Windows.Forms.Label lblHeading;
    }
}

