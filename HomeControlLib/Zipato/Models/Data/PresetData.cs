﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PresetData.cs" company="DTV-Online">
//   Copyright(c) 2019 Dr. Peter Trimmel. All rights reserved.
// </copyright>
// <license>
// Licensed under the MIT license. See the LICENSE file in the project root for more information.
// </license>
// --------------------------------------------------------------------------------------------------------------------
namespace HomeControlLib.Zipato.Models.Data
{
    #region Using Directives

    using HomeControlLib.Zipato.Models.Data.Preset;

    #endregion

    public class PresetData
    {
        public string Name { get; set; }
        public PresetMap Map { get; set; }
    }
}
