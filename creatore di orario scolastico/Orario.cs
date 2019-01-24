using System.Data;

namespace creatore_di_orario_scolastico
{


    partial class Orario
    {
        public void creaDatiEsempio()
        {
            // Materie
            tableMaterie.Rows.Add(0, "Inf");
            tableMaterie.Rows.Add(1, "Sis");
            tableMaterie.Rows.Add(2, "Ita");
            tableMaterie.Rows.Add(3, "Mat");
            tableMaterie.Rows.Add(4, "Ing");
            // Docenti
            tableDocenti.Rows.Add(0, "Max", "Bianchi", 0);
            tableDocenti.Rows.Add(1, "Giu", "Tramontano", 1);
            tableDocenti.Rows.Add(2, "Man", "Marchesini", 2);
            tableDocenti.Rows.Add(3, "Fer", "Ritacco", 3);
            tableDocenti.Rows.Add(4, "Car", "Cattapan", 4);
            //Classi
            tableClassi.Rows.Add(0, "5i1");
            tableClassi.Rows.Add(1, "5i2");
            tableClassi.Rows.Add(2, "5i3");
            tableClassi.Rows.Add(3, "5i4");
            tableClassi.Rows.Add(4, "5i5");
        }
    
        partial class DocentiDataTable
        {
        }
        
        partial class ClassiDataTable
        {
        }
    }
}
