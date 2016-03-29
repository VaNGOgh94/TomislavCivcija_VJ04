using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOTO_aplikacija {
	///<summary>
	/// Klasa Loto koja služi za implementaciju logike aplikacije!
	/// </summary>
	class Loto {
		public List<int> UplaceniBrojevi { get; set; }
		public List<int> DobitniBrojevi { get; set; }
		///<summary>
		/// Konstruktor klase:
		/// </summary>
		public Loto() {
			UplaceniBrojevi = new List<int>();
			DobitniBrojevi = new List<int>();
		}

		public bool UnesiUplaceneBrojeve(List<string>korisnikovUnos) {
			UplaceniBrojevi.Clear();
			foreach (string unos in korisnikovUnos) {
				int broj = 0;
				if(int.TryParse(unos, out broj) == true) 
					if (broj >= 1 && broj <= 39)
						if (UplaceniBrojevi.Contains(broj) == false)
							UplaceniBrojevi.Add(broj);
			}

			if (UplaceniBrojevi.Count == 7)
				return true;
			else return false;
		}

		public void GenerirajDobitnuKombinaciju() {
			DobitniBrojevi.Clear();
			Random gen = new Random();
			while (DobitniBrojevi.Count() < 7) {
				int broj = gen.Next(1, 39);
				if (DobitniBrojevi.Contains(broj) == false)
					DobitniBrojevi.Add(broj);

			}
		}

		public int IzracunajBrojPogodaka() {
			int brojPogodaka = 0;
			foreach (int broj in UplaceniBrojevi) {
				if(DobitniBrojevi.Contains(broj) == true) {
					brojPogodaka++;
				}
			}
			return brojPogodaka;
		}
	}
}
