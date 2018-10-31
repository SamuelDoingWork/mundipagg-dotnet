﻿using System.Collections.Generic;

namespace MundiPagg.Models.Request
{
    /// <summary>
    /// Update metadata request
    /// </summary>
    public class UpdateMetadataRequest
    {
        /// <summary>
        /// Additional information
        /// </summary>
        public IDictionary<string, string> Metadata { get; set; }
    }
}
