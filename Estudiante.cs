using System;

namespace exame{

    public class Estudiante{

    public string nombre {set; get;}
    public string apellido {set; get;}
    public string nombre_institucion {set;get;}
    public int cedula{set; get;}

    public Estudiante(string nombre, string apellido, string nombre_institucion, int cedula){
        this.nombre = nombre;
        this.apellido = apellido;
        this.nombre_institucion = nombre_institucion;
        this.cedula = cedula;
    }
}
}