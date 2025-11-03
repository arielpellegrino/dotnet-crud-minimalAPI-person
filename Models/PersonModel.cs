namespace Person.Models;

//Clase Pessoa
public class PersonModel{
    public Guid Id { get; init; }
    public string Name { get; private set; }
    
    public void ChangeName(string name) {
        Name = name;
    }

    public void SetInactive() {
        Name = "desativado";
    }

    //Método construtor
    public PersonModel(string name) {
        Name = name;
        Id = Guid.NewGuid();
    }

    
    
}