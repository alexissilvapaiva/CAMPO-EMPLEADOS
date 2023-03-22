using ConsoleApp1;

Auto onix = new Auto("ABC123", "Chevrolet", "Onix");

Auto focus = new Auto("ABC122", "Ford", "Focus");

Secretario romeo = new Secretario("Romeo", "Santos", 0, "A", 25, 5, 115555555);

Secretario leonardo = new Secretario("Leonardo", "Mattioli", 0, "A", 25, 5, 115555555);

Supervisor paula = new Supervisor("Oficina", onix, romeo,"Paula", "Berghella", 0, "A", 18, 15, 115555555);

Supervisor luis = new Supervisor("Oficina", focus, leonardo, "Luis", "Blanco", 0, "A", 25, 10, 115555555);

Empleado eduardo = new Empleado(paula, "Eduardo", "Campagnola", 0, "A", 25, 1, 115555555);


Console.WriteLine(eduardo.presentarse());
eduardo.cambiarSupervisor(luis);
eduardo.incrementarSalario();

Console.WriteLine(paula.presentarse());
paula.cambiarSecretario(leonardo);
paula.cambiarAuto(focus);
paula.incrementarSalario();