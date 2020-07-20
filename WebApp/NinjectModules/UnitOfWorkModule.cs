using Infrastructure.DataBase.Implementations;
using Infrastructure.DataBase.Interfaces;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.NinjectModules
{
    public class UnitOfWorkModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUnitOfWork>().To<EFUnitOfWork>();
        }
    }
}