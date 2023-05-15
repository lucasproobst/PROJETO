using Data.Context;
using Domain.Entities;

var db = new MeuContexto();

// Create people
Console.WriteLine("Inserting a new person");
var person = new Person { Id = 1, Nome = "João da Silva", Idade = DateTime.Now };
db.Add(person);
db.SaveChanges();