namespace CarProject.Forms
{
    partial class DetailViewCarForm
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
            this.lblTypeTransport = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableViewCollection = new System.Windows.Forms.TableLayoutPanel();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTypeTransport
            // 
            this.lblTypeTransport.AutoSize = true;
            this.lblTypeTransport.Location = new System.Drawing.Point(13, 13);
            this.lblTypeTransport.Name = "lblTypeTransport";
            this.lblTypeTransport.Size = new System.Drawing.Size(93, 13);
            this.lblTypeTransport.TabIndex = 0;
            this.lblTypeTransport.Text = "Type Of Transport";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 549);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Complete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CompleteClick);
            // 
            // tableViewCollection
            // 
            this.tableViewCollection.ColumnCount = 3;
            this.tableViewCollection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableViewCollection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableViewCollection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableViewCollection.Location = new System.Drawing.Point(16, 44);
            this.tableViewCollection.Name = "tableViewCollection";
            this.tableViewCollection.RowCount = 8;
            this.tableViewCollection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableViewCollection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableViewCollection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableViewCollection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableViewCollection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableViewCollection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableViewCollection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableViewCollection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableViewCollection.Size = new System.Drawing.Size(618, 499);
            this.tableViewCollection.TabIndex = 2;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(16, 549);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(90, 23);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(112, 549);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // DetailViewCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 584);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.tableViewCollection);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTypeTransport);
            this.Name = "DetailViewCarForm";
            this.Text = "DetailViewCarForm";
            this.Load += new System.EventHandler(this.DetailViewCarForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTypeTransport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableViewCollection;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button deleteBtn;
    }
}