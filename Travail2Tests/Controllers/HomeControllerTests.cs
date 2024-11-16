using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travail2.Controllers;
using Xunit;

namespace Travail2Tests.Controllers
{
    public class HomeControllerTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[] { 5, 2, 3, 1, 4 }, new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[] { 5, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[] { 1 }, new int[] { 1 })]
        public void EnUnSeulTest(int[] avant, int[] apres)
        {
            // Arrange
            var controller = new HomeController();

            // Act
            controller.tri_a_bulle(avant, avant.Length);

            // Assert
            Assert.Equal(apres, avant);
        }



        [Fact]
        public void TriABulle_TableauDejaTrie_AucunChangement()
        {
            // Arrange
            var controller = new HomeController();
            int[] array = { 1, 2, 3, 4, 5 };
            int n = array.Length;

            // Act
            controller.tri_a_bulle(array, n);

            // Assert
            Assert.Equal(new int[] { 1, 2, 3, 4, 5 }, array);
        }

        [Fact]
        public void TriABulle_TableauNonTrie_UnPassage()
        {
            // Arrange
            var controller = new HomeController();
            int[] array = { 5, 2, 3, 1, 4 };
            int n = array.Length;

            // Act
            controller.tri_a_bulle(array, n);

            // Assert
            Assert.Equal(new int[] { 1, 2, 3, 4, 5 }, array);
        }

        [Fact]
        public void TriABulle_TableauNonTrie_PlusieursPassages()
        {
            // Arrange
            var controller = new HomeController();
            int[] array = { 5, 4, 3, 2, 1 };
            int n = array.Length;

            // Act
            controller.tri_a_bulle(array, n);

            // Assert
            Assert.Equal(new int[] { 1, 2, 3, 4, 5 }, array);
        }

        [Fact]
        public void TriABulle_TableauAvecUnElement()
        {
            // Arrange
            var controller = new HomeController();
            int[] array = { 1 };
            int n = array.Length;

            // Act
            controller.tri_a_bulle(array, n);

            // Assert
            Assert.Equal(new int[] { 1 }, array);
        }

    }
}
