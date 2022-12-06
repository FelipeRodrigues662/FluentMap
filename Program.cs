using Microsoft.EntityFrameworkCore;
using System;
using VendaDeCarrosFluentMap.DataContext;
using VendaDeCarrosFluentMap.Modelos;

namespace VendaDeCarrosFluentMap
{
    class Program
    {
        public static void Main()
        {
            using var context = new SistemaDeVendaDeCarrosDataContext();

            var model = new Modelo() { Nome = "Astra", Ano = 2013, Cor = "Preto" };
            var cliente = new Cliente() { Nome = "Gilmar", Telefone = 3475647 };
            var estadoDeVenda = new EstadoDeVenda() { Vendido = true, Cliente = cliente };
            var carros = new Carros() { Modelo = model, Valor = 70000.56, EstadoDeVenda = estadoDeVenda };

            context.Cars.Add(carros);
            context.SaveChanges();

            var cars = context
                .Cars
                .AsNoTracking()
                .Include(x => x.Modelo)
                .Include(x => x.EstadoDeVenda)
                .Include(x => x.EstadoDeVenda.Cliente)
                .OrderBy(x => x.Valor)
                .ToList();

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Id} - {car.EstadoDeVenda?.Cliente?.Nome} - {car.EstadoDeVenda?.Cliente?.Telefone} - {car.Modelo?.Nome} - {car.Modelo?.Ano} - {car.Modelo?.Cor} - {car.EstadoDeVenda?.Vendido} - {car.Valor}");
            }
        }
    }
}