﻿using Hypercube.Core.Dependencies;
using Hypercube.Core.Execution.Attributes;
using Hypercube.Core.Execution.Enums;

namespace Rainclipse;

public static class EntryPoint
{
    [EntryPoint(EntryPointLevel.BeforeInit)]
    public static void Init(DependenciesContainer container)
    {
        // Init
    }
    
    [EntryPoint(EntryPointLevel.AfterInit)]
    public static void Start(DependenciesContainer container)
    {
        // Hello!
    }
}