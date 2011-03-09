using System;
using MovilDomain;
using Castle.ActiveRecord;
using Castle.ActiveRecord.Framework.Config;
using System.IO;

namespace MovilClient
{
    class MainClass
    {
        static void Main(string[] args)
        {
            ini();

            Console.WriteLine("Deseas crear la Estructura de la Base de Datos? (s/n): (s)i");
            string respuesta = Console.ReadLine();

            if (respuesta.ToLower() == "s")
            {
                try
                {
                    ActiveRecordStarter.CreateSchema();
                    Console.WriteLine("Estructura de la Base de Datos Creada Satisfactoriamente");
                }
                catch (Exception e)
                {
                    Console.WriteLine("ocurrio excepcion: " + e.Message);
                }
            }
            Console.WriteLine("presiona cualquier tecla");
            Console.ReadLine();
        }

        public static void ini()
        {
            XmlConfigurationSource ARConfig = new XmlConfigurationSource("ARConfig.xml");
            try
            {
                ActiveRecordStarter.Initialize(ARConfig,
                                               typeof(Placa),
                                               typeof(Licencia),
                                               typeof(Direccion),
                                               typeof(Multa),
                                               typeof(OrdAprehension));
            }
            catch (Exception e)
            {
                Console.WriteLine("ocurrio excepcion: " + e.Message);
            }
            Console.WriteLine("Inicializando Aplicacion");
        }
    }
}
