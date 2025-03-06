using static System.Console;

struct Libro {
	public string Titolo;
	public string Autore;
	public string Categoria;
	public int Id;
	public double Prezzo;
	
	public Libro(string titolo, string autore, string categoria, int id, double price) {
		Titolo = titolo;
		Autore = autore;
		Categoria = categoria;
		Id = id;
		Prezzo = price;
	}
	
	void Stampa (){
		WriteLine();
		WriteLine($"Libro: \"{Titolo}\" di {Autore}");
		WriteLine($"ID: {Id} - Prezzo: {Prezzo} - Categoria: {Categoria}");
	}
	
	void CambiaPrezzo (double nuovoPrezzo) {
		Prezzo = nuovoPrezzo;
	}
}

public class Program
{
	static Libro[] libri = new Libro[20]; //le stringhe vanno a null (perchè puntatori/riferimento) se non specificato e gli int a 0 (value default)
	static Libro[] libriacquistati = new Libro[20];
	
	static void InizializzaLibri () {
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
	
	static void Main()
	{
		InizializzaLibri();
		while (true) {
			do {
				....
		}
	}
	
	static void AcquistaLibro (int id)
	{
		
	}
}
