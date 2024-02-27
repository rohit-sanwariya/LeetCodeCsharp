 
namespace Logical;

public class Problem2108FindFirstPallindromicString
{

    public string FirstPalindrome(string[] words)
    {
        foreach (string word in words)
        {
            if (isPallindrom(word))
            {
                return word;
            }
        }
        return "";
    }

    public bool isPallindrom(string word)
    {
        int i, j;
        i = 0;
        j = word.Length - 1;
        while (i < j)
        {
            if (word[i] != word[j])
            {
                return false;
            }
            i++;
            j--;
        }
        return true;
    }
}
