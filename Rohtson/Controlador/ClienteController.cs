using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rohtson.Modelo.DTO;
using Rohtson.Modelo.DAO;
using Rohtson.Vista;

namespace Rohtson.Controlador
{

    class ClienteController
    {
        Uc_cliente Vista;
        //Constructor
        public ClienteController(Uc_cliente View)
        {
            Vista = View;
            //Inicializar eventos
            Vista.Load += new EventHandler(ClientList);          
            Vista.gtxt_Buscar.TextChanged += new EventHandler(ClientList);
        }

        private void ClientList(object sender, EventArgs e) 
        { 
            ClienteDao db   = new ClienteDao();
            Vista.dgvClientes.DataSource = db.VerRegistros(Vista.gtxt_Buscar.Text);
        }
    }
}
