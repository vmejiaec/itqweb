using miweb;
namespace miweb;

// Clase ventana
public class Ventana{
  public int Id ;
  public string Name;

  public int Doble(){
    Id = 2 * Id;
    return Id;
  }

  public Ventana(){
    Id = 1;
    Name = "Ventana vacía";
  }

  public Ventana(int Id , string Name){
    this.Id = Id;
    this.Name = Name;
  }
}

