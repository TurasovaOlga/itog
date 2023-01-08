
		// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
		// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
		// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
		// лучше обойтись исключительно массивами.
				
		string[] arr1 = {"Hello", "2", "planet", "'-)"};
		string[] arr2 = {"2123", "7632", "-4", "computer"};
		string[] arr3 = {"Russia", "Tatisheva", "Astrahan"};
		
		int MAX_WORD_LENGTH = 3;
		
		string[] GetShortWordsArray(string[] array)
		{
			int length = array.Length;			
			string[] result = new string[length];
			int count = 0;
			
			for (int i = 0; i < length; i++)
			{
				if(array[i].Length <= MAX_WORD_LENGTH)
				{
					result[count] = array[i];
					count++;
				}
			}
			Array.Resize(ref result, count);
			
			return result;
		}
		
		void PrintArray(string[] array)
		{
			if(array.Length == 0)
			{
				Console.WriteLine("Пустой массив");
			}
			else
			{
				Array.ForEach(array, (str) => Console.Write($"{str} "));
				Console.WriteLine();
			}
		}
		
		void PrintTask(string[] array)
		{
			Console.WriteLine("Исходный массив:");
			PrintArray(array);
			string[] shortArray = GetShortWordsArray(array);
			Console.WriteLine($"Результат массива (слова меньше или равны {MAX_WORD_LENGTH} символа)");
			PrintArray(shortArray);
			Console.WriteLine();
		}
		
		PrintTask(arr1);
		PrintTask(arr2);
		PrintTask(arr3);

