using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeneticAlgorithmCourseWork.ChromosomeModel;
using GeneticAlgorithmCourseWork.Service;

namespace GeneticAlgorithmCourseWorkTests
{
    [TestClass]
    public class ExecuteServiceTest
    {
        [TestInitialize]
        public void initialize()
        {
            GeneticAlgorithmCourseWork.SpaceParam.SingleSpaceParams.getInstance(600, 300);
        }


        [TestMethod]
        public void RefactorBadGeneTest()
        {
            Gene gene = new Gene(12,33,22,1);
            ExecuteService.RefactorBadGene(gene);
        }
    }
}
