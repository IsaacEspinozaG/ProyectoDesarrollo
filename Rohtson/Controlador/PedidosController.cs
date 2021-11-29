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
    class PedidosController
    {
        uc_pedidos Vista1;
        //Constructor
        public PedidosController(uc_pedidos View)
        {
            Vista1 = View;
            //Inicializar eventos
            Vista1.Load += new EventHandler(PedidosList);
        }

        private void PedidosList(object sender, EventArgs e)
        {
            PedidosDao db = new PedidosDao();
            Vista1.dgvPedidos.DataSource = db.VerPedidos(Vista1.gtbxpedidos.Text);
        }
    }
}
