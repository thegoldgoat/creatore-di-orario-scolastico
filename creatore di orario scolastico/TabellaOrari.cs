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
            dataGridView1.Columns.Add("Ora", "Ora");
            dataGridView1.Columns.Add("Lun", "Lun");
            dataGridView1.Columns.Add("Mar", "Mar");
            dataGridView1.Columns.Add("Mer", "Mer");
            dataGridView1.Columns.Add("Gio", "Gio");
            dataGridView1.Columns.Add("Ven", "Ven");

            // Inserisci tutte le righe
            
        }

        private void listaClassi_SelectedIndexChanged(object sender, EventArgs e)
        {
            visualizzaOrario(listaClassi.SelectedText);
        }
    }
}
