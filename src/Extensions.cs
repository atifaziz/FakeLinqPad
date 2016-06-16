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
    using Fakers;

    public interface IExtensions
    {
        T Dump<T>(T o, string description, int? depth, bool toDataGrid);
    }

    public static class Extensions
    {
        public static IExtensions Faker { get; set; } = Fakes.Extensions;

        public static T Dump<T>(this T o) =>
            o.Dump(description: null);

        public static T Dump<T>(this T o, string description) =>
            o.Dump(description, depth: null);

        public static T Dump<T>(this T o, int depth) =>
            o.Dump(null, depth);

        public static T Dump<T>(this T o, bool toDataGrid) =>
            o.Dump(null, toDataGrid);

        public static T Dump<T>(this T o, string description, int? depth) =>
            Faker.Dump(o, description, depth, toDataGrid: false);

        public static T Dump<T>(this T o, string description, bool toDataGrid) =>
            Faker.Dump(o, description, null, toDataGrid);

        // Possibly to support one fine day if it makes sense...

        // public static T DumpTrace<T>(this T o) { ... }
        // public static T DumpTrace<T>(this T o, string description) { ... }
        // public static T DumpTrace<T>(this T o, int depth) { ... }
        // public static T DumpTrace<T>(this T o, string description, int? depth) { ... }
        // public static T DumpTrace<T>(this T o, string description, bool toDataGrid) { ... }
        // public static DumpContainer OnDemand<T>(this IEnumerable<T> sequence) { ... }
        // public static DumpContainer OnDemand(this IEnumerable sequence, string description) { ... }
        // public static string Disassemble(this MethodBase method) { ... }
        // public static object ToImage(this Binary imageData) { ... }
        // public static IObservable<T> DumpLive<T>(this IObservable<T> obs) { ... }
        // public static IObservable<T> DumpLive<T>(this IObservable<T> obs, string heading) { ... }
        // public static XElement DumpFormatted(this XElement xml) { ... }
        // public static XElement DumpFormatted(this XElement xml, string heading) { ... }
        // public static XDocument DumpFormatted(this XDocument xml) { ... }
        // public static XDocument DumpFormatted(this XDocument xml, string heading) { ... }
        // public static XmlDocument DumpFormatted(this XmlDocument xml) { ... }
        // public static XmlDocument DumpFormatted(this XmlDocument xml, string heading) { ... }
        // public static XmlElement DumpFormatted(this XmlElement xml) { ... }
        // public static XmlElement DumpFormatted(this XmlElement xml, string heading) { ... }
        // public static T[] Cache<T>(this IEnumerable<T> query) { ... }
        // public static T[] Cache<T>(this IEnumerable<T> query, string key) { ... }
    }
}
