using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_de_acceso
{
    struct Cliente
    {
        public string dni_cliente;
        public string nombre_cliente;
        public string apellido_cliente;
        public string telefono_cliente;
        public string direccion_cliente;
    };

    
    struct vehiculo
    {
        public string dni_cliente;
        public string placa_vehiculo;
        public string caracteristicas_vehiculo;
        public string estado_vehiculo;
        public float deuda_vehiculo;
    }
    struct trabajador
    {
        public string dni_trabajador;
        public string nombre_trabajador;
        public string apellido_trabajador;
        public string rango_trabajador;
        public float sueldo_trabajador;
    }

    struct control
    {
        public string id_control;
        public string dni_trabajador;
        public string placa_vehiculo;
        public DateTime fecha_hora_entrada;
        public DateTime fecha_hora_salida;
        public float pago_control;
    }

    class Program
    {
        static void Main(string[] args)
        {

        }

    }
}
