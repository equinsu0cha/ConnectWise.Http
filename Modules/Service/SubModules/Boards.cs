﻿using ConnectWise.Http.ModuleTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectWise.Http.Modules.Service.SubModules
{
    public class BoardsSubModule : FullSubModule
    {
        internal BoardsSubModule(string module, string endpoint) : base(module, endpoint) { }

        /// <summary>
        /// Copies the board that is specified in the content body.
        /// </summary>
        /// <param name="content">The serialized content to be sent in the request body.</param>
        /// <param name="conditions">This endpoint only accepts 'Fields.'</param>
        /// <returns>CWRequest to be sent using CWHttpClient.</returns>
        public CWRequest CopyRequest(string content, CWRequestConditions conditions = null)
        {
            var conditionStr = conditions != null ? conditions.ToUriConditions(CWConditionOptions.OnlyFields) : string.Empty;
            return new CWRequest(CWHttpMethod.Post, $"{getPrefix()}/copy{conditionStr}", content);
        }
    }
}
