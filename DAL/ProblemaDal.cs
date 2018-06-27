﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using DTO;

namespace DAL
{
    public class ProblemaDal
    {

        string conexao_sql = "server=localhost;database=db_tech;user=root;password=1234;port=3306";
        MySqlConnection conexao = null;
        MySqlCommand comando = new MySqlCommand();

        public List<probDto> carregaTudo()
        {
            try
            {
                conexao = new MySqlConnection(conexao_sql);
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select * from problema";
                comando.Connection = conexao;

                List<probDto> listProbDto = new List<probDto>();
                conexao.Open();

                MySqlDataReader dr = comando.ExecuteReader();


                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        probDto dtovar = new probDto();

                        dtovar.idProb = Convert.ToInt32(dr["idProb"]);
                        dtovar.problema = Convert.ToString(dr["problema"]);
                        dtovar.aula = Convert.ToString(dr["aula"]);
                        dtovar.professor = Convert.ToString(dr["professor"]);
                        dtovar.data = Convert.ToDateTime(dr["dataProb"]);
                        dtovar.idMaquina = Convert.ToString(dr["idMaquina"]);
                        dtovar.Check = Convert.ToString(dr["resolvido"]);

                        listProbDto.Add(dtovar);


                    }
                }
                return listProbDto;


            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao.Close();
            }
        }

        public void cadProd(probDto dto)
        {
            try
            {
                conexao = new MySqlConnection(conexao_sql);
                MySqlCommand sql = new MySqlCommand("insert into problema(aula,professor,idMaquina,problema,dataProb,resolvido) values(@aula,@profe,@idmaquina,@descProb,@data,@re)")
                {
                    Connection = conexao
                };
                sql.Parameters.Add("@aula", MySqlDbType.VarChar).Value = dto.aula;
                sql.Parameters.Add("@profe", MySqlDbType.VarChar).Value = dto.professor;
                sql.Parameters.Add("@idmaquina", MySqlDbType.VarChar).Value = dto.idMaquina;
                sql.Parameters.Add("@descProb", MySqlDbType.VarChar).Value = dto.problema;
                sql.Parameters.Add("@data", MySqlDbType.DateTime).Value = System.DateTime.Now;
                sql.Parameters.Add("@re", MySqlDbType.VarChar).Value = "";


                conexao.Open();
                sql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                conexao.Close();
            }
        }

        public void alteraProb(probDto dtovar)
        {
            try
            {
                conexao = new MySqlConnection(conexao_sql);
                MySqlCommand sql = new MySqlCommand("update problema set idMaquina = @idM,problema = @prob where idProb = @id")
                {
                    Connection = conexao
                };
                sql.Parameters.Add("@idM", MySqlDbType.VarChar).Value = dtovar.idMaquina;
                sql.Parameters.Add("@id", MySqlDbType.Int32).Value = dtovar.idProb;
                sql.Parameters.Add("@prob", MySqlDbType.VarChar).Value = dtovar.problema;
                conexao.Open();
                sql.ExecuteNonQuery();
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }
        public void deletaProb(probDto dto)
        {
            try
            {
                conexao = new MySqlConnection(conexao_sql);
                MySqlCommand sql = new MySqlCommand("delete from problema where idProb = @id")
                {
                    Connection = conexao
                };
                sql.Parameters.Add("@id", MySqlDbType.Int32).Value = dto.idProb;
                conexao.Open();
                sql.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public List<probDto> carregaPorData()
        {
            try
            {
                conexao = new MySqlConnection(conexao_sql);
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT * FROM problema order by dataProb";
                comando.Connection = conexao;

                List<probDto> listProbDto = new List<probDto>();
                conexao.Open();

                MySqlDataReader dr = comando.ExecuteReader();


               
               
                    while (dr.Read())
                    {
                        probDto dtovar = new probDto();

                        dtovar.idProb = Convert.ToInt32(dr["idProb"]);
                        dtovar.problema = Convert.ToString(dr["problema"]);
                        dtovar.aula = Convert.ToString(dr["aula"]);
                        dtovar.professor = Convert.ToString(dr["professor"]);
                        dtovar.data = Convert.ToDateTime(dr["dataProb"]);
                        dtovar.idMaquina = Convert.ToString(dr["idMaquina"]);
                        dtovar.Check = Convert.ToString(dr["resolvido"]);


                    listProbDto.Add(dtovar);


                    }
               
                return listProbDto;


            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao.Close();
            }
        }
        public List<probDto> carregaPorDataNova()
        {
            try
            {
                conexao = new MySqlConnection(conexao_sql);
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT * FROM problema order by dataProb desc";
                comando.Connection = conexao;

                List<probDto> listProbDto = new List<probDto>();
                conexao.Open();

                MySqlDataReader dr = comando.ExecuteReader();




                while (dr.Read())
                {
                    probDto dtovar = new probDto();

                    dtovar.idProb = Convert.ToInt32(dr["idProb"]);
                    dtovar.problema = Convert.ToString(dr["problema"]);
                    dtovar.aula = Convert.ToString(dr["aula"]);
                    dtovar.professor = Convert.ToString(dr["professor"]);
                    dtovar.data = Convert.ToDateTime(dr["dataProb"]);
                    dtovar.idMaquina = Convert.ToString(dr["idMaquina"]);
                    dtovar.Check = Convert.ToString(dr["resolvido"]);


                    listProbDto.Add(dtovar);


                }

                return listProbDto;


            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao.Close();
            }
        }

        public List<probDto> carregaPorProfessor(probDto dtovar)
        {
            try
            {
                conexao = new MySqlConnection(conexao_sql);
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT * FROM problema WHERE CONCAT(professor) LIKE '%" + dtovar.professor + "%'";
                comando.Connection = conexao;

                List<probDto> listProbDto = new List<probDto>();
                conexao.Open();

                MySqlDataReader dr = comando.ExecuteReader();


                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {

                        dtovar.idProb = Convert.ToInt32(dr["idProb"]);
                        dtovar.problema = Convert.ToString(dr["problema"]);
                        dtovar.aula = Convert.ToString(dr["aula"]);
                        dtovar.professor = Convert.ToString(dr["professor"]);
                        dtovar.data = Convert.ToDateTime(dr["dataProb"]);
                        dtovar.idMaquina = Convert.ToString(dr["idMaquina"]);
                        dtovar.Check = Convert.ToString(dr["resolvido"]);


                        listProbDto.Add(dtovar);


                    }
                }
                return listProbDto;


            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public List<probDto> carregaPorId(probDto dtovar)
        {
            try
            {
                conexao = new MySqlConnection(conexao_sql);
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT * FROM problema WHERE CONCAT(idmaquina) LIKE '%" + dtovar.idMaquina + "%';";
                comando.Connection = conexao;


                List<probDto> listProbDto = new List<probDto>();
                conexao.Open();

                MySqlDataReader dr = comando.ExecuteReader();


                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {

                        dtovar.idProb = Convert.ToInt32(dr["idProb"]);
                        dtovar.problema = Convert.ToString(dr["problema"]);
                        dtovar.aula = Convert.ToString(dr["aula"]);
                        dtovar.professor = Convert.ToString(dr["professor"]);
                        dtovar.data = Convert.ToDateTime(dr["dataProb"]);
                        dtovar.idMaquina = Convert.ToString(dr["idMaquina"]);
                        dtovar.Check = Convert.ToString(dr["resolvido"]);

                        listProbDto.Add(dtovar);


                    }
                }
                return listProbDto;


            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void alteraSituacao(probDto dtoVar)
        {
            try
            {
                conexao = new MySqlConnection(conexao_sql);
                MySqlCommand sql = new MySqlCommand("update problema set resolvido = @check where idProb = @id")
                {
                    Connection = conexao
                };
                sql.Parameters.Add("@check", MySqlDbType.VarChar).Value = dtoVar.Check;
                sql.Parameters.Add("@id", MySqlDbType.Int32).Value = dtoVar.idProb;
                conexao.Open();
                sql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                conexao.Close();
            }
        }
        public List<probDto> notifica(probDto dtovar)
        {
            try
            {
                conexao = new MySqlConnection(conexao_sql);
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT COUNT(*) FROM problema";
                comando.Connection = conexao;


                List<probDto> listProbDto = new List<probDto>();
                conexao.Open();

                MySqlDataReader dr = comando.ExecuteReader();


                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {

                        dtovar.noti = Convert.ToInt32(dr["COUNT(*)"]);
                        

                        listProbDto.Add(dtovar);


                    }
                }
                return listProbDto;


            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
