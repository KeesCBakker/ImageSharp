// Copyright (c) Six Labors.
// Licensed under the Apache License, Version 2.0.

namespace SixLabors.ImageSharp.Formats.Tiff
{
    /// <summary>
    /// Enumeration representing how the components of each pixel are stored the Tiff file-format.
    /// </summary>
    internal enum TiffPlanarConfiguration
    {
        /// <summary>
        /// Chunky format.
        /// </summary>
        Chunky = 1,

        /// <summary>
        /// Planar format.
        /// </summary>
        Planar = 2
    }
}