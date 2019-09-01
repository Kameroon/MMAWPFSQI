using MMA.Framework.Services.Contracts;
using NLog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMA.Framework.Services.Core
{
    public class EnvoieFichePaieService : IEnvoieFichePaieService
    {
        public readonly Logger _logger = LogManager.GetCurrentClassLogger();
        private IProviderService _providerService;

        public EnvoieFichePaieService(IProviderService providerService)
        {
            _providerService = providerService;
        }

        /// <summary>
        /// -- --
        /// </summary>
        /// <param name="file"></param>
        /// <returns>DataTable dt </returns>
        public DataTable GetDataTableFromExcelFile(string file)
        {
            _logger.Debug($"==> Debut récupération des données dans un fichier Excel et convertion en DataTable.");
            DataTable dt = new DataTable();

            _logger.Debug($"==> Début récupération de la chaine de connection OLEDB");
            string connectionString = _providerService.GetConnectionString(file);
            _logger.Debug($"==> Fin récupération de la chaine de connection OLEDB");

            try
            {
                _logger.Debug($"==> Connection à la source de données");
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;

                    // Get all Sheets in Excel File
                    DataTable dtSheet = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                    // Loop through all Sheets to get data
                    foreach (DataRow dr in dtSheet.Rows)
                    {
                        string sheetName = dr["TABLE_NAME"].ToString();

                        if (!sheetName.EndsWith("$"))
                            continue;

                        // Get all rows from the Sheet
                        cmd.CommandText = "SELECT * FROM [" + sheetName + "]";

                        dt.TableName = sheetName;

                        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                        da.Fill(dt);

                        break;
                    }

                    cmd = null;
                }

                _logger.Debug($"==> Fin récupération des données dans un fichier Excel et convertion en DataTable.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
            return dt;
        }
    }
}
