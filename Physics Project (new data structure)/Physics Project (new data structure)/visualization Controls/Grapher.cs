using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Physics_Project__new_data_structure_
{
    public partial class Grapher : UserControl
    {
        #region Properties

        public bool AxiVisible = true;
        public bool GridVisible = true;

        public int GridsNumX = 10;
        public int GridsNumY = 10;

        public Color AxiColor = Color.Black;
        public Color GridColor = Color.LightGray;

        public int ZoomInterval = 10;
        public bool _AutoScale = true;
        #endregion


        public bool RealTimeMode;


        private bool _dragging = false;
        private float _xPosDragging;
        private float _yPosDragging;

        private List<DataList> DataLists = new List<DataList>();
        //private DataSet selectedDataSet = new DataSet();
        private int selectedDataList;
        private float minX = 0, maxX = 0;
        private float minY = 0, maxY = 0;
        private float scaleX = 1;
        private float scaleY = 1;
        private PointF origin = new PointF();
        private Random tempRandom = new Random();

        PointF previusPoint = new PointF();
        PointF indexPoint = new PointF();
        float gridJumpX, gridJumpY;


        private Bitmap backgroundBitmap;
        private Color clearColor;
        private int _offsetW;
        private int _offsetH;
        private Point[] _borderPoints;
        private int offsetW
        {
            get { return _offsetW; }
            set
            {
                _offsetW = value;
                displayPB.MinimumSize = new Size(_offsetW + 1, _offsetH + 1);
                RefreshBorderPoints();
            }
        }
        private int offsetH
        {
            get { return _offsetH; }
            set
            {
                _offsetH = value;
                displayPB.MinimumSize = new Size(_offsetW + 1, _offsetH + 1);
                RefreshBorderPoints();
            }
        }
        private void RefreshBorderPoints()
        {
            _borderPoints = new Point[5];
            _borderPoints[0].X = offsetW;
            _borderPoints[0].Y = displayPB.Height - offsetH;
            _borderPoints[1].X = displayPB.Width - 1;
            _borderPoints[1].Y = displayPB.Height - offsetH;
            _borderPoints[2].X = displayPB.Width - 1;
            _borderPoints[2].Y = 0;
            _borderPoints[3].X = offsetW;
            _borderPoints[3].Y = 0;
            _borderPoints[4].X = offsetW;
            _borderPoints[4].Y = displayPB.Height - offsetH;
        }
        public float realWidth
        {
            get { return displayPB.Width - offsetW; }
        }
        public float realHeight
        {
            get { return displayPB.Height - offsetH; }
        }

        private char[] SuperScriptNums = new char[10]
        {
            '⁰',
            '¹',
            '²',
            '³',
            '⁴',
            '⁵',
            '⁶',
            '⁷',
            '⁸',
            '⁹'
        };
        RandomColor randomColor = new RandomColor();

        private Pen gp = new Pen(Color.Black); // gp = "Global Pen"
        private SolidBrush gsb = new SolidBrush(Color.Black); // gsb = "Global SolidBrush"
        private Font gvf = new Font("Microsoft Sans Serif", 10, FontStyle.Regular, GraphicsUnit.Pixel); // gvf = "Grid Values Font"
        //private ColorPicker cp = new ColorPicker();




        public Grapher()
        {
            InitializeComponent();

            offsetW = 50;
            offsetH = 20;
            RealTimeMode = false;
            clearColor = Color.FromArgb(0, 0, 0, 0);
            backgroundBitmap = new Bitmap(displayPB.Width, displayPB.Height);
            displayPB.BackgroundImage = backgroundBitmap;

            displayPB.MouseWheel += DisplayPB_MouseWheel;
        }



        public void Add_DataList(DataList dataList)
        {
            dataList.LineColor = randomColor.GetColor();
            DataLists.Add(dataList);
            selectedDataList = DataLists.Count - 1;

            dataListsTV.Nodes.Add(dataList.Get_FullName());
            dataListsTV.Nodes[selectedDataList].Checked = dataList.Visible;
            dataListsTV.SelectedNode = dataListsTV.Nodes[selectedDataList];
        }

        public void Remove_DataList(DataList dataList)
        {
            RemoveAt_DataList(DataLists.IndexOf(dataList));
        }
        public void RemoveAt_DataList(int index)
        {
            DataLists.RemoveAt(index);
            dataListsTV.Nodes.RemoveAt(index);
        }



        private void SetScale(Size size)
        {
            if (_AutoScale)
            {
                minX = 0; maxX = 0;
                minY = 0; maxY = 0;

                foreach (DataList dl in DataLists)
                    if (dl.Visible && dl.Value_X.Count > 0 && dl.Value_Y.Count > 0)
                    {
                        if (dl.Value_X.MinVal < minX)
                            minX = dl.Value_X.MinVal;
                        if (dl.Value_X.MaxVal > maxX)
                            maxX = dl.Value_X.MaxVal;
                        if (dl.Value_Y.MinVal < minY)
                            minY = dl.Value_Y.MinVal;
                        if (dl.Value_Y.MaxVal > maxY)
                            maxY = dl.Value_Y.MaxVal;
                    }

                //float rangeX = maxX - minX, rangeY = maxY - minY;
                minX -= 1; //rangeX / 10;
                maxX += 1; //rangeX / 10;
                minY -= 1; //rangeY / 10;
                maxY += 1; //rangeY / 10;
            }

            scaleX = realWidth / (maxX - minX);
            scaleY = realHeight / (maxY - minY);

            origin.X = -minX;
            origin.Y = maxY;
        }
        private void DrawGrid(Graphics g, Size size, int roundTo = 3)
        {
            gridJumpX = (float)Math.Round((maxX - minX) / GridsNumX, roundTo);
            gridJumpY = (float)Math.Round((maxY - minY) / GridsNumY, roundTo);


            gp.Color = GridColor;
            gsb.Color = Color.Black;

            string valueS;
            float index;

            if (minX > 0)
            {
                for (index = 0; index < minX; index += gridJumpX) { }
                for (; index < maxX; index += gridJumpX)
                {
                    g.DrawLine(gp, offsetW + (origin.X + index) * scaleX, 0, offsetW + (origin.X + index) * scaleX, size.Height - offsetH);
                    valueS = index.ToString();
                    g.DrawString(valueS, gvf, gsb, offsetW + (origin.X + index) * scaleX - valueS.Length * 3, size.Height - 16);
                }
            }
            else if (maxX < 0)
            {
                for (index = 0; index > maxX; index -= gridJumpX) { }
                for (; index > minX; index -= gridJumpX)
                {
                    g.DrawLine(gp, offsetW + (origin.X + index) * scaleX, 0, offsetW + (origin.X + index) * scaleX, size.Height - offsetH);
                    valueS = index.ToString();
                    g.DrawString(valueS, gvf, gsb, offsetW + (origin.X + index) * scaleX - valueS.Length * 3, size.Height - 16);
                }
            }
            else
            {
                index = -gridJumpX;
                for (; index > minX; index -= gridJumpX)
                {
                    g.DrawLine(gp, offsetW + (origin.X + index) * scaleX, 0, offsetW + (origin.X + index) * scaleX, size.Height - offsetH);
                    valueS = index.ToString();
                    g.DrawString(valueS, gvf, gsb, offsetW + (origin.X + index) * scaleX - valueS.Length * 3, size.Height - 16);
                }
                index = gridJumpX;
                for (; index < maxX; index += gridJumpX)
                {
                    g.DrawLine(gp, offsetW + (origin.X + index) * scaleX, 0, offsetW + (origin.X + index) * scaleX, size.Height - offsetH);
                    valueS = index.ToString();
                    g.DrawString(valueS, gvf, gsb, offsetW + (origin.X + index) * scaleX - valueS.Length * 3, size.Height - 16);
                }
                gp.Color = AxiColor;
                g.DrawLine(gp, offsetW + origin.X * scaleX, 0, offsetW + origin.X * scaleX, size.Height - offsetH);
                g.DrawString("0", gvf, gsb, offsetW + origin.X * scaleX - 3, size.Height - 16);
                gp.Color = GridColor;
            }

            if (minY > 0)
            {
                for (index = 0; index < minY; index += gridJumpY) { }
                for (; index < maxY; index += gridJumpY)
                {
                    g.DrawLine(gp, offsetW, (origin.Y - index) * scaleY, size.Width - 1, (origin.Y - index) * scaleY);
                    valueS = index.ToString();
                    g.DrawString(valueS, gvf, gsb, offsetW - 5 * (valueS.Length + 2), (origin.Y - index) * scaleY - 5);
                }
            }
            else if (maxY < 0)
            {
                for (index = 0; index > maxY; index -= gridJumpY) { }
                for (; index > minY; index -= gridJumpY)
                {
                    g.DrawLine(gp, offsetW, (origin.Y - index) * scaleY, size.Width - 1, (origin.Y - index) * scaleY);
                    valueS = index.ToString();
                    g.DrawString(valueS, gvf, gsb, offsetW - 5 * (valueS.Length + 2), (origin.Y - index) * scaleY - 5);
                }
            }
            else
            {
                index = -gridJumpY;
                for (; index > minY; index -= gridJumpY)
                {
                    g.DrawLine(gp, offsetW, (origin.Y - index) * scaleY, size.Width - 1, (origin.Y - index) * scaleY);
                    valueS = index.ToString();
                    g.DrawString(valueS, gvf, gsb, offsetW - 5 * (valueS.Length + 2), (origin.Y - index) * scaleY - 5);
                }
                index = gridJumpY;
                for (; index < maxY; index += gridJumpY)
                {
                    g.DrawLine(gp, offsetW, (origin.Y - index) * scaleY, size.Width - 1, (origin.Y - index) * scaleY);
                    valueS = index.ToString();
                    g.DrawString(valueS, gvf, gsb, offsetW - 5 * (valueS.Length + 2), (origin.Y - index) * scaleY - 5);
                }
                gp.Color = AxiColor;
                g.DrawLine(gp, offsetW, origin.Y * scaleY, size.Width - 1, origin.Y * scaleY);
                g.DrawString("0", gvf, gsb, offsetW - 15, (origin.Y) * scaleY - 5);
                gp.Color = GridColor;
            }
        }



        private void DrawBorders(Graphics g)
        {
            g.DrawLines(new Pen(Color.Black), _borderPoints);
        }



        public void Update2()
        {
            Graphics g = Graphics.FromImage(backgroundBitmap);
            g.Clear(clearColor);

            SetScale(backgroundBitmap.Size);
            DrawGrid(g, backgroundBitmap.Size);
            DrawBorders(g);

            float tempSlope;
            bool inRange_X;
            bool inRange_Y;
            bool fillEllipse;

            foreach (DataList dl in DataLists)
                if (dl.Visible && dl.Value_X.Count > 0 && dl.Value_Y.Count > 0)
                {
                    //if (!RealTimeMode)
                    //    for (int i = 0; i < ds.Polynoms.Count; i++)
                    //        if (ds.Polynoms[i].Visible)
                    //            DrawPolynom(g, ds.Polynoms[i], (int)polyResNUD.Value);

                    previusPoint.X = dl.Value_X.Value[0];
                    previusPoint.Y = dl.Value_Y.Value[0];

                    gsb.Color = dl.LineColor;
                    gp.Color = dl.LineColor;

                    if (previusPoint.X > minX && previusPoint.X < maxX &&
                        previusPoint.Y > minY && previusPoint.Y < maxY)
                        g.FillEllipse(gsb, offsetW + (origin.X + previusPoint.X) * scaleX - 2, (origin.Y - previusPoint.Y) * scaleY - 2, 3, 3);

                    // g.DrawString("(" + ds.DataX.Data[0].ToString() + ", " + ds.DataY.Data[0] + ")", new Font("Microsoft Sans Serif", 7.8f), new SolidBrush(Color.Black), (origin.X + ds.DataX.Data[0]) * scaleX, (origin.Y - ds.DataY.Data[0] - 2) * scaleY);

                    for (int i = 1; i < dl.Value_X.Count && i < dl.Value_Y.Count; i++)
                    {
                        indexPoint.X = dl.Value_X.Value[i];
                        indexPoint.Y = dl.Value_Y.Value[i];

                        tempSlope = (indexPoint.Y - previusPoint.Y) / (indexPoint.X - previusPoint.X);
                        fillEllipse = true;

                        if (previusPoint.X >= minX && previusPoint.X <= maxX &&
                                indexPoint.X >= minX && indexPoint.X <= maxX)
                            inRange_X = true;
                        else
                        {
                            inRange_X = false;
                            if (previusPoint.X < minX && indexPoint.X > minX)
                            {
                                previusPoint.Y += (minX - previusPoint.X) * tempSlope;
                                previusPoint.X = minX;
                                inRange_X = true;
                            }
                            else if (previusPoint.X > maxX && indexPoint.X < maxX)
                            {
                                previusPoint.Y += (maxX - previusPoint.X) * tempSlope;
                                previusPoint.X = maxX;
                                inRange_X = true;
                            }
                            if (indexPoint.X < minX && previusPoint.X > minX)
                            {
                                indexPoint.Y += (minX - indexPoint.X) * tempSlope;
                                indexPoint.X = minX;
                                inRange_X = true;
                                fillEllipse = false;
                            }
                            else if (indexPoint.X > maxX && previusPoint.X < maxX)
                            {
                                indexPoint.Y += (maxX - indexPoint.X) * tempSlope;
                                indexPoint.X = maxX;
                                inRange_X = true;
                                fillEllipse = false;
                            }
                        }

                        if (inRange_X)
                        {
                            if (previusPoint.Y >= minY && previusPoint.Y <= maxY &&
                                indexPoint.Y >= minY && indexPoint.Y <= maxY)
                                inRange_Y = true;
                            else
                            {
                                inRange_Y = false;
                                if (previusPoint.Y < minY && indexPoint.Y > minY)
                                {
                                    previusPoint.X += (minY - previusPoint.Y) / tempSlope;
                                    previusPoint.Y = minY;
                                    inRange_Y = true;
                                }
                                else if (previusPoint.Y > maxY && indexPoint.Y < maxY)
                                {
                                    previusPoint.X += (maxY - previusPoint.Y) / tempSlope;
                                    previusPoint.Y = maxY;
                                    inRange_Y = true;
                                }
                                if (indexPoint.Y < minY && previusPoint.Y > minY)
                                {
                                    indexPoint.X += (minY - indexPoint.Y) / tempSlope;
                                    indexPoint.Y = minY;
                                    inRange_Y = true;
                                }
                                else if (indexPoint.Y > maxY && previusPoint.Y < maxY)
                                {
                                    indexPoint.X += (maxY - indexPoint.Y) / tempSlope;
                                    indexPoint.Y = maxY;
                                    inRange_Y = true;
                                }
                            }

                            if (inRange_Y)
                            {
                                if (!RealTimeMode)
                                    g.DrawLine(gp, offsetW + (origin.X + previusPoint.X) * scaleX, (origin.Y - previusPoint.Y) * scaleY,
                                    offsetW + (origin.X + indexPoint.X) * scaleX, (origin.Y - indexPoint.Y) * scaleY);
                                if (fillEllipse)
                                    g.FillEllipse(gsb, offsetW + (origin.X + indexPoint.X) * scaleX - 2, (origin.Y - indexPoint.Y) * scaleY - 2, 3, 3);
                            }

                        }

                        previusPoint = new PointF(dl.Value_X.Value[i], dl.Value_Y.Value[i]);
                        // g.DrawString("(" + ds.DataX.Data[i].ToString() + ", " + ds.DataY.Data[i] + ")", new Font("Microsoft Sans Serif", 7.8f), new SolidBrush(Color.Black), (origin.X + ds.DataX.Data[i]) * scaleX, (origin.Y - ds.DataY.Data[i] - 2) * scaleY);
                    }
                }

            //displayPB.BackgroundImage = backgroundBitmap;
            displayPB.Refresh();
        }



        private void displayPB_Resize(object sender, EventArgs e)
        {
            if (backgroundBitmap != null)
                backgroundBitmap.Dispose();
            backgroundBitmap = new Bitmap(displayPB.Width, displayPB.Height);
            displayPB.BackgroundImage = backgroundBitmap;

            RefreshBorderPoints();
            Update2();
        }
        private void displayPB_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _AutoScale = false;
                _dragging = true;
                _xPosDragging = e.X;
                _yPosDragging = e.Y;
            }
        }
        private void displayPB_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                float tempXOffset = (_xPosDragging - e.X) / scaleX;
                float tempYOffset = (e.Y - _yPosDragging) / scaleY;
                minX += tempXOffset;
                maxX += tempXOffset;
                minY += tempYOffset;
                maxY += tempYOffset;
                _xPosDragging = e.X;
                _yPosDragging = e.Y;
                Update2();
            }
        }
        private void displayPB_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }
        private void DisplayPB_MouseWheel(object sender, MouseEventArgs e)
        {
            float tempIntervalX = (float)(maxX - minX) / ZoomInterval,
                tempIntervalY = (float)(maxY - minY) / ZoomInterval;

            if (e.Delta > 0)
            {
                if (minX + 2 * tempIntervalX < maxX &&
                        minY + 2 * tempIntervalY < maxY)
                {
                    if (e.X < offsetW)
                    {
                        minY += tempIntervalY;
                        maxY -= tempIntervalY;
                    }
                    else if (e.Y > displayPB.Height - offsetH)
                    {
                        minX += tempIntervalX;
                        maxX -= tempIntervalX;
                    }
                    else
                    {
                        minX += tempIntervalX;
                        maxX -= tempIntervalX;
                        minY += tempIntervalY;
                        maxY -= tempIntervalY;
                    }
                }
            }
            else if (e.Delta < 0)
            {
                if (e.X < offsetW)
                {
                    minY -= tempIntervalY;
                    maxY += tempIntervalY;
                }
                else if (e.Y > displayPB.Height - offsetH)
                {
                    minX -= tempIntervalX;
                    maxX += tempIntervalX;
                }
                else
                {
                    minX -= tempIntervalX;
                    maxX += tempIntervalX;
                    minY -= tempIntervalY;
                    maxY += tempIntervalY;
                }
            }

            _AutoScale = false;
            Update2();
        }
        private void displayPB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _AutoScale = true;
                Update2();
            }
        }


    }
}
