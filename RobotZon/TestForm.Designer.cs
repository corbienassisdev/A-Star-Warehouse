namespace RobotZon
{
    partial class TestForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelDebug = new System.Windows.Forms.Panel();
            this.listBoxDebug = new System.Windows.Forms.ListBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelDebug.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDebug
            // 
            this.panelDebug.Controls.Add(this.listBoxDebug);
            this.panelDebug.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDebug.Location = new System.Drawing.Point(734, 0);
            this.panelDebug.Name = "panelDebug";
            this.panelDebug.Size = new System.Drawing.Size(450, 562);
            this.panelDebug.TabIndex = 0;
            // 
            // listBoxDebug
            // 
            this.listBoxDebug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxDebug.FormattingEnabled = true;
            this.listBoxDebug.Location = new System.Drawing.Point(0, 0);
            this.listBoxDebug.Name = "listBoxDebug";
            this.listBoxDebug.Size = new System.Drawing.Size(450, 562);
            this.listBoxDebug.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(734, 562);
            this.panelMain.TabIndex = 1;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.onDraw);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 562);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelDebug);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.panelDebug.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDebug;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ListBox listBoxDebug;
    }
}

