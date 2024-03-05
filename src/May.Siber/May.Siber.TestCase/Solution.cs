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
			if (K.Length == 2)
			{
				if (K[0] > K[1]) return K[0] * 2;

				return K[1] * 2;
			}

			var minimumPackageArea = int.MaxValue;
			//İlk kolideki son kutunun indeksi i olsun;
			for (int i = 0; i < K.Length; i++)
			{
				//İlk olarak en uzun kutunun konumunu bul
				var firstPackageItems = K.Take(i + 1).ToArray();


				var longestBoxLength = GetLongestBoxLength(firstPackageItems);

				var firstPackageWidth = firstPackageItems.Length;

				//ilk kutunun boyutunu hesapla
				var firstPackageSize = longestBoxLength * firstPackageWidth;

				//En uzun koliden sonraki kutuları ikinci koliye yerleştirebiliriz. 
				//Bunun için kalan kutuları yeni bir diziye alıp en uzun olanı hesaplamamız yeterli olacaktır.

				//Eğer ilk koli, tüm kutuları içermiyorsa
				var secondPackageSize = 0;
				if (firstPackageItems.Length < K.Length)
				{

					var secondPackageItems = K.Skip(i + 1).Take(K.Length - firstPackageItems.Length).ToArray();
					longestBoxLength = GetLongestBoxLength(secondPackageItems);
					var secondPackageWidth = secondPackageItems.Length;
					secondPackageSize = longestBoxLength * secondPackageWidth;
				}
				var packageArea = firstPackageSize + secondPackageSize;

				if (minimumPackageArea > packageArea)
				{
					minimumPackageArea = packageArea;
				} 
			} 
			return minimumPackageArea;
		}

		private int GetLongestBoxLength(int[] K)
		{
			var maxSize = int.MinValue;
			for (int i = 0; i < K.Length; i++)
			{
				if (K[i] >= maxSize)
				{
					maxSize = K[i];
				}
			}
			return maxSize;
		}

	}
}
