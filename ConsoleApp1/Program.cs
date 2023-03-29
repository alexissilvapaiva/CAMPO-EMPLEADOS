using ConsoleApp1;

Auto onix = new Auto("ABC123", "Chevrolet", "Onix");

Auto focus = new Auto("ABC122", "Ford", "Focus");

Secretario romeo = new Secretario(1, "Romeo", "Santos", 0, "A", 25, 5, 115555555);

Secretario leonardo = new Secretario(1, "Leonardo", "Mattioli", 0, "A", 25, 5, 115555555);

Supervisor paula = new Supervisor(5, "Oficina", onix, romeo,"Paula", "Berghella", 0, "A", 18, 15, 115555555);

Supervisor luis = new Supervisor(5, "Oficina", focus, leonardo, "Luis", "Blanco", 0, "A", 25, 10, 115555555);

Empleado eduardo = new Empleado(paula, "Eduardo", 0, "Campagnola", 0, "A", 25, 1, 115555555);

Empleado miguel = new Empleado(paula, "Miguel", 2, "Romario", 0, "A", 90, 1, 115555555);



Console.WriteLine(eduardo.presentarse());
eduardo.cambiarSupervisor(luis);
eduardo.incrementarSalario();
miguel.incrementarSalario();

Console.WriteLine(paula.presentarse());
paula.cambiarSecretario(leonardo);
paula.cambiarAuto(focus);
paula.incrementarSalario();
paula.agregarEmpleado(eduardo);