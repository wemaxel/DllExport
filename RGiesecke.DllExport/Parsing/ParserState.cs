﻿// [Decompiled] Assembly: RGiesecke.DllExport, Version=1.2.3.29766, Culture=neutral, PublicKeyToken=ad5f9f4a55b5020b
// Author of original assembly (MIT-License): Robert Giesecke
// Use Readme & LICENSE files for details.

namespace RGiesecke.DllExport.Parsing
{
    public enum ParserState
    {
        Normal,
        ClassDeclaration,
        Class,
        DeleteExportDependency,
        MethodDeclaration,
        MethodProperties,
        Method,
        DeleteExportAttribute,
    }
}
