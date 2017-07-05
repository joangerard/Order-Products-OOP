using Container;
using NUnit.Framework;
using OrderProducts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProducts.Test.Shared
{
    [TestFixture]
    class InterpreterTest
    {
        IPropertyComparerFactory<ProductModel> _productPropertyComparerFactory;
        Interpreter<ProductModel> _productInterpreter;

        [SetUp]
        public void SetUp(){
            this._productPropertyComparerFactory = new FactoryProductPropertyComparer();
            this._productInterpreter = new Interpreter<ProductModel>(_productPropertyComparerFactory,"1-A");
        }

        [Test]
        public void Translate_should_return_one_comparer()
        {
            List<IComparer<ProductModel>> comparers = _productInterpreter.Translate("1");
            Assert.AreEqual(comparers.Count(), 1);
            Assert.AreEqual(comparers[0].GetType(), typeof(ProductCodeComparer));
        }

        [Test]
        public void Translate_should_return_two_comparers()
        {
            List<IComparer<ProductModel>> comparers = _productInterpreter.Translate("2,1");
            Assert.AreEqual(comparers.Count(), 2);
            Assert.AreEqual(comparers[0].GetType(), typeof(ProductNameComparer));
            Assert.AreEqual(comparers[1].GetType(), typeof(ProductCodeComparer));
        }

        [Test]
        public void Translate_should_return_three_comparers()
        {
            List<IComparer<ProductModel>> comparers = _productInterpreter.Translate("2,1,3");
            Assert.AreEqual(comparers.Count(), 3);
            Assert.AreEqual(comparers[0].GetType(), typeof(ProductNameComparer));
            Assert.AreEqual(comparers[1].GetType(), typeof(ProductCodeComparer));
            Assert.AreEqual(comparers[2].GetType(), typeof(ProductStockComparer));
        }

        [Test]
        public void Translate_should_return_four_comparers()
        {
            List<IComparer<ProductModel>> comparers = _productInterpreter.Translate("2,1,3,4");
            Assert.AreEqual(comparers.Count(), 4);
            Assert.AreEqual(comparers[0].GetType(), typeof(ProductNameComparer));
            Assert.AreEqual(comparers[1].GetType(), typeof(ProductCodeComparer));
            Assert.AreEqual(comparers[2].GetType(), typeof(ProductStockComparer));
            Assert.AreEqual(comparers[3].GetType(), typeof(ProductExpirationDateComparer));
        }

        [Test]
        public void Translate_should_return_two_comparers_and_order_is_important()
        {
            List<IComparer<ProductModel>> comparers = _productInterpreter.Translate("2,1,3");
            Assert.AreEqual(comparers.Count(), 3);
            Assert.AreEqual(comparers[0].GetType(), typeof(ProductNameComparer));
            Assert.AreEqual(comparers[1].GetType(), typeof(ProductCodeComparer));
            Assert.AreEqual(comparers[2].GetType(), typeof(ProductStockComparer));

            comparers = _productInterpreter.Translate("3,1,2");
            Assert.AreEqual(comparers.Count(), 3);
            Assert.AreEqual(comparers[0].GetType(), typeof(ProductStockComparer));
            Assert.AreEqual(comparers[1].GetType(), typeof(ProductCodeComparer));
            Assert.AreEqual(comparers[2].GetType(), typeof(ProductNameComparer));
        }
    }
}
