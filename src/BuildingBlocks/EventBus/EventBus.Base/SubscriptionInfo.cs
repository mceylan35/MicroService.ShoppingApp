using System;
using System.Collections.Generic;
using System.Text;

namespace EventBus.Base
{
    public class SubscriptionInfo
    {
        public Type HandleType { get; set; }

        public SubscriptionInfo(Type handlerType)
        {
            HandleType = handlerType ?? throw new ArgumentNullException(nameof(handlerType));

        }
        public static SubscriptionInfo Typed(Type handlerType)
        {
            return new SubscriptionInfo(handlerType);
        }
    }
}
