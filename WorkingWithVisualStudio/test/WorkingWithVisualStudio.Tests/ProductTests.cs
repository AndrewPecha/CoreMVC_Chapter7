﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkingWithVisualStudio.Models;
using Xunit;

namespace WorkingWithVisualStudio.Tests
{
    public class ProductTests
    {
        [Fact]
        public void CanChangeProductName()
        {
            //Arrange
            var p = new Product { Name = "Test", Price = 100m };

            //Act
            p.Name = "New Name";

            //Assert
            Assert.Equal("New Name", p.Name);
        }

        [Fact]
        public void CanChangeProductPrice()
        {
            //Arrange
            var p = new Product { Name = "Test", Price = 100m };

            //Act
            p.Price = 300m;

            //Assert
            Assert.Equal(300m, p.Price);
        }
    }
}
