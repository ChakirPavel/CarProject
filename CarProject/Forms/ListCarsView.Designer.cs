namespace CarProject
{
    partial class ListCarsView
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddNewCar = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GridTransport = new System.Windows.Forms.DataGridView();
            this.HeaderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarkHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridTransport)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddNewCar
            // 
            this.btnAddNewCar.Location = new System.Drawing.Point(12, 42);
            this.btnAddNewCar.Name = "btnAddNewCar";
            this.btnAddNewCar.Size = new System.Drawing.Size(130, 24);
            this.btnAddNewCar.TabIndex = 1;
            this.btnAddNewCar.Text = "Add new car";
            this.btnAddNewCar.UseVisualStyleBackColor = true;
            this.btnAddNewCar.Click += new System.EventHandler(this.AddNewCarClick);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(148, 12);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(640, 20);
            this.searchBox.TabIndex = 2;
            this.searchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(37, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "CarProject";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(9, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 159);
            this.label2.TabIndex = 4;
            this.label2.Text = "Double click on element for open detail view.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GridTransport
            // 
            this.GridTransport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTransport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HeaderId,
            this.MarkHeader,
            this.ModelHeader,
            this.YearHeader,
            this.ColorHeader,
            this.TypeHeader,
            this.PriceHeader});
            this.GridTransport.Location = new System.Drawing.Point(149, 38);
            this.GridTransport.Name = "GridTransport";
            this.GridTransport.Size = new System.Drawing.Size(639, 397);
            this.GridTransport.TabIndex = 5;
            this.GridTransport.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridTransport_CellDoubleClick);
            // 
            // HeaderId
            // 
            this.HeaderId.HeaderText = "ID";
            this.HeaderId.Name = "HeaderId";
            this.HeaderId.Width = 30;
            // 
            // MarkHeader
            // 
            this.MarkHeader.HeaderText = "Mark";
            this.MarkHeader.Name = "MarkHeader";
            this.MarkHeader.Width = 130;
            // 
            // ModelHeader
            // 
            this.ModelHeader.HeaderText = "Model";
            this.ModelHeader.Name = "ModelHeader";
            // 
            // YearHeader
            // 
            this.YearHeader.HeaderText = "Year";
            this.YearHeader.Name = "YearHeader";
            this.YearHeader.Width = 40;
            // 
            // ColorHeader
            // 
            this.ColorHeader.HeaderText = "Color";
            this.ColorHeader.Name = "ColorHeader";
            // 
            // TypeHeader
            // 
            this.TypeHeader.HeaderText = "Type";
            this.TypeHeader.Name = "TypeHeader";
            // 
            // PriceHeader
            // 
            this.PriceHeader.HeaderText = "Price";
            this.PriceHeader.Name = "PriceHeader";
            // 
            // ListCarsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 447);
            this.Controls.Add(this.GridTransport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.btnAddNewCar);
            this.Name = "ListCarsView";
            this.Text = "CarProject";
            ((System.ComponentModel.ISupportInitialize)(this.GridTransport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddNewCar;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView GridTransport;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarkHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceHeader;
    }
}

