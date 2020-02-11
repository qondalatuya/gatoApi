using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GatoApi.Entidades;

namespace GatoApi.Config
{
    public class Util
    {
        public static ISessionFactory CreateSessionFactory()
        {
            var f = Fluently.Configure();
                        
            //DESKTOP-RI5PVSQ\SQLEXPRESS casa
            //string connString = @"Server=DESKTOP-RI5PVSQ\SQLEXPRESS; Database=gato; User Id=gato; Password = gato";

            //06CHAPC15\MSSQLEXPRESS osprera
            string connString = @"Server=06CHAPC15\MSSQLEXPRESS; Database=gato; User Id=gato; Password = gato";
            
            f.Database(MsSqlConfiguration.MsSql2012.ConnectionString(connString).ShowSql());

            // mapeo de clases, con solo hacer una referencia a una clase nos mapea todas las clases
            f.Mappings(m => m.FluentMappings.AddFromAssemblyOf<Cliente>());
            
            //esta linea es para crear las tablas en la base. pisa todo así que solo se ejecuta una vez, después le hardcodeo un comentario
            //f.ExposeConfiguration(x => new SchemaExport(x).Create(true,true));

            return f.BuildSessionFactory();
        }
    }
}
