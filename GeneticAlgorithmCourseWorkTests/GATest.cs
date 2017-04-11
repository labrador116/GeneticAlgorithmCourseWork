using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using GeneticAlgorithmCourseWork.Container;
using GeneticAlgorithmCourseWork.GeneticAlgorithm;
using System.Reflection;
using GeneticAlgorithmCourseWork.ChromosomeModel;
using FakeItEasy;

namespace GeneticAlgorithmCourseWorkTests
{
    [TestClass]
    public class GATest
    {
      
        [TestInitialize]
        public void initialize()
        {
            GeneticAlgorithmCourseWork.SpaceParam.SingleSpaceParams.getInstance(600, 300);
        }
        //Белый ящик
        [TestMethod]
        public void CheckToCheckToAreaTest()
        {
            Gene gene = new Gene(15,17,14,1);
            Chromosome chr = new Chromosome();
            chr.Container.Add(gene);
            
            bool actual = GA.CheckToArea(chr);
            Assert.AreEqual(actual, false);
        }

        //Белый ящик
        [TestMethod]
        public void CheckIntersectionTest()
        {
            Gene gene = new Gene(15, 17, 14, 1);
            Chromosome chr = new Chromosome();
            chr.Container.Add(gene);

            bool actual = GA.CheckIntersection(chr,1);
            Assert.AreEqual(actual, false);
        }

        //белый ящик
        [TestMethod]
        public void EvaluationOfFitenssFuncTest()
        {
            Gene gene = new Gene(15, 17, 14, 1);
            Chromosome chr = new Chromosome();
            chr.Container.Add(gene);

            Assert.IsInstanceOfType(GA.EvaluationOfFitenssFunc(chr), typeof(double));
        }

        //Черный ящик
        [TestMethod]
        public void GA_EncodeTest()
        {
            Gene gene = new Gene(15, 17, 14, 1);
            Chromosome chr = new Chromosome();
            chr.Container.Add(gene);
            GA.GA_Encode(chr);
        }

        //Черный ящик
        [TestMethod]
        public void GA_DecodeTest()
        {
            Gene gene = new Gene(15, 17, 14, 1);
            Chromosome chr = new Chromosome();
            chr.Container.Add(gene);
            GA.GA_Decode(chr);
        }

        //Черный ящик
        [TestMethod]
        public void CrossingOverTest()
        {
            Gene gene = new Gene(15, 17, 14, 1);
            Chromosome chr = new Chromosome();
            Chromosome chr2 = new Chromosome();
            chr.Container.Add(gene);
            chr2.Container.Add(gene);
        
            GA.CrossingOver(new System.Collections.Generic.List<Chromosome> { chr, chr2 });
        }
        //Черный ящик
        [TestMethod]
        public void MutationTest()
        {
            Gene gene = new Gene(15, 17, 14, 1);
            Chromosome chr = new Chromosome();
            chr.Container.Add(gene);
            GA.Mutation(chr);
        }
    }
}
