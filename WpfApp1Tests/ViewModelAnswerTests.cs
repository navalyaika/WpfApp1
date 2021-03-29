using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApp1;
using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp1.Tests
{
    [TestClass()]
    public class ViewModelAnswerTests
    {
        [TestMethod()]
        //нахождение значение линейной функции при x=y=a=b=c=1
        public void GetFTestlinear()
        {
            //arrange
            int expected=3;
            ViewModelAnswer answer = new ViewModelAnswer { A=1, B=1, C=1, X=1, Y=1};
            //act
            answer.GetF();
            int actual = answer.F;
          //asset
          Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        //нахождение значение квадратичной функции при x=y=a=b=1, c=10
        public void GetFTestquadratic()
        {
            //arrange
            int expected = 12;
            ViewModelAnswer answer = new ViewModelAnswer { A = 1, B = 1, C = 10, X = 1, Y = 1, TF=new ModelFunctionTypes { TypeFunction=TypeFunction.квадратичная.ToString() } };
            //act
            answer.GetF();
            int actual = answer.F;
            //asset
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        //нахождение значение кубической функции при x=y=a=b=1, c=100
        public void GetFTestcubic()
        {
            //arrange
            int expected = 102;
            ViewModelAnswer answer = new ViewModelAnswer { A = 1, B = 1, C = 100, X = 1, Y = 1, TF = new ModelFunctionTypes { TypeFunction = TypeFunction.кубическая.ToString() } };
            //act
            answer.GetF();
            int actual = answer.F;
            //asset
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        //нахождение значение функции 4-ой степени при x=y=a=b=1, c=1000
        public void GetFTestfourth_degreec()
        {
            //arrange
            int expected = 1002;
            ViewModelAnswer answer = new ViewModelAnswer { A = 1, B = 1, C = 1000, X = 1, Y = 1, TF = new ModelFunctionTypes { TypeFunction = TypeFunction.четвертой_степени.ToString() } };
            //act
            answer.GetF();
            int actual = answer.F;
            //asset
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        //нахождение значение функции 5-ой степени при x=y=a=b=1, c=10000
        public void GetFTestfifth_degreec()
        {
            //arrange
            int expected = 10002;
            ViewModelAnswer answer = new ViewModelAnswer { A = 1, B = 1, C = 10000, X = 1, Y = 1, TF = new ModelFunctionTypes { TypeFunction = TypeFunction.пятой_степени.ToString() } };
            //act
            answer.GetF();
            int actual = answer.F;
            //asset
            Assert.AreEqual(expected, actual);
        }
    }
}