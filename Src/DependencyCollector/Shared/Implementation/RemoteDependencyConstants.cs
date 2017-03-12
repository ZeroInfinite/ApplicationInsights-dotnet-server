﻿namespace Microsoft.ApplicationInsights.DependencyCollector.Implementation
{
    internal static class RemoteDependencyConstants
    {
        public const string SQL = "SQL";
        public const string HTTP = "Http";
        public const string AI = "Http (tracked component)";

        public const string AzureBlob = "Azure blob";
        public const string AzureTable = "Azure table";
        public const string AzureQueue = "Azure queue";

        public const string WcfService = "WCF Service";
        public const string WebService = "Web Service";
    }
}
