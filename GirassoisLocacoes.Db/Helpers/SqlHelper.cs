using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Configuration;
using System.Reflection;
using System.IO;
using GirassoisLocacoes.Entidades;

namespace GirassoisLocacoes.Db
{
    public class SqlHelper
    {
        private static SqlHelper instance;
        DataSet objDS = new DataSet();  
        private SqlHelper() { }

        public static SqlHelper Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new SqlHelper();
                }
                return instance;
            }
        }

        private SqlDbType obterTipoParametro(string pTipo)
        {
            switch (pTipo)
            {
                case "bigint":
                    return SqlDbType.BigInt;
                case "binary":
                    return SqlDbType.Binary;
                case "bit":
                    return SqlDbType.Bit;
                case "char":
                    return SqlDbType.Char;
                case "date":
                    return SqlDbType.Date;
                case "datetime":
                    return SqlDbType.DateTime;
                case "datetime2":
                    return SqlDbType.DateTime2;
                case "datetimeoffset":
                    return SqlDbType.DateTimeOffset;
                case "decimal":
                    return SqlDbType.Decimal;
                case "float":
                    return SqlDbType.Float;
                case "image":
                    return SqlDbType.Image;
                case "int":
                    return SqlDbType.Int;
                case "money":
                    return SqlDbType.Money;
                case "nchar":
                    return SqlDbType.NChar;
                case "ntext":
                    return SqlDbType.NText;
                case "nvarchar":
                    return SqlDbType.NVarChar;
                case "real":
                    return SqlDbType.Real;
                case "smalldatetime":
                    return SqlDbType.SmallDateTime;
                case "smallint":
                    return SqlDbType.SmallInt;
                case "smallmoney":
                    return SqlDbType.SmallMoney;
                case "text":
                    return SqlDbType.Text;
                case "time":
                    return SqlDbType.Time;
                case "timestamp":
                    return SqlDbType.Timestamp;
                case "tinyint":
                    return SqlDbType.TinyInt;
                case "uniqueidentifier":
                    return SqlDbType.UniqueIdentifier;
                case "varbinary":
                    return SqlDbType.VarBinary;
                case "varchar":
                    return SqlDbType.VarChar;
                case "xml":
                    return SqlDbType.Xml;
                default:
                    return SqlDbType.VarChar;
            }
        }

        public SqlConnection abrirConexao(String stringConexao = "ConexaoSQLServer")
        {
            SqlConnection objConexao = null;
            string sConexao = null;
            try
            {
                sConexao = ConfigurationManager.ConnectionStrings[stringConexao].ConnectionString;

                if(objConexao == null)
                {
                    objConexao = new SqlConnection();
                    objConexao.ConnectionString = sConexao;

                    objConexao.Open();
                }

                return objConexao;
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }

        public bool fecharConexao(SqlConnection objConexao)
        {
            bool ret = false;
            try
            {
                if(objConexao != null)
                {
                    objConexao.Close();
                    objConexao.Dispose();
                    objConexao = null;
                }

                ret = true;
            }
            catch(SqlException ex)
            {
                //String descError = "Erro genérico com o banco de dados!";
                throw ex;
            }
            return ret;
        }

        public DataSet executarConsulta(SqlCommand pComando, int logComandoSql = 0)
        {
            string sErros = "";

            SqlConnection conn = null;
            DataSet objDS = null;

            try
            {
                conn = abrirConexao();
                objDS = new DataSet();
                pComando.Connection = conn;
                SqlDataAdapter objDA = new SqlDataAdapter(pComando);
                objDA.Fill(objDS);
            }catch(SqlException ex)
            {
                string descError = "Erro genérico de banco de dados!";

                if(ex.Errors.Count > 0)
                {
                    foreach(SqlError objErro in ex.Errors)
                    {
                        sErros += "- " + objErro.Message + "\r\n";
                    }

                    descError += "\r\n" + sErros;
                }

                throw ex;
            }
            finally
            {
                fecharConexao(conn);
            }

            return objDS;
        }

        public void criarParametros(string pNomeObjeto, ref SqlCommand pCMD)
        {
            SqlCommand objCmdPar = new SqlCommand();

            objCmdPar.CommandText = " SELECT 'Nome' = SC.Name, 'Tipo' = TYPE_NAME(SC.XUSERTYPE)," +
                                    " 'Tamanho' = CASE WHEN SC.xprec = 0 or TYPE_NAME(SC.XUSERTYPE) IN ('date','datetime','datetime2','datetimeoffset','time') " +
                                    " THEN SC.Length ELSE SC.xprec END, 'Direcao' = CASE WHEN SC.Isoutparam = 1 then 'OUTPUT' Else 'INPUT' END" +
                                    " FROM SYSOBJECTS SO" +
                                    " LEFT JOIN SYSCOLUMNS SC ON SC.ID = SO.ID" +
                                    " WHERE SO.Name = '" + pNomeObjeto + "'";

            objDS = this.executarConsulta(objCmdPar);

            if (objDS.Tables[0].Rows.Count > 0)
            {
                foreach(DataRow dr in objDS.Tables[0].Rows)
                {
                    //If para proc que não tem parâmetros
                    if (Convert.ToString(dr["Nome"]) == "")
                    {
                        break;
                    }

                    //Verifica se tem o "@" no inicio
                    if (!dr["Nome"].ToString().StartsWith("@"))
                        dr["Nome"] = "@" + dr["Nome"];

                    if (dr["Tipo"].ToString().Trim().ToUpper() == "LISTAUSUARIOS")
                    {
                        pCMD.Parameters.Add(dr["Nome"].ToString(), obterTipoParametro(dr["Tipo"].ToString()));
                    }
                    else
                    {
                        pCMD.Parameters.Add(dr["Nome"].ToString(), obterTipoParametro(dr["Tipo"].ToString()), Convert.ToInt32(dr["Tamanho"]));
                        if (dr["Direcao"].ToString() == "OUTPUT")
                            pCMD.Parameters[pCMD.Parameters.Count - 1].Direction = ParameterDirection.Output;
                    }
                }
            }
        }
    }
}
