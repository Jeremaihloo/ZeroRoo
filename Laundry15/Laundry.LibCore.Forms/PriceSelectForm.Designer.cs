namespace Laundry.LibCore.Forms
{
    partial class PriceSelectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PriceSelectForm));
            this.button1 = new System.Windows.Forms.Button();
            this.lvPrice = new System.Windows.Forms.ListView();
            this.fpCategory = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.fpCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "分类";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lvPrice
            // 
            this.lvPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPrice.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvPrice.FullRowSelect = true;
            this.lvPrice.Location = new System.Drawing.Point(0, 0);
            this.lvPrice.MultiSelect = false;
            this.lvPrice.Name = "lvPrice";
            this.lvPrice.Size = new System.Drawing.Size(659, 478);
            this.lvPrice.TabIndex = 1;
            this.lvPrice.UseCompatibleStateImageBehavior = false;
            this.lvPrice.View = System.Windows.Forms.View.Details;
            this.lvPrice.DoubleClick += new System.EventHandler(this.lvPrice_DoubleClick);
            // 
            // fpCategory
            // 
            this.fpCategory.Controls.Add(this.button1);
            this.fpCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpCategory.Location = new System.Drawing.Point(0, 0);
            this.fpCategory.Name = "fpCategory";
            this.fpCategory.Size = new System.Drawing.Size(659, 59);
            this.fpCategory.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.fpCategory);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvPrice);
            this.splitContainer1.Size = new System.Drawing.Size(659, 541);
            this.splitContainer1.SplitterDistance = 59;
            this.splitContainer1.TabIndex = 3;
            // 
            // PriceSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 541);
            this.Controls.Add(this.splitContainer1);
            this.Name = "PriceSelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "衣服和价格";
            this.Load += new System.EventHandler(this.PriceSelectForm_Load);
            this.fpCategory.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lvPrice;
        private System.Windows.Forms.FlowLayoutPanel fpCategory;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}