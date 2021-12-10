using System;
using System.Collections.Generic;
using Aplication;
using Domain.Model.Entities;
using Xunit;

namespace TestProject3
{
    public class UnitTest1
    {
        [Fact]
        public void ValidacionDeLoginUsuarioInexistente()
        {
            UsuarioService usuario = new UsuarioService();
            Usuario user = new Usuario();
            string correo = "correomisterioso1";
            string contra = "contrasena";
            object[] login = usuario.IniciarUsuario(correo, contra);
            Assert.Null(login);
        }

        [Fact]
        public void ComprobarIncorrectaLonguitudDNI()//TDD
        {
            UsuarioService user = new UsuarioService();
            string dni = "123456789";
            string Nombre = "nombre1";
            string Apellido = "apellidos1";
            string Direccion = "direccion1";
            string Email = "email1";
            string Telefono = "telefono1";
            string Contrasenia = "";

            int x = user.RegistrarUsuario(dni, Nombre, Apellido, Direccion, Email, Telefono, Contrasenia);
            Assert.Equal(x, -1);
        }


        [Fact]
        public void Registrar_Cliente_DNI_Incorrecto()
        {
            ClienteService customer = new ClienteService();
            bool resultado = customer.RegistrarCliente("123456789", "NOMBRE1", "APELLIDO1", "Av. Calle 123123", "email1", "telefono1", "");
            Assert.False(resultado);
        }

        [Fact]
        public void Registrar_Empleado()
        {
            EmpleadoService employee = new EmpleadoService();
            bool resultado = employee.RegistrarEmpleado("Secretario", "Administracion", "47383067", "PRUEBA03", "XD", "Av. XD", "emailNEW", "telefonoN", "3333");
            Assert.False(resultado);
        }
        [Fact]
        public void Registrar_Empleado_DNI_Incorrecto()//TDD
        {
            EmpleadoService employee = new EmpleadoService();
            Empleado person = new Empleado();

            bool resultado = employee.RegistrarEmpleado("Secretario", "Administracion", "123456789", "PRUEBA03", "XD", "Av. XD", "emailNEW", "telefonoN", "");
            Assert.False(resultado);
        }

        [Fact]
        public void Buscar_Estado_Pedido()
        {
            PedidoService obj = new PedidoService();

            bool resultado = obj.VerificarEstadoPedido(1);
            Assert.False(resultado);
        }
    }
}
