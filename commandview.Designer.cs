namespace Restaurant_rdbms
{
    partial class commandview
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
            this.dgvCommand = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommand)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCommand
            // 
            this.dgvCommand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommand.Location = new System.Drawing.Point(78, 174);
            this.dgvCommand.Name = "dgvCommand";
            this.dgvCommand.RowHeadersWidth = 62;
            this.dgvCommand.RowTemplate.Height = 28;
            this.dgvCommand.Size = new System.Drawing.Size(1073, 463);
            this.dgvCommand.TabIndex = 0;
            this.dgvCommand.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCommand_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(391, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Command Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1181, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "x";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // commandview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 695);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCommand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "commandview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "commandview";
            this.Load += new System.EventHandler(this.commandview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCommand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}