using Projekt_květen;
bool exit = false;
Inventory inventory = new Inventory();
while (!exit)
    {
        Console.WriteLine("------------------------");
        Console.WriteLine("Vyberte akci pomocí kliknutí čísla na klávesnici");
        Console.WriteLine("------------------------");
        Console.WriteLine("1. Přidat produkt");
        Console.WriteLine("2. Odebrat produkt");
        Console.WriteLine("3. Zobrazit inventář");
        Console.WriteLine("4. Konec programu");
        ConsoleKeyInfo vyber = Console.ReadKey();    
        //case jsem použil protože jsem si o něm zjistil informace jak ho použít a zdá se mi že se na vybírání v "menu" hodí
        switch (vyber.Key)
        {
            //pridani
            case ConsoleKey.D1:
            case ConsoleKey.NumPad1:
            Console.Clear();
            inventory.PridatProdukt();            
                break;
            //odebrani
            case ConsoleKey.D2: 
            case ConsoleKey.NumPad2:
            Console.Clear();
            inventory.OdebratProdukt();
            Console.Clear();
            inventory.VypisInventar(); //vypada to zbytecne ale diky tomuhle uživatel nebude muset zbytečně klikat 3 aby se ujistil že se produkt odebral
                break;
            //inventar
            case ConsoleKey.D3: 
            case ConsoleKey.NumPad3:
            Console.Clear();
            inventory.VypisInventar();
                break;
            //konec
            case ConsoleKey.D4: 
            case ConsoleKey.NumPad4:
                exit = true;
                Console.Clear();
                Console.WriteLine("Program byl ukončen :)");
                break;
            //chyba
            default: //použito kdyby uživatel zadal jiné znaky něž 1, 2, 3, 4 
                Console.Clear();
                Console.WriteLine("Neplatná volba");
                break;
        }
}       