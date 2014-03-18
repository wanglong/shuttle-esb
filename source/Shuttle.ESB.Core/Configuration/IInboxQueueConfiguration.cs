using System;

namespace Shuttle.ESB.Core
{
    public interface IInboxQueueConfiguration : IWorkProcessorConfiguration
    {
        QueueStartupAction WorkQueueStartupAction { get; set; }
        bool Distribute { get; set; }
		IQueue DeferredQueue { get; set; }
	    void MessageDeferred(DateTime ignoreTillDate);
	    bool ShouldProcessDeferred();
    }
}