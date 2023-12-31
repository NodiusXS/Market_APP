﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_APP.Models;

public class Game
{
    public string Name { get; set; }
    public string[] Subtitle { get; set; }
    public string Icon { get; set; }
    public string FullImage { get; set; }
    public int Stars { get; set; }
    public double Download {  get; set; }
    public string Description { get; set; }
    public Color AccentColorStart { get; set; }
    public Color AccentColorEnd { get; set; }
    public List<string> Images { get; set; }


    // Background
    public Brush Background
    {
        get
        {
            var gradientStops = new GradientStopCollection();
            gradientStops.Add(new GradientStop(AccentColorStart, 0.0f));
            gradientStops.Add(new GradientStop(AccentColorEnd, 1.0f));

            var bgBrush = new LinearGradientBrush(
                gradientStops,
                new Point(0.0, 0.0),
                new Point(1.0, 1.0));

            return bgBrush;
        }
    }

}
