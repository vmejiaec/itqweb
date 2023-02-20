namespace miweb;

public class Menu{
    public string tipo;

    public setTipoFin(){
        // Pongo el tipo del menú a Financiero
        this.tipo = "Financiero";
    }

    public setTipoInv(){
        this.tipo = "Inventario";
    }

    // Poner el tipo a Matrícula
    public setTipoMat(){
        this.tipo = "Matrícula";
    }
}