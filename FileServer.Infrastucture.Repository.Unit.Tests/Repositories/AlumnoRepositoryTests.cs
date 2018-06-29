using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileServer.Infrastucture.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using FileServer.Common.Model;
using FileServer.Infrastucture.Repository.Interfaces;

namespace FileServer.Infrastucture.Repository.Repositories.Tests
{  
  [TestClass()]
  public class AlumnoRepositoryTests
  {
    private IAlumnoRepository mockObject;
    Alumno regAlumno = new Alumno
    {
      idAlumno = 1,
      Nombre = "Susanna",
      Apellidos = "Bolufer Felip",
      Dni = "12345678P"
    };

    [TestInitialize]
    public void Setup()
    {
      var mock = new Mock<IAlumnoRepository>();      

      mock.Setup(x => x.Add(regAlumno)).Returns(regAlumno);
      
      mockObject = mock.Object;
    }


    [TestMethod()]
    public void AddTest()
    {
      var result = mockObject.Add(regAlumno);
      
      Assert.AreEqual(regAlumno,result);
      //Assert.Fail();
    }
  }
}