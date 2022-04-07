using State.Implementation;

Order order = new Order(new RegistrationStatus());
order.Registration();
order.Confirmation();
order.Payment();
order.Completing();
order.SendingToTheRecipient();
order.Receiving();