﻿using EstoqueApp.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp.Domain.Interfaces.Services
{
    public interface IProdutoDomainService : IBaseDomainService<Produto, Guid>
    {
    }
}
