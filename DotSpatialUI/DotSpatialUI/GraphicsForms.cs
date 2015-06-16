namespace DotSpatialUI
{

    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using ZedGraph;

    public partial class GraphicsForms : Form
    {
        public static List<string> layerName;


        public GraphicsForms(Dictionary<int, List<PathPoint>> ssv, List<string> sss)
        {
            InitializeComponent();

            List<PathPoint> pathList = null;
            var extrele = new List<PathPoint>();

            for (int x = 0; x < ssv.Count(); x ++)
            {
                var vall = ssv.ElementAt(x);
                var exe = vall.Value;

                pathList = exe;

                double[] distanceArray = new double[pathList.Count];
                double[] elevationArray = new double[pathList.Count];


                for (int y = 0; y <= pathList.Count - 1; y++)
                {
                    distanceArray[y] = pathList[y].Distance;
                    distanceArray[y] = pathList[y].Elevation;

                }

                ZedGraph.LineItem myCurve = uxZedGraphControl.GraphPane.AddCurve(sss[x], distanceArray, elevationArray, Color.Tomato);
                myCurve.Line.Width = 1f;
                myCurve.Symbol.Type = ZedGraph.SymbolType.HDash;
            }

            uxZedGraphControl.GraphPane.Title = "Soil Profile";
            uxZedGraphControl.GraphPane.XAxis.Title = "Distance (Meters)";
            uxZedGraphControl.GraphPane.Y2Axis.Title = "Depth (Meters)";

            uxZedGraphControl.AxisChange();
        
        }
       
    }
}
