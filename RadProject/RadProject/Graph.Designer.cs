namespace RadProject
{
    partial class Graph
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
            this.components = new System.ComponentModel.Container();
            this.lblElement = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtPrint = new System.Windows.Forms.RichTextBox();
            this.lblRows = new System.Windows.Forms.Label();
            this.lblColums = new System.Windows.Forms.Label();
            this.txtRow = new System.Windows.Forms.TextBox();
            this.txtColums = new System.Windows.Forms.TextBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnAddValues = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMatrix = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblElement
            // 
            this.lblElement.AutoSize = true;
            this.lblElement.BackColor = System.Drawing.Color.LightGreen;
            this.lblElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblElement.Location = new System.Drawing.Point(34, 60);
            this.lblElement.Name = "lblElement";
            this.lblElement.Size = new System.Drawing.Size(0, 25);
            this.lblElement.TabIndex = 5;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(641, 386);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(110, 38);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Purple;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.Aqua;
            this.btnLoad.Location = new System.Drawing.Point(615, 254);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(157, 100);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Load garph";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtPrint
            // 
            this.txtPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrint.Location = new System.Drawing.Point(199, 161);
            this.txtPrint.Name = "txtPrint";
            this.txtPrint.Size = new System.Drawing.Size(345, 281);
            this.txtPrint.TabIndex = 8;
            this.txtPrint.Text = "";
            this.txtPrint.TextChanged += new System.EventHandler(this.txtPrint_TextChanged);
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRows.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblRows.Location = new System.Drawing.Point(12, 9);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(171, 24);
            this.lblRows.TabIndex = 9;
            this.lblRows.Text = "Number of Rows:";
            // 
            // lblColums
            // 
            this.lblColums.AutoSize = true;
            this.lblColums.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColums.ForeColor = System.Drawing.SystemColors.Control;
            this.lblColums.Location = new System.Drawing.Point(12, 51);
            this.lblColums.Name = "lblColums";
            this.lblColums.Size = new System.Drawing.Size(187, 24);
            this.lblColums.TabIndex = 10;
            this.lblColums.Text = "Number of colums:";
            // 
            // txtRow
            // 
            this.txtRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRow.Location = new System.Drawing.Point(199, 12);
            this.txtRow.Name = "txtRow";
            this.txtRow.Size = new System.Drawing.Size(149, 29);
            this.txtRow.TabIndex = 11;
            this.txtRow.TextChanged += new System.EventHandler(this.txtRow_TextChanged);
            this.txtRow.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRow_KeyDown);
            // 
            // txtColums
            // 
            this.txtColums.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColums.Location = new System.Drawing.Point(199, 48);
            this.txtColums.Name = "txtColums";
            this.txtColums.Size = new System.Drawing.Size(149, 29);
            this.txtColums.TabIndex = 12;
            this.txtColums.TextChanged += new System.EventHandler(this.txtColums_TextChanged);
            this.txtColums.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtColums_KeyDown);
            // 
            // txtValue
            // 
            this.txtValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue.Location = new System.Drawing.Point(199, 107);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(149, 29);
            this.txtValue.TabIndex = 13;
            this.txtValue.TextChanged += new System.EventHandler(this.txtValue_TextChanged);
            this.txtValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValue_KeyDown);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.Red;
            this.btnOk.Location = new System.Drawing.Point(369, 24);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 34);
            this.btnOk.TabIndex = 14;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnAddValues
            // 
            this.btnAddValues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddValues.ForeColor = System.Drawing.Color.Red;
            this.btnAddValues.Location = new System.Drawing.Point(371, 100);
            this.btnAddValues.Name = "btnAddValues";
            this.btnAddValues.Size = new System.Drawing.Size(73, 36);
            this.btnAddValues.TabIndex = 15;
            this.btnAddValues.Text = "Enter";
            this.btnAddValues.UseVisualStyleBackColor = false;
            this.btnAddValues.Click += new System.EventHandler(this.btnAddValues_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(18, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Enter Elements :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(18, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Your Matrix :";
            // 
            // btnMatrix
            // 
            this.btnMatrix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatrix.ForeColor = System.Drawing.Color.Red;
            this.btnMatrix.Location = new System.Drawing.Point(501, 100);
            this.btnMatrix.Name = "btnMatrix";
            this.btnMatrix.Size = new System.Drawing.Size(81, 36);
            this.btnMatrix.TabIndex = 18;
            this.btnMatrix.Text = "Matrix";
            this.btnMatrix.UseVisualStyleBackColor = false;
            this.btnMatrix.Click += new System.EventHandler(this.btnMatrix_Click);
            // 
            // Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::RadProject.Properties.Resources.images__7_;
            this.ClientSize = new System.Drawing.Size(784, 454);
            this.Controls.Add(this.btnMatrix);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddValues);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.txtColums);
            this.Controls.Add(this.txtRow);
            this.Controls.Add(this.lblColums);
            this.Controls.Add(this.lblRows);
            this.Controls.Add(this.txtPrint);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblElement);
            this.Name = "Graph";
            this.Text = "Graph";
            this.Load += new System.EventHandler(this.Graph_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblElement;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.RichTextBox txtPrint;
        private System.Windows.Forms.TextBox txtColums;
        private System.Windows.Forms.TextBox txtRow;
        private System.Windows.Forms.Label lblColums;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnAddValues;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMatrix;
    }
}