namespace DotSpatialUI
{
    using DotSpatial.Controls;
    using DotSpatial.Data;
    using DotSpatial.Symbology;
    using DotSpatial.Topology;
    using DotSpatial.Projections;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;




    public partial class uxDotSpatial : Form
    {
        #region Variables

        private Boolean pathFinished = false;
        private Boolean clickOn = false;
        private FeatureSet newLine;
        private FeatureSet newPoint;
        private MapLineLayer newLineLayer;
        private MapPointLayer newPointLayer;
        private int xyPointsLineId;
        private int xyPointsId;
        private int eventKind;

        #endregion Variables


        public uxDotSpatial()
        {
            InitializeComponent();
            uxAppManager.LoadExtensions();
        }

        #region MenuBar

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uxMap.AddRasterLayer();
            uxMap.ZoomToMaxExtent();
        }

        private void openVectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uxMap.AddLayer();
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uxMap.FunctionMode = DotSpatial.Controls.FunctionMode.ZoomIn;
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uxMap.FunctionMode = DotSpatial.Controls.FunctionMode.ZoomOut;
        }

        private void drawLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (IMapLineLayer paths in uxMap.GetLineLayers())
            {
                uxMap.Layers.Remove(paths);
            }

            uxMap.Cursor = Cursors.Cross;
            pathFinished = false;
            DataColumn aColumn = new DataColumn("Id");

            newLine = new FeatureSet(FeatureType.Line);
            newLine.Projection = uxMap.Projection;
            newLine.DataTable.Columns.Add(aColumn);
            newLineLayer = (MapLineLayer)uxMap.Layers.Add(newLine);
            LineSymbolizer lineSymbol = new LineSymbolizer(Color.Tomato, 1);
            newLineLayer.Symbolizer = lineSymbol;
            newLineLayer.LegendText = "Soil Profile";

            eventKind = 1;
            clickOn = true;
        }

        private void getCoordinateToolStripMenuItem_Click(object sender, EventArgs e)
        {

            uxMap.Cursor = Cursors.Hand;
            pathFinished = false;
            DataColumn aColumn = new DataColumn("Id");

            newPoint = new FeatureSet(FeatureType.Point);
            newPoint.Projection = uxMap.Projection;
            newPoint.DataTable.Columns.Add(aColumn);
            newPointLayer = (MapPointLayer)uxMap.Layers.Add(newPoint);
            PointSymbolizer pointSymbol = new PointSymbolizer(Color.Violet, DotSpatial.Symbology.PointShape.Diamond, 3);
            newPointLayer.Symbolizer = pointSymbol;
            newPointLayer.LegendText = "Get Coordinates";

            eventKind = 2;

        }

        #endregion MenuBar

        #region Drawing

        private void uxMap_MouseDown(object sender, MouseEventArgs e)
        {
            if (pathFinished == true)
                return;

            switch (eventKind) { 
            
                case 1:
                    if (e.Button == MouseButtons.Left){
                        Coordinate xyPoint = uxMap.PixelToProj(e.Location);

                        if (clickOn)
                        {
                            //MessageBox.Show("It' working");

                            List<Coordinate> xyPointsLine = new List<Coordinate>();
                            LineString xyLineGeometry = new LineString(xyPointsLine);
                            IFeature newLineFeature = newLine.AddFeature(xyLineGeometry);
                            newLineFeature.Coordinates.Add(xyPoint);

                            xyPointsLineId += 1;
                            newLineFeature.DataRow["Id"] = xyPointsLineId;

                            clickOn = false;
                        }
                        else
                        {
                            IFeature createdFeature = newLine.Features[newLine.Features.Count - 1];
                            createdFeature.Coordinates.Add(xyPoint);

                            if (createdFeature.Coordinates.Count() >= 2)
                            {
                                newLine.InitializeVertices();
                                uxMap.ResetBuffer();
                            }
                        }
                    }
                    else if (e.Button == MouseButtons.Right)
                    {
                        clickOn = true;
                        uxMap.ResetBuffer();
                        SaveAndCreateShp(newLine);
                    }
                break;
                case 2:
                if (e.Button == MouseButtons.Left)
                {
                    Coordinate xyOnePoint = uxMap.PixelToProj(e.Location);

                    Coordinate xyTwoPoint =  new Coordinate();
                    xyTwoPoint.X = (414227.273622587);
                    xyTwoPoint.Y = (4455818.31551072);

                    
                    List<Coordinate> xyPoints = new List<Coordinate>();
                    LineString xyPointGeometry = new LineString(xyPoints);
                    IFeature newPointFeature = newPoint.AddFeature(xyPointGeometry);
                    newPointFeature.Coordinates.Add(xyOnePoint);
                    newPointFeature.Coordinates.Add(xyTwoPoint);


                    

                    xyPointsId += 1;
                    newPointFeature.DataRow["Id"] = xyPointsId;


                    IFeature createdPointFeature = newPoint.Features[newPoint.Features.Count - 1];
                    createdPointFeature.Coordinates.Add(xyOnePoint);

                    //ProjectionInfo pStart = KnownCoordinateSystems.Geographic.NorthAmerica.NorthAmericanDatum1983;

                    

                    newPoint.InitializeVertices();
                    uxMap.ResetBuffer();

                   


                    
                }
                break;
            }

           

        }

        #endregion DrawingALine

        private void viewSoilProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x;
            try
            {
                IMapRasterLayer getRasterLayer = default(IMapRasterLayer);
                IMapLineLayer getPathLineLayer = default(IMapLineLayer);
                Dictionary<int, List<PathPoint>> ss = new Dictionary<int, List<PathPoint>>();
                List<string> getLayersNames = new List<string>();
                double lineDistance = 0;

                if (uxMap.GetRasterLayers().Count() == 0)
                {
                    return;
                }

                if (uxMap.GetLineLayers().Count() == 0)
                {
                    return;
                }

                getPathLineLayer = uxMap.GetLineLayers()[0];

                IFeatureSet pathLineFeatures = getPathLineLayer.DataSet;

                IList<Coordinate> xyPointsLine = pathLineFeatures.Features[0].Coordinates;

                int numLayers = uxMap.GetRasterLayers().Count();

                for (x = 0; x < numLayers; x++)
                {
                    List<PathPoint> pathPointsList = new List<PathPoint>();

                    getRasterLayer = uxMap.GetRasterLayers()[x];

                    for (int y = 0; y < xyPointsLine.Count() - 1; y++) { 
                    
                        //Lines Segments
                        Coordinate startXyPoint = xyPointsLine[y];
                        Coordinate endXyPoint = xyPointsLine[y + 1];
                        List<PathPoint> xySegmentLineList = getElevation(startXyPoint.X, startXyPoint.Y, endXyPoint.X, endXyPoint.Y, getRasterLayer);
                        pathPointsList.AddRange(xySegmentLineList);
                    
                    }

                    for (int y = 1; y < pathPointsList.Count() - 1; y++)
                    {

                        double xOne = pathPointsList[y - 1].X;
                        double yOne = pathPointsList[y - 1].Y;
                        double xTwo = pathPointsList[y].X;
                        double yTwo = pathPointsList[y].Y;

                        double addDistance = Math.Sqrt(((xTwo - xOne) * (xTwo - xOne)) + ((yTwo - yOne) * (yTwo - yOne)));

                        lineDistance += addDistance;

                        pathPointsList[y].Distance = lineDistance;
                    }

                    ss.Add(x, pathPointsList);
                    getLayersNames.Add((uxMap.GetRasterLayers()[x].LegendText.ToString()));
                }

                GraphicsForms getGraph = new GraphicsForms(ss, getLayersNames);
                getGraph.Show();

            }
            catch (Exception)
            {
            }
        }

        public List<PathPoint> getElevation(double xPointStart, double yPointStart, double xEndPoint, double yEndPoint, IMapRasterLayer rasterLayer)
        {
            double curX = xPointStart;
            double curY = yPointStart;
            double curElevation = 0;

            List<PathPoint> pathPointList = new List<PathPoint>();

            int numberofpoints = 100;

            double constXDif = ((xEndPoint - xPointStart) / numberofpoints);
            double constYDif = ((yEndPoint - yPointStart) / numberofpoints);



            for (int i = 0; i <= numberofpoints; i++)
            {
                PathPoint newPathPoint = new PathPoint();

                if ((i == 0))
                {
                    curX = xPointStart;
                    curY = yPointStart;
                }
                else
                {
                    curX = curX + constXDif;
                    curY = curY + constYDif;
                }

                Coordinate coordinate = new Coordinate(curX, curY);

                RcIndex rowColumn = rasterLayer.DataSet.Bounds.ProjToCell(coordinate);

                curElevation = rasterLayer.DataSet.Value[rowColumn.Row, rowColumn.Column];

                //set the properties of new PathPoint
                newPathPoint.X = curX;
                newPathPoint.Y = curY;
                newPathPoint.Elevation = curElevation;
                pathPointList.Add(newPathPoint);
            }

            return pathPointList;
        }

        public void SaveAndCreateShp(FeatureSet lineShape)
        {
            Random num = new Random();
            lineShape.SaveAs("c:\\dev\\LineShape_" + num.Next().ToString() + ".shp", true);
        }

        private void uxMap_MouseUp(object sender, MouseEventArgs e)
        {
            uxToolStripStatusLabel.Text = string.Format("Lat: {0} Long: {1}", uxMap.PixelToProj(e.Location).Y.ToString(), uxMap.PixelToProj(e.Location).X.ToString());
        }
        
    }
}