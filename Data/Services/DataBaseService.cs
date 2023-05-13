using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Interfaces;

namespace Data.Services
{
    public class DataBaseService : IDataBaseService
    {
        // GET: HomeController
        private readonly IUserService _IUserService;
        private readonly ITablesServices _ITablesServices;

        public DataBaseService(ITablesServices ITablesServices, IUserService IUserService)
        {
            _IUserService = IUserService;
            _ITablesServices = ITablesServices;
        }
        public object Update()
        {
            try
            {
                var ListOfUsers = _IUserService.GetAllUsers();
                var ListOfTables = _ITablesServices.GetAllTables();

                var laPosta = _IUserService.GetUserWithRelations();

                return new { Respuesta = "ok" };
            }
            catch (Exception ex)
            {
                return new { Respuesta = "Msj Error: " + ex.Message + "Sourse" + ex.Source };
            }
        }
    }
}
