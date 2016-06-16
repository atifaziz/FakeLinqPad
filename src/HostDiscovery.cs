#region Copyright (c) 2016 Atif Aziz. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#endregion

namespace FakeLinqPad
{
    using System;
    using System.IO;

    public static class HostDiscovery
    {
        static bool? _isHostLinqPad;

        public static bool IsHostLinqPad =>
            _isHostLinqPad ?? (_isHostLinqPad = InLinqPadCore()) == true;

        static bool InLinqPadCore()
        {
            var binName = Path.GetFileNameWithoutExtension(Environment.GetCommandLineArgs()[0]);
            return "lprun".Equals(binName, StringComparison.OrdinalIgnoreCase)
                   || "LINQPad.UserQuery".Equals(binName, StringComparison.OrdinalIgnoreCase)
                   || AppDomain.CurrentDomain.FriendlyName.IndexOf("LINQPad", StringComparison.OrdinalIgnoreCase) >= 0;
        }
    }
}