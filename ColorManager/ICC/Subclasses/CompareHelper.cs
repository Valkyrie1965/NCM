﻿using System;
using System.Collections.Generic;

namespace ColorManager.ICC
{
    internal static unsafe class CMP
    {
        #region Compare One Dimensional Arrays

        public static bool Compare<T>(IList<T> a, IList<T> b)
        {
            if (a == null && b == null) return true;
            if (!CompareBase(a, b)) return false;
            for (int i = 0; i < a.Count; i++) { if (!a[i].Equals(b[i])) return false; }
            return true;
        }

        public static bool Compare(bool[] a, bool[] b)
        {
            if (a == null && b == null) return true;
            if (!CompareBase(a, b)) return false;
            fixed (bool* ap = a)
            fixed (bool* bp = b)
            {
                for (int i = 0; i < a.Length; i++) { if (ap[i] != bp[i]) return false; }
            }
            return true;
        }

        public static bool Compare(byte[] a, byte[] b)
        {
            if (a == null && b == null) return true;
            if (!CompareBase(a, b)) return false;
            fixed (byte* ap = a)
            fixed (byte* bp = b)
            {
                for (int i = 0; i < a.Length; i++) { if (ap[i] != bp[i]) return false; }
            }
            return true;
        }

        public static bool Compare(sbyte[] a, sbyte[] b)
        {
            if (a == null && b == null) return true;
            if (!CompareBase(a, b)) return false;
            fixed (sbyte* ap = a)
            fixed (sbyte* bp = b)
            {
                for (int i = 0; i < a.Length; i++) { if (ap[i] != bp[i]) return false; }
            }
            return true;
        }

        public static bool Compare(short[] a, short[] b)
        {
            if (a == null && b == null) return true;
            if (!CompareBase(a, b)) return false;
            fixed (short* ap = a)
            fixed (short* bp = b)
            {
                for (int i = 0; i < a.Length; i++) { if (ap[i] != bp[i]) return false; }
            }
            return true;
        }

        public static bool Compare(ushort[] a, ushort[] b)
        {
            if (a == null && b == null) return true;
            if (!CompareBase(a, b)) return false;
            fixed (ushort* ap = a)
            fixed (ushort* bp = b)
            {
                for (int i = 0; i < a.Length; i++) { if (ap[i] != bp[i]) return false; }
            }
            return true;
        }

        public static bool Compare(int[] a, int[] b)
        {
            if (a == null && b == null) return true;
            if (!CompareBase(a, b)) return false;
            fixed (int* ap = a)
            fixed (int* bp = b)
            {
                for (int i = 0; i < a.Length; i++) { if (ap[i] != bp[i]) return false; }
            }
            return true;
        }

        public static bool Compare(uint[] a, uint[] b)
        {
            if (a == null && b == null) return true;
            if (!CompareBase(a, b)) return false;
            fixed (uint* ap = a)
            fixed (uint* bp = b)
            {
                for (int i = 0; i < a.Length; i++) { if (ap[i] != bp[i]) return false; }
            }
            return true;
        }

        public static bool Compare(long[] a, long[] b)
        {
            if (a == null && b == null) return true;
            if (!CompareBase(a, b)) return false;
            fixed (long* ap = a)
            fixed (long* bp = b)
            {
                for (int i = 0; i < a.Length; i++) { if (ap[i] != bp[i]) return false; }
            }
            return true;
        }

        public static bool Compare(ulong[] a, ulong[] b)
        {
            if (a == null && b == null) return true;
            if (!CompareBase(a, b)) return false;
            fixed (ulong* ap = a)
            fixed (ulong* bp = b)
            {
                for (int i = 0; i < a.Length; i++) { if (ap[i] != bp[i]) return false; }
            }
            return true;
        }

        public static bool Compare(float[] a, float[] b)
        {
            if (a == null && b == null) return true;
            if (!CompareBase(a, b)) return false;
            fixed (float* ap = a)
            fixed (float* bp = b)
            {
                for (int i = 0; i < a.Length; i++) { if (!Equals(ap[i], bp[i])) return false; }
            }
            return true;
        }

        public static bool Compare(double[] a, double[] b)
        {
            if (a == null && b == null) return true;
            if (!CompareBase(a, b)) return false;
            fixed (double* ap = a)
            fixed (double* bp = b)
            {
                for (int i = 0; i < a.Length; i++) { if (!Equals(ap[i], bp[i])) return false; }
            }
            return true;
        }

        public static bool Compare(decimal[] a, decimal[] b)
        {
            if (a == null && b == null) return true;
            if (!CompareBase(a, b)) return false;
            fixed (decimal* ap = a)
            fixed (decimal* bp = b)
            {
                for (int i = 0; i < a.Length; i++) { if (!Equals(ap[i], bp[i])) return false; }
            }
            return true;
        }

        #endregion

        #region Compare Two Dimensional Arrays (Jagged)

        public static bool Compare<T>(T[][] a, T[][] b)
        {
            if (a == null && b == null) return true;
            if (!CompareBase(a, b)) return false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Length != b[i].Length) return false;

                for (int j = 0; j < a[i].Length; j++)
                {
                    if (!Compare(a[i], b[i])) return false;
                }
            }
            return true;
        }

        public static bool Compare(bool[][] a, bool[][] b)
        {
            if (a == null && b == null) return true;
            if (!CompareBase(a, b)) return false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Length != b[i].Length) return false;

                for (int j = 0; j < a[i].Length; j++)
                {
                    if (!Compare(a[i], b[i])) return false;
                }
            }
            return true;
        }

        public static bool Compare(byte[][] a, byte[][] b)
        {
            if (a == null && b == null) return true;
            if (!CompareBase(a, b)) return false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Length != b[i].Length) return false;

                for (int j = 0; j < a[i].Length; j++)
                {
                    if (!Compare(a[i], b[i])) return false;
                }
            }
            return true;
        }

        public static bool Compare(sbyte[][] a, sbyte[][] b)
        {
            if (a == null && b == null) return true;
            if (!CompareBase(a, b)) return false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Length != b[i].Length) return false;

                for (int j = 0; j < a[i].Length; j++)
                {
                    if (!Compare(a[i], b[i])) return false;
                }
            }
            return true;
        }

        public static bool Compare(short[][] a, short[][] b)
        {
            if (a == null && b == null) return true;
            if (!CompareBase(a, b)) return false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Length != b[i].Length) return false;

                for (int j = 0; j < a[i].Length; j++)
                {
                    if (!Compare(a[i], b[i])) return false;
                }
            }
            return true;
        }

        public static bool Compare(ushort[][] a, ushort[][] b)
        {
            if (a == null && b == null) return true;
            if (!CompareBase(a, b)) return false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Length != b[i].Length) return false;

                for (int j = 0; j < a[i].Length; j++)
                {
                    if (!Compare(a[i], b[i])) return false;
                }
            }
            return true;
        }

        public static bool Compare(int[][] a, int[][] b)
        {
            if (a == null && b == null) return true;
            if (!CompareBase(a, b)) return false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Length != b[i].Length) return false;

                for (int j = 0; j < a[i].Length; j++)
                {
                    if (!Compare(a[i], b[i])) return false;
                }
            }
            return true;
        }

        public static bool Compare(uint[][] a, uint[][] b)
        {
            if (a == null && b == null) return true;
            if (!CompareBase(a, b)) return false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Length != b[i].Length) return false;

                for (int j = 0; j < a[i].Length; j++)
                {
                    if (!Compare(a[i], b[i])) return false;
                }
            }
            return true;
        }

        public static bool Compare(long[][] a, long[][] b)
        {
            if (a == null && b == null) return true;
            if (!CompareBase(a, b)) return false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Length != b[i].Length) return false;

                for (int j = 0; j < a[i].Length; j++)
                {
                    if (!Compare(a[i], b[i])) return false;
                }
            }
            return true;
        }

        public static bool Compare(ulong[][] a, ulong[][] b)
        {
            if (a == null && b == null) return true;
            if (!CompareBase(a, b)) return false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Length != b[i].Length) return false;

                for (int j = 0; j < a[i].Length; j++)
                {
                    if (!Compare(a[i], b[i])) return false;
                }
            }
            return true;
        }

        public static bool Compare(float[][] a, float[][] b)
        {
            if (a == null && b == null) return true;
            if (!CompareBase(a, b)) return false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Length != b[i].Length) return false;

                for (int j = 0; j < a[i].Length; j++)
                {
                    if (!Compare(a[i], b[i])) return false;
                }
            }
            return true;
        }

        public static bool Compare(double[][] a, double[][] b)
        {
            if (a == null && b == null) return true;
            if (!CompareBase(a, b)) return false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Length != b[i].Length) return false;

                for (int j = 0; j < a[i].Length; j++)
                {
                    if (!Compare(a[i], b[i])) return false;
                }
            }
            return true;
        }

        public static bool Compare(decimal[][] a, decimal[][] b)
        {
            if (a == null && b == null) return true;
            if (!CompareBase(a, b)) return false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Length != b[i].Length) return false;

                for (int j = 0; j < a[i].Length; j++)
                {
                    if (!Compare(a[i], b[i])) return false;
                }
            }
            return true;
        }

        #endregion

        #region Compare Two Dimensional Arrays (Multi-Dimensional)

        public static bool Compare<T>(T[,] a, T[,] b)
        {
            if (a == null && b == null) return true;
            if (!CompareBase<T>(a, b)) return false;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++) { if (!a[i, j].Equals(b[i, j])) return false; }
            }
            return true;
        }

        public static bool Compare(bool[,] a, bool[,] b)
        {
            if (a == null && b == null) return true;
            if (!CompareBase(a, b)) return false;
            fixed (bool* ap = a)
            fixed (bool* bp = b)
            {
                for (int i = 0; i < a.Length; i++) { if (ap[i] != bp[i]) return false; }
            }
            return true;
        }

        public static bool Compare(byte[,] a, byte[,] b)
        {
            if (a == null && b == null) return true;
            if (!CompareBase(a, b)) return false;
            fixed (byte* ap = a)
            fixed (byte* bp = b)
            {
                for (int i = 0; i < a.Length; i++) { if (ap[i] != bp[i]) return false; }
            }
            return true;
        }

        public static bool Compare(sbyte[,] a, sbyte[,] b)
        {
            if (a == null && b == null) return true;
            if (!CompareBase(a, b)) return false;
            fixed (sbyte* ap = a)
            fixed (sbyte* bp = b)
            {
                for (int i = 0; i < a.Length; i++) { if (ap[i] != bp[i]) return false; }
            }
            return true;
        }

        public static bool Compare(short[,] a, short[,] b)
        {
            if (a == null && b == null) return true;
            if (!CompareBase(a, b)) return false;
            fixed (short* ap = a)
            fixed (short* bp = b)
            {
                for (int i = 0; i < a.Length; i++) { if (ap[i] != bp[i]) return false; }
            }
            return true;
        }

        public static bool Compare(ushort[,] a, ushort[,] b)
        {
            if (a == null && b == null) return true;
            if (!CompareBase(a, b)) return false;
            fixed (ushort* ap = a)
            fixed (ushort* bp = b)
            {
                for (int i = 0; i < a.Length; i++) { if (ap[i] != bp[i]) return false; }
            }
            return true;
        }

        public static bool Compare(int[,] a, int[,] b)
        {
            if (a == null && b == null) return true;
            if (!CompareBase(a, b)) return false;
            fixed (int* ap = a)
            fixed (int* bp = b)
            {
                for (int i = 0; i < a.Length; i++) { if (ap[i] != bp[i]) return false; }
            }
            return true;
        }

        public static bool Compare(uint[,] a, uint[,] b)
        {
            if (a == null && b == null) return true;
            if (!CompareBase(a, b)) return false;
            fixed (uint* ap = a)
            fixed (uint* bp = b)
            {
                for (int i = 0; i < a.Length; i++) { if (ap[i] != bp[i]) return false; }
            }
            return true;
        }

        public static bool Compare(long[,] a, long[,] b)
        {
            if (a == null && b == null) return true;
            if (!CompareBase(a, b)) return false;
            fixed (long* ap = a)
            fixed (long* bp = b)
            {
                for (int i = 0; i < a.Length; i++) { if (ap[i] != bp[i]) return false; }
            }
            return true;
        }

        public static bool Compare(ulong[,] a, ulong[,] b)
        {
            if (a == null && b == null) return true;
            if (!CompareBase(a, b)) return false;
            fixed (ulong* ap = a)
            fixed (ulong* bp = b)
            {
                for (int i = 0; i < a.Length; i++) { if (ap[i] != bp[i]) return false; }
            }
            return true;
        }

        public static bool Compare(float[,] a, float[,] b)
        {
            if (a == null && b == null) return true;
            if (!CompareBase(a, b)) return false;
            fixed (float* ap = a)
            fixed (float* bp = b)
            {
                for (int i = 0; i < a.Length; i++) { if (!Compare(ap[i], bp[i])) return false; }
            }
            return true;
        }

        public static bool Compare(double[,] a, double[,] b)
        {
            if (a == null && b == null) return true;
            if (!CompareBase(a, b)) return false;
            fixed (double* ap = a)
            fixed (double* bp = b)
            {
                for (int i = 0; i < a.Length; i++) { if (!Compare(ap[i], bp[i])) return false; }
            }
            return true;
        }

        public static bool Compare(decimal[,] a, decimal[,] b)
        {
            if (a == null && b == null) return true;
            if (!CompareBase(a, b)) return false;
            fixed (decimal* ap = a)
            fixed (decimal* bp = b)
            {
                for (int i = 0; i < a.Length; i++) { if (!Compare(ap[i], bp[i])) return false; }
            }
            return true;
        }

        #endregion

        #region Compare Floating Point Numbers

        /// <summary>
        /// The number of decimals to which a float number will be compared (0-7)
        /// </summary>
        public static int FloatAccuracy
        {
            get { return _FloatAccuracy; }
            set
            {
                if (_FloatAccuracy > 15) _FloatAccuracy = 7;
                else if (_FloatAccuracy < 0) _FloatAccuracy = 0;
                else _FloatAccuracy = value;
            }
        }
        private static int _FloatAccuracy = 4;
        /// <summary>
        /// The number of decimals to which a double number will be compared (0-15)
        /// </summary>
        public static int DoubleAccuracy
        {
            get { return _DoubleAccuracy; }
            set
            {
                if (_DoubleAccuracy > 15) _DoubleAccuracy = 15;
                else if (_DoubleAccuracy < 0) _DoubleAccuracy = 0;
                else _DoubleAccuracy = value;
            }
        }
        private static int _DoubleAccuracy = 6;
        /// <summary>
        /// The number of decimals to which a decimal number will be compared (0-28)
        /// </summary>
        public static int DecimalAccuracy
        {
            get { return _DecimalAccuracy; }
            set
            {
                if (_DecimalAccuracy > 28) _DecimalAccuracy = 28;
                else if (_DecimalAccuracy < 0) _DecimalAccuracy = 0;
                else _DecimalAccuracy = value;
            }
        }
        private static int _DecimalAccuracy = 12;

        public static bool Compare(float a, float b)
        {
            return Math.Round(a, _FloatAccuracy) == Math.Round(b, _FloatAccuracy);
        }

        public static bool Compare(double a, double b)
        {
            return Math.Round(a, _DoubleAccuracy) == Math.Round(b, _DoubleAccuracy);
        }

        public static bool Compare(decimal a, decimal b)
        {
            return Math.Round(a, _DecimalAccuracy) == Math.Round(b, _DecimalAccuracy);
        }

        #endregion

        #region GetHashCode One Dimensional Arrays

        public static int GetHashCode<T>(IList<T> a)
        {
            if (a == null) return 0;
            unchecked
            {
                int hash = (int)2166136261;
                foreach (var ai in a) { if (ai != null) hash *= 16777619 ^ ai.GetHashCode(); }
                return hash;
            }
        }

        public static int GetHashCode(bool[] a)
        {
            if (a == null) return 0;
            unchecked
            {
                int hash = (int)2166136261;
                fixed (bool* ap = a)
                {
                    for (int i = 0; i < a.Length; i++) hash *= 16777619 ^ ap[i].GetHashCode();
                }
                return hash;
            }
        }

        public static int GetHashCode(byte[] a)
        {
            if (a == null) return 0;
            unchecked
            {
                int hash = (int)2166136261;
                fixed (byte* ap = a)
                {
                    for (int i = 0; i < a.Length; i++) hash *= 16777619 ^ ap[i].GetHashCode();
                }
                return hash;
            }
        }

        public static int GetHashCode(sbyte[] a)
        {
            if (a == null) return 0;
            unchecked
            {
                int hash = (int)2166136261;
                fixed (sbyte* ap = a)
                {
                    for (int i = 0; i < a.Length; i++) hash *= 16777619 ^ ap[i].GetHashCode();
                }
                return hash;
            }
        }

        public static int GetHashCode(short[] a)
        {
            if (a == null) return 0;
            unchecked
            {
                int hash = (int)2166136261;
                fixed (short* ap = a)
                {
                    for (int i = 0; i < a.Length; i++) hash *= 16777619 ^ ap[i].GetHashCode();
                }
                return hash;
            }
        }

        public static int GetHashCode(ushort[] a)
        {
            if (a == null) return 0;
            unchecked
            {
                int hash = (int)2166136261;
                fixed (ushort* ap = a)
                {
                    for (int i = 0; i < a.Length; i++) hash *= 16777619 ^ ap[i].GetHashCode();
                }
                return hash;
            }
        }

        public static int GetHashCode(int[] a)
        {
            if (a == null) return 0;
            unchecked
            {
                int hash = (int)2166136261;
                fixed (int* ap = a)
                {
                    for (int i = 0; i < a.Length; i++) hash *= 16777619 ^ ap[i].GetHashCode();
                }
                return hash;
            }
        }

        public static int GetHashCode(uint[] a)
        {
            if (a == null) return 0;
            unchecked
            {
                int hash = (int)2166136261;
                fixed (uint* ap = a)
                {
                    for (int i = 0; i < a.Length; i++) hash *= 16777619 ^ ap[i].GetHashCode();
                }
                return hash;
            }
        }

        public static int GetHashCode(long[] a)
        {
            if (a == null) return 0;
            unchecked
            {
                int hash = (int)2166136261;
                fixed (long* ap = a)
                {
                    for (int i = 0; i < a.Length; i++) hash *= 16777619 ^ ap[i].GetHashCode();
                }
                return hash;
            }
        }

        public static int GetHashCode(ulong[] a)
        {
            if (a == null) return 0;
            unchecked
            {
                int hash = (int)2166136261;
                fixed (ulong* ap = a)
                {
                    for (int i = 0; i < a.Length; i++) hash *= 16777619 ^ ap[i].GetHashCode();
                }
                return hash;
            }
        }

        public static int GetHashCode(float[] a)
        {
            if (a == null) return 0;
            unchecked
            {
                int hash = (int)2166136261;
                fixed (float* ap = a)
                {
                    for (int i = 0; i < a.Length; i++) hash *= 16777619 ^ ap[i].GetHashCode();
                }
                return hash;
            }
        }

        public static int GetHashCode(double[] a)
        {
            if (a == null) return 0;
            unchecked
            {
                int hash = (int)2166136261;
                fixed (double* ap = a)
                {
                    for (int i = 0; i < a.Length; i++) hash *= 16777619 ^ ap[i].GetHashCode();
                }
                return hash;
            }
        }

        public static int GetHashCode(decimal[] a)
        {
            if (a == null) return 0;
            unchecked
            {
                int hash = (int)2166136261;
                fixed (decimal* ap = a)
                {
                    for (int i = 0; i < a.Length; i++) hash *= 16777619 ^ ap[i].GetHashCode();
                }
                return hash;
            }
        }

        #endregion

        #region GetHashCode Two Dimensional Arrays (Jagged)

        public static int GetHashCode<T>(T[][] a)
        {
            if (a == null) return 0;
            unchecked
            {
                int hash = (int)2166136261;
                foreach (var ai in a)
                {
                    foreach (var aij in ai) { if (aij != null) hash *= 16777619 ^ aij.GetHashCode(); }
                }
                return hash;
            }
        }

        public static int GetHashCode(bool[][] a)
        {
            if (a == null) return 0;
            unchecked
            {
                int hash = (int)2166136261;
                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = 0; j < a[i].Length; j++) hash *= 16777619 ^ a[i].GetHashCode();
                }
                return hash;
            }
        }

        public static int GetHashCode(byte[][] a)
        {
            if (a == null) return 0;
            unchecked
            {
                int hash = (int)2166136261;
                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = 0; j < a[i].Length; j++) hash *= 16777619 ^ a[i].GetHashCode();
                }
                return hash;
            }
        }

        public static int GetHashCode(sbyte[][] a)
        {
            if (a == null) return 0;
            unchecked
            {
                int hash = (int)2166136261;
                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = 0; j < a[i].Length; j++) hash *= 16777619 ^ a[i].GetHashCode();
                }
                return hash;
            }
        }

        public static int GetHashCode(short[][] a)
        {
            if (a == null) return 0;
            unchecked
            {
                int hash = (int)2166136261;
                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = 0; j < a[i].Length; j++) hash *= 16777619 ^ a[i].GetHashCode();
                }
                return hash;
            }
        }

        public static int GetHashCode(ushort[][] a)
        {
            if (a == null) return 0;
            unchecked
            {
                int hash = (int)2166136261;
                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = 0; j < a[i].Length; j++) hash *= 16777619 ^ a[i].GetHashCode();
                }
                return hash;
            }
        }

        public static int GetHashCode(int[][] a)
        {
            if (a == null) return 0;
            unchecked
            {
                int hash = (int)2166136261;
                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = 0; j < a[i].Length; j++) hash *= 16777619 ^ a[i].GetHashCode();
                }
                return hash;
            }
        }

        public static int GetHashCode(uint[][] a)
        {
            if (a == null) return 0;
            unchecked
            {
                int hash = (int)2166136261;
                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = 0; j < a[i].Length; j++) hash *= 16777619 ^ a[i].GetHashCode();
                }
                return hash;
            }
        }

        public static int GetHashCode(long[][] a)
        {
            if (a == null) return 0;
            unchecked
            {
                int hash = (int)2166136261;
                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = 0; j < a[i].Length; j++) hash *= 16777619 ^ a[i].GetHashCode();
                }
                return hash;
            }
        }

        public static int GetHashCode(ulong[][] a)
        {
            if (a == null) return 0;
            unchecked
            {
                int hash = (int)2166136261;
                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = 0; j < a[i].Length; j++) hash *= 16777619 ^ a[i].GetHashCode();
                }
                return hash;
            }
        }

        public static int GetHashCode(float[][] a)
        {
            if (a == null) return 0;
            unchecked
            {
                int hash = (int)2166136261;
                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = 0; j < a[i].Length; j++) hash *= 16777619 ^ a[i].GetHashCode();
                }
                return hash;
            }
        }

        public static int GetHashCode(double[][] a)
        {
            if (a == null) return 0;
            unchecked
            {
                int hash = (int)2166136261;
                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = 0; j < a[i].Length; j++) hash *= 16777619 ^ a[i].GetHashCode();
                }
                return hash;
            }
        }

        public static int GetHashCode(decimal[][] a)
        {
            if (a == null) return 0;
            unchecked
            {
                int hash = (int)2166136261;
                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = 0; j < a[i].Length; j++) hash *= 16777619 ^ a[i].GetHashCode();
                }
                return hash;
            }
        }

        #endregion

        #region GetHashCode Two Dimensional Arrays (Multi-Dimensional)

        public static int GetHashCode<T>(T[,] a)
        {
            if (a == null) return 0;
            unchecked
            {
                int hash = (int)2166136261;
                foreach (var ai in a) { if (ai != null) hash *= 16777619 ^ ai.GetHashCode(); }
                return hash;
            }
        }

        public static int GetHashCode(bool[,] a)
        {
            if (a == null) return 0;
            unchecked
            {
                int hash = (int)2166136261;
                fixed (bool* ap = a)
                {
                    for (int i = 0; i < a.Length; i++) hash *= 16777619 ^ ap[i].GetHashCode();
                }
                return hash;
            }
        }

        public static int GetHashCode(byte[,] a)
        {
            if (a == null) return 0;
            unchecked
            {
                int hash = (int)2166136261;
                fixed (byte* ap = a)
                {
                    for (int i = 0; i < a.Length; i++) hash *= 16777619 ^ ap[i].GetHashCode();
                }
                return hash;
            }
        }

        public static int GetHashCode(sbyte[,] a)
        {
            if (a == null) return 0;
            unchecked
            {
                int hash = (int)2166136261;
                fixed (sbyte* ap = a)
                {
                    for (int i = 0; i < a.Length; i++) hash *= 16777619 ^ ap[i].GetHashCode();
                }
                return hash;
            }
        }

        public static int GetHashCode(short[,] a)
        {
            if (a == null) return 0;
            unchecked
            {
                int hash = (int)2166136261;
                fixed (short* ap = a)
                {
                    for (int i = 0; i < a.Length; i++) hash *= 16777619 ^ ap[i].GetHashCode();
                }
                return hash;
            }
        }

        public static int GetHashCode(ushort[,] a)
        {
            if (a == null) return 0;
            unchecked
            {
                int hash = (int)2166136261;
                fixed (ushort* ap = a)
                {
                    for (int i = 0; i < a.Length; i++) hash *= 16777619 ^ ap[i].GetHashCode();
                }
                return hash;
            }
        }

        public static int GetHashCode(int[,] a)
        {
            if (a == null) return 0;
            unchecked
            {
                int hash = (int)2166136261;
                fixed (int* ap = a)
                {
                    for (int i = 0; i < a.Length; i++) hash *= 16777619 ^ ap[i].GetHashCode();
                }
                return hash;
            }
        }

        public static int GetHashCode(uint[,] a)
        {
            if (a == null) return 0;
            unchecked
            {
                int hash = (int)2166136261;
                fixed (uint* ap = a)
                {
                    for (int i = 0; i < a.Length; i++) hash *= 16777619 ^ ap[i].GetHashCode();
                }
                return hash;
            }
        }

        public static int GetHashCode(long[,] a)
        {
            if (a == null) return 0;
            unchecked
            {
                int hash = (int)2166136261;
                fixed (long* ap = a)
                {
                    for (int i = 0; i < a.Length; i++) hash *= 16777619 ^ ap[i].GetHashCode();
                }
                return hash;
            }
        }

        public static int GetHashCode(ulong[,] a)
        {
            if (a == null) return 0;
            unchecked
            {
                int hash = (int)2166136261;
                fixed (ulong* ap = a)
                {
                    for (int i = 0; i < a.Length; i++) hash *= 16777619 ^ ap[i].GetHashCode();
                }
                return hash;
            }
        }

        public static int GetHashCode(float[,] a)
        {
            if (a == null) return 0;
            unchecked
            {
                int hash = (int)2166136261;
                fixed (float* ap = a)
                {
                    for (int i = 0; i < a.Length; i++) hash *= 16777619 ^ ap[i].GetHashCode();
                }
                return hash;
            }
        }

        public static int GetHashCode(double[,] a)
        {
            if (a == null) return 0;
            unchecked
            {
                int hash = (int)2166136261;
                fixed (double* ap = a)
                {
                    for (int i = 0; i < a.Length; i++) hash *= 16777619 ^ ap[i].GetHashCode();
                }
                return hash;
            }
        }

        public static int GetHashCode(decimal[,] a)
        {
            if (a == null) return 0;
            unchecked
            {
                int hash = (int)2166136261;
                fixed (decimal* ap = a)
                {
                    for (int i = 0; i < a.Length; i++) hash *= 16777619 ^ ap[i].GetHashCode();
                }
                return hash;
            }
        }

        #endregion

        #region Subroutines

        private static bool CompareBase<T>(IList<T> a, IList<T> b)
        {
            if (a == null || b == null) return false;
            if (ReferenceEquals(a, b)) return true;
            if (a.Count != b.Count) return false;

            return true;
        }

        private static bool CompareBase<T>(T[][] a, T[][] b)
        {
            if (a == null || b == null) return false;
            if (ReferenceEquals(a, b)) return true;
            if (a.Length != b.Length) return false;

            return true;
        }

        private static bool CompareBase<T>(T[,] a, T[,] b)
        {
            if (a == null || b == null) return false;
            if (ReferenceEquals(a, b)) return true;
            if (a.GetLength(0) != b.GetLength(0) || a.GetLength(1) != b.GetLength(1)) return false;

            return true;
        }

        #endregion
    }
}
