// using Microsoft.VisualStudio.TestTools.UnitTesting;
// using System;
// using ScrableScore.Models;

// namespace ScrableScore.Test
// {
//   [TestClass]
//   public class ScoreTests
//   {
//     [TestMethod]
//     public void SplitWord_SplitsWordIntoList_CharArray()
//     {
//       char[] expected = new char[] { 't', 'e', 's', 't' };
//       CollectionAssert.AreEqual(expected, Score.SplitWord("test"));
//     }

//     [TestMethod]
//     public void ValueScore_CalculatesScoreForString_int()
//     {
//       char[] test = new char[] { 't', 'e', 's', 't' };
//       int score = 4;
//       Assert.AreEqual(score, Score.ValueScore(test));
//     }
//   }
// }