/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RegionSellConf : AbstractModel
    {
        
        /// <summary>
        /// 地域中文名称
        /// </summary>
        [JsonProperty("RegionName")]
        public string RegionName{ get; set; }

        /// <summary>
        /// 所属大区
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// 是否为默认地域
        /// </summary>
        [JsonProperty("IsDefaultRegion")]
        public long? IsDefaultRegion{ get; set; }

        /// <summary>
        /// 地域名称
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 可用区售卖配置
        /// </summary>
        [JsonProperty("ZonesConf")]
        public ZoneSellConf[] ZonesConf{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RegionName", this.RegionName);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "IsDefaultRegion", this.IsDefaultRegion);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamArrayObj(map, prefix + "ZonesConf.", this.ZonesConf);
        }
    }
}

