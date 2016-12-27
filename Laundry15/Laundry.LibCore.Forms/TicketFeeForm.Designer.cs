namespace Laundry.LibCore.Forms
{
    partial class TicketFeeForm
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
            this.nudFromVip = new System.Windows.Forms.NumericUpDown();
            this.nudFromCash = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudFromVip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFromCash)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(22, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "会员扣费金额";
            // 
            // nudFromVip
            // 
            this.nudFromVip.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nudFromVip.Location = new System.Drawing.Point(148, 53);
            this.nudFromVip.Name = "nudFromVip";
            this.nudFromVip.Size = new System.Drawing.Size(120, 26);
            this.nudFromVip.TabIndex = 1;
            // 
            // nudFromCash
            // 
            this.nudFromCash.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nudFromCash.Location = new System.Drawing.Point(148, 123);
            this.nudFromCash.Name = "nudFromCash";
            this.nudFromCash.Size = new System.Drawing.Size(120, 26);
            this.nudFromCash.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(22, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "收取现金金额";
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOk.Location = new System.Drawing.Point(101, 201);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(93, 37);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "确认收费";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // TicketFeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.nudFromCash);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudFromVip);
            this.Controls.Add(this.label1);
            this.Name = "TicketFeeForm";
            this.Text = "衣单收费";
            ((System.ComponentModel.ISupportInitialize)(this.nudFromVip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFromCash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudFromVip;
        private System.Windows.Forms.NumericUpDown nudFromCash;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOk;
    }
}