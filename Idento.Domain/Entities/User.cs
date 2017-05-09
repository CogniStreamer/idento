﻿/*
 * Copyright 2016-2017 Wouter Huysentruit
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

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Idento.Domain.Entities
{
    [Table("Users", Schema = "Security")]
    public class User : IdentityUser<Guid>
    {
        public User()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }


        [EmailAddress(ErrorMessage = "Invalid email address")]
        public override string UserName { get; set; }

        [MaxLength(256)]
        public virtual string FirstName { get; set; }

        [MaxLength(256)]
        public virtual string LastName { get; set; }
    }
}