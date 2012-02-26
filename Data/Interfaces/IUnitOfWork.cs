﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebSite.Data
{
    public interface IUnitOfWork
    {
        void Commit();
        void DisposeCore();
    }
}
