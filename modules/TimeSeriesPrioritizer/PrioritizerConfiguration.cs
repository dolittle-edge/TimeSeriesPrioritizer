/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System.Collections.Generic;
using Dolittle.Configuration;
using Dolittle.Edge.Modules;

namespace Dolittle.Edge.TimeSeriesPrioritizer
{
    /// <summary>
    /// Represents the configuration for the prioritizer
    /// </summary>
    [Name("configuration")]
    public class PrioritizerConfiguration : IConfigurationObject
    {
        /// <summary>
        /// Initializes a new instance of <see cref="PrioritizerConfiguration"/>
        /// </summary>
        /// <param name="prioritized"></param>
        public PrioritizerConfiguration(IEnumerable<TimeSeries> prioritized)
        {
            Prioritized = prioritized;
        }

        /// <summary>
        /// Gets the prioritized timeseries
        /// </summary>
        public IEnumerable<TimeSeries> Prioritized { get; }
    }
}