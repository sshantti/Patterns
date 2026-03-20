using Creational_1;

Console.WriteLine("=== Заказ от фабрики Alpha (Audi, Volvo, Abrams) ===");
AbstractTransportFactory alphaFactory = new AlphaFactory();
TransportClient client1 = new TransportClient(alphaFactory);
client1.ShowGarage();

Console.WriteLine("=== Заказ от фабрики Beta (Honda, Man, Merkava) ===");
AbstractTransportFactory betaFactory = new BetaFactory();
TransportClient client2 = new TransportClient(betaFactory);
client2.ShowGarage();

Console.WriteLine("=== Заказ от фабрики Gamma (Tesla, Scania, Tiger) ===");
AbstractTransportFactory gammaFactory = new GammaFactory();
TransportClient client3 = new TransportClient(gammaFactory);
client3.ShowGarage();

Console.ReadLine();