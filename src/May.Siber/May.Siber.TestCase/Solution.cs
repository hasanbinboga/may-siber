namespace May.Siber.TestCase
{
	public class Solution
	{

		public int solution(int[] K)
		{
			//Eğer kutu yoksa 
			if (K.Length == 0) return 0;

			//Eğer 1 kutu varsa
			if (K.Length == 1) return K[0];

			//Eğer 2 kutu varsa
			if(K.Length == 2)
			{
				if (K[0] > K[1]) return K[0]*2;

				return K[1]*2;
			}


			//İlk olarak en uzun kutunun konumunu bul
			var firstLongestBoxId = GetLongestBox(K, out int longestBoxHeight);

			//İlk Kolinin alanı, en uzun koliyi içerecek şekilde hesaplanır.
			var firstPackageSize = longestBoxHeight * (firstLongestBoxId + 1);

			//En uzun koliden sonraki kutuları ikinci koliye yerleştirebiliriz. 
			//Bunun için kalan kutuları yeni bir diziye alıp en uzun olanı hesaplamamız yeterli olacaktır.
			var secondPackageWidth = K.Length - firstLongestBoxId - 1;
			var secondPackageItems = new List<int>(secondPackageWidth);
			if (K.Length - 1 > firstLongestBoxId)
			{
				for (var i = firstLongestBoxId+1; i < K.Length; i++)
				{
					secondPackageItems.Add(K[i]);
				}

			}


			var L = secondPackageItems.ToArray();
			GetLongestBox(L, out longestBoxHeight);

			var secondPackageSize = longestBoxHeight * secondPackageWidth;

			return firstPackageSize + secondPackageSize;
		}

		private int GetLongestBox(int[] K, out int maxSize)
		{
			var maxIdx = 0;
			maxSize = int.MinValue;
			for (int i = 0; i < K.Length; i++)
			{
				if (K[i] >= maxSize)
				{
					maxIdx = i;
					maxSize = K[i];
				}
			}
			return maxIdx;
		}

	}
}
