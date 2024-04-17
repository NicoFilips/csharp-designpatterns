using NUnit.Framework;
using System;
using System.IO;
using FlyWeight;

namespace StructuralPatterns.test.Flyweight;

public class FlyWeightPatternTests
{
    private StringWriter _stringWriter;

    [SetUp]
    public void Setup()
    {
        _stringWriter = new StringWriter();
        Console.SetOut(_stringWriter);
    }

    [Test]
    public void TreeFactory_Creates_New_TreeType_When_Not_Present()
    {
        // Arrange
        var treeFactory = new TreeFactory();

        // Act
        treeFactory.HoleTreeType("Oak", "Green", "Rough");

        // Assert
        string output = _stringWriter.ToString().Trim();
        Assert.IsTrue(output.Contains("Treetype create: Oak-Green-Rough"));
    }

    [Test]
    public void TreeFactory_Returns_Existing_TreeType_When_Present()
    {
        // Arrange
        var treeFactory = new TreeFactory();
        var firstTreeType = treeFactory.HoleTreeType("Oak", "Green", "Rough");

        // Act
        var secondTreeType = treeFactory.HoleTreeType("Oak", "Green", "Rough");

        // Assert
        Assert.AreSame(firstTreeType, secondTreeType);
    }

    [Test]
    public void Tree_Draw_Paints_Correctly()
    {
        // Arrange
        var treeFactory = new TreeFactory();
        var treeType = treeFactory.HoleTreeType("Oak", "Green", "Rough");
        var tree = new Tree(1, 2, treeType);

        // Act
        tree.Draw();

        // Assert
        string output = _stringWriter.ToString().Trim();
        Assert.IsTrue(output.Contains("Tree of type Oak with the color Green and Texture Rough is located at (1,2)."));
    }

    [TearDown]
    public void TearDown()
    {
        _stringWriter.Close();
        Console.SetOut(Console.Out);
    }
}