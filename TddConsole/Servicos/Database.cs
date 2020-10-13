using System;
using System.Collections.Generic;
using TddConsole.Models;

namespace TddConsole.Servicos
{
    public class Database
    {
        public Database(IDoc iDoc, Db db)
        {
            this._iDoc = iDoc;
            this._db = db;
        }

        private IDoc _iDoc;
        private Db _db;

        public void Salvar()
        {
            _db.Salvar(_iDoc);
        }

        public int Quantidade()
        {
            return _db.Quantidade();
        }

        public List<IDoc> Todos()
        {
            return _db.Todos();
        }
    }
}
