using Persistence.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Import
{
    public partial class ImportForm : PForm
    {
        public ImportForm()
        {
            InitializeComponent();
            this.Importar("C://Users//Diego//Desktop//Exemple.xlsx");
        }
        //Primeira Etapa
        
        // Itens contemplados
        
        // Primissas
        // Selecionar a primeira linha.
        // Selecionar as colunas.
        
        //Configurações
        // Ignorar linhas vazias
        // Verificar se têm cabeçalho.
        // Coluna de ordenação. a-z e z-a.

        //Segunda Etapa
        //Tipos de Arquivos para importação
        public DataTable Importar(string arquivo) 
        { 
            string ext = string.Empty; 
            string aspas = "\""; 
            string Conexao = string.Empty;
            for (int i = arquivo.Length - 1; i < arquivo.Length; i--) 
            { 
                if (arquivo[i] != '.') 
                { 
                    ext += arquivo[i]; 
                } 
                else 
                { 
                    ext += "."; break; 
                } 
            } 
            //ext = StringUtils.Inverter(ext); 
            if (ext == ".xls") 
            { 
                Conexao = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + arquivo + ";" + "Extended Properties=" + aspas + "Excel 8.0;HDR=YES" + aspas; 
            } 
            if (ext == ".xlsx") 
            { 
                Conexao = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + arquivo + ";" + "Extended Properties=" + aspas + "Excel 12.0;HDR=YES" + aspas; 
            } 
            System.Data.OleDb.OleDbConnection Cn = new System.Data.OleDb.OleDbConnection(); 
            Cn.ConnectionString = Conexao; 
            Cn.Open(); 
            object[] Restricoes = { null, null, null, "TABLE" }; 
            DataTable DTSchema = Cn.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables, Restricoes); 
            if (DTSchema.Rows.Count > 0) 
            { 
                string Sheet = DTSchema.Rows[0]["TABLE_NAME"].ToString(); 
                System.Data.OleDb.OleDbCommand Comando = new System.Data.OleDb.OleDbCommand("SELECT * FROM [" + Sheet + "]", Cn); 
                DataTable Dados = new DataTable(); 
                System.Data.OleDb.OleDbDataAdapter DA = new System.Data.OleDb.OleDbDataAdapter(Comando); 
                DA.Fill(Dados); 
                Cn.Close(); 
                return Dados; 
            } 
            return null; 
        }
    }
}
