namespace zhFelkeszito2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            kisállatHozzáadásToolStripMenuItem = new ToolStripMenuItem();
            listázásToolStripMenuItem = new ToolStripMenuItem();
            exportálásToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { kisállatHozzáadásToolStripMenuItem, listázásToolStripMenuItem, exportálásToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // kisállatHozzáadásToolStripMenuItem
            // 
            kisállatHozzáadásToolStripMenuItem.Name = "kisállatHozzáadásToolStripMenuItem";
            kisállatHozzáadásToolStripMenuItem.Size = new Size(145, 24);
            kisállatHozzáadásToolStripMenuItem.Text = "Kisállat hozzáadás";
            kisállatHozzáadásToolStripMenuItem.Click += kisállatHozzáadásToolStripMenuItem_Click;
            // 
            // listázásToolStripMenuItem
            // 
            listázásToolStripMenuItem.Name = "listázásToolStripMenuItem";
            listázásToolStripMenuItem.Size = new Size(74, 24);
            listázásToolStripMenuItem.Text = "Listázás";
            // 
            // exportálásToolStripMenuItem
            // 
            exportálásToolStripMenuItem.Name = "exportálásToolStripMenuItem";
            exportálásToolStripMenuItem.Size = new Size(92, 24);
            exportálásToolStripMenuItem.Text = "Exportálás";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem kisállatHozzáadásToolStripMenuItem;
        private ToolStripMenuItem listázásToolStripMenuItem;
        private ToolStripMenuItem exportálásToolStripMenuItem;
    }
}
