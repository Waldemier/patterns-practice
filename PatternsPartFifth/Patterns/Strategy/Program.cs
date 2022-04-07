using Strategy.Implementation;

Organization organization = new Organization();
organization.ChangeStrategy(new BusTransportation());
organization.Transportate();
organization.ChangeStrategy(new CarTransportation());
organization.Transportate();
organization.ChangeStrategy(new PlainTransportation());
organization.Transportate();
organization.ChangeStrategy(new RailwayTransportation());
organization.Transportate();
