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

		[TestMethod("0 Kutu - Liste bo�")]
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


		[TestMethod("2 Kutu - B�y�k kutu son eleman")]
		public void TwoBoxTest1()
		{
			var K = new int[] { 2, 4 };
			//B�yle bir durumda tek koli hesaplamal� ve iki kutuyu tek koliye koymal�
			//Bu durumda kolinin boyutu 4x2 = 8 olmal�.
			var expected = 4 * 2;
			var actual = solution.solution(K);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod("2 Kutu - �ki kutu da ayn�")]
		public void TwoBoxTest2()
		{
			var K = new int[] { 2, 2 };
			//B�yle bir durumda tek koli hesaplamal� ve iki kutuyu tek koliye koymal�
			//Bu durumda kolinin boyutu 2x2 = 4 olmal�.
			var expected = 2 * 2;
			var actual = solution.solution(K);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod("3 Kutu - Dizi: 2,1,3")]
		public void ThreeBoxTest1()
		{
			var K = new int[] { 2, 1, 3 };
			//B�yle bir durumda ilk iki eleman bir kutuya konur ve ���nc� eleman 2. kutuya konur.
			//Bu durumda kolinin boyutu 2x2 + 3x1 = 7 olmal�.
			var expected = 2 * 2 + 3 * 1;
			var actual = solution.solution(K);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod("3 Kutu - Dizi: 2,3,1")]
		public void ThreeBoxTest2()
		{
			var K = new int[] { 2, 3, 1 };
			//B�yle bir durumda iki koli hesaplamal� ve son kutuyu ikinci koliye koymal�
			//Bu durumda kolilerin toplam boyutu 3x2 + 1x1 = 6 +1 = 7  olmal�.
			var expected = 3 * 2 + 1 * 1;
			var actual = solution.solution(K);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod("3 Kutu - Dizi: 4,3,1")]
		public void ThreeBoxTest3()
		{
			var K = new int[] { 4, 3, 1 };
			//B�yle bir durumda iki koli hesaplamal� ve ilk iki kutuyu birinci koliye koymal�
			//Bu durumda kolilerin toplam boyutu 4x2 + 1x1 = 8 + 1 = 9  olmal�.
			var expected = 4 * 2 + 1 * 1;
			var actual = solution.solution(K);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod("3 Kutu - Dizi: 4,4,1")]
		public void ThreeBoxTest4()
		{
			var K = new int[] { 4, 4, 1 };
			//B�yle bir durumda iki koli hesaplamal� ve son kutuyu ikinci koliye koymal�
			//Bu durumda kolilerin toplam boyutu 4x2 + 1x1 = 8 + 1 = 9  olmal�.
			var expected = 4 * 2 + 1 * 1;
			var actual = solution.solution(K);
			Assert.AreEqual(expected, actual);
		}


		[TestMethod("3 Kutu - Dizi: 4,4,4")]
		public void ThreeBoxTest5()
		{
			var K = new int[] { 4, 4, 4 };
			//B�yle bir durumda tek koli hesaplamal�
			//Bu durumda kolilerin toplam boyutu 4x3 = 12  olmal�.
			var expected = 4 * 3;
			var actual = solution.solution(K);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod("3 Kutu - Dizi: 4,1,4")]
		public void ThreeBoxTest6()
		{
			var K = new int[] { 4, 1, 4 };
			//B�yle bir durumda tek koli hesaplamal�
			//Bu durumda kolilerin toplam boyutu 4x3 = 12  olmal�.
			var expected = 4 * 3;
			var actual = solution.solution(K);
			Assert.AreEqual(expected, actual);
		}


		[TestMethod("4 Kutu - Dizi: 1,4,1,4")]
		public void FourBoxTest1()
		{
			var K = new int[] { 1, 4, 1, 4 };
			//B�yle bir durumda iki koli hesaplamal�. �lk koliye birinci kutuyu koymal�, di�er 3 kutuyu da ikinici koliye koymal�.
			//Bu durumda kolilerin toplam boyutu 1x1 + 4x3 = 13  olmal�.
			var expected = 1 * 1 + 3 * 4;
			var actual = solution.solution(K);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod("�rnek 1 | K = [3, 2, 4] => 10")]
		public void OrnekTest1()
		{
			var K = new int[] { 3, 2, 4 };
			//K = [3, 2, 4] verildi�inde fonksiyon 10 d�nmelidir. �lk iki kutu 3x2 ebat�ndaki bir koliye son
			// kutu ise 4x1 ebat�ndaki koliye yerle�tirilerek sonu� bulunur.
			//Bu durumda kolilerin toplam boyutu 3x2 + 4x1 = 10  olmal�.
			var expected = 3 * 2 + 4 * 1;
			var actual = solution.solution(K);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod("�rnek 2 | K = [5, 3, 2, 4] => 17")]
		public void OrnekTest2()
		{
			var K = new int[] { 5, 3, 2, 4 };
			// K = [5, 3, 2, 4] verildi�inde fonksiyon 17 d�nmelidir. �lk kutu 5x1 ebat�ndaki bir koliye,
			// sonraki kutular ise 4x3 ebat�ndaki koliye yerle�tirilerek sonu� bulunur.
			//Bu durumda kolilerin toplam boyutu 5x1 + 4x3 = 17  olmal�.
			var expected = 5 * 1 + 4 * 3;
			var actual = solution.solution(K);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod("�rnek 3 | K = [5, 4, 5, 2, 1] => 19")]
		public void OrnekTest3()
		{
			var K = new int[] { 5, 4, 5, 2, 1 };
			// K = [5, 4, 5, 2, 1] verildi�inde fonksiyon 19 d�nmelidir. �lk kutu 5x3 ebat�ndaki bir koliye,
			// sonraki kutular ise 2x2 ebat�ndaki koliye yerle�tirilerek sonu� bulunur.
			//Bu durumda kolilerin toplam boyutu 5x3 + 2x2 = 19  olmal�.
			var expected = 5 * 3 + 2 * 2;
			var actual = solution.solution(K);
			Assert.AreEqual(expected, actual);
		}


		[TestMethod("�rnek 4 | K = [5, 5, 5, 2, 5, 5, 5] => 35")]
		public void OrnekTest4()
		{
			var K = new int[] { 5, 5, 5, 2, 5, 5, 5 };
			// K = [5, 5, 5, 2, 5, 5, 5] verildi�inde fonksiyon 35 d�nmelidir. T�m kutular 5x7 ebat�ndaki bir
			// ebat�ndaki bir koliye yerle�tirilerek sonu� bulunur.
			//Bu durumda kolilerin toplam boyutu 5x7 = 35  olmal�.

			var expected = 5 * 7;
			var actual = solution.solution(K);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod("�rnek 5 | K = [1, 1, 6, 5, 5, 5] => 26")]
		public void OrnekTest5()
		{
			var K = new int[] { 1, 1, 6, 5, 5, 5 };
			// K = [1, 1, 6, 5, 5, 5] verildi�inde fonksiyon 26 d�nmelidir. �lk iki kutu 1x2 ebat�ndaki bir
			// koliye, sonraki kutular ise 6x4 ebat�ndaki koliye yerle�tirilerek sonu� bulunur.
			//Bu durumda kolilerin toplam boyutu 1x2 + 6x4 = 26  olmal�.

			var expected = 1 * 2 + 6 * 4;
			var actual = solution.solution(K);
			Assert.AreEqual(expected, actual);
		}


	}
}