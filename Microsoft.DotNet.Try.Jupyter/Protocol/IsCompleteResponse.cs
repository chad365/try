﻿using Newtonsoft.Json;

namespace Microsoft.DotNet.Try.Jupyter.Protocol
{
    public class IsCompleteResponse
    {
        //One of 'complete', 'incomplete', 'invalid', 'unknown'
        [JsonProperty("status")]
        public string Status { get; set; }

        //If status is 'incomplete', indent should contain the characters to use
        //to indent the next line. This is only a hint: frontends may ignore it
        // and use their own autoindentation rules. For other statuses, this
        // field does not exist.
        [JsonProperty("ident")]
        public string Ident { get; set; }
    }
}