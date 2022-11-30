﻿using SandBox.Database.Entities.Base;

namespace SandBox.Database.Entities
{
    public class AppSetting : BaseEntity<int>
    {
        /// <summary>
        /// Gets or sets the ReferenceKey
        /// </summary>
        public string ReferenceKey { get; set; } = String.Empty;
        /// <summary>
        /// Gets or sets the Value
        /// </summary>
        public string Value { get; set; } = String.Empty;
        /// <summary>
        /// Gets or sets the Description
        /// </summary>
        public string Description { get; set; } = String.Empty;
        /// <summary>
        /// Gets or sets the Type
        /// </summary>
        public string Type { get; set; } = String.Empty;
    }
}
