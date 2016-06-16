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

        public static T Dump<T>(this T o) => o.Dump(description: null);
        public static T Dump<T>(this T o, string description) => o.Dump(description, depth: null);
        public static T Dump<T>(this T o, int depth) => o.Dump(null, depth);
        public static T Dump<T>(this T o, bool toDataGrid) => o.Dump(null, toDataGrid);
        public static T Dump<T>(this T o, string description, int? depth) => Faker.Dump(o, description, depth, toDataGrid: false);
        public static T Dump<T>(this T o, string description, bool toDataGrid) => Faker.Dump(o, description, null, toDataGrid);
    }
}
