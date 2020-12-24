
namespace QuickFixDental.View
{
    partial class MedicalHistView
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
            this.txtAlergicTo = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastUpdated = new System.Windows.Forms.TextBox();
            this.lblLastUpdatedBy = new System.Windows.Forms.Label();
            this.txtLastUpdatedBy = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAlergicTo
            // 
            this.txtAlergicTo.Location = new System.Drawing.Point(35, 98);
            this.txtAlergicTo.Name = "txtAlergicTo";
            this.txtAlergicTo.Size = new System.Drawing.Size(730, 102);
            this.txtAlergicTo.TabIndex = 0;
            this.txtAlergicTo.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alergic To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "LastUpdated";
            // 
            // txtLastUpdated
            // 
            this.txtLastUpdated.Location = new System.Drawing.Point(153, 235);
            this.txtLastUpdated.Name = "txtLastUpdated";
            this.txtLastUpdated.Size = new System.Drawing.Size(135, 22);
            this.txtLastUpdated.TabIndex = 3;
            // 
            // lblLastUpdatedBy
            // 
            this.lblLastUpdatedBy.AutoSize = true;
            this.lblLastUpdatedBy.Location = new System.Drawing.Point(38, 296);
            this.lblLastUpdatedBy.Name = "lblLastUpdatedBy";
            this.lblLastUpdatedBy.Size = new System.Drawing.Size(109, 17);
            this.lblLastUpdatedBy.TabIndex = 4;
            this.lblLastUpdatedBy.Text = "LastUpdated By";
            // 
            // txtLastUpdatedBy
            // 
            this.txtLastUpdatedBy.Location = new System.Drawing.Point(153, 296);
            this.txtLastUpdatedBy.Name = "txtLastUpdatedBy";
            this.txtLastUpdatedBy.Size = new System.Drawing.Size(135, 22);
            this.txtLastUpdatedBy.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(387, 381);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(505, 381);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // MedicalHistView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtLastUpdatedBy);
            this.Controls.Add(this.lblLastUpdatedBy);
            this.Controls.Add(this.txtLastUpdated);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAlergicTo);
            this.Name = "MedicalHistView";
            this.Text = "MedicalHistory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtAlergicTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastUpdated;
        private System.Windows.Forms.Label lblLastUpdatedBy;
        private System.Windows.Forms.TextBox txtLastUpdatedBy;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnNext;
    }
}