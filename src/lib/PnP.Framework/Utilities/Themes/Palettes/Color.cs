﻿namespace PnP.Framework.Utilities.Themes.Palettes
{
    public class Color : IColor
    {
        public string hex { get; set; }
        public string str { get; set; }
        public int r { get; set; }
        public int g { get; set; }
        public int b { get; set; }
        public int? a { get; set; }
        public float h { get; set; }
        public float s { get; set; }
        public float v { get; set; }
    }

    public class HslColor : IHSL
    {
        public float h { get; set; }
        public float s { get; set; }
        public float l { get; set; }
    }
}
