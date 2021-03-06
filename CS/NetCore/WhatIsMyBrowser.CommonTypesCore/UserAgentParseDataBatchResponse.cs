﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace WhatIsMyBrowser.CommonTypesCore
{
    public class UserAgentParseDataBatchResponse : BaseResponse
    {
        [JsonProperty("parses")]
        public Dictionary<string, UserAgentParseDataBatchResponseItem> Parses { get; set; }

        [JsonProperty("parse_stats")]
        public UserAgentParseDataBatchResponseStats ParseStats { get; set; }
    }
}