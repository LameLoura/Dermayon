﻿using Dermayon.Infrastructure.Data.MongoRepositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dermayon.Infrastructure.Data.MongoRepositories.UoW
{
    public class UnitOfWorkMongo<Tcontext> : IUnitOfWorkMongo<Tcontext>
        where Tcontext : MongoContext
    {
        public Tcontext Context { get; }
        public UnitOfWorkMongo(Tcontext context) => Context = context;
        public async Task<bool> Commit()
        {
            try
            {
                var changeAmount = await Context.SaveChanges();                

                return changeAmount > 0;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public void Dispose()
        => Context?.Dispose();

    }
}
