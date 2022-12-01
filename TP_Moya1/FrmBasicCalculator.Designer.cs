namespace TP_Moya1
{
    partial class FrmCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.cbop = new System.Windows.Forms.ComboBox();
            this.lbl = new System.Windows.Forms.Label();
            this.total_num = new System.Windows.Forms.Label();
            this.btnCompute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Basic Calculator";
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(26, 62);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(392, 20);
            this.num1.TabIndex = 1;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(26, 142);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(392, 20);
            this.num2.TabIndex = 2;
            // 
            // cbop
            // 
            this.cbop.FormattingEnabled = true;
            this.cbop.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cbop.Location = new System.Drawing.Point(159, 97);
            this.cbop.Name = "cbop";
            this.cbop.Size = new System.Drawing.Size(121, 21);
            this.cbop.TabIndex = 3;
            this.cbop.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(26, 189);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(31, 13);
            this.lbl.TabIndex = 4;
            this.lbl.Text = "Total";
            // 
            // total_num
            // 
            this.total_num.AutoSize = true;
            this.total_num.Location = new System.Drawing.Point(26, 225);
            this.total_num.Name = "total_num";
            this.total_num.Size = new System.Drawing.Size(31, 13);
            this.total_num.TabIndex = 5;
            this.total_num.Text = "0000";
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(191, 251);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(75, 23);
            this.btnCompute.TabIndex = 6;
            this.btnCompute.Text = "compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // FrmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 310);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.total_num);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.cbop);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.label1);
            this.Name = "FrmCalculator";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.ComboBox cbop;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label total_num;
        private System.Windows.Forms.Button btnCompute;
    }
}

