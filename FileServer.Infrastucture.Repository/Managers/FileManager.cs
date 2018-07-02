using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;

namespace FileServer.Infrastucture.Repository.Managers
{
  public class FileManager
  {
    public static bool CreateFile(string Path)
    {
      bool Created = true;
      
      try
      {
        if (!File.Exists(Path))
           File.CreateText(Path);
      }
      catch (Exception ex)
      {
        Created = false;
      }         
      return Created;

      throw new 
        NotImplementedException("The method is not implemented yet");
    }
  }
}
