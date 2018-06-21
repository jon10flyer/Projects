using System;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Storage;

namespace SpyStore.DAL.EF
{
    class MyExecutionStrategy : ExecutionStrategy
    {
        public MyExecutionStrategy(
            ExecutionStrategyContext context,
            int maxRetryCount,
            TimeSpan maxRetryDelay) : base(context, maxRetryCount, maxRetryDelay)
        {
        }
        public MyExecutionStrategy(ExecutionStrategyContext context):
            base (context, ExecutionStrategy.DefaultMaxRetryCount,
                ExecutionStrategy.DefaultMaxDelay)
        { }
        protected override bool ShouldRetryOn(Exception exception)
        {
            return true;
        }

    }
}
