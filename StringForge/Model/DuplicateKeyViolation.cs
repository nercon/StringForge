﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DuplicateKeyViolation.cs" company="RHS">
//   Copyright (c) 2015 Alex Vorobiev
// </copyright>
// <summary>
//   The  provides a violation of duplicate key ids
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace StringForge.Model
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using RHSStringTableTools.Model;

    /// <summary>
    /// The <see cref="DuplicateKeyViolation" /> provides a violation of duplicate key ids
    /// </summary>
    internal class DuplicateKeyViolation : IViolation
    {
        /// <summary>
        /// Gets the level.
        /// </summary>
        public ViolationLevel Level
        {
            get { return ViolationLevel.Error; }
        }

        /// <summary>
        /// Gets the message.
        /// </summary>
        public string Message
        {
            get { return this.CompileMessage(); }
        }

        /// <summary>
        /// Compiles the message.
        /// </summary>
        /// <returns>The violation message</returns>
        private string CompileMessage()
        {
            return string.Format("Duplicate Key ID: {0}", this.Keys[0].Id);
        }

        /// <summary>
        /// Gets or sets the keys.
        /// </summary>
        public ObservableCollection<Key> Keys { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DuplicateKeyViolation"/> class.
        /// </summary>
        /// <param name="keys">The keys.</param>
        public DuplicateKeyViolation(List<Key> keys)
        {
            this.Keys = new ObservableCollection<Key>(keys);
        }
    }
}