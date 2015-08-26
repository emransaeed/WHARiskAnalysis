namespace WHARiskAnalysis
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
            this.label1 = new System.Windows.Forms.Label();
            this.gridRiskyBets = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridUnusualCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRiskyBets)).BeginInit();
            this.SuspendLayout();
            // 
            // gridUnusualCustomers
            // 
            this.gridUnusualCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUnusualCustomers.Location = new System.Drawing.Point(12, 69);
            this.gridUnusualCustomers.Name = "gridUnusualCustomers";
            this.gridUnusualCustomers.RowTemplate.Height = 24;
            this.gridUnusualCustomers.Size = new System.Drawing.Size(612, 169);
            this.gridUnusualCustomers.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(114, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Unusual Customers (winning more than 60% bets)";
            // 
            // gridRiskyBets
            // 
            this.gridRiskyBets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRiskyBets.Location = new System.Drawing.Point(12, 369);
            this.gridRiskyBets.Name = "gridRiskyBets";
            this.gridRiskyBets.RowTemplate.Height = 24;
            this.gridRiskyBets.Size = new System.Drawing.Size(612, 169);
            this.gridRiskyBets.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(103, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(452, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Risky Bets (bets that belongs to unusual customers)";
            // 
            // frmRiskAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1609, 586);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridRiskyBets);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridUnusualCustomers);
            this.Name = "frmRiskAnalysis";
            this.Text = "William Hills Australia - Betting Risk Analysis";
            this.Load += new System.EventHandler(this.frmRiskAssessment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridUnusualCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRiskyBets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridUnusualCustomers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridRiskyBets;
        private System.Windows.Forms.Label label2;
    }
}

