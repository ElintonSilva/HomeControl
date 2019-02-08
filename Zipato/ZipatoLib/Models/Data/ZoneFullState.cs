﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ZoneFullState.cs" company="DTV-Online">
//   Copyright(c) 2019 Dr. Peter Trimmel. All rights reserved.
// </copyright>
// <license>
// Licensed under the MIT license. See the LICENSE file in the project root for more information.
// </license>
// --------------------------------------------------------------------------------------------------------------------
namespace ZipatoLib.Models.Data
{
    #region Using Directives

    using System;

    #endregion

    public class ZoneFullState : ZoneState
    {
        public Guid? Uuid { get; set; }
        public DateTime? Timestamp { get; set; }
    }
}