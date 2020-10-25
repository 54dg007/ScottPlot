﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ScottPlot.Renderable
{
    /// <summary>
    /// This class holds styling information about tick marks, tick labels, and grid lines
    /// </summary>
    public class Ticks
    {
        public double[] Positions;
        public float MarkLength = 10;
        public Color MarkColor = Color.Black;

        public string[] Labels;
        public Drawing.Font LabelFont = new Drawing.Font();
        public float LabelRotation = 0;

        public bool GridLines = false;
        public Color GridLineColor = Color.Black;
        public LineStyle GridLineStyle = LineStyle.Solid;

        public bool PixelSnap = true;
    }
}