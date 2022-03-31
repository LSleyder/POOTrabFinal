using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace InovadancaPOO
{
    public class AlunoInova
    {
        private NpgsqlConnection conn;
        private NpgsqlCommand cmd;

        public AlunoInova()
        {
            conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=inovadanca;User Id=postgres;Password=docker");
            conn.Open();
            cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

        }
        ~AlunoInova()
        {
            cmd.Dispose();
            conn.Close();
        }

        public void create(string id, string name, string birthday, string genre, string address, string phone, string CPF, string created_at, string updated_at)
        {
            cmd.CommandText = String.Format("insert into alunos (id, name, birthday, genre, address, phone, CPF, created_at, updated_at) values (" +
                    "'{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}');", id, name, birthday, genre, address, phone, CPF, created_at, updated_at);
            var db = cmd.ExecuteReader();
            db.Close();
        }

        public DataTable read()
        {
            cmd.CommandText = "select id, name, birthday, genre, address, phone, CPF from alunos order by id asc";
            NpgsqlDataReader db = cmd.ExecuteReader();
            DataTable dGrid = new DataTable();
            dGrid.Load(db);
            db.Close();
            return dGrid;
        }
        public void update(string id, string name, string birthday, string genre, string address, string phone, string CPF, string updated_at)
        {
            cmd.CommandText = String.Format("update alunos set name='{0}', birthday='{1}', genre='{2}', address='{3}', phone='{4}', CPF='{5}'," +
                "updated_at = '{6}' where id='{7}'", name, birthday, genre, address, phone, CPF, updated_at, id);
            var db = cmd.ExecuteReader();
            db.Close();
        }

        public void delete(string id)
        {
            cmd.CommandText = String.Format("delete from alunos where id='{0}'", id);
            var db = cmd.ExecuteReader();
            db.Close();
        }

        public NpgsqlDataReader search(string id)
        {
            cmd.CommandText = String.Format("select * from alunos where id='{0}'", id);
            NpgsqlDataReader aluno = cmd.ExecuteReader();
            return aluno;
        }
    }
}
