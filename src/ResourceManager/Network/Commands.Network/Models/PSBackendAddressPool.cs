﻿//
// Copyright (c) Microsoft.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

namespace Microsoft.Azure.Commands.Network.Models
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public class PSBackendAddressPool : PSChildResource
    {
        public List<PSResourceId> BackendIpConfigurations { get; set; }

        public List<PSResourceId> LoadBalancingRules { get; set; }

        public string ProvisioningState { get; set; }

        [JsonIgnore]
        public string BackendIpConfigurationsText
        {
            get { return JsonConvert.SerializeObject(BackendIpConfigurations, Formatting.Indented); }
        }

        [JsonIgnore]
        public string LoadBalancingRulesText
        {
            get { return JsonConvert.SerializeObject(LoadBalancingRules, Formatting.Indented); }
        }
    }
}
