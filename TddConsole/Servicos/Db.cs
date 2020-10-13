using System;
using System.Collections.Generic;
using TddConsole.Models;

namespace TddConsole.Servicos
{
    public abstract class Db
    {
        public Db()
        {
        }

        public abstract void Salvar(IDoc iDoc);
        public abstract int Quantidade();
        public abstract List<IDoc> Todos();
    }
}
