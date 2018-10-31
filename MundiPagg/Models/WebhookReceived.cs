﻿using MundiPagg.Models.Enums;
using Newtonsoft.Json;
using System;

namespace MundiPagg.Models
{
    /// <summary>
    /// Webhook received model
    /// </summary>
    public class WebhookReceived : BaseWebhook
    {
        /// <summary>
        /// Hook event type
        /// </summary>
        public WebhookEventEnum Type
        {
            get
            {
                return this.EventType;
            }
            set
            {
                this.EventType = value;
            }
        }
    }
}