using System;
using System.Collections.Generic;
using System.Data;

namespace creatore_di_orario_scolastico
{
    partial class Orario
    {
        static Random randomizzatore = new Random();

        private int idIncrementaleOrario = 0;

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

        // Algoritmo di creazione dell'orario
        public void creaOrario()
        {
            //tableOrari.Rows.Add(idIncrementaleOrario++, 1, 0, 0, 0);

            /*
             * Crea un orario scolastico.
             * Distribuisci i docenti disponibili in ogni classe.
             * Poi passa all'ora successiva
             */

            List<int> listaClassi = new List<int>();
            foreach (ClassiRow classe in tableClassi.Rows)
                listaClassi.Add(classe.idClaPk);

            int classeRandom;

            for (int giorno = 1; giorno <= 5; giorno++)
            {
                for (int ora = 1; ora <= 5; ora++)
                {
                    // Genera la lista con tutte le classi
                    List<int> listaPoolClassi = new List<int>(listaClassi);


                    for (int docente = 0; docente < 5; docente++)
                    {
                        // Lista con tutti i flag delle classi
                        List<bool> flagPoolClassi = new List<bool>();
                        for (int i = 0; i < listaPoolClassi.Count(); i++)
                            flagPoolClassi.Add(true);

                        bool classeAccettata = false;

                        do
                        {
                            // Scelgo una classe a caso
                            classeRandom = rand.Next(listaPoolClassi.Count);

                            // Ottiene tutti gli orari di quella classe in quel giorno per quel docente
                            var query1 =
                                from oraQuery in this.tableOre.AsEnumerable()
                                where oraQuery.Field<int>("Id_classe") == listaPoolClassi[classeRandom]
                                && oraQuery.Field<string>("Giorno") == giorno
                                && oraQuery.Field<int>("Id_docente") == docente
                                let rigaQuery1 = new
                                {
                                    Ora = oraQuery.Numero,
                                    IdDocente = oraQuery.Id_docente
                                }
                                select rigaQuery1;

                            switch (query1.Count())
                            {
                                case 0:
                                    // Accettato
                                    classeAccettata = true;
                                    break;
                                case 1:
                                    // Controlla che sia all'ora precedente, se non lo è rifiuta
                                    var ultimaOra = query1.Last();
                                    classeAccettata = (ultimaOra.Ora == ora - 1);
                                    break;
                                default:
                                    // Rifiutato
                                    break;
                            }
                            flagPoolClassi[classeRandom] = classeAccettata;

                            // Controlla che il pool sia maggiore di 1
                            if (!classeAccettata)
                            {
                                // Controlla se i flag del pool sono tutti falsi, se sono falsi significa che nessuna classe è accettabile
                                if( !flagPoolClassi.Contains(true))
                                {
                                    throw new Exception("Riga impossibile da creare!");
                                }
                            }
                        } while (!classeAccettata);

                        // Assegno l'ora
                        this.Ore.Rows.Add(idOre++, giorno, ora, docente, listaPoolClassi[classeRandom]);
                        listaPoolClassi.RemoveAt(classeRandom);
                    }
                }
            }

        }

        // Cerca l'id della materia partendo dal docente
        private int ottieniMateriaDaDocente(int idDocente)
        {
            int idTrovato = -1;
            foreach (DocentiRow docente in tableDocenti)
                if (docente.idDocPk == idDocente)
                {
                    idTrovato = docente.idMat;
                    break;
                }

            if (idTrovato == -1)
                throw new Exception("Eccezione!");

            return idTrovato;
        }

        partial class DocentiDataTable
        {
        }

        partial class ClassiDataTable
        {
        }
    }
}
