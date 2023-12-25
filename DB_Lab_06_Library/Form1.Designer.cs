namespace DB_Lab_06_Library
{
    partial class FormLibrary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLibrary));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.книгиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.читателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.должникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчет1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчет2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчет3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.report1 = new FastReport.Report();
            this.libraryDataSet1 = new DB_Lab_06_Library.libraryDataSet();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.report1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.книгиToolStripMenuItem,
            this.читателиToolStripMenuItem,
            this.должникиToolStripMenuItem,
            this.отчетыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(421, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // книгиToolStripMenuItem
            // 
            this.книгиToolStripMenuItem.Name = "книгиToolStripMenuItem";
            this.книгиToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.книгиToolStripMenuItem.Text = "Книги";
            this.книгиToolStripMenuItem.Click += new System.EventHandler(this.книгиToolStripMenuItem_Click);
            // 
            // читателиToolStripMenuItem
            // 
            this.читателиToolStripMenuItem.Name = "читателиToolStripMenuItem";
            this.читателиToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.читателиToolStripMenuItem.Text = "Читатели";
            this.читателиToolStripMenuItem.Click += new System.EventHandler(this.читателиToolStripMenuItem_Click);
            // 
            // должникиToolStripMenuItem
            // 
            this.должникиToolStripMenuItem.Name = "должникиToolStripMenuItem";
            this.должникиToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.должникиToolStripMenuItem.Text = "Должники";
            this.должникиToolStripMenuItem.Click += new System.EventHandler(this.должникиToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчет1ToolStripMenuItem,
            this.отчет2ToolStripMenuItem,
            this.отчет3ToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // отчет1ToolStripMenuItem
            // 
            this.отчет1ToolStripMenuItem.Name = "отчет1ToolStripMenuItem";
            this.отчет1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.отчет1ToolStripMenuItem.Text = "Отчет №1";
            this.отчет1ToolStripMenuItem.Click += new System.EventHandler(this.отчет1ToolStripMenuItem_Click);
            // 
            // отчет2ToolStripMenuItem
            // 
            this.отчет2ToolStripMenuItem.Name = "отчет2ToolStripMenuItem";
            this.отчет2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.отчет2ToolStripMenuItem.Text = "Отчет №2";
            this.отчет2ToolStripMenuItem.Click += new System.EventHandler(this.отчет2ToolStripMenuItem_Click);
            // 
            // отчет3ToolStripMenuItem
            // 
            this.отчет3ToolStripMenuItem.Name = "отчет3ToolStripMenuItem";
            this.отчет3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.отчет3ToolStripMenuItem.Text = "Отчет №3";
            this.отчет3ToolStripMenuItem.Click += new System.EventHandler(this.отчет3ToolStripMenuItem_Click);
            // 
            // report1
            // 
            this.report1.NeedRefresh = false;
            this.report1.ReportResourceString = resources.GetString("report1.ReportResourceString");
            this.report1.Tag = null;
            // 
            // libraryDataSet1
            // 
            this.libraryDataSet1.DataSetName = "libraryDataSet";
            this.libraryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 206);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormLibrary";
            this.Text = "Библиотека";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.report1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem книгиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem читателиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem должникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчет1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчет2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчет3ToolStripMenuItem;
        private FastReport.Report report1;
        private libraryDataSet libraryDataSet1;
    }
}

