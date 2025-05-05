using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Desk
{
    // Serviço de autenticação 

    public class Autenticador
    {
        public bool ValidarLogin(string cpf, string senha)
        {
            // Aqui você pode implementar a lógica de autenticação
            // Por exemplo, verificar se o usuário e a senha estão corretos
            // Para fins de exemplo, vamos considerar que o usuário e a senha são válidos se forem iguais
            return true;
        }

    }
}
