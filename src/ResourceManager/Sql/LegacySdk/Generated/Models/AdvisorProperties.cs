// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.Sql.LegacySdk.Models;

namespace Microsoft.Azure.Management.Sql.LegacySdk.Models
{
    /// <summary>
    /// Represents the properties of an Azure SQL Server/Database/Elastic Pool
    /// Advisor.
    /// </summary>
    public partial class AdvisorProperties
    {
        private string _advisorStatus;
        
        /// <summary>
        /// Optional. Gets the current the status of this advisor. Possible
        /// values are 'GA', 'PublicPreview', 'LimitedPublicPreview' and
        /// 'PrivatePreview'.
        /// </summary>
        public string AdvisorStatus
        {
            get { return this._advisorStatus; }
            set { this._advisorStatus = value; }
        }
        
        private string _autoExecuteStatus;
        
        /// <summary>
        /// Optional. Gets the auto-execute status (whether to let the system
        /// execute the recommendations) of this advisor. Possible values are
        /// 'Enabled' and 'Disabled'
        /// </summary>
        public string AutoExecuteStatus
        {
            get { return this._autoExecuteStatus; }
            set { this._autoExecuteStatus = value; }
        }
        
        private string _autoExecuteStatusInheritedFrom;
        
        /// <summary>
        /// Optional. Gets the resource from which current value of
        /// auto-execute status is inherited. Auto-execute status can be set
        /// on (and inhertied from) different levels in the resource
        /// heirarchy. Possible values are 'Subscription', 'Server',
        /// 'ElasticPool', 'Database' and 'Default' (when status is not
        /// explicitly set on any level).
        /// </summary>
        public string AutoExecuteStatusInheritedFrom
        {
            get { return this._autoExecuteStatusInheritedFrom; }
            set { this._autoExecuteStatusInheritedFrom = value; }
        }
        
        private System.DateTime? _lastChecked;
        
        /// <summary>
        /// Optional. Gets the time when the current resource was analyzed for
        /// recommendations by this Advisor.
        /// </summary>
        public System.DateTime? LastChecked
        {
            get { return this._lastChecked; }
            set { this._lastChecked = value; }
        }
        
        private string _recommendationsStatus;
        
        /// <summary>
        /// Optional. Gets that status of recommendations for this Advisor and
        /// reason for not having any recommendations. Possible values
        /// include, but not limited to, 'Ok' (Recommendations
        /// available),LowActivity (not enough workload to analyze),
        /// 'DbSeemsTuned' (Database is doing well), etc.
        /// </summary>
        public string RecommendationsStatus
        {
            get { return this._recommendationsStatus; }
            set { this._recommendationsStatus = value; }
        }
        
        private IList<RecommendedAction> _recommendedActions;
        
        /// <summary>
        /// Optional. Gets the recommended actions for this advisor.
        /// </summary>
        public IList<RecommendedAction> RecommendedActions
        {
            get { return this._recommendedActions; }
            set { this._recommendedActions = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the AdvisorProperties class.
        /// </summary>
        public AdvisorProperties()
        {
            this.RecommendedActions = new LazyList<RecommendedAction>();
        }
    }
}
