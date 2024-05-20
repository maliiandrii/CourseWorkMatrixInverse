namespace WindowsFormsApp1
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMatrix = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSchultz = new System.Windows.Forms.Button();
            this.buttonLUP = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.labelSchultz = new System.Windows.Forms.Label();
            this.labelLUP = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelDet = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonFile = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelCompSch = new System.Windows.Forms.Label();
            this.labelCompLUP = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSize
            // 
            this.textBoxSize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSize.Location = new System.Drawing.Point(299, 6);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(100, 34);
            this.textBoxSize.TabIndex = 0;
            this.textBoxSize.TextChanged += new System.EventHandler(this.textBoxSize_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Розмірність матриці (NxN):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Елементи матриці:";
            // 
            // textBoxMatrix
            // 
            this.textBoxMatrix.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMatrix.Location = new System.Drawing.Point(299, 53);
            this.textBoxMatrix.Multiline = true;
            this.textBoxMatrix.Name = "textBoxMatrix";
            this.textBoxMatrix.Size = new System.Drawing.Size(388, 282);
            this.textBoxMatrix.TabIndex = 3;
            this.textBoxMatrix.TextChanged += new System.EventHandler(this.textBoxMatrix_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Методи обертання матриці:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(786, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Метод Шульца";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(786, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Метод LUP-розкладу";
            // 
            // buttonSchultz
            // 
            this.buttonSchultz.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSchultz.Location = new System.Drawing.Point(13, 439);
            this.buttonSchultz.Name = "buttonSchultz";
            this.buttonSchultz.Size = new System.Drawing.Size(268, 42);
            this.buttonSchultz.TabIndex = 7;
            this.buttonSchultz.Text = "Метод Шульца";
            this.buttonSchultz.UseVisualStyleBackColor = true;
            this.buttonSchultz.Click += new System.EventHandler(this.buttonSchultz_Click);
            // 
            // buttonLUP
            // 
            this.buttonLUP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLUP.Location = new System.Drawing.Point(13, 503);
            this.buttonLUP.Name = "buttonLUP";
            this.buttonLUP.Size = new System.Drawing.Size(268, 41);
            this.buttonLUP.TabIndex = 8;
            this.buttonLUP.Text = "Метод LUP-розкладу";
            this.buttonLUP.UseVisualStyleBackColor = true;
            this.buttonLUP.Click += new System.EventHandler(this.buttonLUP_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(527, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 28);
            this.label6.TabIndex = 9;
            this.label6.Text = "Обернена матриця";
            // 
            // labelSchultz
            // 
            this.labelSchultz.AutoSize = true;
            this.labelSchultz.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSchultz.Location = new System.Drawing.Point(1035, 52);
            this.labelSchultz.Name = "labelSchultz";
            this.labelSchultz.Size = new System.Drawing.Size(0, 28);
            this.labelSchultz.TabIndex = 10;
            // 
            // labelLUP
            // 
            this.labelLUP.AutoSize = true;
            this.labelLUP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLUP.Location = new System.Drawing.Point(1035, 349);
            this.labelLUP.Name = "labelLUP";
            this.labelLUP.Size = new System.Drawing.Size(0, 28);
            this.labelLUP.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(455, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 28);
            this.label9.TabIndex = 12;
            this.label9.Text = "Визначник:";
            this.label9.Visible = false;
            // 
            // labelDet
            // 
            this.labelDet.AutoSize = true;
            this.labelDet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDet.Location = new System.Drawing.Point(591, 6);
            this.labelDet.Name = "labelDet";
            this.labelDet.Size = new System.Drawing.Size(0, 28);
            this.labelDet.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(259, 28);
            this.label11.TabIndex = 14;
            this.label11.Text = "Згенерувати матрицю NxN";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerate.Location = new System.Drawing.Point(18, 174);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(262, 41);
            this.buttonGenerate.TabIndex = 15;
            this.buttonGenerate.Text = "Згенерувати";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1232, 216);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 31);
            this.label12.TabIndex = 16;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // buttonFile
            // 
            this.buttonFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFile.Location = new System.Drawing.Point(18, 283);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(262, 43);
            this.buttonFile.TabIndex = 17;
            this.buttonFile.Text = "Зберегти у файл";
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(316, 446);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(197, 28);
            this.label10.TabIndex = 18;
            this.label10.Text = "Кількість порівнянь:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(316, 509);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 28);
            this.label7.TabIndex = 19;
            this.label7.Text = "Кількість порівнянь:";
            // 
            // labelCompSch
            // 
            this.labelCompSch.AutoSize = true;
            this.labelCompSch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompSch.Location = new System.Drawing.Point(530, 446);
            this.labelCompSch.Name = "labelCompSch";
            this.labelCompSch.Size = new System.Drawing.Size(0, 28);
            this.labelCompSch.TabIndex = 20;
            // 
            // labelCompLUP
            // 
            this.labelCompLUP.AutoSize = true;
            this.labelCompLUP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompLUP.Location = new System.Drawing.Point(530, 509);
            this.labelCompLUP.Name = "labelCompLUP";
            this.labelCompLUP.Size = new System.Drawing.Size(0, 28);
            this.labelCompLUP.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(753, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1222, 627);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorProvider1.SetIconAlignment(this.groupBox2, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.groupBox2.Location = new System.Drawing.Point(299, 385);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(388, 167);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Практична складність алгоритмів";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 703);
            this.Controls.Add(this.labelCompLUP);
            this.Controls.Add(this.labelCompSch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonFile);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labelDet);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelLUP);
            this.Controls.Add(this.labelSchultz);
            this.Controls.Add(this.buttonLUP);
            this.Controls.Add(this.buttonSchultz);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMatrix);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSize);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Обернення матриць";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMatrix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSchultz;
        private System.Windows.Forms.Button buttonLUP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelSchultz;
        private System.Windows.Forms.Label labelLUP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelDet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label labelCompLUP;
        private System.Windows.Forms.Label labelCompSch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

