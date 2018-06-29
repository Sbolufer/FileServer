using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileServer.Infrastucture.Repository.Repositories;
using FileServer.Infrastucture.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileServer.Common.Model;

namespace FileServer.Infrastucture.Repository.Repositories.Tests
{
  [TestClass()]
  public class AlumnoRepositoryTests
  {
    IAlumnoRepository iAlumno = new AlumnoRepository();
    Alumno regAlumno = new Alumno
    {
      idAlumno = 1,
      Nombre = "Susanna",
      Apellidos = "Bolufer Felip",
      Dni = "12345678P"
    };
    [TestMethod()]
    public void AddTest()
    {
      Assert.IsTrue(iAlumno.Add(regAlumno).Equals(regAlumno));
    }
  }
}