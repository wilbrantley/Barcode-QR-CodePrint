namespace BarcodeQRCodePrint
{
    partial class BarcodeQRCodePrint
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
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmdPrint = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.barcode = new System.Windows.Forms.PictureBox();
            this.printDoc = new System.Drawing.Printing.PrintDocument();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnQR = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(12, 12);
            this.txtBarcode.Multiline = true;
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(215, 52);
            this.txtBarcode.TabIndex = 0;
            this.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnQR);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cmdPrint);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtHeight);
            this.groupBox1.Controls.Add(this.txtWidth);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 158);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fix Size Barcode";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Create Barcode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cmdPrint
            // 
            this.cmdPrint.Location = new System.Drawing.Point(49, 129);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(104, 23);
            this.cmdPrint.TabIndex = 7;
            this.cmdPrint.Text = "Print Code";
            this.cmdPrint.UseVisualStyleBackColor = true;
            this.cmdPrint.Click += new System.EventHandler(this.cmdPrint_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "X";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(110, 53);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(35, 20);
            this.txtHeight.TabIndex = 4;
            this.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(49, 53);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(32, 20);
            this.txtWidth.TabIndex = 4;
            this.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Height";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Width";
            // 
            // barcode
            // 
            this.barcode.Location = new System.Drawing.Point(249, 12);
            this.barcode.Name = "barcode";
            this.barcode.Size = new System.Drawing.Size(452, 216);
            this.barcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.barcode.TabIndex = 2;
            this.barcode.TabStop = false;
            // 
            // printDoc
            // 
            this.printDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDoc_PrintPage);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnQR
            // 
            this.btnQR.Location = new System.Drawing.Point(105, 103);
            this.btnQR.Name = "btnQR";
            this.btnQR.Size = new System.Drawing.Size(93, 23);
            this.btnQR.TabIndex = 9;
            this.btnQR.Text = "Creat QRCode";
            this.btnQR.UseVisualStyleBackColor = true;
            this.btnQR.Click += new System.EventHandler(this.btnQR_Click);
            // 
            // TaxSlayerPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 237);
            this.Controls.Add(this.barcode);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtBarcode);
            this.Name = "TaxSlayerPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create & Print Barcode";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Button cmdPrint;
        private System.Windows.Forms.Button btnBarcode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox barcode;
        private System.Drawing.Printing.PrintDocument printDoc;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnQR;
    }
}

