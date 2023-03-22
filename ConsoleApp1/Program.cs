using ConsoleApp1;

Supervisor paula = new Supervisor("Paula", "Berghella", 0, "A", 18, 500000000, 115555555);

Supervisor luis = new Supervisor("Luis", "Blanco", 0, "A", 25, 10, 115555555);

Empleado eduardo = new Empleado(paula, "Eduardo", "Campagnola", 0, "A", 25, 1, 115555555);

paula.incrementarSalario();
Console.WriteLine(paula.presentarse());
Console.WriteLine(eduardo.mostrarSupervisor());
eduardo.cambiarSupervisor(luis);
Console.WriteLine(eduardo.mostrarSupervisor());