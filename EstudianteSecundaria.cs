using System;
namespace exame{

class EstudianteSecundaria:Estudiante,IEstudiante{
    public int nive_cursado {set; get;}
    public int precioi_fijo{set;get;}

    public EstudianteSecundaria(int nive_cursado ,string nombre, string apellido,string nombre_institucion,int cedula):base(nombre, apellido, nombre_institucion,cedula){
        this.nive_cursado = nive_cursado;
        this.precioi_fijo = 20;
    }
     public void mostrar_datos(){
               Console.WriteLine("Nombre: "+nombre);
               Console.WriteLine("Apellido:"+ apellido);
               Console.WriteLine("Institucion: "+nombre_institucion);
               Console.WriteLine("Cedula: "+ cedula);
               Console.WriteLine("Nivel Estudiado: "+nive_cursado); 
    }
    public void matricula(){
        int operacion;
        operacion = nive_cursado * this.precioi_fijo;
        Console.WriteLine("La Matricula de un Estudiante de primaria");
        Console.WriteLine("Por "+nive_cursado+ " nivel se calculo un valor "+operacion);
    }
}
}
