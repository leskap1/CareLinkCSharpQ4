using System;

public class UnitTest {

  public static void TestValidFindCase()
  {
      Solution s = new Solution();
      int answer = s.FirstIndexOf("hello", "ll");
      Assert(answer, 2, "The first index of 'll' in 'hello' is index 2.");
  }
  
  public static void TestMultipleFindFirstCase()
  {
      Solution s = new Solution();
      int answer = s.FirstIndexOf("dog in bog", "og");
      Assert(answer, 1, "The first index of 'og' in 'dog in bog' is index 1.");

  }

  public static void TestNotFoundCase()
  {
      Solution s = new Solution();
      int answer = s.FirstIndexOf("aaaaa", "bba");
      Assert(answer, -1, "The first index of 'bba' in 'aaaaa' is index -1, or not found.");
  }
  
  public static void TestNoSearchCase()
  {
      Solution s = new Solution();
      int answer = s.FirstIndexOf("abcde", "");
      Assert(answer, 0, "The first index of empty string '' in 'abcde' is index 0, or start of string.");
  }
 
  public static void Assert(int value, int correctValue, string testcase) 
  {
      if (value == correctValue)
      {
         Console.WriteLine("Pass: " + testcase);
      }
      else
      {
         Console.WriteLine("Fail: " + testcase);
      }
  }

  public static void Assert(bool isTrue, string testcase) 
  {
      if (isTrue)
      {
         Console.WriteLine("Pass: " + testcase);
      }
      else
      {
         Console.WriteLine("Fail: " + testcase);
      }
  }
}