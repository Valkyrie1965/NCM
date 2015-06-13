﻿using System;

namespace ColorManager
{
    public sealed class Colorspace_NTSCRGB : ColorspaceRGB
    {
        public override string Name
        {
            get { return "NTSCRGB"; }
        }
        public override double Gamma
        {
            get { return g; }
        }
        public override double[] Cr
        {
            get { return new double[] { 0.67, 0.33 }; }
        }
        public override double[] Cg
        {
            get { return new double[] { 0.21, 0.71 }; }
        }
        public override double[] Cb
        {
            get { return new double[] { 0.14, 0.08 }; }
        }
        public override double[] CM
        {
            get { return new double[] { 0.6068909, 0.1735011, 0.200348, 0.2989164, 0.586599, 0.1144845, 0.0, 0.0660957, 1.1162243 }; }
        }
        public override double[] ICM
        {
            get { return new double[] { 1.9099961, -0.5324542, -0.2882091, -0.9846663, 1.999171, -0.0283082, 0.0583056, -0.1183781, 0.8975535 }; }
        }

        private const double g = 2.19921875d;
        private const double g1 = 1 / g;

        private static readonly Whitepoint wp = new WhitepointC();

        public Colorspace_NTSCRGB()
            : base(wp)
        { }

        public unsafe override void ToLinear(double* inVal, double* outVal)
        {
            outVal[0] = Math.Pow(inVal[0], g);
            outVal[1] = Math.Pow(inVal[1], g);
            outVal[2] = Math.Pow(inVal[2], g);
        }

        public unsafe override void ToNonLinear(double* inVal, double* outVal)
        {
            outVal[0] = Math.Pow(inVal[0], g1);
            outVal[1] = Math.Pow(inVal[1], g1);
            outVal[2] = Math.Pow(inVal[2], g1);
        }
    }
}
