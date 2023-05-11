using Projekt_květen;
    bool exit = false;
    while (!exit)
    {
        Console.WriteLine("------------------------");
        Console.WriteLine("Vyberte akci");
        Console.WriteLine("------------------------");
        Console.WriteLine("1. Přidat produkt");
        Console.WriteLine("2. Odebrat produkt");
        Console.WriteLine("3. Zobrazit inventář");
        Console.WriteLine("4. Konec programu");
        string choice = Console.ReadLine();

        Inventory inventory = new Inventory();

        switch (choice)
        {
            case "1":
            inventory.PridatProdukt();            
                break;

            case "2":
            inventory.OdebratProdukt();
                break;

            case "3":
            Console.Clear();
            inventory.VypisInventar();
                break;

            case "4":
                exit = true;
                Console.WriteLine("Program byl ukončen.");
                break;

            default:
                Console.Clear();
                Console.WriteLine("Chyba: Neplatná volba.");
                break;
    }   }