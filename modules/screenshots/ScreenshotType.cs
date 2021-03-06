﻿//-----------------------------------------------------------------------
// <copyright file="ScreenshotType.cs" company="Gavin Kendall">
//     Copyright (c) 2020 Gavin Kendall
// </copyright>
// <author>Gavin Kendall</author>
// <summary>The type of screenshot can either represent the active window, a region, or a screen.</summary>
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program. If not, see <https://www.gnu.org/licenses/>.
//-----------------------------------------------------------------------
namespace AutoScreenCapture
{
    /// <summary>
    /// A class representing a type of screenshot.
    /// </summary>
    public enum ScreenshotType
    {
        /// <summary>
        /// The type of screenshot represents the active window.
        /// </summary>
        ActiveWindow = 0,

        /// <summary>
        /// The type of screenshot represents a region.
        /// </summary>
        Region = 1,

        /// <summary>
        /// The type of screenshot represents a screen.
        /// </summary>
        Screen = 2
    }
}
