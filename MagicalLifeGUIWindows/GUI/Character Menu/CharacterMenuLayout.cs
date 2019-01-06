﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalLifeGUIWindows.GUI.Character_Menu
{
    /// <summary>
    /// Layout for the character menu.
    /// </summary>
    public static class CharacterMenuLayout
    {
        public static Rectangle GetMenuBounds()
        {
            return new Rectangle(0, 0, 600, 600);
        }

        /// <summary>
        /// The bounds of the name label.
        /// </summary>
        /// <returns></returns>
        public static Rectangle GetNameBounds()
        {
            return new Rectangle(20, 40, 200, 50);
        }
    }
}
