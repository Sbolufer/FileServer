using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileServer.Common.Model
{
  public class Alumno
  {
    public int idAlumno { get; set; }
    public string Nombre { get; set; }
    public string Apellidos { get; set; }
    public string Dni { get; set; }

    public Alumno()
    {

    }
    public Alumno (int IdAlumno, string Nombre, string Apellidos, string Dni)
    {
      this.idAlumno   = IdAlumno;
      this.Nombre     = Nombre;
      this.Apellidos  = Apellidos;
      this.Dni        = Dni;
    }

    public override bool Equals(object obj)
    {
      var alumno = obj as Alumno;
      return alumno != null &&
             idAlumno == alumno.idAlumno &&
             Nombre == alumno.Nombre &&
             Apellidos == alumno.Apellidos &&
             Dni == alumno.Dni;
    }

    public override int GetHashCode()
    {
      var hashCode = -1833878610;
      hashCode = hashCode * -1521134295 + idAlumno.GetHashCode();
      hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nombre);
      hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Apellidos);
      hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Dni);
      return hashCode;
    }

    // override object.Equals
    //public override bool Equals(object obj)
    //{
    //  //       
    //  // See the full list of guidelines at
    //  //   http://go.microsoft.com/fwlink/?LinkID=85237  
    //  // and also the guidance for operator== at
    //  //   http://go.microsoft.com/fwlink/?LinkId=85238
    //  //

    //  if (obj == null || GetType() != obj.GetType())
    //  {
    //    return false;
    //  }

    //  // TODO: write your implementation of Equals() here
    //  //throw new NotImplementedException();
    //  return base.Equals(obj);
    //}

    //// override object.GetHashCode
    //public override int GetHashCode()
    //{
    //  // TODO: write your implementation of GetHashCode() here
    //  // throw new NotImplementedException();
    //  return base.GetHashCode();
    //}

    //public override bool Equals(object obj)
    //{
    //  var item = obj as Alumno;
    //  Boolean vRetorno = false;

    //  if (item != null) vRetorno = this.idAlumno.Equals(item.idAlumno);

    //  return vRetorno;
    //}



  }
}
