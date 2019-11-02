﻿using Dermayon.Common.CrossCutting;
using Dermayon.Infrastructure.Data.MongoRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dermayon.Sample.SocialMedia.User.Framework.DAL
{
    public class UserContextEvents : MongoContext
    {

        public UserContextEvents(UserContextSetting settings) : base(settings)
        {

        }
    }
}