﻿using Planetbase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhiScript.Event
{
    public class EventGui : EventArgs
    {
        public enum GuiType
        {
            BaseManagement = 1,
            Build = 2,
            BuildInterior = 3,
            BuildExterior = 4
        }

        public GuiMenu GuiMenu
        {
            get;
        }

        public GuiType Type
        {
            get;
        }

        public EventGui(GuiMenu guiMenu, GuiType guiType)
        {
            this.GuiMenu = guiMenu;
            this.Type = guiType;
        }
    }
}
