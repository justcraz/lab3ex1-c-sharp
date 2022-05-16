using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class GFG
{

	static bool isAlphabet(char ch)
	{
		if (ch >= 'a' && ch <= 'z')
			return true;
		if (ch >= 'A' && ch <= 'Z')
			return true;

		return false;
	}


	static string remConsonants(string str)
	{
		char[] vowels = { 'a', 'e', 'i', 'o', 'u',
					'A', 'E', 'I', 'O', 'U' };

		string sb = "";

		for (int i = 0; i < str.Length; i++)
		{
			bool present = false;
			for (int j = 0; j < vowels.Length; j++)
			{
				if (str[i] == vowels[j])
				{
					present = true;
					break;
				}
			}

			if (!isAlphabet(str[i]) || present)
			{
				sb += str[i];
			}
		}
		return sb;
	}


	
	static bool isPalindrome(string str)
	{
		int i = 0, j = str.Length - 1;

		while (i < j)
		{

			if (str[i++] != str[j--])
				return false;
		}

		
		return true;
	}

	
	static String removePalinWords(string str)
	{

		string final_str = "", word = "";

		
		str = str + " ";
		int n = str.Length;

		
		for (int i = 0; i < n; i++)
		{

			
			if (str[i] != ' ')
				word = word + str[i];
			else
			{

				
				if (!(isPalindrome(word)))
					final_str += word + " ";

				
				word = "";
			}
		}

		
		return final_str;
	}

	static public void MainProgram()
	{
		// Ведення речення
		Console.Write("\n\n Ведiть ваше речення: ");
		string text = CheckIfNotNum();
		Console.WriteLine(removePalinWords(text));
		Console.WriteLine(remConsonants(text));

	}

	static public string CheckIfNotNum()
	{
		double num = 0;
		while (true)
		{

			var input = Console.ReadLine();

			if (!double.TryParse(input, out num) && num < ' ')
			{
				// Якщо було веденно слова то буде закінчення циклу
				return input;
			}
			else
			{
				// Якщо було веденно число буде повернення циклу
				Console.WriteLine(" Ведено невірне значення. Спробуйте знову !");
				Console.Write(" Ваша значення: ");
			}
		}
	}

	public static void Main()
	{
		MainProgram();

	}
}

