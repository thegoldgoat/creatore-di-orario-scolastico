using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace creatore_di_orario_scolastico
{
    public partial class TabellaOrari : Form
    {
        public static Color[] colori = new Color[]
        {
            Color.Aqua,
            Color.OrangeRed,
            Color.PaleVioletRed,
            Color.YellowGreen,
            Color.MistyRose
        };
        public Orario orario = new Orario();
        public TabellaOrari()
        {
            InitializeComponent();
            orario.creaDatiEsempio();
            orario.creaOrario();

            // Inserisci i nomi delle classi nella combobox
            
            foreach (Orario.ClassiRow classe in orario.Classi.Rows )
            {
                this.listaClassi.Items.Add( classe[1] );
            }
        }

        // Mostra l'orario sulla Windows Form
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nomeClasse"></param>
        private void visualizzaOrario(String nomeClasse)
        {
            // Cerca l'id della classe partendo dal nome
            Int64 trovato = -1;
            foreach (Orario.ClassiRow classe in orario.Classi.Rows)
            {
                if (classe.Nome == nomeClasse)
                {
                    trovato = classe.idClaPk;
                    break;
                }
            }
            if (trovato == -1)
                throw new Exception("Id della classe non trovato nella visualizzazione orario");

            // Cancella tutto
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            // Mostra colonne
            dataGridView1.Columns.Add("Giorno", "Giorno");
            dataGridView1.Columns.Add("1", "1");
            dataGridView1.Columns.Add("2", "2");
            dataGridView1.Columns.Add("3", "3");
            dataGridView1.Columns.Add("4", "4");
            dataGridView1.Columns.Add("5", "5");

            // Inserisci tutte le righe

            var query =
                from ora in orario.Orari.AsEnumerable()
                where ora.Field<int>("idCla") == trovato
                join classe in orario.Classi.AsEnumerable()
                    on ora.Field<int>("idCla") equals
                        classe.Field<int>("idClaPk")
                join docente in orario.Docenti.AsEnumerable()
                    on ora.Field<int>("idDoc") equals
                        docente.Field<int>("idDocPk")
                join materia in orario.Materie.AsEnumerable()
                    on ora.Field<int>("idMat") equals
                        materia.Field<int>("idMatPk")
                orderby ora.Giorno, ora.Ora
                select new
                {
                    Ora = ora.Ora,
                    Giorno = ora.Giorno,
                    NomeDocente = docente.Nome,
                    CognomeDocente = docente.Cognome,
                    NomeMateria = materia.Nome,
                    IdMateria = materia.idMatPk
                };
            
            int contatoreGiorno = 0;
            int contatoreOra = 1;
            dataGridView1.Rows.Add(6);
            dataGridView1.Rows[contatoreGiorno].Cells[0].Value = contatoreGiorno+1;
            foreach ( var rigaOra in query)
            {
                dataGridView1.Rows[contatoreGiorno].Cells[contatoreOra].Value = rigaOra.NomeMateria;
                dataGridView1.Rows[contatoreGiorno].Cells[contatoreOra].Style.BackColor = colori[rigaOra.IdMateria];
                
                if( ++contatoreOra > 5)
                {
                    contatoreOra = 1;
                    contatoreGiorno++;
                    dataGridView1.Rows[contatoreGiorno].Cells[0].Value = contatoreGiorno + 1;
                }
            }
        }

        private void listaClassi_SelectedIndexChanged(object sender, EventArgs e)
        {
            visualizzaOrario(listaClassi.SelectedItem as String);
        }
    }
}
