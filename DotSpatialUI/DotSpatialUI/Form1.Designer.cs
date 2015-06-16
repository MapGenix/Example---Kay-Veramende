namespace DotSpatialUI
{

    using DotSpatial.Analysis;
    using DotSpatial.Controls;
    using DotSpatial.Data;
    using DotSpatial.Extensions;
    using DotSpatial.Modeling;
    using DotSpatial.Symbology.Forms;
    using DotSpatial.Symbology;
    using DotSpatial.Topology;
    

    partial class uxDotSpatial
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uxDotSpatial));
            this.uxContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openVectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSoilProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getCoordinateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxSpatialStatusStrip = new DotSpatial.Controls.SpatialStatusStrip();
            this.uxToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.uxSpatialToolStrip = new DotSpatial.Controls.SpatialToolStrip();
            this.uxMap = new DotSpatial.Controls.Map();
            this.uxLegend = new DotSpatial.Controls.Legend();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.uxAppManager = new DotSpatial.Controls.AppManager();
            this.uxLabelCoordinate = new System.Windows.Forms.Label();
            this.uxToolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1.SuspendLayout();
            this.uxSpatialStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxContextMenuStrip
            // 
            this.uxContextMenuStrip.Name = "contextMenuStrip1";
            this.uxContextMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1004, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.openVectoToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.openFileToolStripMenuItem.Text = "Open Raster File...";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // openVectoToolStripMenuItem
            // 
            this.openVectoToolStripMenuItem.Name = "openVectoToolStripMenuItem";
            this.openVectoToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.openVectoToolStripMenuItem.Text = "Open Vector File...";
            this.openVectoToolStripMenuItem.Click += new System.EventHandler(this.openVectoToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.zoomInToolStripMenuItem.Text = "Zoom In";
            this.zoomInToolStripMenuItem.Click += new System.EventHandler(this.zoomInToolStripMenuItem_Click);
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.zoomOutToolStripMenuItem.Text = "Zoom Out";
            this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawLineToolStripMenuItem,
            this.viewSoilProfileToolStripMenuItem,
            this.getCoordinateToolStripMenuItem});
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolToolStripMenuItem.Text = "Tool ";
            // 
            // drawLineToolStripMenuItem
            // 
            this.drawLineToolStripMenuItem.Name = "drawLineToolStripMenuItem";
            this.drawLineToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.drawLineToolStripMenuItem.Text = "Draw Line";
            this.drawLineToolStripMenuItem.Click += new System.EventHandler(this.drawLineToolStripMenuItem_Click);
            // 
            // viewSoilProfileToolStripMenuItem
            // 
            this.viewSoilProfileToolStripMenuItem.Name = "viewSoilProfileToolStripMenuItem";
            this.viewSoilProfileToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.viewSoilProfileToolStripMenuItem.Text = "View Soil Profile";
            this.viewSoilProfileToolStripMenuItem.Click += new System.EventHandler(this.viewSoilProfileToolStripMenuItem_Click);
            // 
            // getCoordinateToolStripMenuItem
            // 
            this.getCoordinateToolStripMenuItem.Name = "getCoordinateToolStripMenuItem";
            this.getCoordinateToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.getCoordinateToolStripMenuItem.Text = "Get Coordinate";
            this.getCoordinateToolStripMenuItem.Click += new System.EventHandler(this.getCoordinateToolStripMenuItem_Click);
            // 
            // uxSpatialStatusStrip
            // 
            this.uxSpatialStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxToolStripStatusLabel,
            this.uxToolStripProgressBar});
            this.uxSpatialStatusStrip.Location = new System.Drawing.Point(0, 539);
            this.uxSpatialStatusStrip.Name = "uxSpatialStatusStrip";
            this.uxSpatialStatusStrip.ProgressBar = this.uxToolStripProgressBar;
            this.uxSpatialStatusStrip.ProgressLabel = this.uxToolStripStatusLabel;
            this.uxSpatialStatusStrip.Size = new System.Drawing.Size(1004, 22);
            this.uxSpatialStatusStrip.TabIndex = 2;
            this.uxSpatialStatusStrip.Text = "spatialStatusStrip1";
            // 
            // uxToolStripStatusLabel
            // 
            this.uxToolStripStatusLabel.Name = "uxToolStripStatusLabel";
            this.uxToolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // uxSpatialToolStrip
            // 
            this.uxSpatialToolStrip.ApplicationManager = null;
            this.uxSpatialToolStrip.Location = new System.Drawing.Point(0, 24);
            this.uxSpatialToolStrip.Map = this.uxMap;
            this.uxSpatialToolStrip.Name = "uxSpatialToolStrip";
            this.uxSpatialToolStrip.Size = new System.Drawing.Size(1004, 25);
            this.uxSpatialToolStrip.TabIndex = 3;
            this.uxSpatialToolStrip.Text = "spatialToolStrip1";
            // 
            // uxMap
            // 
            this.uxMap.AllowDrop = true;
            this.uxMap.BackColor = System.Drawing.Color.White;
            this.uxMap.CollectAfterDraw = false;
            this.uxMap.CollisionDetection = false;
            this.uxMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxMap.ExtendBuffer = false;
            this.uxMap.FunctionMode = DotSpatial.Controls.FunctionMode.None;
            this.uxMap.IsBusy = false;
            this.uxMap.IsZoomedToMaxExtent = false;
            this.uxMap.Legend = this.uxLegend;
            this.uxMap.Location = new System.Drawing.Point(0, 0);
            this.uxMap.Name = "uxMap";
            this.uxMap.ProgressHandler = this.uxSpatialStatusStrip;
            this.uxMap.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt;
            this.uxMap.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt;
            this.uxMap.RedrawLayersWhileResizing = false;
            this.uxMap.SelectionEnabled = true;
            this.uxMap.Size = new System.Drawing.Size(693, 490);
            this.uxMap.TabIndex = 0;
            this.uxMap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.uxMap_MouseDown);
            this.uxMap.MouseUp += new System.Windows.Forms.MouseEventHandler(this.uxMap_MouseUp);
            // 
            // uxLegend
            // 
            this.uxLegend.BackColor = System.Drawing.Color.White;
            this.uxLegend.ControlRectangle = new System.Drawing.Rectangle(0, 0, 293, 458);
            this.uxLegend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxLegend.DocumentRectangle = new System.Drawing.Rectangle(0, 0, 187, 428);
            this.uxLegend.HorizontalScrollEnabled = true;
            this.uxLegend.Indentation = 30;
            this.uxLegend.IsInitialized = false;
            this.uxLegend.Location = new System.Drawing.Point(3, 3);
            this.uxLegend.MinimumSize = new System.Drawing.Size(5, 5);
            this.uxLegend.Name = "uxLegend";
            this.uxLegend.ProgressHandler = null;
            this.uxLegend.ResetOnResize = false;
            this.uxLegend.SelectionFontColor = System.Drawing.Color.Black;
            this.uxLegend.SelectionHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.uxLegend.Size = new System.Drawing.Size(293, 458);
            this.uxLegend.TabIndex = 0;
            this.uxLegend.Text = "legend1";
            this.uxLegend.VerticalScrollEnabled = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.uxMap);
            this.splitContainer1.Size = new System.Drawing.Size(1004, 490);
            this.splitContainer1.SplitterDistance = 307;
            this.splitContainer1.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(307, 490);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.uxLegend);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(299, 464);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Legend";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(299, 464);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tool Box";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // uxAppManager
            // 
            this.uxAppManager.Directories = ((System.Collections.Generic.List<string>)(resources.GetObject("uxAppManager.Directories")));
            this.uxAppManager.DockManager = null;
            this.uxAppManager.HeaderControl = null;
            this.uxAppManager.Legend = this.uxLegend;
            this.uxAppManager.Map = this.uxMap;
            this.uxAppManager.ProgressHandler = null;
            this.uxAppManager.ShowExtensionsDialogMode = DotSpatial.Controls.ShowExtensionsDialogMode.Default;
            // 
            // uxLabelCoordinate
            // 
            this.uxLabelCoordinate.AutoSize = true;
            this.uxLabelCoordinate.Location = new System.Drawing.Point(777, 542);
            this.uxLabelCoordinate.Name = "uxLabelCoordinate";
            this.uxLabelCoordinate.Size = new System.Drawing.Size(0, 13);
            this.uxLabelCoordinate.TabIndex = 1;
            // 
            // uxToolStripProgressBar
            // 
            this.uxToolStripProgressBar.Name = "uxToolStripProgressBar";
            this.uxToolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // uxDotSpatial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 561);
            this.Controls.Add(this.uxLabelCoordinate);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.uxSpatialToolStrip);
            this.Controls.Add(this.uxSpatialStatusStrip);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "uxDotSpatial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dot Spatial";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.uxSpatialStatusStrip.ResumeLayout(false);
            this.uxSpatialStatusStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip uxContextMenuStrip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private DotSpatial.Controls.SpatialStatusStrip uxSpatialStatusStrip;
        private DotSpatial.Controls.SpatialToolStrip uxSpatialToolStrip;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private DotSpatial.Controls.Map uxMap;
        private DotSpatial.Controls.Legend uxLegend;
        private DotSpatial.Controls.AppManager uxAppManager;



        protected override void OnShown(System.EventArgs e)
        {
            //IMapRasterLayer newRasterLayer = uxMap.Layers.Add(Raster.Open(@"C:\dev\DotSpatialDev\Tutorial\Components\Ex1\Data\BedRock.bgd"));
           
            //ControlRange(newRasterLayer);
            
            base.OnShown(e);
        }


        #region RasterControlRang
        public void ControlRange(IMapRasterLayer rasterLayer)
        {

            rasterLayer.Symbolizer.Scheme.ApplyScheme(ColorSchemeType.Summer_Mountains, rasterLayer.DataSet);
            rasterLayer.Symbolizer.Scheme.Categories[0].Range = new Range(45, 47);
            rasterLayer.Symbolizer.Scheme.Categories[0].ApplyMinMax(rasterLayer.Symbolizer.EditorSettings);
            rasterLayer.Symbolizer.Scheme.Categories[1].Range = new Range(47,52);
            rasterLayer.Symbolizer.Scheme.Categories[1].ApplyMinMax(rasterLayer.Symbolizer.EditorSettings);
            rasterLayer.Symbolizer.ShadedRelief.ElevationFactor = 1;
            rasterLayer.Symbolizer.ShadedRelief.IsUsed = true;

            rasterLayer.WriteBitmap();

        }
        #endregion

        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openVectoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSoilProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getCoordinateToolStripMenuItem;
        private System.Windows.Forms.Label uxLabelCoordinate;
        private System.Windows.Forms.ToolStripStatusLabel uxToolStripStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar uxToolStripProgressBar;

    }
}

