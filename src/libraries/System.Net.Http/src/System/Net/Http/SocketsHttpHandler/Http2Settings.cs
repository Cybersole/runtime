// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable CS3009 // Base type is not CLS-compliant
#pragma warning disable CS3003 // Base type is not CLS-compliant

namespace System.Net.Http
{
    public struct Http2Settings
    {
        public enum Headers { Method, Authority, Scheme, Path }

        public enum SettingId : ushort
        {
            HeaderTableSize = 0x1,
            EnablePush = 0x2,
            MaxConcurrentStreams = 0x3,
            InitialWindowSize = 0x4,
            MaxFrameSize = 0x5,
            MaxHeaderListSize = 0x6,
            EnableConnect = 0x8
        }

        public Headers[] HeaderOrder { get; set; }

        public uint WindowSize { get; set; }

        public Dictionary<SettingId, uint> Settings { get; set; }

        public Http2Settings()
        {
            HeaderOrder = [Headers.Method, Headers.Authority, Headers.Scheme, Headers.Path];

            Settings = new()
            {
                [SettingId.HeaderTableSize] = 65536,
                [SettingId.EnablePush] = 0,
                [SettingId.InitialWindowSize] = 6291456,
                [SettingId.MaxHeaderListSize] = 262144
            };

            WindowSize = 15663105;
        }
    }
}
