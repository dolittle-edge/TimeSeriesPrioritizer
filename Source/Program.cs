﻿// Copyright (c) RaaLabs. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;
using RaaLabs.Edge.Modules.EventHandling;
using RaaLabs.Edge.Modules.EdgeHub;
using RaaLabs.Edge.Modules.Configuration;

namespace RaaLabs.Edge.Prioritizer
{
    [ExcludeFromCodeCoverage]
    static class Program
    {
        static void Main(string[] args)
        {
            Run().Wait();
        }
        
        private static async Task Run()
        {
            var application = new ApplicationBuilder()
                .WithModule<EventHandling>()
                .WithModule<EdgeHub>()
                .WithModule<Configuration>()
                .WithHandler<PrioritizerHandler>()
                .WithType<Prioritizer>()
                .Build();

            await application.Run();
        }
    }
}
