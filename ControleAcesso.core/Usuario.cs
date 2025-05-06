using ControleAcesso.Desk;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ControleAcesso.Desk
{
    // Entidade de usuário 

    public class Usuario
    {

        public int Id { get; set; }

        public string? Nome { get; set; }

        public string? Cpf { get; set; }

        public string? TipoUsuario { get; set; }

        public string? Senha { get; set; } // Apenas Simular
        public bool Ativo { get; set; } // Apenas Simular

        //Construtor
        public Usuario() { }
        public Usuario(int id, string nome, string cpf, string tipoUsuario, string senha, bool ativo)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            TipoUsuario = tipoUsuario;
            Senha = senha;
            Ativo = ativo;
        }
        public Usuario(string nome, string cpf, string tipoUsuario, string senha)
        {
            Nome = nome;
            Cpf = cpf;
            TipoUsuario = tipoUsuario;
            Senha = senha;
        }
        public Usuario(string nome, string senha)
        {
            Nome = nome;
            Senha = senha;
        }
        public Usuario(string nome)
        {
            Nome = nome;

        }
        //Métodos da Classe!
        public static Usuario ObterPorID(int id)
        {
            Usuario usuario = new Usuario();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from usuarios where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                usuario = new(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetString(4),
                        dr.GetBoolean(5)
                    );
            }
            return usuario;
        }
        public static List<Usuario> ObterLista()
        {
            List<Usuario> usuarios = new List<Usuario>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from usuarios order by nome";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Usuario usuario = new(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetString(4),
                        dr.GetBoolean(5)
                    );
                usuarios.Add(usuario);
            }
            return usuarios;

        }
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"INSERT INTO usuarios (nome, cpf, tipo, senha, ativo) " +
    $"VALUES ('{Nome}', '{Cpf}', '{TipoUsuario}', md5('{Senha}'), 1)";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select last_insert_id()";
            Id = Convert.ToInt32(cmd.ExecuteScalar());

        }

        public void alterar()// Alterar apenas o nome
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update usuarios set nome = '{Nome}' where id = {Id}";
            cmd.ExecuteNonQuery();
        }
        public static Usuario EfetuarLogin(string nome, string senha)
        {
            Usuario usuario = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from usuarios where nome = @nome and senha = md5(@senha)";
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@senha", senha);
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                usuario.Id = dr.GetInt32(0);
                usuario.Nome = dr.GetString(1);
                usuario.Cpf = dr.GetString(2);
                usuario.TipoUsuario = dr.GetString(3);
                usuario.Senha = dr.GetString(4);
                usuario.Ativo = dr.GetBoolean(5);

            }
            return usuario;

                   
        }
        public void ValidarLogin()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"insert usuarios (nome, senha, ativo) " +
                $"values ('{Nome}',md5('{Senha}'), default)";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select last_insert_id()";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            // NECESSÁRIO CORRIGIR COMANDO, COMANDO DE INSERIR.

        }
        public void Alterar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update usuarios set nome = '{Nome}', cpf = '{Cpf}', tipo = '{TipoUsuario}', senha = md5('{Senha}'), ativo = {Ativo} where id = {Id}";
            cmd.ExecuteNonQuery();

            //Alterar cadastro de usuário

        }

    }
}
