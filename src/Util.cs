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
    using System.Net;
    using Fakers;

    public interface IUtil
    {
        IWebProxy GetWebProxy();
    }

    public static class Util
    {
        public static IUtil Faker { get; set; } = Fakes.Util;

        public static IWebProxy GetWebProxy() => Faker.GetWebProxy();

        // Possibly to support one fine day if it makes sense...

        // public static TextWriter CreateXhtmlWriter() { ... }
        // public static TextWriter CreateXhtmlWriter(bool enableExpansions) { ... }
        // public static TextWriter CreateXhtmlWriter(bool enableExpansions, bool noHeader) { ... }
        // public static TextWriter CreateXhtmlWriter(bool enableExpansions, int maxDepth) { ... }
        // public static TextWriter CreateXhtmlWriter(bool enableExpansions, int maxDepth, bool noHeader) { ... }
        // public static TextWriter CreateXhtmlWriter(int maxDepth) { ... }
        // public static AppDomain CreateAppDomain(string friendlyName) { ... }
        // public static AppDomain CreateAppDomain(string friendlyName, Evidence securityInfo) { ... }
        // public static AppDomain CreateAppDomain(string friendlyName, Evidence securityInfo, AppDomainSetup setup) { ... }
        // public static string GetSamplesFolder() { ... }
        // public static string GetSamplesFolder(string sampleLibraryName) { ... }
        // public static string GetSampleFilePath(string sampleLibraryName, string fileName) { ... }
        // public static string GetFullPath(string nameOfReferencedFile) { ... }
        // public static string ReadSampleTextFile(string sampleLibraryName, string fileName) { ... }
        // public static string[] Cmd(string commandText) { ... }
        // public static string[] Cmd(string commandText, bool quiet) { ... }
        // public static string[] Cmd(string commandText, string args) { ... }
        // public static string[] Cmd(string commandText, string args, bool quiet) { ... }
        // public static QueryExecuter Run(string queryFilePath, QueryResultFormat format, params string[] args) { ... }
        // public static IEnumerable<Query> GetSamples() { ... }
        // public static IEnumerable<Query> GetMyQueries() { ... }
        // public static object Metatext(string text) { ... }
        // public static object Highlight(object data) { ... }
        // public static object HighlightIf<T>(T data, Func<T, bool> predicate) { ... }
        // public static object WordRun(bool withGaps, params object[] elements) { ... }
        // public static object WordRun(bool withGaps, IEnumerable elements) { ... }
        // public static object HorizontalRun(bool withGaps, params object[] elements) { ... }
        // public static object HorizontalRun(bool withGaps, IEnumerable elements) { ... }
        // public static object HorizontalRun(string commaDelimitedHeadings, params object[] elements) { ... }
        // public static object HorizontalRun(string commaDelimitedHeadings, IEnumerable elements) { ... }
        // public static object VerticalRun(params object[] elements) { ... }
        // public static object VerticalRun(IEnumerable elements) { ... }
        // public static object Image(byte[] imageData) { ... }
        // public static object Image(Binary imageData) { ... }
        // public static object Image(string pathOrUri) { ... }
        // public static object Image(Uri uri) { ... }
        // public static object RawHtml(XElement xhtmlNode) { ... }
        // public static object RawHtml(string xhtml) { ... }
        // public static void ClearResults() { ... }
        // public static string ReadLine() { ... }
        // public static string ReadLine(string prompt) { ... }
        // public static string ReadLine(string prompt, string defaultValue) { ... }
        // public static string ReadLine(string prompt, string defaultValue, IEnumerable<string> suggestions) { ... }
        // public static TResult ReadLine<TResult>() { ... }
        // public static TResult ReadLine<TResult>(string prompt) { ... }
        // public static TResult ReadLine<TResult>(string prompt, TResult defaultValue) { ... }
        // public static TResult ReadLine<TResult>(string prompt, TResult defaultValue, IEnumerable<TResult> suggestions) { ... }
        // public static void CreateSynchronizationContext() { ... }
        // public static void CreateSynchronizationContext(bool detectDeadlocks) { ... }
        // public static void CreateSynchronizationContext(bool detectDeadlocks, bool reportActivity) { ... }
        // public static string GetPassword(string name) { ... }
        // public static string GetPassword(string name, bool noDefaultSave) { ... }
        // public static void SetPassword(string name, string password) { ... }
        // public static IDisposable GetQueryLifeExtensionToken() { ... }
        // public static T Cache<T>(Func<T> dataFetcher) { ... }
        // public static T Cache<T>(Func<T> dataFetcher, string key) { ... }
        // public static void DisplayWebPage(Uri uri) { ... }
        // public static void DisplayWebPage(Uri uri, string title) { ... }
        // public static void DisplayWebPage(string uriOrPath) { ... }
        // public static void DisplayWebPage(string uriOrPath, string title) { ... }
        // public static string ToHtmlString(params object[] objectsToDump) { ... }
        // public static string ToHtmlString(bool enableExpansions, params object[] objectsToDump) { ... }
        // public static string ToHtmlString(bool enableExpansions, bool noHeader, params object[] objectsToDump) { ... }
        // public static string ToHtmlString(int maxDepth, params object[] objectsToDump) { ... }
        // public static string ToHtmlString(bool enableExpansions, int maxDepth, params object[] objectsToDump) { ... }
        // public static string ToHtmlString(bool enableExpansions, int maxDepth, bool noHeader, params object[] objectsToDump) { ... }
        // public static string ToCsvString<T>(IEnumerable<T> elements) { ... }
        // public static string ToCsvString<T>(IEnumerable<T> elements, params string[] membersToInclude) { ... }
        // public static string ToCsvString<T>(IEnumerable<T> elements, bool useInvariantCulture, params string[] membersToInclude) { ... }
        // public static string ToCsvString(DataTable rows) { ... }
        // public static string ToCsvString(DataTable rows, params string[] membersToInclude) { ... }
        // public static string ToCsvString(DataTable rows, bool useInvariantCulture, params string[] membersToInclude) { ... }
        // public static void WriteCsv<T>(IEnumerable<T> elements, string filePath) { ... }
        // public static void WriteCsv<T>(IEnumerable<T> elements, string filePath, params string[] membersToInclude) { ... }
        // public static void WriteCsv<T>(IEnumerable<T> elements, string filePath, bool useInvariantCulture, params string[] membersToInclude) { ... }
        // public static void WriteCsv<T>(IEnumerable<T> elements, TextWriter writer, params string[] membersToInclude) { ... }
        // public static void WriteCsv<T>(IEnumerable<T> elements, TextWriter writer, bool useInvariantCulture, params string[] membersToInclude) { ... }
        // public static void WriteCsv(DataTable rows, string filePath) { ... }
        // public static void WriteCsv(DataTable rows, string filePath, params string[] rowsToInclude) { ... }
        // public static void WriteCsv(DataTable rows, string filePath, bool useInvariantCulture, params string[] rowsToInclude) { ... }
        // public static void WriteCsv(DataTable rows, TextWriter writer, params string[] rowsToInclude) { ... }
        // public static void WriteCsv(DataTable rows, TextWriter writer, bool useInvariantCulture, params string[] rowsToInclude) { ... }
        // public static DumpContainer OnDemand<T>(string description, Func<T> funcToEvalAndDump) { ... }
        // public static DumpContainer OnDemand<T>(string description, Func<T> funcToEvalAndDump, bool runOnNewThread) { ... }
        // public static bool? AutoScrollResults { get { ... } set { ... } }
        // public static DataContextBase CurrentDataContext { get { ... } internal set { ... } }
        // public static TextWriter SqlOutputWriter { get { ... } }
        // public static string CurrentQueryPath { get { ... } internal set { ... } }
        // public static int? Progress { get { ... } set { ... } }

        // public class ProgressBar
        // {
        //     public ProgressBar() { ... }
        //     public ProgressBar(string caption) { ... }
        //     public ProgressBar(string caption, bool hideWhenCompleted) { ... }
        //     public ProgressBar(bool hideWhenCompleted) { ... }
        //     public bool HideWhenCompleted { get { ... } set { ... } }
        //     public double Fraction { get { ... } set { ... } }
        //     public int Percent { get { ... } set { ... } }
        //     public string Caption { get { ... } set { ... } }
        //     public bool Visible { get { ... } set { ... } }
        // }
    }
}