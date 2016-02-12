﻿/*
 * Copyright 2016 CogniStreamer, Wouter Huysentruit
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using Microsoft.AspNet.Mvc.Razor;
using System.Collections.Generic;

namespace Idento
{
    public class IdentoViewLocationExpander : IViewLocationExpander
    {
        public IEnumerable<string> ExpandViewLocations(
            ViewLocationExpanderContext context,
            IEnumerable<string> viewLocations)
        {
            yield return "~/ManagerUI/{1}/Views/{0}.cshtml";
            yield return "~/ManagerUI/SharedViews/{0}.cshtml";
            yield return "~/LoginUI/{1}/Views/{0}.cshtml";
            yield return "~/LoginUI/SharedViews/{0}.cshtml";
        }

        public void PopulateValues(ViewLocationExpanderContext context)
        {
        }
    }
}
