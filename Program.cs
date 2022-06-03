
namespace exame{

    class Program{

        public static void Main(String[] args){
            EstudiantePrimaria estudiante_primaria = new EstudiantePrimaria(5,"Jonathan","Sol","Fe_y_alegria",7856767);
            estudiante_primaria.mostrar_datos();
            estudiante_primaria.matricula();
            
            EstudianteSecundaria estudianteSecundaria = new EstudianteSecundaria(7,"pepe","Hermandez","Manta",7856767);
            estudianteSecundaria.mostrar_datos();
            estudianteSecundaria.matricula();

            EstudianteUniversitario estudianteUniversitario = new EstudianteUniversitario(12,200,"Jose","lopez","Fe_y_alegria",7856767);
            estudianteUniversitario.mostrar_datos();
            estudianteUniversitario.matricula();

        }
    }
}