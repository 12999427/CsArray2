using static System.Console;

struct Libro {
    public string Titolo;
    public string Autore;
    public string Categoria;
    public int Id;
    public double Prezzo;

    public Libro(string titolo, string autore, string categoria, int id, double prezzo) {
        Titolo = titolo;
        Autore = autore;
        Categoria = categoria;
        Id = id;
        Prezzo = prezzo;
    }

    public void Stampa() {
        WriteLine($"Libro: \"{Titolo}\" di {Autore}");
        WriteLine($"ID: {Id} - Prezzo: {Prezzo:F2}€ - Categoria: {Categoria}");
        WriteLine();
    }
	
	public Libro Copia() {
		return new Libro(Titolo, Autore, Categoria, Id, Prezzo);
	}
}

public class Program {
    static void InizializzaLibri(Libro[] libri) { //usa id 0 per invalido
        libri[0] = new Libro("Il Nome della Rosa", "Umberto Eco", "Storico", 1, 15.50);
        libri[1] = new Libro("1984", "George Orwell", "Distopico", 2, 10.99);
        libri[2] = new Libro("Il Grande Gatsby", "F. Scott Fitzgerald", "Narrativa", 3, 12.80);
        libri[3] = new Libro("La Divina Commedia", "Dante Alighieri", "Classico", 4, 8.30);
        libri[4] = new Libro("Orgoglio e Pregiudizio", "Jane Austen", "Romantico", 5, 9.50);
        libri[5] = new Libro("Moby Dick", "Herman Melville", "Avventura", 6, 11.20);
        libri[6] = new Libro("Il Processo", "Franz Kafka", "Psicologico", 7, 13.00);
        libri[7] = new Libro("Don Chisciotte", "Miguel de Cervantes", "Classico", 8, 14.10);
        libri[8] = new Libro("Le Metamorfosi", "Franz Kafka", "Surrealismo", 9, 6.90);
        libri[9] = new Libro("Cime Tempestose", "Emily Brontë", "Gotico", 10, 10.00);
        libri[10] = new Libro("Ulisse", "James Joyce", "Moderno", 11, 18.00);
    }

	static void Main() {
		int la = 0; //contatore x larray di libri acquistati
        Libro[] libri = new Libro[20]; //le stringhe vanno a null (perchè puntatori/riferimento) se non specificato e gli int a 0 (value default)
		Libro[] libriacquistati = new Libro[20];
        InizializzaLibri(libri);

        while (true) {
            WriteLine("acquista/prezzo/visualizza/aggiungi/acquistati/esci");
            string risposta = ReadLine();

            if (risposta == "acquista") {
                int id = GetID();
                int indice = Ricerca(libri, id);
                if (indice != -1) {
					libriacquistati[la++] = libri[indice].Copia();
                    libri[indice] = new Libro();
                    WriteLine("Libro acquistato!");
                } else {
                    WriteLine("Libro non trovato.");
                }
			} else if (risposta == "acquistati") {
				printAcquistati(libriacquistati);
				
            } else if (risposta == "prezzo") {
                int id = GetID();
                int indice = Ricerca(libri, id);
                if (indice != -1) {
                    CambiaPrezzo(ref libri[indice]);
                } else {
                    WriteLine("Libro non trovato.");
                }

            } else if (risposta == "visualizza") {
                Stampa(libri);

            } else if (risposta == "aggiungi") {
                AggiungiLibro(libri);

            } else if (risposta == "esci") {
                break;

            } else {
                WriteLine("Comando errato.");
            }
        }
    }
	
	static void printAcquistati (Libro[] libri) {
		double prezzoTot = 0.0;
		for (int i = 0; i<libri.Length; i++){
			Libro libro = libri[i];
			if (libro.Id != 0){
					libro.Stampa();
					prezzoTot += libro.Prezzo;
			}
		}
		WriteLine("\nPrezzo Acquisti: " + prezzoTot);
	}
	
    static int GetID() {
        int id;
        do {
            WriteLine("Inserisci ID:");
        } while (!int.TryParse(ReadLine(), out id) || id <= 0);
        return id;
    }

    static int Ricerca(Libro[] libri, int id) {
        for (int i = 0; i < libri.Length; i++) {
            if (libri[i].Id == id) {
                return i;
            }
        }
        return -1;
    }

    static void CambiaPrezzo(ref Libro libro) {
        double nuovoPrezzo;
        do {
            Write("Inserisci nuovo prezzo: ");
        } while (!double.TryParse(ReadLine(), out nuovoPrezzo) || nuovoPrezzo <= 0);

        libro.Prezzo = nuovoPrezzo;
        WriteLine("Prezzo aggiornato!");
    }

    static void Stampa(Libro[] libri) {
        foreach (var libro in libri) {
            if (libro.Id != 0) libro.Stampa();
        }
    }

    static void AggiungiLibro(Libro[] libri) {
        for (int i = 0; i < libri.Length; i++) {
            if (libri[i].Id == 0) { 
                Write("Titolo: ");
                string titolo = ReadLine();
                Write("Autore: ");
                string autore = ReadLine();
                Write("Categoria: ");
                string categoria = ReadLine();
                int id = GetID();
                double prezzo;
                do {
                    Write("Prezzo: ");
                } while (!double.TryParse(ReadLine(), out prezzo) || prezzo <= 0);

                libri[i] = new Libro(titolo, autore, categoria, id, prezzo);
                WriteLine("Libro aggiunto con successo!");
                return;
            }
        }
        WriteLine("Spazio esaurito per nuovi libri.");
    }
}
