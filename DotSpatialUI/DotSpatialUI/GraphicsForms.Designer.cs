namespace DotSpatialUI
{
    partial class GraphicsForms
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
            this.uxZedGraphControl = new ZedGraph.ZedGraphControl();
            this.SuspendLayout();
            // 
            // uxZedGraphControl
            // 
            this.uxZedGraphControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxZedGraphControl.IsShowPointValues = false;
            this.uxZedGraphControl.Location = new System.Drawing.Point(0, 0);
            this.uxZedGraphControl.Name = "uxZedGraphControl";
            this.uxZedGraphControl.PointValueFormat = "G";
            this.uxZedGraphControl.Size = new System.Drawing.Size(663, 418);
            this.uxZedGraphControl.TabIndex = 0;
            // 
            // GraphicsForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 418);
            this.Controls.Add(this.uxZedGraphControl);
            this.Name = "GraphicsForms";
            this.Text = "GraphicsForms";
            this.ResumeLayout(false);

        }

        #endregion

        private ZedGraph.ZedGraphControl uxZedGraphControl;
    }
}