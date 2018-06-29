using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileServer.Common.Model;
using FileServer.Infrastucture.Repository.Interfaces;
using FileServer.Infrastucture.Repository.Repositories;


namespace FileServer.Presentation.WinSite
{
  public partial class Form1 : Form
  {
    IAlumnoRepository iAlumnoRepositori;
    public Form1()
    {
      InitializeComponent();
      iAlumnoRepositori = new AlumnoRepository();
    }
    // Versio Curs
    private void btn_Afegir_Click(object sender, EventArgs e)
    {
      var alumno = new Alumno();     

      iAlumnoRepositori.Add(alumno);
    }


    // Versio Sbf
    //private void btn_Afegir_Click(object sender, EventArgs e)
    //{
    //  try
    //  { 
    //    IAlumnoRepository iAlumno = new AlumnoRepository();
    //    Alumno regAlumno = new Alumno();

    //    regAlumno.idAlumno  = Convert.ToInt32(txtBox_CodiClient.Text);
    //    regAlumno.Nombre    = txtBox_Nom.Text;
    //    regAlumno.Apellidos = txtBox_Cognoms.Text;
    //    regAlumno.Dni       = txtBox_Dni.Text;

    //    iAlumno.Add(regAlumno);

    //    MessageBox.Show ("Registro insertado!");
    //  }
    //  catch (Exception ex)
    //  {
    //    Console.WriteLine(ex.Message);
    //  }
    //}
  }
}
