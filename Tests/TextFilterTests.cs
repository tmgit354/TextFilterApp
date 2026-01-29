using TextFilterApp;


namespace Tests
{
    [TestFixture]
    public class TextFilterTests
    {
        [Test]
        public void Test_RemovesWordsWithVowelInMiddle()
        {
            var vowelFilter = new TextFilterVowel();
            string input = "currently rather clean what";
            string result = vowelFilter.Apply(input);
            Assert.AreEqual("rather", result);
        }

        [Test]
        public void Test_RemovesWordsWithLessThanThreeLetters()
        {
            var lengthFilter = new TextFilterLength();
            string input = "the it image";
            string result = lengthFilter.Apply(input);
            Assert.AreEqual("the image", result);
        }

        [Test]
        public void Test_RemovesWordsWithT()
        {
            var letterFilter = new TextFilterLetter();
            string input = "the test better word";
            string result = letterFilter.Apply(input);
            Assert.AreEqual("word", result);
        }

        [Test]
        public void TestApplyFilters_ShouldApplyAllFilters()
        {
            var filters = new List<ITextFilter>
            {
                new TextFilterVowel(),
                new TextFilterLength(),
                new TextFilterLetter()
            };
            var app = new TextFilter(filters);
            string input = "image once better";
            string result = app.ApplyFilters(input);
            Assert.AreEqual("once", result); // After all filters
        }
    }
}