namespace WindowsForms_Integr_Diff
{
    partial class FormMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelInter1 = new System.Windows.Forms.Label();
            this.textBoxA1 = new System.Windows.Forms.TextBox();
            this.textBoxB1 = new System.Windows.Forms.TextBox();
            this.labelB1 = new System.Windows.Forms.Label();
            this.labelB2 = new System.Windows.Forms.Label();
            this.labelSig1 = new System.Windows.Forms.Label();
            this.labelInter2 = new System.Windows.Forms.Label();
            this.labelB3 = new System.Windows.Forms.Label();
            this.textBoxA2 = new System.Windows.Forms.TextBox();
            this.labelSig2 = new System.Windows.Forms.Label();
            this.textBoxB2 = new System.Windows.Forms.TextBox();
            this.labelB4 = new System.Windows.Forms.Label();
            this.labelXis = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.labelEps = new System.Windows.Forms.Label();
            this.textBoxE = new System.Windows.Forms.TextBox();
            this.buttonSimpson = new System.Windows.Forms.Button();
            this.buttonGauss = new System.Windows.Forms.Button();
            this.buttonSplines = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSplines);
            this.groupBox1.Controls.Add(this.textBoxX);
            this.groupBox1.Controls.Add(this.labelXis);
            this.groupBox1.Controls.Add(this.labelSig1);
            this.groupBox1.Controls.Add(this.labelB2);
            this.groupBox1.Controls.Add(this.labelB1);
            this.groupBox1.Controls.Add(this.textBoxB1);
            this.groupBox1.Controls.Add(this.textBoxA1);
            this.groupBox1.Controls.Add(this.labelInter1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Differentiation";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(21, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 50);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonGauss);
            this.groupBox2.Controls.Add(this.buttonSimpson);
            this.groupBox2.Controls.Add(this.textBoxE);
            this.groupBox2.Controls.Add(this.labelEps);
            this.groupBox2.Controls.Add(this.labelB4);
            this.groupBox2.Controls.Add(this.textBoxB2);
            this.groupBox2.Controls.Add(this.labelSig2);
            this.groupBox2.Controls.Add(this.textBoxA2);
            this.groupBox2.Controls.Add(this.labelB3);
            this.groupBox2.Controls.Add(this.labelInter2);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(250, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 250);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Integration";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(21, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 32);
            this.panel2.TabIndex = 0;
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAnswer.Location = new System.Drawing.Point(12, 278);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(79, 24);
            this.labelAnswer.TabIndex = 3;
            this.labelAnswer.Text = "Answer:";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(186, 306);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 24);
            this.labelResult.TabIndex = 4;
            // 
            // labelInter1
            // 
            this.labelInter1.AutoSize = true;
            this.labelInter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInter1.Location = new System.Drawing.Point(14, 99);
            this.labelInter1.Name = "labelInter1";
            this.labelInter1.Size = new System.Drawing.Size(65, 20);
            this.labelInter1.TabIndex = 1;
            this.labelInter1.Text = "Interval:";
            // 
            // textBoxA1
            // 
            this.textBoxA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxA1.Location = new System.Drawing.Point(89, 96);
            this.textBoxA1.Name = "textBoxA1";
            this.textBoxA1.Size = new System.Drawing.Size(33, 22);
            this.textBoxA1.TabIndex = 2;
            this.textBoxA1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxA1_KeyPress);
            // 
            // textBoxB1
            // 
            this.textBoxB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxB1.Location = new System.Drawing.Point(138, 96);
            this.textBoxB1.Name = "textBoxB1";
            this.textBoxB1.Size = new System.Drawing.Size(33, 22);
            this.textBoxB1.TabIndex = 3;
            this.textBoxB1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxA1_KeyPress);
            // 
            // labelB1
            // 
            this.labelB1.AutoSize = true;
            this.labelB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelB1.Location = new System.Drawing.Point(74, 93);
            this.labelB1.Name = "labelB1";
            this.labelB1.Size = new System.Drawing.Size(15, 24);
            this.labelB1.TabIndex = 4;
            this.labelB1.Text = "[";
            // 
            // labelB2
            // 
            this.labelB2.AutoSize = true;
            this.labelB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelB2.Location = new System.Drawing.Point(172, 93);
            this.labelB2.Name = "labelB2";
            this.labelB2.Size = new System.Drawing.Size(15, 24);
            this.labelB2.TabIndex = 5;
            this.labelB2.Text = "]";
            // 
            // labelSig1
            // 
            this.labelSig1.AutoSize = true;
            this.labelSig1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSig1.Location = new System.Drawing.Point(123, 95);
            this.labelSig1.Name = "labelSig1";
            this.labelSig1.Size = new System.Drawing.Size(15, 24);
            this.labelSig1.TabIndex = 6;
            this.labelSig1.Text = ",";
            // 
            // labelInter2
            // 
            this.labelInter2.AutoSize = true;
            this.labelInter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInter2.Location = new System.Drawing.Point(17, 98);
            this.labelInter2.Name = "labelInter2";
            this.labelInter2.Size = new System.Drawing.Size(65, 20);
            this.labelInter2.TabIndex = 2;
            this.labelInter2.Text = "Interval:";
            // 
            // labelB3
            // 
            this.labelB3.AutoSize = true;
            this.labelB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelB3.Location = new System.Drawing.Point(78, 93);
            this.labelB3.Name = "labelB3";
            this.labelB3.Size = new System.Drawing.Size(15, 24);
            this.labelB3.TabIndex = 5;
            this.labelB3.Text = "[";
            // 
            // textBoxA2
            // 
            this.textBoxA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxA2.Location = new System.Drawing.Point(93, 96);
            this.textBoxA2.Name = "textBoxA2";
            this.textBoxA2.Size = new System.Drawing.Size(33, 22);
            this.textBoxA2.TabIndex = 6;
            this.textBoxA2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxA1_KeyPress);
            // 
            // labelSig2
            // 
            this.labelSig2.AutoSize = true;
            this.labelSig2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSig2.Location = new System.Drawing.Point(127, 95);
            this.labelSig2.Name = "labelSig2";
            this.labelSig2.Size = new System.Drawing.Size(15, 24);
            this.labelSig2.TabIndex = 7;
            this.labelSig2.Text = ",";
            // 
            // textBoxB2
            // 
            this.textBoxB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxB2.Location = new System.Drawing.Point(143, 96);
            this.textBoxB2.Name = "textBoxB2";
            this.textBoxB2.Size = new System.Drawing.Size(33, 22);
            this.textBoxB2.TabIndex = 8;
            this.textBoxB2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxA1_KeyPress);
            // 
            // labelB4
            // 
            this.labelB4.AutoSize = true;
            this.labelB4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelB4.Location = new System.Drawing.Point(178, 93);
            this.labelB4.Name = "labelB4";
            this.labelB4.Size = new System.Drawing.Size(15, 24);
            this.labelB4.TabIndex = 9;
            this.labelB4.Text = "]";
            // 
            // labelXis
            // 
            this.labelXis.AutoSize = true;
            this.labelXis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelXis.Location = new System.Drawing.Point(46, 150);
            this.labelXis.Name = "labelXis";
            this.labelXis.Size = new System.Drawing.Size(29, 20);
            this.labelXis.TabIndex = 7;
            this.labelXis.Text = "x =";
            // 
            // textBoxX
            // 
            this.textBoxX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxX.Location = new System.Drawing.Point(89, 148);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(82, 22);
            this.textBoxX.TabIndex = 8;
            this.textBoxX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxA1_KeyPress);
            // 
            // labelEps
            // 
            this.labelEps.AutoSize = true;
            this.labelEps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEps.Location = new System.Drawing.Point(49, 148);
            this.labelEps.Name = "labelEps";
            this.labelEps.Size = new System.Drawing.Size(30, 20);
            this.labelEps.TabIndex = 10;
            this.labelEps.Text = "ε =";
            // 
            // textBoxE
            // 
            this.textBoxE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxE.Location = new System.Drawing.Point(93, 146);
            this.textBoxE.Name = "textBoxE";
            this.textBoxE.Size = new System.Drawing.Size(83, 22);
            this.textBoxE.TabIndex = 11;
            this.textBoxE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxA1_KeyPress);
            // 
            // buttonSimpson
            // 
            this.buttonSimpson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSimpson.Location = new System.Drawing.Point(10, 198);
            this.buttonSimpson.Name = "buttonSimpson";
            this.buttonSimpson.Size = new System.Drawing.Size(105, 40);
            this.buttonSimpson.TabIndex = 12;
            this.buttonSimpson.Text = "Simpson";
            this.buttonSimpson.UseVisualStyleBackColor = true;
            this.buttonSimpson.Click += new System.EventHandler(this.buttonSimpson_Click);
            // 
            // buttonGauss
            // 
            this.buttonGauss.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGauss.Location = new System.Drawing.Point(129, 198);
            this.buttonGauss.Name = "buttonGauss";
            this.buttonGauss.Size = new System.Drawing.Size(105, 40);
            this.buttonGauss.TabIndex = 13;
            this.buttonGauss.Text = "Gauss";
            this.buttonGauss.UseVisualStyleBackColor = true;
            this.buttonGauss.Click += new System.EventHandler(this.buttonGauss_Click);
            // 
            // buttonSplines
            // 
            this.buttonSplines.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSplines.Location = new System.Drawing.Point(10, 198);
            this.buttonSplines.Name = "buttonSplines";
            this.buttonSplines.Size = new System.Drawing.Size(211, 40);
            this.buttonSplines.TabIndex = 13;
            this.buttonSplines.Text = "Splines";
            this.buttonSplines.UseVisualStyleBackColor = true;
            this.buttonSplines.Click += new System.EventHandler(this.buttonSplines_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 376);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelAnswer);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMain";
            this.Text = "Integration and differentiation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelAnswer;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label labelXis;
        private System.Windows.Forms.Label labelSig1;
        private System.Windows.Forms.Label labelB2;
        private System.Windows.Forms.Label labelB1;
        private System.Windows.Forms.TextBox textBoxB1;
        private System.Windows.Forms.TextBox textBoxA1;
        private System.Windows.Forms.Label labelInter1;
        private System.Windows.Forms.TextBox textBoxE;
        private System.Windows.Forms.Label labelEps;
        private System.Windows.Forms.Label labelB4;
        private System.Windows.Forms.TextBox textBoxB2;
        private System.Windows.Forms.Label labelSig2;
        private System.Windows.Forms.TextBox textBoxA2;
        private System.Windows.Forms.Label labelB3;
        private System.Windows.Forms.Label labelInter2;
        private System.Windows.Forms.Button buttonSplines;
        private System.Windows.Forms.Button buttonGauss;
        private System.Windows.Forms.Button buttonSimpson;
    }
}

