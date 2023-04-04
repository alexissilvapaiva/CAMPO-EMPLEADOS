using ConsoleApp1;

Auto onix = new Auto("ABC123", "Chevrolet", "Onix");

Auto focus = new Auto("ABC122", "Ford", "Focus");

Secretario romeo = new Secretario(1, "Romeo", "Santos", 1, "A", 25, 5, 115555555);

Secretario leonardo = new Secretario(1, "Leonardo", "Mattioli", 2, "A", 25, 5, 115555555);

Supervisor paula = new Supervisor(5, "Oficina", onix, romeo, "Paula", "Berghella", 1, "A", 18, 15, 115555555);

Supervisor luis = new Supervisor(5, "Oficina", focus, leonardo, "Luis", "Blanco", 2, "A", 25, 10, 115555555);

Empleado eduardo = new Empleado(paula, "Eduardo", 7, "Campagnola", 1, "A", 25, 1, 115555555);

Empleado miguel = new Empleado(paula, "Miguel", 10, "Romario", 2, "A", 90, 1, 115555555);

Empleado marcelo = new Empleado(paula, "Marcelo", 0, "Ramirez", 3, "A", 80, 1, 115555555);


Console.WriteLine(eduardo.presentarse());
eduardo.incrementarSalario();
miguel.incrementarSalario();
marcelo.incrementarSalario();

Console.WriteLine(paula.presentarse());
paula.cambiarSecretario(leonardo);
paula.cambiarAuto(focus);
paula.incrementarSalario();
paula.mostrarEmpleados();
paula.sumatoriaSueldoEmpleados();

marcelo.cambiarSupervisor(luis);

paula.sumatoriaSueldoEmpleados();
luis.sumatoriaSueldoEmpleados();

marcelo.cambiarSupervisor(luis);
paula.mostrarEmpleados();
paula.quitarEmpleadoDeLista(marcelo);
paula.cambiarAuto(focus);
luis.mostrarEmpleados();
paula.agregarEmpleado(eduardo);
paula.cambiarSecretario(leonardo);
