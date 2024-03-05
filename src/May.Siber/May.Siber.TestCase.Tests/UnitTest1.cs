namespace May.Siber.TestCase.Tests
{
	[TestClass]
	public class UnitTest1
	{
		private Solution solution;
		public UnitTest1()
		{
			solution = new Solution();
		}

		[TestMethod("0 Kutu - Liste boþ")]
		public void NoItemTest()
		{
			var K = new int[0];
			var expected = 0;
			var actual = solution.solution(K);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod("1 Kutu - Listede sadece bir kutu var")]
		public void OneBoxTest()
		{
			var K = new int[] { 4 };
			var expected = 4;
			var actual = solution.solution(K);
			Assert.AreEqual(expected, actual);
		}


		[TestMethod("2 Kutu - Büyük kutu son eleman")]
		public void TwoBoxTest1()
		{
			var K = new int[] { 2, 4 };
			//Böyle bir durumda tek koli hesaplamalý ve iki kutuyu tek koliye koymalý
			//Bu durumda kolinin boyutu 4x2 = 8 olmalý.
			var expected = 4 * 2;
			var actual = solution.solution(K);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod("2 Kutu - Ýki kutu da ayný")]
		public void TwoBoxTest2()
		{
			var K = new int[] { 2, 2 };
			//Böyle bir durumda tek koli hesaplamalý ve iki kutuyu tek koliye koymalý
			//Bu durumda kolinin boyutu 2x2 = 4 olmalý.
			var expected = 2 * 2;
			var actual = solution.solution(K);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod("3 Kutu - Dizi: 2,1,3")]
		public void ThreeBoxTest1()
		{
			var K = new int[] { 2, 1, 3 };
			//Böyle bir durumda ilk iki eleman bir kutuya konur ve üçüncü eleman 2. kutuya konur.
			//Bu durumda kolinin boyutu 2x2 + 3x1 = 7 olmalý.
			var expected = 2 * 2 + 3 * 1;
			var actual = solution.solution(K);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod("3 Kutu - Dizi: 2,3,1")]
		public void ThreeBoxTest2()
		{
			var K = new int[] { 2, 3, 1 };
			//Böyle bir durumda iki koli hesaplamalý ve son kutuyu ikinci koliye koymalý
			//Bu durumda kolilerin toplam boyutu 3x2 + 1x1 = 6 +1 = 7  olmalý.
			var expected = 3 * 2 + 1 * 1;
			var actual = solution.solution(K);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod("3 Kutu - Dizi: 4,3,1")]
		public void ThreeBoxTest3()
		{
			var K = new int[] { 4, 3, 1 };
			//Böyle bir durumda iki koli hesaplamalý ve ilk iki kutuyu birinci koliye koymalý
			//Bu durumda kolilerin toplam boyutu 4x2 + 1x1 = 8 + 1 = 9  olmalý.
			var expected = 4 * 2 + 1 * 1;
			var actual = solution.solution(K);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod("3 Kutu - Dizi: 4,4,1")]
		public void ThreeBoxTest4()
		{
			var K = new int[] { 4, 4, 1 };
			//Böyle bir durumda iki koli hesaplamalý ve son kutuyu ikinci koliye koymalý
			//Bu durumda kolilerin toplam boyutu 4x2 + 1x1 = 8 + 1 = 9  olmalý.
			var expected = 4 * 2 + 1 * 1;
			var actual = solution.solution(K);
			Assert.AreEqual(expected, actual);
		}


		[TestMethod("3 Kutu - Dizi: 4,4,4")]
		public void ThreeBoxTest5()
		{
			var K = new int[] { 4, 4, 4 };
			//Böyle bir durumda tek koli hesaplamalý
			//Bu durumda kolilerin toplam boyutu 4x3 = 12  olmalý.
			var expected = 4 * 3;
			var actual = solution.solution(K);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod("3 Kutu - Dizi: 4,1,4")]
		public void ThreeBoxTest6()
		{
			var K = new int[] { 4, 1, 4 };
			//Böyle bir durumda tek koli hesaplamalý
			//Bu durumda kolilerin toplam boyutu 4x3 = 12  olmalý.
			var expected = 4 * 3;
			var actual = solution.solution(K);
			Assert.AreEqual(expected, actual);
		}


		[TestMethod("4 Kutu - Dizi: 1,4,1,4")]
		public void FourBoxTest1()
		{
			var K = new int[] { 1, 4, 1, 4 };
			//Böyle bir durumda iki koli hesaplamalý. Ýlk koliye birinci kutuyu koymalý, diðer 3 kutuyu da ikinici koliye koymalý.
			//Bu durumda kolilerin toplam boyutu 1x1 + 4x3 = 13  olmalý.
			var expected = 1 * 1 + 3 * 4;
			var actual = solution.solution(K);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod("Örnek 1 | K = [3, 2, 4] => 10")]
		public void OrnekTest1()
		{
			var K = new int[] { 3, 2, 4 };
			//K = [3, 2, 4] verildiðinde fonksiyon 10 dönmelidir. Ýlk iki kutu 3x2 ebatýndaki bir koliye son
			// kutu ise 4x1 ebatýndaki koliye yerleþtirilerek sonuç bulunur.
			//Bu durumda kolilerin toplam boyutu 3x2 + 4x1 = 10  olmalý.
			var expected = 3 * 2 + 4 * 1;
			var actual = solution.solution(K);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod("Örnek 2 | K = [5, 3, 2, 4] => 17")]
		public void OrnekTest2()
		{
			var K = new int[] { 5, 3, 2, 4 };
			// K = [5, 3, 2, 4] verildiðinde fonksiyon 17 dönmelidir. Ýlk kutu 5x1 ebatýndaki bir koliye,
			// sonraki kutular ise 4x3 ebatýndaki koliye yerleþtirilerek sonuç bulunur.
			//Bu durumda kolilerin toplam boyutu 5x1 + 4x3 = 17  olmalý.
			var expected = 5 * 1 + 4 * 3;
			var actual = solution.solution(K);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod("Örnek 3 | K = [5, 4, 5, 2, 1] => 19")]
		public void OrnekTest3()
		{
			var K = new int[] { 5, 4, 5, 2, 1 };
			// K = [5, 4, 5, 2, 1] verildiðinde fonksiyon 19 dönmelidir. Ýlk kutu 5x3 ebatýndaki bir koliye,
			// sonraki kutular ise 2x2 ebatýndaki koliye yerleþtirilerek sonuç bulunur.
			//Bu durumda kolilerin toplam boyutu 5x3 + 2x2 = 19  olmalý.
			var expected = 5 * 3 + 2 * 2;
			var actual = solution.solution(K);
			Assert.AreEqual(expected, actual);
		}


		[TestMethod("Örnek 4 | K = [5, 5, 5, 2, 5, 5, 5] => 35")]
		public void OrnekTest4()
		{
			var K = new int[] { 5, 5, 5, 2, 5, 5, 5 };
			// K = [5, 5, 5, 2, 5, 5, 5] verildiðinde fonksiyon 35 dönmelidir. Tüm kutular 5x7 ebatýndaki bir
			// ebatýndaki bir koliye yerleþtirilerek sonuç bulunur.
			//Bu durumda kolilerin toplam boyutu 5x7 = 35  olmalý.

			var expected = 5 * 7;
			var actual = solution.solution(K);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod("Örnek 5 | K = [1, 1, 6, 5, 5, 5] => 26")]
		public void OrnekTest5()
		{
			var K = new int[] { 1, 1, 6, 5, 5, 5 };
			// K = [1, 1, 6, 5, 5, 5] verildiðinde fonksiyon 26 dönmelidir. Ýlk iki kutu 1x2 ebatýndaki bir
			// koliye, sonraki kutular ise 6x4 ebatýndaki koliye yerleþtirilerek sonuç bulunur.
			//Bu durumda kolilerin toplam boyutu 1x2 + 6x4 = 26  olmalý.

			var expected = 1 * 2 + 6 * 4;
			var actual = solution.solution(K);
			Assert.AreEqual(expected, actual);
		}


	}
}