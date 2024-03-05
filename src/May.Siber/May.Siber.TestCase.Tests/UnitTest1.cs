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
			var K = new int[] {1, 4, 1, 4 };
			//B�yle bir durumda iki koli hesaplamal�. �lk koliye birinci kutuyu koymal�, di�er 3 kutuyu da ikinici koliye koymal�.
			//Bu durumda kolilerin toplam boyutu 1x1 + 4x3 = 13  olmal�.
			var expected = 1*1 + 3 * 4;
			var actual = solution.solution(K);
			Assert.AreEqual(expected, actual);
		}
	}
}