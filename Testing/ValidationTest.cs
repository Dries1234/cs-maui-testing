using gitinder;

namespace Testing
{
    public class ValidationTest
    {
        [Fact]
        public void test()
        {
            var mockRepo = new Repository() { id = "1", description = "test repo", name = "Test", primaryLanguage = new Language() { name = "Typescript" }, stargazerCount = 5, url = "https://github.com/" };
            // description missing
            var mockRepo2 = new Repository() { id = "2", name = "Test", primaryLanguage = new Language() { name = "Typescript" }, stargazerCount = 5, url = "https://github.com/" };

            Assert.True(mockRepo.Validate() && !mockRepo2.Validate());
        }
    }
}