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
        }

        // Mostra l'orario sulla Windows Form
        private void visualizzaOrario()
        {
            // Mostra colonne
            dataGridView1.Columns.Add("Ora", "Ora");
            dataGridView1.Columns.Add("Lun", "Lun");
            dataGridView1.Columns.Add("Mar", "Mar");
            dataGridView1.Columns.Add("Mer", "Mer");
            dataGridView1.Columns.Add("Gio", "Gio");
            dataGridView1.Columns.Add("Ven", "Ven");

            // Inserisci tutte le righe
            
        }
        
    }
}
