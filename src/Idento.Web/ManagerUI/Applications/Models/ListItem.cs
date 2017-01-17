﻿/*
 * Copyright (c) Wouter Huysentruit
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

using System;

namespace Idento.Web.ManagerUI.Applications.Models
{
    public class ListItem
    {
        public Guid Id { get; set; }
        public string ClientId { get; set; }
        public string DisplayName { get; set; }
        public bool Enabled { get; set; }
        public string GrantType { get; set; }
        public string Uri { get; set; }

    }
}