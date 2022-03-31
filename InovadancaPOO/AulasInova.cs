using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;


namespace InovadancaPOO
{
    internal class AulasInova
    {
        private NpgsqlConnection conn;
        private NpgsqlCommand cmd;

        public AulasInova()
        {
            conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=inovadanca;User Id=postgres;Password=docker");
            conn.Open();
            cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

        }
        ~AulasInova()
        {
            cmd.Dispose();
            conn.Close();
        }
        public void create(string id, string name, string professor, string days, string modalidade, string created_at, string updated_at)
        {
            cmd.CommandText = String.Format("insert into aulas (id, name, professor, days, modalidade, created_at, updated_at) values (" +
                    "'{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');", id, name, professor, days, modalidade, created_at, updated_at);
            var db = cmd.ExecuteReader();
            db.Close();
        }
        public DataTable read()
        {
            cmd.CommandText = "select id, name, professor, days, modalidade, created_at, updated_at from aulas order by id asc";
            NpgsqlDataReader db = cmd.ExecuteReader();
            DataTable dGrid = new DataTable();
            dGrid.Load(db);
            db.Close();
            return dGrid;
        }
        public DataTable readaula()
        {
            cmd.CommandText = "select id, name from aulas order by name asc";
            NpgsqlDataReader db = cmd.ExecuteReader();
            DataTable dGrid = new DataTable();
            dGrid.Load(db);
            db.Close();
            return dGrid;
        }
        public void update(string id, string name, string professor, string days, string modalidade, string updated_at)
        {
            cmd.CommandText = String.Format("update aulas set name='{0}', professor='{1}', days='{2}', modalidade='{3}'," +
                "updated_at = '{4}' where id='{5}'", name, professor, days, modalidade, updated_at, id);
            var db = cmd.ExecuteReader();
            db.Close();
        }

        public void delete(string id)
        {
            cmd.CommandText = String.Format("delete from aulas where id='{0}'", id);
            var db = cmd.ExecuteReader();
            db.Close();
        }

        public NpgsqlDataReader search(string id)
        {
            cmd.CommandText = String.Format("select * from aulas where id='{0}'", id);
            NpgsqlDataReader aluno = cmd.ExecuteReader();
            return aluno;
        }
        
        public string aulanome(string id)
        {
            cmd.CommandText = String.Format("select name from aulas where id='{0}'", id);
            var user = cmd.ExecuteReader();
            user.Read();
            string nome = user["name"].ToString();
            user.Close();
            return nome;
        }
        public DataTable readexcess(string aulas_id)
        {
            string comando = "select id, name from aulas where";
            int count = 0;
            for (int i = 0; i < aulas_id.Length; i++)
            {
                if (aulas_id[i] == ',')
                    count += 1;
            }
            string aulas_split = "";
            for (int i = 0; i < count; i++)
            {
                if (i + 1 != count)
                    comando = comando + " id != " + "'" + aulas_id.Split(',')[i] + "'" + " and";
                else
                    comando = comando + " id != " + "'" + aulas_id.Split(',')[i] + "'";
            }
            cmd.CommandText = comando + " order by name asc";
            NpgsqlDataReader db = cmd.ExecuteReader();
            DataTable dGrid = new DataTable();
            dGrid.Load(db);
            db.Close();
            return dGrid;
        }
    }
}
