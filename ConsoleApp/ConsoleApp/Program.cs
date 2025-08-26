Console.WriteLine("Hello, World!");

Personas Persona = new Personas();
var Persona1 = new Personas();
Estudiantes Persona2 = new Estudiantes();
Personas Persona3 = Persona2;
Personas Persona4 = (Personas)Persona2;
Personas Persona5 = (Estudiantes)Persona2;

Persona.Id = 1;
Persona.Nombre = "Tralalero Tralala";
Persona.Estatura = 3.65m;
Persona.Vive = true;
Persona.Fecha = DateTime.Now;
Persona.Estado = new Estados() {Id = 1, Nombre = "XD"};
Persona.VideoJuegos = new List<VideoJuegos>();
Persona.VideoJuegos.Add(new VideoJuegos(){Id = 1, Nombre = "LOL"});
Persona.VideoJuegos.Add(new VideoJuegos(){Id = 2, Nombre = "GTA V"});

Console.WriteLine(Persona.Nombre);
Console.WriteLine(Persona.Estado.Nombre);

foreach(var elemento in Persona.VideoJuegos){
//Sirve para leer cada elemento de una lista, en este caso lista VideoJuegos
    Console.WriteLine(elemento.Nombre);
}

public class Personas {
    public int Id;
    public string? Nombre;
    public decimal Estatura;
    public bool Vive;
    public DateTime Fecha;
    public Estados? Estado;
    public List<VideoJuegos>? VideoJuegos;
}
public class Estados {
    public int Id;
    public string? Nombre;
    public List<Personas>? Personas;
}
public class VideoJuegos {
    public int Id;
    public string? Nombre;
}
public class Estudiantes : Personas {
    public string? Carnet;
}