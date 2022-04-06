using Command.Implementations;

Client client = new Client();

Chef chef = new Chef();

client.Cook(new Bread(chef));
client.Cook(new Latte(chef));
client.Cook(new Borshch(chef));

