namespace RobotZon
{
    partial class FormAskingUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAskingUser));
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelNumberofcarts = new System.Windows.Forms.Label();
            this.numericUpDownNumberofcarts = new System.Windows.Forms.NumericUpDown();
            this.labelAbscissa = new System.Windows.Forms.Label();
            this.groupBoxCartposition = new System.Windows.Forms.GroupBox();
            this.listBoxSelectcart = new System.Windows.Forms.ListBox();
            this.labelOrdinate = new System.Windows.Forms.Label();
            this.buttonSetPosition = new System.Windows.Forms.Button();
            this.numericUpDownAbscissa = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownOrdinate = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberofcarts)).BeginInit();
            this.groupBoxCartposition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAbscissa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOrdinate)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Enabled = false;
            this.buttonOK.Location = new System.Drawing.Point(215, 201);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "Valider";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelNumberofcarts
            // 
            this.labelNumberofcarts.AutoSize = true;
            this.labelNumberofcarts.Location = new System.Drawing.Point(123, 25);
            this.labelNumberofcarts.Name = "labelNumberofcarts";
            this.labelNumberofcarts.Size = new System.Drawing.Size(99, 13);
            this.labelNumberofcarts.TabIndex = 1;
            this.labelNumberofcarts.Text = "Nombre de chariots";
            // 
            // numericUpDownNumberofcarts
            // 
            this.numericUpDownNumberofcarts.Location = new System.Drawing.Point(234, 23);
            this.numericUpDownNumberofcarts.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericUpDownNumberofcarts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumberofcarts.Name = "numericUpDownNumberofcarts";
            this.numericUpDownNumberofcarts.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownNumberofcarts.TabIndex = 2;
            this.numericUpDownNumberofcarts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumberofcarts.ValueChanged += new System.EventHandler(this.numericUpDownNumberofcarts_ValueChanged);
            // 
            // labelAbscissa
            // 
            this.labelAbscissa.AutoSize = true;
            this.labelAbscissa.Location = new System.Drawing.Point(6, 44);
            this.labelAbscissa.Name = "labelAbscissa";
            this.labelAbscissa.Size = new System.Drawing.Size(49, 13);
            this.labelAbscissa.TabIndex = 3;
            this.labelAbscissa.Text = "Abscisse";
            // 
            // groupBoxCartposition
            // 
            this.groupBoxCartposition.Controls.Add(this.numericUpDownOrdinate);
            this.groupBoxCartposition.Controls.Add(this.buttonSetPosition);
            this.groupBoxCartposition.Controls.Add(this.numericUpDownAbscissa);
            this.groupBoxCartposition.Controls.Add(this.labelOrdinate);
            this.groupBoxCartposition.Controls.Add(this.labelAbscissa);
            this.groupBoxCartposition.Location = new System.Drawing.Point(28, 66);
            this.groupBoxCartposition.Name = "groupBoxCartposition";
            this.groupBoxCartposition.Size = new System.Drawing.Size(214, 116);
            this.groupBoxCartposition.TabIndex = 4;
            this.groupBoxCartposition.TabStop = false;
            // 
            // listBoxSelectcart
            // 
            this.listBoxSelectcart.FormattingEnabled = true;
            this.listBoxSelectcart.Location = new System.Drawing.Point(264, 74);
            this.listBoxSelectcart.Name = "listBoxSelectcart";
            this.listBoxSelectcart.Size = new System.Drawing.Size(194, 108);
            this.listBoxSelectcart.TabIndex = 5;
            this.listBoxSelectcart.SelectedIndexChanged += new System.EventHandler(this.listBoxSelectcart_SelectedIndexChanged);
            // 
            // labelOrdinate
            // 
            this.labelOrdinate.AutoSize = true;
            this.labelOrdinate.Location = new System.Drawing.Point(104, 44);
            this.labelOrdinate.Name = "labelOrdinate";
            this.labelOrdinate.Size = new System.Drawing.Size(54, 13);
            this.labelOrdinate.TabIndex = 7;
            this.labelOrdinate.Text = "Ordonnée";
            // 
            // buttonSetPosition
            // 
            this.buttonSetPosition.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSetPosition.Location = new System.Drawing.Point(52, 77);
            this.buttonSetPosition.Name = "buttonSetPosition";
            this.buttonSetPosition.Size = new System.Drawing.Size(110, 23);
            this.buttonSetPosition.TabIndex = 6;
            this.buttonSetPosition.Text = "Attribuer la position";
            this.buttonSetPosition.UseVisualStyleBackColor = true;
            this.buttonSetPosition.Click += new System.EventHandler(this.buttonSetPosition_Click);
            // 
            // numericUpDownAbscissa
            // 
            this.numericUpDownAbscissa.Location = new System.Drawing.Point(61, 42);
            this.numericUpDownAbscissa.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownAbscissa.Name = "numericUpDownAbscissa";
            this.numericUpDownAbscissa.Size = new System.Drawing.Size(37, 20);
            this.numericUpDownAbscissa.TabIndex = 6;
            // 
            // numericUpDownOrdinate
            // 
            this.numericUpDownOrdinate.Location = new System.Drawing.Point(163, 42);
            this.numericUpDownOrdinate.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownOrdinate.Name = "numericUpDownOrdinate";
            this.numericUpDownOrdinate.Size = new System.Drawing.Size(37, 20);
            this.numericUpDownOrdinate.TabIndex = 7;
            // 
            // FormAskingUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 236);
            this.Controls.Add(this.listBoxSelectcart);
            this.Controls.Add(this.groupBoxCartposition);
            this.Controls.Add(this.numericUpDownNumberofcarts);
            this.Controls.Add(this.labelNumberofcarts);
            this.Controls.Add(this.buttonOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAskingUser";
            this.Text = "Initialisation des chariots";
            this.Load += new System.EventHandler(this.FormAskingUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberofcarts)).EndInit();
            this.groupBoxCartposition.ResumeLayout(false);
            this.groupBoxCartposition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAbscissa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOrdinate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelNumberofcarts;
        private System.Windows.Forms.NumericUpDown numericUpDownNumberofcarts;
        private System.Windows.Forms.Label labelAbscissa;
        private System.Windows.Forms.GroupBox groupBoxCartposition;
        private System.Windows.Forms.ListBox listBoxSelectcart;
        private System.Windows.Forms.Label labelOrdinate;
        private System.Windows.Forms.Button buttonSetPosition;
        private System.Windows.Forms.NumericUpDown numericUpDownAbscissa;
        private System.Windows.Forms.NumericUpDown numericUpDownOrdinate;
    }
}