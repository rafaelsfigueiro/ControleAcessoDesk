﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Desk
{
    public static class Banco
    {
        /// <summary>
        /// Abre uma conexão com o banco de dados
        /// </summary>
        /// <returns>Um Objeto de comados MySql com uma conexão aberta</returns>
        public static MySqlCommand Abrir()
        {
            MySqlCommand cmd = new();
            string strConn = @"server=locahost;database=ControleAcesso;user=root;password=";

            // string strConn = @"server=127.0.0.1;database=tdsqueuedb01;user=root;password=" // meu servidor local
            MySqlConnection cn = new(strConn);
            try
            {
                cn.Open();
                cmd.Connection = cn;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return cmd;
        }

    }
}