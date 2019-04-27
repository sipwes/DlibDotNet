﻿using System;
using System.Runtime.InteropServices;

// ReSharper disable once CheckNamespace
namespace DlibDotNet
{

    internal sealed partial class NativeMethods
    {

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern IntPtr linear_kernel_new(MatrixElementType matrixElementType, int templateRow, int templateColumn);

        [DllImport(NativeLibrary, CallingConvention = CallingConvention)]
        public static extern void linear_kernel_delete(MatrixElementType matrixElementType, IntPtr linerKernel, int templateRow, int templateColumn);

    }

}