﻿using OpenCensus.Stats.Aggregations;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenCensus.Stats
{
    public interface IAggregation
    {
        M Match<M>(
             Func<ISum, M> p0,
             Func<ICount, M> p1,
             Func<IMean, M> p2,
             Func<IDistribution, M> p3,
             Func<ILastValue, M> p4,
             Func<IAggregation, M> p6);
    }
}