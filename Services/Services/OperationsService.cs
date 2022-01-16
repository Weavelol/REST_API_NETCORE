﻿using Data.Repositories;
using Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Services {
    public class OperationsService : AbstractService<Operation> {
        public OperationsService(IRepository<Operation> repository) : base(repository) { }

        public Task<IEnumerable<Operation>> GetOperationsAtDateAsync(DateTime date) {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Operation>> GetOperationsAtPeriodAsync(DateTime startDate, DateTime endDate) {
            throw new NotImplementedException();
        }
    }
}
