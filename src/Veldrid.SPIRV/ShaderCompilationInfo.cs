﻿using System.Runtime.InteropServices;

namespace Veldrid.SPIRV
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal unsafe struct ShaderCompilationInfo
    {
        public Bool32 HasValue;
        public uint Length;
        public uint* ShaderCode; // SPIR-V bytecode
    }
}
