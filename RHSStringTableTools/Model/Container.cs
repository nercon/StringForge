﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Container.cs" company="RHS">
//   Copyright (c) 2015 Alex Vorobiev
// </copyright>
// <summary>
//   The  class specifying the container
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RHSStringTableTools.Model
{
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;
    using ReactiveUI;

    /// <summary>
    /// The container class. Used for grouping.
    /// </summary>
    public class Container : ReactiveObject
    {
        /// <summary>
        /// Backing field for <see cref="Name"/>
        /// </summary>
        private string name;

        /// <summary>
        /// Initializes a new instance of the <see cref="Container"/> class.
        /// </summary>
        public Container()
        {
            this.Keys = new ObservableCollection<Key>();
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [XmlAttribute("name")]
        public string Name
        {
            get { return this.name; }
            set { this.RaiseAndSetIfChanged(ref this.name, value); }
        }

        /// <summary>
        /// Gets or sets the keys.
        /// </summary>
        [XmlElement("Key")]
        public ObservableCollection<Key> Keys { get; set; }

        /// <summary>
        /// Gets or sets the parent
        /// </summary>
        [XmlIgnore]
        public Package Parent { get; set; }
    }
}