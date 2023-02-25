using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using P42023UC.Models;
using System.Threading.Tasks;

namespace P42023UC.Controllers
{
    public class EmpleController
    {
        readonly SQLiteAsyncConnection _connection;
        // Constructor de clase
        public EmpleController(string DBPath) 
        {
            _connection = new SQLiteAsyncConnection(DBPath);
            _connection.CreateTableAsync<Models.Empleado>();
        }

        // CRUD - Create - Read - Update - Delete

        // Create / Update
        public Task<int> SaveEmple(Models.Empleado empleado) 
        {
            if (empleado.id != 0)
                return _connection.UpdateAsync(empleado);
            else
                return _connection.InsertAsync(empleado);
        }

        //Read one un empleado
        public Task<Models.Empleado> GetEmpleado(int pid) 
        {
            return _connection.Table<Models.Empleado>()
                .Where(i => i.id == pid)
                .FirstOrDefaultAsync();
        }

        // Read para toda la lista de empleados
        public Task<List<Models.Empleado>> GetListEmple() 
        {
            return _connection.Table<Models.Empleado>().ToListAsync();
        }

        //Delete 
        public Task<int> DeleteEmple(Models.Empleado empleado) 
        {
            return _connection.DeleteAsync(empleado);
        }

    }
}
