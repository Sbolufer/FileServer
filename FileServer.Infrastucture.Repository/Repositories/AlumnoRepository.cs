using System;
using System.Configuration;
using System.IO;
using FileServer.Common.Model;
using FileServer.Infrastucture.Repository.Interfaces;
using FileServer.Infrastucture.Repository.Managers;
using Newtonsoft.Json;


namespace FileServer.Infrastucture.Repository.Repositories
{
  public class AlumnoRepository : IAlumnoRepository
  {
  
    string path = ConfigurationSettings.AppSettings.Get("Path");

    public Alumno Add(Alumno alumno)
    {
      StreamWriter sw = null;     
      string output = null;

      try
      {
        if (!FileManager.CreateFile(path));

        output = JsonConvert.SerializeObject(alumno);

        // Codi antic        
        //sw = new StreamWriter(@"c:\Sbf\json.txt",true);
        sw = new StreamWriter(path, true);
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
