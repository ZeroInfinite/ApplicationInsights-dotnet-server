﻿namespace Microsoft.ApplicationInsights.Extensibility.PerfCounterCollector.Implementation.WebAppPerformanceCollector
{
    /// <summary>
    /// Interface for classes that implement a CacheHelper.
    /// </summary>
    internal interface ICachedEnvironmentVariableAccess
    {
        /// <summary>
        /// Returns value of a counter from cache.
        /// </summary>
        /// <param name="name"> Name of the counter.</param>
        /// <param name="environmentVariable"> Identifier of the corresponding environment variable.</param>
        /// <returns> Counter value.</returns>
        int GetCounterValue(string name, AzureWebApEnvironmentVariables environmentVariable);
    }
}