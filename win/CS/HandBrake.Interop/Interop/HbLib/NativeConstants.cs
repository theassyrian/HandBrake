﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NativeConstants.cs" company="HandBrake Project (http://handbrake.fr)">
//   This file is part of the HandBrake source code - It may be used under the terms of the GNU General Public License.
// </copyright>
// <summary>
//   Defines the NativeConstants type.
// </summary>
// <auto-generated> Disable Stylecop Warnings for this file  </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace HandBrake.Interop.Interop.HbLib
{
    public class NativeConstants
    {
        // Audio encoders
        public const uint HB_ACODEC_AC3 = 0x00000800;
        public const uint HB_ACODEC_DCA = 0x00002000;
        public const uint HB_ACODEC_FFAAC = 0x00010000;
        public const uint HB_ACODEC_DCA_HD = 0x00040000;
        public const uint HB_ACODEC_MP3 = 0x00080000;
        public const uint HB_ACODEC_FFFLAC = 0x00100000;
        public const uint HB_ACODEC_FFEAC3 = 0x01000000;
        public const uint HB_ACODEC_FFTRUEHD = 0x02000000;
        public const uint HB_ACODEC_PASS_FLAG = 0x40000000;
        public const uint HB_ACODEC_PASS_MASK = (HB_ACODEC_AC3 | HB_ACODEC_DCA | HB_ACODEC_DCA_HD | HB_ACODEC_FFAAC | HB_ACODEC_FFEAC3 | HB_ACODEC_FFFLAC | HB_ACODEC_MP3 | HB_ACODEC_FFTRUEHD);

        // VideoEncoders
        public const uint HB_VCODEC_QSV_H264 = 0x0000100;
        public const uint HB_VCODEC_QSV_H265 = 0x0000200;
        public const uint HB_VCODEC_QSV_H265_10BIT = 0x0000400;
	}
}