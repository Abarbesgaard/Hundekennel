using Hundekennel;
using Hundekennel.ViewModel;
namespace TestProject
{
    [TestClass]
    public class ViewModelTesting
    {
        /// <summary>
        /// Tester om hvorvidt at der bliver lavet en Collection View Model
        /// </summary>
        [TestMethod]
        public void IsCollectionViewModelCreated()
        {
            // ARRANGE
            CollectionViewModel _collectionVM = new CollectionViewModel();
            
            // ACT
            
            // ASSERT
            Assert.IsNotNull( _collectionVM, "Collection View Model blev ikke oprettet korrekt" );
        }
        /// <summary>
        /// Tester om hvorvidt at der bliver lavet en Home View Model
        /// </summary>
        [TestMethod]
        public void IsHomeViewModelCreated()
        {
            // ARRANGE
            HomeViewModel _homeViewModel = new HomeViewModel();

            // ACT
            // ASSERT
            Assert.IsNotNull(_homeViewModel, "Home view Model blev ikke oprettet korrekt");
        }
        /// <summary>
        /// Tester om hvorvidt at der bliver lavet en Main View Model
        /// </summary>
        [TestMethod]
        public void IsMainViewModelCreated()
        {
            // ARRANGE
            MainViewModel mainViewModel = new MainViewModel();


            // ACT
            // ASSERT
            Assert.IsNotNull(mainViewModel, "Home view Model blev ikke oprettet korrekt");
        }
    }
}