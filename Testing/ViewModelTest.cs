using gitinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class ViewModelTest
    {
        [Fact]
        public void test()
        {
            var mockViewModel = new MockViewModel()
            {
                repos = new System.Collections.ObjectModel.ObservableCollection<Repository> { new Repository() }
            };

            // mock onReject behavior
            mockViewModel.OnReject();

            // get repos count
            var count = mockViewModel.repos.Count;
            //should be 0 now
            Assert.Equal(0, count);
        }
    }
}
