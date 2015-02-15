﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ViolationLevel.cs" company="RHS">
//   Red Hammer Studios
// </copyright>
// <summary>
//   The <see cref="AboutViewModel" /> provides a the view model for the About dialog
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace StringForge.ViewModel
{
    using System.Reflection;

    /// <summary>
    /// The about window view model
    /// </summary>
    internal class AboutViewModel
    {
        /// <summary>
        /// Gets the title.
        /// </summary>
        public string Title
        {
            get { return "StringForge"; }
        }

        /// <summary>
        /// Gets the version.
        /// </summary>
        public string Version
        {
            get { return Assembly.GetEntryAssembly().GetName().Version.ToString(); }
        }

        /// <summary>
        /// Gets the copyright.
        /// </summary>
        public string Copyright
        {
            get { return "By Alex \"Soul_Assassin\" Vorobiev. Distributed under the MIT license."; }
        }
    }
}