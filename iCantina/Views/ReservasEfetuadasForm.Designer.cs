namespace iCantina.Views
{
    partial class ReservasEfetuadasForm
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
            this.dataGridViewProfessores = new System.Windows.Forms.DataGridView();
            this.dataGridViewReservasMarcadas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfessores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservasMarcadas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProfessores
            // 
            this.dataGridViewProfessores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProfessores.Location = new System.Drawing.Point(419, 49);
            this.dataGridViewProfessores.Name = "dataGridViewProfessores";
            this.dataGridViewProfessores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewProfessores.Size = new System.Drawing.Size(359, 347);
            this.dataGridViewProfessores.TabIndex = 38;
            // 
            // dataGridViewReservasMarcadas
            // 
            this.dataGridViewReservasMarcadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservasMarcadas.Location = new System.Drawing.Point(12, 49);
            this.dataGridViewReservasMarcadas.Name = "dataGridViewReservasMarcadas";
            this.dataGridViewReservasMarcadas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewReservasMarcadas.Size = new System.Drawing.Size(341, 347);
            this.dataGridViewReservasMarcadas.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 18);
            this.label1.TabIndex = 40;
            this.label1.Text = "Reservas marcadas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(416, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 18);
            this.label2.TabIndex = 41;
            this.label2.Text = "Reservas  consumidas";
            // 
            // ReservasEfetuadasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewReservasMarcadas);
            this.Controls.Add(this.dataGridViewProfessores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReservasEfetuadasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReservasEfetuadasForm";
            this.Load += new System.EventHandler(this.ReservasEfetuadasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfessores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservasMarcadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProfessores;
        private System.Windows.Forms.DataGridView dataGridViewReservasMarcadas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}