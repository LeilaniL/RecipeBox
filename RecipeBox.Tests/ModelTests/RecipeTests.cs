using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecipeBox.Models;
using System.Collections.Generic;
using System;

namespace RecipeBox.Tests
{
    [TestClass]
    public class RecipeTest : IDisposable
    {

        public RecipeTest()
        {
            DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=recipebox_test;";
        }

        public void Dispose()
        {
            Recipe.ClearAll();
        }

        [TestMethod]
        public void RecipeConstructor_CreatesInstanceOfRecipe_Recipe()
        {
            Recipe newRecipe = new Recipe("test Recipe", "banana", 5);
            Assert.AreEqual(typeof(Recipe), newRecipe.GetType());
        }

        // [TestMethod]
        // public void GetName_ReturnsName_String()
        // {
        //     //Arrange
        //     string name = "Test Category";
        //     Category newCategory = new Category(name);

        //     //Act
        //     string result = newCategory.GetName();

        //     //Assert
        //     Assert.AreEqual(name, result);
        // }



        // [TestMethod]
        // public void GetAll_ReturnsAllCategoryObjects_CategoryList()
        // {
        //     //Arrange
        //     string name01 = "Work";
        //     string name02 = "School";
        //     Category newCategory1 = new Category(name01);
        //     newCategory1.Save();
        //     Category newCategory2 = new Category(name02);
        //     newCategory2.Save();
        //     List<Category> newList = new List<Category> { newCategory1, newCategory2 };

        //     //Act
        //     List<Category> result = Category.GetAll();

        //     //Assert
        //     CollectionAssert.AreEqual(newList, result);
        // }

        // [TestMethod]
        // public void Find_ReturnsCategoryInDatabase_Category()
        // {
        //     //Arrange
        //     Category testCategory = new Category("Household chores");
        //     testCategory.Save();

        //     //Act
        //     Category foundCategory = Category.Find(testCategory.GetId());

        //     //Assert
        //     Assert.AreEqual(testCategory, foundCategory);
        // }

        // [TestMethod]
        // public void GetItems_ReturnsEmptyItemList_ItemList()
        // {
        //     //Arrange
        //     string name = "Work";
        //     Category newCategory = new Category(name);
        //     List<Item> newList = new List<Item> { };

        //     //Act
        //     List<Item> result = newCategory.GetItems();

        //     //Assert
        //     CollectionAssert.AreEqual(newList, result);
        // }

        // [TestMethod]
        // public void GetAll_CategoriesEmptyAtFirst_List()
        // {
        //     //Arrange, Act
        //     int result = Category.GetAll().Count;

        //     //Assert
        //     Assert.AreEqual(0, result);
        // }

        // [TestMethod]
        // public void Equals_ReturnsTrueIfNamesAreTheSame_Category()
        // {
        //     //Arrange, Act
        //     Category firstCategory = new Category("Household chores");
        //     Category secondCategory = new Category("Household chores");

        //     //Assert
        //     Assert.AreEqual(firstCategory, secondCategory);
        // }

        // [TestMethod]
        // public void Save_SavesCategoryToDatabase_CategoryList()
        // {
        //     //Arrange
        //     Category testCategory = new Category("Household chores");
        //     testCategory.Save();

        //     //Act
        //     List<Category> result = Category.GetAll();
        //     List<Category> testList = new List<Category> { testCategory };

        //     //Assert
        //     CollectionAssert.AreEqual(testList, result);
        // }

        // [TestMethod]
        // public void Save_DatabaseAssignsIdToCategory_Id()
        // {
        //     //Arrange
        //     Category testCategory = new Category("Household chores");
        //     testCategory.Save();

        //     //Act
        //     Category savedCategory = Category.GetAll()[0];

        //     int result = savedCategory.GetId();
        //     int testId = testCategory.GetId();

        //     //Assert
        //     Assert.AreEqual(testId, result);
        // }

        // [TestMethod]
        // public void GetItems_RetrievesAllItemsWithCategory_ItemList()
        // {
        //     //Arrange, Act
        //     Category testCategory = new Category("Household chores");
        //     testCategory.Save();
        //     Item firstItem = new Item("Mow the lawn");
        //     firstItem.Save();
        //     Item secondItem = new Item("Do the dishes");
        //     secondItem.Save();

        //     testCategory.AddItem(firstItem);
        //     testCategory.AddItem(secondItem);

        //     List<Item> testItemList = new List<Item> { firstItem, secondItem };
        //     List<Item> resultItemList = testCategory.GetItems();

        //     //Assert
        //     CollectionAssert.AreEqual(testItemList, resultItemList);
        // }

        // [TestMethod]
        // public void Delete_DeletesCategoryAssociationsFromDatabase_CategoryList()
        // {
        //     //Arrange
        //     Item testItem = new Item("Mow the lawn");
        //     testItem.Save();
        //     string testName = "Home stuff";
        //     Category testCategory = new Category(testName);
        //     testCategory.Save();

        //     //Act
        //     testCategory.AddItem(testItem);
        //     testCategory.Delete();
        //     List<Category> resultItemCategories = testItem.GetCategories();
        //     List<Category> testItemCategories = new List<Category> { };

        //     //Assert
        //     CollectionAssert.AreEqual(testItemCategories, resultItemCategories);
        // }

        // [TestMethod]
        // public void GetItems_ReturnsAllCategoryItems_ItemList()
        // {
        //     //Arrange
        //     Category testCategory = new Category("Household chores");
        //     testCategory.Save();
        //     Item testItem1 = new Item("Mow the lawn");
        //     testItem1.Save();
        //     Item testItem2 = new Item("Buy plane ticket");
        //     testItem2.Save();

        //     //Act
        //     testCategory.AddItem(testItem1);
        //     List<Item> savedItems = testCategory.GetItems();
        //     List<Item> testList = new List<Item> { testItem1 };

        //     //Assert
        //     CollectionAssert.AreEqual(testList, savedItems);
    }
}
