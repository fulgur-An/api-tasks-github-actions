using TaskApi.Repositories;
using TaskApi.Models;
using FluentAssertions;
namespace TaskApi.Tests.Repositories;

public class InMemoryTaskRepositoryTests
{
    private readonly InMemoryTaskRepository _repo;
    public InMemoryTaskRepositoryTests()
    {
        _repo = new();
    }

    // [Fact]
    // public void Add_TareaValida_AsignaIdYRetornaTarea()
    // {
    //     //Arrange        
    //     var tarea = new TaskItem
    //     {
    //         Title = "Comprar Guitarra",
    //         Description = "Comprar Guitarra para ser Feliz"
    //     };
    //     //Act
    //     var resultado = _repo.Add(tarea);
    //     //Arrange
    //     resultado.Id.Should().BeGreaterThan(0);
    //     resultado.Title.Should().Be("Comprar Guitarra");
    // }

    // [Fact]
    // public void Add_TareaValida_AumentaElConteoDeTareas()
    // {
        //Arrange
    //     var tarea = new TaskItem
    //     {
    //         Title = "Comprar Guitarra",
    //         Description = "Comprar Guitarra para ser Feliz"
    //     };
    //     var conteoInicial = _repo.GetAll().Count();
    //     //Act
    //     _repo.Add(tarea);
    //     var conteoFinal = _repo.GetAll().Count();
    //     //Arrange
    //     conteoFinal.Should().Be(conteoInicial + 1);
    // }

    // //GetAll
    // [Fact]
    // public void GetAll_RepositorioVacio_RetornaColeccionVacia()
    // {
    //     //Arrange
    //     //Act
    //     var resultado = _repo.GetAll();
    //     //Assert
    //     resultado.Should().BeEmpty();
    // }

    // //prueba unitaria que cuando hagan 2 tareas se regresene sas tareas
    // [Fact]
    // public void GetAll_DosTareasAgregadas_RetornaColeccionConDosTareas()
    // {
    //     //Arrange
    //     var tarea1 = new TaskItem
    //     {
    //         Title = "Comprar Guitarra",
    //         Description = "Comprar Guitarra para ser Feliz"
    //     };
    //     var tarea2 = new TaskItem
    //     {
    //         Title = "Comprar Piano",
    //         Description = "Comprar Piano para ser Feliz"
    //     };
    //     _repo.Add(tarea1);
    //     _repo.Add(tarea2);
    //     //Act
    //     var resultado = _repo.GetAll();
    //     //Assert
    //     resultado.Should().HaveCount(2);
    // }

    // //getById
    // [Fact]
    // public void GetById_TareaExistente_RetornaTarea()
    // {
    //     //Arrange
    //     var tarea = new TaskItem
    //     {
    //         Title = "Comprar Guitarra",
    //         Description = "Comprar Guitarra para ser Feliz"
    //     };
    //     var tareaAgregada = _repo.Add(tarea);
    //     //Act
    //     var resultado = _repo.GetById(tareaAgregada.Id);
    //     //Assert
    //     resultado.Should().NotBeNull();
    //     resultado.Id.Should().Be(tareaAgregada.Id);
    // }

    // //prueba unitaria para una tarea que no existe
    // [Fact]
    // public void GetById_TareaNoExistente_RetornaNull()
    // {
    //     //Arrange
    //     //Act
    //     var resultado = _repo.GetById(999);
    //     //Assert
    //     resultado.Should().BeNull();
    // }

    // [Fact]
    // public void Update_TareaExistente_ActualizaPropiedades()
    // {
    //     //Arrange
    //     var tarea = new TaskItem
    //     {
    //         Title = "Comprar Guitarra",
    //         Description = "Comprar Guitarra para ser Feliz"
    //     };
    //     var tareaAgregada = _repo.Add(tarea);
    //     var tareaActualizada = new TaskItem
    //     {
    //         Title = "Comprar Guitarra Eléctrica",
    //         Description = "Comprar Guitarra Eléctrica para ser Más Feliz",
    //         IsCompleted = true
    //     };
    //     //Act
    //     var resultado = _repo.Update(tareaAgregada.Id, tareaActualizada);
    //     //Assert
    //     resultado.Should().NotBeNull();
    //     resultado.Title.Should().Be("Comprar Guitarra Eléctrica");
    //     resultado.Description.Should().Be("Comprar Guitarra Eléctrica para ser Más Feliz");
    //     resultado.IsCompleted.Should().BeTrue();
    // }

    // //actualizar elemento que no existe
    // [Fact]
    // public void Update_TareaNoExistente_RetornaNull()
    // {
    //     //Arrange
    //     var tareaActualizada = new TaskItem
    //     {
    //         Title = "Comprar Guitarra Eléctrica",
    //         Description = "Comprar Guitarra Eléctrica para ser Más Feliz",
    //         IsCompleted = true
    //     };
    //     //Act
    //     var resultado = _repo.Update(999, tareaActualizada);
    //     //Assert
    //     resultado.Should().BeNull();
    // }

    // //Delete
    // [Fact]
    // public void Delete_TareaExistente_EliminaTarea()
    // {
    //     //Arrange
    //     var tarea = new TaskItem
    //     {
    //         Title = "Comprar Guitarra",
    //         Description = "Comprar Guitarra para ser Feliz"
    //     };
    //     var tareaAgregada = _repo.Add(tarea);
    //     //Act
    //     var resultado = _repo.Delete(tareaAgregada.Id);
    //     //Assert
    //     resultado.Should().BeTrue();
    //     _repo.GetById(tareaAgregada.Id).Should().BeNull();
    // }

    // [Fact]
    // public void Delete_TareaNoExistente_RetornaFalse()
    // {
    //     //Arrange
    //     //Act
    //     var resultado = _repo.Delete(999);
    //     //Assert
    //     resultado.Should().BeFalse();
    // }
}