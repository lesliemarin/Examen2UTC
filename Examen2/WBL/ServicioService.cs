using BD;
using Entity;
using Entity.dbo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public  interface IServicioService
    {
  
        Task<IEnumerable<ServicioEntity>> GET();
 
    }

    public class ServicioService : IServicioService
    {
        private readonly IDataAccess sql;

        public ServicioService(IDataAccess _sql)
        {
            sql = _sql;
        }

        #region MetodosCRUD

        //Metodo Get
        public async Task<IEnumerable<ServicioEntity>> GET()
        {
            try
            {
                var result = sql.QueryAsync<ServicioEntity>("dbo.ServicioObtener");
                return await result;
            }
            catch (Exception)
            {

                throw;
            }


        }

        #endregion
    }
}
