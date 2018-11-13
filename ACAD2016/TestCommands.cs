using System.Reflection;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.ApplicationServices.Core;
using System.Collections.Generic;
using System;
using Autodesk.AutoCAD.Geometry;
using System.Drawing;

[assembly: CommandClass(typeof(ACADPlugin.TestCmd))]

namespace ACADPlugin
{
    public class TestCmd
    {
        [CommandMethod("Test", CommandFlags.Modal | CommandFlags.NoBlockEditor | CommandFlags.NoPaperSpace)]
        public void TEST()
        {
        }
    }
}

