using Visitor.Implementations;

ComputerPartsVisitor computerPartsVisitor = new ComputerPartsVisitor();

var mouse = new Mouse();

var keyboard = new Keyboard();

var monitor = new Visitor.Implementations.Monitor();

var computer = new Visitor.Implementations.Computer();

computer.AddPart(mouse);
computer.AddPart(keyboard);
computer.AddPart(monitor);

computer.Accept(computerPartsVisitor);

