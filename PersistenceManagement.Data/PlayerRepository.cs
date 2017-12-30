using PersistenceManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistenceManagement.Data
{
    public class PlayerRepository
    {
        private readonly TennisSchemaContext _tennisSchemaContext;
        public PlayerRepository(TennisSchemaContext tennisSchemaContext)
        {
            _tennisSchemaContext = tennisSchemaContext;
        }

        public void Create()
        {

        }
        public Player Read()
        {
            return null;
        }
        public void Update(int id)
        {

        }
        public void Delete(int id)
        {

        }
    }
}
