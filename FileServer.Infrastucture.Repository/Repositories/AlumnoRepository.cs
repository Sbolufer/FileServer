using System;
using System.IO;
using FileServer.Common.Model;
using FileServer.Infrastucture.Repository.Interfaces;
using Newtonsoft.Json;


namespace FileServer.Infrastucture.Repository.Repositories
{
  public class AlumnoRepository : IAlumnoRepository
  {
    public Alumno Add(Alumno alumno)
    {
      StreamWriter sw = null;
      try
      {
        string output = JsonConvert.SerializeObject(alumno);

        sw = new StreamWriter(@"c:\Sbf\json.txt",true);
        sw.WriteLine(output);

        alumno = JsonConvert.DeserializeObject<Alumno>(output);
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
        alumno.idAlumno = 0;
      }
      finally
      {
        if (sw != null) sw.Close();
      }

      return alumno;
    }
  }
}
